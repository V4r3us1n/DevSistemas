using System;

namespace exercicio4_24_05_2023
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
                //SOLICITANDO OPERAÇÃO
                do {
                    ExibirCalculadora();

                    Console.WriteLine("Digite a Operação Desejada: ");

                    //Validando Operador
                    try 
                    {
                        operacao = Console.ReadLine();

                        if (operacao != "+" && operacao != "-" && operacao != "/" && operacao != "*" && operacao != "^2" && operacao != "^x")
                        {
                            throw new ArgumentException();
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (operacao != "+" && operacao != "-" && operacao != "/" && operacao != "*" && operacao != "^2" && operacao != "^x");

                Console.WriteLine("");

                ResultadoOperacao resultado;

                //SELECIONANDO OPERAÇÃO DESEJADA
                bool validador;

                switch (operacao)
                {
                    case "+":
                        //Validando Primeiro Valor
                        do {
                            validador = true;
                            Console.Write("Digite o Primeiro Valor da Operação: ");

                            try {
                                valor1 = Double.Parse(Console.ReadLine());

                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);
                        
                        Console.WriteLine("");

                        //Validando Segundo Valor
                        do {
                            validador = true;
                            Console.Write("Digite o Segundo Valor da Operação: ");

                            try {
                                valor2 = Double.Parse(Console.ReadLine());

                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);

                        Console.WriteLine("");

                        OperacaoAritmetica soma = new OperacaoSoma(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        resultado = new ResultadoOperacao(soma);
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultado.ExibirResultado()}");

                        break;
                    case "-":
                        //Validando Primeiro Valor
                        do {
                            validador = true;
                            Console.Write("Digite o Primeiro Valor da Operação: ");

                            try {
                                valor1 = Double.Parse(Console.ReadLine());

                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);
                        
                        Console.WriteLine("");

                        //Validando Segundo Valor
                        do {
                            validador = true;
                            Console.Write("Digite o Segundo Valor da Operação: ");

                            try {
                                valor2 = Double.Parse(Console.ReadLine());

                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);

                        Console.WriteLine("");

                        OperacaoAritmetica subtracao = new OperacaoSubtracao(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        resultado = new ResultadoOperacao(subtracao);
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultado.ExibirResultado()}");

                        break;
                    case "/":
                        //Validando Primeiro Valor
                        do {
                            validador = true;
                            Console.Write("Digite o Primeiro Valor da Operação: ");

                            try {
                                valor1 = Double.Parse(Console.ReadLine());

                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);
                        
                        Console.WriteLine("");

                        //Validando Segundo Valor
                        do {
                            validador = true;
                            Console.Write("Digite o Segundo Valor da Operação: ");

                            try {
                                valor2 = Double.Parse(Console.ReadLine());

                                if (valor2 == 0)
                                {
                                    throw new DivideByZeroException();
                                }
                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch (DivideByZeroException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);

                        Console.WriteLine("");

                        OperacaoAritmetica divisao = new OperacaoDivisao(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        resultado = new ResultadoOperacao(divisao);
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultado.ExibirResultado()}");

                        break;
                    case "*":
                        do {
                            validador = true;
                            Console.Write("Digite o Primeiro Valor da Operação: ");

                            try {
                                valor1 = Double.Parse(Console.ReadLine());
                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);
                        
                        Console.WriteLine("");

                        //Validando Segundo Valor
                        do {
                            validador = true;
                            Console.Write("Digite o Segundo Valor da Operação: ");

                            try {
                                valor2 = Double.Parse(Console.ReadLine());
                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);

                        Console.WriteLine("");

                        OperacaoAritmetica multiplicacao = new OperacaoMultiplicacao(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        resultado = new ResultadoOperacao(multiplicacao);
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultado.ExibirResultado()}");

                        break;
                    case "^2":
                        do {
                            validador = true;
                            Console.Write("Digite o Primeiro Valor da Operação: ");

                            try {
                                valor1 = Double.Parse(Console.ReadLine());
                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);
                        
                        Console.WriteLine("");

                        //Validando Segundo Valor
                        valor2 = 2;
                        Console.WriteLine("");

                        OperacaoAritmetica potencia2 = new OperacaoPotencia2(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        resultado = new ResultadoOperacao(potencia2);
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultado.ExibirResultado()}");

                        break;
                    case "^x":
                        do {
                            validador = true;
                            Console.Write("Digite o Primeiro Valor da Operação: ");

                            try {
                                valor1 = Double.Parse(Console.ReadLine());
                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);
                        
                        Console.WriteLine("");

                        //Validando Segundo Valor
                        do {
                            validador = true;
                            Console.Write("Digite o Segundo Valor da Operação: ");

                            try {
                                valor2 = Double.Parse(Console.ReadLine());
                            }
                            catch(ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                            catch(FormatException ex)
                            {
                                Console.WriteLine(ex.Message);
                                validador = false;
                            }
                        } while (validador == false);

                        Console.WriteLine("");

                        OperacaoAritmetica potenciaX = new OperacaoPotenciaX(valor1, valor2);

                        //IMPRIMINDO O RESULTADO
                        resultado = new ResultadoOperacao(potenciaX);
                        Console.WriteLine($"[AVISO!] O RESULTADO DA OPERAÇÃO É: {resultado.ExibirResultado()}");

                        break;
                }

                Console.WriteLine("");

                //PERGUNTANDO SE O USUÁRIO DESEJA REALIZAR MAIS OPERAÇÕES
                
                string resposta = "";

                do {
                    Console.WriteLine("Deseja Continuar? [S/N]");

                    try
                    {
                        resposta = Console.ReadLine();

                        if (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
                        {
                            throw new ArgumentException();
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N");
                

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
