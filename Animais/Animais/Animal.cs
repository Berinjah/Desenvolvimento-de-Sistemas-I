using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Animal
    {
        private float peso;
        private int idade;
        private int membros;

        public virtual void locomover()
        {
           Console.WriteLine("O animal se locomoveu");
        }
        public virtual void alimentar()
        {
            Console.WriteLine("O animal se alimentou");
        }
        public virtual void emitirSom()
        {
            Console.WriteLine("O animal emitiu um som característico");
        }
        public float getPeso()
        {
            return peso;
        }
        public void setPeso(float peso)
        {
            this.peso = peso;
        }
        public float getIdade()
        {
            return idade;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        public float getMembros()
        {
            return membros;
        }
        public void setMembros(int membros)
        {
            this.membros = membros;
        }
        public override string ToString()
        {
            return "Animal {" + "Peso=" + peso + ", idade=" + idade + ", membros=" + membros + "}";
        }


    }
}
