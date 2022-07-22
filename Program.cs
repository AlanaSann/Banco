using System;

namespace BANCO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            Agencia agencia = new Agencia();
            while(opcao != 0)
            {
                int i;
                Console.WriteLine("***************************** BANCO BR ***************************");
                Console.WriteLine("\n(1)CADASTRO \n(2)VERIFICAR DADOS");
                i = int.Parse(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        break;

                    case 2:
                        break;
                }
            }






        }
    }
}
