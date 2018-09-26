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

void SetPosition(Vector3 position)
{


	greeter.SetPosition( position);
	//greeter.setGreeting(std::string(greeting));
}

Vector3 GetPos()
{
	return greeter.GetPos();
}
