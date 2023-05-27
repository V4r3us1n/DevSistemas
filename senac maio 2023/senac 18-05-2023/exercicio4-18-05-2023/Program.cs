using System;

namespace exercicio4_18_05_2023
{
    class Program
    {
        public const double salario = 1200;
        static Funcionario[] funcionarios = new Funcionario[0];
        static void Main(string[] args)
        {
            bool continuarLoop = true;
            int tipoContrato = 0;
            string[] listaTipoContrato = new string[2] {"Pessoa Física", "Pessoa Jurídica"};
            string idFuncionario = "";
            string nome = "";
            int opcaoCargo = 0;
            string rua = "";
            int numeroResidencia = 0;
            string bairro = "";
            string cidade = "";
            int estado = 0;
            string[] listaUF = new string[27] {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG",
             "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"};

            

            do {
                //Realizando Novo Cadastro de Funcionário
                Console.WriteLine("=============== CADASTRANDO FUNCIONÁRIO ===============");
                Console.WriteLine("");

                //Solicitando Tipo de Contrato

                do {
                    Console.WriteLine("[1] Pessoa Física, [2] Pessoa Jurídica");
                    Console.Write("Digite o Nº correspondente ao Tipo de Contrato: ");
                    tipoContrato = Int32.Parse(Console.ReadLine());

                    if (tipoContrato < 1 || tipoContrato > 2)
                    {
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                    }
                } while (tipoContrato < 1 || tipoContrato > 2);

                switch (tipoContrato)
                {
                    case 1:
                        //Solicitando CPF do Funcionário
                        do{
                            Console.Write("Digite o CPF do Funcionário: ");
                            idFuncionario = Console.ReadLine();

                            if (ValidarCPF(idFuncionario) is false)
                            {
                                Console.WriteLine("[ERRO!] CPF INVÁLIDO E/OU JÁ CADASTRADO!");
                                Console.WriteLine("");
                            }
                        } while (ValidarCPF(idFuncionario) is false);

                        break;
                    case 2:
                        //Solicitando CNPJ do Funcionário
                        do{
                            Console.Write("Digite o CNPJ do Funcionário: ");
                            idFuncionario = Console.ReadLine();

                            if (ValidarCNPJ(idFuncionario) is false)
                            {
                                Console.WriteLine("[ERRO!] CNPJ INVÁLIDO E/OU JÁ CADASTRADO!");
                                Console.WriteLine("");
                            }
                        } while (ValidarCNPJ(idFuncionario) is false);

                        break;
                }
                

                //Solicitando Nome do Funcionário
                Console.Write("Digite o Nome do Funcionário: ");
                nome = Console.ReadLine();

                //Solicitando o Endereço do Funcionário:
                Console.Write("Informe a Rua em que o Funcionário mora: ");
                rua = Console.ReadLine();

                do {
                    Console.Write("Informe o Nº da Residência: ");
                    numeroResidencia = Int32.Parse(Console.ReadLine());

                    if (numeroResidencia < 1)
                    {
                        Console.WriteLine("[ERRO!] O NÚMERO DA RESIDÊNCIA NÃO PODE SER MENOR QUE 1!");
                        Console.WriteLine("");
                    }
                } while (numeroResidencia < 1);

                Console.Write("Digite o Bairro do Funcionário: ");
                bairro = Console.ReadLine();

                Console.Write("Digite a Cidade do Funcionário: ");
                cidade = Console.ReadLine();

                do {
                    Console.WriteLine("[1] AC, [2] AL, [3] AP, [4] AM, [5] BA [6] CE, [7] DF, [8] ES, [9] GO, [10] MA,");
                    Console.WriteLine("[11] MT, [12] MS, [13] MG, [14] PA, [15] PB, [16] PR, [17] PE, [18] PI, [19] RJ, [20] RN,");
                    Console.WriteLine("[21] RS, [22] RO, [23] RR, [24] SC, [25] SP, [26] SE, [27] TO");
                    Console.Write("Digite o Nº correspondente à UF do Funcionário: ");
                    estado = Int32.Parse(Console.ReadLine());

                    if (estado < 1 || estado > 27)
                    {
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                        Console.WriteLine("");
                    }
                } while (estado < 1 || estado > 27);

                Endereco endereco = new Endereco(rua, numeroResidencia, bairro, cidade, listaUF[estado-1]);

                //Dando Algumas Informações a Respeito do Salário e a influência dos Cargos sobre o Mesmo
                Console.WriteLine("");
                Console.WriteLine($"[AVISO!] O Salário base dos Funcionários é R${salario} mas pode ser alterado de acordo com o CARGO do Funcionário!");
                Console.WriteLine("");

                //Solicitando Cargo
                do {
                    Console.WriteLine("[1] Funcionário Comum, [2] Programador, [3] Suporte");
                    Console.Write("Digite o Número correspondente ao Cargo do Funcionário: ");
                    opcaoCargo = Int32.Parse(Console.ReadLine());

                    if (opcaoCargo < 1 || opcaoCargo > 3)
                    {
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                        Console.WriteLine("");
                    }
                } while (opcaoCargo < 1 || opcaoCargo > 3);

                switch (opcaoCargo)
                {
                    case 1:
                        //Funcionário Comum
                        FuncionarioComum funcionario = new FuncionarioComum(nome, salario, listaTipoContrato[tipoContrato-1]);

                        funcionario.NomearCargo();
                        funcionario.CalcularSalario();
                        funcionario.AtribuirEndereco(endereco);
                        funcionario.AtribuirTipoContrato(listaTipoContrato[tipoContrato-1], idFuncionario);

                        AumentarArrayFuncionarios(funcionario);

                        break;
                    case 2:
                        //Funcionário Programador
                        Programador funcionarioProgramador = new Programador(nome, salario, listaTipoContrato[tipoContrato-1]);

                        funcionarioProgramador.NomearCargo();
                        funcionarioProgramador.CalcularSalario();
                        funcionarioProgramador.AtribuirEndereco(endereco);
                        funcionarioProgramador.AtribuirTipoContrato(listaTipoContrato[tipoContrato-1], idFuncionario);

                        AumentarArrayFuncionarios(funcionarioProgramador);

                        break;
                    case 3:
                        //Funcionário Suporte
                        Suporte funcionarioSuporte = new Suporte(nome, salario, listaTipoContrato[tipoContrato-1]);

                        funcionarioSuporte.NomearCargo();
                        funcionarioSuporte.CalcularSalario();
                        funcionarioSuporte.AtribuirEndereco(endereco);
                        funcionarioSuporte.AtribuirTipoContrato(listaTipoContrato[tipoContrato-1], idFuncionario);

                        AumentarArrayFuncionarios(funcionarioSuporte);

                        break;
                }

                Console.WriteLine("Deseja Continuar? [S/N]");
                string resposta = Console.ReadLine();
                Console.WriteLine("");

                if (resposta.ToUpper() is "N")
                {
                    Console.WriteLine("[AVISO!] Ok, será gerado o Relatório dos Funcionários... ");
                    Console.WriteLine("");
                    continuarLoop = false;
                }
            } while (continuarLoop is true);

            RelatorioFuncionarios relatorio = new RelatorioFuncionarios();

            relatorio.RelatorioDeFuncionarios(funcionarios);
            relatorio.RelatorioTotalSalario(funcionarios);
        }

        static bool ValidarCNPJ(string idFuncionario)
        {
            if (idFuncionario.Length != 14)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < idFuncionario.Length; i++)
                {
                    if (idFuncionario[i] < 48 || idFuncionario[i] > 57)
                    {
                        return false;
                    }
                }

                for (int i = 0; i < funcionarios.Length; i++)
                {
                    if (funcionarios[i].CPF == idFuncionario)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        static bool ValidarCPF(string idFuncionario)
        {
            if (idFuncionario.Length != 11)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < idFuncionario.Length; i++)
                {
                    if (idFuncionario[i] < 48 || idFuncionario[i] > 57)
                    {
                        return false;
                    }
                }

                for (int i = 0; i < funcionarios.Length; i++)
                {
                    if (funcionarios[i].CPF == idFuncionario)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        static void AumentarArrayFuncionarios(Funcionario funcionario)
        {
            Funcionario[] funcionariosTemp = new Funcionario[funcionarios.Length + 1];

            for (int i = 0; i < funcionarios.Length; i++)
            {
                funcionariosTemp[i] = funcionarios[i];
            }

            funcionariosTemp[funcionarios.Length] = funcionario;

            funcionarios = funcionariosTemp;
        }
    }
}
