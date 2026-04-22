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

            Console.Write("Ingrese el día: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el mes: ");
            int mes = int.Parse(Console.ReadLine());

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("Es Navidad");
            }
            else
            {
                Console.WriteLine("No es Navidad");
            }
            Console.ReadKey();
        }
    }
}