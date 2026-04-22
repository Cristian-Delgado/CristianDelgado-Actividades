using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
        class Empleado
        {
            private string nombre;
            private double sueldo;

            public void Cargar()
            {
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese sueldo: ");
                sueldo = double.Parse(Console.ReadLine());
            }

            public void Imprimir()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Sueldo: " + sueldo);
            }

            public void PagaImpuestos()
            {
                if (sueldo > 3000)
                    Console.WriteLine("Debe pagar impuestos");
                else
                    Console.WriteLine("No paga impuestos");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Empleado emp = new Empleado();
                emp.Cargar();
                emp.Imprimir();
                emp.PagaImpuestos();

                Console.ReadKey();
            }
        }
}