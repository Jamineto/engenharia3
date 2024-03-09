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

namespace EngenhariaDesktop
{
    public partial class frm_vendaProd : Form
    {
        public frm_vendaProd()
        {
            InitializeComponent();
        }

        private void frm_vendaProd_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            HomeController hc = new HomeController();
            string retorno = hc.Teste();
            lbl_teste.Text = retorno;
        }
    }
}
