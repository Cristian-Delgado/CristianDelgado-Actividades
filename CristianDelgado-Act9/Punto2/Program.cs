using System;
using System.Collections;
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
            // Punto2:
            // Una empresa registra los nombres de sus 5 vendedores y el total de ventas
            // realizadas por cada uno en un mes.Cargar los nombres y ventas en dos
            // vectores paralelos, ordenar los datos de mayor a menor según las ventas,
            // imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue 
            // el que menos vendió de los 5 empleados. 

            string[] nombres = new string[5];
            int[] ventas = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nombre del vendedor: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ventas: ");
                ventas[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    if (ventas[j] < ventas[j + 1])
                    {
                        int auxVenta = ventas[j];
                        ventas[j] = ventas[j + 1];
                        ventas[j + 1] = auxVenta;

                        string auxNombre = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = auxNombre;
                    }
                }
            }

            Console.WriteLine("\nLista ordenada:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nombres[i] + " - " + ventas[i]);
            }

            Console.WriteLine("\nEl que menos vendió: " + nombres[4] + " - " + ventas[4]);

            Console.ReadKey();
        }
    }
}