namespace EngenhariaWeb.Models
{
    public class Produto
    {
        private int _id;
        private String descricao {  get; set; }
        private String categoria { get; set; }
        private int estoque{ get; set; }
        private float preco { get; set; }

        public Produto(int id, string descricao, string categoria, int estoque, float preco)
        {
            _id = id;
            this.descricao = descricao;
            this.categoria = categoria;
            this.estoque = estoque;
            this.preco = preco;
        }
    }
}
