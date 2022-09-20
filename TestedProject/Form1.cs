using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestedProject
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Shown += Form1_Shown;
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Tick += new EventHandler(MyTimer_Tick_All_Time);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Program.parameter > 0)
            {
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                saveButton.Enabled = false;
                exitButton.Enabled = false;
                sleepButton.Enabled = false;
                Thread.Sleep(Program.parameter);
                firstNameTextBox.ReadOnly = false;
                lastNameTextBox.ReadOnly = false;
                saveButton.Enabled = true;
                exitButton.Enabled = true;
                sleepButton.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(@"C:\Data\Visual Studio Workspace\KLAPreparation\TestedProject\demo.txt");
            txt.Write(firstNameTextBox.Text);
            txt.Write(" ");
            txt.Write(lastNameTextBox.Text);
            txt.Close();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void sleepButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            saveButton.Enabled = false;
            exitButton.Enabled = false;
            sleepButton.Enabled = false;
            Thread.Sleep(5000);
            firstNameTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;
            saveButton.Enabled = true;
            exitButton.Enabled = true;
            sleepButton.Enabled = true;
        }

        private void createAndRemoveButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            TextBox t = new TextBox();
            tabPage1.Controls.Add(t);
            timer.Interval = (6000);
            timer.Tick += new EventHandler(MyTimer_Tick);
            timer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            tabPage1.Controls.Clear();
        }

        private void MyTimer_Tick_All_Time(object sender, EventArgs e)
        {
            tabPage1.Controls.Clear();
            myTimer.Enabled = false;
            Thread.Sleep(3000);
            myTimer.Enabled = true;
            TextBox t = new TextBox();
            tabPage1.Controls.Add(t);
        }

        private void createAndRemoveAllTimeButton_Click(object sender, EventArgs e)
        {
            TextBox t = new TextBox();
            tabPage1.Controls.Add(t);
            myTimer.Enabled = true;
            myTimer.Interval = (6000);
            myTimer.Tick += new EventHandler(MyTimer_Tick_All_Time);
        }
    }
}
