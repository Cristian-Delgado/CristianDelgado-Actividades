using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Punto3:
    //Armar una clase parcial JuegoArcade.
    //En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
    //NivelDificultad(de 1 a 5). Valores cargados desde consola
    //En el segundo archivo, implementar un método que indique si un puntaje ingresado
    //supera el récord o no.
    //Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego.

        partial class JuegoArcade
        {
            private string nombreJuego;
            private int puntajeMaximo;
            private int nivelDificultad;

            public string NombreJuego
            {
                set
                {
                    nombreJuego = value;
                }
                get
                {
                    return nombreJuego;
                }
            }

            public int PuntajeMaximo
            {
                set
                {
                    puntajeMaximo = value;
                }
                get
                {
                    return puntajeMaximo;
                }
            }

            public int NivelDificultad
            {
                set
                {
                    nivelDificultad = value;
                }
                get
                {
                    return nivelDificultad;
                }
            }

            public void VerificarRecord(int puntaje)
            { 
            if (puntaje > PuntajeMaximo)
            {
                Console.WriteLine("Rompió el récord");
            }
            else
            {
                Console.WriteLine("No superó el récord");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                JuegoArcade juego = new JuegoArcade();

                Console.Write("Ingrese nombre del juego: ");
                juego.NombreJuego = Console.ReadLine();
                Console.Write("Ingrese puntaje máximo: ");
                string linea = Console.ReadLine();
                juego.PuntajeMaximo = int.Parse(linea);
                Console.Write("Ingrese nivel: ");
                juego.NivelDificultad = int.Parse(linea);
                for (int f = 1; f <= 4; f++)
                {
                    Console.Write("Ingrese puntaje del jugador: ");
                    int puntaje = int.Parse(Console.ReadLine());
                    juego.VerificarRecord(puntaje);
                }
                Console.ReadKey();
            }
        }
    }
}