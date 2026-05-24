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

            double num1, num2, num3, num4;
            string linea;

            Console.Write("Ingrese el ler numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el 2do numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el 3ro numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("Ingrese el 4to numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            double suma = num1 + num2 + num3 + num4;
            double promedio = suma / 4;

            Console.WriteLine("Suma total: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadKey();
        }
    }
}