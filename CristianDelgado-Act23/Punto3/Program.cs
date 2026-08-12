using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    // Punto3:
    // Un centro de conservación marina registra de forma dinámica las especies de
    // mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
    //  Crear la clase MonitoreoCostero que contenga como atributo privado
    // una lista de cadenas de texto List<string> especiesDetectadas.
    //  Métodos en MonitoreoCostero:
    // 1. CargarAvistamientos() : Solicitar por teclado nombres de
    // especies marinas avistadas(ej: &quot; Ballena Franca&quot;, &quot;Lobo Marino&quot;,
    // &quot;Delfín&quot;) y agregarlos a la lista utilizando.Add(). La carga finaliza
    // cuando el usuario ingresa la palabra & quot; FIN&quot;.
    // 2. MostrarReporteOrdenado() : Imprimir la lista de avistamientos
    // organizada alfabéticamente de la A a la Z utilizando el método .Sort().
    // 3. MostrarReporteInvertido() : Imprimir la lista organizada de la Z a la A combinando.Sort() con el método.Reverse().
    // 4. BuscarEspecie() : Pedir al operador que ingrese el nombre de un
    // animal y, utilizando los métodos de búsqueda de listas, informar si la especie fue divisada en la costa durante el día.

    class MonitoreoCostero
    {
        List<string> especiesDetectadas = new List<string>();

        public void cargarAvistamientos()
        {
            bool bucle = true;
            do
            {
                Console.Write("Ingrese la especie marina avistada o *FIN* para dejar de ingresar datos: ");
                string texto = Console.ReadLine();
                if (texto != "FIN")
                {
                    especiesDetectadas.Add(texto);
                }
                else
                {
                    bucle = false;
                }

            } while (bucle == true);
            Console.WriteLine();
        }

        public void mostrarReporteOrdenado()
        {
            especiesDetectadas.Sort();
            Console.WriteLine();
            Console.WriteLine("Reporte ordenado:");

            for (int i = 0; i < especiesDetectadas.Count; i++)
            {
                Console.WriteLine($"- {especiesDetectadas[i]}");
            }
        }

        public void mostrarReporteInvertido()
        {
            especiesDetectadas.Sort();
            especiesDetectadas.Reverse();
            Console.WriteLine();
            Console.WriteLine("Reporte invertido:");

            for (int i = 0; i < especiesDetectadas.Count; i++)
            {
                Console.WriteLine($"- {especiesDetectadas[i]}");
            }
        }

        public void buscarEspecie()
        {
            {
                string especie;

                Console.WriteLine();
                Console.Write("Ingrese el nombre de la especie a buscar: ");
                especie = Console.ReadLine();

                if (especiesDetectadas.Contains(especie))
                {
                    Console.WriteLine("La especie fue divisada en la costa.");
                }
                else
                {
                    Console.WriteLine("La especie no fue divisada en la costa.");
                }
            }
        }

        static void Main(string[] args)
        {
            MonitoreoCostero mc1 = new MonitoreoCostero();
            mc1.cargarAvistamientos();
            mc1.mostrarReporteOrdenado();
            mc1.mostrarReporteInvertido();
            mc1.buscarEspecie();

            Console.ReadKey();
        }
    }
}