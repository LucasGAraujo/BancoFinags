using System;

namespace BancoFinags
{
    public class Utils
    {
        public static int EntrarNumero()
        {
            int num = 0;
            bool ok = false;
            do
            {
                try
                {
                    Console.Write("Entre com o Numero da Conta: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Número Invalido");
                }
            } while (!ok);
            return num;
        }

        public static string EntrarNome()
        {
            string nome= " ";
            string[] campos;
            bool ok = false;
            do
            {
                Console.Write("Entre com o Nome: ");
                nome = Console.ReadLine();
                campos = nome.Split(' ');
                if (campos.Length < 2)
                {
                    Console.WriteLine("Erro: Nome Inválido");
                }
                else
                {
                    ok = true;
                }
            } while (!ok);
            return nome;
        }

        public static double EntrarSaldo()
        {
            double saldo = 0;
            bool ok = false;

            do {
                Console.Write("Entre com o Saldo: ");
                saldo = Convert.ToDouble(Console.ReadLine());
                if(saldo < 0)
                {
                    Console.WriteLine("Erro: Saldo Inválido");
                }
                else
                {
                    ok = true;
                }
            } while(!ok);
            return saldo;
        }
        
        
    
    } 
}

