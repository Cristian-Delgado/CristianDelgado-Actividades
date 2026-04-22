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
            // Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
            // sus nombres y puntajes promedio obtenidos(de 1 a 10).
            // Cargar sus datos en vectores paralelos, mostrar docente con calificación más
            // alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
            // calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
            // desaprobaron(tomando como base que se aprueba con una nota mayor o igual a 6)

            string[] nombres = new string[6];
            int[] notas = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese nombre del docente: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese nota (1 a 10): ");
                notas[i] = int.Parse(Console.ReadLine());
            }

            int max = notas[0];
            int min = notas[0];
            string nombreMax = nombres[0];
            string nombreMin = nombres[0];

            int aprobados = 0;
            int desaprobados = 0;

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

                if (notas[i] >= 6)
                    aprobados++;
                else
                    desaprobados++;
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    if (notas[j] < notas[j + 1])
                    {
                        int auxNota = notas[j];
                        notas[j] = notas[j + 1];
                        notas[j + 1] = auxNota;

                        string auxNombre = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = auxNombre;
                    }
                }
            }

            Console.WriteLine("\nDocente con mayor nota: " + nombreMax + " - " + max);
            Console.WriteLine("Docente con menor nota: " + nombreMin + " - " + min);

            Console.WriteLine("\nListado ordenado (mayor a menor):");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(nombres[i] + " - " + notas[i]);
            }

            Console.WriteLine("\nCantidad de aprobados: " + aprobados);
            Console.WriteLine("Cantidad de desaprobados: " + desaprobados);

            Console.ReadKey();
        }
    }
}