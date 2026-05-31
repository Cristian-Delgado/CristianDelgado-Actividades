using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        // Punto2:
        // Desarrollar una clase que represente un Cuadrado y tenga los siguientes
        // métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.

        class Cuadrado
        {
            private int lado;

            public void Inicializar()
            {
                string linea;

                Console.Write("Ingrese el valor del lado: ");
                linea = Console.ReadLine();
                lado = int.Parse(linea);
            }

            public void Perimetro()
            {
                int perimetro;
                perimetro = lado * 4;

                Console.WriteLine("Perímetro: " + perimetro);
            }

            public void Superficie()
            {
                int superficie;
                superficie = lado * lado;

                Console.WriteLine("Superficie: " + superficie);
            }

            static void Main(string[] args)
            {
                Cuadrado c = new Cuadrado();

                c.Inicializar();
                c.Perimetro();
                c.Superficie();

                Console.ReadKey();
            }
        }
    }
}