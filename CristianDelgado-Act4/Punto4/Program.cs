using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto4:
            // En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            // cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            // finalizar al ingresar un valor negativo en el número de cuenta.
            // Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
            // a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
            // Estado de la cuenta:
            // ○ “Acreedor” si el saldo es &gt; 0.
            // ○ “Deudor” si el saldo es &lt; 0.
            // ○ “Nulo” si el saldo es = 0.
            // b) La suma total de los saldos acreedores.

            int numeroCuenta;
            float saldo;
            float sumaAcreedores = 0;

            do
            {
                Console.Write("Ingrese número de cuenta: ");
                numeroCuenta = int.Parse(Console.ReadLine());

                if (numeroCuenta >= 0)
                {
                    Console.Write("Ingrese saldo: ");
                    saldo = float.Parse(Console.ReadLine());

                    Console.Write("Cuenta: " + numeroCuenta + " - Estado: ");

                    if (saldo > 0)
                    {
                        Console.WriteLine("Acreedor");
                        sumaAcreedores += saldo;
                    }
                    else if (saldo < 0)
                    {
                        Console.WriteLine("Deudor");
                    }
                    else
                    {
                        Console.WriteLine("Nulo");
                    }
                }

            } while (numeroCuenta >= 0);

            Console.WriteLine("Total de saldos acreedores: $" + sumaAcreedores);

            Console.ReadKey();
        }
    }
}