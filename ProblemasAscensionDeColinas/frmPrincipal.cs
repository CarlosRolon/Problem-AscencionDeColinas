using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemasAscensionDeColinas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMochila_Click(object sender, EventArgs e)
        {
            frmMochila mochila = new frmMochila();
            mochila.ShowDialog();
        }

        private void btnViajero_Click(object sender, EventArgs e)
        {
            frmViajeroVendedor viajeroVendedor = new frmViajeroVendedor();
            viajeroVendedor.ShowDialog();
        }
    }
}
