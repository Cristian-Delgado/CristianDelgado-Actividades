using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);

            double resultado = 0;

            if (radioButton1.Checked)
            {
                resultado = numero1 + numero2;
            }

            if (radioButton2.Checked)
            {
                resultado = numero1 - numero2;
            }

            this.Text = "Resultado: " + resultado;
        }
    }
}
