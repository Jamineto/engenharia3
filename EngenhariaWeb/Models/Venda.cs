namespace EngenhariaWeb.Models
{
    public class Venda
    {
        private int _id;
        private DateTime dataHora { get; set; }
        private float valorTotal { get; set; }
        private String pagamento { get; set; }

        public Venda(int id, DateTime dataHora, float valorTotal, string pagamento)
        {
            _id = id;
            this.dataHora = dataHora;
            this.valorTotal = valorTotal;
            this.pagamento = pagamento;
        }
    }
}
