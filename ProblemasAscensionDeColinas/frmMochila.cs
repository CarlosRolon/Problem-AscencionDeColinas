using ProblemasAscensionDeColinas.Resources;
using ProblemasAscensionDeColinas.Resources.GA;
using ProblemasAscensionDeColinas.Resources.SA;
using System;
using System.Collections;
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
    public partial class frmMochila : Form
    {
        MochilaClass mochila;
        public frmMochila()
        {
            InitializeComponent();
            mochila = new MochilaClass();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            rtbSolucion.Text = "";
            if (mochila.objetosPosibles.Count <= 0)
            {
                MessageBox.Show("No hay Items", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nupPesoMaximo.Value <= 0)
            {
                MessageBox.Show("El peso maximo soportado por la mochila debe ser mayor a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nupTemperaturaMin.Value > nupTemperaturaInicial.Value)
            {
                MessageBox.Show("La temperatura inicial debe ser menor a la temperatura final", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            mochila.pesoMaximoPermitido = (int)nupPesoMaximo.Value;

            if (!mochila.pesoItemsPosiblesAceptables())
            {
                MessageBox.Show("Todos los objetos tienen un peso mayor al aceptable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            AlgortimoGAMochila algortimoGAMochila = new AlgortimoGAMochila(mochila);
            MochilaClass resultado = algortimoGAMochila.algoritmoGeneticoEstacionario(500 , 10 , .8 , .005);
            MochilaClass resultado1 = algortimoGAMochila.algoritmoGeneticoGeneracional(500, 10, .8, .005);

            rtbSolucion.Text +=
                " Objetos en la mochila con modelo Estacionario:  \n";
            for (int i = 0; i < resultado.ObjetosEnMochila.Count; i++)
            {
                if (resultado.ObjetosEnMochila[i])
                {
                    rtbSolucion.Text += (i + 1) + " , ";
                }
            }

            rtbSolucion.Text += " \n Peso Mochila: " + resultado.pesoEnMochila + " ,Valor Mochila: " + resultado.valorEnMochila;

            rtbSolucion.Text +=
                "\n Objetos en la mochila con modelo Generacional:  \n";
            for (int i = 0; i < resultado1.ObjetosEnMochila.Count; i++)
            {
                if (resultado1.ObjetosEnMochila[i])
                {
                    rtbSolucion.Text += (i + 1) + " , ";
                }
            }
            rtbSolucion.Text += " \n Peso Mochila: " + resultado1.pesoEnMochila + " ,Valor Mochila: " + resultado1.valorEnMochila;
            return;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if (nupPesoItem.Value <= 0 || nupValorItem.Value <= 0 )
            {
                MessageBox.Show("El peso/valor del item debe ser mayor a 0" , "ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int peso = (int)nupPesoItem.Value;
            int valor = (int)nupValorItem.Value;
            int[,] item = { { peso, valor } };

            mochila.agregarObjetoPosible( item );
            UpdateItemsListBox();
        }


        void UpdateItemsListBox()
        {
            listbItems.Items.Clear();
            ArrayList objetos = mochila.objetosPosibles;

            for (int i = 0; i < objetos.Count; i++)
            {
                int[,] item = (int[,])objetos[i];
                listbItems.Items.Add("ITEM " + (i + 1) +" : PESO " + item[0,0] + " , VALOR " + item[0,1]);
            }
        }

        private void btnEliminarTodosItems_Click(object sender, EventArgs e)
        {
            mochila.eliminarTodosObjetoPosibles();
            UpdateItemsListBox();
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            int posicion = listbItems.SelectedIndex;

            if (posicion < 0)
            {
                MessageBox.Show("Seleccionar item de la lista a eliminar" , "ERROR" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                return;
            }

            mochila.eliminarObjetoPosiblePosicion(posicion);
            UpdateItemsListBox();
        }

      
    }
}
