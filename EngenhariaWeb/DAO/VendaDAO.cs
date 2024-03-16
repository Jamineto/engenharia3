using EngenhariaWeb.Util;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace EngenhariaWeb.DAO
{
    public class VendaDAO
    {

        public bool gravaVenda(Models.Venda venda)
        {
            bool operacao = false;
            try
            {
                Singleton instance = Singleton.getInstance();
                instance.ConnectionStart();

                using (MySqlConnection con = instance.ConnectionStart())
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "INSERT INTO  Venda (nome, idade) values (@nome, @idade)";

                        SqlParameter parNome = new SqlParameter("@nome", "teste");
                        SqlParameter parIdade = new SqlParameter("@idade", 10);
                        cmd.Parameters.Add(parNome);
                        cmd.Parameters.Add(parIdade);
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return operacao;
        }
    }
}
