#include "Player.h"

Player::Player()
{
	Initialize();
}

Player::~Player()
{
}

void Player::Initialize()
{
	// �Ѿ� �̸� ����.
	for (int i = 0; i<PLAYER_BULLET_MAX; i++)
	{
		playerBullet[i].x = 0;
		playerBullet[i].y = 0;
		playerBullet[i].fire = false;
	}

	x = 0;
	y = MAP_SIZE_Y / 2;
}

void Player::Draw(char** map)
{
	DrawBullet(map);
	DrawPlayer(map);
}

void Player::DrawBullet(char** map)
{
	// �Ѿ� �׸���.
	for (int i = 0; i<PLAYER_BULLET_MAX; i++)
	{
		if (playerBullet[i].fire == true)
		{
			map[playerBullet[i].y][playerBullet[i].x - 1] = '-';
			map[playerBullet[i].y][playerBullet[i].x + 0] = '>';

			// ��ǥ �̵�.
			playerBullet[i].x++;

			// X�� ����ǥ���� Ŀ����, �ʱ�ȭ.
			if (playerBullet[i].x > MAP_SIZE_X - 1)
			{
				playerBullet[i].fire = false;
			}
		}
	}
}

void Player::DrawPlayer(char** map)
{
	map[y - 1][x + 0] = '-';
	map[y - 1][x + 1] = '>';
	map[y + 0][x + 1] = '>';
	map[y + 0][x + 2] = '>';
	map[y + 0][x + 3] = '>';
	map[y + 1][x + 0] = '-';
	map[y + 1][x + 1] = '>';
}

void Player::KeyControl(void)
{
	// �÷��̾� Ű�Է� ����.
	char pressKey;

	if (_kbhit())
	{
		pressKey = _getch();
		switch (pressKey)
		{
		case 72:
			y--;
			if (y < 1)
				y = 1;
			break;
		case 75:
			x--;
			if (x < 0)
			x = 0;
			break;
		case 77:
			x++;
			if (x > MAP_SIZE_X - 5)
			x = MAP_SIZE_X - 5;
			break;
		case 80:
			y++;
			if (y > MAP_SIZE_Y - 3)
				y = MAP_SIZE_Y - 3;
			break;
		case 32:
			for (int i = 0; i<PLAYER_BULLET_MAX; i++)
			{
				if (playerBullet[i].fire == false)
				{
					playerBullet[i].fire = true;
					playerBullet[i].x = x + 5;
					playerBullet[i].y = y;
					break;
				}
			}
			break;
		}
	}
}

bool Player::ClashEnemyAndPlayer(Enemy* enemy)
{
	// �÷��̾�� ��ġ ��.
	if ((y - 1) <= enemy->GetY() && (y + 1) >= enemy->GetY() &&
		(x <= enemy->GetX() + 2 && (x + 3) >= enemy->GetX() - 2))
		return true;
	return false;
}

bool Player::ClashEnemyAndBullet(Enemy* enemy)
{
	// �߻�� �Ѿ˵��� ���� ��ġ ��.
	for (int i = 0; i<PLAYER_BULLET_MAX; i++)
	{
		if (playerBullet[i].fire == true &&  
			playerBullet[i].y == enemy->GetY() && //���� �Ҵ��� �����ͷ� ����
			(playerBullet[i].x >= (enemy->GetX() - 1)) && (playerBullet[i].x <= (enemy->GetX() + 1))) 
		{
			enemy->Reset(); 
			playerBullet[i].fire = false;
			return true;
		}
	}
	return false;
}