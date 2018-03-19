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

            animal1.alimentar();
            animal1.emitirSom();
            animal1.setCorPena("Branca");
            animal2.setCorPelo("Laranja com manchas pretas");
            animal2.setRaca("Onça");
            animal3.setIdade(10);
            animal3.setMembros(5);
            animal3.setCorEscama("Verde escuro");
            animal4.setCorPena("Preta");
            animal4.setPeso(3.5f);
            animal4.fazerNinho();
            animal5.setRaca("Urso polar");
            animal5.setCorPelo("Branco");
            animal5.setPeso(400f);
            animal5.setIdade(20);
            animal5.setMembros(4);
            animal6.setCorEscama("Verde Claro");
            animal6.setPeso(1f);


            Console.WriteLine(animal1.ToString());
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(animal3.ToString());
            Console.WriteLine(animal4.ToString());
            Console.WriteLine(animal5.ToString());
            Console.WriteLine(animal6.ToString());

            Console.ReadKey();

        }
    }
}
