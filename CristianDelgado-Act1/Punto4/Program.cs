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
            // Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.
            // Mostrar lo que debe abonar el comprador.

            Console.Write("Ingrese el precio del artículo: ");
            int precio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad: ");
            int cantidad = int.Parse(Console.ReadLine());
            int total = precio * cantidad;
            Console.WriteLine("El total a abonar es: " + total);
            Console.ReadKey();
        }
    }
}