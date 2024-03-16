namespace EngenhariaDesktop
{
    partial class frm_ListaProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dg_produtos = new DataGridView();
            produtoListaBindingSource = new BindingSource(components);
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg_produtos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)produtoListaBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dg_produtos
            // 
            dg_produtos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dg_produtos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dg_produtos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg_produtos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_produtos.Location = new Point(-1, 36);
            dg_produtos.Name = "dg_produtos";
            dg_produtos.ReadOnly = true;
            dg_produtos.RowHeadersWidth = 51;
            dg_produtos.RowTemplate.Height = 29;
            dg_produtos.Size = new Size(800, 413);
            dg_produtos.TabIndex = 0;
            // 
            // produtoListaBindingSource
            // 
            produtoListaBindingSource.DataSource = typeof(EngenhariaWeb.Util.ProdutoLista);
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 38);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 34);
            label1.TabIndex = 0;
            label1.Text = "Lista de Produtos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frm_ListaProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dg_produtos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_ListaProdutos";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de produtos";
            Load += frm_ListaProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dg_produtos).EndInit();
            ((System.ComponentModel.ISupportInitialize)produtoListaBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_produtos;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn Quantidade;
        private BindingSource produtoListaBindingSource;
        private DataGridViewTextBoxColumn prodcodigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtdeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}