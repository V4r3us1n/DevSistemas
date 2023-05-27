using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2_11_05_2023
{
    public class Programador:Funcionario
    {
        public Programador (string cpf, string nome, double salario) : base(cpf, nome, salario)
        {
            CPF = cpf;
            Nome = nome;
            Salario = salario;
        }

        public override void CalcSalario(double salario)
        {
            salario = Salario;
            salario += (salario*0.01);
            Salario = salario;
            base.CalcSalario(salario);
        }
    }
}