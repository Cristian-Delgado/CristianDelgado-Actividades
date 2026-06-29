using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        // Punto3:
        // Crear una clase base Vehículo que contenga atributos marca y velocidadMaxima.
        // Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo.Cada
        // una debe tener un constructor que reciba los valores de los atributos base
        // mediante la palabra clave base, y un atributo propio (cantidadPuertas en Auto, cilindrada en Moto).
        // Crear un objeto de cada clase y mostrar todos sus datos por consola.

        class Vehiculo
        {
            protected string marca;
            protected int velocidadMaxima;

            public Vehiculo(string ma, int vm)
            {
                marca = ma;
                velocidadMaxima = vm;
            }
        }

        class Auto : Vehiculo
        {
            private int cantidadPuertas;

            public Auto(string ma, int vm, int cp)
            {
               cantidadPuertas = cp;
            }

            public void Mostrar()
            {
                Console.WriteLine("Auto");
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Velocidad máxima: " + velocidadMaxima);
                Console.WriteLine("Puertas: " + cantidadPuertas);
            }
        }

        class Moto : Vehiculo
        {
            private int cilindrada;

            public Moto(string ma, int vm, int ci)
            {
                cilindrada = ci;
            }

            public void Mostrar()
            {
                Console.WriteLine("Moto");
                Console.WriteLine("Marca: " + marca);
                Console.WriteLine("Velocidad máxima: " + velocidadMaxima);
                Console.WriteLine("Cilindrada: " + cilindrada);
            }
        }

        static void Main(string[] args)
        {
            Auto a = new Auto("Ford", 220, 4);
            Moto m = new Moto("Yamaha", 180, 250);

            a.Mostrar();
            m.Mostrar();

            Console.ReadKey();
        }
    }
}