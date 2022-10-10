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
                    return conta;
                }
                dr.Close();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return conta;
        }
    }
}
