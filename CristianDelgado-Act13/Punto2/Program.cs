using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        // Punto2:
        // Implementar la clase operaciones. Se deben cargar dos valores enteros en el
        // constructor, calcular su suma, resta, multiplicación y división, cada una en un
        // método, imprimir dichos resultados.

        class Operaciones
        {
            private int valor1, valor2;

            public Operaciones()
            {
                Console.Write("Ingrese primer valor: ");
                string linea = Console.ReadLine();
                valor1 = int.Parse(linea);
                Console.Write("Ingrese segundo valor: ");
                valor2 = int.Parse(linea);
            }

            public void Suma()
            {
                int suma = valor1 + valor2;
                Console.WriteLine("La suma es: " + suma);
            }

            public void Resta()
            {
                int resta = valor1 - valor2;
                Console.WriteLine("La resta es: " + resta);
            }

            public void Multiplicacion()
            {
                int multiplicacion = valor1 * valor2;
                Console.WriteLine("La multiplicación es: " + multiplicacion);
            }

            public void Division()
            {
                if (valor2 != 0)
                {
                    int division = valor1 / valor2;
                    Console.WriteLine("La división es: " + division);
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                }
            }

            static void Main(string[] args)
            {
                Operaciones op = new Operaciones();
                op.Suma();
                op.Resta();
                op.Multiplicacion();
                op.Division();
                Console.ReadKey();
            }
        }
    }
}