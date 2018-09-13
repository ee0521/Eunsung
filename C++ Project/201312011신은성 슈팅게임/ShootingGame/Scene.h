#pragma once

class Scene
{
public:
	Scene();
	~Scene();
	virtual void Initialize() {}				// 씬 초기화.
	virtual void Update() {}					// 씬 업데이트.
	virtual void Draw(char** map) {}			// 씬 그리기.
	virtual int ChangeScene() { return -1; }		// 씬 바꾸기.
	virtual void release() {}					// 씬 데이터 삭제.
};

