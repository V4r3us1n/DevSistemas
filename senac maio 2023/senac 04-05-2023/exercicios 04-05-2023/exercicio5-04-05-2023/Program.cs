using System;

namespace exercicio5_04_05_2023
{
    class Program
    {
        //static Correnstista[] correntistas = new Correntista[0];

        static int i = 0;
        static int i2 = 0;
        static Correntista[] correntistas = new Correntista[0];
        static Conta[] contasCorrentistas = new Conta[0];
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
                            i2++;
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
                    Console.WriteLine("[1] Inserir Novo Cadastro, [2] Consultar Correntista, [3] Excluir Correntista, [4] Editar Correntista, [5] Consultar Conta, [6] Acessar Conta, [7] Sair");
                    Console.Write("Selecione uma das Opções acima: ");
                    opcao = Int32.Parse(Console.ReadLine());
                
                    switch (opcao)
                    {
                        case 1:
                            //INSERIR NOVO CADASTRO
                            i++;
                            i2++;
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
                            //CONSULTAR CONTA
                            ConsultarConta();

                            break;
                        case 6:
                            //ACESSAR CONTA
                            AcessarConta();

                            break;
                        case 7: 
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


            //VERIFICANDO SE O CPF POSSUI UMA CONTA SUSPENSA PARA REABRIR

            int verificarConta = 0, reabrirConta = -1;

            for (int j = 0; j < contasCorrentistas.Length; j++)
            {
                if (contasCorrentistas[j].CorrentistaConta.CPF == novoCorrentista.CPF)
                {
                    verificarConta++;
                    reabrirConta = j;
                }
            }

            if (verificarConta != 0 && reabrirConta >= 0)
            {
                Console.WriteLine("[AVISO!] ESSE CPF POSSUÍ UMA CONTA QUE FOI SUSPENSA, DEVIDO AO RECADASTRO ELA SERÁ REABERTA!");
                contasCorrentistas[reabrirConta].CorrentistaConta = novoCorrentista;
            }
            else
            {
                //Criando Conta para o Correntista
                CriarConta();
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

        static void CriarConta()
        {
            Console.WriteLine("Criando Conta...");

            int nConta = i2;
            Correntista correntistaConta = correntistas[i-1];
            Console.Write("Digite o valor que deseja depositar em sua conta para criá-la (mínimo R$50): R$");
            double saldoConta = Int32.Parse(Console.ReadLine());
            ValidarSaldo(ref saldoConta);

            Conta novaConta = new Conta(nConta, correntistaConta, saldoConta);

            //AUMENTANDO ARRAY

            if (contasCorrentistas.Length != i)
            {
                Conta[] contasTemp = new Conta[contasCorrentistas.Length + 1];

                for (int j = 0; j < i; j++)
                {
                    if (j+1 != i)
                    {
                        contasTemp[j] = contasCorrentistas[j];

                    }
                    else
                    {
                        contasTemp[j] = novaConta;
                    }
                }

                contasCorrentistas = contasTemp;
            }
            else
            {
                Conta[] contasTemp = new Conta[contasCorrentistas.Length];

                for (int j = 0; j < contasCorrentistas.Length; j++)
                {
                    if (j+1 != i)
                    {
                        contasTemp[j] = contasCorrentistas[j];

                    }
                    else
                    {
                        contasTemp[j] = novaConta;
                    }
                }

                contasCorrentistas = contasTemp;
            }
        }

        static void ValidarSaldo(ref double saldoConta)
        {
            while (saldoConta < 50)
            {
                Console.WriteLine("[ERRO!] O SALDO INICIAL DEVE SER NO MÍNIMO R$50!");

                Console.WriteLine("");
                Console.Write("Digite o valor que deseja depositar em sua conta para criá-la (mínimo R$50): R$");
                saldoConta = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
            }
        }

        static void ConsultarCorrentista()
        {
            Console.Write("Digite o CPF do Correntista que você deseja consultar: ");
            long consultarCpf = Int64.Parse(Console.ReadLine());

            int consulta = 0, verificador = 0, consulta2 = 0;

            for (int j = 0; j < i; j++)
            {
                if (correntistas[j].CPF == consultarCpf)
                {
                    consulta = j;
                    verificador++;
                }
            }

            for (int j = 0; j < contasCorrentistas.Length; j++)
            {
                if (contasCorrentistas[j].CorrentistaConta.CPF == consultarCpf)
                {
                    consulta2 = j;
                }
            }

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] CPF NÃO ENCONTRADO!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine($"Número da Conta: {contasCorrentistas[consulta2].NumeroConta} - CPF: {correntistas[consulta].CPF} - Nome: {correntistas[consulta].Nome} - Sobrenome: {correntistas[consulta].Sobrenome} - Renda Comprovada: R${correntistas[consulta].Renda} - Idade: {correntistas[consulta].Idade} - Data de Nascimento: {correntistas[consulta].DataNascimento.ToString("dd/MM/yyyy")}");
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

            int editar = 0, verificador = 0, editar2 = 0;

            for (int j = 0; j < correntistas.Length; j++)
            {
                if (correntistas[j].CPF == editarCpf)
                {
                    editar = j;
                    verificador++;
                }
            }

            for (int j = 0; j < contasCorrentistas.Length; j++)
            {
                if (contasCorrentistas[j].CorrentistaConta.CPF == editarCpf)
                {
                    editar2 = j;
                }
            }

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] CPF NÃO ENCONTRADO!");
                Console.WriteLine("");
            }
            else
            {
                int verificadorCPF = 0, verificador1 = 0, verificador2 = 0;
                long cpf = 0;

                while (verificadorCPF == 0)
                {
                    Console.Write("Digite o CPF do Correntista (USE APENAS NÚMEROS): ");
                    cpf = Int64.Parse(Console.ReadLine());
                    ValidarCPF(ref cpf);

                    for (int j = 0; j < contasCorrentistas.Length; j++)
                    {
                        if (contasCorrentistas[j].CorrentistaConta.CPF == cpf)
                        {
                            verificador1++;
                        }
                    }

                    for (int j = 0; j < correntistas.Length; j++)
                    {
                        if (correntistas[j].CPF == cpf)
                        {
                            verificador2++;
                        }
                    }

                    if (verificador1 > 0 && verificador2 == 0)
                    {
                        Console.WriteLine("[AVISO!] VOCÊ NÃO PODE COLOCAR O CPF DE UMA CONTA QUE JÁ EXISTE E/OU FOI SUSPENSA!");
                    }
                    else
                    {
                        verificadorCPF++;
                    }
                }


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
                contasCorrentistas[editar2].CorrentistaConta = novoCorrentista;
            }
        }

