using BancoFinags.Models;
using System;
using System.Collections.Generic;
using static BancoFinags.Utils;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static BancoFinags.CrudBD;

namespace BancoFinags
{
    public static class Crud { 
    public static void IncluirConta(SqlConnection sqlConn)
    {

        int num = EntrarConta();
        string nome = EntrarNome();
        double saldo = EntrarRealPositivo("Entre com o saldo: ");
        IncluirContaBD(sqlConn, nome, saldo);
    }
    public static void AlterarConta(SqlConnection sqlConn)
    {

            int num = EntrarConta();
            Conta conta = ConsultarContaBD(sqlConn, num);
            if (conta == null)
            {
                Console.WriteLine("Erro: conta não existe");
                return;
            }
            AlterarSaldo(conta);
            AlterarContaBD(sqlConn, conta);
        }
    public static void ExcluirConta(SqlConnection sqlConn)
    {

        int num = EntrarConta();
        Conta conta = ConsultarContaBD(sqlConn, num);
        if (conta == null)
        {
            Console.WriteLine("Erro: conta não existe");
            return;
        }
        if (conta.Saldo != 0)
        {
            Console.WriteLine("Erro: saldo diferente de zero");
            return;
        }
            ExcluirContaBD(sqlConn, conta);
    }
    public static void ExibirConta(SqlConnection sqlConn)
    {

        int num = EntrarConta();
            Conta conta = ConsultarContaBD(sqlConn, num);
        if (conta != null) {
                Console.WriteLine(conta); 
            }
            else
            {
                Console.WriteLine("Erro: Conta não encontrada");
            }
    }
    public static void ExibirContas(SqlConnection sqlConn)
        {
            List<Conta> contas = ConsultarContasBD(sqlConn);
            if(contas == null)
            {
                Console.WriteLine("Banco Vazio");
                return;
            }
      
            foreach(var conta in contas)
            {
                Console.WriteLine(conta);
            }
        }
}
}
