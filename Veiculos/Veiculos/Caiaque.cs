using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Caiaque : Embarcacao
    {
        public override void locomover()
        {
            Console.WriteLine("O veículo 'Caiaque' se locomove a remo");
        }
        public override void abastecer()
        {
            Console.WriteLine("O veículo 'Caiaque' depende da força do remador");
        }

        public override string ToString()
        {
            return "\nA marca da embarcação é: " + getMarca() + "\nO ano de fabricação: " + getAno() + ", quantidade de pneus: " + getPneu() + ", a cor do casco: " + getCorCasco() + "\n";
        }
    }
}
