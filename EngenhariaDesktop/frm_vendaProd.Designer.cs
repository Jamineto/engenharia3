namespace EngenhariaDesktop
{
    partial class frm_vendaProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_vendaProd));
            lbl_teste = new Label();
            tx_codigo = new TextBox();
            lbl_codigo = new Label();
            lbl_desc = new Label();
            tx_descricao = new TextBox();
            lbl_estoque = new Label();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel8 = new Panel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbl_prod = new Label();
            label1 = new Label();
            tx_codCli = new TextBox();
            lbl_dadosCli = new Label();
            lbl_cliente = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel5 = new Panel();
            tx_documento = new TextBox();
            lbl_doc = new Label();
            lbl_nome = new Label();
            tx_nomeCli = new TextBox();
            pictureBox3 = new PictureBox();
            panel6 = new Panel();
            btn_concluir = new Button();
            bt_cancelar = new Button();
            cb_pagamento = new ComboBox();
            lb_pagamento = new Label();
            cb_transporte = new ComboBox();
            lbl_transporte = new Label();
            textBox2 = new TextBox();
            lbl_qtd = new Label();
            lbl_valor = new Label();
            textBox4 = new TextBox();
            panel7 = new Panel();
            lbl_tranporte = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_teste
            // 
            lbl_teste.AutoSize = true;
            lbl_teste.Location = new Point(0, 0);
            lbl_teste.Name = "lbl_teste";
            lbl_teste.Size = new Size(0, 20);
            lbl_teste.TabIndex = 0;
            // 
            // tx_codigo
            // 
            tx_codigo.Location = new Point(147, 78);
            tx_codigo.Name = "tx_codigo";
            tx_codigo.Size = new Size(125, 27);
            tx_codigo.TabIndex = 2;
            tx_codigo.TextChanged += tx_codigo_TextChanged;
            // 
            // lbl_codigo
            // 
            lbl_codigo.AutoSize = true;
            lbl_codigo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_codigo.Location = new Point(147, 51);
            lbl_codigo.Name = "lbl_codigo";
            lbl_codigo.Size = new Size(81, 24);
            lbl_codigo.TabIndex = 1;
            lbl_codigo.Text = "Código";
            lbl_codigo.Click += lbl_codigo_Click;
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_desc.Location = new Point(332, 51);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(117, 24);
            lbl_desc.TabIndex = 3;
            lbl_desc.Text = "Descrição";
            // 
            // tx_descricao
            // 
            tx_descricao.Location = new Point(332, 78);
            tx_descricao.Name = "tx_descricao";
            tx_descricao.Size = new Size(384, 27);
            tx_descricao.TabIndex = 4;
            // 
            // lbl_estoque
            // 
            lbl_estoque.AutoSize = true;
            lbl_estoque.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_estoque.Location = new Point(783, 51);
            lbl_estoque.Name = "lbl_estoque";
            lbl_estoque.Size = new Size(163, 24);
            lbl_estoque.TabIndex = 5;
            lbl_estoque.Text = "Estoque Atual";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(783, 78);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(163, 27);
            textBox1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(lbl_estoque);
            panel2.Controls.Add(tx_codigo);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lbl_codigo);
            panel2.Controls.Add(lbl_desc);
            panel2.Controls.Add(tx_descricao);
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(1062, 129);
            panel2.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Location = new Point(1, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1063, 3);
            panel8.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(lbl_prod);
            flowLayoutPanel1.Location = new Point(0, 1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(346, 34);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // lbl_prod
            // 
            lbl_prod.BackColor = Color.Transparent;
            lbl_prod.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_prod.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_prod.Location = new Point(3, 0);
            lbl_prod.Name = "lbl_prod";
            lbl_prod.Size = new Size(346, 34);
            lbl_prod.TabIndex = 2;
            lbl_prod.Text = "Dados do produto";
            lbl_prod.TextAlign = ContentAlignment.MiddleCenter;
            lbl_prod.Click += lbl_prod_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Stencil", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1062, 49);
            label1.TabIndex = 9;
            label1.Text = "Área de Vendas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tx_codCli
            // 
            tx_codCli.Location = new Point(174, 99);
            tx_codCli.Name = "tx_codCli";
            tx_codCli.Size = new Size(125, 27);
            tx_codCli.TabIndex = 11;
            tx_codCli.TextChanged += textBox2_TextChanged;
            // 
            // lbl_dadosCli
            // 
            lbl_dadosCli.AutoSize = true;
            lbl_dadosCli.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_dadosCli.Location = new Point(174, 72);
            lbl_dadosCli.Name = "lbl_dadosCli";
            lbl_dadosCli.Size = new Size(81, 24);
            lbl_dadosCli.TabIndex = 10;
            lbl_dadosCli.Text = "Código";
            lbl_dadosCli.Click += label2_Click;
            // 
            // lbl_cliente
            // 
            lbl_cliente.BackColor = Color.Transparent;
            lbl_cliente.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_cliente.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_cliente.Location = new Point(17, 0);
            lbl_cliente.Name = "lbl_cliente";
            lbl_cliente.Size = new Size(367, 35);
            lbl_cliente.TabIndex = 12;
            lbl_cliente.Text = "Dados do comprador";
            lbl_cliente.TextAlign = ContentAlignment.MiddleCenter;
            lbl_cliente.Click += lbl_cliente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lbl_cliente);
            panel1.Location = new Point(9, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(367, 34);
            panel1.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(1, 333);
            panel3.Name = "panel3";
            panel3.Size = new Size(1063, 3);
            panel3.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 54);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Location = new Point(0, 176);
            panel4.Name = "panel4";
            panel4.Size = new Size(1063, 3);
            panel4.TabIndex = 16;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.GradientInactiveCaption;
            panel5.Controls.Add(tx_documento);
            panel5.Controls.Add(lbl_doc);
            panel5.Controls.Add(lbl_nome);
            panel5.Controls.Add(tx_nomeCli);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(tx_codCli);
            panel5.Controls.Add(lbl_dadosCli);
            panel5.Location = new Point(-27, 179);
            panel5.Name = "panel5";
            panel5.Size = new Size(1091, 154);
            panel5.TabIndex = 17;
            // 
            // tx_documento
            // 
            tx_documento.Location = new Point(810, 99);
            tx_documento.Name = "tx_documento";
            tx_documento.Size = new Size(267, 27);
            tx_documento.TabIndex = 18;
            // 
            // lbl_doc
            // 
            lbl_doc.AutoSize = true;
            lbl_doc.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_doc.Location = new Point(810, 72);
            lbl_doc.Name = "lbl_doc";
            lbl_doc.Size = new Size(128, 24);
            lbl_doc.TabIndex = 17;
            lbl_doc.Text = "Documento";
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nome.Location = new Point(359, 72);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(64, 24);
            lbl_nome.TabIndex = 11;
            lbl_nome.Text = "Nome";
            // 
            // tx_nomeCli
            // 
            tx_nomeCli.Location = new Point(359, 99);
            tx_nomeCli.Name = "tx_nomeCli";
            tx_nomeCli.Size = new Size(384, 27);
            tx_nomeCli.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 54);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(91, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.GradientInactiveCaption;
            panel6.Controls.Add(btn_concluir);
            panel6.Controls.Add(bt_cancelar);
            panel6.Controls.Add(cb_pagamento);
            panel6.Controls.Add(lb_pagamento);
            panel6.Controls.Add(cb_transporte);
            panel6.Controls.Add(lbl_transporte);
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(textBox2);
            panel6.Controls.Add(lbl_qtd);
            panel6.Controls.Add(lbl_valor);
            panel6.Controls.Add(textBox4);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(0, 336);
            panel6.Name = "panel6";
            panel6.Size = new Size(1064, 367);
            panel6.TabIndex = 18;
            // 
            // btn_concluir
            // 
            btn_concluir.BackColor = SystemColors.Highlight;
            btn_concluir.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_concluir.Location = new Point(880, 289);
            btn_concluir.Name = "btn_concluir";
            btn_concluir.Size = new Size(168, 66);
            btn_concluir.TabIndex = 20;
            btn_concluir.Text = "Concluir";
            btn_concluir.UseVisualStyleBackColor = false;
            // 
            // bt_cancelar
            // 
            bt_cancelar.BackColor = Color.Red;
            bt_cancelar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bt_cancelar.Location = new Point(682, 289);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(168, 66);
            bt_cancelar.TabIndex = 19;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = false;
            // 
            // cb_pagamento
            // 
            cb_pagamento.FormattingEnabled = true;
            cb_pagamento.Items.AddRange(new object[] { "PIX", "Cartão de Crédito", "Cartão de Débito", "Dinheiro" });
            cb_pagamento.Location = new Point(781, 93);
            cb_pagamento.Name = "cb_pagamento";
            cb_pagamento.Size = new Size(267, 28);
            cb_pagamento.TabIndex = 18;
            // 
            // lb_pagamento
            // 
            lb_pagamento.AutoSize = true;
            lb_pagamento.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pagamento.Location = new Point(781, 67);
            lb_pagamento.Name = "lb_pagamento";
            lb_pagamento.Size = new Size(226, 24);
            lb_pagamento.TabIndex = 17;
            lb_pagamento.Text = "Forma de pagamento";
            // 
            // cb_transporte
            // 
            cb_transporte.FormattingEnabled = true;
            cb_transporte.Items.AddRange(new object[] { "SEDEX", "Transportadora X", "Transp. Marítimo", "Transp. Áereo" });
            cb_transporte.Location = new Point(521, 94);
            cb_transporte.Name = "cb_transporte";
            cb_transporte.Size = new Size(193, 28);
            cb_transporte.TabIndex = 16;
            // 
            // lbl_transporte
            // 
            lbl_transporte.AutoSize = true;
            lbl_transporte.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_transporte.Location = new Point(521, 67);
            lbl_transporte.Name = "lbl_transporte";
            lbl_transporte.Size = new Size(169, 24);
            lbl_transporte.TabIndex = 15;
            lbl_transporte.Text = "Forma de envio";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 2;
            // 
            // lbl_qtd
            // 
            lbl_qtd.AutoSize = true;
            lbl_qtd.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_qtd.Location = new Point(145, 67);
            lbl_qtd.Name = "lbl_qtd";
            lbl_qtd.Size = new Size(132, 24);
            lbl_qtd.TabIndex = 1;
            lbl_qtd.Text = "quantidade";
            // 
            // lbl_valor
            // 
            lbl_valor.AutoSize = true;
            lbl_valor.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_valor.Location = new Point(330, 67);
            lbl_valor.Name = "lbl_valor";
            lbl_valor.Size = new Size(137, 24);
            lbl_valor.TabIndex = 3;
            lbl_valor.Text = "Valor Total";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(330, 94);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 27);
            textBox4.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(lbl_tranporte);
            panel7.Location = new Point(-4, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(353, 36);
            panel7.TabIndex = 14;
            // 
            // lbl_tranporte
            // 
            lbl_tranporte.BackColor = Color.Transparent;
            lbl_tranporte.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tranporte.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_tranporte.Location = new Point(0, 1);
            lbl_tranporte.Name = "lbl_tranporte";
            lbl_tranporte.Size = new Size(353, 35);
            lbl_tranporte.TabIndex = 13;
            lbl_tranporte.Text = "Dados da venda";
            lbl_tranporte.TextAlign = ContentAlignment.MiddleCenter;
            lbl_tranporte.Click += lbl_tranporte_Click;
            // 
            // frm_vendaProd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1062, 703);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(lbl_teste);
            Controls.Add(panel5);
            Name = "frm_vendaProd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda de Produtos";
            Load += frm_vendaProd_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_teste;
        private Panel panel1;
        private Label lbl_venda;
        private TextBox tx_codigo;
        private Label lbl_codigo;
        private Label lbl_desc;
        private TextBox tx_descricao;
        private Label lbl_estoque;
        private TextBox textBox1;
        private Panel panel2;
        private Panel panel3;
        private Label lbl_prod;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private TextBox tx_codCli;
        private Label lbl_dadosCli;
        private Label lbl_cliente;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Panel panel5;
        private TextBox tx_documento;
        private Label lbl_doc;
        private Label lbl_nome;
        private TextBox tx_nomeCli;
        private PictureBox pictureBox3;
        private Panel panel6;
        private Label lbl_transporte;
        private Panel panel7;
        private Label lbl_tranporte;
        private TextBox textBox2;
        private Label lbl_qtd;
        private Label lbl_valor;
        private TextBox textBox4;
        private Button bt_cancelar;
        private ComboBox cb_pagamento;
        private Label lb_pagamento;
        private ComboBox cb_transporte;
        private Button btn_concluir;
        private Panel panel8;
    }
}