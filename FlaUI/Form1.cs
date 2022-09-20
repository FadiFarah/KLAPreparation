using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlaUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test1Button_Click(object sender, EventArgs e)
        {
            FlaUITest.Test1();
        }

        private void test2Button_Click(object sender, EventArgs e)
        {
            FlaUITest.Test2();
        }

        private void test3Button_Click(object sender, EventArgs e)
        {
            FlaUITest.Test3();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void test4Button_Click(object sender, EventArgs e)
        {
            FlaUITest.Test4();
        }

        private void test5Button_Click(object sender, EventArgs e)
        {
            FlaUITest.Test5();
        }
    }
}
