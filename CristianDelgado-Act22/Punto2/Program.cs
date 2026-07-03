using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    // Actividad 2: Posicionamiento de elementos en consola
    // Problema:
    // Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
    //  Implementar propiedades y un constructor que cargue valores.
    //  Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el nombre en pantalla y Console.CursorVisible para ocultar el cursor.
    //  Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la consola.

    class ElementoPantalla
    {
        public string nombre { set; get; }
        public int posX { set; get; }
        public int posY { set; get; }

        public ElementoPantalla(string nombre, int x, int y)
        {
            this.nombre = nombre;
            this.posX = x;
            this.posY = y;
        }

        public void Mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(posX, posY);
            Console.Write(nombre);
        }
    }

    class Program
    {
        static void Main()
        {
            ElementoPantalla[] elementos = new ElementoPantalla[4];

            elementos[0] = new ElementoPantalla("A", 5, 2);
            elementos[1] = new ElementoPantalla("B", 10, 4);
            elementos[2] = new ElementoPantalla("C", 15, 6);
            elementos[3] = new ElementoPantalla("D", 20, 8);
            foreach (ElementoPantalla e in elementos)
            {
                e.Mostrar();
            }
            Console.ReadKey();
        }
    }
}