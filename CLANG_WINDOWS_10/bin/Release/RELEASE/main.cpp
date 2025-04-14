// copy and past C#_CLANG_STUDENT_PROGRAMMING.exe
// in same folder to can compile projects
// in folder can have one main.c OR !!! main.cpp
// file. program will tell you if have some errors,
// have both files and/or have no files to compile
#include <iostream>
using namespace std;

unsigned char variable_aa = 10;
unsigned char variable_bb = 76;
unsigned char variable_cc = 0;

int main()
{
	variable_cc = variable_aa + variable_bb;
	 
	 // PRINT ASCII LETTER V
	cout << "\nRESULT = " << variable_cc;
	// PRINT sum of two variables = 86
	cout << "\nRESULT = " << static_cast<int>(variable_cc);
	cout << "\n\n";
	
  // use this line for pause program before exit
   cout << "\nPRESS < ENTER > KEY TO FINISH\n\n";
  getchar();
  return 0;
}
