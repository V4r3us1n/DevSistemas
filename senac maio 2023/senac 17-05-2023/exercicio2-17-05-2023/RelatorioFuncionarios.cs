using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2_17_05_2023
{
    public class RelatorioFuncionarios
    {
        public double Salario {get;set;}
        public double TotalSalario {get;set;}

        public RelatorioFuncionarios (double salario)
        {
            Salario = salario;
        }
        public void ExibirRelatorioFuncionarios(Funcionario[] funcionarios)
        {
            Console.WriteLine("============== EXBINDO RELATÓRIO FUNCIONÁRIOS ===============");
            Console.WriteLine("");

            for (int i = 0; i < funcionarios.Length; i++)
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine($"Funcionário Nº{i+1}");
                Console.WriteLine("");
                Console.WriteLine($"CPF: {funcionarios[i].CPF}");
                Console.WriteLine($"Nome: {funcionarios[i].Nome}");
                Console.WriteLine($"Cargo: {funcionarios[i].DefinirCargo()}");
                Console.WriteLine($"Salário: R${funcionarios[i].CalcularSalario(Salario)}");
                Console.WriteLine("----------------------------------------------------------");
            }
        }

        public double CalcTotalSalario(Funcionario[] funcionarios, double salario)
        {
            for (int i = 0; i < funcionarios.Length; i++)
            {
                TotalSalario += funcionarios[i].CalcularSalario(salario);
            }

            return TotalSalario;
        }
    }
}