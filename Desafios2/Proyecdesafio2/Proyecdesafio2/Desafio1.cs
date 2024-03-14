using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecdesafio2
{
    public class Desafio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa tu nombre");
            string usuario = Console.ReadLine();

            Console.WriteLine(" Ingresa tu nombre");
            double ingresoMes1 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingresa tu nombre");
            double ingresoMes2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" Ingresa tu nombre");
            double ingresoMes3 = double.Parse(Console.ReadLine());

            CalcularyMostrarIngresos(usuario, ingresoMes1, ingresoMes2, ingresoMes3);
        }
        static void CalcularyMostrarIngresos(string usuario, double ingresoMes1, double ingresoMes2, double ingresoMes3)
        {
            double sumaIngresos = ingresoMes1 + ingresoMes2 + ingresoMes3;
            double promedioIngresos = sumaIngresos / 3;

            Console.Write($"Hola{usuario}, el total ganaste ${sumaIngresos} y promediste ${promedioIngresos} En los ultimos 3 meses. ");
        }

    }
}
    

    

