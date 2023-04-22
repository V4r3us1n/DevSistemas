using System;

namespace exercicios11_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar o Salário do Funcionário

            double salario, aumentoPercentual, aumentoReal, novoSalario;

            Console.Write("Informe seu Salário... R$");
            salario = Double.Parse(Console.ReadLine());

            //Verificando Percentual de Aumento Salarial

            if (salario <= 1280)
            {
                aumentoPercentual = 20;
            }
            else if (salario > 1280 && salario <= 1700)
            {
                aumentoPercentual = 15;
            }
            else if (salario > 1700 && salario <= 2500)
            {
                aumentoPercentual = 10;
            }
            else
            {
                aumentoPercentual = 5;
            }

            //Calculando Porcentagem em Comparação com o Salário Informado...

            aumentoReal = salario * (aumentoPercentual / 100);

            //Calculando Novo Salário

            novoSalario = salario + aumentoReal;

            //Imprimindo Resultado...

            Console.WriteLine($"O Salário informado antes do reajuste era de R$ {salario}");
            Console.WriteLine($"Sofreu um Aumento Percentual de {aumentoPercentual}%");
            Console.WriteLine($"O que corresponde à R${aumentoReal} do Salário!");
            Console.WriteLine($"Após esse aumento, seu Salário passou de R${salario} para R${novoSalario}");
        }
    }
}
