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
            // Punto3:
            // Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            // ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
            // valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
            
            int valor;
            int suma = 0;

            do
            {
                Console.Write("Ingrese un valor (9999 para finalizar): ");
                valor = int.Parse(Console.ReadLine());

                if (valor != 9999)
                {
                    suma += valor;
                }

            } while (valor != 9999);

            Console.WriteLine("Valor acumulado: " + suma);

            if (suma > 0)
            {
                Console.WriteLine("El resultado es mayor a cero");
            }
            else if (suma < 0)
            {
                Console.WriteLine("El resultado es menor a cero");
            }
            else
            {
                Console.WriteLine("El resultado es cero");
            }

            Console.ReadKey();
        }
    }
}