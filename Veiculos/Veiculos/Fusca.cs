using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Fusca : Carro
    {
        public override void locomover()
        {
            Console.WriteLine("O veículo 'Fusca' se locomove com tração em somente 2 rodas");
        }
        public override void abastecer()
        {
            Console.WriteLine("O veículo 'Fusca' é abastecido com gasolina");
        }
        public override string ToString()
        {
            return "\nA marca do carro é: " + getMarca() + "\nO ano de fabricação: " + getAno() + ", quantidade de pneus: " + getPneu() + ", a cor do carro: " + getCorCarro() + "\n";
        }
    }
}
