using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animais
{
    class Cachorro : Mamifero
    {
        public void enterrarOsso()
        {
            Console.WriteLine("Enterra o osso");
        }
        public void abanarRabo()
        {
            Console.WriteLine("Abana o rabo");
        }
        public string reagir(String atitude){
            if (atitude == "Brincar" && atitude == "Acariciar"){
                return abanarRabo;
            }
            else{
                Console.WriteLine("Rosna");
            }
        public int reagir(int hora, min){
            if(hora<12){
                Console.WriteLine("Abana o rabo e late");
            }
            else if(hora>=18){
                Console.WriteLine("Não liga para o dono");
            }
            else{
                return abanarRabo;
            }
        }
        public Boolean reagir(Boolean dono){
            if (done == true){
                Console.WriteLine("Abana o rabo e brinca");
            }
            else{
                Console.WriteLine("Avança e rosna");
            }
        }
    }
}
