using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double SalarioBase { get; set; }

        public Funcionario(string nome, string cpf, double salarioBase)
        {
            Nome = nome;
            Cpf = cpf;
            SalarioBase = salarioBase;
        }

        public virtual double CalcularSalarioFinal()
        {
            return SalarioBase;
        }

        public virtual string ExibirDados()
        {
            return $"Nome: {Nome} Salário final R$ {CalcularSalarioFinal()}\n";
        }
    }
}