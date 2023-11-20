#include <iostream>
//https://github.com/llvm/llvm-project
unsigned char c = 130; // 0 - 255 // 0xFF
unsigned char d = 10; // 0 - 255 // 0xFF
unsigned int e = 0; //	0 - 65535 // 0xFFF
unsigned int e2 = 10681; //	0 - 65535 // 0xFFF
unsigned int e3 = 31885; //	0 - 65535 // 0xFFF

unsigned long ee_result = 0;

using namespace std;
// unsigned int
// int
// double
// long
// long double

//use unsigned int value = c * d ;

// IF YOUR CODE HAVE An ERROR COMPILER WILL GIVE
// ERRROR MESSAGE !! LIKE EXAMPLE BELLOW
// AFTER SUCCESS COMPILING USE main.bat FILE
// TO START PROGRAM USING main.bat FILE WILL
// RUN PROGRAM WITH STAY OPEN CMD WINDOW
// TO SHOW RESULT OF PROGRAM

int main()
{
	cout << "\nget sum e = c * d\n";
	
	cout << "c = "; cout << c; cout << "\n";
	
	cout << "d = "; cout << d; cout << "\n";
  
	e = c * d; // <<< value DDD not registered !!!
	
	cout << "e = "; cout << e;
	
	cout << "\n"; cout << "\n";
	
	cout << "\nget multiply ee_result = e2 * e3\n";
	
	cout << "e2 = "; cout << e2; cout << "\n";
	
	cout << "e3 = "; cout << e3; cout << "\n";
	
	ee_result = e2 * e3;
	
	cout << "ee_result = "; cout << ee_result;
	
	cout << "\n"; cout << "\n";
	
	cout << "\nPRESS < ENTER > TO FINISH\n";
	
	// use this line for pause program before exit
	system("pause");
	
	// or use thise two lines to stay program open
	//int x, y;
    //std::cin >> x >> y;
	
  return 0;

} // END MAIN