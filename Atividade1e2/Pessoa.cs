using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void Exibirdados()
        {
            Console.WriteLine($"Sou {Nome} e tenho {Idade} anos.\n");
        }
    }
}