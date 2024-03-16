using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngenhariaWeb.Controllers;

namespace EngenhariaDesktop
{
    public partial class frm_vendaProd : Form
    {
        public frm_vendaProd()
        {
            InitializeComponent();

        }

        private void frm_vendaProd_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            HomeController hc = new HomeController();
            string retorno = hc.Teste();
            lbl_teste.Text = retorno;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tx_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                int id = Convert.ToInt32(tx_codigo.Text);
                ProdutoController pc = new ProdutoController();
                Object objeto = pc.obterPorCodigo(id);
            }

        }

        private void lbl_codigo_Click(object sender, EventArgs e)
        {
        }

        private void lbl_prod_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cliente_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void lbl_tranporte_Click(object sender, EventArgs e)
        {

        }

        private void add_prod_Click(object sender, EventArgs e)
        {
            if (tx_codigo.Text != "" && qtd_prod.Value > 0)
            {
                ProdutoController pc = new ProdutoController();
                int estq = pc.obterEstoqueProduto(Convert.ToInt32(tx_codigo.Text));
                if (estq == 0)
                    MessageBox.Show("Produto sem estoque. Deseja ser notificado ao possuir estoque?", "Produto sem estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                else if (Convert.ToInt32(qtd_prod.Value) > estq)
                    MessageBox.Show("Quantidade indisponível. Deseja ser notificado ao possuir estoque?", "Produto sem estoque", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                else
                {
                    pc.guardaItens(Convert.ToInt32(tx_codigo.Text), Convert.ToInt32(qtd_prod.Value));
                    MessageBox.Show("Produto adicionado à compra.", "Adição de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tx_codigo.Text = "";
                    qtd_prod.Value = 0;
                    tx_descricao.Text = "";
                    tx_estoque.Text = "";
                }

            }
            else
                MessageBox.Show("Informe o código e quantidade", "Campos não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_listaProd_Click(object sender, EventArgs e)
        {
            frm_ListaProdutos flp = new frm_ListaProdutos();
            flp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tx_codigo_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                int id = Convert.ToInt32(tx_codigo.Text);
                ProdutoController pc = new ProdutoController();
                Object objeto = pc.obterPorCodigo(id);
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tx_codigo.Text);
            ProdutoController pc = new ProdutoController();
            Object objeto = pc.obterPorCodigo(id);
            Type tipo = objeto.GetType();
            var cod = tipo.GetProperty("id");
            int codigo = Convert.ToInt32(cod.GetValue(objeto));
            if (codigo != 0)
            {

                var desc = tipo.GetProperty("descricao");
                var estq = tipo.GetProperty("estoque");
                string descricao = desc.GetValue(objeto).ToString();
                int estoque = Convert.ToInt32(estq.GetValue(objeto));
                tx_descricao.Text = descricao;
                tx_estoque.Text = estoque.ToString();
            }
            else
            {
                MessageBox.Show("Produto não cadastrado", "Erro ao buscar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lbl_doc_Click(object sender, EventArgs e)
        {

        }

        private void tx_documento_TextChanged(object sender, EventArgs e)
        {
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja cancelar a venda?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ProdutoController pc = new ProdutoController();
                pc.zeraLista();
                this.Hide();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
