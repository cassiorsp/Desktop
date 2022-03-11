using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeConsole
{
    class ItensIniciais
    {
        public int Inicio()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("------Escolha uma Opção");
            Console.WriteLine("------Digite 1 para o primeiro Exercicio do Cap02");
            Console.WriteLine("------Digite 2 para o segundo Exercicio do Cap02");
            Console.WriteLine("------Digite 3 para exemplo de laço");
            Console.WriteLine("------Para SAIR digite 0");
            Console.Write("------Opção= ");
            var opc = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");

            return int.Parse(opc);
        }

        public void Retorno()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("----------------------Resposta-------------------------");
            Console.WriteLine("-------------------------------------------------------");
        }


    }
}
