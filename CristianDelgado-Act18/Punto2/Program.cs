using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        class CriaturaMarina
        {
            private string especie;
            private int profundidadOptima;
            private int nivelSalinidad;

            public string Especie
            {
                set
                {
                    especie = value;
                }
                get
                {
                    return especie;
                }
            }

            public int ProfundidadOptima
            {
                set
                {
                    if (value > 0)
                    {
                        profundidadOptima = value;
                    }
                }
                get
                {
                    return profundidadOptima;
                }
            }

            public int NivelSalinidad
            {
                set
                {
                    if (value >= 1 && value <= 100)
                    {
                        nivelSalinidad = value;
                    }
                    else
                    {
                        nivelSalinidad = 35;
                    }
                }
                get
                {
                    return nivelSalinidad;
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Especie: " + Especie);
                Console.WriteLine("Profundidad: " + ProfundidadOptima);
                Console.WriteLine("Salinidad: " + NivelSalinidad);
            }
        }

        class HabitatAcuatico
        {
            private CriaturaMarina[] criaturas;

            public HabitatAcuatico()
            {
                criaturas = new CriaturaMarina[3];
            }

            public void Cargar()
            {
                for (int f = 0; f < 3; f++)
                {
                    criaturas[f] = new CriaturaMarina();

                    Console.Write("Ingrese especie: ");
                    criaturas[f].Especie = Console.ReadLine();
                    Console.Write("Ingrese profundidad: ");
                    criaturas[f].ProfundidadOptima = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese salinidad: ");
                    criaturas[f].NivelSalinidad = int.Parse(Console.ReadLine());
                }
            }

            public void Mostrar()
            {
                for (int f = 0; f < 3; f++)
                {
                    criaturas[f].Imprimir();
                }
            }

            public void MayorSalinidad()
            {
                int mayor = criaturas[0].NivelSalinidad;
                string especie = criaturas[0].Especie;

                for (int f = 1; f < 3; f++)
                {
                    if (criaturas[f].NivelSalinidad > mayor)
                    {
                        mayor = criaturas[f].NivelSalinidad;
                        especie = criaturas[f].Especie;
                    }
                }

                Console.WriteLine("Mayor salinidad: " + especie);
            }
        }

        class Prueba
        {
            static void Main(string[] args)
            {
                HabitatAcuatico h1 = new HabitatAcuatico();
                h1.Cargar();
                h1.Mostrar();
                h1.MayorSalinidad();

                Console.ReadKey();
            }
        }
    }
}
