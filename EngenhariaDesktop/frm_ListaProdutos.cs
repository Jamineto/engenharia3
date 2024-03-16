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
using EngenhariaWeb.Util;

namespace EngenhariaDesktop
{
    public partial class frm_ListaProdutos : Form
    {
        public frm_ListaProdutos()
        {
            InitializeComponent();
        }

        private void frm_ListaProdutos_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ProdutoController pc = new ProdutoController();
            try
            {
                List<ProdutoLista> prodLista = pc.obterProdutosVenda();
                dg_produtos.DataSource = prodLista;
                dg_produtos.Columns["prod_codigo"].HeaderText = "Código";
                dg_produtos.Columns["descricao"].HeaderText = "Descrição";
                dg_produtos.Columns["qtde"].HeaderText = "Quantidade";
                dg_produtos.Columns["valor"].HeaderText = "Preço";
                dg_produtos.Columns["valorTotal"].HeaderText = "Total";

            }
            catch (Exception ex)
            {
            }



        }
    }
}
