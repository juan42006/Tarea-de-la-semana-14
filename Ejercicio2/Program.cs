using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                char[] a1 = { 'a', 'b', 'c' };
                char[] a2 = new char[] { 'a', 'b', 'c' };
                char[] a3 = new char[3];
                a3[0] = 'a';
                a3[1] = 'b';
                a3[2] = 'c';
                //Escribe la longuitud del array
                Console.WriteLine("Tamaño a1[]: {0}", a1.Length);
                Console.WriteLine("Tamaño a2[]: {0}", a2.Length);
                Console.WriteLine("Tamaño a3[]: {0}", a3.Length);
                Console.ReadKey();
            }
        }
    }
}
    