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

namespace Punto5
{
    // Punto5: Configuración de Suscripción
    // Problema:
    // Una aplicación ofrece distintos niveles de suscripción.
    // Requisitos:
    // ● Usar un ComboBox para elegir el tipo de plan: &quot;Gratis&quot;, &quot;Básico&quot;, &quot;Premium&quot;.
    // ● Incluir dos CheckBox para elegir servicios adicionales(por ejemplo: &quot; Soporte
    // técnico&quot;, &quot;Acceso anticipado&quot;).
    // ● Al presionar el botón &quot;Guardar&quot;, se debe mostrar en un Label un resumen con el
    // plan y los servicios elegidos.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plan = comboBox1.Text;
            string servicios = "";

            if (checkBox1.Checked)
            {
                servicios = servicios + "Soporte técnico ";
            }

            if (checkBox2.Checked)
            {
                servicios = servicios + "Acceso anticipado";
            }

            label1.Text = "Plan: " + plan + " - Servicios: " + servicios;
        }
    }
}
