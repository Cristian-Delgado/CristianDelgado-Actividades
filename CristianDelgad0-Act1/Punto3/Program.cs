using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto3:
            // Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

            double suma = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("Ingrese el número " + i + ": ");
                suma += double.Parse(Console.ReadLine());
            }

            double promedio = suma / 4;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("El promedio es: " + promedio);

            Console.ReadKey();
        }
    }
}