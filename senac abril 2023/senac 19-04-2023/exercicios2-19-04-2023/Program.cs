using System;

namespace exercicios2_19_04_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando a Senha...

            int nLetrasMaiusculas = 0, nLetrasMinusculas = 0, nNumeros = 0, nCaractEspec = 0, charSenhaToInt;
            string senha;

            Console.Write("Insira sua senha... ");
            senha = Console.ReadLine();

            //Validando Senha

            for (int i = 0; i < senha.Length; i++) {
                charSenhaToInt = (int)senha[i];

                if (charSenhaToInt > 47 && charSenhaToInt < 58)
                {
                    nNumeros++;
                }
                else if (charSenhaToInt > 64 && charSenhaToInt < 91)
                {
                    nLetrasMaiusculas++;
                }
                else if (charSenhaToInt > 96 && charSenhaToInt < 123)
                {
                    nLetrasMinusculas++;
                }
                else
                {
                    nCaractEspec++;
                }
            }

            //Exibindo Resultado de acordo com a TABELA ASCII

            Console.WriteLine($"Senha: {senha}");
            Console.WriteLine($"Letras Maiúsculas: {nLetrasMaiusculas}");
            Console.WriteLine($"Letras Minúsculas: {nLetrasMinusculas}");
            Console.WriteLine($"Numeros: {nNumeros}");
            Console.WriteLine($"Caracteres Especiais: {nCaractEspec}");
            
        }
    }
}
