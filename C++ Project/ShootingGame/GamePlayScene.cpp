#include "GamePlayScene.h"

GamePlayScene::GamePlayScene()
{
}


GamePlayScene::~GamePlayScene()
{
}

void GamePlayScene::Initialize()
{

}
void GamePlayScene::Update()
{
	
}

char GamePlayScene::computeScoreText(int &currentScore, int spaceNumber)
{
	// 점수를 자릿수마다 계산해서 문자열로 돌려줌.
	char ch = ' ';
	if (currentScore / spaceNumber > 0)
	{
		ch = num[currentScore / spaceNumber];
		currentScore = currentScore % spaceNumber;
	}
	return ch;
}

void GamePlayScene::Draw(char** map)
{
	// Score : 그리기.
	int posX = MAP_SIZE_X - 18;
	int posY = MAP_SIZE_Y - 1;

	map[posY][posX + 1] = 'S';
	map[posY][posX + 2] = 'c';
	map[posY][posX + 3] = 'o';
	map[posY][posX + 4] = 'r';
	map[posY][posX + 5] = 'e';
	map[posY][posX + 6] = ' ';
	map[posY][posX + 7] = ':';
	map[posY][posX + 8] = ' ';

	// 자릿수마다 점수 그리기.
	int currentScore = GameManager::score;
	char currentText = ' ';
	bool exist = false;
	currentText = computeScoreText(currentScore, 10000);
	map[posY][posX + 9] = currentText;

	exist = currentText != ' ';
	currentText = computeScoreText(currentScore, 1000);
	map[posY][posX + 10] = currentText == ' ' && exist == true ? '0' : currentText;

	exist = currentText != ' ';
	currentText = computeScoreText(currentScore, 100);
	map[posY][posX + 11] = currentText == ' ' && exist == true ? '0' : currentText;

	exist = currentText != ' ';
	currentText = computeScoreText(currentScore, 10);
	map[posY][posX + 12] = currentText == ' ' && exist == true ? '0' : currentText;
	map[posY][posX + 13] = num[0];
}

int GamePlayScene::ChangeScene()
{
	return -1;
}

void GamePlayScene::release()
{

}