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
            this.nupPesoItem = new System.Windows.Forms.NumericUpDown();
            this.lbPesoItem = new System.Windows.Forms.Label();
            this.lbTituloPrincipal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.pbFuncion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncion)).BeginInit();
            this.SuspendLayout();
            // 
            // nupPesoItem
            // 
            this.nupPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPesoItem.Location = new System.Drawing.Point(171, 200);
            this.nupPesoItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupPesoItem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPesoItem.Name = "nupPesoItem";
            this.nupPesoItem.Size = new System.Drawing.Size(90, 23);
            this.nupPesoItem.TabIndex = 12;
            this.nupPesoItem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbPesoItem
            // 
            this.lbPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoItem.Location = new System.Drawing.Point(91, 202);
            this.lbPesoItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPesoItem.Name = "lbPesoItem";
            this.lbPesoItem.Size = new System.Drawing.Size(76, 24);
            this.lbPesoItem.TabIndex = 11;
            this.lbPesoItem.Text = "Dimension";
            // 
            // lbTituloPrincipal
            // 
            this.lbTituloPrincipal.AutoSize = true;
            this.lbTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrincipal.Location = new System.Drawing.Point(67, 29);
            this.lbTituloPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(259, 26);
            this.lbTituloPrincipal.TabIndex = 10;
            this.lbTituloPrincipal.Text = "Minimo de una Función";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(146, 276);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 26);
            this.btnCalcular.TabIndex = 30;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcion.Location = new System.Drawing.Point(8, 80);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(229, 24);
            this.lbDescripcion.TabIndex = 31;
            this.lbDescripcion.Text = "Calcula el minimo de la función";
            // 
            // pbFuncion
            // 
            this.pbFuncion.Image = ((System.Drawing.Image)(resources.GetObject("pbFuncion.Image")));
            this.pbFuncion.Location = new System.Drawing.Point(34, 106);
            this.pbFuncion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbFuncion.Name = "pbFuncion";
            this.pbFuncion.Size = new System.Drawing.Size(286, 25);
            this.pbFuncion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncion.TabIndex = 32;
            this.pbFuncion.TabStop = false;
            // 
            // frmFuncionMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(362, 368);
            this.Controls.Add(this.pbFuncion);
            this.Controls.Add(this.lbDescripcion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nupPesoItem);
            this.Controls.Add(this.lbPesoItem);
            this.Controls.Add(this.lbTituloPrincipal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmFuncionMinimo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcion Minimo";
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupPesoItem;
        private System.Windows.Forms.Label lbPesoItem;
        private System.Windows.Forms.Label lbTituloPrincipal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.PictureBox pbFuncion;
    }
}