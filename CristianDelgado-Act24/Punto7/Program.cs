using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto7
{
    // Punto7:
    // Un restaurante automatizado procesa la comanda de una mesa para controlar la preparación y el cobro de los platos pedidos.
    //  Crear la clase Plato que contenga como atributos privados: nombrePlato
    // (string) y precio (double). Definir sus propiedades correspondientes y un constructor que reciba nom y pre.
    //  Crear la clase GestionComandas que administre una lista de objetos List.
    //  Métodos en GestionComandas:
    // o AgregarPlato():Solicitar por teclado los datos de un plato y agregarlo a la lista utilizando .Add().
    // o MostrarComanda(): Listar todos los platos agregados hasta el momento junto a la cantidad total de ítems
    // pedidos utilizando la propiedad.Count.
    // o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto total a cobrar sumando los precios de la lista.
    // o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
    // se encuentra en la lista, removerlo mediante .Remove() para actualizar la comanda.

    class Plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            get { return nombrePlato; }
            set { nombrePlato = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Plato(string nom, double pre)
        {
            this.nombrePlato = nom;
            this.precio = pre;
        }
    }

    class GestionComandas
    {
        List<Plato> platos = new List<Plato>();

        public GestionComandas()
        {
            platos = new List<Plato>();
        }

        public void AgregarPlato()
        {
            Console.Write("Ingresar nombre del plato: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresar precio: ");
            double precio = double.Parse(Console.ReadLine());

            Plato nuevoPlato = new Plato(nombre, precio);
            platos.Add(nuevoPlato);

            Console.WriteLine("Plato agregado");
        }

        public void MostrarComanda()
        {
            Console.WriteLine("=== COMANDA ===");
            if (platos.Count == 0)
            {
                Console.WriteLine("No hay platos pedidos.");
            }
            else
            {
                for (int i = 0; i < platos.Count; i++)
                {
                    Console.WriteLine("Plato: " + platos[i].NombrePlato + "Precio: $" + platos[i].Precio);
                }
                Console.WriteLine("Cantidad total de items: " + platos.Count);
            }
        }

        public void CalcularTotalMesa()
        {
            double total = 0;
            for (int i = 0; i < platos.Count; i++)
            {
                total = total + platos[i].Precio;
            }

            Console.WriteLine("Total a cobrar: $" + total);
        }

        public void CancelarPlato()
        {
            Console.Write("Ingresar nombre del plato a cancelar: ");
            string nombre = Console.ReadLine();
            Plato platoEncontrado = null;
            for (int i = 0; i < platos.Count; i++)
            {
                if (platos[i].NombrePlato == nombre)
                {
                    platoEncontrado = platos[i];
                    break;
                }
            }
            if (platoEncontrado != null)
            {
                platos.Remove(platoEncontrado);
                Console.WriteLine("Plato cancelado correctamente");
            }
            else
            {
                Console.WriteLine("El plato no se encuentra en la comanda");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GestionComandas gestion = new GestionComandas();
            gestion.AgregarPlato();
            gestion.AgregarPlato();
            gestion.MostrarComanda();
            gestion.CalcularTotalMesa();
            gestion.CancelarPlato();
            gestion.MostrarComanda();
            gestion.CalcularTotalMesa();

            Console.ReadKey();
        }
    }
}