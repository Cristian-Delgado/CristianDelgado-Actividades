using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        // Punto1:
        // El Sistema de Peaje.
        // Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
        // La clase Vehiculo debe tener los siguientes atributos privados:
        // Patente (de tipo string).
        // Tipo(puede ser "Auto", "Camion" o "Moto").
        // Tarifa(un valor decimal que representa el costo de su pase).
        // El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
        // La clase CabinaPeaje debe tener como atributos privados:
        // El número o identificador de la cabina.
        // Tres objetos de la clase Vehiculo(que representan los últimos 3 vehículos que pagaron en esa cabina).
        // Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos.Además, implementar los siguientes métodos dentro de CabinaPeaje:
        // 1. Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
        // 2. Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
        // 3. Un método que muestre la patente del vehículo que pagó la tarifa más cara.


        class Vehiculo
        {
            private string patente;
            private string tipo;
            private decimal tarifa;

            public Vehiculo()
            {
                Console.Write("Ingrese patente: ");
                patente = Console.ReadLine();
                Console.Write("Ingrese tipo (Auto/Camion/Moto): ");
                tipo = Console.ReadLine();
                Console.Write("Ingrese tarifa: ");
                string linea = Console.ReadLine();
                tarifa = decimal.Parse(linea);
            }

            public string RetornarPatente()
            {
                return patente;
            }

            public string RetornarTipo()
            {
                return tipo;
            }

            public decimal RetornarTarifa()
            {
                return tarifa;
            }
        }

        class CabinaPeaje
        {
            private int numeroCabina;
            private Vehiculo vehiculo1, vehiculo2, vehiculo3;

            public CabinaPeaje()
            {
                Console.Write("Ingrese numero de cabina: ");
                numeroCabina = int.Parse(Console.ReadLine());
                vehiculo1 = new Vehiculo();
                vehiculo2 = new Vehiculo();
                vehiculo3 = new Vehiculo();
            }

            public void MostrarVehiculos()
            {
                Console.WriteLine("Vehiculos registrados:");
                Console.WriteLine(vehiculo1.RetornarPatente() + " - " + vehiculo1.RetornarTipo());
                Console.WriteLine(vehiculo2.RetornarPatente() + " - " + vehiculo2.RetornarTipo());
                Console.WriteLine(vehiculo3.RetornarPatente() + " - " + vehiculo3.RetornarTipo());
            }

            public void RecaudacionTotal()
            {
                decimal total = vehiculo1.RetornarTarifa() +
                                vehiculo2.RetornarTarifa() +
                                vehiculo3.RetornarTarifa();
                Console.WriteLine("Total recaudado: " + total);
            }

            public void TarifaMasCara()
            {
                Vehiculo mayor = vehiculo1;
                if (vehiculo2.RetornarTarifa() > mayor.RetornarTarifa())
                {
                    mayor = vehiculo2;
                }
                else
                {
                    if (vehiculo3.RetornarTarifa() > mayor.RetornarTarifa())
                    {
                        mayor = vehiculo3;
                    }
                }          
                Console.WriteLine("Patente con tarifa mas cara: " + mayor.RetornarPatente());
            }

            static void Main(string[] args)
            {
                CabinaPeaje cabina = new CabinaPeaje();
                cabina.MostrarVehiculos();
                cabina.RecaudacionTotal();
                cabina.TarifaMasCara();
                Console.ReadKey();
            }
        }
    }
}