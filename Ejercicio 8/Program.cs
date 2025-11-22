using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void invertir(char[] c)
        {
            {
                char aux;
                int size = c.Length;
                for (int i = 0; i < size / 2; i++)
                {
                    aux = c[i];
                    c[i] = c[size - i - 1];
                    c[size - i - 1] = aux;
                }
            }
            static void imprimir(char[] c)
            {
                int size = c.Length;
                Console.Write("c[{0}] = ", size);
                for (int i = 0; i < size; i++)
                {
                    Console.Write("[{0}]", c[i]);
                }
            }
            static char[] ingreso()
            {
                char[] c;
                Console.Write("Digite una frase: ");
                c = Console.ReadLine().ToCharArray();
                return c;
            }
            static void Main(string[] args)
            {
                char[] c;
                c = ingreso();
                invertir(c);
                Console.WriteLine("\nFrase invertida: ");
                imprimir(c);
                Console.ReadKey();
            }
        }
    }
}
    