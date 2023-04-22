using System;

namespace projeto1_05_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("O futuro é pika!");

            //Vai imprimir a data e hora de acordo com o ponto de horário 0 do mundo
            //Console.WriteLine(DateTime.UtcNow);

            //Vai imprimir a data e hora de acordo com o local que estamos
            //Console.WriteLine(DateTime.Now);

            /*
            Console.WriteLine("Este texto não tem cor de fundo!");
            //Mudar a cor do plano de fundo do texto
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Esse texto tem cor de fundo magenta!");

            //Tirando a cor de fundo
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Este texto tem cor de fundo normal novamente!");

            //Mudando a cor do texto
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Esse texto tem cor azul ao invés de branco!");
            */
            /*
            //Inserindo informações no C#

            Console.Write("Escreva seu nome: ");
            string nome = Console.ReadLine(); //Vai ler os dados inseridos
            Console.Write("Escreva seu sobrenome: ");
            string sobreno = Console.ReadLine(); //Vai ler os dados inseridos
            string nome_completo = nome + " " + sobreno;
            Console.WriteLine("\n\n\nOlá Mr. " + nome + " " + sobreno); //"\n" pula uma linha entre uma linha de comando e outra

            //Como ter certeza de que a pessoa vai digitar o nome? Ela pode digitar um número

            byte idade = 19;

            Console.WriteLine("Você tem " + idade + " anos!");

            Console.WriteLine("Aguarde um moemento " + nome_completo + ", estamos carregando seu saldo...");
            double saldo;
            saldo = 50000.89;
            Console.WriteLine("Seu saldo atual é R$" + saldo);

            //Se vc fizer uma divisão quebrada e n colocar casa decimal o resultado será um valor inteiro, veja:

            var n1 = 3 / 4;
            Console.WriteLine(n1);

            //Após uma variavel "var" receber um tipo o mesmo não pode ser trocado!
            //Agora veja se colocarmos casa decimal

            var n2 = 3.00 / 4.00;
            Console.WriteLine(n2);

            //Caso queira declar aruma variavel antes de atribuir um valor a ela vc precisa especificar o tipo dela, veja:

            string nomes;

            //Para inserir valores imutáveis em variáveis vc usa o "const" antes da variável e seu tipo, não pode usar "const var nome" mas sim "const string nome";

            const string sobrenome = "kakakaka";

            //Sempre que você for usar o "const" vc tem q inserir o valor a ela;
            */

            string nome = "Jão";
            string sobrenome = "Silva";
            var fraseOla = "Olá tudo bem?";
            Console.WriteLine(fraseOla + " " + nome + " " + sobrenome);

            var fraseCompleta = fraseOla + " " + nome + " " + sobrenome;

            Console.WriteLine(fraseCompleta);

            //Para realizar a concatenação podemos usar a própria biblioteca do C#, ou seja:

            var fraseCompleta2 = $"{fraseOla} {nome} {sobrenome}";

            Console.WriteLine(fraseCompleta2);

            //Oq fizemos acima se chama INTERPOLAÇÃO, podemos adicionar ainda mais strings caso a gente queira!

        }
    }
}
