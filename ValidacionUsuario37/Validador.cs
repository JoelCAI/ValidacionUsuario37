using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionUsuario37
{
    public class Validador
    {
        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
            
        }

        public static string PedirCaracter(string mensaje, int min, int max)
        {
            string valor;
            bool valido = false;
            string mensajeMenu = "\n El número de caracteres a ingresar es entre " + min + " y " + max;
            string mensajeError = "\n El valor no puede ser vacio y tiene que estar dentro del rango solicitado. ";

            do
            {

                Console.WriteLine(mensaje);
                Console.WriteLine(mensajeMenu);

                valor = Console.ReadLine();
               

                if (valor.Length < min || valor.Length > max)
                {
                    Console.Clear();
                    Console.WriteLine(mensajeError);
                    
                }
                else
                {
                    
                    valido = true;
                    
                }

            } while (!valido);

            
            return valor;

        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }


    }
}
