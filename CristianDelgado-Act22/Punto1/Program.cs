using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    // Actividad 1: Control de horarios en un gimnasio
    // Problema:
    // Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin(usar DateTime).
    //  Implementar un constructor que permita cargar los datos desde consola y otro que cargue valores por defecto(sobrecarga de constructores).
    //  Incluir un método para calcular la duración de la clase usando TimeSpan.
    //  Crear un vector de 3 clases de gimnasio y mostrar:
    // 1. La clase que tenga la mayor duración.
    // 2. El nombre y el horario de inicio de la clase más temprana.

    class ClaseGimnasio
    {
        public string nombreClase;
        public DateTime horaInicio;
        public DateTime horaFin;

        public ClaseGimnasio()
        {
            nombreClase = "Gimnasio";
            horaInicio = DateTime.Today.AddHours(8);
            horaFin = DateTime.Today.AddHours(10);
        }

        public ClaseGimnasio(string nombre, DateTime inicio, DateTime fin)
        {
            this.nombreClase = nombre;
            this.horaInicio = inicio;
            this.horaFin = fin;
        }

        public TimeSpan Duracion()
        {
            return horaFin - horaInicio;
        }
    }

    class Program
    {
        static void Main()
        {
            ClaseGimnasio[] clases = new ClaseGimnasio[3];

            clases[0] = new ClaseGimnasio("Yoga", DateTime.Today.AddHours(5), DateTime.Today.AddHours(6));
            clases[1] = new ClaseGimnasio("Karate", DateTime.Today.AddHours(9), DateTime.Today.AddHours(12));
            clases[2] = new ClaseGimnasio("Boxeo", DateTime.Today.AddHours(7), DateTime.Today.AddHours(8));

            ClaseGimnasio mayor = clases[0];
            ClaseGimnasio temprano = clases[0];
            foreach (ClaseGimnasio c in clases)
            {
                if (c.Duracion() > mayor.Duracion())
                {
                    mayor = c;
                }

                else
                {
                    if (c.horaInicio < temprano.horaInicio)
                    {
                        temprano = c;
                    }
                }
            }
            Console.WriteLine("Clase más larga: " + mayor.nombreClase);
            Console.WriteLine("Clase más temprana: " + temprano.nombreClase);
            Console.ReadKey();
        }
    }
}