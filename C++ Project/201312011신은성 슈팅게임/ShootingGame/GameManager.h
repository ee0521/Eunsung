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
	void Initialize(void);							// 초기화.
	bool Update(void);								// 게임 및 시스템 로직.
	void Release(void);								// 게임 종료 및 메모리 해제.
	
	void Remove(Enemy* enemy);						// 적 제거.

	static int score;								// 현재 스코어.
private:
	char** map;										// 게임 맵.
	
	vector<Scene*> sceneList;						// 게임시작, 게임중, 게임종료 씬 리스트.
	int sceneIndex;									// 게임시작, 게임중, 게임종료를 위한 변수.
	
	Player player;									// 내 캐릭터.
	list<Enemy*> enemyList;							// 적 리스트.

	int nBufferIndex;								// 버퍼 핸들값.
	HANDLE hBuffer[2];								// 버퍼 핸들.

	// Game framework.
	void CreateEnemy(int count);					// 최초에 적 생성.
	void ClearScreen(void);							// 화면 청소.
	void GameMain(void);							// 게임 실제 로직.
	void RemoveCursor(void);						// 커서 깜박임 제거.

	// Double buffering(플리핑) 관련.
	void CreateBuffer(void);						// 플리핑에 필요한 버퍼 생성 및 변수 적용.
	void BufferWrite(int x, int y, char *string);	// 버퍼 쓰기.
	void Flipping(void);							// 플리핑 - 버퍼(화면) 교체.
	void BufferClear(void);							// 버퍼 리셋.
};

