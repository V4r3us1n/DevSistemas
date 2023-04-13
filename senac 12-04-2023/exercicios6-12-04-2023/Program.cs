using System;

namespace exercicios6_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar variavel double valorDaNotaFiscal

            double valorDaNotaFiscal, valorImposto, valorRealImposto;

            Console.Write("Informe o valor da Nota Fiscal... R$");
            valorDaNotaFiscal = Double.Parse(Console.ReadLine());

            //Validando valor...

            while (valorDaNotaFiscal <= 0)
            {
                Console.WriteLine("[ERRO!] Por favor insira um valor positivo!");
                Console.Write("Informe o valor da Nota Fiscal... R$");
                valorDaNotaFiscal = Double.Parse(Console.ReadLine());
            }

            if (valorDaNotaFiscal <= 999)
            {
                valorImposto = 0.02;
            }
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal <= 2999)
            {
                valorImposto = 0.025;
            }
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal <= 6999)
            {
                valorImposto = 0.028;
            }
            else
            {
                valorImposto = 0.03;
            }

            valorRealImposto = valorDaNotaFiscal * valorImposto;

            Console.WriteLine($"Devido ao valor de R${valorDaNotaFiscal} da Nota Fiscal, será cobrado um imposto de {valorImposto * 100}%, o que corresponde a R${valorRealImposto}!");
        }
    }
}
