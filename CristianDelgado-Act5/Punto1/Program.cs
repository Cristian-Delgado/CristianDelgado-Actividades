using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto1:
            // Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            // muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            // Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.

            int numero, f, resultado;
            string linea;

            Console.Write("Ingrese un número del 1 al 10: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            for (f = 1; f <= 13; f++)
            {
                resultado = numero * f;
                Console.WriteLine(numero + " x " + f + " = " + resultado);
            }

            Console.ReadKey();
        }
    }
}