using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
        class Punto
        {
            private int x, y;

            public void Cargar()
            {
                Console.Write("Ingrese valor de X: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("Ingrese valor de Y: ");
                y = int.Parse(Console.ReadLine());
            }

            public void Cuadrante()
            {
                if (x > 0 && y > 0)
                    Console.WriteLine("Primer cuadrante");
                else if (x < 0 && y > 0)
                    Console.WriteLine("Segundo cuadrante");
                else if (x < 0 && y < 0)
                    Console.WriteLine("Tercer cuadrante");
                else if (x > 0 && y < 0)
                    Console.WriteLine("Cuarto cuadrante");
                else
                    Console.WriteLine("El punto está sobre un eje");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Punto punto1 = new Punto();
                punto1.Cargar();
                punto1.Cuadrante();

                Console.ReadKey();
            }
        }
}