using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {

        // Punto3:
        // Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector

        class PruebaVector3
        {
            private int[] vec;
            private int n;

            public void Cargar()
            {
                Console.Write("Ingrese cantidad de elementos: ");
                string linea;
                linea = Console.ReadLine();
                n = int.Parse(linea);
                vec = new int[n];
                for (int f = 0; f < vec.Length; f++)
                {
                    Console.Write("Ingrese valor: ");
                    linea = Console.ReadLine();
                    vec[f] = int.Parse(linea);
                }
            }

            public void Ordenar()
            {
                for (int k = 0; k < vec.Length; k++)
                {
                    for (int f = 0; f < vec.Length - 1 - k; f++)
                    {
                        if (vec[f] > vec[f + 1])
                        {
                            int aux;
                            aux = vec[f];
                            vec[f] = vec[f + 1];
                            vec[f + 1] = aux;
                        }
                    }
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Vector ordenado:");

                for (int f = 0; f < vec.Length; f++)
                {
                    Console.WriteLine(vec[f]);
                }
            }

            static void Main(string[] args)
            {
                PruebaVector3 pv = new PruebaVector3();
                pv.Cargar();
                pv.Ordenar();
                pv.Imprimir();
                Console.ReadKey();
            }
        }
    }
}