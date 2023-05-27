using System;

namespace projeto_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe é a base para a criação de um Objeto

            var conta = new Conta();

            conta.numero = 1;
            conta.correntista = "João Mendes";
            conta.saldo = 1250;

            Console.WriteLine(conta.numero);
            Console.WriteLine(conta.correntista);
            Console.WriteLine(conta.saldo);

            double valorSaque = -200;

            conta.Sacar(valorSaque);

            conta.ValidarValor(ref valorSaque);

            double valorDeposito = -500;

            conta.ValidarValor(ref valorDeposito);
            
            Console.WriteLine(conta.saldo);

            conta.Depositar(valorDeposito);

            Console.WriteLine(conta.saldo);
        }
    }

    public class Conta
    {
        public int numero;
        public string correntista;
        public double saldo;

        public void Sacar(double valorSaque)
        {
            if (valorSaque <= saldo)
            {
                saldo -= valorSaque;
            }
        }

        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }

        public void ValidarValor(ref double valor)
        {
            while (valor <= 0)
            {
                Console.WriteLine("[ERRO!] Você não pode inserir valores infeiriores, ou iguais, a ZERO!");

                Console.WriteLine("Insira um Novo Valor: ");
                valor = Double.Parse(Console.ReadLine());
            }
        }//clicar na variável e pressionar F2 renomea o nome da variável em todos os lugares em que ela é usada
    }
}
