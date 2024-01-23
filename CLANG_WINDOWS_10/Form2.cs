using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CLANG_WINDOWS_10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string readtxt;
            Assembly assembly = Assembly.GetExecutingAssembly();
            StreamReader reader = new StreamReader(assembly.GetManifestResourceStream("CLANG_WINDOWS_10.TextFile1.txt"));
             readtxt = reader.ReadToEnd();
            richTextBox1.AppendText(readtxt);
            richTextBox1.Find("HELP USING C#"); // get marker to start
            richTextBox1.Focus();               // of memo text
        }
    }
}
