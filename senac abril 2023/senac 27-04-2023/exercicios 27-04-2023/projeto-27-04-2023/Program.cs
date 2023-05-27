using System;

namespace projeto_27_04_2023
{
    class Program
    {
        public class Contato
        {
            public string nome;
            public string endereco;
            public string telefone;
        }

        static void Main(string[] args)
        {
            Contato[] contatos = new Contato[1];

            string verificador = "";
            int i = 0;
            
            
            do {
                Console.Write("Nome: ");
                contatos[i].nome = Console.ReadLine();

                Console.Write("Endereço: ");
                contatos[i].endereco = Console.ReadLine();

                Console.Write("Telefone: ");
                contatos[i].telefone = Console.ReadLine();

                Console.Write("Deseja Continaur Inserindo Contatos? ");
                verificador = Console.ReadLine();

                if (verificador.ToLower() == "sim")
                {
                    Contato[] contatosTemp = new Contato[contatos.Length + 1];

                    for (int j = 0; j < contatos.Length; j++)
                    {
                        contatosTemp[j].nome = contatos[j].nome;
                        contatosTemp[j].endereco = contatos[j].endereco;
                        contatosTemp[j].telefone = contatos[j].telefone;
                    }

                    contatos = contatosTemp;

                    i++;
                }

            } while (verificador.ToLower() == "sim");

            Console.WriteLine("");
            Console.WriteLine("IMPRIMINDO CONTATOS:");
            Console.WriteLine("");
            Console.WriteLine("====================================================================================");

            for (int j = 0; j < contatos.Length; j++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Nome: {contatos[j].nome} - Endereço: {contatos[j].endereco} - Telefone: {contatos[j].telefone}");
                Console.WriteLine("");
                Console.WriteLine("====================================================================================");
            }
            Console.WriteLine("");
            Console.WriteLine("FIM DO PROGRAMA!");

            /*
            Console.Write("Nome: ");
            c1.nome = Console.ReadLine();

            Console.Write("Endereço: ");
            c1.endereco = Console.ReadLine();

            Console.Write("Telefone: ");
            c1.telefone = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine($"Nome: {c1.nome} - Endereço: {c1.endereco} - Telefone: {c1.telefone}");
            */

        }
    }
}
