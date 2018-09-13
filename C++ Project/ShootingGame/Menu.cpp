#include "Menu.h"

Menu::Menu()
{
}


Menu::~Menu()
{
}


void Menu::Initialize()
{

}
void Menu::Update()
{

}
void Menu::Draw(char** map)
{
	int posX = 0;
	int posY = 1;

	map[posY][posX + 1] = 'G';
	map[posY][posX + 2] = 'a';
	map[posY][posX + 3] = 'm';
	map[posY][posX + 4] = 'e';
	map[posY][posX + 5] = ' ';
	map[posY][posX + 6] = 'S';
	map[posY][posX + 7] = 't';
	map[posY][posX + 8] = 'a';
	map[posY][posX + 9] = 'r';
	map[posY][posX + 10] = 't';
	map[posY][posX + 11] = '?';
	map[posY][posX + 12] = '(';
	map[posY][posX + 13] = 'Y';
	map[posY][posX + 14] = '/';
	map[posY][posX + 15] = 'N';
	map[posY][posX + 16] = ')';
}

int Menu::ChangeScene()
{
	char pressKey;
	if (_kbhit())
	{
		pressKey = _getch();
		switch (pressKey)
		{
		case 'Y':
		case 'y':
			return GAME_PLAY;
		case 'N':
		case 'n':
			return PROGRAM_EXIT;
		}
	}

	return -1;
}

void Menu::release()
{

}