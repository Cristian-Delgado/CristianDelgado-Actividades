using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
 
       //Punto1:
       // Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
       // del vector.

        class PruebaVector1
        {
            private int[] vec;
            private int n;

            public void Cargar()
            {
                Console.Write("Ingrese la cantidad de elementos: ");
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

            public void Menor()
            {
                int menor = vec[0];
                int cantidad = 1;
                for (int f = 1; f < vec.Length; f++)
                {
                    if (vec[f] < menor)
                    {
                        menor = vec[f];
                        cantidad = 1;
                    }
                    else
                    {
                        if (vec[f] == menor)
                        {
                            cantidad++;
                        }
                    }
                }

                Console.WriteLine("El menor valor es: " + menor);

                if (cantidad > 1)
                    Console.WriteLine("El menor se repite.");
                else
                    Console.WriteLine("El menor no se repite.");
            }

            static void Main(string[] args)
            {
                PruebaVector1 pv = new PruebaVector1();
                pv.Cargar();
                pv.Menor();
                Console.ReadKey();
            }
          }
    }
}