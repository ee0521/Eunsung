#pragma once

class Scene
{
public:
	Scene();
	~Scene();
	virtual void Initialize() {}				// �� �ʱ�ȭ.
	virtual void Update() {}					// �� ������Ʈ.
	virtual void Draw(char** map) {}			// �� �׸���.
	virtual int ChangeScene() { return -1; }		// �� �ٲٱ�.
	virtual void release() {}					// �� ������ ����.
};

