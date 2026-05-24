using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto5:
            //  Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo
            //  (La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).

            Console.Write("Ingrese el radio del círculo: ");
            double radio = double.Parse(Console.ReadLine());

            double circunferencia = 2 * Math.PI * radio;
            double area = Math.PI * radio * radio;

            Console.WriteLine("La circunferencia es: " + circunferencia);
            Console.WriteLine("El área es: " + area);

            Console.ReadKey();
        }
    }
}