using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Punto3
{
    // Punto3: Elección de Paquete de Viaje
    // Problema:
    // Una agencia de viajes ofrece distintos tipos de paquetes turísticos.
    // Requisitos:
    // ● Usar tres RadioButton para seleccionar el destino principal: &quot; Playa&quot;, &quot;Montaña&quot; o
    // &quot;Ciudad&quot;.
    // ● Agregar un ComboBox para elegir la duración del viaje (ejemplo: &quot;3 días&quot;, &quot;7 días&quot;,
    // &quot;15 días&quot;).
    // ● Un botón &quot;Confirmar&quot; debe mostrar en un Label la opción seleccionada.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string destino = "";

            if (radioButton1.Checked)
            {
                destino = "Playa";
            }

            if (radioButton2.Checked)
            {
                destino = "Montaña";
            }

            if (radioButton3.Checked)
            {
                destino = "Ciudad";
            }

            string duracion = comboBox1.Text;

            label1.Text = "Destino: " + destino + " - Duración: " + duracion;
        }
    }
}
