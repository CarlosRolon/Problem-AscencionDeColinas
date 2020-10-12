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
            this.nupNumeroIteraciones = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroIteraciones = new System.Windows.Forms.Label();
            this.rtbSolucion = new System.Windows.Forms.RichTextBox();
            this.lbSolucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoMaximo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroIteraciones)).BeginInit();
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
            this.lbPeso.Location = new System.Drawing.Point(8, 130);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(227, 30);
            this.lbPeso.TabIndex = 5;
            this.lbPeso.Text = "Peso Máximo Mochila\r\n\r\n";
            // 
            // nupPesoMaximo
            // 
            this.nupPesoMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPesoMaximo.Location = new System.Drawing.Point(236, 129);
            this.nupPesoMaximo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupPesoMaximo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupPesoMaximo.Name = "nupPesoMaximo";
            this.nupPesoMaximo.Size = new System.Drawing.Size(120, 26);
            this.nupPesoMaximo.TabIndex = 6;
            // 
            // lbTitleItems
            // 
            this.lbTitleItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleItems.Location = new System.Drawing.Point(8, 180);
            this.lbTitleItems.Name = "lbTitleItems";
            this.lbTitleItems.Size = new System.Drawing.Size(83, 30);
            this.lbTitleItems.TabIndex = 7;
            this.lbTitleItems.Text = "Items";
            // 
            // lbPesoItem
            // 
            this.lbPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPesoItem.Location = new System.Drawing.Point(8, 222);
            this.lbPesoItem.Name = "lbPesoItem";
            this.lbPesoItem.Size = new System.Drawing.Size(101, 30);
            this.lbPesoItem.TabIndex = 8;
            this.lbPesoItem.Text = "Peso Item";
            // 
            // nupPesoItem
            // 
            this.nupPesoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPesoItem.Location = new System.Drawing.Point(103, 220);
            this.nupPesoItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupPesoItem.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupPesoItem.Name = "nupPesoItem";
            this.nupPesoItem.Size = new System.Drawing.Size(120, 26);
            this.nupPesoItem.TabIndex = 9;
            // 
            // lbValorItem
            // 
            this.lbValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorItem.Location = new System.Drawing.Point(232, 222);
            this.lbValorItem.Name = "lbValorItem";
            this.lbValorItem.Size = new System.Drawing.Size(101, 30);
            this.lbValorItem.TabIndex = 10;
            this.lbValorItem.Text = "Valor Item";
            // 
            // nupValorItem
            // 
            this.nupValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupValorItem.Location = new System.Drawing.Point(323, 220);
            this.nupValorItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupValorItem.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupValorItem.Name = "nupValorItem";
            this.nupValorItem.Size = new System.Drawing.Size(120, 26);
            this.nupValorItem.TabIndex = 11;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarItem.Location = new System.Drawing.Point(451, 217);
            this.btnAgregarItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(119, 32);
            this.btnAgregarItem.TabIndex = 12;
            this.btnAgregarItem.Text = "Agregar Item";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(451, 510);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 32);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // listbItems
            // 
            this.listbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbItems.FormattingEnabled = true;
            this.listbItems.ItemHeight = 20;
            this.listbItems.Location = new System.Drawing.Point(103, 289);
            this.listbItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbItems.Name = "listbItems";
            this.listbItems.Size = new System.Drawing.Size(339, 164);
            this.listbItems.TabIndex = 14;
            // 
            // btnEliminarTodosItems
            // 
            this.btnEliminarTodosItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodosItems.Location = new System.Drawing.Point(451, 327);
            this.btnEliminarTodosItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTodosItems.Name = "btnEliminarTodosItems";
            this.btnEliminarTodosItems.Size = new System.Drawing.Size(119, 92);
            this.btnEliminarTodosItems.TabIndex = 15;
            this.btnEliminarTodosItems.Text = "Eliminar Todos Items";
            this.btnEliminarTodosItems.UseVisualStyleBackColor = true;
            this.btnEliminarTodosItems.Click += new System.EventHandler(this.btnEliminarTodosItems_Click);
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarItem.Location = new System.Drawing.Point(451, 289);
            this.btnEliminarItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(119, 32);
            this.btnEliminarItem.TabIndex = 16;
            this.btnEliminarItem.Text = "Eliminar Item";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // nupNumeroIteraciones
            // 
            this.nupNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumeroIteraciones.Location = new System.Drawing.Point(449, 471);
            this.nupNumeroIteraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupNumeroIteraciones.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
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
            // lbNumeroIteraciones
            // 
            this.lbNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroIteraciones.Location = new System.Drawing.Point(198, 473);
            this.lbNumeroIteraciones.Name = "lbNumeroIteraciones";
            this.lbNumeroIteraciones.Size = new System.Drawing.Size(245, 30);
            this.lbNumeroIteraciones.TabIndex = 35;
            this.lbNumeroIteraciones.Text = "Número de Iteraciones";
            // 
            // rtbSolucion
            // 
            this.rtbSolucion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rtbSolucion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbSolucion.Location = new System.Drawing.Point(12, 573);
            this.rtbSolucion.Name = "rtbSolucion";
            this.rtbSolucion.ReadOnly = true;
            this.rtbSolucion.Size = new System.Drawing.Size(450, 100);
            this.rtbSolucion.TabIndex = 37;
            this.rtbSolucion.Text = "";
            // 
            // lbSolucion
            // 
            this.lbSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSolucion.Location = new System.Drawing.Point(8, 540);
            this.lbSolucion.Name = "lbSolucion";
            this.lbSolucion.Size = new System.Drawing.Size(245, 30);
            this.lbSolucion.TabIndex = 38;
            this.lbSolucion.Text = "Solución";
            // 
            // frmMochila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(582, 703);
            this.Controls.Add(this.lbSolucion);
            this.Controls.Add(this.rtbSolucion);
            this.Controls.Add(this.nupNumeroIteraciones);
            this.Controls.Add(this.lbNumeroIteraciones);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMochila";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problema de la mochila";
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoMaximo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPesoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroIteraciones)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nupNumeroIteraciones;
        private System.Windows.Forms.Label lbNumeroIteraciones;
        private System.Windows.Forms.RichTextBox rtbSolucion;
        private System.Windows.Forms.Label lbSolucion;
    }
}