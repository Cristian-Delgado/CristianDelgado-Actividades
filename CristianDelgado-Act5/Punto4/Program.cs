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
            // Se cuenta con la siguiente información:
            // ● Las edades de 20 estudiantes del turno mañana.
            // ● Las edades de 30 estudiantes del turno tarde.
            // ● Las edades de 15 estudiantes del turno noche.
            // Las edades de cada estudiante deben ingresarse por teclado.
            // a) Obtener el promedio de las edades de cada turno(tres promedios)
            // b) Imprimir dichos promedios(promedio de cada turno)
            // c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            // promedio de edades menor.

            int edad, f;
            int sumaManana, sumaTarde, sumaNoche;
            int promedioManana, promedioTarde, promedioNoche;

            sumaManana = 0;
            sumaTarde = 0;
            sumaNoche = 0;

            for (f = 1; f <= 20; f++)
            {
                Console.Write("Ingrese edad del estudiante del turno mañana: ");
                edad = int.Parse(Console.ReadLine());
                sumaManana = sumaManana + edad;
            }

            for (f = 1; f <= 30; f++)
            {
                Console.Write("Ingrese edad del estudiante del turno tarde: ");
                edad = int.Parse(Console.ReadLine());
                sumaTarde = sumaTarde + edad;
            }

            for (f = 1; f <= 15; f++)
            {
                Console.Write("Ingrese edad del estudiante del turno noche: ");
                edad = int.Parse(Console.ReadLine());
                sumaNoche = sumaNoche + edad;
            }

            promedioManana = sumaManana / 20;
            promedioTarde = sumaTarde / 30;
            promedioNoche = sumaNoche / 15;

            Console.WriteLine("Promedio turno mañana: " + promedioManana);
            Console.WriteLine("Promedio turno tarde: " + promedioTarde);
            Console.WriteLine("Promedio turno noche: " + promedioNoche);

            if (promedioManana < promedioTarde && promedioManana < promedioNoche)
            {
                Console.WriteLine("El turno mañana tiene el menor promedio de edad.");
            }
            else
            {
                if (promedioTarde < promedioNoche)
                {
                    Console.WriteLine("El turno tarde tiene el menor promedio de edad.");
                }
                else
                {
                    Console.WriteLine("El turno noche tiene el menor promedio de edad.");
                }
            }

            Console.ReadKey();
        }
    }
}