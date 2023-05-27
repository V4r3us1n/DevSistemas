using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_24_05_2023
{
    public class Programador : Funcionario, INomearCargo
    {
        public Programador (string nome, double salario, string tipoContrato) : base(nome, salario, tipoContrato)
        {
            Nome = nome;
            Salario = salario;
            TipoContrato = tipoContrato;
        }

        public void NomearCargo()
        {
            Cargo = "Programador";
        }

        public void CalcularSalario()
        {
            if (TipoContrato == "Pessoa Jurídica")
            {
                Salario = (Salario*1.01)*1.3;
            }
            else
            {
                Salario = Salario*1.01;
            }
        }
    }
}