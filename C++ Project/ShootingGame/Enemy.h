#include "Main.h"
#include "Object.h"
#pragma once

class Enemy : public Object
{
public:
	Enemy();
	~Enemy();

	int GetX(void);			
	int GetY(void);			
	void Move(void);				// 적 움직임.
	virtual void Draw(char** map);	// 적 그리기.
	void Reset(void);				// 기존 위치로 초기화.
private:
	int x;							// 적의 현재 위치 - X 좌표.
	int y;							// 적의 현재 위치 - Y 좌표.
};

