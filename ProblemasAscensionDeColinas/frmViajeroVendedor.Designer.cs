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
            this.nupA = new System.Windows.Forms.NumericUpDown();
            this.lbA = new System.Windows.Forms.Label();
            this.nupTemperaturaMin = new System.Windows.Forms.NumericUpDown();
            this.lbTemperaturaMin = new System.Windows.Forms.Label();
            this.nupTemperaturaInicial = new System.Windows.Forms.NumericUpDown();
            this.lbTemperaturaInicial = new System.Windows.Forms.Label();
            this.nupNumeroIteraciones = new System.Windows.Forms.NumericUpDown();
            this.CargarCSV = new System.Windows.Forms.Button();
            this.lbNumeroIteraciones = new System.Windows.Forms.Label();
            this.ButtonExplorar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSolucion = new System.Windows.Forms.Label();
            this.rtbSolucion = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemperaturaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemperaturaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloPrincipal
            // 
            this.lbTituloPrincipal.AutoSize = true;
            this.lbTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrincipal.Location = new System.Drawing.Point(197, 29);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(491, 37);
            this.lbTituloPrincipal.TabIndex = 17;
            this.lbTituloPrincipal.Text = "Problema del Viajero Vendedor";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(581, 296);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 40);
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
            this.textBoxFilePad.Location = new System.Drawing.Point(195, 29);
            this.textBoxFilePad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFilePad.Name = "textBoxFilePad";
            this.textBoxFilePad.Size = new System.Drawing.Size(364, 26);
            this.textBoxFilePad.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CargarCSV);
            this.panel1.Controls.Add(this.ButtonExplorar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxFilePad);
            this.panel1.Location = new System.Drawing.Point(35, 108);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 141);
            this.panel1.TabIndex = 39;
            // 
            // nupA
            // 
            this.nupA.DecimalPlaces = 2;
            this.nupA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupA.Location = new System.Drawing.Point(893, 443);
            this.nupA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupA.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            131072});
            this.nupA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nupA.Name = "nupA";
            this.nupA.Size = new System.Drawing.Size(135, 30);
            this.nupA.TabIndex = 50;
            this.nupA.Value = new decimal(new int[] {
            90,
            0,
            0,
            131072});
            // 
            // lbA
            // 
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(821, 443);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(46, 38);
            this.lbA.TabIndex = 49;
            this.lbA.Text = "a";
            // 
            // nupTemperaturaMin
            // 
            this.nupTemperaturaMin.DecimalPlaces = 3;
            this.nupTemperaturaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTemperaturaMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupTemperaturaMin.Location = new System.Drawing.Point(1162, 380);
            this.nupTemperaturaMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupTemperaturaMin.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupTemperaturaMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.nupTemperaturaMin.Name = "nupTemperaturaMin";
            this.nupTemperaturaMin.Size = new System.Drawing.Size(135, 30);
            this.nupTemperaturaMin.TabIndex = 48;
            this.nupTemperaturaMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lbTemperaturaMin
            // 
            this.lbTemperaturaMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperaturaMin.Location = new System.Drawing.Point(798, 383);
            this.lbTemperaturaMin.Name = "lbTemperaturaMin";
            this.lbTemperaturaMin.Size = new System.Drawing.Size(328, 38);
            this.lbTemperaturaMin.TabIndex = 47;
            this.lbTemperaturaMin.Text = "Temperatura Minima    T < ";
            // 
            // nupTemperaturaInicial
            // 
            this.nupTemperaturaInicial.DecimalPlaces = 3;
            this.nupTemperaturaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTemperaturaInicial.Location = new System.Drawing.Point(1162, 310);
            this.nupTemperaturaInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupTemperaturaInicial.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupTemperaturaInicial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nupTemperaturaInicial.Name = "nupTemperaturaInicial";
            this.nupTemperaturaInicial.Size = new System.Drawing.Size(135, 30);
            this.nupTemperaturaInicial.TabIndex = 46;
            this.nupTemperaturaInicial.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lbTemperaturaInicial
            // 
            this.lbTemperaturaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperaturaInicial.Location = new System.Drawing.Point(798, 313);
            this.lbTemperaturaInicial.Name = "lbTemperaturaInicial";
            this.lbTemperaturaInicial.Size = new System.Drawing.Size(299, 38);
            this.lbTemperaturaInicial.TabIndex = 45;
            this.lbTemperaturaInicial.Text = "Temperatura Inicial";
            // 
            // nupNumeroIteraciones
            // 
            this.nupNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumeroIteraciones.Location = new System.Drawing.Point(1162, 238);
            this.nupNumeroIteraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupNumeroIteraciones.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupNumeroIteraciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNumeroIteraciones.Name = "nupNumeroIteraciones";
            this.nupNumeroIteraciones.Size = new System.Drawing.Size(135, 30);
            this.nupNumeroIteraciones.TabIndex = 36;
            this.nupNumeroIteraciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CargarCSV
            // 
            this.CargarCSV.Location = new System.Drawing.Point(580, 66);
            this.CargarCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CargarCSV.Name = "CargarCSV";
            this.CargarCSV.Size = new System.Drawing.Size(125, 42);
            this.CargarCSV.TabIndex = 41;
            this.CargarCSV.Text = "Cargar";
            this.CargarCSV.UseVisualStyleBackColor = true;
            this.CargarCSV.Click += new System.EventHandler(this.CargarCSV_Click);
            // 
            // lbNumeroIteraciones
            // 
            this.lbNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroIteraciones.Location = new System.Drawing.Point(789, 240);
            this.lbNumeroIteraciones.Name = "lbNumeroIteraciones";
            this.lbNumeroIteraciones.Size = new System.Drawing.Size(299, 42);
            this.lbNumeroIteraciones.TabIndex = 35;
            this.lbNumeroIteraciones.Text = "Número de Iteraciones";
            // 
            // ButtonExplorar
            // 
            this.ButtonExplorar.Location = new System.Drawing.Point(580, 25);
            this.ButtonExplorar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExplorar.Name = "ButtonExplorar";
            this.ButtonExplorar.Size = new System.Drawing.Size(125, 35);
            this.ButtonExplorar.TabIndex = 40;
            this.ButtonExplorar.Text = "Explorar";
            this.ButtonExplorar.UseVisualStyleBackColor = true;
            this.ButtonExplorar.Click += new System.EventHandler(this.ButtonExplorar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cargar archivo: ";
            // 
            // lbSolucion
            // 
            this.lbSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolucion.Location = new System.Drawing.Point(30, 304);
            this.lbSolucion.Name = "lbSolucion";
            this.lbSolucion.Size = new System.Drawing.Size(276, 38);
            this.lbSolucion.TabIndex = 41;
            this.lbSolucion.Text = "Solución";
            this.lbSolucion.Click += new System.EventHandler(this.lbSolucion_Click);
            // 
            // rtbSolucion
            // 
            this.rtbSolucion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSolucion.Location = new System.Drawing.Point(35, 346);
            this.rtbSolucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbSolucion.Name = "rtbSolucion";
            this.rtbSolucion.ReadOnly = true;
            this.rtbSolucion.Size = new System.Drawing.Size(682, 245);
            this.rtbSolucion.TabIndex = 40;
            this.rtbSolucion.Text = "";
            // 
            // frmViajeroVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(774, 691);
            this.Controls.Add(this.nupA);
            this.Controls.Add(this.lbSolucion);
            this.Controls.Add(this.rtbSolucion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.lbTituloPrincipal);
            this.Controls.Add(this.lbTemperaturaMin);
            this.Controls.Add(this.lbTemperaturaInicial);
            this.Controls.Add(this.nupTemperaturaMin);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nupTemperaturaInicial);
            this.Controls.Add(this.lbNumeroIteraciones);
            this.Controls.Add(this.nupNumeroIteraciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmViajeroVendedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajero Vendedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemperaturaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemperaturaInicial)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nupA;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.NumericUpDown nupTemperaturaMin;
        private System.Windows.Forms.Label lbTemperaturaMin;
        private System.Windows.Forms.NumericUpDown nupTemperaturaInicial;
        private System.Windows.Forms.Label lbTemperaturaInicial;
    }
}