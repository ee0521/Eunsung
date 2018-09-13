#pragma once
class Object
{
public:
	Object();
	virtual ~Object();
	virtual void Draw(char** map) = 0;
};

