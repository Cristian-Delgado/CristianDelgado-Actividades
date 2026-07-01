using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        // Punto3:
        // Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
        // AutonomiaMinutos(int). Definir un constructor que reciba estos dos valores como parámetros y
        // realice su asignación.
        // Luego, definir dos clases derivadas de la clase base:
        // ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima soportada en atmósferas).
        // ● RoverTerrestre: que añade el atributo propio CantidadRuedas(int).
        // Cada una de estas clases derivadas debe poseer su propio constructor.El mismo debe recibir
        // tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
        // clase SondaExploradora mediante el uso explícito de la palabra clave base.
        // En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus parámetros unificados por consola.

        class SondaExploradora
        {
            protected string modelo;
            protected int autonomiaMinutos;

            public string Modelo
            {
                set
                {
                    modelo = value;
                }
                get
                {
                    return modelo;
                }
            }

            public int AutonomiaMinutos
            {
                set
                {
                    autonomiaMinutos = value;
                }
                get
                {
                    return autonomiaMinutos;
                }
            }
        }

        class SondaSubmarina : SondaExploradora
        {
            private int presionMaximaAtm;

            public int PresionMaximaAtm
            {
                set
                {
                    presionMaximaAtm = value;
                }
                get
                {
                    return presionMaximaAtm;
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Autonomia: " + AutonomiaMinutos);
                Console.WriteLine("Presion maxima: " + PresionMaximaAtm);
            }
        }

        class RoverTerrestre : SondaExploradora
        {
            private int cantidadRuedas;

            public int CantidadRuedas
            {
                set
                {
                    cantidadRuedas = value;
                }
                get
                {
                    return cantidadRuedas;
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Autonomia: " + AutonomiaMinutos);
                Console.WriteLine("Cantidad ruedas: " + CantidadRuedas);
            }
        }

        class Prueba
        {
            static void Main(string[] args)
            {
                SondaSubmarina s1 = new SondaSubmarina();
                s1.Modelo = "SubmarinaX";
                s1.AutonomiaMinutos = 100;
                s1.PresionMaximaAtm = 40;
                s1.Imprimir();

                RoverTerrestre r1 = new RoverTerrestre();
                r1.Modelo = "RoverY";
                r1.AutonomiaMinutos = 150;
                r1.CantidadRuedas = 6;
                r1.Imprimir();

                Console.ReadKey();
            }
        }
    }
}
