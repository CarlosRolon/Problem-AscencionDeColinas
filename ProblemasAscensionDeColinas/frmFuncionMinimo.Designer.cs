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
            this.nupPesoItem = new System.Windows.Forms.NumericUpDown();
            this.lbPesoItem = new System.Windows.Forms.Label();
            this.lbTituloPrincipal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // nupPesoItem
            // 
            this.nupPesoItem.DecimalPlaces = 2;
            this.nupPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPesoItem.Location = new System.Drawing.Point(285, 114);
            this.nupPesoItem.Name = "nupPesoItem";
            this.nupPesoItem.Size = new System.Drawing.Size(120, 26);
            this.nupPesoItem.TabIndex = 12;
            // 
            // lbPesoItem
            // 
            this.lbPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoItem.Location = new System.Drawing.Point(160, 110);
            this.lbPesoItem.Name = "lbPesoItem";
            this.lbPesoItem.Size = new System.Drawing.Size(102, 30);
            this.lbPesoItem.TabIndex = 11;
            this.lbPesoItem.Text = "Dimension";
            // 
            // lbTituloPrincipal
            // 
            this.lbTituloPrincipal.AutoSize = true;
            this.lbTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrincipal.Location = new System.Drawing.Point(176, 21);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(314, 31);
            this.lbTituloPrincipal.TabIndex = 10;
            this.lbTituloPrincipal.Text = "Minimo de una Función";
            // 
            // frmFuncionMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 473);
            this.Controls.Add(this.nupPesoItem);
            this.Controls.Add(this.lbPesoItem);
            this.Controls.Add(this.lbTituloPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmFuncionMinimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcion Minimo";
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupPesoItem;
        private System.Windows.Forms.Label lbPesoItem;
        private System.Windows.Forms.Label lbTituloPrincipal;
    }
}