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
        // Sistema de Logística: Envíos por Sucursal
        // Una empresa de correo tiene 3 sucursales principales.Cada sucursal procesa una
        // cantidad diferente de paquetes por día dependiendo de su demanda.
        // ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        // ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
        // represente el peso (en kg) de cada paquete enviado.
        // ● Métodos:
        // 1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
        // paquetes se enviaron hoy para definir el tamaño de su fila.
        // 2. Cargar el peso de cada paquete.
        // 3. Imprimir el peso de todos los paquetes organizados por sucursal.
        // 4. Calcular e informar el peso total despachado por cada sucursal.
        // 5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal pertenece.

        class Logistica
        {
            private string[] sucursales;
            private int[][] paquetes;
            private int[] totalSucursal;

            public void Cargar()
            {
                sucursales = new String[3];
                paquetes = new int[3][];
                for (int f = 0; f < sucursales.Length; f++)
                {
                    Console.Write("Ingrese nombre de la sucursal: ");
                    sucursales[f] = Console.ReadLine();
                    Console.Write("Cuántos paquetes envió: ");
                    string linea = Console.ReadLine();
                    linea = Console.ReadLine();
                    int cant = int.Parse(linea);
                    paquetes[f] = new int[cant];
                    for (int c = 0; c < paquetes[f].Length; c++)
                    {
                        Console.Write("Ingrese peso del paquete: ");
                        linea = Console.ReadLine();
                        paquetes[f][c] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < paquetes.Length; f++)
                {
                    Console.WriteLine("Sucursal: " + sucursales[f]);
                    for (int c = 0; c < paquetes[f].Length; c++)
                    {
                        Console.WriteLine("Paquete " + c + ": " + paquetes[f][c] + " kg");
                    }
                }
            }

            public void CalcularTotales()
            {
                totalSucursal = new int[3];
                for (int f = 0; f < paquetes.Length; f++)
                {
                    int suma = 0;
                    for (int c = 0; c < paquetes[f].Length; c++)
                    {
                        suma += paquetes[f][c];
                    }
                    totalSucursal[f] = suma;
                }
            }

            public void MostrarTotales()
            {
                for (int f = 0; f < totalSucursal.Length; f++)
                {
                    Console.WriteLine(sucursales[f] + " Total: " + totalSucursal[f] + " kg");
                }
            }

            public void PaqueteMayor()
            {
                int mayor = paquetes[0][0];
                string nom = sucursales[0];
                for (int f = 0; f < paquetes.Length; f++)
                {
                    for (int c = 0; c < paquetes[f].Length; c++)
                    {
                        if (paquetes[f][c] > mayor)
                        {
                            mayor = paquetes[f][c];
                            nom = sucursales[f];
                        }
                    }
                }
                Console.WriteLine("El paquete más pesado es de " + mayor + " kg y pertenece a " + nom);
            }

            static void Main(string[] args)
            {
                Logistica lg = new Logistica();
                lg.Cargar();
                lg.Imprimir();
                lg.CalcularTotales();
                lg.MostrarTotales();
                lg.PaqueteMayor();
                Console.ReadKey();
            }
        }
    }
}