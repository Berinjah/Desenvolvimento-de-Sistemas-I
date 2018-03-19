using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula1_Exemplo2
{   //inicio namespace
    class Program   
    {   //início class
        static void Main(string[] args)
        { //início main

            //Declaração de variáveis 
            int a, b, total;

            //Atribuição de valores
            a = 20;
            b = 10;

            /*Concatenação de valores a serem exibidos na tela
             * Cálculo da operação sendo realizado entre parênteses */
            Console.WriteLine(a + "+" + b + "=" + (a + b));

            //Resultado do cálculo da operação sendo atribuido em uma variável
            total = a - b;
            Console.WriteLine(a + "-" + b + "=" + total);
            Console.WriteLine(a + "*" + b + "=" + (a * b));
            Console.WriteLine(a + "/" + b + "=" + (a / b));
            Console.WriteLine(a + "%" + b + "=" + (a % b));

            Console.ReadKey(); //instrução utilizada para dar uma pausa para vizualização

        }//fim Main
    }//fim Class
}//fim namespace
