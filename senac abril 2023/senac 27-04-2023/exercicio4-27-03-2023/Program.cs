using System;

namespace exercicio4_27_03_2023
{
    class Program
    {
        static int nSorteios, i = 0;
        static void Main(string[] args)
        {
            //Solicitando Numero de Sorteios
            string continuarSorteio = "";
		
		    Console.Write("Digite Entre Quantos Números será realizado o Sorteio: ");
		    nSorteios = Int32.Parse(Console.ReadLine());
		    ValidarNSorteios();
            Console.WriteLine("");
		
		    string[,] sorteioDataHora = new string[1, 3];
		
		    //Realizando Sorteios

            do {
                continuarSorteio = "não";

                if (i <= nSorteios)
                {
                    Console.WriteLine($"{i+1}º Sorteio Realizado com Sucesso!");
                    Console.WriteLine("");

                    SortearNumero(ref sorteioDataHora);

                    Console.Write("Deseja continuar os Sorteios? ");
                    continuarSorteio = Console.ReadLine();

                    if (continuarSorteio.ToLower() == "sim")
                    {
                        AumentarTamanhoMatriz(ref sorteioDataHora);

                        i++;
                    }
                }
            } while (continuarSorteio.ToLower() == "sim");
		
		    //Imprimindo Resultados
		
		    for (int j = 0; j <= nSorteios; j++)
		    {
		        Console.WriteLine($"Sorteio N°{j+1} --> Valor Sorteado: {sorteioDataHora[j,0]} - Data do Sorteio: {sorteioDataHora[j,1]} - Hora do Sorteio: {sorteioDataHora[j,2]}");
		    }
	    }

        static void AumentarTamanhoMatriz(ref string[,] matriz)
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
	
	    static void SortearNumero(ref string[,] matriz)
	    {
		    int verificador;
		
		    do {
	            Random rNumero = new Random();
		
		        matriz[i,0] = $"{rNumero.Next(0,nSorteios + 1)}";
		        verificador = ValidarNumero(ref matriz);
		        var data = DateTime.Now;
		
		        matriz[i,1] = data.ToString("dd/MM/yyyy");
		        matriz[i,2] = data.ToString("HH:mm:ss");
		    } while (verificador > 1);
	    }
	
	    static int ValidarNumero(ref string[,] matriz)
	    {
		    int verificador = 0;
		
	        for (int k = 0; k <= i; k++)
		    {
		        if (matriz[k,0] == matriz[i,0])
			    {
			        verificador++;
			    }
		    }
		
		    return verificador;
	    }
	
	    static void ValidarNSorteios()
	    {
	        while (nSorteios < 1)
	        {
	            Console.WriteLine("[ERRO!] Por favor digite um Número Maior que 0!");
		   
		        Console.Write("Digite a Quantidade de Sorteios a serem Realizados (entre 1 e 100): ");
		        nSorteios = Int32.Parse(Console.ReadLine());
            }
	    }
    }
}
