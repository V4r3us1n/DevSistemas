using System;

namespace exercicios4_19_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int nEspacos = 0, limitePalavra = 0, novaPalavra = 0;

            //Criando Dicionário

            string[] dicionario = {"olá", "mundo", "boa tarde", "boa noite"};

            //Solicitando ao Usuário uma Frase...

            Console.WriteLine("Escreva uma frase a baixo...");
            frase = Console.ReadLine();
            frase = frase.ToLower();

            //Calculando Quantidade de Espaços

            for (int i = 0; i < frase.Length; i++) {
                if ($"{frase[i]}" == " ")
                {
                    nEspacos++;
                }
            }

            //Console.WriteLine($"Número de Espaços: {nEspacos}");

            //Separando Palavras da Frase

            string[] palavrasFrase = new string[nEspacos + 1];

            for (int i = 0; i < frase.Length; i++) {
                if ($"{frase[i]}" == " ")
                {
                    for (int c = limitePalavra; c < i; c++) {
                        palavrasFrase[novaPalavra] += frase[c];
                    }
                    limitePalavra = i + 1;
                    novaPalavra++;
                }
                else if (i == frase.Length - 1)
                {
                    for (int c = limitePalavra; c <= i; c++) {
                        palavrasFrase[novaPalavra] += frase[c];
                    }
                    limitePalavra = i + 1;
                    novaPalavra++;
                }
            }


            //Comparando Palavras Digitadas com o Dicionário...

            int nPalavrasEncontradas = 0;

            for (int i = 0; i < palavrasFrase.Length; i++) {
                //Console.WriteLine($"Procurando a Palavra '{palavrasFrase[i]}' no Dicionário... ");

                for (int c = 0; c < dicionario.Length; c++) {
                    if (palavrasFrase[i] == dicionario[c])
                    {
                        nPalavrasEncontradas++;
                    }
                    //Verificando se Existe as Palavras "Boa Tarde" ou "Boa Noite" dentro da Frase Digitada
                    else if (palavrasFrase[i] == "boa")
                    {
                        if ($"{palavrasFrase[i]} {palavrasFrase[i + 1]}" == dicionario[c])
                        {
                            nPalavrasEncontradas++;
                        }  
                    }
                }
            }

            //Imprimindo Resultado
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("EXIBINDO RESULTADO");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine($"Foram encontradas, ao todo, {nPalavrasEncontradas} palavras dessa frase no Dicionário!");
            Console.WriteLine("");

        }
    }
}
