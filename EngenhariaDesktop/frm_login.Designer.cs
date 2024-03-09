namespace EngenhariaDesktop
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            pictureBox1 = new PictureBox();
            tx_login = new TextBox();
            lbl_nome = new Label();
            lbl_senha = new Label();
            tx_senha = new TextBox();
            pictureBox2 = new PictureBox();
            lbl_titulo = new Label();
            label1 = new Label();
            btn_entrar = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // tx_login
            // 
            tx_login.Location = new Point(109, 253);
            tx_login.Name = "tx_login";
            tx_login.Size = new Size(238, 27);
            tx_login.TabIndex = 1;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nome.Location = new Point(109, 228);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(65, 22);
            lbl_nome.TabIndex = 2;
            lbl_nome.Text = "Login";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Stencil", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_senha.Location = new Point(109, 303);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(71, 22);
            lbl_senha.TabIndex = 5;
            lbl_senha.Text = "Senha";
            lbl_senha.Click += lbl_senha_Click;
            // 
            // tx_senha
            // 
            tx_senha.Location = new Point(109, 328);
            tx_senha.Name = "tx_senha";
            tx_senha.Size = new Size(238, 27);
            tx_senha.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lbl_titulo
            // 
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Pokemon Solid", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_titulo.Location = new Point(26, 32);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(321, 123);
            lbl_titulo.TabIndex = 6;
            lbl_titulo.Text = "SISTEMA XPTO";
            lbl_titulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Pokemon Solid", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 129);
            label1.Name = "label1";
            label1.Size = new Size(321, 59);
            label1.TabIndex = 7;
            label1.Text = "Realize seu login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_entrar
            // 
            btn_entrar.BackColor = SystemColors.ControlLightLight;
            btn_entrar.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_entrar.Location = new Point(213, 458);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(134, 49);
            btn_entrar.TabIndex = 8;
            btn_entrar.Text = "ENTRAR";
            btn_entrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.ErrorImage = (Image)resources.GetObject("pictureBox3.ErrorImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(26, 396);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(148, 127);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(382, 553);
            Controls.Add(pictureBox3);
            Controls.Add(btn_entrar);
            Controls.Add(label1);
            Controls.Add(lbl_titulo);
            Controls.Add(lbl_senha);
            Controls.Add(tx_senha);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_nome);
            Controls.Add(tx_login);
            Controls.Add(pictureBox1);
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tx_login;
        private Label lbl_nome;
        private Label lbl_senha;
        private TextBox tx_senha;
        private PictureBox pictureBox2;
        private Label lbl_titulo;
        private Label label1;
        private Button btn_entrar;
        private PictureBox pictureBox3;
    }
}