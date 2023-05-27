using System;

namespace exercicio3_27_04_2023
{
    class Program
    {
        static int i = 0;
        
        static void Main(string[] args)
        {

            //Sortear um Número de 0 a 100

            string verificador = "";
            string[,] sorteioDataHora = new string[1, 3];
            
            Console.Write("Deseja Realizar um Sorteio? ");
            verificador = Console.ReadLine();

            while (verificador.ToLower() == "sim")
            {
                Console.WriteLine($"Realizando {i+1}º Sorteio!");

                Random nRandom = new Random();
                int numeroRandom = nRandom.Next(0, 101);
                var data = DateTime.Now;

                //Armazenando Sorteio
                sorteioDataHora[i, 0] = $"{numeroRandom}";

                //Armazenando Data do Sorteio
                sorteioDataHora[i, 1] = data.ToString("dd/MM/yyyy");

                //Armazenando Hora do Sorteio
                sorteioDataHora[i, 2] = data.ToString("HH:mm:ss");


                Console.Write("Deseja Realizar mais um Sorteio? ");
                verificador = Console.ReadLine();

                if (verificador.ToLower() == "sim")
                {
                    AumentarMatriz(ref sorteioDataHora);

                    i++;
                }

            }

            Console.WriteLine("");
            Console.WriteLine("");

            //IMPRIMINDO SORTEIOS

            for (int j = 0; j <= i; j++)
            {
                Console.WriteLine($"Sorteio Nº{j+1} => Data: {sorteioDataHora[j,1]} - Hora: {sorteioDataHora[j,2]} - Nº Sorteado: {sorteioDataHora[j,0]}");
            }
        }

        static void AumentarMatriz(ref string[,] matriz)
        {
            string[,] matrizTemp = new string[i + 2, 3];

            for (int j = 0; j <= i; j++)
            {
                matrizTemp[j, 0] = matriz[j, 0];
                matrizTemp[j, 1] = matriz[j, 1];
                matrizTemp[j, 2] = matriz[j, 2];
            }

            matriz = matrizTemp;
        }
    }
}
