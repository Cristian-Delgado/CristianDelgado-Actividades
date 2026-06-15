using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Punto4
{
    internal class Program
    {
        // Punto4:
        // Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
        // habitantes de este.Ordenar alfabéticamente e imprimir los resultados.Por último
        // ordenar con respecto a la cantidad de habitantes(de mayor a menor) e imprimir
        // nuevamente.

        class PruebaVector4
        {
            private string[] paises;
            private int[] habitantes;

            public void Cargar()
            {
                paises = new string[5];
                habitantes = new int[5];
                for (int f = 0; f < paises.Length; f++)
                {
                    Console.Write("Ingrese país: ");
                    paises[f] = Console.ReadLine();
                    Console.Write("Ingrese habitantes: ");
                    string linea;
                    linea = Console.ReadLine();
                    habitantes[f] = int.Parse(linea);
                }
            }

            public void OrdenarAlfabetico()
            {
                for (int k = 0; k < paises.Length; k++)
                {
                    for (int f = 0; f < paises.Length - 1 - k; f++)
                    {
                        if (paises[f].CompareTo(paises[f + 1]) > 0)
                        {
                            string auxPais;
                            auxPais = paises[f];
                            paises[f] = paises[f + 1];
                            paises[f + 1] = auxPais;

                            int auxHab;
                            auxHab = habitantes[f];
                            habitantes[f] = habitantes[f + 1];
                            habitantes[f + 1] = auxHab;
                        }
                    }
                }
            }

            public void OrdenarHabitantes()
            {
                for (int k = 0; k < habitantes.Length; k++)
                {
                    for (int f = 0; f < habitantes.Length - 1 - k; f++)
                    {
                        if (habitantes[f] < habitantes[f + 1])
                        {
                            int auxHab;
                            auxHab = habitantes[f];
                            habitantes[f] = habitantes[f + 1];
                            habitantes[f + 1] = auxHab;
                            string auxPais;
                            auxPais = paises[f];
                            paises[f] = paises[f + 1];
                            paises[f + 1] = auxPais;
                        }
                    }
                }
            }

            public void Imprimir()
            {
                for (int f = 0; f < paises.Length; f++)
                {
                    Console.WriteLine(paises[f] + " - " + habitantes[f]);
                }
            }

            static void Main(string[] args)
            {
                PruebaVector4 pv = new PruebaVector4();
                pv.Cargar();
                Console.WriteLine("Ordenados alfabéticamente");
                pv.OrdenarAlfabetico();
                pv.Imprimir();
                Console.WriteLine("Ordenados por habitantes");
                pv.OrdenarHabitantes();
                pv.Imprimir();

                Console.ReadKey();
            }
        }
    }
}