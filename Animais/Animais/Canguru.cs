using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Canguru : Mamifero
    {
        public override void locomover()
        {
            Console.WriteLine("Movimenta-se pulando");
        }
        public void usarBolsa()
        {
            Console.WriteLine("Usa a bolsa");
        }
    }
}
