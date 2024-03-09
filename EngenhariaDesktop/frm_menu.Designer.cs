namespace EngenhariaDesktop
{
    partial class frm_menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolStripMenuItem entradaDeProdutosToolStripMenuItem;
            ToolStripMenuItem perdaToolStripMenuItem;
            ToolStripMenuItem trocaToolStripMenuItem;
            ToolStripMenuItem zerarEstoqueToolStripMenuItem;
            ToolStripMenuItem balançoToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            pnl_menu = new Panel();
            lbl_nome = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menu_principal = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            pessoasToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            vendaToolStripMenuItem = new ToolStripMenuItem();
            vendaDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            préVendaToolStripMenuItem = new ToolStripMenuItem();
            orçamentoToolStripMenuItem = new ToolStripMenuItem();
            caixaToolStripMenuItem = new ToolStripMenuItem();
            saídaDeCaixaToolStripMenuItem = new ToolStripMenuItem();
            entradaDeCaixaToolStripMenuItem = new ToolStripMenuItem();
            conferênciaDeCaixaToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            entradaDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            perdaToolStripMenuItem = new ToolStripMenuItem();
            trocaToolStripMenuItem = new ToolStripMenuItem();
            zerarEstoqueToolStripMenuItem = new ToolStripMenuItem();
            balançoToolStripMenuItem = new ToolStripMenuItem();
            pnl_menu.SuspendLayout();
            menu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // entradaDeProdutosToolStripMenuItem
            // 
            entradaDeProdutosToolStripMenuItem.ForeColor = Color.Black;
            entradaDeProdutosToolStripMenuItem.Name = "entradaDeProdutosToolStripMenuItem";
            entradaDeProdutosToolStripMenuItem.Size = new Size(444, 36);
            entradaDeProdutosToolStripMenuItem.Text = "Entrada de Produtos";
            // 
            // perdaToolStripMenuItem
            // 
            perdaToolStripMenuItem.ForeColor = Color.Black;
            perdaToolStripMenuItem.Name = "perdaToolStripMenuItem";
            perdaToolStripMenuItem.Size = new Size(444, 36);
            perdaToolStripMenuItem.Text = "Perda";
            // 
            // trocaToolStripMenuItem
            // 
            trocaToolStripMenuItem.ForeColor = Color.Black;
            trocaToolStripMenuItem.Name = "trocaToolStripMenuItem";
            trocaToolStripMenuItem.Size = new Size(444, 36);
            trocaToolStripMenuItem.Text = "Troca";
            // 
            // zerarEstoqueToolStripMenuItem
            // 
            zerarEstoqueToolStripMenuItem.ForeColor = Color.Black;
            zerarEstoqueToolStripMenuItem.Name = "zerarEstoqueToolStripMenuItem";
            zerarEstoqueToolStripMenuItem.Size = new Size(444, 36);
            zerarEstoqueToolStripMenuItem.Text = "Zerar Estoque";
            // 
            // balançoToolStripMenuItem
            // 
            balançoToolStripMenuItem.ForeColor = Color.Black;
            balançoToolStripMenuItem.Name = "balançoToolStripMenuItem";
            balançoToolStripMenuItem.Size = new Size(444, 36);
            balançoToolStripMenuItem.Text = "Balanço";
            // 
            // pnl_menu
            // 
            pnl_menu.BackColor = Color.Transparent;
            pnl_menu.Controls.Add(lbl_nome);
            pnl_menu.Dock = DockStyle.Bottom;
            pnl_menu.Location = new Point(0, 397);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(800, 53);
            pnl_menu.TabIndex = 0;
            pnl_menu.Paint += pnl_menu_Paint;
            // 
            // lbl_nome
            // 
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Dock = DockStyle.Bottom;
            lbl_nome.Font = new Font("Pokemon Solid", 20.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nome.ForeColor = Color.Black;
            lbl_nome.Location = new Point(0, -30);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(800, 83);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "Sistema de vendas XPTO";
            lbl_nome.TextAlign = ContentAlignment.MiddleCenter;
            lbl_nome.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menu_principal
            // 
            menu_principal.BackColor = Color.Transparent;
            menu_principal.Font = new Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point);
            menu_principal.ImageScalingSize = new Size(20, 20);
            menu_principal.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, estoqueToolStripMenuItem, vendaToolStripMenuItem });
            menu_principal.Location = new Point(0, 0);
            menu_principal.Name = "menu_principal";
            menu_principal.Size = new Size(800, 40);
            menu_principal.TabIndex = 2;
            menu_principal.Text = "menuStrip1";
            menu_principal.ItemClicked += menuStrip1_ItemClicked;
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.BackColor = Color.Transparent;
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtosToolStripMenuItem, categoriasToolStripMenuItem, pessoasToolStripMenuItem, usuáriosToolStripMenuItem });
            cadastrosToolStripMenuItem.Font = new Font("Ravie", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            cadastrosToolStripMenuItem.ForeColor = Color.Black;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(196, 36);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.Font = new Font("Pokemon Solid", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            produtosToolStripMenuItem.ForeColor = Color.Black;
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(246, 70);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Font = new Font("Pokemon Solid", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            categoriasToolStripMenuItem.ForeColor = Color.Black;
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(246, 70);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // pessoasToolStripMenuItem
            // 
            pessoasToolStripMenuItem.Font = new Font("Pokemon Solid", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            pessoasToolStripMenuItem.ForeColor = Color.Black;
            pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            pessoasToolStripMenuItem.Size = new Size(246, 70);
            pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Font = new Font("Pokemon Solid", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            usuáriosToolStripMenuItem.ForeColor = Color.Black;
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(246, 70);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.BackColor = Color.Transparent;
            estoqueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { entradaDeProdutosToolStripMenuItem, perdaToolStripMenuItem, trocaToolStripMenuItem, zerarEstoqueToolStripMenuItem, balançoToolStripMenuItem });
            estoqueToolStripMenuItem.Font = new Font("Ravie", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            estoqueToolStripMenuItem.ForeColor = Color.Black;
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(159, 36);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // vendaToolStripMenuItem
            // 
            vendaToolStripMenuItem.BackColor = Color.Transparent;
            vendaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vendaDeProdutosToolStripMenuItem, préVendaToolStripMenuItem, orçamentoToolStripMenuItem, caixaToolStripMenuItem });
            vendaToolStripMenuItem.Font = new Font("Ravie", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            vendaToolStripMenuItem.ForeColor = Color.Black;
            vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            vendaToolStripMenuItem.Size = new Size(127, 36);
            vendaToolStripMenuItem.Text = "Venda";
            // 
            // vendaDeProdutosToolStripMenuItem
            // 
            vendaDeProdutosToolStripMenuItem.ForeColor = Color.Black;
            vendaDeProdutosToolStripMenuItem.Name = "vendaDeProdutosToolStripMenuItem";
            vendaDeProdutosToolStripMenuItem.Size = new Size(406, 36);
            vendaDeProdutosToolStripMenuItem.Text = "Venda de Produtos";
            vendaDeProdutosToolStripMenuItem.Click += vendaDeProdutosToolStripMenuItem_Click;
            // 
            // préVendaToolStripMenuItem
            // 
            préVendaToolStripMenuItem.ForeColor = Color.Black;
            préVendaToolStripMenuItem.Name = "préVendaToolStripMenuItem";
            préVendaToolStripMenuItem.Size = new Size(406, 36);
            préVendaToolStripMenuItem.Text = "Pré-Venda";
            // 
            // orçamentoToolStripMenuItem
            // 
            orçamentoToolStripMenuItem.ForeColor = Color.Black;
            orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            orçamentoToolStripMenuItem.Size = new Size(406, 36);
            orçamentoToolStripMenuItem.Text = "Orçamento";
            // 
            // caixaToolStripMenuItem
            // 
            caixaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saídaDeCaixaToolStripMenuItem, entradaDeCaixaToolStripMenuItem, conferênciaDeCaixaToolStripMenuItem });
            caixaToolStripMenuItem.ForeColor = Color.Black;
            caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            caixaToolStripMenuItem.Size = new Size(406, 36);
            caixaToolStripMenuItem.Text = "Caixa";
            // 
            // saídaDeCaixaToolStripMenuItem
            // 
            saídaDeCaixaToolStripMenuItem.ForeColor = Color.Black;
            saídaDeCaixaToolStripMenuItem.Name = "saídaDeCaixaToolStripMenuItem";
            saídaDeCaixaToolStripMenuItem.Size = new Size(445, 36);
            saídaDeCaixaToolStripMenuItem.Text = "Saída de Caixa";
            // 
            // entradaDeCaixaToolStripMenuItem
            // 
            entradaDeCaixaToolStripMenuItem.ForeColor = Color.Black;
            entradaDeCaixaToolStripMenuItem.Name = "entradaDeCaixaToolStripMenuItem";
            entradaDeCaixaToolStripMenuItem.Size = new Size(445, 36);
            entradaDeCaixaToolStripMenuItem.Text = "Entrada de Caixa";
            // 
            // conferênciaDeCaixaToolStripMenuItem
            // 
            conferênciaDeCaixaToolStripMenuItem.ForeColor = Color.Black;
            conferênciaDeCaixaToolStripMenuItem.Name = "conferênciaDeCaixaToolStripMenuItem";
            conferênciaDeCaixaToolStripMenuItem.Size = new Size(445, 36);
            conferênciaDeCaixaToolStripMenuItem.Text = "Conferência de Caixa";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(350, 170);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(menu_principal);
            Controls.Add(pnl_menu);
            MainMenuStrip = menu_principal;
            Name = "frm_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            Load += frm_menu_Load_1;
            pnl_menu.ResumeLayout(false);
            menu_principal.ResumeLayout(false);
            menu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_menu;
        private Label lbl_nome;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem pessoasToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ToolStripMenuItem entradaDeProdutosToolStripMenuItem;
        private ToolStripMenuItem perdaToolStripMenuItem;
        private ToolStripMenuItem trocaToolStripMenuItem;
        private ToolStripMenuItem zerarEstoqueToolStripMenuItem;
        private ToolStripMenuItem balançoToolStripMenuItem;
        private ToolStripMenuItem vendaToolStripMenuItem;
        private ToolStripMenuItem vendaDeProdutosToolStripMenuItem;
        private ToolStripMenuItem préVendaToolStripMenuItem;
        private ToolStripMenuItem orçamentoToolStripMenuItem;
        private ToolStripMenuItem caixaToolStripMenuItem;
        private ToolStripMenuItem saídaDeCaixaToolStripMenuItem;
        private ToolStripMenuItem entradaDeCaixaToolStripMenuItem;
        private ToolStripMenuItem conferênciaDeCaixaToolStripMenuItem;
        private MenuStrip menu_principal;
        private PictureBox pictureBox1;
    }
}