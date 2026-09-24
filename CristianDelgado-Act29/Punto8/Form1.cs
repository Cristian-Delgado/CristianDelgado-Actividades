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

namespace Punto8
{
    // Punto8: Validador de Credenciales y Formato
    // ● Consigna: Solicitar usuario y contraseña mediante TextBox(usando
    // UseSystemPasswordChar = true). Un CheckBox &quot; Acepto términos&quot; debe habilitar
    // (Enabled = true) el Button &quot; Ingresar&quot;. Si la clave coincide con & quot; admin123&quot;, mostrar
    // éxito en una Label; de lo contrario, mostrar advertencia.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox2.UseSystemPasswordChar = true;
            button1.Enabled = false;

            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            button1.Click += button1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "admin123")
            {
                label1.Text = "Ingreso exitoso.";
            }
            else
            {
                label1.Text = "Contraseña incorrecta.";
            }
        }
    }
}