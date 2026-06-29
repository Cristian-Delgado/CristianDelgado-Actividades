using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        // Punto4:
        // Armar tres clases: Animal, Mamífero y Perro.
        // La clase Animal debe tener un atributo especie.
        // La clase Mamífero, que hereda de Animal, debe tener un atributo tipoAlimentacion
        // La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
        // Cada clase debe tener un constructor que reciba los datos correspondientes
        // y los imprima indicando a qué clase pertenecen.Los datos deben ser asignados previamente
        // Crear un objeto de la clase Perro y verificar la ejecución en cadena de los constructores.

        class Animal
        {
            protected string especie;

            public Animal(string e)
            {
                especie = e;
                Console.WriteLine("Constructor de Animal");
                Console.WriteLine("Especie: " + especie);
            }
        }

        class Mamifero : Animal
        {
            protected string tipoAlimentacion;

            public Mamifero(string e, string ta) : base(e)
            {
                tipoAlimentacion = ta;
                Console.WriteLine("Constructor de Mamifero");
                Console.WriteLine("Tipo de alimentación: " + tipoAlimentacion);
            }
        }

        class Perro : Mamifero
        {
            private string nombre;

            public Perro(string e, string ta, string n) : base(e, ta)
            {
                nombre = n;
                Console.WriteLine("Constructor de Perro");
                Console.WriteLine("Nombre: " + nombre);
            }
        }

        class Prueba
        {
            static void Main(string[] args)
            {
                Perro perro1 = new Perro("Canino", "Carnívoro", "Firulais");
                Console.ReadKey();
            }
        }
    }
}