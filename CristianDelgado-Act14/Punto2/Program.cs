using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        // Punto2:
        // Control de Vuelos
        // Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos(peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
        // Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero.Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
        // Agregar los siguientes métodos en la clase Vuelo:
        // 1. Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
        // 2. Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
        // 3. Un método que informe si algún pasajero excede el límite permitido de equipaje(mayor a 23 kg), imprimiendo su nombre y su DNI.


        class Pasajero
        {
            private string nombre;
            private string dni;
            private int equipajeKilos;

            public Pasajero()
            {
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese DNI: ");
                dni = Console.ReadLine();
                Console.Write("Ingrese kilos de equipaje: ");
                string linea = Console.ReadLine();
                equipajeKilos = int.Parse(linea);
            }

            public void Imprimir()
            {
                Console.WriteLine(nombre + " - " + dni + " - " + equipajeKilos + " kg");
            }

            public int RetornarEquipaje()
            {
                return equipajeKilos;
            }

            public string RetornarNombre()
            {
                return nombre;
            }

            public string RetornarDni()
            {
                return dni;
            }
        }

        class Vuelo
        {
            private Pasajero[] pasajeros;

            public Vuelo()
            {
                pasajeros = new Pasajero[4];
                for (int i = 0; i < 4; i++)
                {
                    pasajeros[i] = new Pasajero();
                }
            }

            public void MostrarPasajeros()
            {
                for (int i = 0; i < 4; i++)
                {
                    pasajeros[i].Imprimir();
                }
            }

            public void PesoTotal()
            {
                int total = 0;
                for (int i = 0; i < 4; i++)
                {
                    total += pasajeros[i].RetornarEquipaje();
                }
                Console.WriteLine("Peso total: " + total + " kg");
            }

            public void ExcesoEquipaje()
            {
                for (int i = 0; i < 4; i++)
                {
                    if (pasajeros[i].RetornarEquipaje() > 23)
                    {
                        Console.WriteLine("Exceso: " + pasajeros[i].RetornarNombre() +  " DNI: " + pasajeros[i].RetornarDni());
                    }
                }
            }

            static void Main(string[] args)
            {
                Vuelo vuelo = new Vuelo();
                vuelo.MostrarPasajeros();
                vuelo.PesoTotal();
                vuelo.ExcesoEquipaje();
                Console.ReadKey();
            }
        }
    }
}