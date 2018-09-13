#pragma once
#include "Main.h"
#include "Scene.h"

class Menu : public Scene
{
public:
	Menu();
	~Menu();

	virtual void Initialize();
	virtual void Update();
	virtual void Draw(char** map);
	virtual int ChangeScene();
	virtual void release();
};

