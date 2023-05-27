using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_24_05_2023
{
    public class Suporte : Funcionario, INomearCargo
    {
        public Suporte (string nome, double salario, string tipoContrato) : base(nome, salario, tipoContrato)
        {
            Nome = nome;
            Salario = salario;
            TipoContrato = tipoContrato;
        }

        public void NomearCargo()
        {
            Cargo = "Suporte";
        }

        public void CalcularSalario()
        {
            if (TipoContrato == "Pessoa Jurídica")
            {
                Salario = (Salario*1.005)*1.3;
            }
            else
            {
                Salario = Salario*1.005;
            }
        }

    }
}