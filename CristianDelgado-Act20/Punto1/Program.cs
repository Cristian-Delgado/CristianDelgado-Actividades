using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    // Punto1:
    // Actividad 1: Sistema de control de vuelos
    // Problema:
    // Una aerolínea administra los vuelos programados mediante un sistema orientado a objetos.
    // Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
    // destino y duración en horas.Luego definir una clase derivada VueloInternacional que
    // herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
    // Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
    // desde consola y luego:
    //  Mostrar los vuelos registrados y el país de destino.
    //  Informar cuál es el vuelo con mayor duración.
    //  Mostrar el orden de ejecución de los constructores.

    class Vuelo
    {
        private string numeroVuelo;
        private string destino;
        private int duracion;

        public string NumeroVuelo
        {
            set
            {
                numeroVuelo = value;
            }
            get
            {
                return numeroVuelo;
            }
        }

        public string Destino
        {
            set
            {
                destino = value;
            }
            get
            {
                return destino;
            }
        }

        public int Duracion
        {
            set
            {
                duracion = value;
            }
            get
            {
                return duracion;
            }
        }

        public Vuelo()
        {
            Console.WriteLine("Constructor Vuelo");
        }
    }

    class VueloInternacional : Vuelo
    {
        private string paisDestino;

        public string PaisDestino
        {
            set
            {
                paisDestino = value;
            }
            get
            {
                return paisDestino;
            }
        }

        public VueloInternacional()
        {
            Console.WriteLine("Constructor Vuelo Internacional");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<VueloInternacional> listaVuelos = new List<VueloInternacional>();

            for (int i = 0; i < 5; i++)
            {
                VueloInternacional v = new VueloInternacional();

                Console.Write("Ingrese número de vuelo: ");
                v.NumeroVuelo = Console.ReadLine();

                Console.Write("Ingrese destino: ");
                v.Destino = Console.ReadLine();

                Console.Write("Ingrese duración: ");
                v.Duracion = int.Parse(Console.ReadLine());

                Console.Write("Ingrese país destino: ");
                v.PaisDestino = Console.ReadLine();

                listaVuelos.Add(v);
            }

            Console.WriteLine("Vuelos cargados:");
            foreach (VueloInternacional v in listaVuelos)
            {
                Console.WriteLine(v.NumeroVuelo + " - " + v.Destino + " - " + v.Duracion + " horas - " + v.PaisDestino);
            }
            int mayor = 0;
            foreach (VueloInternacional v in listaVuelos)
            {
                if (v.Duracion > mayor)
                {
                    mayor = v.Duracion;
                }
            }
            Console.WriteLine("Mayor duración: " + mayor);
            Console.ReadKey();
        }
    }
}