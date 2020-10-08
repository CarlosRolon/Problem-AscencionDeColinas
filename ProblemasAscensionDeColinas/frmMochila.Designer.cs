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
            this.lbTituloPrincipal.Location = new System.Drawing.Point(106, 31);
            this.lbTituloPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(263, 26);
            this.lbTituloPrincipal.TabIndex = 4;
            this.lbTituloPrincipal.Text = "Problema de la mochila";
            // 
            // lbPeso
            // 
            this.lbPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeso.Location = new System.Drawing.Point(6, 106);
            this.lbPeso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(170, 24);
            this.lbPeso.TabIndex = 5;
            this.lbPeso.Text = "Peso Máximo Mochila\r\n\r\n";
            // 
            // nupPesoMaximo
            // 
            this.nupPesoMaximo.DecimalPlaces = 2;
            this.nupPesoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPesoMaximo.Location = new System.Drawing.Point(177, 105);
            this.nupPesoMaximo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupPesoMaximo.Name = "nupPesoMaximo";
            this.nupPesoMaximo.Size = new System.Drawing.Size(90, 23);
            this.nupPesoMaximo.TabIndex = 6;
            // 
            // lbTitleItems
            // 
            this.lbTitleItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleItems.Location = new System.Drawing.Point(6, 146);
            this.lbTitleItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitleItems.Name = "lbTitleItems";
            this.lbTitleItems.Size = new System.Drawing.Size(62, 24);
            this.lbTitleItems.TabIndex = 7;
            this.lbTitleItems.Text = "Items";
            // 
            // lbPesoItem
            // 
            this.lbPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoItem.Location = new System.Drawing.Point(6, 180);
            this.lbPesoItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPesoItem.Name = "lbPesoItem";
            this.lbPesoItem.Size = new System.Drawing.Size(76, 24);
            this.lbPesoItem.TabIndex = 8;
            this.lbPesoItem.Text = "Peso Item";
            // 
            // nupPesoItem
            // 
            this.nupPesoItem.DecimalPlaces = 2;
            this.nupPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPesoItem.Location = new System.Drawing.Point(77, 179);
            this.nupPesoItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupPesoItem.Name = "nupPesoItem";
            this.nupPesoItem.Size = new System.Drawing.Size(90, 23);
            this.nupPesoItem.TabIndex = 9;
            // 
            // lbValorItem
            // 
            this.lbValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorItem.Location = new System.Drawing.Point(174, 180);
            this.lbValorItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbValorItem.Name = "lbValorItem";
            this.lbValorItem.Size = new System.Drawing.Size(76, 24);
            this.lbValorItem.TabIndex = 10;
            this.lbValorItem.Text = "Valor Item";
            // 
            // nupValorItem
            // 
            this.nupValorItem.DecimalPlaces = 2;
            this.nupValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupValorItem.Location = new System.Drawing.Point(242, 179);
            this.nupValorItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nupValorItem.Name = "nupValorItem";
            this.nupValorItem.Size = new System.Drawing.Size(90, 23);
            this.nupValorItem.TabIndex = 11;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.Location = new System.Drawing.Point(338, 176);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(89, 26);
            this.btnAgregarItem.TabIndex = 12;
            this.btnAgregarItem.Text = "Agregar Item";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(338, 414);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 26);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // listbItems
            // 
            this.listbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbItems.FormattingEnabled = true;
            this.listbItems.ItemHeight = 16;
            this.listbItems.Items.AddRange(new object[] {
            "Item 1: Peso 5 - Valor 10",
            "Item 2: Peso 7 - Valor 3"});
            this.listbItems.Location = new System.Drawing.Point(77, 235);
            this.listbItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listbItems.Name = "listbItems";
            this.listbItems.Size = new System.Drawing.Size(255, 148);
            this.listbItems.TabIndex = 14;
            // 
            // btnEliminarTodosItems
            // 
            this.btnEliminarTodosItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodosItems.Location = new System.Drawing.Point(338, 266);
            this.btnEliminarTodosItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarTodosItems.Name = "btnEliminarTodosItems";
            this.btnEliminarTodosItems.Size = new System.Drawing.Size(89, 75);
            this.btnEliminarTodosItems.TabIndex = 15;
            this.btnEliminarTodosItems.Text = "Eliminar Todos Items";
            this.btnEliminarTodosItems.UseVisualStyleBackColor = true;
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarItem.Location = new System.Drawing.Point(338, 235);
            this.btnEliminarItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(89, 26);
            this.btnEliminarItem.TabIndex = 16;
            this.btnEliminarItem.Text = "Eliminar Item";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            // 
            // frmMochila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(436, 449);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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