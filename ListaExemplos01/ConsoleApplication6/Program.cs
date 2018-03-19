using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class exemplo7
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Digite um número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite outro número: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.Write(a + " + " + b + " = " + c);

            Console.ReadKey();
        }
    }
}
