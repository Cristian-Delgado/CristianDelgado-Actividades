using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    // Punto1:
    //En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de llegada.
    // Crear la clase Documento que contenga como atributos privados:
    //nombreArchivo(string) y cantidadPaginas(int). Definir sus
    //propiedades de solo lectura y un constructor que reciba los parámetros nom y pag.
    // Crear la clase ServidorImpresion que administre una lista dinámica de documentos (List<Documento>).
    // Métodos en ServidorImpresion:
    //1. AgregarDocumento() : Solicitar por teclado los datos de un documento y agregarlo al final de la lista utilizando.Add().
    //2. ImprimirSiguiente() : Si la lista no está vacía, simular la impresión del primer documento de la lista(mostrar sus datos en
    //consola) y removerlo de la colección mediante.RemoveAt(0). Si está vacía, advertir que no hay trabajos pendientes.
    //3. MostrarColaPendiente(): Listar todos los documentos que están esperando ser impresos y la cantidad total de páginas
    //acumuladas en la cola de espera utilizando .Count.

    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public string NombreArchivo
        {
            get { return nombreArchivo; }
        }
        public int CantidadPaginas
        {
            get { return cantidadPaginas; }
        }

        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }

    class ServidorImpresion
    {
        List<Documento> documentos = new List<Documento>();

        public void AgregarDocumento()
        {
            string nombre;
            int paginas;

            Console.Write("Ingresar nombre de archivo del documento: ");
            nombre = Console.ReadLine();
            Console.Write("Ingresar mcantidad de paginas del documento: ");
            paginas = int.Parse(Console.ReadLine());
            Documento nuevoDocumento = new Documento(nombre, paginas);
            documentos.Add(nuevoDocumento);
            Console.WriteLine("Documento agregado correctamente.");
        }

        public void ImprimirSiguiente()
        {
            if (documentos.Count == 0)
            {
                Console.WriteLine("No hay trabajos pendientes.");
            }
            else
            {
                Documento documento = documentos[0];

                Console.WriteLine();
                Console.WriteLine("Imprimiendo documento...");
                Console.WriteLine($"Nombre archivo: {documento.NombreArchivo}");
                Console.WriteLine($"Cantidad de paginas: {documento.CantidadPaginas}");

                documentos.RemoveAt(0);

                Console.WriteLine("Documento impreso correctamente.");
            }
        }

        public void MostrarColaPendiente()
        {
            if (documentos.Count == 0)
            {
                Console.WriteLine("No hay documentos pendientes.");
            }
            else
            {
                int paginasTotales = 0;

                Console.WriteLine();
                Console.WriteLine("Documentos pendientes:");

                for (int i = 0; i < documentos.Count; i++)
                {
                    Console.WriteLine($"- {documentos[i].NombreArchivo} - " + $"{documentos[i].CantidadPaginas} paginas");
                    paginasTotales += documentos[i].CantidadPaginas;
                }

                Console.WriteLine();
                Console.WriteLine($"Cantidad de documentos pendientes: {documentos.Count}");
                Console.WriteLine($"La cantidad total de paginas acumuladas en la cola son: {paginasTotales}");
            }
        }

        static void Main(string[] args)
        {
            ServidorImpresion si1 = new ServidorImpresion();

            si1.ImprimirSiguiente();
            si1.AgregarDocumento();
            si1.ImprimirSiguiente();
            si1.ImprimirSiguiente();
            si1.AgregarDocumento();
            si1.AgregarDocumento();
            si1.AgregarDocumento();
            si1.MostrarColaPendiente();

            Console.ReadKey();
        }
    }
}