﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

namespace CLANG_WINDOWS_10
{
    public partial class Form1 : Form
    {
        string folderPath;
        //path to clang = C:\Program Files\LLVM\bin\clang.exe
        string clang_file_default_path = @"C:\Program Files\LLVM\bin\clang.exe";
        string clang_file_default_path_x86 = @"C:\Program Files (x86)\LLVM\bin\clang.exe";

        string clang_folder_default_path_x86 = @"C:\Program Files (x86)\LLVM\bin\";
        string clang_folder_default_path = @"C:\Program Files\LLVM\bin\";

        string clang_folder_exist_x86;
        string clang_folder_exist;
        string clang_file_exist_x86;
        string clang_file_exist;
        string clang_main_folder = @"C:\\Program Files\\LLVM";

        string strCmdText;
        string current_File_c = @"main.c";
        string current_File_cpp = @"main.cpp";
        string current_File_a = @"a.exe";
        string current_File_main = @"main.exe";
        string m1 = "COMPILING";

        //C:\Program Files\LLVM
        public Form1()
        {
            InitializeComponent();
            //get folder name from start program/form
            //folderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            folderPath = Application.ExecutablePath;
            label4.Text = folderPath; // WORK FOLDER PRINT
            clang_file_exist_x86 = ""; clang_file_exist = "";
            //FileInfo clang_info = new FileInfo(clang_file_default_path_x86);
            // clang_folder_default_path = clang_info.DirectoryName;
            clang_file_exist_x86 = Path.GetFullPath(clang_file_default_path_x86);
            clang_file_exist = Path.GetFullPath(clang_file_default_path);

            MaximizeBox = false;

            if (File.Exists(clang_file_default_path) || File.Exists(clang_file_default_path_x86))
            {
                label1.BackColor = System.Drawing.Color.DarkGreen;
                label1.ForeColor = System.Drawing.Color.Orange;
                label1.Text = "CLANG IS INSTALLED AND READY FOR WORK"
                    + "\n\nIF PROGRAM FREEZE JUST CLOSE AND START AGAIN";
                //System.Environment.SetEnvironmentVariable("PATH", clang_folder_default_path);
            }
            else
            {
                button1.Enabled = false; button2.Enabled = false;
                button3.Enabled = false;
                label1.BackColor = System.Drawing.Color.Black;
                label1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "ERROR !!! CLANG NOT INSTALLED !!!! "
                    + "READ HELP\nAND INSTALL CLANG COMPILER !!! "
                    + "AFTER INSTALL,\nCLOSE THIS PROGRAMM AND TRY AGAIN !!!";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.BackColor = System.Drawing.Color.DarkGreen;
            label4.ForeColor = System.Drawing.Color.Orange;
        }

        private void button1_Click(object sender, EventArgs e)
        {       // BUTTON OPEN FOLDER IN COMMAND PROMPT
            string strCmdText = "/K dir";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void button3_Click(object sender, EventArgs e)
        {   // BUTTON RUN PROJECT
            string strCmdText;
            string current_File_main = @"main.exe";

            if (File.Exists(current_File_main))
            {
                strCmdText = "/K main.exe";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }
            else
            {
                strCmdText = "/K echo NO main.exe FILE TO RUN !!! ERROR !!! ";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {       // BUTTON OPEN CALCULATOR
          System.Diagnostics.Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {       // BUTTON OPEN NOTEPAD++
            //standart path to notepad++ >> C:\Program Files\Notepad++\notepad++.exe
            string strCmdText;
            string current_File_main = @"C:\Program Files\Notepad++\notepad++.exe";

            if (File.Exists(current_File_main)) 
            {
                if (File.Exists(current_File_c))
                {
                  System.Diagnostics.Process.Start(@"C:\Program Files\Notepad++\notepad++.exe", "main.c");
                }
                else
                    if (File.Exists(current_File_cpp))
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files\Notepad++\notepad++.exe", "main.cpp");
                }
                else
                {
                    strCmdText = "/K echo NO main.cpp OR main.c FILE TO OPEN OPEN NOTEPAD++ with new empty file";
                    System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                    System.Diagnostics.Process.Start(@"C:\Program Files\Notepad++\notepad++.exe", "");
                }

            }
            else
            {
                strCmdText = "/K echo NOTEPAD++ IS NOT INSTALLED !!! ERROR !!! ";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {       // BUTTON HELP
            var form2 = new Form2();
            form2.Show();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //label3.Text = "IMPORTANT !!! COPY AND PAST THIS EXE FILE";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {       // BUTTON COMPILE
            bool flag_both_files_EXIST = false;
           
            
            if (File.Exists(current_File_main))
            {
                strCmdText = "/C del main.exe";
                System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);

                strCmdText = "/C del a.exe";
                System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
            }

            while (File.Exists(current_File_main))
            {
               
            }

            if (File.Exists(current_File_c) && File.Exists(current_File_cpp))
            {
                flag_both_files_EXIST = true;
            }
            else
            {   if (File.Exists(current_File_c))
                  {
                    label1.BackColor = System.Drawing.Color.DarkGreen;
                    label1.ForeColor = System.Drawing.Color.Orange;
                    label1.Text = "CLANG IS INSTALLED AND READY FOR WORK"
                        + "\nIF PROGRAM FREEZE JUST CLOSE AND START AGAIN\n"
                        +"FILE main.c IS FOUND";
                   }
                
                if (File.Exists(current_File_cpp))
                {
                    label1.BackColor = System.Drawing.Color.DarkGreen;
                    label1.ForeColor = System.Drawing.Color.Orange;
                    label1.Text = "CLANG IS INSTALLED AND READY FOR WORK"
                        + "\nIF PROGRAM FREEZE JUST CLOSE AND START AGAIN\n"
                        + "FILE main.cpp IS FOUND";
                }

            }

            if (File.Exists(current_File_c) && flag_both_files_EXIST == false)
            {

                if (checkBox1.Checked)
                {
                    strCmdText = "/K clang.exe main.c"; // /K
                    System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
                }
                else
                {
                    strCmdText = "/C clang.exe main.c"; // /K
                    System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
                }

                while (!File.Exists(current_File_a))
                { }

                if (File.Exists(current_File_a))
                {
                    strCmdText = "/C ren a.exe main.exe";  // /K
                    System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
                }

                while (!File.Exists(current_File_main))
                { }

                if (File.Exists(current_File_main))
                {
                    strCmdText = "/K main.exe";
                    System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
                }
            }
            else
            if (File.Exists(current_File_cpp) && flag_both_files_EXIST == false)
            {


                if (checkBox1.Checked)
                {
                    strCmdText = "/K clang.exe main.cpp"; // /K
                    System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
                }
                else
                {
                    strCmdText = "/C clang.exe main.cpp"; // /K
                    System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
                }

                while (!File.Exists(current_File_a))
                { }

                if (File.Exists(current_File_a))
                {
                    strCmdText = "/C ren a.exe main.exe";
                    System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
                }

                while (!File.Exists(current_File_main))
                { }

                if (File.Exists(current_File_main))
                {
                    strCmdText = "/K main.exe";
                    System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);
                }
            }
            else
                if (flag_both_files_EXIST == true)
                 {
                   label1.BackColor = System.Drawing.Color.Black;
                     label1.ForeColor = System.Drawing.Color.Red;
                     label1.Text = "!!! ERROR !!! BOTH FILES main.c AND main.cpp EXIST\n"
                         + "REMOVE OR RENAME ONE OF THEM TO USE OTHER FOR COMPILING";
                    
                  }
            else
            {
                strCmdText = "/K echo !!! ERROR !!! NO main.cpp FILE TO COMPILE";
                System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);

                strCmdText = "/K echo !!! ERROR !!! NO main.c FILE TO COMPILE";
                System.Diagnostics.Process.Start(@"CMD.exe", strCmdText);

                // if (File.Exists(current_File_c))  // IF FILE IS MAIN.C
                // { 
                // }     // END IF FILE IS MAIN.C
                //  else
                //  if (File.Exists(current_File_cpp))  // IF FILE IS MAIN.Cpp
                //  {

                // }     // END IF FILE IS MAIN.Cpp




            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    private void button7_Click(object sender, EventArgs e)
    {		 // BUTTON WINDOWS FILE EXPLORER
      //string strCmdText = "/K dir";
      System.Diagnostics.Process.Start(@"Explorer.exe", ".\\");
    }

  }
}
