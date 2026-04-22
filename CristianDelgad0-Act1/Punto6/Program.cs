using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto6:
            // Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) de una persona, y mostrar
            // por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).
            
            Console.Write("Ingrese su peso (kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su altura (m): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Su IMC es: " + imc);

            Console.ReadKey();
        }
    }
}