using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string navegadores = "";

            if (checkBox1.Checked)
            {
                navegadores = navegadores + "Google Chrome ";
            }

            if (checkBox2.Checked)
            {
                navegadores = navegadores + "Mozilla Firefox ";
            }

            if (checkBox3.Checked)
            {
                navegadores = navegadores + "Microsoft Edge";
            }

            this.Text = navegadores;
        }
    }
}
