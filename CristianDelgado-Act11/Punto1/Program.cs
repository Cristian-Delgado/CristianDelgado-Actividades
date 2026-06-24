using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        // Punto1:
        // Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
        // dato las temperaturas medias mensuales de dichos paises.
        // Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
        // Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos el memoria.
        // a.Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
        // b.Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
        // c.Calcular la temperatura media trimestral de cada país.
        // d.Imprimir los nombres de los paises y las temperaturas medias trimestrales.
        // e.Imprimir el nombre del país con la temperatura media trimestral mayor.

        class Temperaturas
        {
            private string[] paises;
            private int[,] temperaturas;
            private int[] promedioTrimestral;

            public void Cargar()
            {
                paises = new String[4];
                temperaturas = new int[4, 3];
                for (int f = 0; f < paises.Length; f++)
                {
                    Console.Write("Ingrese nombre del país: ");
                    paises[f] = Console.ReadLine();
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write("Ingrese temperatura del mes " + (c + 1) + ": ");
                        string linea;
                        linea = Console.ReadLine();
                        temperaturas[f, c] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Temperaturas ingresadas:");

                for (int f = 0; f < paises.Length; f++)
                {
                    Console.Write(paises[f] + ": ");

                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write(temperaturas[f, c] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void CalcularPromedios()
            {
                promedioTrimestral = new int[4];
                for (int f = 0; f < 4; f++)
                {
                    int suma = 0;
                    for (int c = 0; c < 3; c++)
                    {
                        suma += temperaturas[f, c];
                    }
                    promedioTrimestral[f] = suma / 3;
                }
            }

            public void ImprimirPromedios()
            {
                Console.WriteLine("Promedios trimestrales:");
                for (int f = 0; f < paises.Length; f++)
                {
                    Console.WriteLine(paises[f] + " - " + promedioTrimestral[f]);
                }
            }

            public void MayorTemperatura()
            {
                int mayor = promedioTrimestral[0];
                string paisMayor = paises[0];
                for (int f = 1; f < promedioTrimestral.Length; f++)
                {
                    if (promedioTrimestral[f] > mayor)
                    {
                        mayor = promedioTrimestral[f];
                        paisMayor = paises[f];
                    }
                }
                Console.WriteLine("País con mayor temperatura media trimestral:" + paisMayor + " - " + mayor);
            }

            static void Main(string[] args)
            {
                Temperaturas t = new Temperaturas();
                t.Cargar();
                t.Imprimir();
                t.CalcularPromedios();
                t.ImprimirPromedios();
                t.MayorTemperatura();
                Console.ReadKey();
            }
        }
    }
}