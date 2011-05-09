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
            int textboxid = int.Parse(((TextBox) sender).Name.Substring(7));

            char correctchar = textBox1.Text.ToCharArray()[textboxid - 2];

            if (((TextBox) sender).Text.Length != 0)
            {
                // first char filled in, move to next box
                string control = "textBox" + ++textboxid;

                ((TextBox) sender).BackColor = (((TextBox) sender).Text.ToCharArray())[0] == correctchar
                                                   ? Color.Green
                                                   : Color.Red;

                if (this.Controls.ContainsKey(control))
                {
                    this.Controls[control].Focus();
                }
            }
            else
            {
                ((TextBox) sender).BackColor = Color.White;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8) return;

            if (((TextBox)sender).Text.Length != 0) return;

            // empty first char, focus at end of last box
            if (((TextBox)sender).Name == "textBox2")
            {
                //first box, do nothing
            }
            else
            {
                string control = "textBox" + (int.Parse(((TextBox)sender).Name.Substring(7)) - 1);
                if (this.Controls.ContainsKey(control))
                {
                    this.Controls[control].Focus();
                    ((TextBox) this.Controls[control]).Text = "";
                }
            }
        }
    }
}
