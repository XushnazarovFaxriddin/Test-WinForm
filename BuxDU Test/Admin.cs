using System;
using System.IO;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void SavolQoshButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >101)
            {
                textBox1.Text = File.ReadAllText("BuxDU_Test/Testlar/test1.txt");
                //File.WriteAllText("./Testlar/test1.txt", textBox1.Text);
                Form1 f = new Form1();
                f.Visible = true;
                f.Show();
                MessageBox.Show("Testlar bazaga qo'shildi!");
                Admin a = new Admin();
                a.Close();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Kiritilgan matn uzunligi 100dan katta bo'lishi kerak!");
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
