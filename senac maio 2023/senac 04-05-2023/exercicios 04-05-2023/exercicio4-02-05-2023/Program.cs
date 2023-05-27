using System;

namespace exercicio4_02_05_2023
{
    class Program
    {
        //static Correnstista[] correntistas = new Correntista[0];

        static int i = 0;
        static Correntista[] correntistas = new Correntista[0];
        static void Main(string[] args)
        {
            //CRIAR CLASSE CORRENTISTA

            int verificador = 0, opcao;

            while (verificador == 0)
            {
                if (i < 1)
                {
                    Console.WriteLine("[1] Inserir Novo Cadastro, [2] Sair");
                    Console.Write("Selecione uma das Opções acima: ");
                    opcao = Int32.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            //INSERIR NOVO CADASTRO
                            i++;
                            AdicionarCorrentista();

                            break;
                        case 2:
                            //SAIR
                            Console.WriteLine("");
                            Console.WriteLine("SAINDO DO PROGRAMA!");
                            Console.WriteLine("");
                            verificador++;
                            break;
                        default:
                            Console.WriteLine("[ERRO!] Opção Inválida!");
                            Console.WriteLine("");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("[1] Inserir Novo Cadastro, [2] Consultar Correntista, [3] Excluir Correntista, [4] Editar Correntista, [5] Sair");
                    Console.Write("Selecione uma das Opções acima: ");
                    opcao = Int32.Parse(Console.ReadLine());
                
                    switch (opcao)
                    {
                        case 1:
                            //INSERIR NOVO CADASTRO
                            i++;
					        AdicionarCorrentista();

                            break;
                        case 2:
                            //CONSULTAR CORRENTISTA
                            ConsultarCorrentista();
							
                            break;
                        case 3:
                            //EXCLUIR CORRENTISTA
                            ExcluirCorrentista();
                        
                            break;
                        case 4:
                            //EDITAR CORRENTISTA
                            EditarCorrentista();

                            break;
                        case 5: 
                            //SAIR
                            Console.WriteLine("");
                            Console.WriteLine("SAINDO DO PROGRAMA!");
                            Console.WriteLine("");
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

        static void AdicionarCorrentista()
        {
            //SOLICITAND INFORMAÇÕES

            Console.WriteLine("");
            Console.WriteLine("INSERINDO NOVO CADASTRO!");
            Console.WriteLine("");

            Console.Write("Digite o CPF do Correntista (USE APENAS NÚMEROS): ");
            long cpf = Int64.Parse(Console.ReadLine());
            ValidarCPF(ref cpf);

            Console.Write("Digite o Nome do Correntista: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Sobrenome do Correntista: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Digite a Renda Confirmada do Correntista: R$");
            double renda = Double.Parse(Console.ReadLine());
            ValidarRenda(ref renda);

            Console.Write("Digite o Ano de Nascimento do Correntista: ");
            int anoNascimento = Int32.Parse(Console.ReadLine());
            ValidarAnoNascimento(ref anoNascimento);

            Console.Write("Digite o Mês de Nascimento do Correntista: ");
            int mesNascimento = Int32.Parse(Console.ReadLine());
            ValidarMesNascimento(ref mesNascimento);

            Console.Write("Digite o Dia de Nascimento do Correntista: ");
            int diaNascimento = Int32.Parse(Console.ReadLine());
            ValidarDiaNascimento(ref diaNascimento, mesNascimento, anoNascimento);

            DateTime dataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);

            int idade = CalcularIdade(dataNascimento);
		
	        Correntista novoCorrentista = new Correntista(cpf, nome, sobrenome, renda, idade, dataNascimento);

            //ADICIONANDO INFORMAÇÕES AO ARRAY CORRENTISTAS

            //AUMENTANDO ARRAY

            if (correntistas.Length != i)
            {
                Correntista[] correntistasTemp = new Correntista[correntistas.Length + 1];

                for (int j = 0; j < i; j++)
                {
                    if (j+1 != i)
                    {
                        correntistasTemp[j] = correntistas[j];

                    }
                    else
                    {
                        correntistasTemp[j] = novoCorrentista;
                    }
                }

                correntistas = correntistasTemp;
            }
            else
            {
                Correntista[] correntistasTemp = new Correntista[correntistas.Length];

                for (int j = 0; j < correntistas.Length; j++)
                {
                    if (j+1 != i)
                    {
                        correntistasTemp[j] = correntistas[j];

                    }
                    else
                    {
                        correntistasTemp[j] = novoCorrentista;
                    }
                }

                correntistas = correntistasTemp;
            }

            Console.WriteLine("");
            Console.WriteLine("CADASTRO REALIZADO COM SUCESSO!");

            Console.WriteLine("");
        }

        static void ValidarCPF(ref long cpf)
        {
            int verificador = 0;

            while (verificador == 0)
            {
                int verificador2 = 0;
                if (cpf < 0)
                {
                    Console.WriteLine("[ERRO!] UM CPF NÃO PODE SER NEGATIVO");
                    Console.WriteLine("");

                }
                else if($"{cpf}".Length != 11)
                {
                    Console.WriteLine("[ERRO!] O CPF   DEVE POSSUIR 11 CARACTERES NUMÉRICOS!");
                    Console.WriteLine("");
                }
                else if (i > 1)
                {
                    for (int j = 0; j < i - 1; j++)
                    {   
                        if (ComparandoCPF(cpf, j) != 0)
                        {
                            verificador2++;
                            Console.WriteLine(verificador2);
                        }
                    }

                    if (verificador2 > 0)
                    {
                        verificador = 0;
                        Console.WriteLine("[ERRO!] CPF JÁ CADASTRADO!");
                    }
                    else
                    {
                        verificador++;
                    }
                }
                else
                {
                    verificador++;
                }
                    
                if (verificador == 0)
                {
                    Console.Write("Digite o CPF do Correntista (USE APENAS NÚMEROS): ");
                    cpf = Int64.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }
            }
        }

        static int ComparandoCPF(long cpf, int j)
        {
            int rComparacao = 0;

            if (cpf == correntistas[j].CPF)
            {
                rComparacao++;
            }

            return rComparacao;
        }

        static void ValidarRenda(ref double renda)
        {
            while (renda < 0)
            {
                Console.WriteLine("");
                Console.WriteLine("[ERRO!] O CORRENTISTA NÃO PODE TER UMA RENDA INFERIOR A 0!");
                Console.WriteLine("");
                Console.Write("Digite a Renda Confirmada do Correntista: R$");
                renda = Double.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
        }

        static void ValidarAnoNascimento(ref int anoNascimento)
        {
            while (anoNascimento > DateTime.Now.Year || DateTime.Now.Year - anoNascimento > 120)
            {
                Console.WriteLine("");
                Console.WriteLine("[ERRO!] POR FAVOR DIGITE UM ANO VÁLIDO");
                Console.WriteLine("");
                Console.Write("Digite o Ano de Nascimento do Correntista: ");
                anoNascimento = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
        }

        static void ValidarMesNascimento(ref int mesNascimento)
        {
            while (mesNascimento < 1 || mesNascimento > 12)
            {
                Console.WriteLine("");
                Console.WriteLine("[ERRO!] POR FAVOR DIGITE UM MÊS VÁLIDO");
                Console.WriteLine("");
                Console.Write("Digite o Mês de Nascimento do Correntista: ");
                mesNascimento = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
    }

    static void ValidarDiaNascimento(ref int diaNascimento, int mesNascimento, int anoNascimento)
    {
            int verificador = 0;

            while (verificador == 0)
            {
                int verificador2 = 0;

                if (mesNascimento == 1 || mesNascimento == 3 || mesNascimento == 5 || mesNascimento == 7 || mesNascimento == 8 || mesNascimento == 10 || mesNascimento == 12)
                {
                    if (diaNascimento < 1 || diaNascimento > 31)
                    {
                        verificador2++;
                    }
                }
                else if (mesNascimento == 4 || mesNascimento == 6 || mesNascimento == 9 || mesNascimento == 11)
                {
                    if (diaNascimento < 1 || diaNascimento > 30)
                    {
                        verificador2++;
                    }
                }
                else if (anoNascimento % 4 == 0)
                {
                    if (diaNascimento < 1 || diaNascimento > 29)
                    {
                        verificador2++;
                    }
                }
                else
                {
                    if (diaNascimento < 1 || diaNascimento > 28)
                    {
                        verificador2++;
                    }
                }

                if (verificador2 != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("[ERRO!] POR FAVOR DIGITE UM DIA VÁLIDO");
                    Console.WriteLine("");
                    Console.Write("Digite o Dia de Nascimento do Correntista: ");
                    diaNascimento = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("");
                }
                else
                {
                    verificador++;
                }
            }
    }

    static int CalcularIdade(DateTime dataNascimento)
    {
            int idadeCorrentista = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.Month < dataNascimento.Month)
            {
                idadeCorrentista--;
            }
            else if (DateTime.Now.Month == dataNascimento.Month && DateTime.Now.Day < dataNascimento.Day)
            {
                idadeCorrentista--;
            }

            return idadeCorrentista;
    }

    static void ConsultarCorrentista()
    {
            Console.Write("Digite o CPF do Correntista que você deseja consultar: ");
            long consultarCpf = Int64.Parse(Console.ReadLine());

            int consulta = 0, verificador = 0;

            for (int j = 0; j < i; j++)
            {
                if (correntistas[j].CPF == consultarCpf)
                {
                    consulta = j;
                    verificador++;
                }
            }

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] CPF NÃO ENCONTRADO!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Correntista Nº{consulta+1} => CPF: {correntistas[consulta].CPF} - Nome: {correntistas[consulta].Nome} - Sobrenome: {correntistas[consulta].Sobrenome} - Renda Comprovada: R${correntistas[consulta].Renda} - Idade: {correntistas[consulta].Idade} - Data de Nascimento: {correntistas[consulta].DataNascimento.ToString("dd/MM/yyyy")}");
                Console.WriteLine("");
            }
    }

    static void ExcluirCorrentista()
    {
            Console.Write("Digite o CPF do Correntista que você deseja excluir: ");
            long excluirCpf = Int64.Parse(Console.ReadLine());

            int excluir = 0, verificador = 0;

            for (int j = 0; j < correntistas.Length; j++)
            {
                if (correntistas[j].CPF == excluirCpf)
                {
                    excluir = j;
                    verificador++;
                }
            }

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] CPF NÃO ENCONTRADO!");
                Console.WriteLine("");
            }
            else
            {
                Correntista[] correntistasTemp = new Correntista[correntistas.Length];

                int k = 0;
                for (int j = 0; j < correntistas.Length; j++)
                {

                    if (j >= excluir && j+1 != correntistas.Length)
                    {
                        correntistasTemp[j] = correntistas[k+1];
                    }
                    else if (j+1 == correntistas.Length)
                    {
                        correntistasTemp[j] = new Correntista(0,"","",0,0,DateTime.Now);
                    }
                    else
                    {
                        correntistasTemp[j] = correntistas[k];
                    }
                }

                correntistas = correntistasTemp;

                Console.WriteLine("CADASTRO EXCLUÍDO COM SUCESSO!");
                Console.WriteLine("");

                i--;
            }
    }

    static void EditarCorrentista()
    {
            Console.Write("Digite o CPF do Correntista que você deseja alterar as informações: ");
            long editarCpf = Int64.Parse(Console.ReadLine());

            int editar = 0, verificador = 0;

            for (int j = 0; j < correntistas.Length; j++)
            {
                if (correntistas[j].CPF == editarCpf)
                {
                    editar = j;
                    verificador++;
                }
            }

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] CPF NÃO ENCONTRADO!");
                Console.WriteLine("");
            }
            else
            {
                Console.Write("Digite o CPF do Correntista (USE APENAS NÚMEROS): ");
                long cpf = Int64.Parse(Console.ReadLine());
                ValidarCPF(ref cpf);

                Console.Write("Digite o Nome do Correntista: ");
                string nome = Console.ReadLine();

                Console.Write("Digite o Sobrenome do Correntista: ");
                string sobrenome = Console.ReadLine();

                Console.Write("Digite a Renda Confirmada do Correntista: R$");
                double renda = Double.Parse(Console.ReadLine());
                ValidarRenda(ref renda);

                Console.Write("Digite o Ano de Nascimento do Correntista: ");
                int anoNascimento = Int32.Parse(Console.ReadLine());
                ValidarAnoNascimento(ref anoNascimento);

                Console.Write("Digite o Mês de Nascimento do Correntista: ");
                int mesNascimento = Int32.Parse(Console.ReadLine());
                ValidarMesNascimento(ref mesNascimento);

                Console.Write("Digite o Dia de Nascimento do Correntista: ");
                int diaNascimento = Int32.Parse(Console.ReadLine());
                ValidarDiaNascimento(ref diaNascimento, mesNascimento, anoNascimento);

                DateTime dataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);

                int idade = CalcularIdade(dataNascimento);
                
                Correntista novoCorrentista = new Correntista(cpf, nome, sobrenome, renda, idade, dataNascimento);

                correntistas[editar] = novoCorrentista;
            }
        }
    }
}
