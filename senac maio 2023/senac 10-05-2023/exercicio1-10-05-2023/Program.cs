using System;

namespace exercicio1_10_05_2023
{
    class Program
    {
        static long matricula;
        static string nomeAluno;
        static double nota1;
        static double nota2;
        static double nota3;
        static double nota4;
        static double media;
        static string situacaoAluno;

        static int Index = 0;

        static Aluno[] alunos = new Aluno[0];
        static void Main(string[] args)
        {
            int continuarLoop = 0;
		
            do {
                switch (Menu())
                {
                    case 1:
                        //INSERIR NOVO ALUNO
                        Console.WriteLine("ADICIONANDO ALUNO...");

                        do {
                            Console.Write("Digite a Matrícula do Aluno: ");
                            matricula = Int64.Parse(Console.ReadLine());
                            if (ValidarMatricula(matricula) == 1)
                            {
                                Console.WriteLine("[ERRO!] SUA MATRÍCULA NÃO PODE SER MENOR QUE 1!");
                            }
                            else if (ValidarMatricula(matricula) == 2)
                            {
                                Console.WriteLine("[ERRO!] ESSA MATRÍCULA JÁ ESTÁ CADASTRADA!");
                            }
                        } while (ValidarMatricula(matricula) != 0);
                        
                        Console.Write("Digite o Nome do Aluno: ");
                        nomeAluno = Console.ReadLine();
                        
                        do {
                            Console.Write("Digite a Primeira Nota do Aluno: ");
                            nota1 = Double.Parse(Console.ReadLine());
                        } while (ValidarNota(ref nota1) != true);
                        
                        do {
                            Console.Write("Digite a Segunda Nota do Aluno: ");
                            nota2 = Double.Parse(Console.ReadLine());
                        } while (ValidarNota(ref nota2) != true);
                        
                        do {
                            Console.Write("Digite a Terceira Nota do Aluno: ");
                            nota3 = Double.Parse(Console.ReadLine());
                        } while (ValidarNota(ref nota3) != true);
                        
                        do {
                            Console.Write("Digite a Quarta Nota do Aluno: ");
                            nota4 = Double.Parse(Console.ReadLine());
                        } while (ValidarNota(ref nota4) != true);
                        
                        media = CalcularMediaAluno(nota1, nota2, nota3, nota4);
                        situacaoAluno = VerificarSituacaoAluno(media);

                        Console.WriteLine($"Sua Média é {media}, você está {situacaoAluno}");

                        Aluno aluno = new Aluno(matricula, nomeAluno);
                        aluno.Nota1 = nota1;
                        aluno.Nota2 = nota2;
                        aluno.Nota3 = nota3;
                        aluno.Nota4 = nota4;
                        aluno.Media = media;
                        aluno.SituacaoAluno = situacaoAluno;

                        AdicionarAluno(aluno);

                        break;
                    case 2:
                        //EDITAR INFORMAÇÕES DO ALUNO
                        Console.WriteLine("EDITANDO ALUNO...");
                        Console.WriteLine("");
                        int matriculaValida = 0;
                        int editar = 0;

                        Console.Write("Insira a Matrícula do Aluno que você Deseja Alterar as Informações: ");
                        long matriculaEditar = Int64.Parse(Console.ReadLine());
                        for (int i = 0; i< alunos.Length; i++)
                        {
                            if (alunos[i].Matricula == matriculaEditar)
                            {
                                matriculaValida++;
                                editar = i;
                            }
                        }

                        if (matriculaValida == 0)
                        {
                            Console.WriteLine("[ERRO!] MATRÍCULA NÃO ENCONTRADA!");
                        }
                        else
                        {
                            do {
                                Console.Write("Digite a Matrícula do Aluno: ");
                                matricula = Int64.Parse(Console.ReadLine());

                                matriculaValida = ValidarMatricula(matricula);

                                if (matriculaValida == 1)
                                {
                                    Console.WriteLine("[ERRO!] SUA MATRÍCULA NÃO PODE SER MENOR QUE 1!");
                                }
                                else if (matriculaValida == 2 && matricula != matriculaEditar)
                                {
                                    Console.WriteLine("[ERRO!] ESSA MATRÍCULA JÁ ESTÁ CADASTRADA!");
                                }
                                else
                                {
                                    matriculaValida = 0;
                                }
                            } while (matriculaValida != 0);
                            
                            Console.Write("Digite o Nome do Aluno: ");
                            nomeAluno = Console.ReadLine();
                            
                            do {
                                Console.Write("Digite a Primeira Nota do Aluno: ");
                                nota1 = Double.Parse(Console.ReadLine());
                            } while (ValidarNota(ref nota1) != true);
                            
                            do {
                                Console.Write("Digite a Segunda Nota do Aluno: ");
                                nota2 = Double.Parse(Console.ReadLine());
                            } while (ValidarNota(ref nota2) != true);
                            
                            do {
                                Console.Write("Digite a Terceira Nota do Aluno: ");
                                nota3 = Double.Parse(Console.ReadLine());
                            } while (ValidarNota(ref nota3) != true);
                            
                            do {
                                Console.Write("Digite a Quarta Nota do Aluno: ");
                                nota4 = Double.Parse(Console.ReadLine());
                            } while (ValidarNota(ref nota4) != true);
                            
                            media = CalcularMediaAluno(nota1, nota2, nota3, nota4);
                            situacaoAluno = VerificarSituacaoAluno(media);

                            Console.WriteLine($"Sua Média é {media}, você está {situacaoAluno}");

                            Aluno alunoEditado = new Aluno(matricula, nomeAluno);
                            alunoEditado.Nota1 = nota1;
                            alunoEditado.Nota2 = nota2;
                            alunoEditado.Nota3 = nota3;
                            alunoEditado.Nota4 = nota4;
                            alunoEditado.Media = media;
                            alunoEditado.SituacaoAluno = situacaoAluno;

                            EditarAluno(alunoEditado, editar);

                            Console.WriteLine("");
                            Console.WriteLine("[AVISO!] ALUNO EDITADO COM SUCESSO!");
                            Console.WriteLine("");
                        }                
                        break;
                    case 3:
                        //CONSULTAR ALUNO
                        Console.WriteLine("CONSULTANDO ALUNO...");
                        Console.WriteLine("");
                        Console.Write("Digite a Matrícula do Aluno que você deseja Consultar: ");
                        matricula = Int64.Parse(Console.ReadLine());
                        matriculaValida = 0;
                        int consulta = 0;

                        for (int i =0; i < alunos.Length; i++)
                        {
                            if (alunos[i].Matricula == matricula)
                            {
                                matriculaValida++;
                                consulta = i;
                            }
                        }

                        if (matriculaValida == 0 || matricula < 1)
                        {
                            Console.WriteLine("[ERRO!] MATRÍCULA NÃO ENCONTRADA!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine($"Matrícula: {alunos[consulta].Matricula}");
                            Console.WriteLine($"Nome: {alunos[consulta].Nome}");
                            Console.WriteLine($"Nota 1: {alunos[consulta].Nota1}");
                            Console.WriteLine($"Nota 2: {alunos[consulta].Nota2}");
                            Console.WriteLine($"Nota 3: {alunos[consulta].Nota3}");
                            Console.WriteLine($"Nota 4: {alunos[consulta].Nota4}");
                            Console.WriteLine($"Média: {alunos[consulta].Media}");
                            Console.WriteLine($"Situação: {alunos[consulta].SituacaoAluno}");
                            Console.WriteLine("");
                        }

                        break;
                    case 4:
                        //EXCLUIR ALUNO
                        Console.WriteLine("DELETANDO ALUNO...");
                        Console.WriteLine("");
                        Console.Write("Digite a Matrícula do Aluno que você deseja Deletar: ");
                        matricula = Int64.Parse(Console.ReadLine());

                        matriculaValida = 0;
                        int excluir = 0;

                        for (int i =0; i < alunos.Length; i++)
                        {
                            if (alunos[i].Matricula == matricula)
                            {
                                matriculaValida++;
                                excluir = i;
                            }
                        }

                        if (matriculaValida == 0)
                        {
                            Console.WriteLine("[ERRO!] MATRÍCULA NÃO ENCONTRADA!");
                            Console.WriteLine("");
                        }
                        else
                        {
                            ExcluirAluno(matricula, excluir);
                            Console.WriteLine("[AVISO!] ALUNO EXCLUÍDO COM SUCESSO!");
                            Console.WriteLine("");

                            AlterarPosicaoAlunos(excluir);
                        }
                
                        break;
                    case 5:
                        //EXIBIR TODOS OS ALUNOS

                        int limiteAluno = - 1;

                        for (int i = 0; i < alunos.Length; i ++)
                        {
                            if (alunos[i].Matricula < 1)
                            {
                                limiteAluno = i;
                            }
                        }

                        if (limiteAluno < 1)
                        {
                            limiteAluno = alunos.Length;
                        }

                        Console.WriteLine("EXIBINDO ALUNOS...");
                        Console.WriteLine("");

                        for (int i = 0; i < limiteAluno; i++)
                        {        
                            Console.WriteLine($"Matrícula: {alunos[i].Matricula}");
                            Console.WriteLine($"Nome: {alunos[i].Nome}");
                            Console.WriteLine($"Nota 1: {alunos[i].Nota1}");
                            Console.WriteLine($"Nota 2: {alunos[i].Nota2}");
                            Console.WriteLine($"Nota 3: {alunos[i].Nota3}");
                            Console.WriteLine($"Nota 4: {alunos[i].Nota4}");
                            Console.WriteLine($"Média: {alunos[i].Media}");
                            Console.WriteLine($"Situação: {alunos[i].SituacaoAluno}");
                            Console.WriteLine("");
                        }

                        break;
                    case 6:
                        Sair(ref continuarLoop);
                        break;
                    default:
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                        
                        break;
                }
            } while (continuarLoop == 0);
        }
        
        static int Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("=============== MENU ALUNO ===============");
            Console.WriteLine("||   [1] Inserir Novo Aluno             ||");
            Console.WriteLine("||   [2] Editar Informações do Aluno    ||");
            Console.WriteLine("||   [3] Consultar Aluno                ||");
            Console.WriteLine("||   [4] Excluir Aluno                  ||");
            Console.WriteLine("||   [5] Mostrar Todos os Alunos        ||");
            Console.WriteLine("||   [6] Sair                           ||");
            Console.WriteLine("==========================================");
            Console.WriteLine("");
            Console.Write("Digite uma das Opções Acima: ");
            
            int opcao = Int32.Parse(Console.ReadLine());

            return opcao;
        }

