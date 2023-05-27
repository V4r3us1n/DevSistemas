using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio1_10_05_2023
{
    public class Aluno
    {
        public long Matricula {get;set;}
        public string Nome {get;set;}
        public double Nota1 {get;set;}
        public double Nota2 {get;set;}
        public double Nota3 {get;set;}
        public double Nota4 {get;set;}
        public double Media{get;set;}
        public string SituacaoAluno {set;get;}

        public Aluno (long matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

    }
}