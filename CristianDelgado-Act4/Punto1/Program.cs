using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Punto1:
            // En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            // $500, realizar un programa que lea los sueldos que cobra cada empleado e
            // informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            // de $300.Además el programa deberá informar el importe que gasta la empresa
            // en sueldos al personal.
            int n;
            int entre100y300 = 0;
            int mayor300 = 0;
            float sueldo;
            float totalSueldos = 0;

            Console.Write("Ingrese la cantidad de empleados: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Ingrese sueldo del empleado " + i + ": ");
                sueldo = float.Parse(Console.ReadLine());

                if (sueldo >= 100 && sueldo <= 300)
                {
                    entre100y300++;
                }
                else if (sueldo > 300)
                {
                    mayor300++;
                }

                totalSueldos += sueldo;
            }

            Console.WriteLine("Cantidad entre $100 y $300: " + entre100y300);
            Console.WriteLine("Cantidad mayor a $300: " + mayor300);
            Console.WriteLine("Total que gasta la empresa: $" + totalSueldos);

            Console.ReadKey();
        }
    }
}