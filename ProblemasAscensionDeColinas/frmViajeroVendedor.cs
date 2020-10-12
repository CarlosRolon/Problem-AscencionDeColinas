using ProblemasAscensionDeColinas.Resources;
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
        ViajeroClass viajero;

        public frmViajeroVendedor()
        {
            InitializeComponent();
            viajero = new ViajeroClass();
        }

        private void btnContinuarPaso1_Click(object sender, EventArgs e)
        {
            if (listbCiudades.Items.Count <= 0)
            {
                MessageBox.Show("No se ha ingresado ninguna ciudad");
                return;
            }

            pnPaso2.Enabled = true;
            pnPaso3.Enabled = false;
            pnPaso1.Enabled = false;

            ComboboxConCiudades();
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

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            string nuevaCiudad = txtCiudad.Text;
            
            if (string.IsNullOrWhiteSpace( nuevaCiudad) )
            {
                MessageBox.Show( "Ingresa un nombre de ciudad" , "ERROR" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return;
            }

            viajero.AgregarCiudad(nuevaCiudad);
            listbCiudades.Items.Add(nuevaCiudad);
            txtCiudad.Text = string.Empty;
        
        }

        private void btnEliminarCiudad_Click(object sender, EventArgs e)
        {
            int posicion = listbCiudades.SelectedIndex;

            if (posicion < 0)
            {
                MessageBox.Show("Seleccionar ciudad de la lista a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            viajero.EliminarCiudadEnPosicion(posicion);
            listbCiudades.Items.RemoveAt(posicion);
        }

        private void btnEliminarTodosItems_Click(object sender, EventArgs e)
        {
            viajero.EliminarTodasCiudades();
            listbCiudades.Items.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            pnPaso1.Enabled = true;
            pnPaso2.Enabled = false;
            pnPaso3.Enabled = false;
        }
    
        private void ComboboxConCiudades()
        {
            List<string> ciudades = viajero.Ciudades;
            foreach (string ciudad in ciudades)
            {
                cbCiudadInicial.Items.Add(ciudad);
                cbCiudadDestino.Items.Add(ciudad);
            }
        }

        private void btnAgregarConexion_Click(object sender, EventArgs e)
        {

        }
    }
}
