namespace ProblemasAscensionDeColinas
{
    partial class frmFuncionMinimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionMinimo));
            this.NumDimensiones = new System.Windows.Forms.NumericUpDown();
            this.lbPesoItem = new System.Windows.Forms.Label();
            this.lbTituloPrincipal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.pbFuncion = new System.Windows.Forms.PictureBox();
            this.NumIteracionMax = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroIteraciones = new System.Windows.Forms.Label();
            this.MinFuncion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBEstadoInicial = new System.Windows.Forms.TextBox();
            this.IterRealizadas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupTempMin = new System.Windows.Forms.NumericUpDown();
            this.nupTemMax = new System.Windows.Forms.NumericUpDown();
            this.nupAvalue = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbMinimos = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumDimensiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIteracionMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTempMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // NumDimensiones
            // 
            this.NumDimensiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDimensiones.Location = new System.Drawing.Point(167, 226);
            this.NumDimensiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumDimensiones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDimensiones.Name = "NumDimensiones";
            this.NumDimensiones.Size = new System.Drawing.Size(135, 30);
            this.NumDimensiones.TabIndex = 12;
            this.NumDimensiones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbPesoItem
            // 
            this.lbPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoItem.Location = new System.Drawing.Point(11, 226);
            this.lbPesoItem.Name = "lbPesoItem";
            this.lbPesoItem.Size = new System.Drawing.Size(148, 38);
            this.lbPesoItem.TabIndex = 11;
            this.lbPesoItem.Text = "Dimensiones";
            // 
            // lbTituloPrincipal
            // 
            this.lbTituloPrincipal.AutoSize = true;
            this.lbTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrincipal.Location = new System.Drawing.Point(100, 45);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(372, 37);
            this.lbTituloPrincipal.TabIndex = 10;
            this.lbTituloPrincipal.Text = "Mínimo de una Función";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(525, 274);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 40);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(12, 122);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(343, 38);
            this.lbDescripcion.TabIndex = 31;
            this.lbDescripcion.Text = "Calcula el mínimo de la función";
            // 
            // pbFuncion
            // 
            this.pbFuncion.Image = ((System.Drawing.Image)(resources.GetObject("pbFuncion.Image")));
            this.pbFuncion.Location = new System.Drawing.Point(51, 162);
            this.pbFuncion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFuncion.Name = "pbFuncion";
            this.pbFuncion.Size = new System.Drawing.Size(429, 39);
            this.pbFuncion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncion.TabIndex = 32;
            this.pbFuncion.TabStop = false;
            // 
            // NumIteracionMax
            // 
            this.NumIteracionMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumIteracionMax.Location = new System.Drawing.Point(934, 274);
            this.NumIteracionMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumIteracionMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumIteracionMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumIteracionMax.Name = "NumIteracionMax";
            this.NumIteracionMax.Size = new System.Drawing.Size(135, 30);
            this.NumIteracionMax.TabIndex = 34;
            this.NumIteracionMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumeroIteraciones
            // 
            this.lbNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroIteraciones.Location = new System.Drawing.Point(693, 276);
            this.lbNumeroIteraciones.Name = "lbNumeroIteraciones";
            this.lbNumeroIteraciones.Size = new System.Drawing.Size(234, 38);
            this.lbNumeroIteraciones.TabIndex = 33;
            this.lbNumeroIteraciones.Text = "Número de Iteraciones";
            // 
            // MinFuncion
            // 
            this.MinFuncion.Location = new System.Drawing.Point(1060, 514);
            this.MinFuncion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinFuncion.Name = "MinFuncion";
            this.MinFuncion.Size = new System.Drawing.Size(850, 26);
            this.MinFuncion.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 38);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mínimo de la función =";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(806, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 38);
            this.label2.TabIndex = 37;
            this.label2.Text = "Estado Inicial =";
            // 
            // TBEstadoInicial
            // 
            this.TBEstadoInicial.Location = new System.Drawing.Point(1052, 391);
            this.TBEstadoInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBEstadoInicial.Name = "TBEstadoInicial";
            this.TBEstadoInicial.Size = new System.Drawing.Size(850, 26);
            this.TBEstadoInicial.TabIndex = 38;
            // 
            // IterRealizadas
            // 
            this.IterRealizadas.Enabled = false;
            this.IterRealizadas.Location = new System.Drawing.Point(973, 40);
            this.IterRealizadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IterRealizadas.Name = "IterRealizadas";
            this.IterRealizadas.Size = new System.Drawing.Size(127, 26);
            this.IterRealizadas.TabIndex = 39;
            this.IterRealizadas.Visible = false;
            // 
            // label3
            // 
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(798, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 62);
            this.label3.TabIndex = 40;
            this.label3.Text = "Iteraciones realizadas";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1128, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 66);
            this.label4.TabIndex = 41;
            this.label4.Text = "Temperatura mínima";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1128, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 68);
            this.label5.TabIndex = 42;
            this.label5.Text = "Temperatura máxima";
            // 
            // nupTempMin
            // 
            this.nupTempMin.DecimalPlaces = 4;
            this.nupTempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTempMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nupTempMin.Location = new System.Drawing.Point(952, 183);
            this.nupTempMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupTempMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupTempMin.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nupTempMin.Name = "nupTempMin";
            this.nupTempMin.Size = new System.Drawing.Size(159, 30);
            this.nupTempMin.TabIndex = 43;
            this.nupTempMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // nupTemMax
            // 
            this.nupTemMax.DecimalPlaces = 4;
            this.nupTemMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTemMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupTemMax.Location = new System.Drawing.Point(1284, 295);
            this.nupTemMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupTemMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupTemMax.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nupTemMax.Name = "nupTemMax";
            this.nupTemMax.Size = new System.Drawing.Size(159, 30);
            this.nupTemMax.TabIndex = 44;
            this.nupTemMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nupAvalue
            // 
            this.nupAvalue.DecimalPlaces = 3;
            this.nupAvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupAvalue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupAvalue.Location = new System.Drawing.Point(1196, 183);
            this.nupAvalue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupAvalue.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupAvalue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nupAvalue.Name = "nupAvalue";
            this.nupAvalue.Size = new System.Drawing.Size(135, 30);
            this.nupAvalue.TabIndex = 45;
            this.nupAvalue.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1142, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 38);
            this.label6.TabIndex = 46;
            this.label6.Text = "a: ";
            // 
            // rtbMinimos
            // 
            this.rtbMinimos.Location = new System.Drawing.Point(17, 329);
            this.rtbMinimos.Name = "rtbMinimos";
            this.rtbMinimos.Size = new System.Drawing.Size(645, 183);
            this.rtbMinimos.TabIndex = 47;
            this.rtbMinimos.Text = "";
            // 
            // frmFuncionMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(688, 566);
            this.Controls.Add(this.rtbMinimos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nupAvalue);
            this.Controls.Add(this.nupTemMax);
            this.Controls.Add(this.nupTempMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IterRealizadas);
            this.Controls.Add(this.TBEstadoInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinFuncion);
            this.Controls.Add(this.NumIteracionMax);
            this.Controls.Add(this.lbNumeroIteraciones);
            this.Controls.Add(this.pbFuncion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.NumDimensiones);
            this.Controls.Add(this.lbPesoItem);
            this.Controls.Add(this.lbTituloPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmFuncionMinimo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcion Minimo";
            ((System.ComponentModel.ISupportInitialize)(this.NumDimensiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIteracionMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTempMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTemMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAvalue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumDimensiones;
        private System.Windows.Forms.Label lbPesoItem;
        private System.Windows.Forms.Label lbTituloPrincipal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.PictureBox pbFuncion;
        private System.Windows.Forms.NumericUpDown NumIteracionMax;
        private System.Windows.Forms.Label lbNumeroIteraciones;
        private System.Windows.Forms.TextBox MinFuncion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBEstadoInicial;
        private System.Windows.Forms.TextBox IterRealizadas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupTempMin;
        private System.Windows.Forms.NumericUpDown nupTemMax;
        private System.Windows.Forms.NumericUpDown nupAvalue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbMinimos;
    }
}