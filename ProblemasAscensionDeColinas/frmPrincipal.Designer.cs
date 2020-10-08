namespace ProblemasAscensionDeColinas
{
    partial class frmMenu
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
            this.btnMochila = new System.Windows.Forms.Button();
            this.btnViajero = new System.Windows.Forms.Button();
            this.btnLimiteFuncion = new System.Windows.Forms.Button();
            this.lbTituloPrincipal = new System.Windows.Forms.Label();
            this.lbInformacionUsurio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMochila
            // 
            this.btnMochila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMochila.Location = new System.Drawing.Point(84, 107);
            this.btnMochila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMochila.Name = "btnMochila";
            this.btnMochila.Size = new System.Drawing.Size(224, 37);
            this.btnMochila.TabIndex = 0;
            this.btnMochila.Text = "Problema de la mochila";
            this.btnMochila.UseVisualStyleBackColor = true;
            this.btnMochila.Click += new System.EventHandler(this.btnMochila_Click);
            // 
            // btnViajero
            // 
            this.btnViajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViajero.Location = new System.Drawing.Point(84, 161);
            this.btnViajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViajero.Name = "btnViajero";
            this.btnViajero.Size = new System.Drawing.Size(224, 37);
            this.btnViajero.TabIndex = 1;
            this.btnViajero.Text = "Problema del viajero vendedor";
            this.btnViajero.UseVisualStyleBackColor = true;
            this.btnViajero.Click += new System.EventHandler(this.btnViajero_Click);
            // 
            // btnLimiteFuncion
            // 
            this.btnLimiteFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimiteFuncion.Location = new System.Drawing.Point(84, 212);
            this.btnLimiteFuncion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimiteFuncion.Name = "btnLimiteFuncion";
            this.btnLimiteFuncion.Size = new System.Drawing.Size(224, 37);
            this.btnLimiteFuncion.TabIndex = 2;
            this.btnLimiteFuncion.Text = "Limites de la función";
            this.btnLimiteFuncion.UseVisualStyleBackColor = true;
            this.btnLimiteFuncion.Click += new System.EventHandler(this.btnLimiteFuncion_Click);
            // 
            // lbTituloPrincipal
            // 
            this.lbTituloPrincipal.AutoSize = true;
            this.lbTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrincipal.Location = new System.Drawing.Point(80, 44);
            this.lbTituloPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(258, 26);
            this.lbTituloPrincipal.TabIndex = 3;
            this.lbTituloPrincipal.Text = "Selecccionar Problema";
            // 
            // lbInformacionUsurio
            // 
            this.lbInformacionUsurio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacionUsurio.Location = new System.Drawing.Point(5, 307);
            this.lbInformacionUsurio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInformacionUsurio.Name = "lbInformacionUsurio";
            this.lbInformacionUsurio.Size = new System.Drawing.Size(303, 93);
            this.lbInformacionUsurio.TabIndex = 4;
            this.lbInformacionUsurio.Text = "Alumnos: \r\n    -     Carlos Alberto Rolón González\r\n    -     Rodrigo Castañón Mé" +
    "ndez \r\nAsignatura: Metaheurísticas\r\nProfesora: Dra. Yenny Villuendas Rey\r\n";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 409);
            this.Controls.Add(this.lbInformacionUsurio);
            this.Controls.Add(this.lbTituloPrincipal);
            this.Controls.Add(this.btnLimiteFuncion);
            this.Controls.Add(this.btnViajero);
            this.Controls.Add(this.btnMochila);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMochila;
        private System.Windows.Forms.Button btnViajero;
        private System.Windows.Forms.Button btnLimiteFuncion;
        private System.Windows.Forms.Label lbTituloPrincipal;
        private System.Windows.Forms.Label lbInformacionUsurio;
    }
}

