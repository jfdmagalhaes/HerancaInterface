using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {

        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor jessica = new Diretor(5000, "2109203190193");
            jessica.Nome = "Jessica";
            jessica.Senha = "123";

            sistemaInterno.Logar(jessica, "19828");


        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario carlos = new Diretor(2000, "109203190193");
            carlos.Nome = "Carlos";
            //carlos.AumentarSalario();

            
            Diretor jessica = new Diretor(5000, "2109203190193");
            jessica.Nome = "Jessica";
            //jessica.AumentarSalario();

            gerenciador.Registrar(carlos);
            gerenciador.Registrar(jessica);

           
            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(jessica.Nome);
            Console.WriteLine(jessica.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }


    }
}
