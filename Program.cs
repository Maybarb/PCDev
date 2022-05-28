using System;

namespace Exercicio.MenuOpcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO PROPOSTO EM AULA.
            //Vitor, minha intenção em escolher esse tema para o exercício é dar continuidade a ele 
            //nas futuras aulas, incrementando ao passo que avanço na linguagem. 

            bool continuar = true;
            do
            {
                Console.WriteLine("Bem-vindo ao DigiDev Bank, sua melhor opção de Banco Digital!");
                Console.WriteLine("Selecione a seguir a opção desejada");
                Console.WriteLine("1 - Consulta de Saldo\n" +
                    "2 - Saques \n" +
                    "3 - Transferências\n" +
                    "4 - Sair");

                double saldo = 1000;
                int opcao = 0;
                string resposta = Console.ReadLine();
                opcao = int.Parse(resposta);

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Seu saldo disponível é R$ " + saldo);
                        break;
                    case 2:
                        Console.WriteLine("Qual o valor deseja sacar?");
                        break;
                    case 3:
                        Console.WriteLine("Qual o valor deseja transferir?");
                        break;
                    case 4:
                    default:
                        continuar = false;
                        break;


                }

            } while (continuar);


        }
    }
}
