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
        // Competencia de Atletismo
        // Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos(tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
        // Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
        // Definir los siguientes métodos en la clase Carrera:
        // 1. Un constructor que cargue los datos de los 3 atletas de la carrera.
        // 2. Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
        // 3. Un método que calcule e imprima el tiempo promedio de la carrera.
        // 4. Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
        // 5. Un método que muestre a los atletas que superaron el promedio.

        class Atleta
        {
            private string nombre;
            private int tiempoSegundos;

            public Atleta()
            {
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese tiempo en segundos: ");
                string linea = Console.ReadLine();
                tiempoSegundos = int.Parse(linea);
            }

            public string RetornarNombre()
            {
                return nombre;
            }

            public int RetornarTiempo()
            {
                return tiempoSegundos;
            }
        }

        class Carrera
        {
            private Atleta atleta1, atleta2, atleta3;

            public Carrera()
            {
                atleta1 = new Atleta();
                atleta2 = new Atleta();
                atleta3 = new Atleta();
            }

            public void MostrarAtletas()
            {
                Console.WriteLine(atleta1.RetornarNombre() + " - " + atleta1.RetornarTiempo());
                Console.WriteLine(atleta2.RetornarNombre() + " - " + atleta2.RetornarTiempo());
                Console.WriteLine(atleta3.RetornarNombre() + " - " + atleta3.RetornarTiempo());
            }

            public void Promedio()
            {
                int promedio =   atleta1.RetornarTiempo() +
                                 atleta2.RetornarTiempo() +
                                 atleta3.RetornarTiempo() / 3;
                Console.WriteLine("Promedio: " + promedio);
            }

            public void Ganador()
            {
                Atleta ganador = atleta1;
                if (atleta2.RetornarTiempo() < ganador.RetornarTiempo())
                {
                    ganador = atleta2;
                }
                else
                {
                    if (atleta3.RetornarTiempo() < ganador.RetornarTiempo())
                    {
                        ganador = atleta3;
                    }
                }
                Console.WriteLine("Ganador: " + ganador.RetornarNombre());
            }

            static void Main(string[] args)
            {
                Carrera carrera = new Carrera();
                carrera.MostrarAtletas();
                carrera.Promedio();
                carrera.Ganador();
                Console.ReadKey();
            }
        }
    }
}