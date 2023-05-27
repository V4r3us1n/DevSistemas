using System;

namespace exercico1_02_05_2023
{
    class Program
    {

        static void Main(string[] args)
        {
            var contaBanco = new Conta();

            int verificador = 0, opcao;

            while (verificador == 0)
            {
                Console.WriteLine("[1] Criar Conta [2] Exibir Contas Cadastradas [3] Sacar [4] Depositar [5] Transferir [6] Sair");
                Console.Write("Selecione uma das Opções acima: ");
                opcao = Int32.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        contaBanco.CriarConta();
                        Console.WriteLine("Conta Cadastrada com Sucesso!");
                        break;
                    case 2:
                        string[] exibirCadastros = contaBanco.ExibirCadastros();

                        for (int i = 0; i < exibirCadastros.Length; i++)
                        {
                            Console.WriteLine(exibirCadastros[i]);
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        contaBanco.Sacar();
                        break;
                    case 4:
                        contaBanco.Depositar();
                        break;
                    case 5:
                        contaBanco.Transferir();
                        break;
                    case 6:
                        verificador++;
                        break;
                    default:
                        Console.WriteLine("[ERRO!] Opção Inválida!");
                        Console.WriteLine("");
                        break;
                }
            }
        }
    }
}
