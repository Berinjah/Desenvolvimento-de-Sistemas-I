using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class PicapeS10 : Carro
    {
        public override void locomover()
        {
            Console.WriteLine("O veículo 'S10' se locomove com tração nas 4 rodas");
        }
        public override void abastecer()
        {
            Console.WriteLine("O veículo 'S10' é abastecido com Diesel");
        }
        public override string ToString()
        {
            return "\nA marca do carro é: " + getMarca() + "\nO ano de fabricação: " + getAno() + ", quantidade de pneus: " + getPneu() + ", a cor do carro: " + getCorCarro() + "\n";
        }
    }
}
