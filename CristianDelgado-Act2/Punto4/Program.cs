using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto 4
            // Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.

            int a, b, c;

            Console.Write("Ingrese el primer número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("El mayor es: " + a);
            }
            else if (b > c)
            {
                Console.WriteLine("El mayor es: " + b);
            }
            else
            {
                Console.WriteLine("El mayor es: " + c);
            }
            Console.ReadKey();
        }
    }
}