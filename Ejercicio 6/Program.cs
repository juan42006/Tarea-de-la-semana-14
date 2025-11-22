using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string r;
                char c;
                int ascii;
                Console.Write("Digite un caracter: ");
                c = char.Parse(Console.ReadLine());
                ascii = (int)char.ToUpper(c);
                if (ascii >= 48 && ascii <= 57)
                {
                    r = "es un numero";
                }
                else if (ascii >= 65 && ascii <= 90)
                {
                    r = "es una letra";
                }
                else
                {
                    r = "es una simbolo";
                }
                Console.WriteLine();
                Console.WriteLine("* Resultado: {0}, {1}", c, r);
                Console.ReadKey();
            }
        }
    }
}
   
