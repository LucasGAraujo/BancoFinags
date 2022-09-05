using BancoFinags.Models;
using System;
using System.Collections.Generic;


namespace BancoFinags
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Conta> contas = new List<Conta>();

            CriarContas(contas);
            MostrarContas(contas);
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
