using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto4
{
    // Punto4: Temporizador de Clics
    // ● Investigación: Explicar el componente Timer(propiedades Interval, Enabled y
    // evento Tick) con un breve ejemplo explicativo.
    // ● Consigna: Crear un mini - juego donde un Button cuente cuántos clics realiza el
    // usuario en 10 segundos.Al finalizar el tiempo mediante el Timer, deshabilitar el
    // botón(Enabled = false) y mostrar el puntaje acumulado en un MessageBox.Show.

    public partial class Form1 : Form
    {
        int puntaje = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puntaje++;     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.Enabled = false;
            MessageBox.Show("Puntaje: " + puntaje);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
