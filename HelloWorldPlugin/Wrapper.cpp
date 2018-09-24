#include "Wrapper.h"

Greeter greeter;

int Add(int first, int second)
{
	return greeter.add(first, second);
}

char* SayHello()
{
	return greeter.greet();
}

void SetGreeting(char* greeting)
{
	greeter.setGreeting(std::string(greeting));
}
