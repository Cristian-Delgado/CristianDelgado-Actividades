using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        // Punto3:
        // Confeccionar una clase que represente un empleado. Definir como atributos su
        // nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
        // sus datos y por último uno que imprima un mensaje si debe pagar impuestos
        // (si el sueldo supera a 3000).

        class Empleado
        {
            private string nombre;
            private int sueldo;

            public void Inicializar()
            {
                string linea;

                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese el sueldo: ");
                linea = Console.ReadLine();
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
                    Console.WriteLine("Debe pagar impuestos");
                }
                else
                {
                    Console.WriteLine("No debe pagar impuestos");
                }
            }

            static void Main(string[] args)
            {
                Empleado emp = new Empleado();

                emp.Inicializar();
                emp.Imprimir();
                emp.PagaImpuestos();

                Console.ReadKey();
            }
        }
    }
}