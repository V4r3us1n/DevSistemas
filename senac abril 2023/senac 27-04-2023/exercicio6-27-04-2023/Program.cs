using System;

namespace exercicio6_27_04_2023
{
    class Program
    {
        static string[,] cadastroCorrentista = new string[1, 5];
        static int i = 0;
        static int nCadastros = 0;

        static string resposta = "";
        static void Main(string[] args)
        {
            //Criando Cadastro
            int opcaoCadastro, verificador = 1;

            do {
                Console.WriteLine("Bem-vindo à sessão de CADASTROS, o que você deseja fazer?");
                Console.WriteLine("[1] Inserir Novo Cadastro, [2] Editar Cadastro, [3] Consultar Cadastro, [4] Excluir Cadastro, [5] Exibir Todos os Correntistas Cadastrados, [6] Sair");
                Console.WriteLine("");
                Console.Write("Insira a Opção Desejada:");
                opcaoCadastro = Int32.Parse(Console.ReadLine());

                while (opcaoCadastro < 0 || opcaoCadastro > 6)
                {
                    Console.WriteLine("[ERRO!] Por favor Insira uma opção Válida!");
                }

                resposta = "";

                switch (opcaoCadastro)
                {
                    case 1:
                        Console.Write("Tem certeza que deseja Inserir um Novo Cadastro? [S/N]");
                        resposta = Console.ReadLine();

                        while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
                        {
                            Console.WriteLine("[ERRO!] Por favor insira uma Resposta Válida!");

                            Console.Write("Tem certeza que deseja Inserir um Novo Cadastro? [S/N]");
                            resposta = Console.ReadLine();
                        }

                        if (resposta.ToUpper() == "S")
                        {
                            InserirNovoCadastro(ref cadastroCorrentista);
                        }

                        break;
                    case 2:
                        Console.Write("Tem certeza que deseja Editar um Cadastro? [S/N]");
                        resposta = Console.ReadLine();

                        while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
                        {
                            Console.WriteLine("[ERRO!] Por favor insira uma Resposta Válida!");

                            Console.Write("Tem certeza que deseja Editar um Cadastro? [S/N]");
                            resposta = Console.ReadLine();
                        }

                        if (resposta.ToUpper() == "S")
                        {
                            EditarCadastro(ref cadastroCorrentista);
                        }

                        break;
                    case 3:
                        Console.Write("Tem certeza que deseja Consultar um Cadastro? [S/N]");
                        resposta = Console.ReadLine();

                        while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
                        {
                            Console.WriteLine("[ERRO!] Por favor insira uma Resposta Válida!");

                            Console.Write("Tem certeza que deseja Consultar um Cadastro? [S/N]");
                            resposta = Console.ReadLine();
                        }

                        if (resposta.ToUpper() == "S")
                        {
                            ConsultarCadastro(ref cadastroCorrentista);
                        }
                        

                        break;
                    case 4:
                        Console.Write("Tem certeza que deseja Excluir um Cadastro? [S/N]");
                        resposta = Console.ReadLine();

                        while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
                        {
                            Console.WriteLine("[ERRO!] Por favor insira uma Resposta Válida!");

                            Console.Write("Tem certeza que deseja Excluir um Cadastro? [S/N]");
                            resposta = Console.ReadLine();
                        }

                        if (resposta.ToUpper() == "S")
                        {
                            ExcluirCadastro(ref cadastroCorrentista);
                        }

                        break;
                    case 5:
                        Console.Write("Tem certeza que deseja Exibir Todos os Correntistas Cadastrados? [S/N]");
                        resposta = Console.ReadLine();

                        while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
                        {
                            Console.WriteLine("[ERRO!] Por favor insira uma Resposta Válida!");

                            Console.Write("Tem certeza que deseja Exibir Todos os Correntistas Cadastrados? [S/N]");
                            resposta = Console.ReadLine();
                        }

                        if (resposta.ToUpper() == "S")
                        {
                            ExibirCadastros(ref cadastroCorrentista);
                        }

                        break;
                    case 6:
                        Console.WriteLine("Tem certeza que deseja Sair? [S/N]");
                        resposta = Console.ReadLine();

                        while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
                        {
                            Console.WriteLine("[ERRO!] Por favor insira uma Resposta Válida!");

                            Console.WriteLine("Tem certeza que deseja sair? [S/N]");
                            resposta = Console.ReadLine();
                        }

                        if (resposta.ToUpper() == "S")
                        {
                            verificador = 0;
                        }

                        break;
                }
            } while (verificador == 1);
        }

