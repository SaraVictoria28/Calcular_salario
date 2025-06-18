using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace prova
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public Aluno(string nome, int idade, double nota): base(nome, idade)
        {
            Nota=nota;
        }
        public override void Exibirdados()
        {
            Console.WriteLine($"Sou {Nome} e tenho {Idade} anos, a minha nota na prova foi {Nota} .");
        }
    }
}