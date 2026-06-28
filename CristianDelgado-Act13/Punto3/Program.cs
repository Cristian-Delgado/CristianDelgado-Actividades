using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        // Punto3:
        // Plantear una clase Club y otra clase Socio.
        // La clase Socio debe tener los siguientes atributos privados: nombre y la
        // antigüedad en el club(en años). En el constructor pedir la carga del nombre y
        // su antigüedad.La clase Club debe tener como atributos 3 objetos de la clase
        // Socio.Definir una responsabilidad para imprimir el nombre del socio con mayor
        // antigüedad en el club.

        class Socio
        {
            private string nombre;
            private int antiguedad;

            public Socio()
            {
                Console.Write("Ingrese nombre del socio: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese antigüedad en años: ");
                string linea = Console.ReadLine();
                antiguedad = int.Parse(linea);
            }

            public string RetornarNombre()
            {
                return nombre;
            }

            public int RetornarAntiguedad()
            {
                return antiguedad;
            }
        }

        class Club
        {
            private Socio socio1, socio2, socio3;

            public Club()
            {
                Console.WriteLine("Carga del socio 1");
                socio1 = new Socio();
                Console.WriteLine("Carga del socio 2");
                socio2 = new Socio();
                Console.WriteLine("Carga del socio 3");
                socio3 = new Socio();
            }

            public void MayorAntiguedad()
            {
                Socio mayor = socio1;
                if (socio2.RetornarAntiguedad() > mayor.RetornarAntiguedad())
                {
                    mayor = socio2;
                }

                if (socio3.RetornarAntiguedad() > mayor.RetornarAntiguedad())
                {
                    mayor = socio3;
                }
                Console.WriteLine("El socio con mayor antigüedad es: " + mayor.RetornarNombre());
            }

            static void Main(string[] args)
            {
                Club club = new Club();
                club.MayorAntiguedad();
                Console.ReadKey();
            }
        }
    }
}