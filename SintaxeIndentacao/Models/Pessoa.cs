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

        //Metodos
        public void Apresentar()
        {
            Console.WriterLine($"Opa, Meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}