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
	void Move(void);				// �� ������.
	virtual void Draw(char** map);	// �� �׸���.
	void Reset(void);				// ���� ��ġ�� �ʱ�ȭ.
private:
	int x;							// ���� ���� ��ġ - X ��ǥ.
	int y;							// ���� ���� ��ġ - Y ��ǥ.
};

