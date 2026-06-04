using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        // Punto4:
        // Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
        // ordenado de menor a mayor y de mayor a menor.

        class VectorOrdenado
        {
            private int[] vector;

            public void Cargar()
            {
                vector = new int[10];

                for (int f = 0; f < vector.Length; f++)
                {
                    Console.Write("Ingrese valor: ");
                    string linea = Console.ReadLine();
                    vector[f] = int.Parse(linea);
                }
            }

            public void Verificar()
            {
                float menorMayor = 0;
                float mayorMenor = 0;

                for (int f = 0; f < vector.Length - 1; f++)
                {
                    if (vector[f] <= vector[f + 1])
                    {
                        menorMayor++;
                    }

                    if (vector[f] >= vector[f + 1])
                    {
                        mayorMenor++;
                    }
                }

                if (menorMayor == vector.Length - 1)
                {
                    Console.WriteLine("El vector está ordenado de menor a mayor");
                }
                else
                {
                    if (mayorMenor == vector.Length - 1)
                    {
                        Console.WriteLine("El vector está ordenado de mayor a menor");
                    }
                    else
                    {
                        Console.WriteLine("El vector no está ordenado");
                    }
                }

                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                VectorOrdenado v = new VectorOrdenado();
                v.Cargar();
                v.Verificar();
            }
        }
    }
}
