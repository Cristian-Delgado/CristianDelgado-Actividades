using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
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
                    duracionMinutos = value;
                }
                get
                {
                    if (value > 0)
                    {
                        return duracionMinutos;
                    }
                    else
                    {
                        duracionMinutos = 1;
                    }
                }
            }

            public int Calificacion
            {
                set
                {
                    calificacion = value;
                }
                get
                {
                    if (value >= 1 && value <= 5)
                    {
                        return calificacion;
                    }
                    else
                    {
                        calificacion = 1;
                    }
                }
            }
        }

        class Catalogo
        {
            private Pelicula[] peliculas = new Pelicula[3];

            public Catalogo()
            {
                for (int i = 0; i < 3; i++)
                {
                    peliculas[i] = new Pelicula();
                }
            }

            public Pelicula[] Peliculas
            {
                get
                {
                    return peliculas;
                }
            }

            public void Mostrar()
            {
                for (int i = 0; i < peliculas.Length - 1; i++)
                {
                    for (int j = i + 1; j < peliculas.Length; j++)
                    {
                        if (peliculas[i].DuracionMinutos < peliculas[j].DuracionMinutos)
                        {
                            Pelicula aux = peliculas[i];
                            peliculas[i] = peliculas[j];
                            peliculas[j] = aux;
                        }
                    }
                }

                foreach (Pelicula p in peliculas)
                {
                    Console.WriteLine(p.Titulo + " - " + p.DuracionMinutos + " min");
                }
                Pelicula mejor = peliculas[0];
                Pelicula corta = peliculas[0];
                foreach (Pelicula p in peliculas)
                {
                    if (p.Calificacion > mejor.Calificacion)
                    {
                        mejor = p; 
                    }

                    else
                    {
                        (p.DuracionMinutos < corta.DuracionMinutos)
                    }
                        corta = p;
                }

                Console.WriteLine("Mejor película: " + mejor.Titulo);
                Console.WriteLine("Película más corta: " + corta.Titulo);
            }
        }

            static void Main(string[] args)
            {
                Catalogo catalogo = new Catalogo();

                catalogo.Peliculas[0].Titulo = "Titanic";
                catalogo.Peliculas[0].DuracionMinutos = 180;
                catalogo.Peliculas[0].Calificacion = 5;

                catalogo.Peliculas[1].Titulo = "Avatar";
                catalogo.Peliculas[1].DuracionMinutos = 160;
                catalogo.Peliculas[1].Calificacion = 4;

                catalogo.Peliculas[2].Titulo = "Cars";
                catalogo.Peliculas[2].DuracionMinutos = 100;
                catalogo.Peliculas[2].Calificacion = 3;

                catalogo.Mostrar();

                Console.ReadKey();
            }
        }
    }
}
