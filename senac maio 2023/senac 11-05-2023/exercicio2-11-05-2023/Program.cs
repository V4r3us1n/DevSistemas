using System;

namespace exercicio2_11_05_2023
{
    class Program
    {
        static string[,] cpfCadastrados = new string[0,2];
        static int Index = 0;
        static Funcionario[] funcionarios = new Funcionario[0];
        static Programador[] programadores = new Programador[0];
        static Suporte[] suportes = new Suporte[0];
        static double salarioFuncionario = 1200;

        static void Main(string[] args)
        {
            bool continuarLoop = true;
            int opcaoMenu = 0;

            do {
                Menu();
                Console.WriteLine("");
                Console.Write("Digite a Opção Desejada: ");
                opcaoMenu = Int32.Parse(Console.ReadLine());

                switch (opcaoMenu)
                {
                    case 1:
                        //CADASTRAR NOVO FUNCIONÁRIO
                        Console.WriteLine("CADASTRANDO NOVO FUNCIONÁRIO!");
                        Console.WriteLine("");
                        string cpfFuncionario = "";
                        do {
                            Console.Write("Digite o CPF do Funcionário (APENAS NÚMEROS): ");
                            cpfFuncionario = Console.ReadLine();

                            if (CpfValido(cpfFuncionario) == false)
                            {
                                Console.WriteLine("[ERRO!] CPF INVÁLIDO OU JÁ CADASTRADO!");
                            }
                        } while (CpfValido(cpfFuncionario) == false);

                        Console.Write("Digite o Nome do Funcionário: ");
                        string nomeFuncionario = Console.ReadLine();

                        bool funcaoValida = true;
                        string[] nomeFuncao = new string[3];
                        nomeFuncao[0] = "Funcionário Comum";
                        nomeFuncao[1] = "Programador";
                        nomeFuncao[2] = "Suporte";

                        Console.WriteLine($"[AVISO!] O Salário Base é R${salarioFuncionario}, mas pode SOFRER algumas ALTERAÇÕES de acordo com sua Função...");

                        string funcaoFuncionario = "";

                        do {
                            Console.WriteLine("[1] Funcionario Comum, [2] Programador, [3] Suporte");
                            Console.Write("Qual dos cargos acima o Novo Funcionário Exerce: ");
                            int opcaoFuncao = Int32.Parse(Console.ReadLine());

                            switch (opcaoFuncao)
                            {
                                case 1:
                                    funcaoFuncionario = nomeFuncao[0];
                                    Funcionario funcionario = new Funcionario(cpfFuncionario, nomeFuncionario, salarioFuncionario);
                                    funcionario.CalcSalario(salarioFuncionario);
                                    AumentarArrayFuncionarios(funcionario);

                                    break;
                                case 2:
                                    funcaoFuncionario = nomeFuncao[1];
                                    Programador programador = new Programador(cpfFuncionario, nomeFuncionario, salarioFuncionario);
                                    programador.CalcSalario(salarioFuncionario);
                                    AumentarArrayProgramadores(programador);

                                    break;
                                case 3:
                                    funcaoFuncionario = nomeFuncao[2];
                                    Suporte suporte = new Suporte(cpfFuncionario, nomeFuncionario, salarioFuncionario);
                                    suporte.CalcSalario(salarioFuncionario);
                                    AumentarArraySuportes(suporte);

                                    break;
                                default:
                                    Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                                    funcaoValida = false;

                                    break;
                            }
                        } while (funcaoValida == false);

                        AumentarArrayCPF(cpfFuncionario, funcaoFuncionario);

                        break;
                    case 2:
                        //EXIBIR FUNCIONÁRIOS
                        Console.WriteLine("[AVISO!] EXIBINDO FUNCIONÁRIOS");
                        Console.WriteLine("");
                        Console.WriteLine("[1] Funcionário Comum, [2] Programador, [3] Suporte, [4] Todos os Funcionários");
                        Console.Write("Digite a Opção que Condiz com o que você deseja ver: ");
                        int opcaoExibir = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        switch (opcaoExibir)
                        {
                            case 1:
                                //EXIBIR TODOS OS FUNCIONÁRIOS COMUNS
                                Console.WriteLine("[AVISO!] Exibindo Todos os Funcionáriso Comuns... ");
                                Console.WriteLine(funcionarios.Length);
                                
                                for (int i = 0; i < funcionarios.Length; i++)
                                {
                                    Console.WriteLine($"Funcionário Comum Nº{i+1}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"CPF: {funcionarios[i].CPF}");
                                    Console.WriteLine($"Nome: {funcionarios[i].Nome}");
                                    Console.WriteLine($"Salário: R${funcionarios[i].Salario}");
                                    Console.WriteLine("Função: Funcionario Comum");
                                    Console.WriteLine("");
                                }

                                break;
                            case 2:
                                //EXIBIR TODOS OS PROGRAMADORES
                                Console.WriteLine("[AVISO!] Exibindo Todos os Programadores... ");
                                
                                for (int i = 0; i < programadores.Length; i++)
                                {
                                    Console.WriteLine($"Funcionário Comum Nº{i+1}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"CPF: {programadores[i].CPF}");
                                    Console.WriteLine($"Nome: {programadores[i].Nome}");
                                    Console.WriteLine($"Salário: R${programadores[i].Salario}");
                                    Console.WriteLine("Função: Programador");
                                    Console.WriteLine("");
                                }

                                break;
                            case 3:
                                //EXIBIR TODOS OS SUPORTES
                                Console.WriteLine("[AVISO!] Exibindo Todos os Suportes... ");
                                Console.WriteLine(suportes.Length);
                                
                                for (int i = 0; i < suportes.Length; i++)
                                {
                                    Console.WriteLine($"Funcionário Comum Nº{i+1}");
                                    Console.WriteLine("---------------------------");
                                    Console.WriteLine($"CPF: {suportes[i].CPF}");
                                    Console.WriteLine($"Nome: {suportes[i].Nome}");
                                    Console.WriteLine($"Salário: R${suportes[i].Salario}");
                                    Console.WriteLine("Função: Suporte");
                                    Console.WriteLine("");
                                }

                                break;
                            case 4:
                                //EXIBIR TODOS OS FUNCIONÁRIOS
                                Console.WriteLine("[AVISO!] Exibindo Todos os Funcionários... ");

                                int k = 0;
                                
                                for (int i = 0; i < Index; i++)
                                {
                                    int posicaoFuncionario = -1;

                                    switch (cpfCadastrados[i,1])
                                    {
                                        case "Funcionário Comum":
                                            for (int j = 0; j < funcionarios.Length; j++)
                                            {
                                                if (cpfCadastrados[i,0] == funcionarios[j].CPF)
                                                {
                                                    posicaoFuncionario = j;
                                                }
                                            }

                                            Console.WriteLine($"Funcionário Nº{k+1}");
                                            Console.WriteLine("---------------------------");
                                            Console.WriteLine($"CPF: {funcionarios[posicaoFuncionario].CPF}");
                                            Console.WriteLine($"Nome: {funcionarios[posicaoFuncionario].Nome}");
                                            Console.WriteLine($"Salário: R${funcionarios[posicaoFuncionario].Salario}");
                                            Console.WriteLine("Função: Funcionário Comum");
                                            Console.WriteLine("");

                                            k++;

                                            break;
                                        case "Programador":
                                            for (int j = 0; j < programadores.Length; j++)
                                            {
                                                if (cpfCadastrados[i,0] == programadores[j].CPF)
                                                {
                                                    posicaoFuncionario = j;
                                                }
                                            }

                                            Console.WriteLine($"Funcionário Nº{k+1}");
                                            Console.WriteLine("---------------------------");
                                            Console.WriteLine($"CPF: {programadores[posicaoFuncionario].CPF}");
                                            Console.WriteLine($"Nome: {programadores[posicaoFuncionario].Nome}");
                                            Console.WriteLine($"Salário: R${programadores[posicaoFuncionario].Salario}");
                                            Console.WriteLine("Função: Programador");
                                            Console.WriteLine("");

                                            k++;

                                            break;
                                        case "Suporte":
                                            for (int j = 0; j < suportes.Length; j++)
                                            {
                                                if (cpfCadastrados[i,0] == suportes[j].CPF)
                                                {
                                                    posicaoFuncionario = j;
                                                }
                                            }

                                            Console.WriteLine($"Funcionário Nº{k+1}");
                                            Console.WriteLine("---------------------------");
                                            Console.WriteLine($"CPF: {suportes[posicaoFuncionario].CPF}");
                                            Console.WriteLine($"Nome: {suportes[posicaoFuncionario].Nome}");
                                            Console.WriteLine($"Salário: R${suportes[posicaoFuncionario].Salario}");
                                            Console.WriteLine("Função: Suporte");
                                            Console.WriteLine("");

                                            k++;

                                            break;
                                    }
                                }

                                break;
                            default:
                                //OPÇÃO INVÁLIDA
                                Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");

                                break;
                        }

                        break;
                    case 3:
                        //SAIR DO MENU
                        Console.WriteLine("[AVISO!] Saindo do Menu... ");
                        Console.WriteLine("");
                        continuarLoop = false;

                        break;
                    default:
                        //OPÇÃO INVÁLIDA
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                        Console.WriteLine("");

                        break;
                }

            } while (continuarLoop == true);
        }

        static void Menu()
        {
            Console.WriteLine("=============== MENU ===============");
            Console.WriteLine("||  [1] Inserir Novo Funcionário  ||");
            Console.WriteLine("||  [2] Exibir Funcionários       ||");
            Console.WriteLine("||  [3] Sair                      ||");;
            Console.WriteLine("====================================");
        }

        static bool CpfValido(string cpf)
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
                    if (cpfCadastrados[i,0] == cpf)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        static void AumentarArrayCPF(string cpf, string funcao)
        {
            string[,] cpfCadastradosTemp = new string[cpfCadastrados.Length+1,2];

            for (int i = 0; i < Index; i++)
            {
                cpfCadastradosTemp[i,0] = cpfCadastrados[i,0];
                cpfCadastradosTemp[i,1] = cpfCadastrados[i,1];
            }
            cpfCadastradosTemp[Index,0] = cpf;
            cpfCadastradosTemp[Index,1] = funcao;

            cpfCadastrados = cpfCadastradosTemp;
            Index++;
        }

        static void AumentarArrayFuncionarios (Funcionario funcionario)
        {
            Funcionario[] funcionariosTemp = new Funcionario[funcionarios.Length+1];

            for (int i = 0; i < funcionarios.Length; i++)
            {
                funcionariosTemp[i] = funcionarios[i];
            }
            funcionariosTemp[funcionarios.Length] = funcionario;

            funcionarios = funcionariosTemp;
        }

        static void AumentarArrayProgramadores (Programador programador)
        {
            Programador[] programadoresTemp = new Programador[programadores.Length+1];

            for (int i = 0; i < programadores.Length; i++)
            {
                programadoresTemp[i] = programadores[i];
            }
            programadoresTemp[programadores.Length] = programador;

            programadores = programadoresTemp;
        }

        static void AumentarArraySuportes (Suporte suporte)
        {
            Suporte[] suportesTemp = new Suporte[suportes.Length+1];

            for (int i = 0; i < suportes.Length; i++)
            {
                suportesTemp[i] = suportes[i];
            }
            suportesTemp[suportes.Length] = suporte;

            suportes = suportesTemp;
        }
    }
}
