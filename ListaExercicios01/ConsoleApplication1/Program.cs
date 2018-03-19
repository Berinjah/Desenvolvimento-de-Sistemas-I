using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex01

            Console.WriteLine("________________________________________________________________________________");
            Console.Write("Digite seu nome: ");
            String nome = Console.ReadLine();
            Console.Write("Digite sua cidade: ");
            String cidade = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            byte idade = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("O nome é: {0} \nA cidade é: {1} \nA idade é: {2}", nome, cidade, idade);
            Console.ReadKey();

            //EX02

            Console.WriteLine("________________________________________________________________________________");
            Console.Write("Digite um número inteiro para multiplicá-lo por 2: ");
            int num = int.Parse(Console.ReadLine());
            num = num * 2;
            Console.Write(num);
            Console.ReadKey();
            
            //EX03

            Console.WriteLine("________________________________________________________________________________");
            Console.Write("Digite um número inteiro para calcular a raiz quadrada do mesmo: ");
            double num1 = int.Parse(Console.ReadLine());
            num1 = (Math.Sqrt(num1));
            Console.Write(num);
            Console.ReadKey();

            //EX04

            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Digite os valores das variáveis para realizar a seguinte expressão 'A²*5-C/(B-A%4)'\n");
            Console.Write("Digite um valor para variável A: ");
            float A = float.Parse(Console.ReadLine());
            Console.Write("Digite um valor para variável B: ");
            float B = float.Parse(Console.ReadLine());
            Console.Write("Digite um valor para variável C: ");
            float C = float.Parse(Console.ReadLine());
            double resultado = Math.Pow(A, 2) * 5 - C / (B - A % 4);
            Console.WriteLine();
            Console.Write("O resultado é: " + resultado);
            Console.ReadKey();

            //EX05

            Console.WriteLine("________________________________________________________________________________");
            string verdadeiro = "Sim, você é", falso = "Não, você não é";
            Console.Write("Digite sua idade: ");
            byte idade1 = byte.Parse(Console.ReadLine());
            Console.Write("\nVocê é maior de idade: ");
            Console.WriteLine(idade1 >= 18 ? verdadeiro : falso);
            Console.ReadKey();

            //EX06

            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Digite os valores solicitados para realizar a conversão das moedas");
            Console.Write("\nDigite o valor em reais (R$): ");
            float reais = float.Parse(Console.ReadLine());
            Console.Write("\nDigite a cotação atual do dólar($): ");
            float dolar = float.Parse(Console.ReadLine());
            float conversao = reais / dolar;
            Console.Write("O valor em dólares fica: R$" + conversao);
            Console.ReadKey();
        }
    }
}
