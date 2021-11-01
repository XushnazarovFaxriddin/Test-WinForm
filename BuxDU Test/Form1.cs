using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuxDU_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (/*LogIn*/textBox1.Text == "BuxDU" && textBox2.Text == "KIDT"/*Parol*/)
            {
                label4.Text = "LogIn va Parol to'g'ri!";
                Registr r = new Registr();

                r.Visible = true;
                r.Show();
                
                //r.Layout();
                //this.Close();
                Form1 f = new Form1();
                f.Close();
                Visible = false;
            }
            else if (/*LogIn*/textBox1.Text == "AT Fak" && textBox2.Text == "BuxDU"/*Parol*/)
            {
                label4.Text = "LogIn va Parol to'g'ri!";
                Admin a = new Admin();

                a.Visible = true;
                a.Show();

                //r.Layout();
                //this.Close();
                Form1 f = new Form1();
                f.Close();
                Visible = false;
            }
            else
            {
                textBox1.SelectAll();
                textBox1.Clear();
                textBox2.SelectAll();
                textBox2.Clear();
                label4.Text = "LogIn yoki Parol xato!";
                MessageBox.Show("LogIn yoki Parol xato!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 12)
                label4.Text = "LogIn uzunligi 12 dan oshmasin!";
            else
                label4.Text = "LogIn va Parolni kiriting!";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 12)
                label4.Text = "Parol uzunligi 12 dan oshmasin!";
            else
                label4.Text = "LogIn va Parolni kiriting!";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
