using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        // Punto1:
        // Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
        // El valor acumulado de todos los elementos del vector.
        // El valor acumulado de los elementos del vector que sean mayores a 36.
        // Cantidad de valores mayores a 50.

        class Vector1
        {
            private int[] vector;

            public void Cargar()
            {
                vector = new int[8];

                for (int f = 0; f < vector.Length; f++)
                {
                    Console.Write("Ingrese valor: ");
                    string linea = Console.ReadLine();
                    vector[f] = int.Parse(linea);
                }
            }

            public void Procesar()
            {
                float sumaTotal = 0;
                float sumaMayores36 = 0;
                float cantidadMayores50 = 0;

                for (int f = 0; f < vector.Length; f++)
                {
                    sumaTotal = sumaTotal + vector[f];

                    if (vector[f] > 36)
                    {
                        sumaMayores36 = sumaMayores36 + vector[f];
                    }

                    if (vector[f] > 50)
                    {
                        cantidadMayores50++;
                    }
                }

                Console.WriteLine("Valor acumulado del vector: " + sumaTotal);
                Console.WriteLine("Valor acumulado mayores a 36: " + sumaMayores36);
                Console.WriteLine("Cantidad mayores a 50: " + cantidadMayores50);

                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                Vector1 v = new Vector1();
                v.Cargar();
                v.Procesar();
            }
        }
    }
}
