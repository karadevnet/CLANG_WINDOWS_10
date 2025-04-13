using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__CLANG_MANAGER_WIN_10
{
    internal class CMD_COMPILE
    {
        //public Form1 _form;

        public static async Task ExecuteCommandAsync(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/K {command}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            process.Start(); // Start the process exactly from here

            // Create tasks for output and error streams
            Task outputTask = Task.Run(async () =>
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    while (!reader.EndOfStream)
                    {
                        string output = await reader.ReadLineAsync();

                        //if (Form1.form1Instance != null && Form1.form1Instance.RichTextBoxInstance != null)
                        //{
                            Form1.form1Instance.RichTextBoxInstance.Invoke(new Action(() =>
                            {
                                Form1.form1Instance.RichTextBoxInstance.AppendText(output + "\n");
                                Form1.form1Instance.RichTextBoxInstance.ScrollToCaret();
                            }));

                        //}
                        //else
                        //{
                          //  MessageBox.Show("Error: Form1 instance or richTextBox1_main is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}


                    }
                }
            });

            Task errorTask = Task.Run(async () =>
            {
                using (StreamReader reader = process.StandardError)
                {
                    while (!reader.EndOfStream)
                    {
                        string errorOutput = await reader.ReadLineAsync();
                        //if (Form1.form1Instance != null && Form1.form1Instance.RichTextBoxInstance != null)
                        //{
                        if (errorOutput.Contains("error"))
                        {
                            Form1.form1Instance.RichTextBoxInstance.Invoke(new Action(() =>
                            {
                                Form1.form1Instance.RichTextBoxInstance.AppendText("ERROR = " + errorOutput + "\n");
                                Form1.form1Instance.RichTextBoxInstance.ScrollToCaret();
                            }));
                        }

                        if (errorOutput.Contains("warning"))
                        {
                            Form1.form1Instance.RichTextBoxInstance.Invoke(new Action(() =>
                            {
                                Form1.form1Instance.RichTextBoxInstance.AppendText("WARNING = " + errorOutput + "\n");
                                Form1.form1Instance.RichTextBoxInstance.ScrollToCaret();
                            }));
                        }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Error: Form1 instance or richTextBox1_main is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                }
            });

            await Task.WhenAll(outputTask, errorTask);
            await Task.Run(() => process.WaitForExit());
        }

    }
}
