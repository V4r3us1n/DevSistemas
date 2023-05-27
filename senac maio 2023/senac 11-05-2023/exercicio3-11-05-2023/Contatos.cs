using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3_11_05_2023
{
    public class Contatos
    {
        public string Nome {get;set;}
        public string Telefone {get;set;}
        public string Endereco {get;set;}
        public string CategoriaContato{get;set;}

        public Contatos (string nome, string telefone, string endereco, string categoriaContato)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            CategoriaContato = categoriaContato;
        }
    }
}