using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto10
{
    // Punto10:
    // Un estacionamiento medido administra el ingreso y la salida de los vehículos que utilizan su playa por orden de llegada.
    //  Crear la clase Ticket que contenga como atributos privados: patente
    // (string) y horasEstadia(int). Definir sus propiedades de solo lectura y un constructor que reciba pat y hs.
    //  Crear la clase GestionEstacionamiento que administre una lista dinámica de tickets (List).
    //  Métodos en GestionEstacionamiento:
    // o RegistrarIngreso(): Solicitar por teclado los datos de un ticket y agregarlo al final de la lista utilizando .Add().
    // o ProcesarSalida(): Si la lista no está vacía, simular la salida del primer vehículo de la lista (mostrar sus datos en consola) y
    // removerlo de la colección mediante.RemoveAt(0). Si está vacía, advertir que no hay vehículos esperando salida.
    // o MostrarVehiculosEstacionados(): Listar todos los vehículos alojados en la playa y la cantidad total de unidades presentes
    // utilizando la propiedad.Count.

    class Ticket
    {
        private string patente;
        private int horasEstadia;

        public string Patente
        {
            get { return patente; }
        }

        public int HorasEstadia
        {
            get { return horasEstadia; }
        }

        public Ticket(string pat, int hs)
        {
            this.patente = pat;
            this.horasEstadia = hs;
        }
    }

    class GestionEstacionamiento
    {
        private List<Ticket> tickets;

        public GestionEstacionamiento()
        {
            tickets = new List<Ticket>();
        }

        public void RegistrarIngreso()
        {
            Console.Write("Ingresar patente: ");
            string patente = Console.ReadLine();

            Console.Write("Ingresar horas de estadía: ");
            int horas = int.Parse(Console.ReadLine());

            Ticket nuevo = new Ticket(patente, horas);
            tickets.Add(nuevo);
            Console.WriteLine("Vehículo registrado correctamente");
        }

        public void ProcesarSalida()
        {
            if (tickets.Count > 0)
            {
                Console.WriteLine("=== SALIDA DEL VEHÍCULO ===");
                Console.WriteLine("Patente: " + tickets[0].Patente);
                Console.WriteLine("Horas de estadía: " + tickets[0].HorasEstadia);
                Console.WriteLine("Vehículo retirado correctamente");
                tickets.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("No hay vehículos esperando salida");
            }
        }

        public void MostrarVehiculosEstacionados()
        {
            Console.WriteLine("=== VEHÍCULOS ESTACIONADOS ===");

            if (tickets.Count == 0)
            {
                Console.WriteLine("No hay vehículos estacionados");
            }
            else
            {
                for (int i = 0; i < tickets.Count; i++)
                {
                    Console.WriteLine("Patente: " + tickets[i].Patente + " Horas: " + tickets[i].HorasEstadia);
                }
                Console.WriteLine("Cantidad total de vehículos: " + tickets.Count);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GestionEstacionamiento gestion = new GestionEstacionamiento();
            gestion.RegistrarIngreso();
            gestion.RegistrarIngreso();
            gestion.RegistrarIngreso();
            gestion.MostrarVehiculosEstacionados();
            gestion.ProcesarSalida();
            gestion.MostrarVehiculosEstacionados();

            Console.ReadKey();
        }
    }
}