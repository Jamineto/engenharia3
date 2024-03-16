namespace EngenhariaDesktop
{
    partial class frm_cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro));
            panel1 = new Panel();
            lbl_prod = new Label();
            pictureBox1 = new PictureBox();
            tx_codigo = new TextBox();
            lbl_codigo = new Label();
            lbl_desc = new Label();
            tx_descricao = new TextBox();
            qtd_estoque = new NumericUpDown();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            cb_transporte = new ComboBox();
            label3 = new Label();
            btn_concluir = new Button();
            bt_cancelar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qtd_estoque).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbl_prod);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 59);
            panel1.TabIndex = 0;
            // 
            // lbl_prod
            // 
            lbl_prod.BackColor = Color.Transparent;
            lbl_prod.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_prod.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_prod.Location = new Point(0, 0);
            lbl_prod.Name = "lbl_prod";
            lbl_prod.Size = new Size(800, 59);
            lbl_prod.TabIndex = 3;
            lbl_prod.Text = "Cadastro de produto";
            lbl_prod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // tx_codigo
            // 
            tx_codigo.Location = new Point(177, 131);
            tx_codigo.Name = "tx_codigo";
            tx_codigo.Size = new Size(125, 27);
            tx_codigo.TabIndex = 13;
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_codigo.Location = new Point(177, 104);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(81, 24);
            lbl_codigo.TabIndex = 12;
            lbl_codigo.Text = "Código";
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_desc.Location = new Point(360, 104);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(117, 24);
            lbl_desc.TabIndex = 14;
            lbl_desc.Text = "Descrição";
            // 
            // tx_descricao
            // 
            tx_descricao.Location = new Point(360, 131);
            tx_descricao.Name = "tx_descricao";
            tx_descricao.Size = new Size(282, 27);
            tx_descricao.TabIndex = 15;
            // 
            // qtd_estoque
            // 
            qtd_estoque.Location = new Point(48, 248);
            qtd_estoque.Name = "qtd_estoque";
            qtd_estoque.Size = new Size(123, 27);
            qtd_estoque.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 221);
            label1.Name = "label1";
            label1.Size = new Size(97, 24);
            label1.TabIndex = 23;
            label1.Text = "Estoque";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 27);
            textBox1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(231, 221);
            label2.Name = "label2";
            label2.Size = new Size(171, 24);
            label2.TabIndex = 25;
            label2.Text = "Preço de venda";
            // 
            // cb_transporte
            // 
            cb_transporte.FormattingEnabled = true;
            cb_transporte.Items.AddRange(new object[] { "SEDEX", "Transportadora X", "Transp. Marítimo", "Transp. Áereo" });
            cb_transporte.Location = new Point(568, 248);
            cb_transporte.Name = "cb_transporte";
            cb_transporte.Size = new Size(193, 28);
            cb_transporte.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(568, 221);
            label3.Name = "label3";
            label3.Size = new Size(117, 24);
            label3.TabIndex = 27;
            label3.Text = "Categoria";
            // 
            // btn_concluir
            // 
            btn_concluir.BackColor = SystemColors.Highlight;
            btn_concluir.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_concluir.Location = new Point(593, 358);
            btn_concluir.Name = "btn_concluir";
            btn_concluir.Size = new Size(168, 66);
            btn_concluir.TabIndex = 29;
            btn_concluir.Text = "Salvar";
            btn_concluir.UseVisualStyleBackColor = false;
            // 
            // bt_cancelar
            // 
            bt_cancelar.BackColor = Color.Red;
            bt_cancelar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_cancelar.Location = new Point(395, 358);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(168, 66);
            bt_cancelar.TabIndex = 28;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // frm_cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_concluir);
            Controls.Add(bt_cancelar);
            Controls.Add(label3);
            Controls.Add(cb_transporte);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(qtd_estoque);
            Controls.Add(lbl_desc);
            Controls.Add(tx_descricao);
            Controls.Add(tx_codigo);
            Controls.Add(lbl_codigo);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frm_cadastro";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de produto";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)qtd_estoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_prod;
        private PictureBox pictureBox1;
        private TextBox tx_codigo;
        private Label lbl_codigo;
        private Label lbl_desc;
        private TextBox tx_descricao;
        private NumericUpDown qtd_estoque;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox cb_transporte;
        private Label label3;
        private Button btn_concluir;
        private Button bt_cancelar;
    }
}