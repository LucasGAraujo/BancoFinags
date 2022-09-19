using BancoFinags.Models;
using BancoFinags
using System;
using System.Collections.Generic;


namespace BancoFinags
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>();

            CriarContas(contas);
            IncluirConta(contas);
            MostrarContas(contas);
            
        }

        public static void IncluirConta(List<Conta> contas)
        {
            int num = Utils.EntrarNumero();
            string nome = Utils.EntrarNome();
            double saldo = Utils.EntrarSaldo();
            contas.Add(new Conta(num, nome, saldo));
        }
        public static void AlterarConta()
        {

        }
        public static void ExcluirConta()
        { 

        }
        public static void ExibirConta()
        {

        }

        
        public static void CriarContas(List<Conta> contas) 
        {
            Conta conta = new Conta(1, "Lucas", 2000);
            contas.Add(conta);
            conta = new Conta(2, "JmDelas", 2000);
            contas.Add(conta);
        }
        public static void  MostrarContas(List<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
