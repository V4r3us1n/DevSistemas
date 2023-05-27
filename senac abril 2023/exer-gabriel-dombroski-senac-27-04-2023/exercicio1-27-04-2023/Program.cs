using System;
using System.Globalization;

namespace exercicio1_27_04_2023
{
    class Program
    {
        static int dia, mes = 0, ano = 0;
        static void Main(string[] args)
        {
            //Solicitar Valores: Dia, Mês e Ano

            Console.Write("Informe o Dia: ");
            dia = Int32.Parse(Console.ReadLine());
            ValidarDia();

            Console.Write("Informe o Mês: ");
            mes = Int32.Parse(Console.ReadLine());
            ValidarMes();

            Console.Write("Informe o Ano: ");
            ano = Int32.Parse(Console.ReadLine());
            ValidarDia();

            DateTime data = new DateTime(ano, mes, dia);

            //Exibindo Data Simplificada:

            Console.WriteLine("Processando so Dados...");
            Console.WriteLine("");

            Console.WriteLine($"Data Simplificada: {data.ToString("dd/MM/yyyy")}");
            Console.WriteLine("");


            //Exibindo Data Completa (Por Extenso):

            var idioma = new CultureInfo("pt-BR");

            var dtfi = idioma.DateTimeFormat;

            Console.WriteLine($"Data Por Extenso: {data.Day} de {idioma.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month))} de {data.Year}");
            Console.WriteLine("");

        }

        static void ValidarDia()
        {
            if (mes == 0 || mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes ==12)
            {
                while (dia < 0 || dia > 31)
                {
                    Console.WriteLine("[ERRO!] Data Inválida!");

                    Console.Write("Informe o Dia: ");
                    dia = Int32.Parse(Console.ReadLine());
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                while (dia < 0 || dia > 30)
                {
                    Console.WriteLine("[ERRO!] Data Inválida!");
                    Console.WriteLine("Possivelmente esse Dia não existe no Mês Procurado!");

                    Console.Write("Informe o Dia: ");
                    dia = Int32.Parse(Console.ReadLine());
                }
            }
            else
            {
                if (ano % 4 == 0)
                {
                    while (dia < 0 || dia > 29)
                    {
                        Console.WriteLine("[ERRO!] Data Inválida!");
                        Console.WriteLine("Possivelmente esse Dia não existe no Mês Procurado!");

                        Console.Write("Informe o Dia: ");
                        dia = Int32.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    while (dia < 0 || dia > 28)
                    {
                        Console.WriteLine("[ERRO!] Data Inválida!");
                        Console.WriteLine("Possivelmente esse Dia não existe no Mês Procurado!");

                        Console.Write("Informe o Dia: ");
                        dia = Int32.Parse(Console.ReadLine());
                    }
                }
            }
        }
    
        static void ValidarMes()
        {
            while (mes < 0 || mes > 12)
            {
                Console.WriteLine("[ERRO!] Mês Inválido!");

                Console.Write("Informe o Mês: ");
                mes = Int32.Parse(Console.ReadLine());
            }

            ValidarDia();
        }
    }
}
