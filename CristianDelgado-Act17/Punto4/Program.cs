using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        // Punto4:
        // Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
        // Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de herencia: Material, Herramienta y Martillo.
        //  La clase Material(base) debe tener un atributo TipoMaterial(ej: Madera, Acero, Plástico).
        //  La clase Herramienta(que hereda de Material) debe añadir el atributo FuncionPrincipal.
        //  La clase Martillo(que hereda de Herramienta) debe añadir el atributo PesoGramos.
        // Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
        // correspondientes.Al momento de ejecutarse, cada constructor debe realizar la asignación y,
        // acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
        // (ejemplo: &quot; Constructor de la clase Material ejecutado&quot;).
        // En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
        // parámetros requeridos.Observar y verificar en la consola el orden secuencial de ejecución
        // en cadena de los constructores(desde la raíz hasta la clase derivada).

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
