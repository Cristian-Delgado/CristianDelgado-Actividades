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
        // Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
        // elementos.Obtener la suma de los dos vectores, dicho resultado guardarlo en un
        // tercer vector del mismo tamaño.Sumar componente a componente.

        class Vector2
        {
            private int[] vector1;
            private int[] vector2;
            private int[] vectorSuma;

            public void Cargar()
            {
                vector1 = new int[4];
                vector2 = new int[4];
                vectorSuma = new int[4];

                Console.WriteLine("Primer vector");

                for (int f = 0; f < vector1.Length; f++)
                {
                    Console.Write("Ingrese valor: ");
                    string linea = Console.ReadLine();
                    vector1[f] = int.Parse(linea);
                }

                Console.WriteLine("Segundo vector");

                for (int f = 0; f < vector2.Length; f++)
                {
                    Console.Write("Ingrese valor: ");
                    string linea = Console.ReadLine();
                    vector2[f] = int.Parse(linea);
                }
            }

            public void Sumar()
            {
                for (int f = 0; f < vectorSuma.Length; f++)
                {
                    vectorSuma[f] = vector1[f] + vector2[f];
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Vector resultado:");

                for (int f = 0; f < vectorSuma.Length; f++)
                {
                    Console.WriteLine(vectorSuma[f]);
                }

                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                Vector2 v = new Vector2();
                v.Cargar();
                v.Sumar();
                v.Imprimir();
            }
        }
    }
}
