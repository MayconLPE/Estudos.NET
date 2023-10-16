using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Pessoa
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        public DateTime DataAtual = DateTime.Now;

        //Metodos
        public void Apresentar()
        {
            Console.WriteLine($"Oi, Meu nome é {Nome}, e tenho {Idade} anos.");
            Console.WriteLine($"A data Atual: {DataAtual.ToString("dd/mm/yyy")}");
        }
    }
}