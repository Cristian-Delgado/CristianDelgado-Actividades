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
            // Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
            // algoritmo de ordenamiento alfabético.

            string[] paises = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese país {i + 1}: ");
                paises[i] = Console.ReadLine();
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (string.Compare(paises[j], paises[j + 1]) > 0)
                    {
                        string aux = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine("Países ordenados:");
            foreach (string p in paises)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}