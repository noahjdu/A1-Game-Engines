#include "Greeter.h"

char* Greeter::greet()
{
	return (char*) greeting->c_str();
}

void Greeter::SetPosition(Vector3 position)
{

	pos = position;

	/*delete greeting;
	greeting = new std::string(g);*/
}
float Greeter::GetPositionX()
{
	return pos.x;
}
float Greeter::GetPositionY()
{
	return pos.y;
}
float Greeter::GetPositionZ()
{
	return pos.z;
}



int Greeter::add(int first, int second)
{
	return first + second;
}