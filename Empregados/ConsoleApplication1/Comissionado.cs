using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Comissionado : Empregado
    {
        private double totalVenda;
        private double taxaComissao;

        public override double vencimento()
        {
            double venc = totalVenda * taxaComissao;
            return venc;
        }

        public double getTotalVenda()
        {
            return totalVenda;
        }
        public void setTotalVenda(double totalVenda)
        {
            this.totalVenda = totalVenda;

        }
        public double getTaxaComissao()
        {
            return taxaComissao;
        }
        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;

        }
        public override string ToString()
        {
            return "Comissionado \n{" + "Nome= " + getNome() + "\nSobrenome= " + getSobrenome() + "\nCPF= " + getCpf() + "\nTotal da venda= " + getTotalVenda() + "\nTaxa de comissão 5% ou " + getTaxaComissao() + "\nVencimento= " + vencimento() + "}\n\n";
        }
    }
}
