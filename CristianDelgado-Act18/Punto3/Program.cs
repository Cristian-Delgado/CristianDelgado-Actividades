using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
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
