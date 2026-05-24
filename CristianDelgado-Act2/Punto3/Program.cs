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
            // Punto 3
            // Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el
            // número tiene uno o dos dígitos.(Tener en cuenta que condición debe cumplirse para tener dos dígitos,un número entero)

            int numero;
            string linea;

            Console.Write("Ingrese un número entre 1 y 99: ");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            if (numero < 10)
            {
                Console.WriteLine("El número tiene un dígito");
            }
            else
            {
                Console.WriteLine("El número tiene dos dígitos");
            }
            Console.ReadKey();
        }
    }
}