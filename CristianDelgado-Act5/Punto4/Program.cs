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
           
            int sumaManiana = 0, sumaTarde = 0, sumaNoche = 0;

            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Edad turno mañana: ");
                sumaManiana += int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Edad turno tarde: ");
                sumaTarde += int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 15; i++)
            {
                Console.Write("Edad turno noche: ");
                sumaNoche += int.Parse(Console.ReadLine());
            }

            double promManiana = sumaManiana / 20.0;
            double promTarde = sumaTarde / 30.0;
            double promNoche = sumaNoche / 15.0;

            Console.WriteLine("\nPromedios:");
            Console.WriteLine("Mañana: " + promManiana);
            Console.WriteLine("Tarde: " + promTarde);
            Console.WriteLine("Noche: " + promNoche);

            if (promManiana < promTarde && promManiana < promNoche)
                Console.WriteLine("El turno con menor promedio es: Mañana");
            else if (promTarde < promManiana && promTarde < promNoche)
                Console.WriteLine("El turno con menor promedio es: Tarde");
            else
                Console.WriteLine("El turno con menor promedio es: Noche");

            Console.ReadKey();
        }
    }
}