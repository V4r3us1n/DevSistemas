using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2_17_05_2023
{
    public class FuncionarioProgramador : Funcionario
    {
        public FuncionarioProgramador(string cpf, string nome) : base(cpf, nome)
        {
            CPF = cpf;
            Nome = nome;
        }

        public override string DefinirCargo()
        {
            Cargo = "Programador";

            return Cargo;
        }

        public override double CalcularSalario(double salario)
        {
            Salario = salario + (salario * 0.01);

            return Salario;
        }
    }
}