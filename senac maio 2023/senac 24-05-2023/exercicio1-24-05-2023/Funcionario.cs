using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_24_05_2023
{
    public abstract class Funcionario
    {
        public string CPF {get;set;}
        public string CNPJ {get;set;}
        public string Nome {get;set;}
        public string TipoContrato {get; protected set;}
        public double Salario {get; protected set;}
        public string Cargo {get; protected set;}
        public int IdFuncionario {get; protected set;}
        public static int NovoIdFuncionario {get; protected set;}

        public Endereco Endereco {get;set;}

        public Funcionario (string nome, double salario, string tipoContrato)
        {
            Nome = nome;
            Salario = salario;
            TipoContrato = tipoContrato;
            NovoIdFuncionario++;
            IdFuncionario = NovoIdFuncionario;
        }

        public void AtribuirEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void AtribuirTipoContrato(string contrato, string identificacao)
        {
            if (contrato == "Pessoa Jurídica")
            {
                CNPJ = identificacao;
            }
            else
            {
                CPF = identificacao;
            }
        }
    }
}