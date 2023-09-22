/*
clang: warning: unable to find a Visual Studio installation; try running Clang from a developer command prompt [-Wmsvc-not-found]
main.c:5:10: fatal error: 'stdio.h' file not found
#include "stdio.h"
         ^~~~~~~~~
1 error generated.

D:\C#_clang_win10\CLANG_WINDOWS_10\bin\Release>
*/


#include <stdio.h>
//https://github.com/llvm/llvm-project
unsigned char c = 130; // 0 - 255 // 0xFF
unsigned char d = 10; // 0 - 255 // 0xFF
unsigned int e = 0; //	0 - 65535 // 0xFFF
unsigned int e2 = 10681; //	0 - 65535 // 0xFFF
unsigned int e3 = 31885; //	0 - 65535 // 0xFFF

unsigned long ee_result = 0;

// unsigned int
// int
// double
// long
// long double

//use unsigned int value = c * d ;

// IF YOUR CODE HAVE An ERROR COMPILER WILL GIVE
// ERRROR MESSAGE !! LIKE EXAMPLE BELLOW

int main()
{
	printf("\nget sum e = c * d\n");
	
	printf("c = "); printf("%d",c); printf("\n");
	
	printf("d = "); printf("%d",d); printf("\n");
  
	e = c * d; // <<< value DDD not registered !!!
	
	printf("e = "); printf("%d",e);
	
	printf("\n"); printf("\n");
	
	printf("\nget multiply ee_result = e2 * e3\n");
	
	printf("e2 = "); printf("%d",e2); printf("\n");
	
	printf("e3 = "); printf("%d",e3); printf("\n");
	
	ee_result = e2 * e3;
	
	printf("ee_result = "); printf("%ld",ee_result);
	
	printf("\n"); printf("\n");
	
	printf("\nPRESS < ENTER > TO FINISH\n");

	getchar();
	
} // END MAIN