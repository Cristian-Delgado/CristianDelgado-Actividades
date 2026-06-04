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
        // Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas deun videojuego.
        // El programa debe:
        //  Mostrar la puntuación más alta y la más baja.
        //  Calcular el promedio de puntuación.
        //  Contar cuántas veces superó los 500 puntos.

        class Videojuego
        {
            private int[] puntos;

            public void Cargar()
            {
                puntos = new int[6];

                for (int f = 0; f < puntos.Length; f++)
                {
                    Console.Write("Ingrese puntuación: ");
                    string linea = Console.ReadLine();
                    puntos[f] = int.Parse(linea);
                }
            }

            public void Procesar()
            {
                int mayor = puntos[0];
                int menor = puntos[0];
                int suma = 0;
                int mayores500 = 0;

                for (int f = 0; f < puntos.Length; f++)
                {
                    suma = suma + puntos[f];

                    if (puntos[f] > mayor)
                    {
                        mayor = puntos[f];
                    }

                    if (puntos[f] < menor)
                    {
                        menor = puntos[f];
                    }

                    if (puntos[f] > 500)
                    {
                        mayores500++;
                    }
                }

                int promedio = suma / puntos.Length;

                Console.WriteLine("Puntuación más alta: " + mayor);
                Console.WriteLine("Puntuación más baja: " + menor);
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("Cantidad de veces que superó 500 puntos: " + mayores500);

                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                Videojuego v = new Videojuego();
                v.Cargar();
                v.Procesar();
            }
        }
    }
}
