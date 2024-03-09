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
            lbl_teste = new Label();
            SuspendLayout();
            // 
            // lbl_teste
            // 
            lbl_teste.AutoSize = true;
            lbl_teste.Location = new Point(0, 0);
            lbl_teste.Name = "lbl_teste";
            lbl_teste.Size = new Size(0, 15);
            lbl_teste.TabIndex = 0;
            // 
            // frm_vendaProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 527);
            Controls.Add(lbl_teste);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frm_vendaProd";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venda de Produtos";
            Load += frm_vendaProd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_teste;
    }
}