using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Cb200 : Motocicleta
    {
        public override void locomover()
        {
            Console.WriteLine("O veículo 'CB200' se locomove com tração traseira");
        }
        public override void abastecer()
        {
            Console.WriteLine("O veículo 'CB200' é abastecido com Álcool");
        }
        public override string ToString()
        {
            return "\nA marca da motocicleta é: " + getMarca() + "\nO ano de fabricação: " + getAno() + ", quantidade de pneus: " + getPneu() + ", a cor da motocileta: " + getCorMotocicleta() + "\n";
        }
    }
}
