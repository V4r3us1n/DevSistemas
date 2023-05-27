using System;
using System.Globalization;

namespace exercicio2_27_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar Nome da Cidade

            string cidade;

            Console.Write("Digite o Nome da Cidade: ");
            cidade = Console.ReadLine();

            var data = DateTime.Now;
            string mesNome = "", diaSemana = $"{data.DayOfWeek}";

            var idioma = new CultureInfo("pt-BR");
            var dtfi = idioma.DateTimeFormat;

            //Imprimindo Resultado:

            Console.WriteLine("Exibindo Resultado Usando CultureInfo");
            Console.WriteLine($"{cidade}, {data.ToString("dd")} de {dtfi.GetMonthName(data.Month)} de {data.Year}. Hoje é {dtfi.GetDayName(data.DayOfWeek)} as {data.ToString("HH:mm:ss")}");
        
            Console.WriteLine("Exibindo Resultado Sem Usar o CultureInfo");

            switch ($"{data.DayOfWeek}")
            {
                case "Sunday":
                    diaSemana = "domingo";
                    break;
                case "Monday":
                    diaSemana = "segunda-feira";
                    break;
                case "Tuesday":
                    diaSemana = "terça-feira";
                    break;
                case "Wednesday":
                    diaSemana = "quarta-feira";
                    break;
                case "Thursday":
                    diaSemana = "quinta-feira";
                    break;
                case "Friday":
                    diaSemana = "sexta-feira";
                    break;
                case "Saturday":
                    diaSemana = "sábado";
                    break;
            }

            switch(data.Month)
            {
                case 1:
                    mesNome = "Janeiro";
                    break;
                case 2:
                    mesNome = "Fevereiro";
                    break;
                case 3:
                    mesNome = "Março";
                    break;
                case 4:
                    mesNome = "Abril";
                    break;
                case 5:
                    mesNome = "Maio";
                    break;
                case 6:
                    mesNome = "Junho";
                    break;
                case 7:
                    mesNome = "Julho";
                    break;
                case 8:
                    mesNome = "Agosto";
                    break;
                case 9:
                    mesNome = "Setembro";
                    break;
                case 10:
                    mesNome = "Outubro";
                    break;
                case 11:
                    mesNome = "Novembro";
                    break;
                case 12:
                    mesNome = "Dezembro";
                    break;
            }

            Console.WriteLine($"{cidade}, {data.ToString("dd")} de {mesNome} de {data.Year}. Hoje é {diaSemana} as {data.ToString("HH:mm:ss")}");

        }
    }
}
