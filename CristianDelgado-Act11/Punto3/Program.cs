using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        // Punto3:
        // Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
        // Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
        // irregular para cargar los días que han faltado cada empleado(cargar el número de día que faltó)
        // Cada fila de la matriz representa los días de cada empleado.
        // a.Mostrar los empleados con la cantidad de inasistencias.
        // b.Cuál empleado faltó menos días.

        class Empleados
        {
            private string[] nombres;
            private int[][] faltas;

            public void Cargar()
            {
                nombres = new string[3];
                faltas = new int[3][];
                for (int f = 0; f < nombres.Length; f++)
                {
                    Console.Write("Ingrese nombre del empleado: ");
                    nombres[f] = Console.ReadLine();
                    Console.Write("Cuántos días faltó ");
                    string linea = Console.ReadLine();
                    int cantidad = int.Parse(linea);
                    faltas[f] = new int[cantidad];
                    for (int c = 0; c < cantidad; c++)
                    {
                        Console.Write("Ingrese día de falta: ");
                        linea = Console.ReadLine();
                        faltas[f][c] = int.Parse(linea);
                    }
                }
            }

            public void MostrarInasistencias()
            {
                Console.WriteLine("Cantidad de inasistencias:");
                for (int f = 0; f < nombres.Length; f++)
                {
                    Console.WriteLine(nombres[f] + " - " + faltas[f].Length + " faltas");
                }
            }

            public void EmpleadoMenosFaltas()
            {
                int menor = faltas[0].Length;
                string nombre = nombres[0];
                for (int f = 1; f < nombres.Length; f++)
                {
                    if (faltas[f].Length < menor)
                    {
                        menor = faltas[f].Length;
                        nombre = nombres[f];
                    }
                }
                Console.WriteLine("Empleado con menos faltas:" + nombre + "-" + menor + "faltas");
            }

            static void Main(string[] args)
            {
                Empleados e = new Empleados();
                e.Cargar();
                e.MostrarInasistencias();
                e.EmpleadoMenosFaltas();
                Console.ReadKey();
            }
        }
    }
}