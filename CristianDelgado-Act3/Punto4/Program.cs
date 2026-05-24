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
            // Punto 4:
            // Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10,
            // imprimir en pantalla la leyenda "Alguno de los números es menor a diez".

            int num1, num2, num3;
            string linea;

            Console.Write("Ingrese primer número: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese segundo número: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese tercer número: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.WriteLine("Alguno de los números es menor a diez");
            }
            Console.ReadKey();
        }
    }
}