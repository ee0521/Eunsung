#pragma once
#include "Main.h"
#include "Scene.h"
class GameEndScene : public Scene
{
public:
	GameEndScene();
	~GameEndScene();

	virtual void Initialize();
	virtual void Update();
	virtual void Draw(char** map);
	virtual int ChangeScene();
	virtual void release();
};

