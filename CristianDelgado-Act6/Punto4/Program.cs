using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
        class Operaciones
        {
            private int num1, num2;

            public void Cargar()
            {
                Console.Write("Ingrese primer valor: ");
                num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese segundo valor: ");
                num2 = int.Parse(Console.ReadLine());
            }

            public void Suma()
            {
                Console.WriteLine("Suma: " + (num1 + num2));
            }

            public void Resta()
            {
                Console.WriteLine("Resta: " + (num1 - num2));
            }

            public void Multiplicacion()
            {
                Console.WriteLine("Multiplicación: " + (num1 * num2));
            }

            public void Division()
            {
                if (num2 != 0)
                    Console.WriteLine("División: " + (num1 / num2));
                else
                    Console.WriteLine("No se puede dividir por cero");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Operaciones op = new Operaciones();
                op.Cargar();
                op.Suma();
                op.Resta();
                op.Multiplicacion();
                op.Division();

                Console.ReadKey();
            }
        }
}