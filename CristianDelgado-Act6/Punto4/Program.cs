using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        // Punto4:
        // Implementar la clase operaciones.Se deben cargar dos valores enteros,
        // calcular su suma, resta, multiplicación y división, cada una en un método,
        // imprimir dichos resultados.

        class Operaciones
        {
            private int valor1, valor2;

            public void Inicializar()
            {
                string linea;

                Console.Write("Ingrese el primer valor: ");
                linea = Console.ReadLine();
                valor1 = int.Parse(linea);

                Console.Write("Ingrese el segundo valor: ");
                linea = Console.ReadLine();
                valor2 = int.Parse(linea);
            }

            public void Suma()
            {
                int suma;
                suma = valor1 + valor2;

                Console.WriteLine("Suma: " + suma);
            }

            public void Resta()
            {
                int resta;
                resta = valor1 - valor2;

                Console.WriteLine("Resta: " + resta);
            }

            public void Multiplicacion()
            {
                int multiplicacion;
                multiplicacion = valor1 * valor2;

                Console.WriteLine("Multiplicación: " + multiplicacion);
            }

            public void Division()
            {
                int division;
                division = valor1 / valor2;

                Console.WriteLine("División: " + division);
            }

            static void Main(string[] args)
            {
                Operaciones op = new Operaciones();

                op.Inicializar();
                op.Suma();
                op.Resta();
                op.Multiplicacion();
                op.Division();

                Console.ReadKey();
            }
        }
    }
}