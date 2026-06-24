using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        // Punto2:
        // Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
        // primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
        // (crearla sin la intervención del operador)
        // Realizar la carga por teclado e imprimir posteriormente.

        class MatrizIrregular
        {
            private int[][] mat;

            public void Cargar()
            {
                mat = new int[5][];

                mat[0] = new int[1];
                mat[1] = new int[2];
                mat[2] = new int[3];
                mat[3] = new int[4];
                mat[4] = new int[5];
                for (int f = 0; f < mat.Length; f++)
                {
                    for (int c = 0; c < mat[f].Length; c++)
                    {
                        Console.Write("Ingrese valor: ");
                        string linea;
                        linea = Console.ReadLine();
                        mat[f][c] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < mat.Length; f++)
                {
                    for (int c = 0; c < mat[f].Length; c++)
                    {
                        Console.Write(mat[f][c] + " ");
                    }

                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            static void Main(string[] args)
            {
                MatrizIrregular ma = new MatrizIrregular();
                ma.Cargar();
                ma.Imprimir();
                Console.ReadKey();
            }
        }
    }
}