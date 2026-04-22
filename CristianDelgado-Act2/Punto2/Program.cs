using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
   internal class Program
    {
        static void Main(string[] args)
        {
            // Punto 2
            // Se ingresan seis notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"

            double n1, n2, n3, n4, n5, n6, promedio;

            Console.Write("Nota 1: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Nota 2: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Nota 3: ");
            n3 = double.Parse(Console.ReadLine());

            Console.Write("Nota 4: ");
            n4 = double.Parse(Console.ReadLine());

            Console.Write("Nota 5: ");
            n5 = double.Parse(Console.ReadLine());

            Console.Write("Nota 6: ");
            n6 = double.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3 + n4 + n5 + n6) / 6;

            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            Console.ReadKey();
        }
    }
}