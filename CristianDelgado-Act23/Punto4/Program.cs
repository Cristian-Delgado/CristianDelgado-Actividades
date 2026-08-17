using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    // Punto4:
    // Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
    // vinculados a una red hogareña.
    //  Crear la clase DispositivoInteligente que contenga como atributos
    // privados: nombreDispositivo(string) y consumoWatts(double). Definir
    // sus propiedades y un constructor que reciba nom y watts.
    //  Crear la clase colaboradora PanelDomotico que administre un objeto
    // List&lt;DispositivoInteligente&gt;.
    //  Métodos en PanelDomotico:
    // 1. Un constructor que permita al usuario cargar dinámicamente
    // dispositivos por teclado.El sistema preguntará después de cada carga si se desea agregar otro dispositivo.
    // 2. MostrarDispositivos(): Listar todos los dispositivos configurados junto a sus consumos.
    // 3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
    // Watts totales que consume la casa sumando los valores de la lista.
    // 4. DesconectarDispositivo(): Solicitar al usuario el nombre de
    // un dispositivo y, si existe en la lista, removerlo de forma dinámica
    // para simular su apagado remoto.
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo
        {
            get { return nombreDispositivo; }
            set { nombreDispositivo = value; }
        }

        public double ConsumoWatts
        {
            get { return consumoWatts; }
            set { consumoWatts = value; }
        }

        public DispositivoInteligente(string nom, double watts)
        {
            this.nombreDispositivo = nom;
            this.consumoWatts = watts;
        }
    }

    class PanelDomotico
    {
        List<DispositivoInteligente> dispositivos = new List<DispositivoInteligente>();
       
        public PanelDomotico()
        {
            bool auxF = true;
            while (auxF)
            {
                Console.Write("Ingresar nombre del dispositivo inteligente: ");
                string auxND = Console.ReadLine();
                Console.Write("Ingrese el consumo en Watts del mismo: ");
                double auxC = double.Parse(Console.ReadLine());
                DispositivoInteligente newDI = new DispositivoInteligente(auxND, auxC);
                dispositivos.Add(newDI);
                Console.Write("Agregar otro dispositivo Y/N: ");
                string auxN = Console.ReadLine();
            }
        }

        public void MostrarDispositivos()
        {
            Console.WriteLine();
            Console.WriteLine("=== DISPOSITIVOS ===");
            foreach (DispositivoInteligente d in dispositivos)
            {
                Console.WriteLine("Dispositivo: " + d.NombreDispositivo + " Consumo: " + d.ConsumoWatts + " Watts");
            }
        }

        public void CalcularConsumoTotal()
        {
            double total = 0;
            foreach (DispositivoInteligente d in dispositivos)
            {
                total += d.ConsumoWatts;
            }

            Console.WriteLine();
            Console.WriteLine("Consumo total de la casa: " + total + " Watts");
        }

        public void DesconectarDispositivo()
        {
            Console.Write("Ingrese el nombre de un dispositivo para apagarlo: ");
            string texto = Console.ReadLine();
            bool verificarExistencia = false;
            foreach (DispositivoInteligente dispositivo in dispositivos)
            {
                if (texto == dispositivo.NombreDispositivo)
                {
                    dispositivos.Remove(dispositivo);
                    verificarExistencia = true;
                    break;
                }
            }
            if (verificarExistencia)
            {
                Console.WriteLine("El dispositivo esta apagado");
            }
            else
            {
                Console.WriteLine("El dispositivo no esta en el panel");
            }
        }
        
        static void Main(string[] args)
        {
            PanelDomotico pd1 = new PanelDomotico();

            pd1.MostrarDispositivos();
            pd1.CalcularConsumoTotal();
            pd1.DesconectarDispositivo();
            pd1.MostrarDispositivos();
            pd1.CalcularConsumoTotal();
            Console.ReadKey();
        }
    }
}
   