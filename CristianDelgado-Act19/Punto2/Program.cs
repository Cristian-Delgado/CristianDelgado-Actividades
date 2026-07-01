using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    // Punto2:
    // Crear una clase parcial Libro.
    // En el primer archivo, declarar las propiedades Título, Autor y Páginas.Validar que la
    // cantidad de páginas sea mayor a 10.Valores cargados desde consola
    // En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
    // si el libro es corto(menos de 100 páginas) o largo.
    // Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.

    partial class Libro
    {
        private string titulo;
        private string autor;
        private int paginas;

        public string Titulo
        {
            set
            {
                titulo = value;
            }
            get
            {
                return titulo;
            }
        }

        public string Autor
        {
            set
            {
                autor = value;
            }
            get
            {
                return autor;
            }
        }

        public int Paginas
        {
            set
            {
                if (value > 10)
                {
                    paginas = value;
                }
                else
                {
                    paginas = 11;
                }
            }
            get
            {
                return paginas;
            }
        }
    }

    partial class Libro
    {
        public void Resumen()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor: " + Autor);

            if (Paginas < 100)
            {
                Console.WriteLine("Libro corto");
            }
            else
            {
                Console.WriteLine("Libro largo");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();
            Libro libro2 = new Libro();

            Console.Write("Ingrese título: ");
            libro1.Titulo = Console.ReadLine();
            Console.Write("Ingrese autor: ");
            libro1.Autor = Console.ReadLine();
            Console.Write("Ingrese páginas: ");
            libro1.Paginas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese título: ");
            libro2.Titulo = Console.ReadLine();
            Console.Write("Ingrese autor: ");
            libro2.Autor = Console.ReadLine();
            Console.Write("Ingrese páginas: ");
            libro2.Paginas = int.Parse(Console.ReadLine());

            libro1.Resumen();
            libro2.Resumen();

            if (libro1.Paginas > libro2.Paginas)
            {
                Console.WriteLine("El más extenso es: " + libro1.Titulo);
            }
            else
            {
                Console.WriteLine("El más extenso es: " + libro2.Titulo);
            }

            Console.ReadKey();
        }
    }
}