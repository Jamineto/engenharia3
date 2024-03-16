using EngenhariaWeb.Models;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace EngenhariaWeb.DAO
{
    public class ProdutoDAO
    {
        public List<Models.Produto> obterProdutos(MySqlConnection con)
        {
            List<Models.Produto> produtos = new List<Models.Produto>();
            try
            {

                using (con)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = "SELECT * from produto";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                
                                while (reader.Read())
                                {
                                    // Extraindo os valores das colunas
                                    Models.Produto prod = new Models.Produto();
                                    prod.id = reader.GetInt32("pro_codigo");
                                    prod.descricao = reader.GetString("pro_descricao");
                                    prod.preco = reader.GetFloat("pro_preco");
                                    prod.estoque = reader.GetInt32("pro_estoque");
                                    prod.categoria = reader.GetString("pro_categoria");

                                    produtos.Add(prod);
                                }
                            }
                        }
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

            return produtos;
        }

        public int obterEstoqueProduto(int id, MySqlConnection con)
        {
            int prodEstoque = 0;
            try
            {

                using (con)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = $"SELECT pro_estoque from produto where pro_codigo = {id}";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    prodEstoque = reader.GetInt32("pro_estoque");

                                }
                            }
                        }
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

            return prodEstoque;
        }

        public Models.Produto obterPorCodigo(int id, MySqlConnection con)
        {
            Models.Produto prod = new Models.Produto();
            try
            {

                using (con)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = con;
                        cmd.CommandText = $"SELECT * from produto where pro_codigo = {id}";

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {

                                while (reader.Read())
                                {
                                    prod.id = reader.GetInt32("pro_codigo");
                                    prod.descricao = reader.GetString("pro_descricao");
                                    prod.preco = reader.GetFloat("pro_preco");
                                    prod.estoque = reader.GetInt32("pro_estoque");
                                    prod.categoria = reader.GetString("pro_categoria");

                                }
                            }
                        }
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

            return prod;
        }
    }
}
