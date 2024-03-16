using EngenhariaWeb.Models;

namespace EngenhariaWeb.Util
{
    public class ProdutoLista
    {
        public int prod_codigo { get; set; }
        public string descricao { get; set; }
        public int qtde { get; set; }
        public float valor { get; set; }
        public float valorTotal { get; set; }


        public ProdutoLista() { }
    }
}
