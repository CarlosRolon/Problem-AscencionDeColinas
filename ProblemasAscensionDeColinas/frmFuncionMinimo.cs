using System;
using ProblemasAscensionDeColinas.Resources;
using ProblemasAscensionDeColinas.Resources.GA;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemasAscensionDeColinas
{
    public partial class frmFuncionMinimo : Form
    {
        FuncionMinimos funcion;
        public frmFuncionMinimo()
        {
            InitializeComponent();
            funcion = new FuncionMinimos();
        }
       
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            MinFuncion.Text = "";
            TBEstadoInicial.Text = "";
            funcion.NumDimensiones = (int)NumDimensiones.Value;

            funcion.listaDeValoresDeX = new List<float>((int)NumDimensiones.Value);
            AlgoritmoGAMinimos algortimoGAMinimos = new AlgoritmoGAMinimos(funcion);           
            FuncionMinimos resultado = algortimoGAMinimos.algoritmoGeneticoEstacionario(500, 10, .8, .005);
            FuncionMinimos resultado2 = algortimoGAMinimos.algoritmoGeneticoGeneracional(500, 10, .8, .005);

            rtbMinimos.Text =
                "  Resultado :  \n";
            for (int i = 0; i < resultado.listaDeValoresDeX.Count; i++)
            {
                rtbMinimos.Text += resultado.listaDeValoresDeX[i] + " , ";                
            }

            //rtbMinimos.Text += " \n Solución: " + resultado.listaDeValoresDeX.Count;
            
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
            return;
        }

       
    }
}
