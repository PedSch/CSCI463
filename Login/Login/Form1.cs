using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Select(0, 0);
            textBox1.UseSystemPasswordChar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "Enter Password")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
 
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox2.Text == "Enter Username")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textbox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Username")
            {
                textBox2.Clear();
                textBox2.ForeColor = Color.Black;
            }

            if (textBox1.Text.Length < 1)
            {
                //textBox1.Forecolor = Color.DarkGray;
                textBox1.UseSystemPasswordChar = false;
                textBox1.Text = "Enter Password ";
            }
        }
        private void textbox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Password")
            {
                textBox1.Clear();
                textBox1.UseSystemPasswordChar = false;
                textBox1.ForeColor = Color.Black;
            }

            if (textBox2.Text.Length < 1)
            {
                //textBox2.Forecolor = Color.DarkGray;
                textBox2.Text = "Enter Username ";
            }
        }
        private void Form1_Click(object sender , EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                //textBox1.Forecolor = Color.DarkGray;
                textBox1.UseSystemPasswordChar = false;
                textBox1.Text = "Enter Password ";
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Successful");
            Hide();
            Form1 FORM = new Form1();
            FORM.ShowDialog();
            Close();
        }

    }
}
