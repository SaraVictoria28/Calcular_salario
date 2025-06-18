using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova
{
    public class Estagiario : Funcionario
    {
        public double Desconto = 0.4;

        public Estagiario(string nome, string cpf, double salarioBase) : base(nome, cpf, salarioBase)
        {

        }

        public override double CalcularSalarioFinal()
        {
            return SalarioBase - (SalarioBase * Desconto);
        }

        public override string ExibirDados()
        {
            return $"Nome: {Nome} Salário R$ {CalcularSalarioFinal()}\n";
        }
    }
}