using System;

namespace exercicio4_11_05_2023
{
    class Program
    {
        static double salario = 1302;
        static void Main(string[] args)
        {
            string continuarLoop = "";
            do {
                Console.WriteLine("");
                Console.WriteLine("=============== CALCULANDO IMPOSTO ===============");
                Console.WriteLine("");

                Console.Write("Digite o Nome do Funcionário: ");
                string nomeFuncionario = Console.ReadLine();
                int funcao = 0;
                string funcaoNome = "";

                do {
                    Console.WriteLine("[1] Funcionário Comum, [2] Gerente, [3] Diretor");
                    Console.Write("Digite o Nº correpondente ao Cargo do Funcionário: ");
                    funcao = Int32.Parse(Console.ReadLine());

                    if (funcao < 1 || funcao > 3)
                    {
                        Console.WriteLine("[ERRO!] OPÇÃO INVÁLIDA!");
                        Console.WriteLine("");
                    }
                } while (funcao < 1 || funcao > 3);

                switch (funcao)
                {
                    case 1:
                        //FUNCIONÁRIO COMUM
                        funcaoNome = "Funcionário";
                        Funcionario funcionario = new Funcionario(nomeFuncionario, funcaoNome, salario);
                        funcionario.CalcularPercentualSalario(funcionario.Salario);
                        funcionario.CalcularValorImposto(funcionario.Salario);


                        Console.WriteLine("========== IMPRIMINDO RESULTADO ==========");

                        Console.WriteLine($"Nome: {funcionario.Nome}");
                        Console.WriteLine($"Cargo: {funcionario.Cargo}");
                        Console.WriteLine($"Salário: R${funcionario.Salario}");
                        Console.WriteLine($"Percentual Imposto: {funcionario.PercentualImposto}%");
                        Console.WriteLine($"Valor Imposto: R${funcionario.ValorImposto}");

                        Console.WriteLine("==========================================");

                        break;
                    case 2:
                        //GERENTE
                        funcaoNome = "Gerente";
                        Gerente gerente = new Gerente(nomeFuncionario, funcaoNome, salario);
                        gerente.CacularSalario(gerente.Salario);
                        gerente.CalcularPercentualSalario(gerente.Salario);
                        gerente.CalcularValorImposto(gerente.Salario);

                        Console.WriteLine("========== IMPRIMINDO RESULTADO ==========");

                        Console.WriteLine($"Nome: {gerente.Nome}");
                        Console.WriteLine($"Cargo: {gerente.Cargo}");
                        Console.WriteLine($"Salário: R${gerente.Salario}");
                        Console.WriteLine($"Percentual Imposto: {gerente.PercentualImposto}%");
                        Console.WriteLine($"Valor Imposto: R${gerente.ValorImposto}");

                        Console.WriteLine("==========================================");

                        break;
                    case 3:
                        //DIRETOR
                        funcaoNome = "Diretor";
                        Diretor diretor = new Diretor(nomeFuncionario, funcaoNome, salario);
                        diretor.CacularSalario(diretor.Salario);
                        diretor.CalcularPercentualSalario(diretor.Salario);
                        diretor.CalcularValorImposto(diretor.Salario);

                        Console.WriteLine("========== IMPRIMINDO RESULTADO ==========");

                        Console.WriteLine($"Nome: {diretor.Nome}");
                        Console.WriteLine($"Cargo: {diretor.Cargo}");
                        Console.WriteLine($"Salário: R${diretor.Salario}");
                        Console.WriteLine($"Percentual Imposto: {diretor.PercentualImposto}%");
                        Console.WriteLine($"Valor Imposto: R${diretor.ValorImposto}");

                        Console.WriteLine("==========================================");

                        break; 
                }

                Console.WriteLine("");
                Console.WriteLine("Deseja Continuar? [S/N]");
                continuarLoop = Console.ReadLine();

            } while (continuarLoop.ToUpper() == "S");
        }
    }
}
