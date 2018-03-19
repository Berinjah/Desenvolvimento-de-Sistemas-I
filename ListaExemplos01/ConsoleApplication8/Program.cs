using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class exemplo9
    {
        static void Main(string[] args)
        {
            bool i, j;

            Console.WriteLine("Exemplo - Operadores Lógicos");
            Console.WriteLine("****************************\n\n");
            Console.WriteLine("Digite true (verdadeiro) ou false(falso)\n ");

            Console.Write("Valor lógico 1: ");
            i = Boolean.Parse(Console.ReadLine());
            Console.Write("Valor lógico 2: ");
            j = Boolean.Parse(Console.ReadLine());

            Console.WriteLine("\nResultados testando os operadores lógicos\n");
            Console.WriteLine("{0} and {1} resulta {2}", i, j, i && j);
            Console.WriteLine("{0} or {1} resulta {2}", i, j, i || j);
            Console.WriteLine("Valor 1: not {0} resulta {1}", i, !i);
            Console.WriteLine("Valor 1: not {0} resulta {1}", j, !j);

            Console.ReadKey();

        }
    }
}
