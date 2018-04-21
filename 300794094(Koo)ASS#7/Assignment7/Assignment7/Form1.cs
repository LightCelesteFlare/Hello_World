using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CountCharacters()
        {
            int count = 0;
            
            // Create a StreamReader and point it to the file to read
            using (StreamReader reader = new StreamReader("Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                // Make the program look busy for 5 seconds
                Thread.Sleep(5000);
            }

            return count;
        }

        private async void btnProcessFile_Click_1(object sender, EventArgs e)
        {
            lblCount.Text = "Processing file. Please wait...";
            Task<int> task = Task.Run(() => CountCharacters());
            await task;

            lblCount.Text = task.Result.ToString() + " characters in file";

            //int count = CountCharacters();
            //lblCount.Text = count.ToString() + " characters in file";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
