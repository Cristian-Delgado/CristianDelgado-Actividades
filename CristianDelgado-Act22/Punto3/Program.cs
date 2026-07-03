using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    // Actividad 3: Registro de entrenamientos
    // Problema:
    // Plantear una clase Entrenamiento con atributos: deportista y duración(en minutos).
    //  Incluir dos métodos RegistrarDuracion(sobrecarga de métodos):
    // 1. Uno que reciba horas y minutos y los convierta a minutos.
    // 2. Otro que reciba directamente los minutos.
    //  Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el más corto.

    class Entrenamiento
    {
        public string deportista;
        public int duracion;

        public Entrenamiento(string deportista)
        {
            this.deportista = deportista;
        }

        public void RegistrarDuracion(int horas, int minutos)
        {
            duracion = (horas * 60) + minutos;
        }

        public void RegistrarDuracion(int minutos)
        {
            duracion = minutos;
        }
    }

    class Program
    {
        static void Main()
        {
            Entrenamiento[] lista = new Entrenamiento[5];

            lista[0] = new Entrenamiento("Lucas");
            lista[0].RegistrarDuracion(2, 30);

            lista[1] = new Entrenamiento("Juan");
            lista[1].RegistrarDuracion(60);

            lista[2] = new Entrenamiento("Ana");
            lista[2].RegistrarDuracion(90);

            lista[3] = new Entrenamiento("Pedro");
            lista[3].RegistrarDuracion(3, 0);

            lista[4] = new Entrenamiento("Peter");
            lista[4].RegistrarDuracion(45);

            Entrenamiento largo = lista[0];
            Entrenamiento corto = lista[0];
            foreach (Entrenamiento e in lista)
            {
                if (e.duracion > largo.duracion)
                {
                    largo = e;
                }

                else
                {

                    if (e.duracion < corto.duracion)
                    {
                        corto = e;
                    }
                }
            }

            Console.WriteLine("Entrenamiento más largo: " + largo.deportista);
            Console.WriteLine("Entrenamiento más corto: " + corto.deportista);
            Console.ReadKey();
        }
    }
}