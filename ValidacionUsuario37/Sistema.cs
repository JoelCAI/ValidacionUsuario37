using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionUsuario37
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            string cadena = Validador.PedirCaracter("\n Ingrese entre 10 y 20 caracteres", 10, 20);

            Console.Clear();
            Console.WriteLine("\n Usted escribio: *" + cadena + "*" + " que tiene " + cadena.Length + " caracteres." +
                              "\n Está en el rango permitido.");

            Validador.Despedida();
        }

        
        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
