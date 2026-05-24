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

            int num1, num2, num3;
            string linea;

            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese tercer valor: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 == num2 && num2 == num3)
            {
                int suma = num1 + num2;
                int resultado = suma * num3;

                Console.WriteLine("El resultado es: " + resultado);
            }
            else
            {
                Console.WriteLine("Los valores no son iguales");
            }
            Console.ReadKey();
        }
    }
}