        static void ConsultarConta()
        {
            Console.Write("Digite o Número da Conta que você deseja consultar: ");
            int consultarConta = Int32.Parse(Console.ReadLine());

            int consulta = 0, verificador = 0, verificador2 = 0;

            Console.WriteLine($"Temos {contasCorrentistas.Length} contas cadastradas!");

            for (int j = 0; j < contasCorrentistas.Length; j++)
            {
                if (contasCorrentistas[j].NumeroConta == consultarConta)
                {
                    consulta = j;
                    verificador++;
                }
            }

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] CONTA NÃO ENCONTRADA!");
                Console.WriteLine("");
            }
            else
            {
                for (int j = 0; j < correntistas.Length; j++)
                {
                    if (contasCorrentistas[consulta].CorrentistaConta.CPF == correntistas[j].CPF)
                    {
                        verificador2++;
                    }
                }

                if (verificador2 == 0)
                {
                    Console.WriteLine("[AVISO!] ESSA CONTA FOI SUSPENSA DEVIDO A SEU CORRENTISTA TER SIDO EXCLUÍDO!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine($"Número da Conta: {contasCorrentistas[consulta].NumeroConta} - Nome: {contasCorrentistas[consulta].CorrentistaConta.Nome} - Sobrenome: {contasCorrentistas[consulta].CorrentistaConta.Sobrenome} - Idade: {contasCorrentistas[consulta].CorrentistaConta.Idade} - Saldo: R${contasCorrentistas[consulta].Saldo}");
                    Console.WriteLine("");
                }
            }
        }

        static void AcessarConta()
        {
            int contaLogin = 0, verificador = 0, verificador3 = 0;

            Console.WriteLine("LOGIN CONTA");
            Console.Write("Digite o Número da Conta: ");
            int nConta = Int32.Parse(Console.ReadLine());

            Console.Write("Digite o CPF do Correntista: ");
            long cpfCorrentista = Int64.Parse(Console.ReadLine());

            for (int j = 0; j < contasCorrentistas.Length; j++)
            {
                if (contasCorrentistas[j].NumeroConta == nConta)
                {
                    contaLogin = j;
                    verificador++;
                }
            }

            for (int j = 0; j < correntistas.Length; j++)
            {
                if (correntistas[j].CPF == cpfCorrentista)
                {
                    verificador3++;
                }
            }

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] CONTA NÃO ENCONTRADA!");
            }
            else if (verificador > 0 && verificador3 == 0)
            {
                Console.WriteLine("[AVISO!] ESSA CONTA FOI SUSPENSA DEVIDO A SEU CORRENTISTA TER SIDO EXCLUÍDO!");
            }
            else
            {
                if (contasCorrentistas[contaLogin].CorrentistaConta.CPF != cpfCorrentista)
                {
                    Console.WriteLine("[ERRO!] CPF NÃO CORRENSPONDE AO DONO DA CONTA!");
                }
                else
                {
                    int verificador2 = 0;

                    while (verificador2 == 0)
                    {
                        MenuConta(ref verificador2, contaLogin);
                    }
                }
            }
        }

        static void MenuConta(ref int verificador2, int contaLogin)
        {
            int opcao = 0;

            Console.WriteLine("");
            Console.WriteLine("---------------MENU CONTA---------------");
            Console.WriteLine("[1] INFORMAÇÕES DA CONTA, [2] SACAR, [3] DEPOSITAR, [4] TRANSFERIR, [5] SAIR");
            Console.Write("Digite a Opção Desejada: ");
            opcao = Int32.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    //INFORMAÇÕES DA CONTA
                    ExibirInfoConta(contaLogin);

                    break;
                case 2:
                    //SACAR
                    Sacar(contaLogin);

                    break;
                case 3:
                    //DEPOSITAR
                    Depositar(contaLogin);

                    break;
                case 4:
                    //TRANSFERIR
                    Transferir(contaLogin);

                    break;
                case 5:
                    //SAIR
                    Console.WriteLine("SAINDO DA CONTA...");
                    Console.WriteLine("");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("");
                    verificador2++;

                    break;
                default:
                    Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");

                    break;
            }
        }

        static void ExibirInfoConta(int contaLogin)
        {
            Console.WriteLine("");
            Console.WriteLine("==========================================");
            Console.WriteLine($"Número da Conta: {contasCorrentistas[contaLogin].NumeroConta}");
            Console.WriteLine($"CPF: {contasCorrentistas[contaLogin].CorrentistaConta.CPF}");
            Console.WriteLine($"Nome: {contasCorrentistas[contaLogin].CorrentistaConta.Nome} {contasCorrentistas[contaLogin].CorrentistaConta.Sobrenome}");
            Console.WriteLine($"Idade: {contasCorrentistas[contaLogin].CorrentistaConta.Idade} anos");
            Console.WriteLine($"Renda Comprovada: R${contasCorrentistas[contaLogin].CorrentistaConta.Renda}");
            Console.WriteLine($"Saldo: R${contasCorrentistas[contaLogin].Saldo}");
            Console.WriteLine("==========================================");
            Console.WriteLine("");
        }

        static void Sacar(int contaLogin)
        {
            if (contasCorrentistas[contaLogin].CorrentistaConta.Idade < 18)
            {
                Console.WriteLine("[AVISO!] VOCÊ SÓ PODE REALIZAR SAQUES E TRANFERÊNCIAS QUANDO FOR MAIOR DE IDADE!");
                Console.WriteLine("");
            }
            else
            {
                Console.Write("Informe o valor que deseja sacar: R$");
                double valorSaque = Int32.Parse(Console.ReadLine());

                if (valorSaque > contasCorrentistas[contaLogin].Saldo)
                {
                    Console.WriteLine("[ERRO!] VOCÊ NÃO POSSUI SALDO SUFICIENTE PARA REALIZAR ESSE SAQUE!");
                    Console.WriteLine("");
                }
                else if (valorSaque <= 0)
                {
                    Console.WriteLine("[ERRO!] VOCÊ NÃO SACAR VALORES QUE SEJAM MENOR OU IGUAL A 0!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("[AVISO!] Para CONFIRMAR a Tranferência Digite seu CPF: ");
                    long contaCPF = Int64.Parse(Console.ReadLine());

                    if (contasCorrentistas[contaLogin].CorrentistaConta.CPF != contaCPF)
                    {
                        Console.WriteLine("[ERRO!] CPF INCORRETO!");
                        Console.WriteLine("[ERRO!] TRANSFERÊNCIA CANCELADA!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        contasCorrentistas[contaLogin].Saldo -= valorSaque;
                        Console.WriteLine("SAQUE REALIZADO COM SUCESSO!");
                        Console.WriteLine("");
                    }
                }
            }
        }

        static void Depositar(int contaLogin)
        {
            Console.Write("Informe o valor que deseja sacar: R$");
            double valorDeposito = Int32.Parse(Console.ReadLine());

            if (valorDeposito <= 0)
            {
                Console.WriteLine("[ERRO!] VOCÊ NÃO DEPOSITAR VALORES QUE SEJAM MENOR OU IGUAL A 0!");
                Console.WriteLine("");
            }
            else
            {
                contasCorrentistas[contaLogin].Saldo += valorDeposito;
                Console.WriteLine("DEPÓSITO REALIZADO COM SUCESSO!");
                Console.WriteLine("");
            }
        }

        static void Transferir(int contaLogin)
        {
            if (contasCorrentistas[contaLogin].CorrentistaConta.Idade < 18)
            {
                Console.WriteLine("[AVISO!] VOCÊ SÓ PODE REALIZAR SAQUES E TRANFERÊNCIAS QUANDO FOR MAIOR DE IDADE!");
                Console.WriteLine("");
            }
            else
            {
                Console.Write("Informe o Número da Conta para a qual você deseja realizar a Tranferência: ");
                int nContaTransferencia = Int32.Parse(Console.ReadLine());

                if (contasCorrentistas[contaLogin].NumeroConta == nContaTransferencia)
                {
                    Console.WriteLine("[ERRO!] VOCÊ NÃO PODE TRANSFERIR PARA SI MESMO!");
                    Console.WriteLine("");
                }
                else
                {
                    int nConta2 = 0, verificador = 0, verificador2 = 0;

                    for (int j = 0; j < contasCorrentistas.Length; j++)
                    {
                        if (contasCorrentistas[j].NumeroConta == nContaTransferencia)
                        {
                            nConta2 = j;
                            verificador++;
                        }
                    }
                    for (int j = 0; j < correntistas.Length; j++)
                    {
                        if (correntistas[j].CPF == contasCorrentistas[nConta2].CorrentistaConta.CPF)
                        {
                            verificador2++;
                        }
                    }

                    if (verificador == 0)
                    {
                        Console.WriteLine("[ERRO!] CONTA NÃO ENCONTRADA!");
                        Console.WriteLine("");
                    }
                    else if (verificador2 == 0)
                    {
                        Console.WriteLine("[AVISO!] VOCÊ NÃO PODE TRANSFERIR DINHEIRO PARA UMA CONTA SUSPENSA!");
                    }
                    else
                    {
                        Console.Write("Informe o Valor que Deseja Transferir: R$");
                        double valorTranferencia = Double.Parse(Console.ReadLine());

                        Console.Write("[AVISO!] Para CONFIRMAR a Tranferência Digite seu CPF: ");
                        long contaCPF = Int64.Parse(Console.ReadLine());

                        if (contasCorrentistas[contaLogin].CorrentistaConta.CPF != contaCPF)
                        {
                            Console.WriteLine("[ERRO!] CPF INCORRETO!");
                            Console.WriteLine("[ERRO!] TRANSFERÊNCIA CANCELADA!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            contasCorrentistas[contaLogin].Saldo -= valorTranferencia;
                            contasCorrentistas[nConta2].Saldo += valorTranferencia;

                            Console.WriteLine("[AVISO!] TRANSFERÊNCIA REALIZADA COM SUCESSO!");
                            Console.WriteLine("");
                        }
                    }
                }
            }
        }
    }
}
