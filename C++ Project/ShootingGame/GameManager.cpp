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
	// 지정된 상수만큼 맵 생성.
	map = new char*[MAP_SIZE_Y];
	for (int index = 0; index < MAP_SIZE_Y; ++index)
	{
		map[index] = new char[MAP_SIZE_X];
		memset(map[index], 0, MAP_SIZE_X + 1);
	}
	
	// 커서를 없앤다.
	RemoveCursor();

	// 플리핑을 위한 버퍼 생성.
	CreateBuffer();

	// 난수 시드 초기화.
	srand((unsigned int)time(NULL));

	// 씬 만들기 (메뉴, 게임플레이, 게임엔드).
	sceneList.push_back(new Menu());
	sceneList.push_back(new GamePlayScene());
	sceneList.push_back(new GameEndScene());

	// 적생성.
	CreateEnemy(ENEMY_COUNT);
}

bool GameManager::Update(void)
{
	ClearScreen();

	if (sceneIndex == GAME_PLAY)
	{
		// 게임 로직.
		GameMain();
	}

	// 해당 씬을 업데이트 및 그린다.
	sceneList[sceneIndex]->Update();
	sceneList[sceneIndex]->Draw(map);

	// 실제 렌더링 코드.
	for (int y = 0; y < MAP_SIZE_Y; ++y)
	{
		BufferWrite(0, y, map[y]);
	}

	// 백버퍼와 화면 교환.
	Flipping();

	// 씬을 바꾸라는 정보를 전달 받으면, 씬을 바꾼다.
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
	// 적 모두 삭제.
	for (list<Enemy*>::iterator enemy = enemyList.begin(); enemy != enemyList.end(); ++enemy)
		delete *enemy;

	// 맵 정보 삭제.
	delete[] map;

	// 씬 삭제.
	for (vector<Scene*>::iterator scene = sceneList.begin(); scene != sceneList.end(); ++scene)
	{
		(*scene)->release();
		delete *scene;
	}

	// 플리핑에 사용했던 버퍼 삭제.
	CloseHandle(hBuffer[0]);
	CloseHandle(hBuffer[1]);
}

void GameManager::CreateEnemy(int count)
{
	// 적을 해당 Count 만큼 생성 한다.
	for (int index = 0; index < count; ++index)
	{
		Enemy* enemy = new Enemy();
		enemyList.push_back(enemy);
	}
}

void GameManager::ClearScreen(void)
{
	// 전에 사용했던 경로를 지워 중복 방지
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
	// 플레이어 움직임 컨트롤.
	player.KeyControl();
	player.Draw(map);

	for (list<Enemy*>::iterator enemy = enemyList.begin(); enemy != enemyList.end(); ++enemy)
	{
		// 적의 AI.
		(*enemy)->Move();
		(*enemy)->Draw(map);
		
		// 충돌 검사 - 플레이어와 적.
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

		// 충돌 검사 - 플레이어의 총알과 적.
		if (player.ClashEnemyAndBullet(*enemy))
 			score += ADD_SCODE;
	}
}

void GameManager::RemoveCursor()
{
	// 커서 지우기(깜박임).
	CONSOLE_CURSOR_INFO curInfo;
	GetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &curInfo);
	curInfo.bVisible = 0; // bVisible 멤버 변경
	SetConsoleCursorInfo(GetStdHandle(STD_OUTPUT_HANDLE), &curInfo); // 변경값 적용
}

void GameManager::Remove(Enemy* enemy)
{
	// 해당 적을 삭제.
	enemyList.remove(enemy);
	delete enemy;
}

// API를 이용한 소스.
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