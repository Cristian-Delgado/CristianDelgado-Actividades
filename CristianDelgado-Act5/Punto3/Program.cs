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
            // Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            // a) La cantidad de valores ingresados negativos.
            // b) La cantidad de valores ingresados positivos.
            // c) La cantidad de múltiplos de 15.
            // d) El valor acumulado de los números ingresados que son pares.

            int negativos = 0, positivos = 0, multiplos15 = 0, sumaPares = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                    negativos++;
                else if (num > 0)
                    positivos++;

                if (num % 15 == 0)
                    multiplos15++;

                if (num % 2 == 0)
                    sumaPares += num;
            }

            Console.WriteLine("\nResultados:");
            Console.WriteLine("Negativos: " + negativos);
            Console.WriteLine("Positivos: " + positivos);
            Console.WriteLine("Múltiplos de 15: " + multiplos15);
            Console.WriteLine("Suma de pares: " + sumaPares);

            Console.ReadKey();
        }
    }
}