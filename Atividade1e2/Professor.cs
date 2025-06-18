using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public Professor(string nome, int idade, decimal salario) : base(nome, idade)
        {
            Salario = salario;
        }

        public override void Exibirdados()
        {
            Console.WriteLine($"Sou {Nome} e tenho {Idade} anos, ganho um sálario de R${Salario} por mês.\n");
        }

    }
}