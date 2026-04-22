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
            // Punto 3:
            // Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en
            // pantalla la leyenda "Todos los números son menores a diez"

            int n1, n2, n3;

            Console.Write("Ingrese número 1: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 3: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 < 10 && n2 < 10 && n3 < 10)
            {
                Console.WriteLine("Todos los números son menores a diez");
            }
            Console.ReadKey();
        }
    }
}