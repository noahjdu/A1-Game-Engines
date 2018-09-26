#pragma once

#include "LibSettings.h"
#include "Greeter.h"

#ifdef __cplusplus
extern "C"
{
#endif
	LIB_API int Add(int first, int second);
	LIB_API char* SayHello();
	LIB_API void SetPosition(Vector3 position);
	LIB_API Vector3 GetPos();
#ifdef __cplusplus
}
#endif