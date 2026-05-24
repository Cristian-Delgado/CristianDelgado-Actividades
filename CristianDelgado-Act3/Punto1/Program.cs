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
            // Punto 1:
            // Realizar un programa que pida cargar una fecha cualquiera, luego verificar
            // si dicha fecha corresponde a Navidad.

            int dia, mes, año;
            string linea;

            Console.Write("Ingrese el día: ");
            linea = Console.ReadLine();
            dia = int.Parse(linea);

            Console.Write("Ingrese el mes: ");
            linea = Console.ReadLine();
            mes = int.Parse(linea);

            Console.Write("Ingrese el año: ");
            linea = Console.ReadLine();
            año = int.Parse(linea);

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("La fecha corresponde a Navidad");
            }
            else
            {
                Console.WriteLine("La fecha no corresponde a Navidad");
            }
            Console.ReadKey();
        }
    }
}