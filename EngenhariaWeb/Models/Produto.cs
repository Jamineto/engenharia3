using EngenhariaWeb.DAO;
using MySql.Data.MySqlClient;

namespace EngenhariaWeb.Models
{
    public class Produto
    {
        public int id { get; set; }
        public String descricao {  get; set; }
        public String categoria { get; set; }
        public int estoque{ get; set; }
        public float preco { get; set; }

        public Produto(int id, string descricao, string categoria, int estoque, float preco)
        {
            this.id = id;
            this.descricao = descricao;
            this.categoria = categoria;
            this.estoque = estoque;
            this.preco = preco;
        }

        public Produto(){}

        public Produto obterPorCodigo(int id, MySqlConnection con)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            return produtoDAO.obterPorCodigo(id, con);
        }

        public int obterEstoqueProduto(int id, MySqlConnection con)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            return produtoDAO.obterEstoqueProduto(id, con);
        }

        public List<Produto> obterProdutos(MySqlConnection con)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            return produtoDAO.obterProdutos(con);
        }
    }
}
