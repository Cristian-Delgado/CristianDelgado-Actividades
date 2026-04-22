using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Punto2:
    //Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
    //elementos.Obtener la suma de los dos vectores, dicho resultado guardarlo en un
    //tercer vector del mismo tamaño. Sumar componente a componente.

    using System;

    class Program
    {
        static void Main()
        {
            int[] v1 = new int[4];
            int[] v2 = new int[4];
            int[] suma = new int[4];

            Console.WriteLine("Vector 1:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese valor: ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vector 2:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese valor: ");
                v2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                suma[i] = v1[i] + v2[i];
            }

            Console.WriteLine("Vector suma:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(suma[i]);
            }
        }
    }
}