using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CLANG_MANAGER_WIN_10
{
    
    internal class CompilerProcess
    {
        static StreamReader reader;
        static StreamWriter reader_input;
        public static void RunCompilation(string correctingPath)
        {
            //richTextBox1.AppendText("COMPILING main.c AND initcpu.c PROJECT STARTED\n");
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/K " + correctingPath;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            // Synchronously read the standard output of the spawned process.
            reader = process.StandardOutput;
            reader_input = process.StandardInput;
            string output = "";

            while (reader.EndOfStream == false)
            {

                output = reader.ReadLineAsync().Result;
                //richTextBox1.AppendText(output + "\n");
                //richTextBox1.ScrollToCaret();
            }
        }
    }
}
