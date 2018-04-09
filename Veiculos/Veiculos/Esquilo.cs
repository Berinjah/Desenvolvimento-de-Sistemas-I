using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Esquilo : Aeronave
    {
        public override void locomover()
        {
            Console.WriteLine("O veículo 'Esquilo' se locomove através de uma hélice");
        }
        public override void abastecer()
        {
            Console.WriteLine("O veículo 'Esquilo' é abastecido com Diesel");
        }
        public override string ToString()
        {
            return "\nA marca da aeronave é: " + getMarca() + "\nO ano de fabricação: " + getAno() + ", quantidade de pneus: " + getPneu() + ", a cor da fuselagem: " + getCorFuselagem() + "\n";
        }
    }
}
