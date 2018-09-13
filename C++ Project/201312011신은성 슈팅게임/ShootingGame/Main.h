#pragma once
#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <conio.h>
#include <Windows.h>
#include <ctime>
#include <list>

using namespace std;

#define MAP_SIZE_X		80
#define MAP_SIZE_Y		25

#define MENU			0
#define GAME_PLAY		1
#define GAME_END		2
#define PROGRAM_EXIT	3

#define ENEMY_COUNT		3	// 최초 적 생성 수.
#define ADD_SCODE		30	// 적 처치시 점수.