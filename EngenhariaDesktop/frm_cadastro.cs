using EngenhariaWeb.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngenhariaDesktop
{
    public partial class frm_cadastro : Form
    {
        public frm_cadastro()
        {
            InitializeComponent();
            tx_codigo.KeyDown += tx_codigo_KeyDown;
        }

        private void tx_codigo_KeyDown(object sender, KeyEventArgs e)
        {
            int codProd;
            if (e.KeyCode == Keys.Enter)
            {
                ProdutoController produtoController = new ProdutoController();
                try
                {
                    codProd = Convert.ToInt32(tx_codigo.Text);
                }
                catch
                {
                    codProd = 0;
                }
                if (codProd > 0)
                {
                    Object objeto = produtoController.obterPorCodigo(codProd);
                    Type tipo = objeto.GetType();
                    var cod = tipo.GetProperty("id");
                    int codigo = Convert.ToInt32(cod.GetValue(objeto));
                    if (codigo != 0)
                    {

                        var desc = tipo.GetProperty("descricao");
                        var estq = tipo.GetProperty("estoque");
                        var preco = tipo.GetProperty("preco");
                        string descricao = desc.GetValue(objeto).ToString();
                        int estoque = Convert.ToInt32(estq.GetValue(objeto));
                        string preco_venda = Convert.ToString(preco.GetValue(objeto));
                        tx_descricao.Text = descricao;
                        qtd_estoque.Value = estoque;
                        tx_preco.Text = preco_venda;
                    }
                    else
                    {
                        MessageBox.Show("Produto não cadastrado", "Erro ao buscar produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                tx_descricao.Focus();

            }
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                tx_codigo.Text = "";
                tx_descricao.Text = "";
                qtd_estoque.Value = 0;
                tx_preco.Text = "";
            }

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja sair do cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Hide();
        }

        private void btn_concluir_Click(object sender, EventArgs e)
        {
            int codProd;
            ProdutoController produtoController = new ProdutoController();
            try
            {
                codProd = Convert.ToInt32(tx_codigo.Text);

            }
            catch
            {
                codProd = 0;
            }
            if (tx_descricao.Text != "" && tx_preco.Text != "")
                produtoController.gravarProduto(codProd, tx_descricao.Text, tx_preco.Text, Convert.ToInt32(qtd_estoque.Value));
            else
                MessageBox.Show("Informe todos os campos", "Campos não preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frm_cadastro_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
