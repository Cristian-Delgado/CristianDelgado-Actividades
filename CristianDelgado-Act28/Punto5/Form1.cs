using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Punto5
{
    // Punto5: Visor Dinámico de Imágenes (Investigación: PictureBox)
    // ● Investigación: Investigar la clase PictureBox y sus propiedades ImageLocation y
    // SizeMode.
    // ● Consigna: Cargar en un ComboBox tres opciones. Al cambiar la selección mediante
    // el evento SelectedIndexChanged, mostrar la imagen correspondiente dentro del PictureBox.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Perro")
            {
                pictureBox1.Image = Properties.Resources.perro;
            }

            if (comboBox1.Text == "Gato")
            {
                pictureBox1.Image = Properties.Resources.gato;
            }

            if (comboBox1.Text == "Paloma")
            {
                pictureBox1.Image = Properties.Resources.Paloma;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
