using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    // Punto3:
    // Actividad 3: Estadísticas de visitas a zonas arqueológicas
    // Problema:
    // Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
    // arqueológicas durante 4 semanas.
    // Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los días.Luego:
    //  Calcular el total de visitas por zona y almacenarlo en un vector.
    //  Mostrar los datos en forma tabular.
    //  Agregar estos resultados a una lista llamada zonasVisitadas que contenga nombres de zonas y total de visitas.
    //  Determinar cuál fue la zona más visitada.

    class Zona
    {
        public string Nombre;
        public int Total;

        public Zona(string n, int t)
        {
            Nombre = n;
            Total = t;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] visitas = new int[3, 4];
            int[] totalZona = new int[3];
            string[] nombres = { "Zona Norte", "Zona Sur", "Zona Central" };

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine("Ingrese visitas para " + nombres[f] + " semana " + (c + 1));
                    visitas[f, c] = int.Parse(Console.ReadLine());
                    totalZona[f] = totalZona[f] + visitas[f, c];
                }
            }

            Console.WriteLine("Tabla de visitas:");

            for (int f = 0; f < 3; f++)
            {
                Console.Write(nombres[f] + ": ");

                for (int c = 0; c < 4; c++)
                {
                    Console.Write(visitas[f, c] + " ");
                }

                Console.WriteLine();
            }

            List<Zona> zonasVisitadas = new List<Zona>();
            for (int i = 0; i < 3; i++)
            {
                Zona z = new Zona(nombres[i], totalZona[i]);
                zonasVisitadas.Add(z);
            }

            Console.WriteLine("Total de visitas por zona:");

            foreach (Zona z in zonasVisitadas)
            {
                Console.WriteLine(z.Nombre + ": " + z.Total);
            }

            int mayor = zonasVisitadas[0].Total;
            string zonaMayor = zonasVisitadas[0].Nombre;
            foreach (Zona z in zonasVisitadas)
            {
                if (z.Total > mayor)
                {
                    mayor = z.Total;
                    zonaMayor = z.Nombre;
                }
            }
            Console.WriteLine("Zona mas visitada: " + zonaMayor);
        }
    }
}