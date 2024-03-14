using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecdesafio2
{
    public class InicioUsuario
    {
        static Dictionary<string, string> usuariosRegistrados = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Registrarse");
                Console.WriteLine("2.Iniciar secion");
                Console.WriteLine("3. salir");
                Console.Write("Selecciona una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarUsuario();
                        break;
                    case "2":
                        IniciarSesion();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcion no valida. Intenta de nuevo.");
                        break;



                }

            }
        }
        static void RegistrarUsuario()
        {
            Console.Write("Ingrese un nombre de usuario: ");
            string usuario = Console.ReadLine();

            if (usuariosRegistrados.ContainsKey(usuario))
            {
                Console.WriteLine("El nombre del usuario ya esta en uso. Intenta con otro.");
                return;
            }

            Console.Write("Ingrese una contraseña: ");
            string contraseña = Console.ReadLine();

            usuariosRegistrados.Add(usuario, contraseña);

            Console.WriteLine("Usuario registrado con exito.");


        }
        static void IniciarSesion()
        {
            Console.Write("Ingrese tu nombre de usuario: ");
            string usuario = Console.ReadLine();

            if (usuariosRegistrados.ContainsKey(usuario))
            {
                Console.Write("Ingrese tu contraseña: ");
                string contraseña = Console.ReadLine();

                if (usuariosRegistrados[usuario]==contraseña)
                {
                    Console.WriteLine("Inicio de secion exitoso. ¡Bienvenido! ");

                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta. Intenta de nuevo. ");

                }
            }
            else
            {
                Console.WriteLine("Nombre de usuario no encontrado. Registrate Primero.");
            }


        }

    }
}
