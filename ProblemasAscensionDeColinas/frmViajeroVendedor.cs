using ProblemasAscensionDeColinas.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemasAscensionDeColinas
{
    public partial class frmViajeroVendedor : Form
    {
        AlgoritmoNAHCViajero algoritmoNAHCViajero;
        Viajero viajero;

        public frmViajeroVendedor()
        {
            InitializeComponent();
            viajero = new Viajero();
            algoritmoNAHCViajero = new AlgoritmoNAHCViajero();
        }

 

        private void ButtonExplorar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileNameCSV = openFileDialog1.FileName;
            textBoxFilePad.Text = fileNameCSV;
        }
       
        private void CargarCSV_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] matriz = MakeMatrizAdyacencia(textBoxFilePad.Text);
                viajero.matrizAdyacencia = matriz;
                MessageBox.Show("Se ha cargado correctamente", " COMPLETADO  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception es)
            {
                MessageBox.Show("Error: \n" + es.Message, "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
         
        }

        private int[,] MakeMatrizAdyacencia(string filePad)
        {
            int[,] matrizAdyacencia;
            int numCiudades;

            using (var reader = new StreamReader(filePad))
            {
                numCiudades = Int32.Parse(reader.ReadLine());
                matrizAdyacencia = new int[numCiudades, numCiudades];

                for (int i = 0; i < numCiudades; i++)
                {
                    for (int j = 0; j < numCiudades; j++)
                    {
                        matrizAdyacencia[i, j] = 0;
                    }
                }
                int ciudadInicio = 0, ciudadLlegada = 0, pesoConexion = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    ciudadInicio = Int32.Parse(values[0])-1;
                    ciudadLlegada = Int32.Parse(values[1])-1;
                    pesoConexion = Int32.Parse(values[2]);

                    matrizAdyacencia[ciudadInicio, ciudadLlegada] = pesoConexion;
                    matrizAdyacencia[ciudadLlegada, ciudadInicio] = pesoConexion;

                }
            }
            return matrizAdyacencia;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*if (viajero.matrizAdyacencia.GetLength(0) == null)
            {
                MessageBox.Show("Favor de Agregar Matriz de Adyacencia","ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/

            viajero = algoritmoNAHCViajero.optimizarFuncion(viajero, (int)nupNumeroIteraciones.Value);

            rtbSolucion.Text = " Distancia: " + viajero.distanciaRecorrida + "  \n Camino: ";

            foreach (int ciudad in viajero.ciudadesVisitadas)
            {
                rtbSolucion.Text += (ciudad + 1) + " ,";
            }
            
            
        }
    }
}
