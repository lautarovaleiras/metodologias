using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologias.factory
{
    public class LectorDeDatos
    {
        public LectorDeDatos()
        {
        }
        /**
         * Devuelve un numero por teclado.
         */
        public int numeroPorTeclado()
        {
            int numeroLeido;
            while (!int.TryParse(Console.ReadLine(), out numeroLeido))
            {
                Console.WriteLine("Número inválido. Ingrese un número válido:");
            }
            return numeroLeido;
        }

        public string stringPorTeclado()
        {
            string cadenaLeida = Console.ReadLine();
            while (string.IsNullOrEmpty(cadenaLeida))
            {
                Console.WriteLine("Cadena inválida. Ingrese una cadena válida:");
                cadenaLeida = Console.ReadLine();
            }
            return cadenaLeida;
        }
    }
}
