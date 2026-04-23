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
            // Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
            // ordenado de menor a mayor y de mayor a menor.

            int[] vector = new int[10];
            bool ascendente = true;
            bool descendente = true;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese valor: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 9; i++)
            {
                if (vector[i] < vector[i + 1])
                    descendente = false;

                if (vector[i] > vector[i + 1])
                    ascendente = false;
            }

            if (ascendente)
                Console.WriteLine("Está ordenado de menor a mayor");

            if (descendente)
                Console.WriteLine("Está ordenado de mayor a menor");

            if (!ascendente && !descendente)
                Console.WriteLine("No está ordenado");
                Console.ReadKey();
        }
    }
}