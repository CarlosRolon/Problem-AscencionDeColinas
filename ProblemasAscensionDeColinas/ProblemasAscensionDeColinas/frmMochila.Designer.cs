namespace ProblemasAscensionDeColinas
{
    partial class frmMochila
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
            this.lbPeso = new System.Windows.Forms.Label();
            this.nupPesoMaximo = new System.Windows.Forms.NumericUpDown();
            this.lbTitleItems = new System.Windows.Forms.Label();
            this.lbPesoItem = new System.Windows.Forms.Label();
            this.nupPesoItem = new System.Windows.Forms.NumericUpDown();
            this.lbValorItem = new System.Windows.Forms.Label();
            this.nupValorItem = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.listbItems = new System.Windows.Forms.ListBox();
            this.btnEliminarTodosItems = new System.Windows.Forms.Button();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorItem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTituloPrincipal
            // 
            this.lbTituloPrincipal.AutoSize = true;
            this.lbTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrincipal.Location = new System.Drawing.Point(141, 38);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(316, 31);
            this.lbTituloPrincipal.TabIndex = 4;
            this.lbTituloPrincipal.Text = "Problema de la mochila";
            // 
            // lbPeso
            // 
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso.Location = new System.Drawing.Point(8, 131);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(226, 30);
            this.lbPeso.TabIndex = 5;
            this.lbPeso.Text = "Peso Máximo Mochila\r\n\r\n";
            // 
            // nupPesoMaximo
            // 
            this.nupPesoMaximo.DecimalPlaces = 2;
            this.nupPesoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPesoMaximo.Location = new System.Drawing.Point(236, 129);
            this.nupPesoMaximo.Name = "nupPesoMaximo";
            this.nupPesoMaximo.Size = new System.Drawing.Size(120, 26);
            this.nupPesoMaximo.TabIndex = 6;
            // 
            // lbTitleItems
            // 
            this.lbTitleItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleItems.Location = new System.Drawing.Point(8, 180);
            this.lbTitleItems.Name = "lbTitleItems";
            this.lbTitleItems.Size = new System.Drawing.Size(82, 30);
            this.lbTitleItems.TabIndex = 7;
            this.lbTitleItems.Text = "Items";
            // 
            // lbPesoItem
            // 
            this.lbPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoItem.Location = new System.Drawing.Point(8, 222);
            this.lbPesoItem.Name = "lbPesoItem";
            this.lbPesoItem.Size = new System.Drawing.Size(102, 30);
            this.lbPesoItem.TabIndex = 8;
            this.lbPesoItem.Text = "Peso Item";
            // 
            // nupPesoItem
            // 
            this.nupPesoItem.DecimalPlaces = 2;
            this.nupPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPesoItem.Location = new System.Drawing.Point(103, 220);
            this.nupPesoItem.Name = "nupPesoItem";
            this.nupPesoItem.Size = new System.Drawing.Size(120, 26);
            this.nupPesoItem.TabIndex = 9;
            // 
            // lbValorItem
            // 
            this.lbValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorItem.Location = new System.Drawing.Point(232, 222);
            this.lbValorItem.Name = "lbValorItem";
            this.lbValorItem.Size = new System.Drawing.Size(102, 30);
            this.lbValorItem.TabIndex = 10;
            this.lbValorItem.Text = "Valor Item";
            // 
            // nupValorItem
            // 
            this.nupValorItem.DecimalPlaces = 2;
            this.nupValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupValorItem.Location = new System.Drawing.Point(322, 220);
            this.nupValorItem.Name = "nupValorItem";
            this.nupValorItem.Size = new System.Drawing.Size(120, 26);
            this.nupValorItem.TabIndex = 11;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.Location = new System.Drawing.Point(451, 216);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(119, 32);
            this.btnAgregarItem.TabIndex = 12;
            this.btnAgregarItem.Text = "Agregar Item";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(451, 509);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 32);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // listbItems
            // 
            this.listbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbItems.FormattingEnabled = true;
            this.listbItems.ItemHeight = 20;
            this.listbItems.Location = new System.Drawing.Point(103, 289);
            this.listbItems.Name = "listbItems";
            this.listbItems.Size = new System.Drawing.Size(339, 184);
            this.listbItems.TabIndex = 14;
            // 
            // btnEliminarTodosItems
            // 
            this.btnEliminarTodosItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodosItems.Location = new System.Drawing.Point(451, 327);
            this.btnEliminarTodosItems.Name = "btnEliminarTodosItems";
            this.btnEliminarTodosItems.Size = new System.Drawing.Size(119, 56);
            this.btnEliminarTodosItems.TabIndex = 15;
            this.btnEliminarTodosItems.Text = "Eliminar Todos Items";
            this.btnEliminarTodosItems.UseVisualStyleBackColor = true;
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarItem.Location = new System.Drawing.Point(451, 289);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(119, 32);
            this.btnEliminarItem.TabIndex = 16;
            this.btnEliminarItem.Text = "Eliminar Item";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            // 
            // frmMochila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.nupPesoMaximo);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.btnEliminarItem);
            this.Controls.Add(this.btnEliminarTodosItems);
            this.Controls.Add(this.listbItems);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnAgregarItem);
            this.Controls.Add(this.nupValorItem);
            this.Controls.Add(this.lbValorItem);
            this.Controls.Add(this.nupPesoItem);
            this.Controls.Add(this.lbPesoItem);
            this.Controls.Add(this.lbTitleItems);
            this.Controls.Add(this.lbTituloPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmMochila";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problema de la mochila";
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTituloPrincipal;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.NumericUpDown nupPesoMaximo;
        private System.Windows.Forms.Label lbTitleItems;
        private System.Windows.Forms.Label lbPesoItem;
        private System.Windows.Forms.NumericUpDown nupPesoItem;
        private System.Windows.Forms.Label lbValorItem;
        private System.Windows.Forms.NumericUpDown nupValorItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox listbItems;
        private System.Windows.Forms.Button btnEliminarTodosItems;
        private System.Windows.Forms.Button btnEliminarItem;
    }
}