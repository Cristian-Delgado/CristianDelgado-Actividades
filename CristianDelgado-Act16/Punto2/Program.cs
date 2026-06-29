using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    internal class Program
    {
        // Punto2:
        // Plantear una clase Producto y otra clase Inventario.
        // La clase Producto debe tener como atributos privados el nombre, precio y
        // stock.Definir propiedades para acceder a estos atributos, asegurando que el
        // stock no pueda ser negativo y el precio sea mayor a cero.
        // La clase Inventario debe contener 3 objetos de la clase Producto.Definir un
        // método para mostrar todos los productos ordenados de menor a mayor en
        // base al precio, además, mostrar el producto más caro y más barato del inventario.

        class Producto
        {
            private string nombre;
            private int precio;
            private int stock;

            public string Nombre
            {
                set
                {
                    nombre = value;
                }
                get
                {
                    return nombre;
                }
            }

            public int Precio
            {
                set
                {
                    if (value > 0)
                        precio = value;
                }
                get
                {
                    return precio;
                }
            }

            public int Stock
            {
                set
                {
                    if (value >= 0)
                    {
                        stock = value;
                    }
                }
                get
                {
                    return stock;
                }
            }

            public void Mostrar()
            {
                Console.WriteLine(Nombre + " $" + Precio + " Stock: " + Stock);
            }
        }

        class Inventario
        {
            private Producto producto1, producto2, producto3;

            public Inventario()
            {
                producto1 = new Producto();
                producto1.Nombre = "Teclado";
                producto1.Precio = 15000;
                producto1.Stock = 5;

                producto2 = new Producto();
                producto2.Nombre = "Mouse";
                producto2.Precio = 10000;
                producto2.Stock = 8;

                producto3 = new Producto();
                producto3.Nombre = "Monitor";
                producto3.Precio = 80000;
                producto3.Stock = 3;
            }

            public void MostrarOrdenados()
            {
                Producto[] productos = { producto1, producto2, producto3 };

                for (int i = 0; i < 3; i++)
                {
                    for (int j = i + 1; j < 3; j++)
                    {
                        if (productos[i].Precio > productos[j].Precio)
                        {
                            Producto aux = productos[i];
                            productos[i] = productos[j];
                            productos[j] = aux;
                        }
                    }
                }

                Console.WriteLine("Productos ordenados:");
                for (int i = 0; i < 3; i++)
                {
                    productos[i].Mostrar();
                }

                Console.WriteLine("Producto mas barato:");
                productos[0].Mostrar();

                Console.WriteLine("Producto mas caro:");
                productos[2].Mostrar();
            }
        }

        static void Main(string[] args)
        {
            Inventario i = new Inventario();
            i.MostrarOrdenados();
            Console.ReadKey();
        }
    }
}