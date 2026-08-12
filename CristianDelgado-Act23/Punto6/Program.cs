using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    // Punto6:
    // Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
    // para organizar la consulta de ejemplares por parte de los lectores.
    //  Crear la clase Libro que contenga como atributos privados: titulo
    // (string) y anioPublicacion(int). Definir sus propiedades de solo lectura y un constructor que reciba tit y anio.
    //  Crear la clase BibliotecaCentral que administre una lista de objetos List.
    //  Métodos en BibliotecaCentral:
    // 1. CargarCatalogo(): Solicitar por teclado títulos y años de
    // publicación para agregar libros a la lista mediante.Add(). La carga
    // finaliza cuando el usuario ingresa la palabra &quot; FIN&quot; como título.
    // 2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
    // junto a la cantidad total de obras registradas mediante la propiedad .Count.
    // 3. FiltrarPorAnio(): Solicitar al usuario un año determinado e imprimir en consola únicamente aquellos libros cuyo año de
    // publicación sea menor a dicho valor.
    // 4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
    // los métodos de búsqueda y remoción de listas, eliminarlo de la colección si se encuentra presente.

    class Libro
    {
        private string titulo;
        private int anioPublicacion;

        public string Titulo
        {
            get { return titulo; }
        }

        public int AnioPublicacion
        {
            get { return anioPublicacion; }
        }

        public Libro(string tit, int anio)
        {
            this.titulo = tit;
            this.anioPublicacion = anio;
        }
    }
    class BibliotecaCentral
    {
        List<Libro> libros = new List<Libro>();

        public void CargarCatalogo()
        {
            string titulo;
            do
            {
                Console.Write("Ingrese el titulo del libro (FIN para terminar): ");
                titulo = Console.ReadLine();
                if (titulo.ToUpper() != "FIN")
                {
                    Console.Write("Ingrese el año de publicacion: ");
                    int anio = int.Parse(Console.ReadLine());
                    Libro nuevoLibro = new Libro(titulo, anio);
                    libros.Add(nuevoLibro);
                    Console.WriteLine();
                }

            } while (titulo.ToUpper() != "FIN");

            Console.WriteLine();
        }

        public void ListarCatalogo()
        {
            Console.WriteLine("CATALOGO DE LIBROS");
            foreach (Libro libro in libros)
            {
                Console.WriteLine($"- {libro.Titulo} - Año: {libro.AnioPublicacion}");
            }

            Console.WriteLine($"Cantidad total de obras registradas: {libros.Count}");
            Console.WriteLine();
        }

        public void FiltrarPorAnio()
        {
            Console.Write("Ingrese un año para realizar el filtro: ");
            int anio = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"*** LIBROS PUBLICADOS ANTES DEL AÑO {anio} ***");

            foreach (Libro libro in libros)
            {
                if (libro.AnioPublicacion < anio)
                {
                    Console.WriteLine($"- {libro.Titulo} - Año: {libro.AnioPublicacion}");
                }
            }

            Console.WriteLine();
        }

        public void RemoverLibro()
        {
            Console.Write("Ingrese el titulo del libro a remover: ");
            string titulo = Console.ReadLine();

            bool existe = false;

            for (int i = 0; i < libros.Count; i++)
            {
                if (libros[i].Titulo == titulo)
                {
                    libros.RemoveAt(i);
                    existe = true;
                    Console.WriteLine("El libro fue eliminado correctamente.");
                    break;
                }
            }

            if (existe == false)
            {
                Console.WriteLine("El libro no se encuentra en el catalogo.");
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            BibliotecaCentral bc = new BibliotecaCentral();
            bc.CargarCatalogo();
            bc.ListarCatalogo();
            bc.FiltrarPorAnio();
            bc.RemoverLibro();
            bc.ListarCatalogo();

            Console.ReadKey();
        }
    }
}