        static void AumentarTamanhoCadastro(ref string[,] array)
        {
            string[,] arrayTemp = new string[i + 2, 5];

            for (int j = 0; j <= i; j++)
            {
                arrayTemp[j, 0] = array[j, 0];
                arrayTemp[j, 1] = array[j, 1];
                arrayTemp[j, 2] = array[j, 2];
                arrayTemp[j, 3] = array[j, 3];
                arrayTemp[j, 4] = array[j, 4];
            }

            array = arrayTemp;

            i++;
        }

        static void InserirNovoCadastro(ref string[,] array)
        {

            if (nCadastros > 0)
            {
                AumentarTamanhoCadastro(ref cadastroCorrentista);
            }

            Console.WriteLine("");

            //Solicitando CPF
            Console.Write("Informe o CPF do Correntista (USE APENAS NÚMEROS): ");
            array[i, 0] = Console.ReadLine();
            ValidarCPF(ref cadastroCorrentista);

            //Solicitando Nome
            Console.Write("Informe o NOME do Correntista: ");
            array[i, 1] = Console.ReadLine();

            //Solicitando Sobrenome
            Console.Write("Informe o SOBRENOME do Correntista: ");
            array[i, 2] = Console.ReadLine();

            //Inserindo Renda Comprovada
            Console.Write("Informe a RENDA COMPROVADA do Correntista: R$");
            array[i, 3] = Console.ReadLine();
            ValidarRenda(ref cadastroCorrentista);

            Console.Write("Informe o ANO DE NASCIMENTO do Correntista: ");
            int ano = Int32.Parse(Console.ReadLine());
            while (DateTime.Now.Year - ano > 120 || DateTime.Now.Year < ano)
            {
                Console.WriteLine("[ERRO!] Por favor Insira um Ano VÁLIDO!");

                Console.Write("Informe o ANO DE NASCIMENTO do Correntista: ");
                ano = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Informe o MÊS DE NASCIMENTO do Correntista: ");
            int mes = Int32.Parse(Console.ReadLine());
            while (mes < 1 || mes > 12)
            {
                Console.WriteLine("[ERRO!] Por favor INSIRA um MÊS VÁLIDO!");

                Console.Write("Informe o MÊS DE NASCIMENTO do Correntista: ");
                mes = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Informe o DIA DE NASCIMENTO do Correntista: ");
            int dia = Int32.Parse(Console.ReadLine());
            int validarDia;
            
            do {
                validarDia = 0;

                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                {
                    if (dia < 0 || dia > 31)
                    {
                        Console.WriteLine("[ERRO!] Por favor INSIRA um DIA VÁLIDO!");
                        validarDia++;
                    }
                }
                else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                {
                    if (dia < 0 || dia > 30)
                    {
                        Console.WriteLine("[ERRO!] Por favor INSIRA um DIA VÁLIDO!");
                        validarDia++;
                    }
                }
                else if (ano % 4 == 0)
                {
                    if (dia < 0 || dia > 29)
                    {
                        Console.WriteLine("[ERRO!] Por favor INSIRA um DIA VÁLIDO!");
                        validarDia++;
                    }
                }
                else
                {
                    if (dia < 0 || dia > 28)
                    {
                        Console.WriteLine("[ERRO!] Por favor INSIRA um DIA VÁLIDO!");
                        validarDia++;
                    }
                }

                if (validarDia > 0)
                {
                    Console.Write("Informe o DIA DE NASCIMENTO do Correntista: ");
                    dia = Int32.Parse(Console.ReadLine());
                }
            } while (validarDia > 0);

            if (DateTime.Now.Year - ano < 18)
            {
                Console.Write("[ERRO!] NÃO É POSSÍVEL CADASTRAR CORRENTISTAS MENORES IDADE!");
                array[i, 0] = "";
                array[i, 1] = "";
                array[i, 2] = "";
                array[i, 3] = "";
            }
            else if (DateTime.Now.Year - ano == 18 && DateTime.Now.Month < mes)
            {
                Console.Write("[ERRO!] NÃO É POSSÍVEL CADASTRAR CORRENTISTAS MENORES IDADE!");
                array[i, 0] = "";
                array[i, 1] = "";
                array[i, 2] = "";
                array[i, 3] = "";
            }
            else if (DateTime.Now.Year - ano == 18 && DateTime.Now.Month == mes && DateTime.Now.Day < dia)
            {
                Console.Write("[ERRO!] NÃO É POSSÍVEL CADASTRAR CORRENTISTAS MENORES IDADE!");
                array[i, 0] = "";
                array[i, 1] = "";
                array[i, 2] = "";
                array[i, 3] = "";
            }
            else
            {
                array[i, 4] = $"{dia}/{mes}/{ano}";

                Console.WriteLine("Cadastro Realizado com Sucesso!");
                nCadastros++;
            }

            Console.WriteLine("");

        }
    
        static void ValidarCPF(ref string[,] array)
        {
            string verificador = "";
            int validador = 0, verificador2 = 0;

            while (verificador != "sim")
            {
                verificador2 = 0;
                validador = 0;

                if (array[i, 0].Length != 11)
                {
                    Console.WriteLine("[ERRO!] Por favor  Insira um CPF Válido!");

                    Console.Write("Informe o CPF do Correntista (USE APENAS NÚMEROS): ");
                    cadastroCorrentista[i, 0] = Console.ReadLine();
                }
                else
                {
                    for (int j = 0; j < array[i, 0].Length; j++)
                    {
                        if ($"{array[i,0][j]}" != "0" && $"{array[i,0][j]}" != "1" && $"{array[i,0][j]}" != "2" && $"{array[i,0][j]}" != "3" && $"{array[i,0][j]}" != "4" && $"{array[i,0][j]}" != "5" && $"{array[i,0][j]}" != "6" && $"{array[i,0][j]}" != "7" && $"{array[i,0][j]}" != "8" && $"{array[i,0][j]}" != "9")
                        {
                            validador++;
                        }
                    }

                    if (validador != 0)
                    {
                        Console.WriteLine("[ERRO!] Por favor  Insira um CPF Válido!");

                        Console.Write("Informe o CPF do Correntista (USE APENAS NÚMEROS): ");
                        cadastroCorrentista[i, 0] = Console.ReadLine();
                    }
                    else
                    {
                        verificador = "sim";
                    }
                    if (verificador == "sim")
                    {
                        if (i > 0)
                        {
                            for (int k = 0; k <= i; k++)
                            {
                                if (array[k, 0] == array[i, 0])
                                {
                                    verificador2++;
                                }
                            }

                            if (verificador2 > 1)
                            {
                                verificador = "não";

                                Console.WriteLine("[ERRO!] CPF já Cadastrado!");
                                Console.WriteLine("[ERRO!] Por favor  Insira outro CPF!");

                                Console.Write("Informe o CPF do Correntista (USE APENAS NÚMEROS): ");
                                cadastroCorrentista[i, 0] = Console.ReadLine();
                            }
                            else
                            {
                                verificador = "sim";
                            }
                        }
                    }
                }
            }

        }

        static void ValidarRenda(ref string[,] array)
        {

            int verificador = 0;

            while (verificador != 1)
            {
                int nViruglas = 0, nNãoNumeros = 0;

                for (int j = 0; j < array[i, 3].Length; j++)
                {
                    if ($"{array[i,3][j]}" != "0" && $"{array[i,3][j]}" != "1" && $"{array[i,3][j]}" != "2" && $"{array[i,3][j]}" != "3" && $"{array[i,3][j]}" != "4" && $"{array[i,3][j]}" != "5" && $"{array[i,3][j]}" != "6" && $"{array[i,3][j]}" != "7" && $"{array[i,3][j]}" != "8" && $"{array[i,3][j]}" != "9")
                    {
                        if ($"{array[i,3][j]}" == "=")
                        {
                            nViruglas++;
                        }
                        else
                        {
                            nNãoNumeros++;
                        }
                    }
                }

                if (nNãoNumeros != 0)
                {
                    Console.WriteLine("[ERRO!] Por favor insira um valor válido!");

                    //Inserindo Renda Comprovada
                    Console.Write("Informe a RENDA COMPROVADA do Correntista: R$");
                    cadastroCorrentista[i, 3] = Console.ReadLine();
                }
                else if (nViruglas != 0 && nViruglas > 1)
                {
                    Console.WriteLine("[ERRO!] Por favor insira um valor válido!");

                    //Inserindo Renda Comprovada
                    Console.Write("Informe a RENDA COMPROVADA do Correntista: R$");
                    cadastroCorrentista[i, 3] = Console.ReadLine();
                }
                else
                {
                    verificador = 1;
                }
            }
        }

        static void EditarCadastro(ref string[,] array)
        {
            int validador = 0;
            long editar;

            Console.Write($"Informe o CPF do Cadastros você deseja Editar? ");
            editar = Int64.Parse(Console.ReadLine());

            while ($"{editar}".Length != 11)
            {
                Console.WriteLine("[ERRO!] Por favor Digite um CPF Válido!");

                Console.Write($"Digite o CPF do Cadastro que você deseja consultar? ");
                editar = Int64.Parse(Console.ReadLine());
            }

            for (int j = 0; j <= i; j++)
            {
                if (array[j, 0] == $"{editar}")
                {

                    Console.Write("Informe o Nome do Correntista: ");
                    array[j, 1] = Console.ReadLine();

                    Console.Write("Informe o Sobrenome do Correntista: ");
                    array[j, 2] = Console.ReadLine();

                    Console.Write("Informe a Renda Comprovada do Correntista: ");
                    array[j, 3] = Console.ReadLine();

                    Console.Write("Informe o ANO DE NASCIMENTO do Correntista: ");
                    int ano = Int32.Parse(Console.ReadLine());
                    while (DateTime.Now.Year - ano > 120 || DateTime.Now.Year < ano)
                    {
                        Console.WriteLine("[ERRO!] Por favor Insira um Ano VÁLIDO!");

                        Console.Write("Informe o ANO DE NASCIMENTO do Correntista: ");
                        ano = Int32.Parse(Console.ReadLine());
                    }

                    Console.Write("Informe o MÊS DE NASCIMENTO do Correntista: ");
                    int mes = Int32.Parse(Console.ReadLine());
                    while (mes < 1 || mes > 12)
                    {
                        Console.WriteLine("[ERRO!] Por favor INSIRA um MÊS VÁLIDO!");

                        Console.Write("Informe o MÊS DE NASCIMENTO do Correntista: ");
                        mes = Int32.Parse(Console.ReadLine());
                    }

                    Console.Write("Informe o DIA DE NASCIMENTO do Correntista: ");
                    int dia = Int32.Parse(Console.ReadLine());
                    int validarDia;
            
                    do {
                        validarDia = 0;

                        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                        {
                            if (dia < 0 || dia > 31)
                            {
                                Console.WriteLine("[ERRO!] Por favor INSIRA um DIA VÁLIDO!");
                                validarDia++;
                            }
                        }
                        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                        {
                            if (dia < 0 || dia > 30)
                            {
                                Console.WriteLine("[ERRO!] Por favor INSIRA um DIA VÁLIDO!");
                                validarDia++;
                            }
                        }
                        else if (ano % 4 == 0)
                        {
                            if (dia < 0 || dia > 29)
                            {
                                Console.WriteLine("[ERRO!] Por favor INSIRA um DIA VÁLIDO!");
                                validarDia++;
                            }
                        }
                        else
                        {
                            if (dia < 0 || dia > 28)
                            {
                                Console.WriteLine("[ERRO!] Por favor INSIRA um DIA VÁLIDO!");
                                validarDia++;
                            }
                        }

                        if (validarDia > 0)
                        {
                            Console.Write("Informe o DIA DE NASCIMENTO do Correntista: ");
                            dia = Int32.Parse(Console.ReadLine());
                        }
                    } while (validarDia > 0);

                    array[j,4] = $"{dia}/{mes}/{ano}";

                    validador++;
                }
            }

            if (validador != 1)
            {
                Console.WriteLine("CPF Não Encontrado! por faovr veirfique novamente o CPF digitado!");
            }
            else
            {
                Console.WriteLine("Cadastro Editado com Sucesso!");
            }

            Console.WriteLine("");

        }

        static void ConsultarCadastro(ref string[,] array)
        {
            int validador = 0;
            long consulta;

            Console.WriteLine("");

            Console.Write($"Digite o CPF do Cadastro que você deseja consultar? ");
            consulta = Int64.Parse(Console.ReadLine());

            while ($"{consulta}".Length != 11)
            {
                Console.WriteLine("[ERRO!] Por favor Digite um CPF Válido!");

                Console.Write($"Digite o CPF do Cadastro que você deseja consultar? ");
                consulta = Int64.Parse(Console.ReadLine());
            }

            for (int j = 0; j <= i; j++)
            {
                if (array[j, 0] == $"{consulta}")
                {
                    Console.WriteLine($"CPF: {array[j, 0]} - Nome: {array[j, 1]} - Sobrenome: {array[j, 2]} - Renda Comprovada: R${array[j, 3]} - Data de Nascimento: {array[j,4]}");

                    validador++;
                }
            }

            if (validador != 1)
            {
                Console.WriteLine("CPF Não Encontrado! por favor veirfique novamente o CPF digitado!");
            }

            Console.WriteLine("");
        }

        static void ExcluirCadastro(ref string[,] array)
        {
            int validador = 0;
            long excluir;
            string[,] arrayTemp = new string[i + 1, 5];
            int k = 0, l = 0;

            Console.Write($"Informe o CPF do Cadastro você deseja excluir? ");
            excluir = Int64.Parse(Console.ReadLine());

            while ($"{excluir}".Length != 11)
            {
                Console.WriteLine("[ERRO!] Por favor Digite um CPF Válido!");

                Console.Write($"Digite o CPF do Cadastro que você deseja consultar? ");
                excluir = Int64.Parse(Console.ReadLine());
            }

            for (int j = 0; j <= i; j++)
            {
                if (array[j, 0] == $"{excluir}")
                {
                    l = j;
                    validador++;
                }
            }

            for (int j = 0; j <= i; j++)
            {
                if (k >= l && j < i)
                {
                    arrayTemp[j, 0] = array[k + 1, 0];
                    arrayTemp[j, 1] = array[k + 1, 1];
                    arrayTemp[j, 2] = array[k + 1, 2];
                    arrayTemp[j, 3] = array[k + 1, 3];
                    arrayTemp[j, 4] = array[k + 1, 4];
                }
                else if (j == i)
                {
                    arrayTemp[j,0] = "";
                    arrayTemp[j,1] = "";
                    arrayTemp[j,2] = "";
                    arrayTemp[j,3] = "";
                    arrayTemp[j,4] = "";
                }
                else
                {
                    arrayTemp[j, 0] = array[k, 0];
                    arrayTemp[j, 1] = array[k, 1];
                    arrayTemp[j, 2] = array[k, 2];
                    arrayTemp[j, 3] = array[k, 3];
                    arrayTemp[j, 4] = array[k, 4];
                }
                k++;
            }
            array = arrayTemp;

            if (validador != 1)
            {
                Console.WriteLine("CPF Não Encontrado! por faovr veirfique novamente o CPF digitado!");
            }
            else
            {
                //array = arrayTemp;
                i--;
            }

            Console.WriteLine("CADASTRO EXCLUÍDO COM SUCESSO!");

            nCadastros--;

            Console.WriteLine("");

        }
        static void ExibirCadastros(ref string[,] array)
        {
            Console.WriteLine("EXIBINDO CADASTROS:");
            Console.WriteLine("");
            int c = 1;

            for (int j = 0; j <= i; j++)
            {
                if (array[j,0] != "")
                {
                    Console.WriteLine($"Cadastro Nº{c}: CPF: {array[j, 0]} - Nome: {array[j, 1]} - Sobrenome: {array[j, 2]} - Renda Comprovada: R${array[j, 3]} - Data de Nascimento: {array[j,4]}");
                    Console.WriteLine("");

                    c++;
                }
            }
        }
    }
}
