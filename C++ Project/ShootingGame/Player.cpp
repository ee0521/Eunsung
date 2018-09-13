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
	// 총알 미리 생성.
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
	// 총알 그리기.
	for (int i = 0; i<PLAYER_BULLET_MAX; i++)
	{
		if (playerBullet[i].fire == true)
		{
			map[playerBullet[i].y][playerBullet[i].x - 1] = '-';
			map[playerBullet[i].y][playerBullet[i].x + 0] = '>';

			// 좌표 이동.
			playerBullet[i].x++;

			// X가 끝좌표보다 커지면, 초기화.
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
	// 플레이어 키입력 조작.
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
	// 플레이어와 위치 비교.
	if ((y - 1) <= enemy->GetY() && (y + 1) >= enemy->GetY() &&
		(x <= enemy->GetX() + 2 && (x + 3) >= enemy->GetX() - 2))
		return true;
	return false;
}

bool Player::ClashEnemyAndBullet(Enemy* enemy)
{
	// 발사된 총알들을 적과 위치 비교.
	for (int i = 0; i<PLAYER_BULLET_MAX; i++)
	{
		if (playerBullet[i].fire == true &&  
			playerBullet[i].y == enemy->GetY() && //동적 할당은 포인터로 접근
			(playerBullet[i].x >= (enemy->GetX() - 1)) && (playerBullet[i].x <= (enemy->GetX() + 1))) 
		{
			enemy->Reset(); 
			playerBullet[i].fire = false;
			return true;
		}
	}
	return false;
}