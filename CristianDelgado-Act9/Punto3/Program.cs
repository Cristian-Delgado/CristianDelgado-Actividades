using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto3;
            // Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
            // carrera de 100 metros.El programa debe cargar los datos en dos vectores
            // paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
            // atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el promedio.
            string[] nombres = new string[5];
            double[] tiempos = new double[5];
            double suma = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese nombre del atleta: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese tiempo (en segundos): ");
                tiempos[i] = double.Parse(Console.ReadLine());

                suma += tiempos[i];
            }

            double promedio = suma / 5;

            double mejor = tiempos[0];
            double peor = tiempos[0];
            string nombreMejor = nombres[0];
            string nombrePeor = nombres[0];

            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i] < mejor)
                {
                    mejor = tiempos[i];
                    nombreMejor = nombres[i];
                }

                if (tiempos[i] > peor)
                {
                    peor = tiempos[i];
                    nombrePeor = nombres[i];
                }
            }

            Console.WriteLine("\nPromedio de tiempos: " + promedio);
            Console.WriteLine("Mejor tiempo: " + nombreMejor + " - " + mejor);
            Console.WriteLine("Peor tiempo: " + nombrePeor + " - " + peor);

            Console.WriteLine("\nAtletas que superaron el promedio (menos tiempo):");
            for (int i = 0; i < 5; i++)
            {
                if (tiempos[i] < promedio)
                {
                    Console.WriteLine(nombres[i]);
                }
            }

            Console.ReadKey();
        }
    }
}