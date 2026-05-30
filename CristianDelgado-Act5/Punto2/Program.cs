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

            int n, f;
            int lado1, lado2, lado3;
            int equilatero, isosceles, escaleno;
            string linea;

            equilatero = 0;
            isosceles = 0;
            escaleno = 0;

            Console.Write("Ingrese la cantidad de triangulos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            for (f = 1; f <= n; f++)
            {
                Console.Write("Ingrese lado 1: ");
                lado1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese lado 2: ");
                lado2 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese lado 3: ");
                lado3 = int.Parse(Console.ReadLine());

                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Triángulo Equilátero");
                    equilatero = equilatero + 1;
                }
                else
                {
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        Console.WriteLine("Triángulo Isósceles");
                        isosceles = isosceles + 1;
                    }
                    else
                    {
                        Console.WriteLine("Triángulo Escaleno");
                        escaleno = escaleno + 1;
                    }
                }
            }

            Console.WriteLine("Cantidad de equiláteros: " + equilatero);
            Console.WriteLine("Cantidad de isósceles: " + isosceles);
            Console.WriteLine("Cantidad de escalenos: " + escaleno);

            if (equilatero < isosceles && equilatero < escaleno)
            {
                Console.WriteLine("El tipo con menor cantidad es Equilátero");
            }
            else
            {
                if (isosceles < escaleno)
                {
                    Console.WriteLine("El tipo con menor cantidad es Isósceles");
                }
                else
                {
                    Console.WriteLine("El tipo con menor cantidad es Escaleno");
                }
            }

            Console.ReadKey();
        }
    }
}
