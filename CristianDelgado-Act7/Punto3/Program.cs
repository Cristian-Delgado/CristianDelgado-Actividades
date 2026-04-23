using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Punto3
            //Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas deun videojuego.
            //El programa debe:
            // Mostrar la puntuación más alta y la más baja.
            // Calcular el promedio de puntuación.
            // Contar cuántas veces superó los 500 puntos.

            int[] puntos = new int[6];
            int suma = 0;
            int mayor = int.MinValue;
            int menor = int.MaxValue;
            int mayores500 = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese puntuación: ");
                puntos[i] = int.Parse(Console.ReadLine());

                suma += puntos[i];

                if (puntos[i] > mayor)
                    mayor = puntos[i];

                if (puntos[i] < menor)
                    menor = puntos[i];

                if (puntos[i] > 500)
                    mayores500++;
            }

            double promedio = (double)suma / 6;

            Console.WriteLine("Mayor puntuación: " + mayor);
            Console.WriteLine("Menor puntuación: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Veces que superó 500: " + mayores500);
            Console.ReadKey();
        }
    }
}