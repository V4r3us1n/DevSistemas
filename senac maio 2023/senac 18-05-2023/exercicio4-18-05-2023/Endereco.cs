using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4_18_05_2023
{
    public struct Endereco
    {
        public string rua;
        public int numeroResidencia;
        public string bairro;
        public string cidade;
        public string estado;

        public Endereco (string rua, int numeroResidencia, string bairro, string cidade, string estado)
        {
            this.rua=rua;
            this.numeroResidencia=numeroResidencia;
            this.bairro=bairro;
            this.cidade=cidade;
            this.estado=estado;
        }
        
    }
}