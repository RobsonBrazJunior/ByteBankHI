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

            Funcionario funcionario = new Funcionario("CPF do funcionario");

            funcionario.Nome = "Nome do funcionario";
            funcionario.Salario = 2000;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(funcionario);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());

            Diretor diretor = new Diretor("CPF do diretor");
            diretor.Nome = "Nome do diretor";
            diretor.Salario = 5000;

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(diretor);

            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
