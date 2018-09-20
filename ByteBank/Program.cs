using ByteBank.Funcionarios;
using ByteBank.Sistemas;
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
            //CaulcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor diretor = new Diretor("159.753.398-04");
            diretor.Nome = "Roberta";
            diretor.Senha = "123";

            GerenteDeConta gerenteDeConta = new GerenteDeConta("326.985.628-89");
            gerenteDeConta.Nome = "Camila";
            gerenteDeConta.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistema.Logar(parceiro, "123456");

            sistema.Logar(diretor, "123");
            sistema.Logar(gerenteDeConta, "abc");

        }

        public static void CaulcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer designer = new Designer("833.22.048-39");
            designer.Nome = "Pedro";

            Diretor diretor = new Diretor("159.753.398-04");
            diretor.Nome = "Roberta";

            Auxiliar auxiliar = new Auxiliar("981.198.778-53");
            auxiliar.Nome = "Igor";

            GerenteDeConta gerenteDeConta = new GerenteDeConta("326.985.628-89");
            gerenteDeConta.Nome = "Camila";

            gerenciador.Registrar(designer);
            gerenciador.Registrar(diretor);
            gerenciador.Registrar(auxiliar);
            gerenciador.Registrar(gerenteDeConta);

            Console.WriteLine("Total de bonificações do mês: " + gerenciador.GetTotalBonificacao());
        }
    }
}
