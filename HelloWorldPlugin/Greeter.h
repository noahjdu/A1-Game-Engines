#pragma once

#include "LibSettings.h"
#include <string>

class LIB_API Greeter
{
public:
	char* greet();

	void SetPosition(Vector3 position);
	float GetPositionX(); 
	float GetPositionY();
	float GetPositionZ();

	int add(int, int);

private:
	//std::string* greeting;
	vector3 pos;
	int value;
};