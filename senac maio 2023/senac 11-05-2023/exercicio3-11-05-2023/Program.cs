using System;

namespace exercicio3_11_05_2023
{
    class Program
    {
        static Contatos[] contatos = new Contatos[0];
        static ContatoPessoal[] contatoPessoal = new ContatoPessoal[0];
        static ContatoTrabalho[] contatoTrabalho = new ContatoTrabalho[0];
        static ContatoNaoClassificado[] contatoNaoClassificado = new ContatoNaoClassificado[0];
        static int i = 0;
        static void Main(string[] args)
        {
            Console.Write("Digite a Quantidade de Contatos que você possui: ");
            int nContatos = Int32.Parse(Console.ReadLine());
            int categoriaContato = -1;

            string nomeContato = "";
            string telefoneContato = "";
            string enderecoContato = "";
            string categoriaContatoNome = "";

            while (i != nContatos)
            {
                categoriaContato = -1;
                Console.WriteLine("");
                Console.WriteLine("========== CRIANDO CONTATO ==========");
                Console.Write("Digite o Nome do Contato: ");
                nomeContato = Console.ReadLine();

                do {
                    Console.WriteLine("[AVISO!] Veja um exemplo de número de contato: '+11 (11)11111-1111'");
                    Console.WriteLine("Insira APENAS os Números, mas seguindo o padrão acima!");
                    Console.Write("Digite o Número de Telefone (APENAS NÚMEROS): ");
                    telefoneContato = Console.ReadLine();

                    if (ValidarTelefone(telefoneContato) == false)
                    {
                        Console.WriteLine("[ERRO!] TELEFONE DO CONTATO INSERIDO DE FORMA INCORRETA!");
                    }
                } while (ValidarTelefone(telefoneContato) == false);

                while (categoriaContato < 1 || categoriaContato > 3)
                {
                    Console.WriteLine("[1] Contato Pessoal, [2] Contato de Trabalho, [3] Contato Não Categorizado");
                    categoriaContato = Int32.Parse(Console.ReadLine());

                    if (categoriaContato < 1 || categoriaContato > 3)
                    {
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                    }
                }

                Console.Write("Digite o Endereço do Contato: ");
                enderecoContato = Console.ReadLine();

                switch (categoriaContato)
                {
                    case 1:
                        //CRIAR CONTATO PESSOAL
                        categoriaContatoNome = "❦ PESSOAL ❦";

                        ContatoPessoal novoContatoPessoal = new ContatoPessoal(nomeContato, telefoneContato, enderecoContato, categoriaContatoNome);
                        AumentarArrayContatoPessoal(novoContatoPessoal);

                        break;
                    case 2:
                        //CRIAR CONTATO DE TRABALHO
                        categoriaContatoNome = "☯ TRABALHO ☯";

                        ContatoTrabalho novoContatoTrabalho = new ContatoTrabalho(nomeContato, telefoneContato, enderecoContato, categoriaContatoNome);
                        AumentarArrayContatoTrabalho(novoContatoTrabalho);

                        break;
                    case 3:
                        //CRIAR CONTATO NÃO-CLASSIFICADO
                        categoriaContatoNome = "☉ NÃO-CLASSIFICADO ☉";

                        ContatoNaoClassificado novoContatoNC = new ContatoNaoClassificado(nomeContato, telefoneContato, enderecoContato, categoriaContatoNome);
                        AumentarArrayContatoNC(novoContatoNC);

                        break;
                }

                Contatos novoContato = new Contatos(nomeContato, telefoneContato, enderecoContato, categoriaContatoNome);
                AumentarArrayContatos(novoContato);

                i++;
            }

            bool exibirAgenda = true;

            do {
                Console.WriteLine("=============== AGENDA ===============");
                Console.WriteLine("");
                Console.WriteLine("[1] Contatos Pessoais");
                Console.WriteLine("[2] Contatos de Trabalho");
                Console.WriteLine("[3] Contatos Não-Classificados");
                Console.WriteLine("[4] Todos os Contatos");
                Console.WriteLine("[5] Sair");
                Console.WriteLine("======================================");
                Console.WriteLine("");
                Console.Write("Digite a Opção Desejada: ");
                int opcaoAgenda = Int32.Parse(Console.ReadLine());

                switch (opcaoAgenda)
                {
                    case 1:
                        //EXIBINDO TODOS OS CONTATOS PESSOAIS
                        Console.WriteLine("[AVISO!] Exibindo Contatos Pessoais... ");
                        for (int j = 0; j < contatoPessoal.Length; j++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine($"Categoria Contato: {contatoPessoal[j].CategoriaContato}");
                            Console.WriteLine($"Nome: {contatoPessoal[j].Nome}");
                            Console.WriteLine($"Telefone: +{contatoPessoal[j].Telefone[0]}{contatoPessoal[j].Telefone[1]} ({contatoPessoal[j].Telefone[2]}{contatoPessoal[j].Telefone[3]}){contatoPessoal[j].Telefone[4]}{contatoPessoal[j].Telefone[5]}{contatoPessoal[j].Telefone[6]}{contatoPessoal[j].Telefone[7]}{contatoPessoal[j].Telefone[8]}-{contatoPessoal[j].Telefone[9]}{contatoPessoal[j].Telefone[10]}{contatoPessoal[j].Telefone[11]}{contatoPessoal[j].Telefone[12]}");
                            Console.WriteLine($"Endereço: {contatoPessoal[j].Endereco}");
                            Console.WriteLine("");
                        }

                        break;
                    case 2:
                        //EXIBINDO TODOS OS CONTATOS DE TRABALHO
                        Console.WriteLine("[AVISO!] Exibindo Contatos de Trabalho... ");
                        for (int j = 0; j < contatoTrabalho.Length; j++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine($"Categoria Contato: {contatoTrabalho[j].CategoriaContato}");
                            Console.WriteLine($"Nome: {contatoTrabalho[j].Nome}");
                            Console.WriteLine($"Telefone: +{contatoTrabalho[j].Telefone[0]}{contatoTrabalho[j].Telefone[1]} ({contatoTrabalho[j].Telefone[2]}{contatoTrabalho[j].Telefone[3]}){contatoTrabalho[j].Telefone[4]}{contatoTrabalho[j].Telefone[5]}{contatoTrabalho[j].Telefone[6]}{contatoTrabalho[j].Telefone[7]}{contatoTrabalho[j].Telefone[8]}-{contatoTrabalho[j].Telefone[9]}{contatoTrabalho[j].Telefone[10]}{contatoTrabalho[j].Telefone[11]}{contatoTrabalho[j].Telefone[12]}");
                            Console.WriteLine($"Endereço: {contatoTrabalho[j].Endereco}");
                            Console.WriteLine("");
                        }

                        Console.WriteLine("");

                        break;
                    case 3:
                        //EXIBINDO TODOS OS CONTATOS NÃO-CLASSIFICADOS
                        Console.WriteLine("[AVISO!] Exibindo Contatos Não-Classificados... ");
                        for (int j = 0; j < contatoNaoClassificado.Length; j++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine($"Categoria Contato: {contatoNaoClassificado[j].CategoriaContato}");
                            Console.WriteLine($"Nome: {contatoNaoClassificado[j].Nome}");
                            Console.WriteLine($"Telefone: +{contatoNaoClassificado[j].Telefone[0]}{contatoNaoClassificado[j].Telefone[1]} ({contatoNaoClassificado[j].Telefone[2]}{contatoNaoClassificado[j].Telefone[3]}){contatoNaoClassificado[j].Telefone[4]}{contatoNaoClassificado[j].Telefone[5]}{contatoNaoClassificado[j].Telefone[6]}{contatoNaoClassificado[j].Telefone[7]}{contatoNaoClassificado[j].Telefone[8]}-{contatoNaoClassificado[j].Telefone[9]}{contatoNaoClassificado[j].Telefone[10]}{contatoNaoClassificado[j].Telefone[11]}{contatoNaoClassificado[j].Telefone[12]}");
                            Console.WriteLine($"Endereço: {contatoNaoClassificado[j].Endereco}");
                            Console.WriteLine("");
                        }

                        Console.WriteLine("");

                        break;
                    case 4:
                        //EXIBINDO TODOS OS CONTATOS
                        Console.WriteLine("[AVISO!] Exibindo Contatos... ");
                        for (int j = 0; j < contatos.Length; j++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine($"Categoria Contato: {contatos[j].CategoriaContato}");
                            Console.WriteLine($"Nome: {contatos[j].Nome}");
                            Console.WriteLine($"Telefone: +{contatos[j].Telefone[0]}{contatos[j].Telefone[1]} ({contatos[j].Telefone[2]}{contatos[j].Telefone[3]}){contatos[j].Telefone[4]}{contatos[j].Telefone[5]}{contatos[j].Telefone[6]}{contatos[j].Telefone[7]}{contatos[j].Telefone[8]}-{contatos[j].Telefone[9]}{contatos[j].Telefone[10]}{contatos[j].Telefone[11]}{contatos[j].Telefone[12]}");
                            Console.WriteLine($"Endereço: {contatos[j].Endereco}");
                            Console.WriteLine("");
                        }

                        Console.WriteLine("");

                        break;
                    case 5:
                        //SAIR
                        Console.WriteLine("[AVISO!] Saindo... ");
                        exibirAgenda = false;
                        Console.WriteLine("");

                        break;
                    default:
                        //OPÇÃO INVÁLIDA
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                        Console.WriteLine("");

                        break;
                }
            } while (exibirAgenda == true);
        }

