using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        // Punto4: Inventario de Sucursales
        // Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual.El constructor de la clase debe cargar estos atributos por teclado.
        // Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo.El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
        // Implementar en la clase Sucursal los siguientes métodos:
        // 1. Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio* Stock).
        // 2. Un método que busque y muestre el nombre del artículo más caro del local.
        // 3. Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).

        class Articulo
        {
            private string nombreArticulo;
            private decimal precio;
            private int stockActual;

            public Articulo()
            {
                Console.Write("Ingrese nombre del articulo: ");
                nombreArticulo = Console.ReadLine();
                Console.Write("Ingrese precio: ");
                precio = decimal.Parse(Console.ReadLine());
                Console.Write("Ingrese stock: ");
                string linea = Console.ReadLine();
                stockActual = int.Parse(linea);
            }

            public string RetornarNombre()
            {
                return nombreArticulo;
            }

            public decimal RetornarPrecio()
            {
                return precio;
            }

            public int RetornarStock()
            {
                return stockActual;
            }
        }

        class Sucursal
        {
            private string nombreSucursal;
            private Articulo[] articulos;

            public Sucursal()
            {
                Console.Write("Ingrese nombre de la sucursal: ");
                nombreSucursal = Console.ReadLine();
                articulos = new Articulo[3];
                for (int i = 0; i < 3; i++)
                {
                    articulos[i] = new Articulo();
                }
            }

            public void MostrarInventario()
            {
                for (int i = 0; i < 3; i++)
                {
                    decimal total = articulos[i].RetornarPrecio() * articulos[i].RetornarStock();
                    Console.WriteLine(articulos[i].RetornarNombre() + " - Valor total: " + total);
                }
            }

            public void ArticuloMasCaro()
            {
                Articulo caro = articulos[0];
                for (int i = 1; i < 3; i++)
                {
                    if (articulos[i].RetornarPrecio() > caro.RetornarPrecio())
                    {
                        caro = articulos[i];
                    }
                }
                Console.WriteLine("Articulo mas caro: " + caro.RetornarNombre());
            }

            public void ReposicionUrgente()
            {
                for (int i = 0; i < 3; i++)
                {
                    if (articulos[i].RetornarStock() <= 5)
                    {
                        Console.WriteLine("Reponer: " + articulos[i].RetornarNombre());
                    }
                }
            }

            static void Main(string[] args)
            {
                Sucursal sucursal = new Sucursal();
                sucursal.MostrarInventario();
                sucursal.ArticuloMasCaro();
                sucursal.ReposicionUrgente();
                Console.ReadKey();
            }
        }
    }
}