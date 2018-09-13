#include "Main.h"
#include "Object.h"
#include "Enemy.h"
#pragma once
#define PLAYER_BULLET_MAX 20

typedef struct _bullet
{
	int x;		// 총알 위치 - X 좌표.
	int y;		// 총알 위치 - Y 좌표.
	bool fire;	// 총알 재생성 및 개수 제한을 위한 사용여부.
} BULLET;

class Player : public Object
{
public:
	Player();
	~Player();

	virtual void Draw(char** map);				// 플레이어 그리기.
	void Initialize(void);						// 데이터 초기화.
	void KeyControl(void);						// 조작.
	bool ClashEnemyAndPlayer(Enemy* enemy);		// 플레이어와 적의 충돌 검사.
	bool ClashEnemyAndBullet(Enemy* enemy);		// 총알과 적의 충돌 검사.
private:
	int x;										// 플레이어 위치 - X 좌표.
	int y;										// 플레이어 위치 - Y 좌표.
	BULLET playerBullet[PLAYER_BULLET_MAX];		// 총알 구조체 배열.

	void DrawBullet(char** map);				// 총알 그리기.
	void DrawPlayer(char** map);				// 플레이어 그리기.
};

