using System;

namespace exercicios2_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando as Variáveis

            int numeroInteiro = 10;

            decimal numeroDecimal = 23.5m;

            string numeroEmString = "78";

            double numeroDouble = 3.71;

            //Convertendo as Variáveis

            //Inteiro para Decimal
            decimal intParaDecimal = Convert.ToDecimal(numeroInteiro);

            Console.WriteLine($"Foi convertido o valor {intParaDecimal} de Int para Decimal!\n");

            //Decimal para Inteiro
            int decimalParaInt = Convert.ToInt32(numeroDecimal);

            Console.WriteLine($"Foi convertido o valor {decimalParaInt} de Decimal para Int!\n");

            //String para Inteiro
            int stringParaInt = Convert.ToInt32(numeroEmString);

            Console.WriteLine($"Foi convertido o valor {stringParaInt} de String para Int!\n");

            //String para Decimal
            decimal stringParaDecimal = Convert.ToDecimal(numeroEmString);

            Console.WriteLine($"Foi convertido o valor {stringParaDecimal} de String para Decimal!\n");

            //Double para Decimal
            decimal doubleParaDecimal = Convert.ToDecimal(numeroDouble);

            Console.WriteLine($"Foi convertido o valor {doubleParaDecimal} de Double para Decimal!\n");

        }
    }
}
