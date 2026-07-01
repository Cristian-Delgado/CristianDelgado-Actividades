using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        // Punto2:
        // Catálogo de Películas (Encapsulación, Validación y Composición)
        // Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
        // La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
        // (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
        // asegurando mediante validaciones lógicas que:
        //  La duración en minutos sea estrictamente mayor a cero(0).
        //  La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar un valor por defecto de 1).
        // La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
        // la clase Pelicula.Definir un método dentro de Catalogo para mostrar por pantalla todas las
        // películas ordenadas de mayor a menor en base a su duración.Además, el método debe
        // informar el título de la película con mejor calificación y cuál es la película más corta del catálogo.

        class Pelicula
        {
            private string titulo;
            private int duracionMinutos;
            private int calificacion;

            public string Titulo
            {
                set
                {
                    titulo = value;
                }
                get
                {
                    return titulo;
                }
            }

            public int DuracionMinutos
            {
                set
                {
                    if (value > 0)
                    {
                        duracionMinutos = value;
                    }
                }
                get
                {
                    return duracionMinutos;
                }
            }

            public int Calificacion
            {
                set
                {
                    if (value >= 1 && value <= 5)
                    {
                        calificacion = value;
                    }
                    else
                    {
                        calificacion = 1;
                    }
                }
                get
                {
                    return calificacion;
                }
            }
        }


        class Catalogo
        {
            private Pelicula[] peliculas = new Pelicula[3];

            public Catalogo()
            {
                peliculas = new Pelicula[3];
                for (int f = 0; f < peliculas.Length; f++)
                {
                    peliculas[f] = new Pelicula();
                }
            }

            public void Cargar()
            {
                peliculas[0].Titulo = "Batman";
                peliculas[0].DuracionMinutos = 180;
                peliculas[0].Calificacion = 5;

                peliculas[1].Titulo = "Avatar";
                peliculas[1].DuracionMinutos = 160;
                peliculas[1].Calificacion = 4;

                peliculas[2].Titulo = "Iro man";
                peliculas[2].DuracionMinutos = 100;
                peliculas[2].Calificacion = 3;
            }

            public void Mostrar()
            {
                int mejor = 0;
                int corta = 0;
                Console.WriteLine("Peliculas cargadas:");
                for (int f = 0; f < peliculas.Length; f++)
                {
                    Console.WriteLine(peliculas[f].Titulo + " - " + peliculas[f].DuracionMinutos + " minutos");

                    if (peliculas[f].Calificacion > peliculas[mejor].Calificacion)
                    {
                        mejor = f;
                    }

                    else
                    {
                        if (peliculas[f].DuracionMinutos < peliculas[corta].DuracionMinutos)
                        {
                            corta = f;
                        }
                    }
                }

                Console.WriteLine("Mejor calificada: " + peliculas[mejor].Titulo);
                Console.WriteLine("Película más corta: " + peliculas[corta].Titulo);
            }
        }

        class prueba
        {
            static void Main(string[] args)
            {
                Catalogo catalogo1 = new Catalogo();
                catalogo1.Cargar();
                catalogo1.Mostrar();

                Console.ReadKey();
            }
        }
    }
}