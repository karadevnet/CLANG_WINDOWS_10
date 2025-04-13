using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__CLANG_MANAGER_WIN_10
{
    public partial class Form1 : Form
    {
        public static Form1 form1Instance;
        // public richTextBox1_main call from CMD_COMPILE cmd_compile;
        //public System.Windows.Forms.RichTextBox richTextBox1_main;
        public RichTextBox RichTextBoxInstance
        {  get { return richTextBox1; } }



        string path = @"C:\msys64\mingw64\bin";
        string exe_local_path = Application.ExecutablePath;
        string exe_path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        public Form1()
        {
            InitializeComponent();
            // Assign instance for external access
            form1Instance = this;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // call from outside class to access richTextBox1 in main form
            //form1Instance.richTextBox1 = richTextBox1;

            //label1.Text = "C++ CLANG MANAGER FOR WINDOWS 10\n";
            label1.Text = "";

            if (System.IO.Directory.Exists(path))
            {
                //label1.Text = "C++ CLANG MANAGER FOR WINDOWS 10\n";
                label1.Text += "CLANG FOLDER = " + path + "\nWORK FOLDER = " + exe_path;
                label1.BackColor = Color.LimeGreen;
            }
            else
            {
                label1.Font = new Font(label1.Font.FontFamily, 14);
                //label1.MaximumSize = new Size(490, 0);
                label1.ForeColor = Color.Yellow;
                label1.BackColor = Color.Red;
                label1.Text = "Path not found: " + path;
            }

            if (File.Exists(@"main.cpp"))
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.BackColor = Color.LimeGreen;
                label2.Text = "File found: main.cpp";
                //string path = @"C:\msys64\mingw64\bin";
                //string fileName = @"main.cpp";
                //string filePath = Path.Combine(path, fileName);
                //string command = "clang++ -o main.exe " + fileName;
                //System.Diagnostics.Process.Start("cmd.exe", "/K " + command);
            }
            else if (File.Exists(@"main.c"))
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.BackColor = Color.LimeGreen;
                label2.Text = "File found: main.c";
                //string path = @"C:\msys64\mingw64\bin";
                //string fileName = @"main.c";
                //string filePath = Path.Combine(path, fileName);
                //string command = "clang++ -o main.exe " + fileName;
                //System.Diagnostics.Process.Start("cmd.exe", "/K " + command);
            }
            else
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.ForeColor = Color.Yellow;
                label2.BackColor = Color.Red;
                label2.Text = "FILE NOT FOUND = main.cpp OR FILE = main.cpp";
                //MessageBox.Show("File not found: main.cpp");
            }

            if (File.Exists(@"main.c") && File.Exists(@"main.cpp"))
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                //label2.ForeColor = Color.Black;
                label2.BackColor = Color.Red;
                label2.Text = "FILE BOTH FOUND = main.cpp + main.c !!!!\n" +
                    "REMOVE OR RENAME ONE !!!";
                //MessageBox.Show("File not found: main.cpp");
               // button1.Enabled = false;
            }
            else if (!File.Exists(@"main.c") && !File.Exists(@"main.cpp"))
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.ForeColor = Color.Black;
                label2.BackColor = Color.Red;
                label2.Text = "FILE NOT FOUND = main.cpp OR FILE = main.cpp";
                //button1.Enabled = false;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"main.c") && File.Exists(@"main.cpp"))
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                //label2.ForeColor = Color.Black;
                label2.BackColor = Color.Red;
                label2.Text = "FILE BOTH FOUND = main.cpp + main.c !!!!\n" +
                    "REMOVE OR RENAME ONE !!!";
                //MessageBox.Show("File not found: main.cpp");
                //button1.Enabled = true;
                richTextBox1.AppendText("FILE BOTH FOUND = main.cpp + main.c !!!!\n" +
                    "REMOVE OR RENAME ONE !!!\n\n");
                richTextBox1.ScrollToCaret();
                return;
            }
            else if (!File.Exists(@"main.c") && !File.Exists(@"main.cpp"))
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.ForeColor = Color.Black;
                label2.BackColor = Color.Red;
                label2.Text = "FILE NOT FOUND = main.cpp OR FILE = main.cpp\nMAKE A NEW ONE main.cpp OR main.c !!!";
                // button1.Enabled = true;
                richTextBox1.AppendText("FILE BOTH NOT FOUND = main.cpp OR main.c !!!!\n" +
                    "MAKE A NEW ONE main.cpp OR main.c !!!\n\n");
                richTextBox1.ScrollToCaret();
                return;
            }


            button1.Enabled = false;
            timer1.Start();
            string CMD_command = "";

            if (File.Exists(@"main.exe"))
            {
                string command_delete_exe = "del main.exe";
                System.Diagnostics.Process.Start("cmd.exe", "/C " + command_delete_exe);
            }
            // wait for the file to be deleted
            while (File.Exists(@"main.exe"))
            {
                // wait for the file to be deleted
                System.Threading.Thread.Sleep(1000);
            }

            if (File.Exists(@"main.cpp"))
            {

                CMD_command = "clang++ -o main.exe main.cpp";
                //CMD_command = "dir";

                await CMD_COMPILE.ExecuteCommandAsync(CMD_command);
                //button1.Enabled = true;
            }
            else if (File.Exists(@"main.c"))
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.BackColor = Color.LimeGreen;
                label2.Text = "FOUND FILE = main.c AND COMPILING IS STARTED";
                //string path = @"C:\msys64\mingw64\bin";
                string fileName = @"main.c";
                //string filePath = Path.Combine(path, fileName);
                string command_compiler = "clang -o main.exe " + fileName;
                //System.Diagnostics.Process.Start("cmd.exe", "/K " + command_compiler);
                
                CMD_command = "clang -o main.exe main.c";
                await CMD_COMPILE.ExecuteCommandAsync(command_compiler);
                //button1.Enabled = true;
            }
            else
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.ForeColor = Color.Black;
                label2.BackColor = Color.Red;
                label2.Text = "FILE NOT FOUND = main.cpp OR FILE = main.cpp";
                //button1.Enabled = true;
                //MessageBox.Show("File not found: main.cpp");
            }

            
            
            //button1.Enabled = true;
        }


        

        private void button2_Click(object sender, EventArgs e)
        {       //button2 = open the file explorer in the path
            // open the file explorer in the path
            System.Diagnostics.Process.Start("explorer.exe", exe_path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button3 = open folder in cmd
            // open the folder in cmd + dir
            //System.Diagnostics.Process.Start("cmd.exe", "/K dir " + exe_path);
            System.Diagnostics.Process.Start("cmd.exe", "/K dir " + exe_path);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // button4 = run the main.exe
            if (File.Exists(@"main.exe"))
            {
                string command = "main.exe";
                System.Diagnostics.Process.Start("cmd.exe", "/K " + command);
            }
            else
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.ForeColor = Color.Yellow;
                label2.BackColor = Color.Red;
                label2.Text = "FILE NOT FOUND = main.exe";
                //MessageBox.Show("File not found: main.cpp");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // button5 = run notepad++ if installed
            string notepad_plus_exe_Path = @"C:\Program Files\Notepad++\notepad++.exe";
            //string notepad_exe_Path = @"C:\Program Files (x86)\Notepad++\notepad++.exe";
             string notepad_win_exe = @"C:\Windows\system32\notepad.exe";
            if (File.Exists(notepad_plus_exe_Path))
            {
                //System.Diagnostics.Process.Start(notepad_exe_Path, @"main.cpp -y");
                System.Diagnostics.Process.Start(notepad_plus_exe_Path);
            }
            else
            {
                System.Diagnostics.Process.Start(notepad_win_exe);
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.ForeColor = Color.Yellow;
                label2.BackColor = Color.Red;
                label2.Text = "FILE NOT FOUND = notepad++.exe";
                //MessageBox.Show("File not found: main.cpp");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // run calculator
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!File.Exists(@"main.exe"))
            {
                label2.Font = new Font(label2.Font.FontFamily, 14);
                label2.Text = "";
                label2.BackColor = Color.Red;
                label2.Text = "!!! ERROR !!! FILE COMPILED NOT OK = main.exe !!!";
                timer1.Stop();
                button1.Enabled = true;
            }

            if (File.Exists(@"main.exe"))
            {
                if (File.Exists(@"main.cpp"))
                {
                    label2.Font = new Font(label2.Font.FontFamily, 14);
                    label2.Text = "";
                    label2.BackColor = Color.LimeGreen;
                    label2.Text = "FILE main.cpp COMPILED OK = main.exe";
                    timer1.Stop();
                    button1.Enabled = true;
                }
                else if (File.Exists(@"main.c"))
                {
                    label2.Font = new Font(label2.Font.FontFamily, 14);
                    label2.Text = "";
                    label2.BackColor = Color.LimeGreen;
                    label2.Text = "FILE main.c COMPILED OK = main.exe";
                    timer1.Stop();
                    button1.Enabled = true;
                }
            }
            //else
            /*
            {
                label2.Text = "";
                label2.BackColor = Color.Red;
                label2.Text = "!!! ERROR !!! FILE COMPILE NOT = main.exe !!!";
                timer1.Stop();
            }
            */
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("NOT USED FOR NOW\n");
            richTextBox1.ScrollToCaret();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("NOT USED FOR NOW\n");
            richTextBox1.ScrollToCaret();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("NOT USED FOR NOW\n");
            richTextBox1.ScrollToCaret();
        }
    }
}
