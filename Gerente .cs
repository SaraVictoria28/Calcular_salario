using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova
{
    public class Gerente : Funcionario
    {
        public double Bonus = 1600;

        public Gerente(string nome, string cpf, double salarioBase) : base(nome, cpf, salarioBase)
        {

        }

        public override double CalcularSalarioFinal()
        {
            return SalarioBase + Bonus;
        }

        public override string ExibirDados()
        {
            return $"Nome: {Nome} Salário Final R${CalcularSalarioFinal()}\n";
        }
        
    }
}