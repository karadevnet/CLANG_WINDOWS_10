# CLANG_WINDOWS_10
CLANG MANAGER for WIN 10
HELP USING C# PROGRAM FOR CLANG PROJECT CREATOR v 1.1 - WWW.KARADEV.NET

04.2025 - completely new program code with new features and improved program design.
there is also a new way to install the clang compiler. follow the description below or watch the video from this one's tube that shows how to use the compiler in vs code /vs code /.

after installing clang in the shown way, you can directly use the program to compile your projects in both the C language and the C++ language. the program automatically recognizes whether one of the two files exists in the project directory or only one or only the other or neither one nor the other.

follow the messages in the field where you will see information about what is happening during the development of your project.

Important !!!! you must add the global path of the installed clang to the Windows system variables.

the video describes how to do it, I use a command through the cmd terminal after running it as an administrator
========================================================================

install VS CODE from https://code.visualstudio.com/

load this clip from youtube :

How to setup Clang on windows and VS code for C/C++ CLANG PROGRAMING
https://www.youtube.com/watch?v=5OSO8IRlyXc

install Download
the installer: msys2-x86_64-20250221.exe
OR LAST VERSION from site
https://www.msys2.org/

1) Download and install mysys2 and run automatically from install program.
2) Open mysys2 terminal and type the the following to install the clang package:

enter command : pacman -S mingw-w64-x86_64-clang
enter command : pacman -S mingw-w64-x86_64-clang-tools-extra

after install all of it from terminal

3) add Clang path to the System variable : path

4) run cmd like admin / right click on cmd icon select : run as administrator
5) command to add path to global
6) enter command : setx /M PATH "C:\msys64\mingw64\bin"
	global path will be added to environments
7) can star using in project folder CLANG_WINDOWS_10
8) files for test can download from same git hub link / repository

====================================================================
=========================================================================

FOR using same mysys2 way in VS CODE watch video and do what is in shown in it
in VS CODE install : Code Runner

in Code Runner settings in section search type exe in end to : @ext:formulahendry.code-runner exe

Code-runner: Executor Map
Set the executor of each language. click on edit in settings.jason

in this line for C++ compiling:

"cpp": "cd $dir && clang++ $fileName -o $fileNameWithoutExt && $dir$fileNameWithoutExt",

change g++ with clang++ to can use clang++ compiler from global path "C:\msys64\mingw64\bin"

in this line for C compiling:

"c": "cd $dir && clang $fileName -o $fileNameWithoutExt && $dir$fileNameWithoutExt",

in Code Runner settings in section search type terminal in end to : @ext:formulahendry.code-runner terminal

@ext:formulahendry.code-runner terminal

check box : Code-runner: Run In Terminal to checked

make new cpp file : hello.cpp and add code from file from main.cpp

=========================================================================

the way of use
A. copy and paste this program directly into a new directory where you will create a new project.
B. install the CLANG compiler on your working machine / computer /, not forgetting to check GLOBAL PATHS DURING COMPILER INSTALLATION !!!! a menu will appear in which the compiler installer will ask you whether to set a global path to the compiler for all users of the particular computer system. ANSWER YES!!!!
C. with the program NOTEPAD++ or other text editor, make and save a file named main.c .
D. run the clang compiler and press the COMPILE CLANG PROJECT button.
E. if all is well, a file named main.c should appear in your new project directory and automatically start your first C program.

1. THE PROGRAM WORKS ON ALL VERSIONS OF WINDOWS FROM XP TO WINDOWS 11
2. THE PROGRAM DOES NOT CONTAIN ANY ADVERTISING MATERIALS AND/OR OTHER COMPUTER SYSTEM-DAMAGED CODES OR COMMANDS
3. the text on the buttons shows which button is for what - what command the button executes in the program
4. RUN PROJECT button - the button will look for the already compiled file / main.exe /. if the file exists it will run it in the windows DOS console with the program you wrote and compiled previously.
5. RUN NOTEPAD++ button - the button will search for the NOTEPAD++ program startup file in its installed directory in C:\Program Files\Notepad++. if the program is installed correctly, the button will start the program directly, if you have not installed the program, an error message window will appear.
6. button COMPILE CLANG PROJECT - this button will compile your text file /main.c/ into an executable /main.exe/ file so that you can run the program in the Windows DOS console.
7. RUN CALCULATOR button - this button will start the standard calculator in Windows
8. HELP button - this button displays a new window with text content of the help information for the program
9. button OPEN PROJECT FOLDER - this button will open a DOS console directly in the directory of your project.
10. 11.11.22 - Bulgaria, 9000, Varna DC
<img src="/clang_1win_2025ss.jpg" alt="Alt text" title="Optional title">

<img src="/clang_win_2025ss.jpg" alt="Alt text" title="Optional title">
