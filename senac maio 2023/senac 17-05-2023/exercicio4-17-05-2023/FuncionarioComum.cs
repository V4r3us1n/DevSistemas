using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_17_05_2023
{
    public class FuncionarioComum : Funcionario
    {
        public FuncionarioComum (string cpf, string nome) : base(cpf, nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public override string DefinirCargo()
        {
            Cargo = "Funcionário Comum";

            return Cargo;
        }

        public override double CalcSalario(double salario)
        {
            Salario = salario * 1;

            return Salario;
        }

        public override double CalcImposto()
        {
            if (Salario <= SalarioF0)
            {
                Imposto = 0;
            }
            else if (Salario <= SalarioF1)
            {
                Imposto = (Salario - SalarioF0) * 0.075;
            }
            else if (Salario <= SalarioF2)
            {
                Imposto = (Salario - SalarioF1) * 0.15 + (SalarioF1 - SalarioF0) * 0.075;
            }
            else if (Salario <= SalarioF3)
            {
                Imposto = (Salario - SalarioF2) * 0.225 + (SalarioF2 - SalarioF1) * 0.15 + (SalarioF1 - SalarioF0) * 0.075;
            }
            else {
                Imposto = (Salario - SalarioF3) * 0.275 + (SalarioF3 - SalarioF2) * 0.225 + (SalarioF2 - SalarioF1) * 0.15 + (SalarioF1 - SalarioF0) * 0.075;
            }

            return Imposto;
        }
    }
}