using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        // Punto4:
        // Plantear una clase Alumno que tenga los atributos privados: nombre y un
        // vector de 4 notas.Definir un constructor que solicite el ingreso del nombre del
        // alumno y sus 4 calificaciones.
        // Luego, confeccionar una clase Curso que contenga un vector de 3 objetos Alumno.
        // Agregar los siguientes métodos:
        // a) Un método que imprima el nombre de cada alumno y su promedio.
        // b) Un método que muestre el nombre del alumno con el promedio más alto.
        // c) Un método que indique qué alumnos tienen al menos una nota desaprobada(nota menor a 6)

        class Alumno
        {
            private string nombre;
            private int[] notas;

            public Alumno()
            {
                notas = new int[4];
                Console.Write("Ingrese nombre del alumno: ");
                nombre = Console.ReadLine();
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Ingrese nota " + (i + 1) + ": ");
                    string linea = Console.ReadLine();
                    notas[i] = int.Parse(linea);
                }
            }

            public string RetornarNombre()
            {
                return nombre;
            }

            public int RetornarPromedio()
            {
                int suma = 0;
                for (int i = 0; i < notas.Length; i++)
                {
                    suma += notas[i];
                }
                return suma / 4;
            }

            public bool TieneDesaprobado()
            {
                for (int i = 0; i < notas.Length; i++)
                {
                    if (notas[i] < 6)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        class Curso
        {
            private Alumno[] alumnos;

            public Curso()
            {
                alumnos = new Alumno[3];
                for (int i = 0; i < alumnos.Length; i++)
                {
                    Console.WriteLine("Cargar alumno " + (i + 1));
                    alumnos[i] = new Alumno();
                }
            }

            public void MostrarPromedios()
            {
                for (int i = 0; i < alumnos.Length; i++)
                {
                    Console.WriteLine("Alumno: " + alumnos[i].RetornarNombre() + " Promedio: " + alumnos[i].RetornarPromedio());
                }
            }

            public void MejorPromedio()
            {
                Alumno mejor = alumnos[0];
                for (int i = 1; i < alumnos.Length; i++)
                {
                    if (alumnos[i].RetornarPromedio() > mejor.RetornarPromedio())
                    {
                        mejor = alumnos[i];
                    }
                }
                Console.WriteLine("El alumno con mejor promedio es: " + mejor.RetornarNombre());
            }

            public void MostrarDesaprobados()
            {
                Console.WriteLine("Alumnos con al menos una nota desaprobada:");
                for (int i = 0; i < alumnos.Length; i++)
                {
                    if (alumnos[i].TieneDesaprobado())
                    {
                        Console.WriteLine(alumnos[i].RetornarNombre());
                    }
                }
            }

            static void Main(string[] args)
            {
                Curso curso = new Curso();
                Console.WriteLine("Promedios:");
                curso.MostrarPromedios();
                curso.MejorPromedio();
                curso.MostrarDesaprobados();
                Console.ReadKey();
            }
        }
    }
}