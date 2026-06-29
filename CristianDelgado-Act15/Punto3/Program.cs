using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Punto3
{
    internal class Program
    {
        // Punto3:
        // Geolocalización de Reservas Naturales
        // Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
        // especies protegidas en cuadrículas de territorio.
        // ● Confeccionar la clase ReservaNatural que tenga como atributos privados el
        // NombreReserva y una matriz llamada avistamientos de 3x3(que representa un
        // mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
        // cantidad de animales avistados en cada sector). El constructor de la clase debe
        // cargar por teclado el nombre y rellenar el mapa de avistamientos.
        // ● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
        // objetos de la clase ReservaNatural.
        // La clase CentroEcologico debe implementar los siguientes métodos:
        // 1. Un constructor que solicite la carga secuencial de las 3 reservas.
        // 2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
        // registró en toda su superficie(la suma de toda su matriz rectangular).
        // 3. Un método que determine e informe cuál fue la coordenada o sector específico([fila,
        // columna]) que registró la mayor concentración de avistamientos de toda la red de
        // reservas, indicando a qué reserva pertenece.
        // Página 1 de 3C# - Constructor de la Clase y Colaboración deClases - Ejercicios extra - 2.1. Monitoreo Clínico de PacientesEn una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmocardíaco de los pacientes.● Plantear una clase llamada Paciente que tenga como atributos privados:1. Nombre (de tipo string).2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando losregistros de pulsaciones tomados durante 3 días diferentes, en 4 momentosclave de cada día: mañana, mediodía, tarde y noche).3. El constructor de Paciente debe pedir su nombre y solicitar la carga porteclado de las 12 lecturas cardíacas.● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar lacarga de los 3 pacientes. Implementar los siguientes métodos dentro deSalaMonitoreo:1. Un método que imprima la grilla de lecturas cardíacas completa de cadapaciente organizada por día y momento.2. Un método que calcule e imprima el promedio de pulsaciones de cadapaciente a lo largo de todo su monitoreo.3. Un método que verifique si algún paciente registró un evento de taquicardiasevera (cualquier lectura individual que sea estrictamente mayor a 120pulsaciones), mostrando por consola su nombre y la lectura detectada.2. Logística de Puerto EspacialUna estación de acoplamiento registra el peso de los contenedores transportados en lasbodegas de carga de las naves espaciales que llegan al puerto.● Crear la clase NaveEspacial que contenga únicamente el atributo privadoNombreNave y su constructor para cargarlo.● Crear la clase colaboradora PuertoControl que contenga:○ Un vector de 3 objetos de la clase NaveEspacial.○ Una matriz irregular de tipo double llamado pesoContenedores, dondecada fila representa a una nave, el tamaño de la fila es la cantidad debodegas que posee esa nave, y los valores almacenados son los pesos (entoneladas) de los contenedores que transporta cada bodega.En PuertoControl, definir los siguientes métodos:

        class ReservaNatural
        {
            private string nombreReserva;
            private int[,] avistamientos;

            public ReservaNatural()
            {
                avistamientos = new int[3, 3];
                Console.Write("Ingrese nombre reserva: ");
                nombreReserva = Console.ReadLine();
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write("Ingrese avistamientos: ");
                        string linea = Console.ReadLine();
                        avistamientos[f, c] = int.Parse(linea);
                    }
                }
            }

            public int Total()
            {
                int suma = 0;
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        suma += avistamientos[f, c];
                    }
                }
                return suma;
            }

            public void Imprimir()
            {
                Console.WriteLine(nombreReserva + " total: " + Total());
            }

            public int Mayor()
            {
                int mayor = avistamientos[0, 0];
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (avistamientos[f, c] > mayor)
                        {
                            mayor = avistamientos[f, c];
                        }
                    }
                }
                return mayor;
            }
        }

        class CentroEcologico
        {
            private ReservaNatural reserva1, reserva2, reserva3;

            public CentroEcologico()
            {
                reserva1 = new ReservaNatural();
                reserva2 = new ReservaNatural();
                reserva3 = new ReservaNatural();
            }

            public void Totales()
            {
                reserva1.Imprimir();
                reserva2.Imprimir();
                reserva3.Imprimir();
            }

            public void MayorAvistamiento()
            {
                int mayor = reserva1.Mayor();

                if (reserva2.Mayor() > mayor)
                {
                    mayor = reserva2.Mayor();
                }

                if (reserva3.Mayor() > mayor)
                {
                    mayor = reserva3.Mayor();
                }

                Console.WriteLine("Mayor avistamiento: " + mayor);
            }

            static void Main(string[] args)
            {
                CentroEcologico centro = new CentroEcologico();
                centro.Totales();
                centro.MayorAvistamiento();
                Console.ReadKey();
            }
        }
    }
}