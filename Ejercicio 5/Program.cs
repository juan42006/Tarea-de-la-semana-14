using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                char[] frase;
                int lim, cont_a = 0, cont_e = 0,
                cont_i = 0, cont_o = 0, cont_u = 0;
                Console.Write("Digite una frase: ");
                frase = Console.ReadLine().ToCharArray();
                lim = frase.Length;
                for (int i = 0; i < lim; i++)
                {
                    switch (char.ToUpper(frase[i]))
                    {
                        case 'A':
                            cont_a++;
                            break;
                        case 'E':
                            cont_e++;
                            break;
                        case 'I':
                            cont_i++;
                            break;
                        case 'O':
                            cont_o++;
                            break;
                        case 'U':
                            cont_u++;
                            break;
                    }
                }
                Console.WriteLine("\nContador de vocales.");
                Console.WriteLine("* Vocal a: {0}", cont_a);
                Console.WriteLine("* Vocal e: {0}", cont_e);
                Console.WriteLine("* Vocal i: {0}", cont_i);
                Console.WriteLine("* Vocal o: {0}", cont_o);
                Console.WriteLine("* Vocal u: {0}", cont_u);
                Console.ReadKey();
            }
        }
    }
}
    