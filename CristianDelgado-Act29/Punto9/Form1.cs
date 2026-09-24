using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto9
{
    // Punto9: Cálculo de Edad (Investigación: DateTimePicker)
    // ● Investigación: Investigar el control DateTimePicker(propiedad Value de tipo
    // DateTime).

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
            int edad = DateTime.Now.Year - dateTimePicker1.Value.Year;

            label1.Text = "Edad: " + edad + " años";
        }
    }
}
