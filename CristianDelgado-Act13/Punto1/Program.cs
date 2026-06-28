using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        // Punto1:
        // Confeccionar una clase que represente un empleado. Definir como atributos su
        // nombre y su sueldo.En el constructor cargar los atributos y luego en otro
        // método imprimir sus datos y por último uno que imprima un mensaje si debe
        // pagar impuestos (si el sueldo supera a 3000)

        class Empleado
        {
            private string nombre;
            private int sueldo;

            public Empleado()
            {
                Console.Write("Ingrese nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese sueldo: ");
                string linea = Console.ReadLine();
                sueldo = int.Parse(linea);
            }

            public void Imprimir()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Sueldo: " + sueldo);
            }

            public void PagaImpuestos()
            {
                if (sueldo > 3000)
                {
                    Console.WriteLine(nombre + " debe pagar impuestos.");
                }
                else
                {
                    Console.WriteLine(nombre + " no debe pagar impuestos.");
                }
            }

            static void Main(string[] args)
            {
                Empleado empleado1 = new Empleado();
                empleado1.Imprimir();
                empleado1.PagaImpuestos();
                Console.ReadKey();
            }
        }
    }
}