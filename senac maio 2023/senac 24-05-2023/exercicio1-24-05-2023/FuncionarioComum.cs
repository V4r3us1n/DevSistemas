using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_24_05_2023
{
    public class FuncionarioComum : Funcionario, INomearCargo
    {
        public FuncionarioComum (string nome, double salario, string tipoContrato) : base(nome, salario, tipoContrato)
        {
            Nome = nome;
            Salario = salario;
            TipoContrato = tipoContrato;
        }

        public void NomearCargo()
        {
            Cargo = "Funcionário Comum";
        }

        public void CalcularSalario()
        {
            if (TipoContrato == "Pessoa Jurídica")
            {
                Salario = Salario*1.3;
            }
            else
            {
                Salario = Salario;
            }
        }

    }
}