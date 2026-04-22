using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[6];
            int[] notas = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese nombre del estudiante: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }

            int max = notas[0], min = notas[0];
            string nombreMax = nombres[0], nombreMin = nombres[0];
            int contMax = 0, contMin = 0;

            for (int i = 0; i < 6; i++)
            {
                if (notas[i] > max)
                {
                    max = notas[i];
                    nombreMax = nombres[i];
                }

                if (notas[i] < min)
                {
                    min = notas[i];
                    nombreMin = nombres[i];
                }
            }

            for (int i = 0; i < 6; i++)
            {
                if (notas[i] == max) contMax++;
                if (notas[i] == min) contMin++;
            }

            Console.WriteLine("Mayor nota: " + nombreMax + " - " + max);
            Console.WriteLine("Menor nota: " + nombreMin + " - " + min);

            if (contMax > 1)
                Console.WriteLine("Hay varios estudiantes con la nota máxima");

            if (contMin > 1)
                Console.WriteLine("Hay varios estudiantes con la nota mínima");

            Console.ReadKey();
        }
    }
}