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
        // Desarrollar una clase que represente un punto en el plano y tenga los
        // siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
        // encuentra dicho punto(concepto matemático, primer cuadrante si x e y son
        // positivas, si x&lt; 0 e y&gt; 0 segundo cuadrante, etc.)

        class Punto
        {
            private int x, y;

            public void Inicializar()
            {
                string linea;

                Console.Write("Ingrese coordenada x: ");
                linea = Console.ReadLine();
                x = int.Parse(linea);

                Console.Write("Ingrese coordenada y: ");
                linea = Console.ReadLine();
                y = int.Parse(linea);
            }

            public void Cuadrante()
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primer cuadrante");
                }
                else
                {
                    if (x < 0 && y > 0)
                    {
                        Console.WriteLine("Segundo cuadrante");
                    }
                    else
                    {
                        if (x < 0 && y < 0)
                        {
                            Console.WriteLine("Tercer cuadrante");
                        }
                        else
                        {
                            if (x > 0 && y < 0)
                            {
                                Console.WriteLine("Cuarto cuadrante");
                            }
                        }
                    }
                }
            }

            static void Main(string[] args)
            {
                Punto p = new Punto();
                p.Inicializar();
                p.Cuadrante();
                Console.ReadKey();
            }
        }
    }
}