using BancoFinags.Models;
using static BancoFinags.Crud;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static BancoFinags.ConexaoBD;
using static BancoFinags.Crud;

namespace BancoFinags
{
    public class Program
    {
        public static void Main(string[] args)
        {

            SqlConnection sqlConn = AbrirConexao();
            if (sqlConn == null)
            {
                Console.WriteLine("Error: Conexão com o banco ");
                return;
            }
            ExibirContas(sqlConn);
            AlterarConta(sqlConn);
            ExcluirConta(sqlConn);
            FecharConexao(sqlConn);
        }

    }
}
