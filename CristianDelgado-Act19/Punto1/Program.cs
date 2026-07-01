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
    // Plantear una clase parcial ReservaHotel.
    // En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
    // TipoHabitacion(puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
    // noches sea mayor a 0. Estos valores son cargados desde la consola.
    // En el segundo archivo, agregar un método que calcule el total a pagar según la
    // habitación elegida(por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por noche).
    // Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más.

    partial class ReservaHotel
    {
        private string nombreCliente;
        private int cantidadNoches;
        private string tipoHabitacion;

        public string NombreCliente
        {
            set
            {
                nombreCliente = value;
            }
            get
            {
                return nombreCliente;
            }
        }

        public int CantidadNoches
        {
            set
            {
                if (value > 0)
                {
                    cantidadNoches = value;
                }
                else
                {
                    cantidadNoches = 1;
                }
            }
            get
            {
                return cantidadNoches;
            }
        }

        public string TipoHabitacion
        {
            set
            {
                tipoHabitacion = value;
            }
            get
            {
                return tipoHabitacion;
            }
        }
    }

    partial class ReservaHotel
    {
        public double RetornarTotal()
        {
            double total = 0;
            if (TipoHabitacion == "Simple")
            {
                total = CantidadNoches * 5000;
            }
            else
            {
                if (TipoHabitacion == "Doble")
                {
                    total = CantidadNoches * 8000;
                }
                else
                {
                    total = CantidadNoches * 12000;
                }
                return total;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                ReservaHotel reserva1 = new ReservaHotel();
                ReservaHotel reserva2 = new ReservaHotel();
                ReservaHotel reserva3 = new ReservaHotel();

                Console.Write("Ingrese cliente: ");
                reserva1.NombreCliente = Console.ReadLine();
                Console.Write("Ingrese noches: ");
                string linea = Console.ReadLine();
                reserva1.CantidadNoches = int.Parse(linea);
                Console.Write("Ingrese habitación: ");
                reserva1.TipoHabitacion = Console.ReadLine();

                Console.Write("Ingrese cliente: ");
                reserva2.NombreCliente = Console.ReadLine();
                Console.Write("Ingrese noches: ");
                reserva2.CantidadNoches = int.Parse(linea);
                Console.Write("Ingrese habitación: ");
                reserva2.TipoHabitacion = Console.ReadLine();

                Console.Write("Ingrese cliente: ");
                reserva3.NombreCliente = Console.ReadLine();
                Console.Write("Ingrese noches: ");
                reserva3.CantidadNoches = int.Parse(linea);
                Console.Write("Ingrese habitación: ");
                reserva3.TipoHabitacion = Console.ReadLine();

                if (reserva1.RetornarTotal() > reserva2.RetornarTotal() && reserva1.RetornarTotal() > reserva3.RetornarTotal())
                {
                    Console.WriteLine("Pagará más: " + reserva1.NombreCliente);
                }

                else
                {
                    if (reserva2.RetornarTotal() > reserva3.RetornarTotal())
                    {
                        Console.WriteLine("Pagará más: " + reserva2.NombreCliente);
                    }
                    else
                    {
                        Console.WriteLine("Pagará más: " + reserva3.NombreCliente);
                    }

                    Console.ReadKey();
                }
            }
        }
    }
}