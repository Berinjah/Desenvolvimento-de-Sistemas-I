using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Aves : Animal
    {
        private string corPena;

        public virtual void fazerNinho()
        {
            Console.WriteLine("Faz o ninho com galhos e folhas");
        }
        public string getCorPena()
        {
            return corPena;
        }
        public void setCorPena(string corPena)
        {
            this.corPena = corPena;
        }
        public override string ToString()
        {
            return "Ave {" + "Peso=" + getPeso() + ", idade=" + getIdade() + ", membros=" + getMembros() + "\nCor da pena=" + corPena + "}\n\n";
        }
    }
}
