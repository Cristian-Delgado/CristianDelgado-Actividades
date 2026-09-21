using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            comboBox1.Items.Add("Perro");
            comboBox1.Items.Add("Gato");
            comboBox1.Items.Add("Conejo");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Perro")
            {
                pictureBox1.ImageLocation = $"https://commons.wikimedia.org/wiki/File:Domestic_rabbit_and_dog.JPG?utm_source";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox1.Text == "Gato")
            {
                pictureBox1.ImageLocation = $"https://commons.wikimedia.org/wiki/File:Gato_(2)_REFON.jpg";
            }
            else if (comboBox1.Text == "Conejo")
            {
                pictureBox1.ImageLocation = $"https://commons.wikimedia.org/wiki/File:Conejo_(27_de_Octubre_de_2021).jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}