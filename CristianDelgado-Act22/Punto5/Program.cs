using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    // Actividad 5: Gestión de Carreras Deportivas
    // Consigna:
    // Crear un sistema para gestionar carreras deportivas.Cada carrera tiene un código,
    // una hora de inicio y una hora de fin.Cada carrera puede registrar varios corredores.
    // Se pide:
    // 1. Crear una clase Carrera con:
    // o Atributos: código, hora de inicio, hora de fin y lista de corredores ya definidos.
    // o Dos constructores (uno por defecto y otro con parámetros).
    // o Método para calcular la duración de la carrera usando TimeSpan.
    // 2. Crear una clase Corredor con:
    // o Atributos: nombre, número de dorsal y tiempo total.
    // o Sobrecarga de métodos para registrar el tiempo total (en minutos o en horas y minutos).
    // 3. Mostrar en consola(usando Console.SetCursorPosition()) :
    // o La carrera con mayor duración.
    // o El corredor más rápido.
    // 4. Utilizar this en los constructores o métodos donde corresponda.
    // 5. Deben ser 4 carreras.

    class Corredor
    {
        public string nombre;
        public int dorsal;
        public int tiempoTotal;

        public Corredor(string nombre, int dorsal)
        {
            this.nombre = nombre;
            this.dorsal = dorsal;
        }

        public void RegistrarTiempo(int minutos)
        {
            tiempoTotal = minutos;
        }

        public void RegistrarTiempo(int horas, int minutos)
        {
            tiempoTotal = (horas * 60) + minutos;
        }
    }

    class Carrera
    {
        public string codigo;
        public DateTime horaInicio;
        public DateTime horaFin;
        public Corredor[] corredores;

        public Carrera()
        {
            codigo = "Cod";
            horaInicio = DateTime.Today.AddHours(8);
            horaFin = DateTime.Today.AddHours(10);
            corredores = new Corredor[2];
        }

        public Carrera(string codigo, DateTime horaInicio, DateTime horaFin)
        {
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            corredores = new Corredor[2];
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
            Carrera[] carreras = new Carrera[4];

            carreras[0] = new Carrera();

            carreras[1] = new Carrera("C1",
                DateTime.Today.AddHours(7),
                DateTime.Today.AddHours(11));

            carreras[2] = new Carrera("C2",
                DateTime.Today.AddHours(9),
                DateTime.Today.AddHours(12));

            carreras[3] = new Carrera("C3",
                DateTime.Today.AddHours(6),
                DateTime.Today.AddHours(13));

            carreras[0].corredores[0] = new Corredor("Luis", 1);
            carreras[0].corredores[0].RegistrarTiempo(120);

            carreras[1].corredores[0] = new Corredor("Ana", 2);
            carreras[1].corredores[0].RegistrarTiempo(1, 30);

            carreras[2].corredores[0] = new Corredor("Pedro", 3);
            carreras[2].corredores[0].RegistrarTiempo(150);

            carreras[3].corredores[0] = new Corredor("Marta", 4);
            carreras[3].corredores[0].RegistrarTiempo(100);

            Carrera mayor = carreras[0];
            Corredor rapido = carreras[0].corredores[0];

            foreach (Carrera c in carreras)
            {
                if (c.Duracion() > mayor.Duracion())
                { 
                    mayor = c;
                }
            }

            foreach (Carrera c in carreras)
            {
                if (c.corredores[0].tiempoTotal < rapido.tiempoTotal)
                {
                    rapido = c.corredores[0];
                }
            }

            Console.SetCursorPosition(1, 1);
            Console.WriteLine("Carrera más larga: " + mayor.codigo);
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("Corredor más rápido: " + rapido.nombre);
            Console.ReadKey();
        }
    }
}