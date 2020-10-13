namespace ProblemasAscensionDeColinas
{
    partial class frmViajeroVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTituloPrincipal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFilePad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nupNumeroIteraciones = new System.Windows.Forms.NumericUpDown();
            this.CargarCSV = new System.Windows.Forms.Button();
            this.lbNumeroIteraciones = new System.Windows.Forms.Label();
            this.ButtonExplorar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSolucion = new System.Windows.Forms.Label();
            this.rtbSolucion = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloPrincipal
            // 
            this.lbTituloPrincipal.AutoSize = true;
            this.lbTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrincipal.Location = new System.Drawing.Point(175, 23);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(416, 31);
            this.lbTituloPrincipal.TabIndex = 17;
            this.lbTituloPrincipal.Text = "Problema del Viajero Vendedor";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(516, 103);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 32);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV|* .csv";
            this.openFileDialog1.Title = "Archivo";
            // 
            // textBoxFilePad
            // 
            this.textBoxFilePad.Location = new System.Drawing.Point(173, 23);
            this.textBoxFilePad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFilePad.Name = "textBoxFilePad";
            this.textBoxFilePad.Size = new System.Drawing.Size(324, 22);
            this.textBoxFilePad.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nupNumeroIteraciones);
            this.panel1.Controls.Add(this.CargarCSV);
            this.panel1.Controls.Add(this.lbNumeroIteraciones);
            this.panel1.Controls.Add(this.ButtonExplorar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.textBoxFilePad);
            this.panel1.Location = new System.Drawing.Point(31, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 157);
            this.panel1.TabIndex = 39;
            // 
            // nupNumeroIteraciones
            // 
            this.nupNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumeroIteraciones.Location = new System.Drawing.Point(364, 104);
            this.nupNumeroIteraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupNumeroIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumeroIteraciones.Name = "nupNumeroIteraciones";
            this.nupNumeroIteraciones.Size = new System.Drawing.Size(120, 26);
            this.nupNumeroIteraciones.TabIndex = 36;
            this.nupNumeroIteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CargarCSV
            // 
            this.CargarCSV.Location = new System.Drawing.Point(516, 53);
            this.CargarCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CargarCSV.Name = "CargarCSV";
            this.CargarCSV.Size = new System.Drawing.Size(111, 34);
            this.CargarCSV.TabIndex = 41;
            this.CargarCSV.Text = "Cargar";
            this.CargarCSV.UseVisualStyleBackColor = true;
            this.CargarCSV.Click += new System.EventHandler(this.CargarCSV_Click);
            // 
            // lbNumeroIteraciones
            // 
            this.lbNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroIteraciones.Location = new System.Drawing.Point(96, 101);
            this.lbNumeroIteraciones.Name = "lbNumeroIteraciones";
            this.lbNumeroIteraciones.Size = new System.Drawing.Size(245, 34);
            this.lbNumeroIteraciones.TabIndex = 35;
            this.lbNumeroIteraciones.Text = "Número de Iteraciones";
            // 
            // ButtonExplorar
            // 
            this.ButtonExplorar.Location = new System.Drawing.Point(516, 20);
            this.ButtonExplorar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExplorar.Name = "ButtonExplorar";
            this.ButtonExplorar.Size = new System.Drawing.Size(111, 28);
            this.ButtonExplorar.TabIndex = 40;
            this.ButtonExplorar.Text = "Explorar";
            this.ButtonExplorar.UseVisualStyleBackColor = true;
            this.ButtonExplorar.Click += new System.EventHandler(this.ButtonExplorar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cargar archivo: ";
            // 
            // lbSolucion
            // 
            this.lbSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolucion.Location = new System.Drawing.Point(27, 268);
            this.lbSolucion.Name = "lbSolucion";
            this.lbSolucion.Size = new System.Drawing.Size(245, 30);
            this.lbSolucion.TabIndex = 41;
            this.lbSolucion.Text = "Solución";
            // 
            // rtbSolucion
            // 
            this.rtbSolucion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbSolucion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSolucion.Location = new System.Drawing.Point(31, 301);
            this.rtbSolucion.Name = "rtbSolucion";
            this.rtbSolucion.ReadOnly = true;
            this.rtbSolucion.Size = new System.Drawing.Size(450, 100);
            this.rtbSolucion.TabIndex = 40;
            this.rtbSolucion.Text = "";
            // 
            // frmViajeroVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(732, 425);
            this.Controls.Add(this.lbSolucion);
            this.Controls.Add(this.rtbSolucion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTituloPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmViajeroVendedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajero Vendedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTituloPrincipal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFilePad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CargarCSV;
        private System.Windows.Forms.Button ButtonExplorar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupNumeroIteraciones;
        private System.Windows.Forms.Label lbNumeroIteraciones;
        private System.Windows.Forms.Label lbSolucion;
        private System.Windows.Forms.RichTextBox rtbSolucion;
    }
}