using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercico1_02_05_2023
{
    public class Conta
    {
        public int[] numero = new int[1];
        public string[] correntista = new string[1];
        public double[] saldo = new double[1];
        public int i = 0;

        public void CriarConta()
        {
            Console.WriteLine($"Estamos no índice {i}...");
            if (i > 0)
            {
                AumentarTamanhoCadastro();
            }

            Console.WriteLine($"O tamanho atual dos arrays é {numero.Length}");

            numero[i] = i+1;

            Console.Write("Informe o Nome do Dono da Conta: ");
            correntista[i] = Console.ReadLine();

            Console.Write("Informe o Saldo da Conta: R$");
            saldo[i] = Double.Parse(Console.ReadLine());

            Console.WriteLine("CONTA CADASTRADA COM SUCESSO!");
            Console.WriteLine("");

            if (i != -1)
            {
                i++;
            }
        }

        public void AumentarTamanhoCadastro()
        {
            int[] numeroTemp = new int[numero.Length+1];
            string[] correntistaTemp = new string[correntista.Length+1];
            double[] saldoTemp = new double[saldo.Length+1];

            for (int j = 0; j < numero.Length; j++)
            {
                numeroTemp[j] = numero[j];
                correntistaTemp[j] = correntista[j];
                saldoTemp[j] = saldo[j];
            }

            numero = numeroTemp;
            correntista = correntistaTemp;
            saldo = saldoTemp;
        }

        public string[] ExibirCadastros()
        {
            string[] exibirContas = new string[i+1];
            for (int j = 0; j < numero.Length; j++)
            {
                exibirContas[j] = $"Conta Nº{j+1} - Correntista: {correntista[j]} - Saldo: R${saldo[j]}";
            }

            return exibirContas;
        }

        public void Sacar()
        {

            Console.Write("Informe o Nº da Conta: ");
            int consultarNConta = Int32.Parse(Console.ReadLine());
            
            int verificador = 0;

            for (int j = 0; j < numero.Length; j++)
            {
                if (numero[j] == consultarNConta)
                {
                    verificador++;
                }
            }

            consultarNConta -= 1;

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] Conta Não Encontrada!");
                Console.WriteLine("");
            }
            else
            {
                Console.Write("Informe o Valor que Deseja Sacar: R$");
                double valorSaque = Double.Parse(Console.ReadLine());

                if (valorSaque > saldo[consultarNConta] || valorSaque < 0)
                {
                    Console.WriteLine("[ERRO!] Valor Inválido e/ou Você Não Possui esse Dinheiro para Saque!");
                    Console.WriteLine("NÃO FOI POSSÍVEL REALIZAR O SAQUE!");
                    Console.WriteLine("");
                }
                else
                {
                    saldo[consultarNConta] -= valorSaque;
                    Console.WriteLine("SAQUE REALIZADO COM SUCESSO!");
                    Console.WriteLine("");
                }
            }
        }

        public void Depositar()
        {
            Console.Write("Informe o Nº da Conta: ");
            int consultarNConta = Int32.Parse(Console.ReadLine());
            
            int verificador = 0;

            for (int j = 0; j < numero.Length; j++)
            {
                if (numero[j] == consultarNConta)
                {
                    verificador++;
                }
            }

            consultarNConta -= 1;

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] Conta Não Encontrada!");
                Console.WriteLine("");
            }
            else
            {
                Console.Write("Informe o Valor que Deseja Depositar: R$");
                double valorDeposito = Double.Parse(Console.ReadLine());

                if (valorDeposito < 0)
                {
                    Console.WriteLine("[ERRO!] Valor Inválido!");
                    Console.WriteLine("NÃO FOI POSSÍVEL REALIZAR O DEPÓSITO!");
                    Console.WriteLine("");
                }
                else
                {
                    saldo[consultarNConta] += valorDeposito;
                    Console.WriteLine("DEPÓSITO REALIZADO COM SUCESSO!");
                    Console.WriteLine("");
                }
            }
        }

        public void Transferir()
        {
            Console.Write("Informe o Nº da Conta: ");
            int consultarNConta = Int32.Parse(Console.ReadLine());
            
            int verificador = 0;

            for (int j = 0; j < numero.Length; j++)
            {
                if (numero[j] == consultarNConta)
                {
                    verificador++;
                }
            }

            consultarNConta -= 1;

            if (verificador == 0)
            {
                Console.WriteLine("[ERRO!] Conta Não Encontrada!");
                Console.WriteLine("");
            }
            else
            {
                verificador = 0;

                Console.Write("Informe o Nº da Conta para a qual você Deseja Realizar a Tranferência: ");
                int consultarNConta2 = Int32.Parse(Console.ReadLine());

                for (int j = 0; j < numero.Length; j++)
                {
                    if (numero[j] == consultarNConta2)
                    {
                        verificador++;
                    }
                }

                if (consultarNConta == consultarNConta2)
                {
                    verificador++;
                }

                consultarNConta2 -= 1;

                if (verificador == 0)
                {
                    Console.WriteLine("[ERRO!] Conta Não Encontrada!");
                    Console.WriteLine("");
                }
                else if (verificador > 1)
                {
                    Console.WriteLine("[ERRO!] VOCÊ NÃO PODE TRANSFERIR PARA A MESMA CONTA!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write("Informe o Valor que Deseja Transferir: R$");
                    double valorTransferencia = Double.Parse(Console.ReadLine());

                    if (valorTransferencia > saldo[consultarNConta] || valorTransferencia < 0)
                    {
                        Console.WriteLine("[ERRO!] Valor Inválido e/ou Você Não Possui esse Dinheiro para Transferência!");
                        Console.WriteLine("NÃO FOI POSSÍVEL REALIZAR A TRANSFERÊNCIA!");
                    }
                    else
                    {
                        saldo[consultarNConta] -= valorTransferencia;
                        saldo[consultarNConta2] += valorTransferencia;
                        Console.WriteLine("TRANSFERÊNCIA REALIZADA COM SUCESSO!");
                        Console.WriteLine("");
                    }
                }                
            }
        }
    }
}