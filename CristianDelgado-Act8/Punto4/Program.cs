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
            // Punto4:
            // Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
            // habitantes de este.Ordenar alfabéticamente e imprimir los resultados.Por último
            // ordenar con respecto a la cantidad de habitantes(de mayor a menor) e imprimir
            // nuevamente.

            string[] paises = new string[5];
            int[] habitantes = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingrese país {i + 1}: ");
                paises[i] = Console.ReadLine();

                Console.Write($"Habitantes de {paises[i]}: ");
                habitantes[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (string.Compare(paises[j], paises[j + 1]) > 0)
                    {
                        string auxP = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = auxP;
                        int auxH = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = auxH;
                    }
                }
            }
            Console.WriteLine("\nOrden alfabético:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{paises[i]} - {habitantes[i]}");
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (habitantes[j] < habitantes[j + 1])
                    {
                        int auxH = habitantes[j];
                        habitantes[j] = habitantes[j + 1];
                        habitantes[j + 1] = auxH;

                        string auxP = paises[j];
                        paises[j] = paises[j + 1];
                        paises[j + 1] = auxP;
                    }
                }
            }

            Console.WriteLine("\nOrden por habitantes (mayor a menor):");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{paises[i]} - {habitantes[i]}");
            }
            Console.ReadKey();
        }
    }
}