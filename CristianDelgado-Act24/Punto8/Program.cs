using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto8
{
    // Punto8:
    // Una farmacia controla el nivel de stock de sus medicamentos para evitar el desabastecimiento de insumos esenciales.
    //  Crear la clase Medicamento que contenga los atributos privados: nombre
    // (string) y stock (int). Definir sus propiedades correspondientes. Su constructor debe recibir nom y stk.
    //  Crear la clase ControlFarmacia que administre una lista de objetos List.
    //  Métodos en ControlFarmacia:
    // o Un constructor que cargue por teclado una lista inicial de 4 medicamentos ingresando sus nombres y stock.
    // o ListarStock(): Mostrar la lista de medicamentos en pantalla.

    class Medicamento
    {
        private string nombre;
        private int stock;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Medicamento(string nom, int stk)
        {
            this.nombre = nom;
            this.stock = stk;
        }
    }

    class ControlFarmacia
    {
        List<Medicamento> medicamentos = new List<Medicamento>();

        public ControlFarmacia()
        {
            medicamentos = new List<Medicamento>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingresar nombre del medicamento: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingresar stock: ");
                int stock = int.Parse(Console.ReadLine());

                Medicamento nuevo = new Medicamento(nombre, stock);
                medicamentos.Add(nuevo);
            }
        }

        public void ListarStock()
        {
            Console.WriteLine("=== STOCK DE MEDICAMENTOS ===");
            for (int i = 0; i < medicamentos.Count; i++)
            {
                Console.WriteLine("Medicamento: " + medicamentos[i].Nombre + "Stock: " + medicamentos[i].Stock);
            }
        }

        public void RemoverAgotados()
        {
            for (int i = medicamentos.Count - 1; i >= 0; i--)
            {
                if (medicamentos[i].Stock == 0)
                {
                    medicamentos.RemoveAt(i);
                }
            }
            Console.WriteLine("Medicamentos agotados eliminados");
        }

        public void MostrarMedicamentosDisponibles()
        {
            Console.WriteLine("=== MEDICAMENTOS DISPONIBLES ===");
            for (int i = 0; i < medicamentos.Count; i++)
            {
                Console.WriteLine("Medicamento: " + medicamentos[i].Nombre + "Stock: " + medicamentos[i].Stock);
            }
            Console.WriteLine("Cantidad de productos disponibles: " + medicamentos.Count);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ControlFarmacia farmacia = new ControlFarmacia();
            farmacia.ListarStock();
            farmacia.RemoverAgotados();
            farmacia.MostrarMedicamentosDisponibles();

            Console.ReadKey();
        }
    }
}