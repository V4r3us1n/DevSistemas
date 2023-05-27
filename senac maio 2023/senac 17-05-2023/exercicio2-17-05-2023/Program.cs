using System;

namespace exercicio2_17_05_2023
{
    class Program
    {
        static Funcionario[] funcionarios = new Funcionario[0];
        static int Index = 0;
        static void Main(string[] args)
        {
            bool continuarLoop = true;
            string cpf;
            string nome;
            const double salario = 1200;
            int opcaoCargo = 0;

            do {
                Console.WriteLine("========== CALCULANDO SALÁRIO FUNCIONÁRIOS ==========");

                do {
                    Console.WriteLine("");
                    Console.Write("Digite o CPF do Funcionário (APENAS NÚMEROS): ");
                    cpf = Console.ReadLine();
                    if (ValidarCPF(cpf) == false)
                    {
                        Console.WriteLine("[ERRO!] CPF INVÁLIDO OU JÁ CADASTRADO!");
                    }
                } while (ValidarCPF(cpf) == false);

                Console.Write("Digite o Nome do Funcionário: ");
                nome = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine($"[AVISO!] O salário base para os funcionários é R${salario}, dependendo do cargo que o mesmo exerce esse valor pode ser alterado!");

                do {
                    Console.WriteLine("");
                    Console.WriteLine("[1] Funcionário Comum, [2] Programador, [3] Suporte");
                    Console.Write("Digite o Número correspondente ao Cargo do Funcionário: ");
                    opcaoCargo = Int32.Parse(Console.ReadLine());

                    if (opcaoCargo < 1 || opcaoCargo > 3)
                    {
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                    }
                } while(opcaoCargo < 1 || opcaoCargo > 3);

                Funcionario funcionario;

                switch (opcaoCargo)
                {
                    case 1:
                        funcionario = new FuncionarioComum(cpf, nome);
                        AumentarArrayFuncionarios(funcionario);

                        break;
                    case 2:
                        funcionario = new FuncionarioProgramador(cpf, nome);
                        AumentarArrayFuncionarios(funcionario);

                        break;
                    case 3:
                        funcionario = new FuncionarioSuporte(cpf, nome);
                        AumentarArrayFuncionarios(funcionario);

                        break;
                }

                Console.WriteLine("Deseja Continuar? [S/N] ");
                string resposta = Console.ReadLine();

                if (resposta.ToUpper() == "N")
                {
                    Console.WriteLine("[AVISO!] Saindo... ");
                    continuarLoop = false;
                }
                else
                {
                    Index++;
                }

            } while (continuarLoop == true);

            RelatorioFuncionarios relatorio = new RelatorioFuncionarios(salario);

            relatorio.ExibirRelatorioFuncionarios(funcionarios);

            Console.WriteLine("");
            Console.WriteLine("==========================================================");
            Console.WriteLine($"Total Salário: R${relatorio.CalcTotalSalario(funcionarios, salario)}");
            Console.WriteLine("==========================================================");
            Console.WriteLine("");
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

                for (int i = 0; i < Index; i++)
                {
                    if (cpf == funcionarios[i].CPF)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        static void AumentarArrayFuncionarios(Funcionario funcionario)
        {
            Funcionario[] funcionariosTemp = new Funcionario[funcionarios.Length+1];

            for (int i = 0; i < funcionarios.Length; i++)
            {
                funcionariosTemp[i] = funcionarios[i];
            }

            funcionariosTemp[funcionarios.Length] = funcionario;

            funcionarios = funcionariosTemp;
        }
    }
}
