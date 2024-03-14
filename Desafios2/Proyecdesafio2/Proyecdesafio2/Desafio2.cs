using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecdesafio2
{
    internal class Desafio2
    {
        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;

        }
        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;

        }
        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;

        }
        public int Dividir(int numero1, int numero2)
        {
            if (numero2 != 0)
            {
                return numero1 / numero2;
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir por cero: ");
                return 0;
            }

        }
    }
    class Program
    {
        static void Main()
        {
            Desafio2 MisOperacionesMatematicas = new Desafio2();
            int numero1 = 30;
            int numero2 = 60;

            Console.WriteLine($"Suma:{MisOperacionesMatematicas.Sumar(numero1, numero2)}");
            Console.WriteLine($"Resta:{MisOperacionesMatematicas.Restar(numero1, numero2)}");
            Console.WriteLine($"Multiplicacion:{MisOperacionesMatematicas.Dividir(numero1, numero2)}");
            Console.WriteLine($"Divicion:{MisOperacionesMatematicas.Sumar(numero1, numero2)}");

        }
    }



}


    

