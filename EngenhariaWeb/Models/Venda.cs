namespace EngenhariaWeb.Models
{
    public class Venda
    {
        private int _id;
        public DateTime dataHora { get; set; }
        public float valorTotal { get; set; }
        public String pagamento { get; set; }

        public Venda(int id, DateTime dataHora, float valorTotal, string pagamento)
        {
            _id = id;
            this.dataHora = dataHora;
            this.valorTotal = valorTotal;
            this.pagamento = pagamento;
        }
    }
}
