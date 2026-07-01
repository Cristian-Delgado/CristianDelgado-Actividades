using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        // Punto3:
        // Fábrica de Computadoras (Herencia y Constructores con base)
        // Crear una clase base llamada Computadora que contenga los atributos Marca y
        // MemoriaRAM(en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
        // Luego, definir dos clases derivadas de la clase base:
        //  Notebook: que añade el atributo propio TamanoPantalla(en pulgadas).
        //  Escritorio: que añade el atributo propio PotenciaFuente(en Watts).
        // Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
        // tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
        // clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
        // de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.

        public class Computadora
        {
            protected string marca;
            protected int memoriaRAM;

            public string Marca
            {
                set
                {
                    marca = value;
                }
                get
                {
                    return marca;
                }
            }

            public int MemoriaRAM
            {
                set
                {
                    memoriaRAM = value;
                }
                get
                {
                    return memoriaRAM;
                }
            }
        }

        public class Notebook : Computadora
        {
            private int tamanoPantalla;

            public int TamanoPantalla
            {
                set
                {
                    tamanoPantalla = value;
                }
                get
                {
                    return tamanoPantalla;
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("RAM: " + MemoriaRAM);
                Console.WriteLine("Pantalla: " + TamanoPantalla);
            }
        }

        public class Escritorio : Computadora
        {
            private int potenciaFuente;

            public int PotenciaFuente
            {
                set
                {
                    potenciaFuente = value;
                }
                get
                {
                    return potenciaFuente;
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("RAM: " + MemoriaRAM);
                Console.WriteLine("Fuente: " + PotenciaFuente);
            }
        }

        class Prueba
        {
            static void Main(string[] args)
            {
                Notebook n1 = new Notebook();
                n1.Marca = "Aplee";
                n1.MemoriaRAM = 16;
                n1.TamanoPantalla = 15;
                n1.Imprimir();

                Escritorio e1 = new Escritorio();
                e1.Marca = "Gaming";
                e1.MemoriaRAM = 32;
                e1.PotenciaFuente = 650;
                e1.Imprimir();

                Console.ReadKey();
            }
        }
    }
}
