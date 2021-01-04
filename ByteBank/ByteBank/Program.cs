﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "109203190193");
            carlos.Nome = "Carlos";
            //carlos.CPF = "109203190193";
            //carlos.Salario = 2000;

            carlos.AumentarSalario();
            Console.WriteLine("Salario do carlos após aumento: " + carlos.Salario);

            gerenciador.Registrar(carlos);

            Diretor jessica = new Diretor(5000, "2109203190193");
            jessica.Nome = "Jessica";
            //jessica.CPF = "109203190193";
            //jessica.Salario = 5000;

            jessica.AumentarSalario();
            Console.WriteLine("Salario da jessica após aumento: " + jessica.Salario);


            gerenciador.Registrar(jessica);


            Funcionario robertaTeste = jessica;


            Console.WriteLine("Boniticacao diretor " + jessica.GetBonificacao());
            Console.WriteLine("Boniticacao funcionario " + robertaTeste.GetBonificacao());

           

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
            Console.WriteLine(jessica.Nome);
            Console.WriteLine(jessica.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
    }
}
