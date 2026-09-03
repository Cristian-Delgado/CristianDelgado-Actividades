using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Punto2
{
    // Punto2:
    // Permitir el ingreso de dos números en controles de tipo TextBox y mediante
    // dos controles de tipo RadioButton permitir seleccionar si queremos sumarlos o
    // restarlos.Al presionar un botón mostrar en el título del Form el resultado de la
    // operación.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox1.Text);
            double numero2 = Convert.ToDouble(textBox2.Text);

            double resultado = 0;

            if (Sumar.Checked)
            {
                resultado = numero1 + numero2;
            }

            if (Restar.Checked)
            {
                resultado = numero1 - numero2;
            }

            this.Text = "Resultado: " + resultado;
        }
    }
}
