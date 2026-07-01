using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        public class Material
        {
            protected string tipoMaterial;

            public string TipoMaterial
            {
                set
                {
                    tipoMaterial = value;
                }
                get
                {
                    return tipoMaterial;
                }
            }

            public Material()
            {
                Console.WriteLine("Constructor de la clase Material");
            }
        }

        public class Herramienta : Material
        {
            protected string funcionPrincipal;

            public string FuncionPrincipal
            {
                set
                {
                    funcionPrincipal = value;
                }
                get
                {
                    return funcionPrincipal;
                }
            }

            public Herramienta()
            {
                Console.WriteLine("Constructor de la clase Herramienta");
            }
        }

        public class Martillo : Herramienta
        {
            private int pesoGramos;

            public int PesoGramos
            {
                set
                {
                    pesoGramos = value;
                }
                get
                {
                    return pesoGramos;
                }
            }

            public Martillo()
            {
                Console.WriteLine("Constructor de la clase Martillo");
            }

            public void Imprimir()
            {
                Console.WriteLine("Material: " + TipoMaterial);
                Console.WriteLine("Función: " + FuncionPrincipal);
                Console.WriteLine("Peso: " + PesoGramos);
            }
        }

        class Prueba
        {
            static void Main(string[] args)
            {
                Martillo obj1 = new Martillo();
                obj1.TipoMaterial = "Acero";
                obj1.FuncionPrincipal = "Golpear";
                obj1.PesoGramos = 800;

                obj1.Imprimir();

                Console.ReadKey();
            }
        }
    }
}
