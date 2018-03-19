using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Reptil : Animal
    {
        private string corEscama;

        public string getCorEscama()
        {
            return corEscama;
        }
        public void setCorEscama(string corEscama)
        {
            this.corEscama = corEscama;
        }
        public override string ToString()
        {
            return "Reptil {" + "Cor da escama=" + corEscama +"}";
        }
    }
}
