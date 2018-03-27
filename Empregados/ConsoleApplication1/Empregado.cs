using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Empregado
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public virtual double vencimento()
        {
            return 1.75; //número aleatório
        }

        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;

        }
        public string getSobrenome()
        {
            return sobrenome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;

        }
        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;

        }
    }
}
