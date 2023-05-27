using System;

namespace exercicio3_17_05_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarLoop = true;
            string operacao = "";
            double valor1 = 0;
            double valor2 = 0;

            do {
                ExibirCalculadora();


                //SOLICITANDO OPERAÇÃO
                do {
                    Console.WriteLine("Digite a Operação Desejada: ");
                    operacao = Console.ReadLine();

                    if (operacao != "+" && operacao != "-" && operacao != "/" && operacao != "*" && operacao != "^2" && operacao != "^x")
                    {
                        Console.WriteLine("[ERRO!] OPERAÇÃO INVÁLIDA!");
                        Console.WriteLine("");
                    }
                } while (operacao != "+" && operacao != "-" && operacao != "/" && operacao != "*" && operacao != "^2" && operacao != "^x");
                Console.WriteLine("");

                OperacaoAritmetica resultadoOperacao;

                //SELECIONANDO OPERAÇÃO DESEJADA
                switch (operacao)
                {
                    case "+":
                        Console.Write("Digite o Primeiro Valor da Operação: ");
                        valor1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Digite o Segundo Valor da Operação: ");
                        valor2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        resultadoOperacao = new OperacaoSoma(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultadoOperacao.Calcular()}");

                        break;
                    case "-":
                        Console.Write("Digite o Primeiro Valor da Operação: ");
                        valor1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Digite o Segundo Valor da Operação: ");
                        valor2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        resultadoOperacao = new OperacaoSubtracao(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultadoOperacao.Calcular()}");

                        break;
                    case "/":
                        Console.Write("Digite o Primeiro Valor da Operação: ");
                        valor1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Digite o Segundo Valor da Operação: ");
                        valor2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        resultadoOperacao = new OperacaoDivisao(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultadoOperacao.Calcular()}");

                        break;
                    case "*":
                        Console.Write("Digite o Primeiro Valor da Operação: ");
                        valor1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Digite o Segundo Valor da Operação: ");
                        valor2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        resultadoOperacao = new OperacaoMultiplicacao(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultadoOperacao.Calcular()}");

                        break;
                    case "^2":
                        Console.Write("Digite o Primeiro Valor da Operação: ");
                        valor1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        valor2 = 2;
                        Console.WriteLine("");

                        resultadoOperacao = new OperacaoPotencia2(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultadoOperacao.Calcular()}");

                        break;
                    case "^x":
                        Console.Write("Digite o Primeiro Valor da Operação: ");
                        valor1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.Write("Digite o Segundo Valor da Operação: ");
                        valor2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("");

                        resultadoOperacao = new OperacaoPotenciaX(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultadoOperacao.Calcular()}");

                        break;
                }

                Console.WriteLine("");

                //PERGUNTANDO SE O USUÁRIO DESEJA REALIZAR MAIS OPERAÇÕES
                Console.WriteLine("Deseja Continuar? [S/N]");
                string resposta = Console.ReadLine();

                if (resposta.ToUpper() == "N")
                {
                    //SAINDO DO PROGRAMA
                    Console.WriteLine("[AVISO!] Saindo do Programa CALCULADORA... ");
                    continuarLoop = false;
                    Console.WriteLine("");
                }

            } while (continuarLoop == true);
        }

        static void ExibirCalculadora()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("||   ___________________   ||");
            Console.WriteLine("||  [___________________]  ||");
            Console.WriteLine("||                         ||");
            Console.WriteLine("||    [+]    [-]    [/]    ||");
            Console.WriteLine("||                         ||");
            Console.WriteLine("||    [*]   [^2]   [^x]    ||");
            Console.WriteLine("||                         ||");
            Console.WriteLine("=============================");
            Console.WriteLine("");
        }
    }
}
