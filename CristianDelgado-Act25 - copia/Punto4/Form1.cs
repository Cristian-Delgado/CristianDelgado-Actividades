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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Punto4
{
    //Punto4:
    // Elaborar una interfaz gráfica que muestre una calculadora (utilizar
    // objetos de la clase Button y un objeto de la clase Label donde se
    // muestra el valor ingresado), tener en cuenta que solo se debe
    // implementar la interfaz y la carga de un valor de hasta 12 dígitos.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "7";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "8";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "9";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "X";
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "4";
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "5";
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "6";
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "-";
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "1";
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "2";
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "3";
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "+";
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "/";
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "0";
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + ".";
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (label1.Text.Length < 12)
            {
                label1.Text = label1.Text + "=";
            }
        }
    }
}
