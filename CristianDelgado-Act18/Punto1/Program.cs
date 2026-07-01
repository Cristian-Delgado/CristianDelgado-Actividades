using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
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