using System;
using System.Collections;
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
    // Punto2: Encuesta de Preferencias de Música
    // Problema:
    // Una aplicación quiere conocer los gustos musicales de los usuarios.
    // Requisitos:
    // ● Mostrar un ComboBox con 5 géneros musicales distintos.
    // ● Incluir tres CheckBox que representen actividades relacionadas (por ejemplo:
    // &quot; Escuchar en vivo&quot;, &quot;Escuchar en streaming&quot;, &quot;Comprar discos&quot;).
    // ● Al presionar un botón &quot;Mostrar Preferencias&quot;, en un Label se debe mostrar el género
    // seleccionado y las actividades marcadas.

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
            string genero = comboBox1.Text;
            string actividades = "";

            if (checkBox1.Checked)
            {
                actividades = actividades + "Escuchar en vivo ";
            }

            if (checkBox2.Checked)
            {
                actividades = actividades + "Escuchar en streaming ";
            }

            if (checkBox3.Checked)
            {
                actividades = actividades + "Comprar discos";
            }

            label1.Text = "Género: " + genero + " - Actividades: " + actividades;
        }
    }
}
