using System;
using prova;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aluno aluno = new Aluno("Sara", 19, 10);
            // Professor professor = new Professor("Thiago", 46, 12000);
            // aluno.Exibirdados();
            // professor.Exibirdados();

            List<Funcionario> funcionario = new List<Funcionario>
            {
                new Gerente("Joao", "123.456.789-00", 5000),
                new Estagiario("Ana", "987.654.321-11", 2000),
                new FuncionarioComum("Cleber", "147.258.369-33", 3000)
            };

            foreach (var empregado in funcionario)
            {
                Console.WriteLine(empregado.ExibirDados());
            }
        }
    }
}




