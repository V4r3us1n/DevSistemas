using System;
using Exercicio01.Classes;

namespace Exercicio01.ConsoleApp
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
                    //Exceção Valores Nulos
                    try
                    {
                        tipoContrato = Int32.Parse(Console.ReadLine());

                        if (tipoContrato < 1 || tipoContrato > 2)
                        {
                            throw new OpcaoInvalidaException("[ERRO!] Opção Inválida Exception!");
                        }
                    }
                    catch (OpcaoInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("[ERRO!] Não é possível inserir um valor NULL nesse campo!");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("[ERRO!] Não é possível inserir um valor DIFERENTE de NUMBER nesse campo!");
                    }
                } while (tipoContrato < 1 || tipoContrato > 2);

                switch (tipoContrato)
                {
                    case 1:
                        //Solicitando CPF do Funcionário
                        do{
                            Console.Write("Digite o CPF do Funcionário: ");
                            idFuncionario = Console.ReadLine();

                            if (ValidarCPF(idFuncionario) == false)
                            {
                                Console.WriteLine("[ERRO!] CPF INVÁLIDO E/OU JÁ CADASTRADO!");
                                Console.WriteLine("");
                            }
                        } while (ValidarCPF(idFuncionario) == false);

                        break;
                    case 2:
                        //Solicitando CNPJ do Funcionário
                        do{
                            Console.Write("Digite o CNPJ do Funcionário: ");
                            idFuncionario = Console.ReadLine();

                            if (ValidarCNPJ(idFuncionario) == false)
                            {
                                Console.WriteLine("[ERRO!] CNPJ INVÁLIDO E/OU JÁ CADASTRADO!");
                                Console.WriteLine("");
                            }
                        } while (ValidarCNPJ(idFuncionario) == false);

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

                    try
                    {
                        numeroResidencia = Int32.Parse(Console.ReadLine());

                        if (numeroResidencia < 1)
                        {
                            throw new ArgumentException();
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("[ERRO!] O Número Inserido não pode ser Negativo!");
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("[ERRO!] Não é possível inserir um valor NULL nesse campo!");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("[ERRO!] Não é possível inserir um valor DIFERENTE de NUMBER nesse campo!");
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
                    
                    try
                    {
                        estado = Int32.Parse(Console.ReadLine());

                        if (estado < 1 || estado > 27)
                        {
                            throw new OpcaoInvalidaException("[ERRO!] Opção Inválida Exception!");
                        }
                    }
                    catch (OpcaoInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("[ERRO!] Não é possível inserir um valor NULL nesse campo!");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("[ERRO!] Não é possível inserir um valor DIFERENTE de NUMBER nesse campo!");
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

                    try
                    {
                        opcaoCargo = Int32.Parse(Console.ReadLine());

                        if (opcaoCargo < 1 || opcaoCargo > 3)
                        {
                            throw new OpcaoInvalidaException("[ERRO!] Opção Inválida Exception!");
                        }
                    }
                    catch (OpcaoInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("[ERRO!] Não é possível inserir um valor NULL nesse campo!");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("[ERRO!] Não é possível inserir um valor DIFERENTE de NUMBER nesse campo!");
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

                if (resposta.ToUpper() == "N")
                {
                    Console.WriteLine("[AVISO!] Ok, será gerado o Relatório dos Funcionários... ");
                    Console.WriteLine("");
                    continuarLoop = false;
                }
            } while (continuarLoop == true);

            RelatorioFuncionarios relatorio = new RelatorioFuncionarios();

            relatorio.RelatorioDeFuncionarios(funcionarios);
            relatorio.RelatorioTotalSalario(funcionarios);
        }

        static bool ValidarCNPJ(string idFuncionario)
        {
            bool cnpjValido = true;

            try {
                //Exceção CNPJ Inválido
                if (idFuncionario.Length != 14)
                {
                    cnpjValido = false;
                    throw new ArgumentException("[ERRO!] O CNPJ inserido não possui tamanho válido!");
                }
                else
                {
                    for (int i = 0; i < idFuncionario.Length; i++)
                    {
                        //Exceção do Tipo CNPJ INVÁLIDO
                        if (idFuncionario[i] < 48 || idFuncionario[i] > 57)
                        {
                            cnpjValido = false;
                            throw new TipoCnpjInvalido("[ERRO!] CNPJ deve possuir APENAS Números!");
                        }
                    }

                    for (int i = 0; i < funcionarios.Length; i++)
                    {
                        //Exceção do Tipo CNPJ JÁ CADASTRADO
                        if (funcionarios[i].CPF == idFuncionario)
                        {
                            cnpjValido = false;
                            throw new CnpjCadastradoException("[ERRO!] CNPJ já cadastrado!");
                        }
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TipoCnpjInvalido ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CnpjCadastradoException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return cnpjValido;
        }

        static bool ValidarCPF(string idFuncionario)
        {
            bool cpfValido = true;

            try {
                //Exceção CPF Inválido
                if (idFuncionario.Length != 11)
                {
                    cpfValido = false;
                    throw new ArgumentException("[ERRO!] O CPF inserido não possui tamanho válido!");
                }
                else
                {
                    for (int i = 0; i < idFuncionario.Length; i++)
                    {
                        //Exceção do Tipo CPF INVÁLIDO
                        if (idFuncionario[i] < 48 || idFuncionario[i] > 57)
                        {
                            cpfValido = false;
                            throw new TipoCpfInvalido("[ERRO!] CPF deve possuir APENAS Números!");
                        }
                    }

                    for (int i = 0; i < funcionarios.Length; i++)
                    {
                        //Exceção do Tipo CNPJ JÁ CADASTRADO
                        if (funcionarios[i].CPF == idFuncionario)
                        {
                            cpfValido = false;
                            throw new CpfCadastradoException("[ERRO!] CPF já cadastrado!");
                        }
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TipoCpfInvalido ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CpfCadastradoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cpfValido;
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
