#include "GameManager.h"
#pragma once

int GameManager::score = 0;

GameManager::GameManager()
{
	sceneIndex = MENU;
}

GameManager::~GameManager()
{
}

void GameManager::Initialize()
{
	// ������ �����ŭ �� ����.
	map = new char*[MAP_SIZE_Y];
	for (int index = 0; index < MAP_SIZE_Y; ++index)
	{
		map[index] = new char[MAP_SIZE_X];
		memset(map[index], 0, MAP_SIZE_X + 1);
	}
	
	// Ŀ���� ���ش�.
	RemoveCursor();

	// �ø����� ���� ���� ����.
	CreateBuffer();

	// ���� �õ� �ʱ�ȭ.
	srand((unsigned int)time(NULL));

	// �� ����� (�޴�, �����÷���, ���ӿ���).
	sceneList.push_back(new Menu());
	sceneList.push_back(new GamePlayScene());
	sceneList.push_back(new GameEndScene());

	// ������.
	CreateEnemy(ENEMY_COUNT);
}

bool GameManager::Update(void)
{
	ClearScreen();

	if (sceneIndex == GAME_PLAY)
	{
		// ���� ����.
		GameMain();
	}

	// �ش� ���� ������Ʈ �� �׸���.
	sceneList[sceneIndex]->Update();
	sceneList[sceneIndex]->Draw(map);

	// ���� ������ �ڵ�.
	for (int y = 0; y < MAP_SIZE_Y; ++y)
	{
		BufferWrite(0, y, map[y]);
	}

	// ����ۿ� ȭ�� ��ȯ.
	Flipping();

	// ���� �ٲٶ�� ������ ���� ������, ���� �ٲ۴�.
	int requestChangeSceneNumber = sceneList[sceneIndex]->ChangeScene();
	if (requestChangeSceneNumber == PROGRAM_EXIT)
	{
		return false;
	}
	else if (requestChangeSceneNumber >= MENU)
	{
		sceneList[sceneIndex]->release();
		sceneIndex = requestChangeSceneNumber;
		sceneList[sceneIndex]->Initialize();
	}

	return true;
}

void GameManager::Release(void)
{
	// �� ��� ����.
	for (list<Enemy*>::iterator enemy = enemyList.begin(); enemy != enemyList.end(); ++enemy)
		delete *enemy;

	// �� ���� ����.
	delete[] map;

	// �� ����.
	for (vector<Scene*>::iterator scene = sceneList.begin(); scene != sceneList.end(); ++scene)
	{
		(*scene)->release();
		delete *scene;
	}

	// �ø��ο� ����ߴ� ���� ����.
	CloseHandle(hBuffer[0]);
	CloseHandle(hBuffer[1]);
}

void GameManager::CreateEnemy(int count)
{
	// ���� �ش� Count ��ŭ ���� �Ѵ�.
	for (int index = 0; index < count; ++index)
	{
		Enemy* enemy = new Enemy();
		enemyList.push_back(enemy);
	}
}

void GameManager::ClearScreen(void)
{
	// ���� ����ߴ� ��θ� ���� �ߺ� ����
	for (int y = 0; y<MAP_SIZE_Y; y++)
	{
		for (int x = 0; x<MAP_SIZE_X; x++)
		{
			map[y][x] = ' ';
		}
	}
	BufferClear();
}

void GameManager::GameMain(void)
{
	// �÷��̾� ������ ��Ʈ��.
	player.KeyControl();
	player.Draw(map);

	for (list<Enemy*>::iterator enemy = enemyList.begin(); enemy != enemyList.end(); ++enemy)
	{
		// ���� AI.
		(*enemy)->Move();
		(*enemy)->Draw(map);
		
		// �浹 �˻� - �÷��̾�� ��.
		if (player.ClashEnemyAndPlayer(*enemy))
		{
			sceneList[sceneIndex]->release();
			player.Initialize();
			for (list<Enemy*>::iterator enemy = enemyList.begin(); enemy != enemyList.end(); ++enemy)
				(*enemy)->Reset();
			sceneIndex = GAME_END;
			sceneList[sceneIndex]->Initialize();
			break;
		}

		// �浹 �˻� - �÷��̾��� �Ѿ˰� ��.
		if (player.ClashEnemyAndBullet(*enemy))
 			score += ADD_SCODE;
	}
}

void GameManager::RemoveCursor()
{
	// Ŀ�� �����(������).
	CONSOLE_CURSOR_INFO curInfo;
	GetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &curInfo);
	curInfo.bVisible = 0; // bVisible ��� ����
	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &curInfo); // ���氪 ����
}

void GameManager::Remove(Enemy* enemy)
{
	// �ش� ���� ����.
	enemyList.remove(enemy);
	delete enemy;
}

// API�� �̿��� �ҽ�.
void GameManager::CreateBuffer()
{ 
	CONSOLE_CURSOR_INFO cci;
	COORD size = { 80, 25 };
	SMALL_RECT rect;

	rect.Left = 0;
	rect.Right = 80 - 1;
	rect.Top = 0;
	rect.Bottom = 25 - 1;

	hBuffer[0] = CreateConsoleScreenBuffer(GENERIC_READ | GENERIC_WRITE, 0, NULL, CONSOLE_TEXTMODE_BUFFER, NULL);
	SetConsoleScreenBufferSize(hBuffer[0], size);
	SetConsoleWindowInfo(hBuffer[0], TRUE, &rect);
	hBuffer[1] = CreateConsoleScreenBuffer(GENERIC_READ | GENERIC_WRITE, 0, NULL, CONSOLE_TEXTMODE_BUFFER, NULL);
	SetConsoleScreenBufferSize(hBuffer[1], size);
	SetConsoleWindowInfo(hBuffer[1], TRUE, &rect);

	cci.dwSize = 1;
	cci.bVisible = FALSE;
	SetConsoleCursorInfo(hBuffer[0], &cci);
	SetConsoleCursorInfo(hBuffer[1], &cci);
}

void GameManager::BufferWrite(int x, int y, char *string)
{
	COORD CursorPosition = { x, y };
	DWORD dw;
	SetConsoleCursorPosition(hBuffer[nBufferIndex], CursorPosition);
	WriteFile(hBuffer[nBufferIndex], string, strlen(string), &dw, NULL);
}

void GameManager::Flipping()
{
	Sleep(33);
	SetConsoleActiveScreenBuffer(hBuffer[nBufferIndex]);
	nBufferIndex = !nBufferIndex;
}

void GameManager::BufferClear()
{
	COORD Coor = { 0, 0 };
	DWORD dw;
	FillConsoleOutputCharacter(hBuffer[nBufferIndex], ' ', 80 * 25, Coor, &dw);
}