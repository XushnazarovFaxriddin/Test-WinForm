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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Fakultet.Text == "Axborot texnologiyalari")
                comboBox1.Items.Add("1-2KIDT-20");
        }

        private void Fakultet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registr_Load(object sender, EventArgs e)
        {

        }
    }
}
