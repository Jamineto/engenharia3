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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {

            frm_menu menu = new frm_menu();
            if (tx_login.Text == "teste" && tx_senha.Text == "teste")
            {
                menu.Show();
                this.Hide();

            }
            else
                lbl_invalido.Visible = true;

        }
    }
}
