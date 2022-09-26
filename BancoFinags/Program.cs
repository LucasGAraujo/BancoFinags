using BancoFinags.Models;
using static BancoFinags.Crud;
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
            MostrarContas(contas);
            ExibirConta(contas);
            //MostrarContas(contas);
        }


        public static void CriarContas(List<Conta> contas)
        {

            Conta conta = new Conta(2, "João", 200);
            contas.Add(conta);
            conta = new Conta(1, "LP", 0);
            contas.Add(conta);
        }

        public static void MostrarContas(List<Conta> contas)
        {

            foreach (Conta c in contas)
            {
                Console.WriteLine(c);
            }
        }
    }
}
