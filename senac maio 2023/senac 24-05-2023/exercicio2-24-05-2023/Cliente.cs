using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio2_24_05_2023
{
    public class Cliente
    {
        public static int NovoIdCliente {get; protected set;}
        public int IdCliente {get; protected set;}
        public string Nome {get;set;}
        public int Idade {get;set;}
        public Endereco Endereco {get;set;}

        public Cliente (string nome, int idade, Endereco endereco)
        {
            Nome =  nome;
            Idade = idade;
            Endereco = endereco;

            //Incrementando Id do Cliente
            NovoIdCliente++;
            IdCliente = NovoIdCliente;
        }
    }
}