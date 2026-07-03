using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    // Actividad 4: Gestión de vuelos
    // Problema:
    // Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada(DateTime).
    //  Usar la palabra clave this en el constructor para diferenciar los parámetros de
    // los atributos.
    //  Crear un método para calcular la duración del vuelo (TimeSpan).
    //  Cargar un vector con 4 vuelos y mostrar:
    // 1. El código y duración del vuelo más largo.
    // 2. El código del vuelo que salga más temprano.
    class Vuelo
    {
        public string codigo;
        public DateTime horaSalida;
        public DateTime horaLlegada;

        public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan Duracion()
        {
            return horaLlegada - horaSalida;
        }
    }

    class Program
    {
        static void Main()
        {
            Vuelo[] vuelos = new Vuelo[4];

            vuelos[0] = new Vuelo("A1", DateTime.Today.AddHours(8), DateTime.Today.AddHours(10));
            vuelos[1] = new Vuelo("B2", DateTime.Today.AddHours(6), DateTime.Today.AddHours(11));
            vuelos[2] = new Vuelo("C3", DateTime.Today.AddHours(9), DateTime.Today.AddHours(12));
            vuelos[3] = new Vuelo("D4", DateTime.Today.AddHours(7), DateTime.Today.AddHours(8));

            Vuelo largo = vuelos[0];
            Vuelo temprano = vuelos[0];
            foreach (Vuelo v in vuelos)
            {
                if (v.Duracion() > largo.Duracion())
                {
                    largo = v;
                }

                else
                {
                    if (v.horaSalida < temprano.horaSalida)
                    {
                        temprano = v;
                    }
                }
            }

            Console.WriteLine("Vuelo más largo: " + largo.codigo);
            Console.WriteLine("Vuelo más temprano: " + temprano.codigo);
            Console.ReadKey();
        }
    }
}