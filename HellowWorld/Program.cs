using System;

//Cria o namespace do projeto
namespace HellowWorld
{
    //Escopo do namespace
    class Program
    {
        //Tudo oq a classe possui
        static void Main(string[] args)
        {
            //Oq o metodo faz
            Console.Write("Data / Hora");
            //Chamando DateTime com C#
            Console.WriteLine(DateTime.Now);
            //DateTime.Now irá exibir o horário certo no lugar que estamos;
            //DateTime.UtcNow exibe o horário de acordo com o ponto horário zero do mundo
        }
    }
}
