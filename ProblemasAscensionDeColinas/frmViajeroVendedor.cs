﻿using ProblemasAscensionDeColinas.Resources;
using ProblemasAscensionDeColinas.Resources.GA;
using ProblemasAscensionDeColinas.Resources.SA;
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
        AlgoritmoSAViajero algoritmoSAViajero;
        Viajero viajero;
        bool subioMatrix;

        public frmViajeroVendedor()
        {
            InitializeComponent();
            viajero = new Viajero();
            algoritmoSAViajero = new AlgoritmoSAViajero();
            subioMatrix = false;
        }

 

        private void ButtonExplorar_Click(object sender, EventArgs e)
        {
            subioMatrix = false;
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
                subioMatrix = true;
            }
            catch (Exception es)
            {
                MessageBox.Show("Error: \n" + es.Message, "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private int[,] MakeMatrizAdyacencia(string filePad)
        {
            int maxValue = 1000000;
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
                        matrizAdyacencia[i, j] = maxValue;
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
            if (!subioMatrix)
            {
                MessageBox.Show("Favor de Agregar Matriz de Adyacencia","ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nupTemperaturaMin.Value > nupTemperaturaInicial.Value)
            {
                MessageBox.Show("La temperatura inicial debe ser menor a la temperatura final", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            AlgoritmoGAViajero algortimoGAViajero = new AlgoritmoGAViajero(viajero);
            List<Viajero> poblacion = algortimoGAViajero.generarPoblacion(10);
            List<Viajero> NPM = algortimoGAViajero.MetodoSeleccion(poblacion, MetodosSeleccion.NPM);
            List<Viajero> Ruleta = algortimoGAViajero.MetodoSeleccion(poblacion, MetodosSeleccion.Proporcional);
            List<Viajero> Torneo = algortimoGAViajero.MetodoSeleccion(poblacion, MetodosSeleccion.Torneo);

            rtbSolucion.Text =
                "  Poblacion Inicial :  \n";

            foreach (Viajero item in poblacion)
            {
                for (int i = 0; i < item.ruta.Count; i++)
                {
                    rtbSolucion.Text += item.ruta[i] + " , ";

                }

                rtbSolucion.Text += " \n";
            }

            rtbSolucion.Text +=
                " \n  Padres con metodo NAM :  \n";
            foreach (Viajero item in NPM)
            {
                for (int i = 0; i < item.ruta.Count; i++)
                {
                    rtbSolucion.Text += item.ruta[i] + " , ";
                }

                rtbSolucion.Text += " \n";
            }

            rtbSolucion.Text +=
                " \n  Padres con metodo Ruleta :  \n";
            foreach (Viajero item in Ruleta)
            {
                for (int i = 0; i < item.ruta.Count; i++)
                {
                    rtbSolucion.Text += item.ruta[i] + " , ";
                }

                rtbSolucion.Text += " \n";
            }

            rtbSolucion.Text +=
              " \n  Padres con metodo Torneo :  \n";
            foreach (Viajero item in Torneo)
            {
                for (int i = 0; i < item.ruta.Count; i++)
                {
                    rtbSolucion.Text += item.ruta[i] + " , ";
                }

                rtbSolucion.Text += " \n";
            }

         
            /*viajero = algoritmoSAViajero.optimizarSolucion( viajero,  (int)nupNumeroIteraciones.Value 
                ,  (float)nupTemperaturaMin.Value, (float)nupTemperaturaInicial.Value, (float)nupA.Value);

            rtbSolucion.Text = " Distancia: " + viajero.distanciaCamino() + "  \n Camino: ";

            foreach (int ciudad in viajero.ruta)
            {
                rtbSolucion.Text += (ciudad + 1) + " ,";
            }
            */

        }

        private void lbSolucion_Click(object sender, EventArgs e)
        {

        }
    }
}
