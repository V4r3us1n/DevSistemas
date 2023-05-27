using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_02_05_2023
{
    public class Correntista
    {
        public long CPF {get;set;}
        public string Nome {get;set;}

        public string Sobrenome {get;set;}

        public double Renda {get;set;}

        public int Idade {get;set;}

        public DateTime DataNascimento {get;set;}
    
	    public Correntista(long cpf, string nome, string sobrenome, double renda, int idade, DateTime dataNascimento)
		{
			CPF = cpf;
			Nome = nome;
			Sobrenome = sobrenome;
			Renda = renda;
			Idade = idade;
			DataNascimento = dataNascimento;
		}
	}
}