using System;

namespace exercicio2_24_05_2023
{
    class Program
    {
        static Cliente[] clientes = new Cliente[0];
        static void Main(string[] args)
        {
            int opcaoMenu = 0;
            bool continuarLoopMenu = true;

            do {
                //Exibindo Menu de Opções
                ExibirMenu();

                //Solicitando Opção do Menu ao Usuário
                do {
                    Console.Write("Digite a Opção Desejada: ");
                    opcaoMenu = Int32.Parse(Console.ReadLine());

                    if (opcaoMenu < 1 || opcaoMenu > 3)
                    {
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                    }
                } while (opcaoMenu < 1 || opcaoMenu > 3);

                Console.WriteLine("");

                //Exibindo Opção Escolhida
                switch (opcaoMenu)
                {
                    case 1:
                        //Inserindo Novo Cliente
                        Console.WriteLine("========== INSERINDO NOVO CLIENTE ==========");

                        //Solicitando Nome do Cliente
                        Console.Write("Digite o Nome do Cliente: ");
                        string nome = Console.ReadLine();

                        //Solicitando Idade do Cliente
                        int idade = 0;
                        do {
                            Console.Write("Digite a Idade do Cliente: ");
                            idade = Int32.Parse(Console.ReadLine());

                            //Validando Idade do Cliente
                            if (ValidarIdade(idade) == false)
                            {
                                Console.WriteLine("[ERRO!] IDADE INVÁLIDA!");
                                Console.WriteLine("");
                            }
                        } while (ValidarIdade(idade) == false);

                        //Solicidado Informações de Endereço do Cliente:
                        //Rua
                        Console.Write("Digite o Nome da Rua do Cliente: ");
                        string rua = Console.ReadLine();
                        //Bairro
                        Console.Write("Digite o Nome do Bairro do Cliente: ");
                        string bairro = Console.ReadLine();
                        //Número da Residência
                        Console.Write("Digite o Número da Residência do Cliente: ");
                        int numero = Int32.Parse(Console.ReadLine());
                        //Cidade
                        Console.Write("Digite o Nome da Cidade do Cliente: ");
                        string cidade = Console.ReadLine();
                        //Estado
                        string[] listaEstados = new string[27] {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG",
                        "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"};
                        int nEstado = 0;

                        do {
                            Console.WriteLine("[1] AC, [2] AL, [3] AP, [4] AM, [5] BA [6] CE, [7] DF, [8] ES, [9] GO, [10] MA,");
                            Console.WriteLine("[11] MT, [12] MS, [13] MG, [14] PA, [15] PB, [16] PR, [17] PE, [18] PI, [19] RJ,");
                            Console.WriteLine("[20] RN, [21] RS, [22] RO, [23] RR, [24] SC, [25] SP, [26] SE, [27] TO");
                            Console.Write("Digite o Número Correspondente ao Estado do Cliente: ");
                            nEstado = Int32.Parse(Console.ReadLine());

                            //Validando Estado
                            if (nEstado < 1 || nEstado > 27)
                            {
                                Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                                Console.WriteLine("");
                            }
                        } while (nEstado < 1 || nEstado > 27);

                        //Criando Novo Endereço
                        Endereco endereco = new Endereco(rua, bairro, numero, cidade, listaEstados[nEstado-1]);

                        //Criando Novo Cliente
                        Cliente novoCliente = new Cliente(nome, idade, endereco);

                        //Adionando Novo Cliente no Array de Clientes
                        AumentarArrayClientes(novoCliente);

                        Console.WriteLine("");
                        Console.WriteLine("[AVISO!] Cleinte Adicionado com Sucesso!");
                        Console.WriteLine("");

                        break;
                    case 2:
                        //Listando Clientes Existentes
                        Console.WriteLine("===== EXIBINDO LISTA DE CLIENTES =====");
                        Console.WriteLine("");
                        for (int i = 0; i < clientes.Length; i++)
                        {
                            Console.WriteLine($"Cliente Nº{i+1}: {clientes[i].Nome} - {clientes[i].Endereco.Cidade}({clientes[i].Endereco.Estado})");
                        }

                        Console.WriteLine("");

                        break;
                    case 3:
                        //Saindo do Menu
                        Console.WriteLine("[AVISO!] Saindo do Menu de Clientes... ");
                        Console.WriteLine("");
                        continuarLoopMenu = false;
                    
                        break;
                }
            } while (continuarLoopMenu == true);
        }

        static void ExibirMenu()
        {
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("[1] Cadastrar Cliente");
            Console.WriteLine("[2] Listar Cliente");
            Console.WriteLine("[3] Sair");
            Console.WriteLine("==========================");
        }

        static bool ValidarIdade(int idade)
        {
            if (idade < 14 || idade > 125)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void AumentarArrayClientes(Cliente novoCliente)
        {
            Cliente[] clientesTemp = new Cliente[clientes.Length + 1];

            for (int i = 0; i < clientes.Length; i++)
            {
                clientesTemp[i] = clientes[i];
            }

            clientesTemp[clientes.Length] = novoCliente;

            clientes = clientesTemp;
        }
    }
}
