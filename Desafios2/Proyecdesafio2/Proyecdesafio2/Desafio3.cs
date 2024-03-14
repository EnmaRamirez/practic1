using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecdesafio2
{
    internal class Desafio3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce el primer valor:");
                string input1 = Console.ReadLine();


                Console.WriteLine("Introduce el segundo valor:");
                string input2 = Console.ReadLine();

                int result = SumarEnteros(input1, input2);
                Console.WriteLine($"La suma es: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operacopn Completada");
            }

        }
        static int SumarEnteros(string input1, string input2)
        {
            int numero1 = int.Parse(input1);
            int numero2 = int.Parse(input2);
            return numero1 + numero2;
        }
    }
}

    

