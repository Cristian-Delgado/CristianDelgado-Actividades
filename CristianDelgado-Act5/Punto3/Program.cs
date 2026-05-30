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

            int negativos, positivos, multiplos15, sumaPares;
            int valor, f;
            string linea;

            negativos = 0;
            positivos = 0;
            multiplos15 = 0;
            sumaPares = 0;

            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingrese un valor: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);

                if (valor < 0)
                {
                    negativos = negativos + 1;
                }

                if (valor > 0)
                {
                    positivos = positivos + 1;
                }

                if (valor % 15 == 0)
                {
                    multiplos15 = multiplos15 + 1;
                }

                if (valor % 2 == 0)
                {
                    sumaPares = sumaPares + valor;
                }
            }

            Console.WriteLine("Cantidad de negativos: " + negativos);
            Console.WriteLine("Cantidad de positivos: " + positivos);
            Console.WriteLine("Cantidad de múltiplos de 15: " + multiplos15);
            Console.WriteLine("Suma de números pares: " + sumaPares);

            Console.ReadKey();
        }
    }
}