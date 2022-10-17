using BancoFinags.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoFinags
{
    public class CrudBD
    {
        public static void IncluirContaBD(SqlConnection sqlCon, string nome, double saldo)
        {
            string sql = "INSERT INTO contas(nome, saldo) VALUES (@nome, @saldo)";
            SqlCommand cmd = new SqlCommand(sql, sqlCon);
            cmd.Parameters.Add(new SqlParameter("@nome", nome));
            cmd.Parameters.Add(new SqlParameter("@saldo", saldo));
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Conta Inserida");
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static Conta ConsultarContaBD(SqlConnection sqlConn, int num)
        {
            string sql = "SELECT * FROM contas WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            cmd.Parameters.Add(new SqlParameter("@id", num));
            Conta conta = null;
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string nome = (dr["nome"].ToString());
                    double saldo = double.Parse(dr["saldo"].ToString());
                    conta = new Conta(id, nome, saldo);
                }
                dr.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conta;
        }
        public static List<Conta> ConsultarContasBD(SqlConnection sqlConn)
        {
            string sql = "SELECT * FROM contas";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            List<Conta> contas = new List<Conta>();
            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = int.Parse(dr["id"].ToString());
                    string nome = (dr["nome"].ToString());
                    double saldo = double.Parse(dr["saldo"].ToString());
                    contas.Add(new Conta(id, nome, saldo ));
                    
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return contas;
        }
        public static void ExcluirContaBD(SqlConnection sqlConn, Conta conta)
        {
            string sql = "DELETE FROM contas WHERE id = @id";
            SqlCommand cmd= new SqlCommand(sql, sqlConn);
            cmd.Parameters.Add(new SqlParameter("@id", conta.Id));
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Conta Excluida");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void AlterarContaBD(SqlConnection sqlConn, Conta conta)
        {
            string sql = "UPDATE contas SET saldo =@saldo WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            cmd.Parameters.Add(new SqlParameter("@id", conta.Id));
            cmd.Parameters.Add(new SqlParameter("@saldo", conta.Saldo));
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Conta Alterada");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
