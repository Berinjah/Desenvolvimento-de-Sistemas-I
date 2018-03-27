using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Aves animal1 = new Aves();
            Mamifero animal2 = new Mamifero();
            Reptil animal3 = new Reptil();
            Aves animal4 = new Aves();
            Mamifero animal5 = new Mamifero();
            Reptil animal6 = new Reptil();
            Cachorro cao = new Cachorro();
            Canguru canguru = new Canguru();
            Tartaruga tartaruga = new Tartaruga();
            Tucano tucano = new Tucano();

            animal1.alimentar();
            animal1.emitirSom();
            animal1.setCorPena("Branca");
            Console.WriteLine(animal1.ToString());
            animal2.setCorPelo("Laranja com manchas pretas");
            animal2.setRaca("Onça");
            Console.WriteLine(animal2.ToString());
            animal3.setIdade(10);
            animal3.setMembros(5);
            animal3.setCorEscama("Verde escuro");
            Console.WriteLine(animal3.ToString());
            animal4.setCorPena("Preta");
            animal4.setPeso(3.5f);
            animal4.fazerNinho();
            Console.WriteLine(animal4.ToString());
            animal5.setRaca("Urso polar");
            animal5.setCorPelo("Branco");
            animal5.setPeso(400f);
            animal5.setIdade(20);
            animal5.setMembros(4);
            Console.WriteLine(animal5.ToString());
            animal6.setCorEscama("Verde Claro");
            animal6.setPeso(1f);
            Console.WriteLine(animal6.ToString());
            cao.abanarRabo();
            cao.enterrarOsso();
            cao.setCorPelo("Preto");
            cao.setIdade(10);
            cao.setRaca("Pastor Alemão");
            cao.locomover();
            Console.WriteLine(cao.ToString());
            canguru.emitirSom();
            canguru.setIdade(15);
            canguru.setCorPelo("Caramelo");
            canguru.locomover();
            Console.WriteLine(canguru.ToString());
            tartaruga.setIdade(50);
            tartaruga.setPeso(5);
            tartaruga.locomover();
            Console.WriteLine(tartaruga.ToString());
            tucano.setCorPena("Preta e com detalhes em amarelo e branco");
            tucano.locomover();
            tucano.fazerNinho();
            Console.WriteLine(tucano.ToString());

            Console.ReadKey();

        }
    }
}
