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
    public static void IncluirConta(List<Conta> contas)
    {

        int num = EntrarConta();
        if (PesquisarConta(contas, num) != -1)
        {
            Console.WriteLine("Erro: conta já existe");
            return;
        }
        string nome = EntrarNome();
        double saldo = EntrarRealPositivo("Entre com o saldo: ");
        contas.Add(new Conta(num, nome, saldo));
    }

    public static void AlterarConta(List<Conta> contas)
    {

        int num = EntrarConta();
        int pos = PesquisarConta(contas, num);
        if (pos == -1)
        {
            Console.WriteLine("Erro: conta não existe");
            return;
        }
        AlterarSaldo(contas[pos]);

    }

    public static void ExcluirConta(List<Conta> contas)
    {

        int num = EntrarConta();
        int pos = PesquisarConta(contas, num);
        if (pos == -1)
        {
            Console.WriteLine("Erro: conta não existe");
            return;
        }
        if (contas[pos].Saldo != 0)
        {
            Console.WriteLine("Erro: saldo diferente de zero");
            return;
        }
        contas.Remove(contas[pos]);
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

}
}
