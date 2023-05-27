using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_11_05_2023
{
    public class Funcionario
    {
        public string Nome{get;set;}
        public string Cargo{get;set;}
        public double Salario{get;set;}
        public double PercentualImposto {get;set;}
        public double ValorImposto{get;set;}

        public Funcionario(string nome, string cargo, double salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public virtual void CacularSalario(double salario)
        {
            salario = Salario;

            Salario = salario;
        }

        public void CalcularPercentualSalario(double salario)
        {
            salario = Salario;

            if (salario <= 1903.98)
            {
                PercentualImposto = 0;
            }
            else if (salario <= 2826.65)
            {
                PercentualImposto = 7.5;
            }
            else if (salario <= 3751.05)
            {
                PercentualImposto = 15;
            }
            else if (salario <= 4664.68)
            {
                PercentualImposto = 22.5;
            }
            else
            {
                PercentualImposto = 27.5;
            }
        }

        public void CalcularValorImposto(double salario)
        {
            salario = Salario;

            ValorImposto = (salario/100)*PercentualImposto;
        }

    }
}