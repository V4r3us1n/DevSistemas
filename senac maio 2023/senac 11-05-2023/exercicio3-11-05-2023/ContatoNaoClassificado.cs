using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio3_11_05_2023
{
    public class ContatoNaoClassificado:Contatos
    {

        public ContatoNaoClassificado (string nome, string telefone, string endereco, string categoriaContato) : base(nome, telefone, endereco, categoriaContato)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            CategoriaContato = categoriaContato;
        }

    }
}