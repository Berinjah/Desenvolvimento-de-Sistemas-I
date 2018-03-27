using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Tartaruga : Reptil
    {
        public override void locomover()
        {
            Console.WriteLine("Move-se lentamente");
        }
    }
}
