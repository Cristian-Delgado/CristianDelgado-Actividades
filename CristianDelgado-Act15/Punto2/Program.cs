using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        // Punto2:
        // Logística de Puerto Espacial
        // Una estación de acoplamiento registra el peso de los contenedores transportados en las
        // bodegas de carga de las naves espaciales que llegan al puerto.
        // ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
        // NombreNave y su constructor para cargarlo.
        // ● Crear la clase colaboradora PuertoControl que contenga:
        // ○ Un vector de 3 objetos de la clase NaveEspacial.
        // ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
        // cada fila representa a una nave, el tamaño de la fila es la cantidad de
        // bodegas que posee esa nave, y los valores almacenados son los pesos (en
        // toneladas) de los contenedores que transporta cada bodega.
        // En PuertoControl, definir los siguientes métodos:
        // 1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
        // cuántas bodegas activas posee(para definir el tamaño de su fila en la matriz
        // irregular) y cargue el peso del contenedor asignado a cada bodega.
        // 2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave espacial.
        // 3. Un método que identifique e informe qué nave transporta el contenedor individual más pesado de todo el puerto espacial
        // (el valor máximo absoluto de la matriz irregular).
        // 4. Un método que indique el nombre de la nave que transporta menor peso acumulado total(la suma de todos sus contenedores).

        class NaveEspacial
        {
            private string nombre;

            public NaveEspacial()
            {
                Console.Write("Ingrese nombre de la nave: ");
                nombre = Console.ReadLine();
            }

            public string RetornarNombre()
            {
                return nombre;
            }
        }

        class PuertoControl
        {
            private NaveEspacial nave1, nave2, nave3;
            private double[][] pesoContenedores;

            public PuertoControl()
            {
                pesoContenedores = new double[3][];

                nave1 = new NaveEspacial();
                nave2 = new NaveEspacial();
                nave3 = new NaveEspacial();
                for (int f = 0; f < 3; f++)
                {
                    Console.Write("Cantidad de bodegas: ");
                    int cant = int.Parse(Console.ReadLine());
                    pesoContenedores[f] = new double[cant];
                    for (int c = 0; c < cant; c++)
                    {
                        Console.Write("Peso: ");
                        pesoContenedores[f][c] = double.Parse(Console.ReadLine());
                    }
                }
            }

            public void MostrarPesos()
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < pesoContenedores[f].Length; c++)
                    {
                        Console.WriteLine(pesoContenedores[f][c]);
                    }
                }
            }

            public void MayorPeso()
            {
                double mayor = pesoContenedores[0][0];

                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < pesoContenedores[f].Length; c++)
                    {
                        if (pesoContenedores[f][c] > mayor)
                        {
                            mayor = pesoContenedores[f][c];
                        }
                    }
                }
                Console.WriteLine("Mayor peso: " + mayor);
            }

            public void MenorPesoTotal()
            {
                double suma1 = 0;
                double suma2 = 0;
                double suma3 = 0;

                for (int c = 0; c < pesoContenedores[0].Length; c++)
                    suma1 += pesoContenedores[0][c];

                for (int c = 0; c < pesoContenedores[1].Length; c++)
                    suma2 += pesoContenedores[1][c];

                for (int c = 0; c < pesoContenedores[2].Length; c++)
                    suma3 += pesoContenedores[2][c];

                if (suma1 < suma2 && suma1 < suma3)
                {
                    Console.WriteLine(nave1.RetornarNombre());
                }
                else
                {
                    if (suma2 < suma3)
                    {
                        Console.WriteLine(nave2.RetornarNombre());
                    }
                    else
                    {
                        Console.WriteLine(nave3.RetornarNombre());
                    }
                }
            }

            static void Main(string[] args)
            {
                PuertoControl puerto = new PuertoControl();
                puerto.MostrarPesos();
                puerto.MayorPeso();
                puerto.MenorPesoTotal();
                Console.ReadKey();
            }
        }
    }
}