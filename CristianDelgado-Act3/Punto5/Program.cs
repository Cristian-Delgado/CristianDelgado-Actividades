using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punot 5:
            // Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros
            // x e y (distintos a cero).Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto.
            // (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0).

            int x, y;

            Console.Write("Ingrese coordenada X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese coordenada Y: ");
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Primer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Tercer cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Cuarto cuadrante");
            }
            Console.ReadKey();
        }
    }
}