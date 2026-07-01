using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        // Punto1:
        // Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
        // CodigoIdentificador(string) y la GeneracionKwh(double, que representa los Kilowatts-hora
        // generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
        // generación no sea un valor negativo(en caso de serlo, asignarle 0). Plantear un método para
        // imprimir estos datos básicos.
        // Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
        // un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
        // en metros cuadrados) con su propiedad correspondiente(validando que sea mayor a cero).
        // Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
        // En el programa principal (Main):
        // ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
        // ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
        // puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
        // muestra de información.

        class DispositivoEnergia
        {
            private string codigoIdentificador;
            private double generacionKwh;

            public string CodigoIdentificador
            {
                set
                {
                    codigoIdentificador = value;
                }
                get
                {
                    return codigoIdentificador;
                }
            }

            public double GeneracionKwh
            {
                set
                {
                    if (value >= 0)
                    {
                        generacionKwh = value;
                    }
                    else
                    {
                        generacionKwh = 0;
                    }
                }
                get
                {
                    return generacionKwh;
                }
            }

            public void Imprimir()
            {
                Console.WriteLine("Código: " + CodigoIdentificador);
                Console.WriteLine("Generación: " + GeneracionKwh + " Kwh");
            }
        }

        class PanelSolar : DispositivoEnergia
        {
            private double areaMetros;

            public double AreaMetros
            {
                set
                {
                    if (value > 0)
                    {
                        areaMetros = value;
                    }
                    else
                    {
                        areaMetros = 1;
                    }
                }
                get
                {
                    return areaMetros;
                }
            }

            public void ImprimirPanel()
            {
                Imprimir();
                Console.WriteLine("Área: " + AreaMetros + " m²");
            }
        }


        static void Main(string[] args)
        {
            DispositivoEnergia d = new DispositivoEnergia();
            Console.Write("Ingrese código: ");
            d.CodigoIdentificador = Console.ReadLine();
            Console.Write("Ingrese generación: ");
            d.GeneracionKwh = double.Parse(Console.ReadLine());
            d.Imprimir();

            PanelSolar p = new PanelSolar();
            Console.Write("Ingrese código del panel: ");
            p.CodigoIdentificador = Console.ReadLine();
            Console.Write("Ingrese generación: ");
            p.GeneracionKwh = double.Parse(Console.ReadLine());
            Console.Write("Ingrese área: ");
            p.AreaMetros = double.Parse(Console.ReadLine());
            p.ImprimirPanel();

            Console.ReadKey();
        }
    }
}