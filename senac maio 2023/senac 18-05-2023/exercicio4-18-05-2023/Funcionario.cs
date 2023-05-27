using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_18_05_2023
{
    public abstract class Funcionario
    {
        public string CPF {get;set;}
        public string CNPJ {get;set;}
        public string Nome {get;set;}
        public string TipoContrato {get;set;}
        public double Salario {get;set;}
        public string Cargo {get;set;}

        public Endereco Endereco {get;set;}

        public Funcionario (string nome, double salario, string tipoContrato)
        {
            Nome = nome;
            Salario = salario;
            TipoContrato = tipoContrato;
        }

        public void AtribuirEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public void AtribuirTipoContrato(string contrato, string identificacao)
        {
            if (contrato is "Pessoa Jurídica")
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