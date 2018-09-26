#pragma once

#include "LibSettings.h"
#include <string>

struct Vector3
{
	float x = 0; 
	float y = 0; 
	float z = 0; 
};

class LIB_API Greeter
{
public:
	char* greet();

	void SetPosition(Vector3 X);

	/*float GetPositionX();
	float GetPositionY();
	float GetPositionZ();*/
	Vector3 GetPos();
	

	int add(int, int);

private:
	std::string* greeting;
	Vector3 pos; 
	int value;
};