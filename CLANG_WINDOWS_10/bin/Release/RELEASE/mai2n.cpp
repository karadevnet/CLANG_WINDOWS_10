// copy and past C#_CLANG_STUDENT_PROGRAMMING.exe
// in same folder to can compile projects
// in folder can have one main.c OR !!! main.cpp
// file. program will tell you if have some errors,
// have both files and/or have no files to compile
#include <iostream>
#include <cstdlib> // For atoi()

using namespace std;

int main(int argc, char* argv[])
{
    if (argc < 3) {
        cout << "Usage: " << argv[0] << " <num1> <num2>\n";
        return 1;
    }
	
	if(atoi(argv[1]) > 255)
	{	cout << "\nvariable_aa IS LARGER THEN 255 !!!\n";
		cout << "!!! ERROR !!! ENTERED VARIABLE IS LARGER THEN 255 !!!\n";
		cout << "RESULT IS NOT CORRECT !!!";
	}
	
	if(atoi(argv[2]) > 255)
	{
		cout << "\nvariable_bb IS LARGER THEN 255 !!!\n";
		cout << "\n!!! ERROR !!! ENTERED VARIABLE IS LARGER THEN 255 !!!\n";
		cout << "RESULT IS NOT CORRECT !!!";
	}

    // Convert command-line arguments to integers
    unsigned char variable_aa = static_cast<unsigned char>(atoi(argv[1]));
    unsigned char variable_bb = static_cast<unsigned char>(atoi(argv[2]));
    unsigned char variable_cc = variable_aa + variable_bb;
	
	
	
	cout << "\nvariable_aa + variable_bb = variable_cc\n";
	cout << "SUM = ";
	cout << static_cast<int>(variable_aa);
	cout << " + ";
	cout << static_cast<int>(variable_bb);
	cout << "\n";
    // Print the result
    cout << "\nRESULT = " << static_cast<int>(variable_cc);

    // Pause program before exit
    cout << "\nPRESS < ENTER > KEY TO FINISH\n\n";
    getchar();
    return 0;
}
