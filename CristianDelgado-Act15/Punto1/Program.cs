using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        // Punto1:
        // Monitoreo Clínico de Pacientes
        // En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
        // cardíaco de los pacientes.
        // ● Plantear una clase llamada Paciente que tenga como atributos privados:
        // 1. Nombre(de tipo string).
        // 2. Una matriz llamada ritmoCardiaco de tamaño 3x4(representando los
        // registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
        // clave de cada día: mañana, mediodía, tarde y noche).
        // 3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
        // teclado de las 12 lecturas cardíacas.
        // ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
        // objetos de la clase Paciente.Su constructor debe inicializar el vector y solicitar la
        // carga de los 3 pacientes.Implementar los siguientes métodos dentro de SalaMonitoreo:
        // 1. Un método que imprima la grilla de lecturas cardíacas completa de cada
        // paciente organizada por día y momento.
        // 2. Un método que calcule e imprima el promedio de pulsaciones de cada
        // paciente a lo largo de todo su monitoreo.
        // 3. Un método que verifique si algún paciente registró un evento de taquicardia
        // severa (cualquier lectura individual que sea estrictamente mayor a 120
        // pulsaciones), mostrando por consola su nombre y la lectura detectada.

        class Paciente
        {
            private string nombre;
            private int[,] ritmoCardiaco;

            public Paciente()
            {
                ritmoCardiaco = new int[3, 4];
                Console.Write("Ingrese nombre del paciente: ");
                nombre = Console.ReadLine();
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        Console.Write("Ingrese pulsaciones: ");
                        string linea = Console.ReadLine();
                        ritmoCardiaco[f, c] = int.Parse(linea);
                    }
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Paciente: " + nombre);
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        Console.Write(ritmoCardiaco[f, c] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public void Promedio()
            {
                int suma = 0;
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        suma += ritmoCardiaco[f, c];
                    }
                }
                Console.WriteLine("Promedio de " + nombre + ": " + (suma / 12));
            }

            public void Taquicardia()
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 4; c++)
                    {
                        if (ritmoCardiaco[f, c] > 120)
                        {
                            Console.WriteLine(nombre + " registró taquicardia: " + ritmoCardiaco[f, c]);
                        }
                    }
                }
            }
        }

        class SalaMonitoreo
        {
            private Paciente paciente1, paciente2, paciente3;

            public SalaMonitoreo()
            {
                paciente1 = new Paciente();
                paciente2 = new Paciente();
                paciente3 = new Paciente();
            }

            public void Mostrar()
            {
                paciente1.Imprimir();
                paciente2.Imprimir();
                paciente3.Imprimir();
            }

            public void Promedios()
            {
                paciente1.Promedio();
                paciente2.Promedio();
                paciente3.Promedio();
            }

            public void VerTaquicardia()
            {
                paciente1.Taquicardia();
                paciente2.Taquicardia();
                paciente3.Taquicardia();
            }


            static void Main(string[] args)
            {
                SalaMonitoreo sala = new SalaMonitoreo();
                sala.Mostrar();
                sala.Promedios();
                sala.VerTaquicardia();
                Console.ReadKey();
            }
        }
    }
}