using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3_11_05_2023
{
    public class ContatoTrabalho:Contatos
    {
        
        public ContatoTrabalho (string nome, string telefone, string endereco, string categoriaContato) : base(nome, telefone, endereco, categoriaContato)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            CategoriaContato = categoriaContato;
        }

    }
}