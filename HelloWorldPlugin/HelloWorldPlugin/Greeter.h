#pragma once

#include "LibSettings.h"
#include <string>

class LIB_API Greeter
{
public:
	char* greet();

	void setGreeting(std::string);

	int add(int, int);

private:
	std::string* greeting;

	int value;
};