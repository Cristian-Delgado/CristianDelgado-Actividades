using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto2
{
    // Punto2: Conversor de Temperatura
    // ● Consigna: Disponer un TextBox para el ingreso numérico y dos RadioButton:
    // &quot;Celsius a Fahrenheit&quot; y &quot;Fahrenheit a Celsius&quot;. Al presionar un Button, realizar la
    // fórmula correspondiente y mostrar el resultado en un Label.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperatura = double.Parse(textBox1.Text);
            double resultado = 0;

            if (radioButton1.Checked)
            {
                resultado = (temperatura * 9 / 5) + 32;
            }

            if (radioButton2.Checked)
            {
                resultado = (temperatura - 32) * 5 / 9;
            }

            label1.Text = "Resultado: " + resultado;
        }
    }
}
