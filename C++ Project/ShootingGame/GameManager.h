#pragma once
#include "Main.h"
#include <vector>
#include "Scene.h"
#include "Menu.h"
#include "GamePlayScene.h"
#include "GameEndScene.h"
#include "Player.h"
#include "Enemy.h"

class GameManager
{
public:
	GameManager();
	~GameManager();

	// Main framework.
	void Initialize(void);							// �ʱ�ȭ.
	bool Update(void);								// ���� �� �ý��� ����.
	void Release(void);								// ���� ���� �� �޸� ����.
	
	void Remove(Enemy* enemy);						// �� ����.

	static int score;								// ���� ���ھ�.
private:
	char** map;										// ���� ��.
	
	vector<Scene*> sceneList;						// ���ӽ���, ������, �������� �� ����Ʈ.
	int sceneIndex;									// ���ӽ���, ������, �������Ḧ ���� ����.
	
	Player player;									// �� ĳ����.
	list<Enemy*> enemyList;							// �� ����Ʈ.

	int nBufferIndex;								// ���� �ڵ鰪.
	HANDLE hBuffer[2];								// ���� �ڵ�.

	// Game framework.
	void CreateEnemy(int count);					// ���ʿ� �� ����.
	void ClearScreen(void);							// ȭ�� û��.
	void GameMain(void);							// ���� ���� ����.
	void RemoveCursor(void);						// Ŀ�� ������ ����.

	// Double buffering(�ø���) ����.
	void CreateBuffer(void);						// �ø��ο� �ʿ��� ���� ���� �� ���� ����.
	void BufferWrite(int x, int y, char *string);	// ���� ����.
	void Flipping(void);							// �ø��� - ����(ȭ��) ��ü.
	void BufferClear(void);							// ���� ����.
};

