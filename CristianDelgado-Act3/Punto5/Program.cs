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
            string linea;

            Console.Write("Ingrese valor de x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);

            Console.Write("Ingrese valor de y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el primer cuadrante");
            }
            else
            {
                if (x < 0 && y > 0)
                {
                    Console.WriteLine("El punto se encuentra en el segundo cuadrante");
                }
                else
                {
                    if (x < 0 && y < 0)
                    {
                        Console.WriteLine("El punto se encuentra en el tercer cuadrante");
                    }
                    else
                    {
                        Console.WriteLine("El punto se encuentra en el cuarto cuadrante");
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}