        static int ValidarMatricula(long matricula)
        {
            int matriculaValida = 0;

            if (matricula < 1)
            {
                matriculaValida = 1;
            }
            else
            {
                for (int i = 0; i < alunos.Length; i++)
                {
                    if (alunos[i].Matricula == matricula)
                    {
                        matriculaValida = 2;
                    }
                }
            }

            return matriculaValida;
        }
        
        static bool ValidarNota(ref double nota)
        {
            bool notaValida;
            
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("[ERRO!] A NOTA NÃO PODE SER MENOR QUE ZERO E/OU MAIOR QUE 10!");
                Console.WriteLine("");
                notaValida = false;
            }
            else
            {
                notaValida = true;
            }
            
            return notaValida;
        }
        
        static double CalcularMediaAluno(double nota1, double nota2, double nota3, double nota4)
        {
            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            return media;
        }

        static string VerificarSituacaoAluno(double media)
        {
            if (media >= 7)
            {
                return "APROVADO";
            }
            else if (media >= 5)
            {
                return "RECUPERAÇÃO";
            }
            else
            {
                return "REPROVADO";
            }
        }

        static void AdicionarAluno(Aluno aluno)
        {
            Aluno[] alunosTemp = new Aluno[Index + 1];

            if (Index == 0)
            {
                alunosTemp[0] = aluno;
            }
            else
            {
                for (int i = 0; i < Index; i++)
                {
                    alunosTemp[i] = alunos[i];
                }
                alunosTemp[Index] = aluno;
            }

            alunos = alunosTemp;

            Index++;
        }

        static void EditarAluno(Aluno alunoEditado, int editar)
        {
            alunos[editar] = alunoEditado;
        }

        static void ExcluirAluno(long matricula, int excluir)
        {
            alunos[excluir].Matricula = 0;
            alunos[excluir].Nome = "";
            alunos[excluir].Nota1 = 0;
            alunos[excluir].Nota2 = 0;
            alunos[excluir].Nota3 = 0;
            alunos[excluir].Nota4 = 0;
            alunos[excluir].Media = 0;
            alunos[excluir].SituacaoAluno = "";

            Index--;
        }

        static void AlterarPosicaoAlunos(int excluir)
        {
            Aluno[] alunosTemp = new Aluno[alunos.Length];

            for (int i = 0; i < alunos.Length - 1; i++)
            {
                if (i >= excluir)
                {
                    alunosTemp[i] = alunos[i+1];
                }
                else
                {
                    alunosTemp[i] = alunos[i];
                }
            }

            alunosTemp[alunos.Length - 1] = alunos[excluir];

            alunos = alunosTemp;
        }
        
        static void Sair(ref int continuarLoop)
        {	
            Console.WriteLine("Saindo do Menu... ");
            
            continuarLoop++;
        }
        
    }
}
