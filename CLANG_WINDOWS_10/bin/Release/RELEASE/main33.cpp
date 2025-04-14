// copy and past C#_CLANG_STUDENT_PROGRAMMING.exe
// in same folder to can compile projects
// in folder can have one main.c OR !!! main.cpp
// file. program will tell you if have some errors,
// have both files and/or have no files to compile
#include <iostream>
#include <cstdlib> // For strtol()

using namespace std;

int main(int argc, char* argv[])
{
    if (argc < 3)
	{
		cout << "FROM CMD LINE ENTER NAME OF EXE FILE\nAND TWO NUMBERS BETWEEN 0 AND 255.\n";
		cout << "EXAMPLE : E:\\C#_CLANG_STUDENT_PROGRAMMING\\>main.exe <num1> <num2>\n\n";
        cout << "Usage like : " << argv[0] << " <num1> <num2>\n";
        return 1;
    }

    // Convert command-line arguments to integers safely
    char* end;
    long temp_a = strtol(argv[1], &end, 10);
    long temp_b = strtol(argv[2], &end, 10);

    /* // also work can be enabled to see what is answer from this check
	// Check if inputs are within valid range
    if (temp_a < 0 || temp_a > 255 || temp_b < 0 || temp_b > 255) {
        cout << "\nERROR: Input values must be between 0 and 255!\n";
        return 1;
    }
	*/
	
	// Check if inputs are within valid range and specify the wrong variable
	if (temp_a < 0 || temp_a > 255)
	{
		cout << "\nERROR: variable_aa (" << temp_a << ") is out of range!\nERROR: Must be between 0 and 255.\n";
		return 1;
	}

	if (temp_b < 0 || temp_b > 255)
	{
    cout << "\nERROR: variable_bb (" << temp_b << ") is out of range!\nERROR: Must be between 0 and 255.\n";
    return 1;
	}

    // Convert valid numbers to unsigned char
    unsigned char variable_aa = static_cast<unsigned char>(temp_a);
    unsigned char variable_bb = static_cast<unsigned char>(temp_b);

    // Perform sum safely using a larger type to avoid overflow
    unsigned int variable_cc = variable_aa + variable_bb;

    // Display calculation
    cout << "\nvariable_aa + variable_bb = variable_cc\n";
    cout << "SUM = " << static_cast<int>(variable_aa) << " + " << static_cast<int>(variable_bb);
    cout << "\nRESULT = " << variable_cc;

    // Pause before exit
    cout << "\nPRESS < ENTER > KEY TO FINISH\n\n";
    getchar();
    return 0;
}
