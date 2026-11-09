using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana11
{
    internal class validador
    {
        public static int LeerEntero(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor < 1 || valor > 5)
                    {
                        Console.WriteLine("ERROR: El valor es entre 0-5");
                        continue;
                    }
                    return valor;
                }
                Console.WriteLine("ERROR: el valor debe ser numerico entero");
            }
        }
        public static double LeerDecimales(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    if (valor < 0 || valor > 20)
                    {
                        Console.WriteLine("ERROR: La nota debe ser entre [0-20]");
                        continue;
                    }
                    return valor;
                }
                Console.WriteLine("ERROR: El valor debe ser numerico decimal");
            }
        }
        public static string LeerTexto(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string texto = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(texto))
                    return texto;
                Console.WriteLine("ERROR: Este campo no puede ser vacio...!!");
            }
        }
    }
}