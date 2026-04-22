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
            // Punto 2:
            //  Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo
            //  y a este resultado se lo multiplica por el tercero.

            int a, b, c;

            Console.Write("Ingrese el primer valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer valor: ");
            c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                int suma = a + b;
                int resultado = suma * c;
                Console.WriteLine("Resultado: " + resultado);
            }
            Console.ReadKey();
        }
    }
}