using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Assalariado : Empregado
    {
        private double salario;

        public override double vencimento()
        {
            double venc = salario;
            return venc;
        }

        public double getSalario()
        {
            return salario;
        }
        public void setSalario(double salario)
        {
            this.salario = salario;
        }
        public override string ToString()
        {
            return "Assalariado \n{" + "Nome= " + getNome() + "\nSobrenome= " + getSobrenome() + "\nCPF= " + getCpf() + "\nSalário= " + getSalario() + "\nVencimento= " + vencimento() + "}\n\n";
        }

       
    }
}
