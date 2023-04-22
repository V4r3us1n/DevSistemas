using System;

namespace exercicios14_12_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadastrando Nome de Usuário e Senha

            string confirmUserName, confirmPassword;

            Console.Write("Crie seu Nome de Usuário: ");
            string userName = Console.ReadLine();

            Console.Write("Crie sua Senha: ");
            string password = Console.ReadLine();

            Console.WriteLine("Usuário Cadastrado! Por favor, realize login agora! \n\n");

            //Validando Nome

            Console.Write("Insira seu Nome de Usuário: ");
            confirmUserName = Console.ReadLine();

            Console.Write("Insira sua Senha: ");
            confirmPassword = Console.ReadLine();

            if (confirmUserName == userName && confirmPassword == password)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Usuário e Senha CONFIRMADOS!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Você será redirecionado para o site em alguns segundos...");
            }
            else if (confirmUserName != userName && confirmPassword == password)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usuário NÃO CADASTRADO!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Por favor verifique as Informações Inseridas e Tente Novamente!");
            }
            else if (confirmPassword != password && confirmUserName == userName)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Senha INCORRETA!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Por favor verifique as Informações Inseridas e Tente Novamente!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usuário e Senha NÃO CADASTRADOS!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Por favor verifique as Informações Inseridas e Tente Novamente!");
                Console.WriteLine("Ou Realize seu Cadastro em nosso Site!");
            }

        }
    }
}
