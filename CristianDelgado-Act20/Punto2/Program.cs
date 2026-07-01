using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    // Punto2:
    // Actividad 2: Administración de entregas logísticas
    // Problema:
    // Una empresa de envíos desea registrar sus entregas mediante colaboración de clases.
    // Crear una clase Paquete con propiedades: código, peso y destino.Crear una clase
    // Despachador que contenga una lista de paquetes y un método para registrar nuevos paquetes.
    // Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
    //  Todos los paquetes registrados.
    //  Cuántos superan los 10 kg de peso.
    //  Cuántos tienen destino nacional (por ejemplo, “Argentina”).

    class Paquete
    {
        private string codigo;
        private double peso;
        private string destino;

        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public double Peso
        {
            set
            {
                peso = value;
            }
            get
            {
                return peso;
            }
        }

        public string Destino
        {
            set
            {
                destino = value;
            }
            get
            {
                return destino;
            }
        }
    }

    class Despachador
    {
        public List<Paquete> listaPaquetes = new List<Paquete>();

        public void Registrar(Paquete p)
        {
            listaPaquetes.Add(p);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Despachador d = new Despachador();

            for (int i = 0; i < 5; i++)
            {
                Paquete p = new Paquete();

                Console.Write("Ingrese código: ");
                p.Codigo = Console.ReadLine();

                Console.Write("Ingrese peso: ");
                p.Peso = double.Parse(Console.ReadLine());

                Console.Write("Ingrese destino: ");
                p.Destino = Console.ReadLine();

                d.Registrar(p);
            }

            int pesados = 0;
            int nacionales = 0;
            Console.WriteLine("Paquetes cargados:");
            foreach (Paquete p in d.listaPaquetes)
            {
                Console.WriteLine(p.Codigo + " - " + p.Peso + "kg " + p.Destino);

                if (p.Peso > 10)
                {
                    pesados++;
                }

                if (p.Destino == "Argentina")
                {
                    nacionales++;
                }
            }

            Console.WriteLine("Paquetes mayores a 10kg: " + pesados);
            Console.WriteLine("Paquetes nacionales: " + nacionales);
            Console.ReadKey();
        }
    }
}