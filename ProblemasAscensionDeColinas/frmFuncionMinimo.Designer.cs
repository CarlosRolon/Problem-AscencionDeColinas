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
            ((System.ComponentModel.ISupportInitialize)(this.NumDimensiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumIteracionMax)).BeginInit();
            this.SuspendLayout();
            // 
            // NumDimensiones
            // 
            this.NumDimensiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDimensiones.Location = new System.Drawing.Point(258, 274);
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
            this.lbPesoItem.Location = new System.Drawing.Point(102, 274);
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
            this.btnCalcular.Location = new System.Drawing.Point(183, 435);
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
            this.NumIteracionMax.Location = new System.Drawing.Point(258, 324);
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
            this.lbNumeroIteraciones.Location = new System.Drawing.Point(17, 326);
            this.lbNumeroIteraciones.Name = "lbNumeroIteraciones";
            this.lbNumeroIteraciones.Size = new System.Drawing.Size(234, 38);
            this.lbNumeroIteraciones.TabIndex = 33;
            this.lbNumeroIteraciones.Text = "Número de Iteraciones";
            // 
            // MinFuncion
            // 
            this.MinFuncion.Location = new System.Drawing.Point(258, 519);
            this.MinFuncion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinFuncion.Name = "MinFuncion";
            this.MinFuncion.Size = new System.Drawing.Size(797, 26);
            this.MinFuncion.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 38);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mínimo de la función =";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 38);
            this.label2.TabIndex = 37;
            this.label2.Text = "Estado Inicial =";
            // 
            // TBEstadoInicial
            // 
            this.TBEstadoInicial.Location = new System.Drawing.Point(258, 481);
            this.TBEstadoInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TBEstadoInicial.Name = "TBEstadoInicial";
            this.TBEstadoInicial.Size = new System.Drawing.Size(797, 26);
            this.TBEstadoInicial.TabIndex = 38;
            // 
            // IterRealizadas
            // 
            this.IterRealizadas.Location = new System.Drawing.Point(823, 274);
            this.IterRealizadas.Name = "IterRealizadas";
            this.IterRealizadas.Size = new System.Drawing.Size(127, 26);
            this.IterRealizadas.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 62);
            this.label3.TabIndex = 40;
            this.label3.Text = "Iteraciones realizadas";
            // 
            // frmFuncionMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1122, 566);
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
    }
}