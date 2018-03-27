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
            Assalariado empregado1 = new Assalariado();
            Comissionado empregado2 = new Comissionado();
            Horista empregado3 = new Horista();

            empregado1.setNome("João");
            empregado1.setSobrenome("Carvalho");
            empregado1.setCpf("455850978-1");
            empregado1.setSalario(5000);
            empregado2.setNome("Maria");
            empregado2.setSobrenome("Flores");
            empregado2.setCpf("455444978-1");
            empregado2.setTotalVenda(9000);
            empregado2.setTaxaComissao(0.05);
            empregado3.setNome("Carolina");
            empregado3.setSobrenome("Silva");
            empregado3.setCpf("554068789-1");
            empregado3.setPrecoHora(10);
            empregado3.setHorasTrabalhadas(44);

            Console.WriteLine(empregado1.ToString());
            Console.WriteLine(empregado2.ToString());
            Console.WriteLine(empregado3.ToString());

            Console.ReadKey();
        }
    }
}
