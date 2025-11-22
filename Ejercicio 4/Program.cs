using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int lim1, lim2;
                char[] s = "Bienvenido a".ToCharArray();
                char[] n;
                Console.Write("* Ingresar su normbre: ");
                n = Console.ReadLine().ToCharArray();
                lim1 = s.Length;
                lim2 = n.Length;
                Array.Resize(ref s, lim2 + lim1);
                for (int i = 0; i < lim2; i++)
                {
                    s[lim1 + i] = n[i];
                }
                lim1 = lim1 + lim2;
                Console.WriteLine();
                Console.Write("* Frase: ");
                for (int i = 0; i < lim1; i++)
                {
                    Console.Write("{0}", s[i]);
                }
                Console.ReadKey();
            }
        }
    }
}
  
