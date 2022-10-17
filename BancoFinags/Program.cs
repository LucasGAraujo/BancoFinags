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
            Console.WriteLine("Digite a Opção desejada [1]Cadastrar Conta\n[2]Atualizar conta\n[3]Exibir todos usuarios\n[4]Pesquisar usuario\n[5]Excluir usuario");
            string menu = Console.ReadLine();
            switch (menu) 
            {
                case "1":
                    Console.WriteLine("Você esta criando uma conta favor digitar abaixo: ");
                   IncluirConta(sqlConn);
                    break;
                case "2":
                    Console.WriteLine("Insira a conta que você deseja atualizar: ");
                    AlterarConta(sqlConn);
                    break ;
                case "3":
                    Console.WriteLine("Essas são as contas cadastrada: ");
                    ExibirContas(sqlConn);
                    break;
                case "4":
                    Console.WriteLine("Favor digitar a :");
                    ExibirConta(sqlConn);
                    break;
                case "5":
                    Console.WriteLine("Para excluir e necessario sua conta esta zerado , favor digitar o nome da conta");
                    ExcluirConta(sqlConn);
                    break;
                default:
                    break;
            }

            FecharConexao(sqlConn);
        }

    }
}
