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
            // Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector

            Console.Write("Cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Valor {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int aux = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Vector ordenado:");
            foreach (int v in vector)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}