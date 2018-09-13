#pragma once
//#include "Main.h"
#include "GameManager.h"
#include "Scene.h"
class GamePlayScene : public Scene
{
public:
	GamePlayScene();
	~GamePlayScene();

	virtual void Initialize();
	virtual void Update();
	virtual void Draw(char** map);
	virtual int ChangeScene();
	virtual void release();

private:
	char num[10] = { '0','1','2','3','4','5','6','7','8','9' };
	char computeScoreText(int &currentScore, int spaceNumber); // ÀÚ¸´¼ö °è»ê.
};