        static void AumentarArrayContatos(Contatos novoContato)
        {
            Contatos[] contatosTemp = new Contatos[contatos.Length+1];

            for (int i = 0; i < contatos.Length; i++)
            {
                contatosTemp[i] = contatos[i];
            }

            contatosTemp[contatos.Length] = novoContato;

            contatos = contatosTemp;
        }

        static void AumentarArrayContatoPessoal(ContatoPessoal novoContatoPessoal)
        {
            ContatoPessoal[] contatoPessoalTemp = new ContatoPessoal[contatoPessoal.Length+1];

            for (int i = 0; i < contatoPessoal.Length; i++)
            {
                contatoPessoalTemp[i] = contatoPessoal[i];
            }
            contatoPessoalTemp[contatoPessoal.Length] = novoContatoPessoal;

            contatoPessoal = contatoPessoalTemp;
        }

        static void AumentarArrayContatoTrabalho(ContatoTrabalho novoContatoTrabalho)
        {
            ContatoTrabalho[] contatoTrabalhoTemp = new ContatoTrabalho[contatoTrabalho.Length+1];

            for (int i = 0; i < contatoTrabalho.Length; i++)
            {
                contatoTrabalhoTemp[i] = contatoTrabalho[i];
            }
            contatoTrabalhoTemp[contatoTrabalho.Length] = novoContatoTrabalho;

            contatoTrabalho = contatoTrabalhoTemp;
        }

        static void AumentarArrayContatoNC(ContatoNaoClassificado novoContatoNC)
        {
            ContatoNaoClassificado[] contatoNaoClassificadoTemp = new ContatoNaoClassificado[contatoNaoClassificado.Length+1];

            for (int i = 0; i < contatoNaoClassificado.Length; i++)
            {
                contatoNaoClassificadoTemp[i] = contatoNaoClassificado[i];
            }
            contatoNaoClassificadoTemp[contatoNaoClassificado.Length] = novoContatoNC;

            contatoNaoClassificado = contatoNaoClassificadoTemp;
        }

        static bool ValidarTelefone(string telefoneContato)
        {
            if (telefoneContato.Length != 13)
            {
                return false;
            }
            else
            {
                for (int j = 0; j < telefoneContato.Length; j++)
                {
                    if (telefoneContato[j] < 48 || telefoneContato[j] > 57)
                    {
                        return false;
                    }
                }

                for (int j = 0; j < contatos.Length; j++)
                {
                    if (contatos[j].Telefone == telefoneContato)
                    {
                        Console.WriteLine("[ERRO!] TELEFONE JÁ CADASTRADO!");
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
