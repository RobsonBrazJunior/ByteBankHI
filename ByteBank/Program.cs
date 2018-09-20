using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario funcionario = new Funcionario(2000,"CPF do funcionario");

            funcionario.Nome = "Nome do funcionario";

            funcionario.AumentarSalario();
            Console.WriteLine("Novo salário do funcionário: "+ funcionario.Salario);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(funcionario);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());

            Diretor diretor = new Diretor("CPF do diretor");
            diretor.Nome = "Nome do diretor";
            Console.WriteLine(diretor.CPF);
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario funcionarioDiretor = diretor;

            diretor.AumentarSalario();
            Console.WriteLine("Novo salário de diretor: " + diretor.Salario);

            Console.WriteLine("Bonificação de uma referência de Diretor: " + diretor.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + funcionarioDiretor.GetBonificacao());

            gerenciador.Registrar(diretor);

            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
