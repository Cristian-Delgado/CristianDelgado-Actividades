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

            int num1, num2,num3, num4, suma, producto;
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

            suma = num1 + num2;
            producto = num3 * num4;

            Console.Write("La suma de ambos numeros es:");

            Console.WriteLine(suma);

            Console.Write("El producto de ambos numeros es:");
            Console.WriteLine(producto);

            Console.ReadKey();
        }
    }
}