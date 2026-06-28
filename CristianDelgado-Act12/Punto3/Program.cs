using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        // Punto3:
        // Academia de Gastronomía: Recetario Dinámico
        // Un chef instructor evalúa a 3 alumnos en un examen final.Cada alumno debe presentar
        // una cantidad distinta de platos(uno presenta 2 platos, otro 4 y otro 3).
        // ● Definir un vector para los nombres de los alumnos.
        // ● Definir una matriz irregular para cargar el puntaje obtenido(0 a 100) en cada plato
        // presentado.
        // ● Métodos:
        // 1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
        // de cada alumno.
        // 2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
        // 3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
        // 4. Calcular el puntaje promedio de cada alumno e informar si está &quot; Aprobado&quot;
        // (promedio &gt;= 70) o &quot;Reprobado&quot;.
        // 5. Determinar quién obtuvo el puntaje individual más alto en un solo plato(el
        // valor máximo de la matriz).

        class Gastronomia
        {
            private string[] alumnos;
            private int[][] puntajes;

            public void Cargar()
            {
                alumnos = new String[3];
                puntajes = new int[3][];
                int[] platos = { 2, 4, 3 };
                for (int f = 0; f < alumnos.Length; f++)
                {
                    Console.Write("Ingrese nombre del alumno: ");
                    alumnos[f] = Console.ReadLine();
                    puntajes[f] = new int[platos[f]];
                    for (int c = 0; c < puntajes[f].Length; c++)
                    {
                        int nota;
                        string linea;
                        do
                        {
                            Console.Write("Ingrese puntaje (0-100): ");
                            linea = Console.ReadLine();
                            nota = int.Parse(linea);
                        } while (nota < 0 || nota > 100);
                        puntajes[f][c] = nota;
                    }
                }
            }

            public void Mostrar()
            {
                for (int f = 0; f < alumnos.Length; f++)
                {
                    Console.WriteLine("Alumno: " + alumnos[f]);
                    for (int c = 0; c < puntajes[f].Length; c++)
                    {
                        Console.WriteLine("Plato " + c + ": " + puntajes[f][c]);
                    }
                }
            }

            public void Promedios()
            {
                for (int f = 0; f < alumnos.Length; f++)
                {
                    int suma = 0;
                    for (int c = 0; c < puntajes[f].Length; c++)
                    {
                        suma += puntajes[f][c];
                    }
                    int promedio = (int)suma / puntajes[f].Length;
                    if (promedio >= 70)
                    {
                        Console.WriteLine(alumnos[f] + " Aprobado con " + promedio);
                    }
                    else
                    {
                        Console.WriteLine(alumnos[f] + " Reprobado con " + promedio);
                    }
                }
            }

            public void MejorPlato()
            {
                int mayor = puntajes[0][0];
                string nom = alumnos[0];
                for (int f = 0; f < puntajes.Length; f++)
                {
                    for (int c = 0; c < puntajes[f].Length; c++)
                    {
                        if (puntajes[f][c] > mayor)
                        {
                            mayor = puntajes[f][c];
                            nom = alumnos[f];
                        }
                    }
                }
                Console.WriteLine("El mejor puntaje fue " + mayor + " y pertenece a " + nom);
            }

            static void Main(string[] args)
            {
                Gastronomia ga = new Gastronomia();
                ga.Cargar();
                ga.Mostrar();
                ga.Promedios();
                ga.MejorPlato();
                Console.ReadKey();
            }
        }
    }
}