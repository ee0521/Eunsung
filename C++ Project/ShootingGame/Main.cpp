#include "GameManager.h"

GameManager* gameManager;

void main(void)
{
	// ���� �Ŵ��� ���� �� ���� ����.
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