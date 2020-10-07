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
    public partial class frmViajeroVendedor : Form
    {
        public frmViajeroVendedor()
        {
            InitializeComponent();
        }

        private void btnContinuarPaso1_Click(object sender, EventArgs e)
        {
            pnPaso2.Enabled = true;
            pnPaso3.Enabled = false;
            pnPaso1.Enabled = false;
        }

        private void btnContinuarPaso2_Click(object sender, EventArgs e)
        {
            pnPaso3.Enabled = true;
            pnPaso1.Enabled = false;
            pnPaso2.Enabled = false;
        }

        private void btnRegresarPaso1_Click(object sender, EventArgs e)
        {
            
            pnPaso1.Enabled = true;
            pnPaso2.Enabled = false;
            pnPaso3.Enabled = false;
        }

        private void btnRegresarPaso2_Click(object sender, EventArgs e)
        {
            pnPaso2.Enabled = true;
            pnPaso1.Enabled = false;
            pnPaso3.Enabled = false; 
        }
    
    }
}
