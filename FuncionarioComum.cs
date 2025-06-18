using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova
{
    public class FuncionarioComum : Funcionario
    {
        public FuncionarioComum(string nome, string cpf, double salarioBase) : base(nome, cpf, salarioBase)
        {

        }
        
        public override double CalcularSalarioFinal()
        {
            return SalarioBase;
        }

        public override string ExibirDados()
        {
            return $"Nome: {Nome} Salário Final R${CalcularSalarioFinal()}\n";
        }
    }
}