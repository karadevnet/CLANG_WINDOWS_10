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
	
	
  // use this line for pause program before exit
   cout << "\n\n... PRESS ANY KEY TO FINISH ...";
  getchar();
  return 0;
}
