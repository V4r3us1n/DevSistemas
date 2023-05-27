using System;

namespace rascunho_mic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja inserir os dados coletados de um cidadão para o pré sensu? Sim/Não");
            double [] salarios = new double [1];
            double somasalarios = 0.0;
            int nfilhos = 0;
            int totfilhos = 0;
            double maiorsalario = 0.0;
            double menorsalario = 1000000000.0;
            int npessoas = 0;
            var ler = Console.ReadLine();
            ler = ler.ToLower();
            Console.WriteLine(ler);
            if (ler == "sim")
            {
                Console.Write("Informe o salário da pessoa 1: R$ ");
                ler = Console.ReadLine();
                salarios[0] = Convert.ToDouble(ler);
                Console.WriteLine("Informe o número de filhos da pessoa 1: ");
                ler = Console.ReadLine();
                nfilhos = Convert.ToInt32(ler);
                totfilhos = somafilhos(ref totfilhos,nfilhos);
                npessoas++;
                Console.Write("Caso deseje encerrar a inserção de dados para o pré sensu escreva (Sair): ");
                ler = Console.ReadLine();
                ler = ler.ToLower();
                while (ler != "sair")
                {
                    double [] tempsalarios = new double [salarios.Length+1];
                    salarios = tempsalarios;
                    Console.Write("Informe o salário da pessoa 1: R$ ");
                    ler = Console.ReadLine();
                    salarios[npessoas] = Convert.ToDouble(ler);
                    Console.WriteLine("Informe o número de filhos da pessoa 1: ");
                    ler = Console.ReadLine();
                    nfilhos = Convert.ToInt32(ler);
                    totfilhos = somafilhos(ref totfilhos,nfilhos);
                    npessoas++;
                    Console.Write("Caso deseje encerrar a inserção de dados para o pré sensu escreva (Sair): ");
                    ler = Console.ReadLine();
                    ler = ler.ToLower();
                }
            } else
            {
                Console.WriteLine("Ok...");
            }
            
        {
            
        }
        }
        static int somafilhos(ref int v1, int v2)
        {
            v1 = v1 + v2;
            return v1;
        }
    }
}
