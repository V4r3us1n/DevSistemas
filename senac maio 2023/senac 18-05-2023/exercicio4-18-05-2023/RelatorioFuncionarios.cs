using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_18_05_2023
{
    public class RelatorioFuncionarios
    {
        public double TotalSalario {get;set;}
        public void RelatorioDeFuncionarios(Funcionario[] funcionarios)
        {
            for (int i = 0; i < funcionarios.Length; i++)
            {
                Console.WriteLine($"========== FUNCIONÁRIO Nº{i+1} ==========");
                if (funcionarios[i].CNPJ is not null)
                {
                    Console.WriteLine($"CNPJ: {funcionarios[i].CNPJ}");
                }
                else
                {
                    Console.WriteLine($"CPF: {funcionarios[i].CPF}");
                }
                Console.WriteLine($"Nome: {funcionarios[i].Nome}");
                Console.WriteLine($"Tipo de Contrato: {funcionarios[i].TipoContrato}");
                Console.WriteLine($"Cargo: {funcionarios[i].Cargo}");
                Console.WriteLine($"Salário: R${funcionarios[i].Salario}");
                Console.WriteLine($"------------- ENDEREÇO --------------");
                Console.WriteLine($"Rua: {funcionarios[i].Endereco.rua}");
                Console.WriteLine($"Número da Residência: {funcionarios[i].Endereco.numeroResidencia}");
                Console.WriteLine($"Bairro: {funcionarios[i].Endereco.bairro}");
                Console.WriteLine($"Cidade: {funcionarios[i].Endereco.cidade}");
                Console.WriteLine($"UF: {funcionarios[i].Endereco.estado}");
                Console.WriteLine($"-------------------------------------");
                Console.WriteLine("");
            }
        }

        public void RelatorioTotalSalario(Funcionario[] funcionarios)
        {
            for (int i = 0; i < funcionarios.Length; i++)
            {
                TotalSalario += funcionarios[i].Salario;
            }

            Console.WriteLine("=====================================");
            Console.WriteLine($"Total Salário: R${TotalSalario}");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
        }
    }
}