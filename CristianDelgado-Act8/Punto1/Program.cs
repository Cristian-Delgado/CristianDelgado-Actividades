using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Punto1:
            // Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
            // del vector.

           Console.Write("Ingrese la cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese valor {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            int menor = vector[0];
            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (vector[i] == menor)
                {
                    contador++;
                }
            }

            Console.WriteLine($"Menor valor: {menor}");

            if (contador > 1)
            {
                Console.WriteLine("El menor valor se repite.");
            }
            else
            {
                Console.WriteLine("El menor valor NO se repite.");
            }
            Console.ReadKey();
        }
    }
}