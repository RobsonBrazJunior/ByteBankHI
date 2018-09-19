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

            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Nome do funcionario";
            funcionario.CPF = "CPF do funcionario";
            funcionario.Salario = 2000;

            gerenciador.Registrar(funcionario);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.GetBonificacao());

            Diretor diretor = new Diretor();
            diretor.Nome = "Nome do diretor";
            diretor.CPF = "CPF do diretor";
            diretor.Salario = 5000;

            gerenciador.Registrar(diretor);

            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
