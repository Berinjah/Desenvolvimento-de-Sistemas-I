using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Legacy450 aviao1 = new Legacy450();
            Cb200 moto = new Cb200();
            Esquilo helicoptero = new Esquilo();
            Caiaque barco = new Caiaque();
            PicapeS10 carro1 = new PicapeS10();
            Fusca carro2 = new Fusca();

            aviao1.setMarca("Embraer Legacy 450");
            aviao1.setAno(2010);
            aviao1.setPneu(3);
            aviao1.setCorFuselagem("Branco");
            Console.Write(aviao1.ToString()); 
            aviao1.arremeter();
            aviao1.locomover();
            aviao1.abastecer();
            aviao1.decolar("sol");
            aviao1.decolar(1);
            aviao1.decolar(true);

            moto.setMarca("Honda CB200");
            moto.setAno(2015);
            moto.setPneu(2);
            moto.setCorMotocicleta("Amarela");
            Console.Write(moto.ToString()); 
            moto.locomover();
            moto.abastecer();

            helicoptero.setMarca("Eurocopter Esquilo");
            helicoptero.setAno(2010);
            helicoptero.setPneu(0);
            helicoptero.setCorFuselagem("Azul");
            Console.Write(helicoptero.ToString()); 
            helicoptero.abastecer();
            helicoptero.locomover();
            helicoptero.abastecer();

            barco.setMarca("Caiaque Caiaker");
            barco.setAno(1990);
            barco.setPneu(0);
            barco.setCorCasco("Amarelo");
            Console.Write(barco.ToString()); 
            barco.ancorar();
            barco.locomover();
            barco.abastecer();

            carro1.setMarca("Chevrolet S10");
            carro1.setAno(2012);
            carro1.setPneu(4);
            carro1.setCorCarro("Prata");
            Console.Write(carro1.ToString()); 
            carro1.locomover();
            carro1.abastecer();

            carro2.setMarca("Volkswagen Fusca");
            carro2.setAno(1978);
            carro2.setPneu(4);
            carro2.setCorCarro("Branco");
            Console.Write(carro2.ToString()); 
            carro2.locomover();
            carro2.abastecer();
            
            Console.ReadKey();

        }
    }
}
