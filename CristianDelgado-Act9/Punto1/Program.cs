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
            // Punto1:
            // Se desea desarrollar un programa que permita registrar los nombres y las
            // calificaciones de 6 estudiantes.Luego de cargar los datos, se debe mostrar el
            // nombre del estudiante con la nota más alta, junto con su nota.Al igual que el
            // estudiante con la nota más baja.Informar si hay estudiantes con la misma nota
            // máxima o mínima.
            
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