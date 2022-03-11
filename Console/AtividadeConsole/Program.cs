using System;

namespace AtividadeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancias de classes
            ItensIniciais itensIniciais = new();
            ExeCap02 exeCap02 = new ();
            
            string loop = "ficar";
            do
            {
                var opc = itensIniciais.Inicio();

                if (opc == 1)
                {
                    itensIniciais.Retorno();
                    exeCap02.Exe01Cap02();
                }
                else if (opc == 2)
                {
                    itensIniciais.Retorno();
                    exeCap02.Exe02Cap02();
                }
                else if(opc ==3)
                {
                    itensIniciais.Retorno();
                    exeCap02.PriExeLaço();
                }
                else if(opc == 0)
                {
                    loop = "sair";
                }

            } while (loop != "sair");
             
        }
    }
}
