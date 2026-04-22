using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto2:
            // Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos
            // primeros y el producto del tercero y el cuarto. 

            Console.Write("Ingrese el primer número: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el cuarto número: ");
            double n4 = double.Parse(Console.ReadLine());

            double suma = n1 + n2;
            double producto = n3 * n4;

            Console.WriteLine("La suma de los dos primeros es: " + suma);
            Console.WriteLine("El producto del tercero y cuarto es: " + producto);

            Console.ReadKey();
        }
    }
}