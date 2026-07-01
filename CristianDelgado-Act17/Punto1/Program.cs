using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
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