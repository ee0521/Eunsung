#include "GameManager.h"

GameManager* gameManager;

void main(void)
{
	// 게임 매니저 생성 및 무한 루프.
	gameManager = new GameManager();
	gameManager->Initialize();
	while (true)
	{
		if (gameManager->Update() == false)
			break;
	}
	gameManager->Release();
	delete gameManager;
}