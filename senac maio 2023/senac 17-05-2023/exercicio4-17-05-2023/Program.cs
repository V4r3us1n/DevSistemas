using System;

namespace exercicio4_17_05_2023
{
    class Program
    {
        public const double salario = 1320;
        static void Main(string[] args)
        {
            bool continuarLoop = true;
            string cpf = "";
            string nome = "";
            int cargo = 0;

            do {
                Console.WriteLine("============= PROGRAMA FOLHA DE PAGAMENTO =============");
                Console.WriteLine("");

                //Solicitando CPF do Funcionário
                do {
                    Console.Write("Digite o CPF do Funcionário: ");
                    cpf = Console.ReadLine();
                    
                    if (ValidarCPF(cpf) == false)
                    {
                        Console.WriteLine("[ERRO!] CPF INVÁLIDO!");
                        Console.WriteLine("");
                    }
                } while (ValidarCPF(cpf) == false);

                Console.WriteLine("");

                //Solicitando Nome do Funcionário
                Console.Write("Digite o Nome do Funcionário: ");
                nome = Console.ReadLine();

                //Solicitando Cargo do Funcionário
                do {
                    Console.WriteLine("");
                    Console.WriteLine("[1] Funcionário Comum, [2] Gerente, [3] Diretor");
                    Console.Write("Informe o Cargo do Funcionário de Acordo com as Opções Acima: ");
                    cargo = Int32.Parse(Console.ReadLine());

                    if (cargo < 1 || cargo > 3)
                    {
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                        Console.WriteLine("");
                    }
                } while (cargo < 1 || cargo > 3);

                Funcionario funcionario;

                //Definindo Cargo
                switch (cargo)
                {
                    case 1:
                        funcionario = new FuncionarioComum(cpf, nome);

                        //EXIBINDO FOLHA DE PAGAMENTO
                        ExibirFolhaPagamento(funcionario);

                        break;
                    case 2:
                        funcionario = new Gerente(cpf, nome);

                        //EXIBINDO FOLHA DE PAGAMENTO
                        ExibirFolhaPagamento(funcionario);

                        break;
                    case 3:
                        funcionario = new Diretor(cpf, nome);

                        //EXIBINDO FOLHA DE PAGAMENTO
                        ExibirFolhaPagamento(funcionario);

                        break;
                }

                Console.WriteLine("");

                //PERGUNTANDO SE O USUÁRIO DESEJA CONTINUAR VENDO FOLHAS DE PAGAMENTO
                Console.WriteLine("Deseja Continuar? [S/N]");
                string resposta = Console.ReadLine();

                if (resposta.ToUpper() == "N")
                {
                    //SAINDO DO PROGRAMA
                    Console.WriteLine("[AVISO!] Terminando o Porgrama... ");
                    Console.WriteLine("");
                    continuarLoop = false;
                }

            } while (continuarLoop == true);
        }

        static bool ValidarCPF(string cpf)
        {
            if (cpf.Length != 11)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < cpf.Length; i++)
                {
                    if (cpf[i] < 48 || cpf[i] > 57)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        static void ExibirFolhaPagamento(Funcionario funcionario)
        {
            Console.WriteLine("========== EXIBINDO FOLHA DE PAGAMENTO ==========");
            Console.WriteLine("");
            Console.WriteLine($"CPF: {funcionario.CPF}");
            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Cargo: {funcionario.DefinirCargo()}");
            Console.WriteLine($"Salário: R${funcionario.CalcSalario(salario)}");
            Console.WriteLine($"Imposto: R${funcionario.CalcImposto()}");
            Console.WriteLine("");
            Console.WriteLine("=================================================");
        }
    }
}
