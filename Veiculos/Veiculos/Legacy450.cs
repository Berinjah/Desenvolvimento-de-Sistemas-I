using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Legacy450 : Aeronave
    {
        
        public override void locomover()
        {
            Console.WriteLine("O veículo 'Legacy450' se locomove através de uma turbina");
        }
        public override void abastecer()
        {
            Console.WriteLine("O veículo 'Legacy450' é abastecido com Querosene");
        }
        public void decolar(string clima)
        {
            if (clima == "sol")
            {
                Console.WriteLine("Voo normal");
            }
            else if (clima == "chuva" || clima == "nublado" || clima == "chuva e nublado")
            {
                Console.WriteLine("Voo por instrumento");
            }
            else if (clima == "neve")
            {
                Console.WriteLine("Sem voo");
            }
            else
            {
                Console.WriteLine("Sem registro");
            }
        }
       public void decolar(int horario)
        {
            if(horario >= 1 && horario <= 12){
                Console.WriteLine("Altitude mais alta");
            }
            else if(horario > 12 && horario <= 18){
                Console.WriteLine("Altitude média");
            }
            else if(horario > 18 &&  horario < 1){
                Console.WriteLine("Altitude baixa");
            }
            else{
                Console.WriteLine("Horário inválido");
            }
        }
        public void decolar(bool tipo)
        {
            if (tipo == true)
            {
                Console.WriteLine("O voo é com passageiros. Servir refeição!");
            }
            else
            {
                Console.WriteLine("O voo é de carga. Amarrar bem a carga!");
            }
        }
        public override string ToString()
        {
            return "\nA marca da aeronave é: " + getMarca() + "\nO ano de fabricação: " + getAno() + ", quantidade de pneus: " + getPneu() + ", a cor da fuselagem: " + getCorFuselagem() + "\n";
        }
    }
}