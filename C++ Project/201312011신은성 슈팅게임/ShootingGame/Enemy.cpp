#include "Enemy.h"

Enemy::Enemy()
{
	x = MAP_SIZE_X - 3;
	y = (rand() % 20) + 2;
}

Enemy::~Enemy()
{
}

int Enemy::GetX(void) { return x; }
int Enemy::GetY(void) { return y; }

void Enemy::Move(void)
{
	x--;
	if (x<2)
	{
		x = MAP_SIZE_X - 3;
		y = (rand() % 20) + 2;
	}
}

void Enemy::Draw(char** map)
{
	map[y][x - 2] = '<';
	map[y][x - 1] = '-';
	map[y][x] = '0';
	map[y][x + 1] = '-';
	map[y][x + 2] = '>';
}

void Enemy::Reset(void)
{
	x = MAP_SIZE_X - 3;
	y = (rand() % 20) + 2;
}