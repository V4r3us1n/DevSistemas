using System;

namespace projeto_2_06_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            //Convertendo Valores

            Console.Write("Valor 1: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            //.Convert há mais +18 possiblidades de conversão, porém ela tem seus problemas
            //O "Int32" serve para dizer que ele suporta 32 bits, caso você queira algo maior, basta trocar para "Int64"

            Console.Write("Valor 2: ");
            var valor2 = Int32.Parse(Console.ReadLine());
            //.Parse só suporta caracter, tem q ter string lá dentro, o bom do .Parse é que você já declara para oq vc quer converter, ex: "Int32.Parse"

            Console.Write(valor1 +valor2);

            //O problema deles é que eles conseguem converter apenas números

            */

            /*
            
            OPERADORES ARITMÉTICOS

            int soma = 2 + 2;

            int subtracao = 2 - 2;

            int multiplicacao = 2 * 2;

            int divisao = 2 / 2;

            int resto_divisao = 2 % 2;
            
            */

            /*
            Console.WriteLine("OPERADORES ARITMÉTICOS");

            int soma = 2 + 2;

            int subtracao = 2 - 2;

            int multiplicacao = 2 * 2;

            int divisao = 2 / 2;

            int resto_divisao = 2 % 2;
            Console.WriteLine("\n\n");
            */

            /*
            
            Incremento e Decremento de Valores dentro de variáveis

            Incremento

            c++ (incrementa após a impressão do valor da variável)
            ++c (incrementa antes da impressão do valor da variável)

            Decremento

            c-- (diminui após a impressão do valor da variável)
            --c (diminui antes da impressão do valor da variável)
            
            */

            Console.WriteLine("INCREMENTO NO VALOR DE VARIÁVEIS\n");

            Console.WriteLine("Incremento Após Impressão\n");
            int a = 0;
            Console.Write(a++);
            
            Console.WriteLine("Incremento Antes da Impressão\n");
            int b = 0;
            Console.Write(++b);

            Console.WriteLine("Decremento Após Impressão\n");
            int c = 0;
            Console.Write(c--);

            Console.WriteLine("Decremento Antes da Impressão\n");
            int d = 0;
            Console.Write(--d);

            Console.WriteLine("\n\n");

            /*
            
            OPERADORES RELACIONAIS
            
            IGUAL A (==)

            DIFERENTE DE (!=)

            MAIOR QUE (>)

            MENOR QUE (<)

            MAIOR OU IGUAL A (>=)

            MENOR OU IGUAL A (<=)

            */

            Console.WriteLine("OPERADORES RELACIONAIS\n");

            Console.WriteLine("");

        }
    }
}
