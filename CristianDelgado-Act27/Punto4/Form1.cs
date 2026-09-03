using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto4
{
    // Punto4: Sistema de Opinión sobre un Producto
    // Problema:
    // Se quiere crear un formulario de opinión para un producto.
    // Requisitos:
    // ● Un Label debe indicar: &quot; Escribe tu opinión&quot;.
    // ● Incluir un TextBox grande(multilínea) donde el usuario escriba su comentario.
    // ● Dos RadioButton deben permitir seleccionar sí recomiendan el producto: &quot; Sí&quot; o &quot;No&quot;.
    // ● Al hacer clic en el botón &quot;Enviar&quot;, se debe mostrar un Label con el mensaje: &quot;Opinión
    // recibida: [texto] – Recomendación: [Sí/No]&quot;.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string opinion = textBox1.Text;
            string recomendacion = "";

            if (radioButton1.Checked)
            {
                recomendacion = "Sí";
            }

            if (radioButton2.Checked)
            {
                recomendacion = "No";
            }

            label1.Text = "Opinión recibida: " + opinion + " – Recomendación: " + recomendacion;
        }
    }
}
