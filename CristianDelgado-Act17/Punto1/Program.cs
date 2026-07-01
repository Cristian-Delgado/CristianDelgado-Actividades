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
        // Personal de un Gimnasio (Herencia Simple y Propiedades)
        // Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
        // Nombre y el DNI(definir sus respectivas propiedades de lectura y escritura). Plantear un
        // método para imprimir estos datos básicos.
        // Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
        // un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
        // para imprimir todos los datos del profesor(incluyendo los heredados).
        // En el programa principal(Main):
        //  Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y llamar a su método de impresión.
        //  Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
        // que puede acceder tanto a sus métodos propios como a los de la clase base.

        class PersonaGimnasio
        {
            private string nombre;
            private string dni;

            public string Nombre
            {
                set
                {
                    nombre = dni;
                }
                get
                {
                    return nombre;
                }
            }

            public string DNI
            {
                set
                {
                    dni = value;
                }
                get
                {
                    return dni;
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Nombre: " + Nombre);
                Console.WriteLine("DNI: " + DNI);
            }
        }

        class Profesor : PersonaGimnasio
        {
            private string especialidad;

            public string Especialidad
            {
                set
                {
                    especialidad = value;
                }
                get
                {
                    return especialidad;
                }
            }

            public void ImprimirProfesor()
            {
                Console.WriteLine("Especialidad: " + Especialidad);
            }
        }

        class prueba
        {
            static void Main(string[] args)
            {
                PersonaGimnasio persona = new PersonaGimnasio();
                persona.Nombre = "Carlos";
                persona.DNI = "12345678";
                persona.Imprimir();

                Console.WriteLine();

                Profesor profesor = new Profesor();
                profesor.Nombre = "Laura";
                profesor.DNI = "87654321";
                profesor.Especialidad = "Yoga";
                profesor.ImprimirProfesor();

                Console.ReadKey();
            }
        }
    }
}