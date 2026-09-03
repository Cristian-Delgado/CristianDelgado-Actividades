using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Punto1
{
    // Punto1: 1. Calculadora de Promedio de Notas
    // ● Consigna: Crear un formulario con tres TextBox para ingresar notas y un Button
    // &quot;Calcular&quot;. Convertir los valores con int.Parse() o double.Parse() y mostrar en una
    // Label el promedio.Si la nota es mayor o igual a 6, cambiar el color del texto de la
    // etiqueta a verde; de lo contrario, a rojo.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(textBox1.Text);
            double nota2 = double.Parse(textBox2.Text);
            double nota3 = double.Parse(textBox3.Text);

            double promedio = (nota1 + nota2 + nota3) / 3;

            label4.Text = "Promedio: " + promedio;

            if (promedio >= 6)
            {
                label4.ForeColor = Color.Green;
            }
            else
            {
                label4.ForeColor = Color.Red;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}