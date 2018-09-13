#include "Main.h"
#include "Object.h"
#include "Enemy.h"
#pragma once
#define PLAYER_BULLET_MAX 20

typedef struct _bullet
{
	int x;		// �Ѿ� ��ġ - X ��ǥ.
	int y;		// �Ѿ� ��ġ - Y ��ǥ.
	bool fire;	// �Ѿ� ����� �� ���� ������ ���� ��뿩��.
} BULLET;

class Player : public Object
{
public:
	Player();
	~Player();

	virtual void Draw(char** map);				// �÷��̾� �׸���.
	void Initialize(void);						// ������ �ʱ�ȭ.
	void KeyControl(void);						// ����.
	bool ClashEnemyAndPlayer(Enemy* enemy);		// �÷��̾�� ���� �浹 �˻�.
	bool ClashEnemyAndBullet(Enemy* enemy);		// �Ѿ˰� ���� �浹 �˻�.
private:
	int x;										// �÷��̾� ��ġ - X ��ǥ.
	int y;										// �÷��̾� ��ġ - Y ��ǥ.
	BULLET playerBullet[PLAYER_BULLET_MAX];		// �Ѿ� ����ü �迭.

	void DrawBullet(char** map);				// �Ѿ� �׸���.
	void DrawPlayer(char** map);				// �÷��̾� �׸���.
};

