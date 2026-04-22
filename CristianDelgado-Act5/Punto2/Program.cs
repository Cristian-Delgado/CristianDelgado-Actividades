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
            // Punto2:
            // Realizar un programa que lea los lados de n triángulos, e informar:
            // a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados
            // iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            // b) Cantidad de triángulos de cada tipo.
            // c) Tipo de triángulo que posee menor cantidad.
            
            int n;
            int equilatero = 0, isosceles = 0, escaleno = 0;

            Console.Write("Ingrese la cantidad de triángulos: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Triángulo {i}:");

                Console.Write("Lado 1: ");
                int l1 = int.Parse(Console.ReadLine());
                Console.Write("Lado 2: ");
                int l2 = int.Parse(Console.ReadLine());
                Console.Write("Lado 3: ");
                int l3 = int.Parse(Console.ReadLine());

                if (l1 == l2 && l1 == l3)
                {
                    Console.WriteLine("Equilátero");
                    equilatero++;
                }
                else if (l1 == l2 || l1 == l3 || l2 == l3)
                {
                    Console.WriteLine("Isósceles");
                    isosceles++;
                }
                else
                {
                    Console.WriteLine("Escaleno");
                    escaleno++;
                }
            }

            Console.WriteLine("\nCantidad de cada tipo:");
            Console.WriteLine("Equiláteros: " + equilatero);
            Console.WriteLine("Isósceles: " + isosceles);
            Console.WriteLine("Escalenos: " + escaleno);

            int menor = Math.Min(equilatero, Math.Min(isosceles, escaleno));

            if (menor == equilatero)
                Console.WriteLine("Tipo con menor cantidad: Equilátero");
            else if (menor == isosceles)
                Console.WriteLine("Tipo con menor cantidad: Isósceles");
            else
                Console.WriteLine("Tipo con menor cantidad: Escaleno");

            Console.ReadKey();
        }
    }
}
