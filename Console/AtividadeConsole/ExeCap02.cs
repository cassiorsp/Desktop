using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeConsole
{
    class ExeCap02
    {
        public void Exe01Cap02()
        {
            Console.WriteLine("Digite o valor da temperatura em C");
            var varC = Console.ReadLine();

            var varF = (9 * double.Parse(varC) + 160)/5 ;
            Console.WriteLine("Temperatura convertida para F: {0}", varF);
            Console.WriteLine("Pressione algo para continuar");
            Console.ReadKey();
        }
        public void Exe02Cap02()
        {
            Console.WriteLine("Digite o valor da temperatura em C");
            var varC = Console.ReadLine();

            var varF = (9 * double.Parse(varC) + 160) / 5;
            Console.WriteLine("Temperatura convertida para F: {0}", varF);
            Console.WriteLine("Pressione algo para continuar");
            Console.ReadKey();
        }
        public void MsgTeste()
        {
            Console.WriteLine("Ola turma 38... :D");
        }

        public void PriExeLaço()
        {
            int[] variosValores = new int[100];
            for (int i = 0; i < 100; i++)
            {
                variosValores[i] = i + 1;
            }

            foreach(int i in variosValores )
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine("Pressione algo para continuar");
            Console.ReadKey();


            //LAÇO FOR

            //for(int i =0; i<=9; i++)
            //{

            //}

            //int j =0;
            //while(j==0)
            //{

            //}

            //do
            //{

            //} while (j == 0);
        }

    }
}
