#include "GameEndScene.h"



GameEndScene::GameEndScene()
{
}


GameEndScene::~GameEndScene()
{
}

void GameEndScene::Initialize()
{

}
void GameEndScene::Update()
{

}
void GameEndScene::Draw(char** map)
{
	int posX = 0;
	int posY = 1;

	map[posY][posX + 1] = 'R';
	map[posY][posX + 2] = 'e';
	map[posY][posX + 3] = 'p';
	map[posY][posX + 4] = 'l';
	map[posY][posX + 5] = 'a';
	map[posY][posX + 6] = 'y';
	map[posY][posX + 7] = '?';
	map[posY][posX + 8] = '(';
	map[posY][posX + 9] = 'Y';
	map[posY][posX + 10] = '/';
	map[posY][posX + 11] = 'N';
	map[posY][posX + 12] = ')';
}
int GameEndScene::ChangeScene()
{
	// 키입력 받기.
	char pressKey;
	if (_kbhit())
	{
		pressKey = _getch();
		switch (pressKey)
		{
		case 'Y':
		case 'y':
			return GAME_PLAY;
		case 'N':
		case 'n':
			return PROGRAM_EXIT;
		}
	}

	return -1;
}

void GameEndScene::release()
{

}