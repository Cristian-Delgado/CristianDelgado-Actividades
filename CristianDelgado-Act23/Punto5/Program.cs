using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    // Punto5:
    // Un taller mecánico automatizado administra la recepción y egreso de automóviles
    // que se encuentran en el sector de reparaciones.
    //  Crear la clase Vehiculo que contenga como atributos privados: patente
    // (string) y costoReparacion (double). Definir sus propiedades correspondientes y un constructor que reciba pat y costo.
    //  Crear la clase GestionTaller que administre una lista de objetos List.
    //  Métodos en GestionTaller:
    // o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
    // reparación de un vehículo para agregarlo a la lista mediante.Add().
    // o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
    // recorriendo la lista, informar si el vehículo está en el taller y mostrar su costo asociado.
    // o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
    // vehículo en la lista y, si existe, removerlo de la colección mediante .Remove() confirmando la entrega del automóvil.
    // o CalcularRecaudacionPendiente(): Listar los vehículos actualmente en reparación, la cantidad total de unidades alojadas en
    // el taller mediante la propiedad.Count y la suma total acumulada por cobrar.

    class Vehiculo
    {
        private string patente;
        private double costoReparacion;

        public string Patente
        {
            get { return patente; }
        }

        public double CostoReparacion
        {
            get { return costoReparacion; }
        }

        public Vehiculo(string pat, double costo)
        {
            this.patente = pat;
            this.costoReparacion = costo;
        }
    }

    class GestionTaller
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void IngresarVehiculo()
        {
            Console.Write("Ingrese la patente del vehiculo: ");
            string patente = Console.ReadLine();
            Console.Write($"Ingrese el costo de reparacion del vehiculo con patente {patente}: ");
            double costo = double.Parse(Console.ReadLine());
            Vehiculo nuevoVehiculo = new Vehiculo(patente, costo);
            vehiculos.Add(nuevoVehiculo);
            Console.WriteLine("Vehiculo agregado correctamente.");
            Console.WriteLine();
        }

        public void BuscarVehiculo()
        {
            Console.Write("Ingrese una patente para buscar: ");
            string patente = Console.ReadLine();
            bool existe = false;

            foreach (Vehiculo vehiculo in vehiculos)
            {
                if (vehiculo.Patente == patente)
                {
                    existe = true;
                    Console.WriteLine($"El vehiculo esta en el taller y debe abonar ${vehiculo.CostoReparacion}");
                    break;
                }
            }

            if (existe == false)
            {
                Console.WriteLine("El vehiculo no esta en el taller.");
            }
            Console.WriteLine();
        }

        public void EntregarVehiculo()
        {
            Console.Write("Ingrese la patente del vehiculo para hacer su entrega: ");
            string patente = Console.ReadLine();
            bool existe = false;

            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].Patente == patente)
                {
                    vehiculos.RemoveAt(i);
                    existe = true;
                    Console.WriteLine("El vehiculo fue entregado con exito.");
                    break;
                }
            }

            if (existe == false)
            {
                Console.WriteLine("El vehiculo ingresado no se encuentra en el taller.");
            }

            Console.WriteLine();
        }

        public void CalcularRecaudacionPendiente()
        {
            Console.WriteLine(" LISTADO DE VEHICULOS Y TOTAL PENDIENTE ");
            double total = 0;
            foreach (Vehiculo vehiculo in vehiculos)
            {
                Console.WriteLine($"- {vehiculo.Patente} debe abonar ${vehiculo.CostoReparacion}");
                total += vehiculo.CostoReparacion;
            }
            Console.WriteLine();
            Console.WriteLine($"Cantidad de vehiculos en el taller: {vehiculos.Count}");
            Console.WriteLine($"Total pendiente por cobrar: ${total}");

            Console.WriteLine();
        }

        static void Main(string[] args)
         {
            GestionTaller gt = new GestionTaller();
            gt.IngresarVehiculo();
            gt.IngresarVehiculo();
            gt.IngresarVehiculo();
            gt.BuscarVehiculo();
            gt.EntregarVehiculo();
            gt.CalcularRecaudacionPendiente();

            Console.ReadKey();
        }
    }
}
