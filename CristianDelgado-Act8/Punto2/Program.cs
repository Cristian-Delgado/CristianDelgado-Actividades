using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        // Punto2:
        // Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
        // algoritmo de ordenamiento alfabético.

        class PruebaVector2
        {
            private string[] paises;

            public void Cargar()
            {
                paises = new string[5];
                for (int f = 0; f < paises.Length; f++)
                {
                    Console.Write("Ingrese país: ");
                    string linea;
                    linea = Console.ReadLine();
                    paises[f] = Console.ReadLine();
                }
            }

            public void Ordenar()
            {
                for (int k = 0; k < paises.Length; k++)
                {
                    for (int f = 0; f < paises.Length - 1 - k; f++)
                    {
                        if (paises[f].CompareTo(paises[f + 1]) > 0)
                        {
                            string aux;
                            aux = paises[f];
                            paises[f] = paises[f + 1];
                            paises[f + 1] = aux;
                        }
                    }
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Países ordenados:");
                for (int f = 0; f < paises.Length; f++)
                {
                    Console.WriteLine(paises[f]);
                }
            }

            static void Main(string[] args)
            {
                PruebaVector2 pv = new PruebaVector2();
                pv.Cargar();
                pv.Ordenar();
                pv.Imprimir();
                Console.ReadKey();
            }
        }
    }
}