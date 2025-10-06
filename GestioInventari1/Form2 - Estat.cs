using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioInventari1
{
    public partial class EstatComanda : Form
    {
        public EstatComanda()
        {
            InitializeComponent();
        }

        private void labelStock_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

            label1.BackColor = Color.LightGray;
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {

            label1.BackColor = Color.Snow;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            comboBox2.ForeColor = Color.DarkRed;
        }
    }
}
