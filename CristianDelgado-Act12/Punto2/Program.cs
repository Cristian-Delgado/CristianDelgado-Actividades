using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        // Punto2:
        // Gestión de Complejo de Cine
        // Un cine tiene 4 salas con diferentes capacidades de espectadores(la Sala 1 tiene 10
        // asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
        // ● Definir una matriz irregular de 4 filas para representar los asientos.
        // ● Métodos:
        // 1. Inicializar la matriz con los tamaños de las salas mencionadas(sin intervención del operador).
        // 2. Crear un método de &quot; Venta de Entradas & quot; que permita cargar la edad del espectador en un asiento específico(fila y columna).
        // 3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador en cada asiento.
        // 4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
        // 5. Informar cuál es el promedio de edad de los espectadores de todo el complejo.

        class Cine
        {
            private int[][] salas;

            public void Inicializar()
            {
                salas = new int[4][];

                salas[0] = new int[10];
                salas[1] = new int[15];
                salas[2] = new int[8];
                salas[3] = new int[12];
            }

            public void VentaEntradas()
            {
                Console.Write("Ingrese sala (1-3): ");
                string linea = Console.ReadLine();
                int fila = int.Parse(linea);
                Console.Write("Ingrese asiento: ");
                int col = int.Parse(linea);
                Console.Write("Ingrese edad del espectador: ");
                salas[fila][col] = int.Parse(linea);
            }

            public void Imprimir()
            {
                for (int f = 0; f < salas.Length; f++)
                {
                    for (int c = 0; c < salas[f].Length; c++)
                    {
                        Console.Write(salas[f][c] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void MenoresPorSala()
            {
                for (int f = 0; f < salas.Length; f++)
                {
                    int menores = 0;
                    for (int c = 0; c < salas[f].Length; c++)
                    {
                        if (salas[f][c] > 0 && salas[f][c] < 18)
                        {
                            menores++;
                        }
                    }
                    Console.WriteLine("Sala " + (f + 1) + " tiene " + menores + " menores.");
                }
            }

            public void PromedioEdades()
            {
                int suma = 0;
                int cant = 0;
                for (int f = 0; f < salas.Length; f++)
                {
                    for (int c = 0; c < salas[f].Length; c++)
                    {
                        if (salas[f][c] > 0)
                        {
                            suma += salas[f][c];
                            cant++;
                        }
                    }
                }
                int promedio = suma / cant;
                Console.WriteLine("Promedio de edad: " + promedio);
            }

            static void Main(string[] args)
            {
                Cine ci = new Cine();
                ci.Inicializar();
                ci.VentaEntradas();
                ci.VentaEntradas();
                ci.VentaEntradas();
                ci.Imprimir();
                ci.MenoresPorSala();
                ci.PromedioEdades();
                Console.ReadKey();
            }
        }
    }
}