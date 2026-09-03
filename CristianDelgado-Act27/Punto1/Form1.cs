using Microsoft.Win32;
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
    // Punto1: Registro de Usuario Simple
    // Problema:
    // Se desea crear un formulario para registrar usuarios en un sistema.
    // Requisitos:
    // ● Mostrar etiquetas(Label) para &quot;Nombre&quot;, &quot;Apellido&quot; y &quot;Correo&quot;.
    // ● Permitir que el usuario escriba los datos en TextBox.
    // ● Incluir un botón &quot;Registrar&quot; que, al presionarlo, muestra en un Label un mensaje con
    // los datos ingresados concatenados.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string correo = textBox3.Text;

            label4.Text = "Nombre: " + nombre + " - Apellido: " + apellido + " - Correo: " + correo;
        }
    }
}
