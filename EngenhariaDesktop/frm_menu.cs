using System.Diagnostics;

namespace EngenhariaDesktop
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnl_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_menu_Load_1(object sender, EventArgs e)
        {
            lbl_nome.Location = new Point((pnl_menu.Width - lbl_nome.Width) / 2, (pnl_menu.Height - lbl_nome.Height) / 2);
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vendaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vendaProd fvp = new frm_vendaProd();
            fvp.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro fCad = new frm_cadastro();
            fCad.Show();
        }
    }
}