using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordLearningTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

            if(((TextBox)sender).Text.Length == 0)
            { // empty first char, focus at end of last box
                if(((TextBox)sender).Name == "textBox2")
                {
                    //first box, do nothing
                }
                else
                {
                    string control = "textBox" + int.Parse(((TextBox)sender).Name.Substring(7)) + 1;
                    if (this.Controls.ContainsKey(control))
                    {
                        this.Controls[control].Focus();
                        ((TextBox) this.Controls[control]).SelectionStart = 1;
                    }
                }
            }
            else
            {
                // first char filled in, move to next box
                string name = ((TextBox) sender).Name;
                string substring = name.Substring(7);
                int i = int.Parse(substring);
                i++;
                string control = "textBox" + i;
                

                if (this.Controls.ContainsKey(control))
                {
                    this.Controls[control].Focus();
                }
            }
        }
    }
}
