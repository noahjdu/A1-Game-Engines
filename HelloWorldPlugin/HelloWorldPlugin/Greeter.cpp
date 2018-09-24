#include "Greeter.h"

char* Greeter::greet()
{
	return (char*) greeting->c_str();
}

void Greeter::setGreeting(std::string g)
{
	delete greeting;
	greeting = new std::string(g);
}

int Greeter::add(int first, int second)
{
	return first + second;
}