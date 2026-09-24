using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto7
{
    // Punto7: Selector de Color con Valores Numéricos (Investigación: NumericUpDown)
    // ● Consigna: Crear tres NumericUpDown restringidos entre 0 y 255 (Rojo, Verde,
    // Azul). Un Button cambiará la propiedad BackColor del Form aplicando
    // Color.FromArgb().

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 255;

            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 255;

            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 255;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rojo = (int)numericUpDown1.Value;
            int verde = (int)numericUpDown2.Value;
            int azul = (int)numericUpDown3.Value;

            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }

    }
}
