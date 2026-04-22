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
            // Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo
            // (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).

            Console.Write("Ingrese el lado del cuadrado: ");
            double lado = double.Parse(Console.ReadLine());

            double perimetro = lado * 4;

            Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
            Console.ReadKey();
        }
    }
}