using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto4
{
    // Punto4: Temporizador de Clics
    // ● Consigna: Crear un mini-juego donde un Button cuente cuántos clics realiza el
    // usuario en 10 segundos.Al finalizar el tiempo mediante el Timer, deshabilitar el
    // botón(Enabled = false) y mostrar el puntaje acumulado en un MessageBox.Show.

    public partial class Form1 : Form
    {
        int clics = 0;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 10000;
            button1.Click += button1_Click;
            timer1.Tick += timer1_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clics++;
            if (clics == 1)
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = false;
            MessageBox.Show("Hiciste " + clics + " clics en 10 segundos.");
        }
    }
}