using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Horista : Empregado
    {
        private double precoHora;
        private double horasTrabalhadas;

        public override double vencimento()
        {
            double venc = precoHora * horasTrabalhadas;
            return venc;
        }
        public double getPrecoHora()
        {
            return precoHora;
        }
        public void setPrecoHora(double precoHora)
        {
            this.precoHora = precoHora;

        }
        public double getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }
        public void setHorasTrabalhadas(double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;

        }
        public override string ToString()
        {
            return "Horista \n{" + "Nome= " + getNome() + "\nSobrenome= " + getSobrenome() + "\nCPF= " + getCpf() + "\nPreco da hora= " + getPrecoHora() + "\nHoras trabalhadas= " + getHorasTrabalhadas() + "\nVencimento= " + vencimento() + "}\n\n";
        }

    }
}
