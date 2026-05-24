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

            int nota1, nota2, nota3, nota4, nota5, nota6;
            string linea;

            Console.Write("Ingrese primera nota: ");
            linea = Console.ReadLine();
            nota1 = int.Parse(linea);

            Console.Write("Ingrese segunda nota: ");
            linea = Console.ReadLine();
            nota2 = int.Parse(linea);

            Console.Write("Ingrese tercera nota: ");
            linea = Console.ReadLine();
            nota3 = int.Parse(linea);

            Console.Write("Ingrese cuarta nota: ");
            linea = Console.ReadLine();
            nota4 = int.Parse(linea);

            Console.Write("Ingrese quinta nota: ");
            linea = Console.ReadLine();
            nota5 = int.Parse(linea);

            Console.Write("Ingrese sexta nota: ");
            linea = Console.ReadLine();
            nota6 = int.Parse(linea);

            int promedio = (nota1 + nota2 + nota3 + nota4 + nota5 + nota6) / 6;

            if (promedio >= 7)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                Console.WriteLine("No promocionado");
            }
            Console.ReadKey();
        }
    }
}