// CMax.c

#include <stdio.h>
#include <assert.h>

int findmax(int x, int y, int z)
{
	int max = x;
	if (y > max)
		max = y;
	if (z > max)
		max = z;
	return max;
}

int main()
{
	assert(findmax(4, 3, 2) == 4);
	printf("Test 1 passed\n");
	assert(findmax(3, 4, 2) == 4);
	printf("Test 2 passed\n");
	assert(findmax(3, 2, 4) == 4);
	printf("Test 3 passed\n");
	assert(findmax(2, 4, 3) == 4);
	printf("Test 4 passed\n");
}