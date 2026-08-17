using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto9
{
    // Punto9:
    // Un instituto de enseñanza registra de forma dinámica a sus estudiantes para
    // realizar el seguimiento académico de sus materias.
    //  Crear la clase Estudiante que contenga como atributos privados:
    // nombreCompleto(string) y calificacion(double). Definir sus propiedades
    // de solo lectura y un constructor que reciba nom y cal.
    //  Crear la clase GestionAcademica que administre una lista de objetos List.
    //  Métodos en GestionAcademica:
    // o CargarEstudiantes(): Solicitar por teclado nombres y
    // calificaciones para agregar estudiantes a la lista mediante.Add(). La
    // carga finaliza cuando el usuario ingresa la palabra "FIN" como nombre.
    // o ListarEstudiantes(): Mostrar en pantalla todos los alumnos
    // junto a la cantidad total de inscriptos mediante la propiedad .Count.
    // o FiltrarAprobados(): Recorrer la lista e imprimir en consola
    // únicamente aquellos estudiantes cuya calificación sea mayor o igual a 6.0.
    // o DarDeBaja(): Pedir al operador el nombre de un estudiante y,
    // utilizando los métodos de búsqueda y remoción de listas, eliminarlo
    // de la colección si se encuentra presente.

    class Estudiante
    {
        private string nombreCompleto;
        private double calificacion;

        public string NombreCompleto
        {
            get { return nombreCompleto; }
        }

        public double Calificacion
        {
            get { return calificacion; }
        }

        public Estudiante(string nom, double cal)
        {
            this.nombreCompleto = nom;
            this.calificacion = cal;
        }
    }

    class GestionAcademica
    {
        private List<Estudiante> estudiantes;

        public GestionAcademica()
        {
            estudiantes = new List<Estudiante>();
        }

        public void CargarEstudiantes()
        {
            string nombre = "";
            while (nombre != "FIN")
            {
                Console.Write("Ingrese el nombre del estudiante (FIN para terminar): ");
                nombre = Console.ReadLine();
                if (nombre != "FIN")
                {
                    Console.Write("Ingrese la calificación: ");
                    double calificacion = double.Parse(Console.ReadLine());
                    Estudiante nuevo = new Estudiante(nombre, calificacion);
                    estudiantes.Add(nuevo);
                }
            }
        }

        public void ListarEstudiantes()
        {
            Console.WriteLine("=== LISTA DE ESTUDIANTES ===");
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine("Nombre: " + estudiantes[i].NombreCompleto + " Calificación: " + estudiantes[i].Calificacion);
            }

            Console.WriteLine("Cantidad total de inscriptos: " + estudiantes.Count);
        }

        public void FiltrarAprobados()
        {
            Console.WriteLine("=== ESTUDIANTES APROBADOS ===");
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].Calificacion >= 6.0)
                {
                    Console.WriteLine("Nombre: " + estudiantes[i].NombreCompleto + " Calificación: " + estudiantes[i].Calificacion);
                }
            }
        }

        public void DarDeBaja()
        {
            Console.Write("Ingresar nombre del estudiante a dar de baja: ");
            string nombre = Console.ReadLine();
            Estudiante estudianteEncontrado = null;
            for (int i = 0; i < estudiantes.Count; i++)
            {
                if (estudiantes[i].NombreCompleto == nombre)
                {
                    estudianteEncontrado = estudiantes[i];
                    break;
                }
            }

            if (estudianteEncontrado != null)
            {
                estudiantes.Remove(estudianteEncontrado);
                Console.WriteLine("Estudiante dado de baja correctamente.");
            }
            else
            {
                Console.WriteLine("El estudiante no se encuentra en la lista.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GestionAcademica gestion = new GestionAcademica();
            gestion.CargarEstudiantes();
            gestion.ListarEstudiantes();
            gestion.FiltrarAprobados();
            gestion.DarDeBaja();
            gestion.ListarEstudiantes();

            Console.ReadKey();
        }
    }
}