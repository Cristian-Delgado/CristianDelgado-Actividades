using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        // Punto4:
        // Línea de Ensamblaje Robótico
        // En una planta de fabricación automatizada, cada robot industrial realiza tareas de
        // ensamblaje complejas divididas en operaciones secundarias de duración variable.
        // ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
        // 1. ModeloRobot.
        // 2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
        // fila representa una de las 4 fases principales del proceso (Estructura,
        // Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
        // completar las distintas subtareas de esa fase(por ejemplo, en la fase de
        // Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene 1).
        // 3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
        // cada una de las 4 fases de fabricación cuántas sub - tareas requirió realizar
        // (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada una de ellas.
        // ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
        // RobotEnsamblador.Implementar en PlantaIndustrial:
        // 1. Un constructor que cargue la información de los 3 robots instalados en la planta.
        // 2. Un método que muestre un reporte detallado con los tiempos de operación
        // de cada robot fase por fase.
        // 3. Un método que calcule el promedio general de tiempo por tarea de cada
        // robot y declare al &quot; Robot más Eficiente & quot; (aquel que registre el promedio de
        // tiempo por operación más bajo de la planta).


        class RobotEnsamblador
        {
            private string modeloRobot;
            private float[][] tiemposOperacion;

            public RobotEnsamblador()
            {
                tiemposOperacion = new float[4][];
                Console.Write("Ingrese modelo del robot: ");
                modeloRobot = Console.ReadLine();
                for (int f = 0; f < 4; f++)
                {
                    Console.Write("Cantidad de subtareas: ");
                    int cant = int.Parse(Console.ReadLine());
                    tiemposOperacion[f] = new float[cant];
                    for (int c = 0; c < cant; c++)
                    {
                        Console.Write("Tiempo en segundos: ");
                        tiemposOperacion[f][c] = float.Parse(Console.ReadLine());
                    }
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Modelo: " + modeloRobot);

                for (int f = 0; f < tiemposOperacion.Length; f++)
                {
                    for (int c = 0; c < tiemposOperacion[f].Length; c++)
                    {
                        Console.Write(tiemposOperacion[f][c] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public float Promedio()
            {
                float suma = 0;
                int cantidad = 0;

                for (int f = 0; f < tiemposOperacion.Length; f++)
                {
                    for (int c = 0; c < tiemposOperacion[f].Length; c++)
                    {
                        suma += tiemposOperacion[f][c];
                        cantidad++;
                    }
                }

                return suma / cantidad;
            }
        }


        class PlantaIndustrial
        {
            private RobotEnsamblador robot1, robot2, robot3;

            public PlantaIndustrial()
            {
                robot1 = new RobotEnsamblador();
                robot2 = new RobotEnsamblador();
                robot3 = new RobotEnsamblador();
            }

            public void Mostrar()
            {
                robot1.Imprimir();
                robot2.Imprimir();
                robot3.Imprimir();
            }

            public void RobotEficiente()
            {
                float p1 = robot1.Promedio();
                float p2 = robot2.Promedio();
                float p3 = robot3.Promedio();

                if (p1 < p2 && p1 < p3)
                {
                    Console.WriteLine("Robot 1 es el más eficiente");
                }
                else
                {
                    if (p2 < p3)
                    {
                        Console.WriteLine("Robot 2 es el más eficiente");
                    }
                    else
                    {
                        Console.WriteLine("Robot 3 es el más eficiente");
                    }
                }
            }

            static void Main(string[] args)
            {
                PlantaIndustrial planta = new PlantaIndustrial();
                planta.Mostrar();
                planta.RobotEficiente();
                Console.ReadKey();
            }
        }
    }
}