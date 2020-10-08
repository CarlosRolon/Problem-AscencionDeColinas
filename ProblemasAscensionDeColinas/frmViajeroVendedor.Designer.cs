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
            this.btnEliminarCiudad = new System.Windows.Forms.Button();
            this.btnEliminarTodosItems = new System.Windows.Forms.Button();
            this.listbCiudades = new System.Windows.Forms.ListBox();
            this.btnContinuarPaso1 = new System.Windows.Forms.Button();
            this.lbTitlePaso1 = new System.Windows.Forms.Label();
            this.lbTituloPrincipal = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnAgregarCiudad = new System.Windows.Forms.Button();
            this.pnPaso1 = new System.Windows.Forms.Panel();
            this.pnPaso2 = new System.Windows.Forms.Panel();
            this.nupValorItem = new System.Windows.Forms.NumericUpDown();
            this.lbValorItem = new System.Windows.Forms.Label();
            this.cbCiudadDestino = new System.Windows.Forms.ComboBox();
            this.cbCiudadOrigen = new System.Windows.Forms.ComboBox();
            this.lbA = new System.Windows.Forms.Label();
            this.btnAgregarConexion = new System.Windows.Forms.Button();
            this.lbTitlePaso2 = new System.Windows.Forms.Label();
            this.btnContinuarPaso2 = new System.Windows.Forms.Button();
            this.btnEliminarTodasConexiones = new System.Windows.Forms.Button();
            this.btnEliminarConexion = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnPaso3 = new System.Windows.Forms.Panel();
            this.btnRegresarPaso2 = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbCiudadInicial = new System.Windows.Forms.ComboBox();
            this.lbPaso3 = new System.Windows.Forms.Label();
            this.btnRegresarPaso1 = new System.Windows.Forms.Button();
            this.nupNumeroIteraciones = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroIteraciones = new System.Windows.Forms.Label();
            this.pnPaso1.SuspendLayout();
            this.pnPaso2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupValorItem)).BeginInit();
            this.pnPaso3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroIteraciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCiudad
            // 
            this.btnEliminarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCiudad.Location = new System.Drawing.Point(11, 290);
            this.btnEliminarCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarCiudad.Name = "btnEliminarCiudad";
            this.btnEliminarCiudad.Size = new System.Drawing.Size(121, 57);
            this.btnEliminarCiudad.TabIndex = 29;
            this.btnEliminarCiudad.Text = "Eliminar\r\n Ciudad";
            this.btnEliminarCiudad.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTodosItems
            // 
            this.btnEliminarTodosItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodosItems.Location = new System.Drawing.Point(187, 290);
            this.btnEliminarTodosItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTodosItems.Name = "btnEliminarTodosItems";
            this.btnEliminarTodosItems.Size = new System.Drawing.Size(161, 57);
            this.btnEliminarTodosItems.TabIndex = 28;
            this.btnEliminarTodosItems.Text = "Eliminar Todas Las Ciudades";
            this.btnEliminarTodosItems.UseVisualStyleBackColor = true;
            // 
            // listbCiudades
            // 
            this.listbCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbCiudades.FormattingEnabled = true;
            this.listbCiudades.ItemHeight = 20;
            this.listbCiudades.Items.AddRange(new object[] {
            "Guadalajara",
            "Monterrey",
            "Ciudad de México"});
            this.listbCiudades.Location = new System.Drawing.Point(8, 92);
            this.listbCiudades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listbCiudades.Name = "listbCiudades";
            this.listbCiudades.Size = new System.Drawing.Size(339, 164);
            this.listbCiudades.TabIndex = 27;
            // 
            // btnContinuarPaso1
            // 
            this.btnContinuarPaso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarPaso1.Location = new System.Drawing.Point(229, 379);
            this.btnContinuarPaso1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinuarPaso1.Name = "btnContinuarPaso1";
            this.btnContinuarPaso1.Size = new System.Drawing.Size(119, 32);
            this.btnContinuarPaso1.TabIndex = 26;
            this.btnContinuarPaso1.Text = "Continuar ";
            this.btnContinuarPaso1.UseVisualStyleBackColor = true;
            this.btnContinuarPaso1.Click += new System.EventHandler(this.btnContinuarPaso1_Click);
            // 
            // lbTitlePaso1
            // 
            this.lbTitlePaso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlePaso1.Location = new System.Drawing.Point(4, 11);
            this.lbTitlePaso1.Name = "lbTitlePaso1";
            this.lbTitlePaso1.Size = new System.Drawing.Size(299, 30);
            this.lbTitlePaso1.TabIndex = 20;
            this.lbTitlePaso1.Text = "Paso 1: Ciudades";
            // 
            // lbTituloPrincipal
            // 
            this.lbTituloPrincipal.AutoSize = true;
            this.lbTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloPrincipal.Location = new System.Drawing.Point(368, 23);
            this.lbTituloPrincipal.Name = "lbTituloPrincipal";
            this.lbTituloPrincipal.Size = new System.Drawing.Size(416, 31);
            this.lbTituloPrincipal.TabIndex = 17;
            this.lbTituloPrincipal.Text = "Problema del Viajero Vendedor";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(8, 54);
            this.txtCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(196, 28);
            this.txtCiudad.TabIndex = 30;
            // 
            // btnAgregarCiudad
            // 
            this.btnAgregarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCiudad.Location = new System.Drawing.Point(211, 50);
            this.btnAgregarCiudad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCiudad.Name = "btnAgregarCiudad";
            this.btnAgregarCiudad.Size = new System.Drawing.Size(139, 32);
            this.btnAgregarCiudad.TabIndex = 31;
            this.btnAgregarCiudad.Text = "Agregar Ciudad";
            this.btnAgregarCiudad.UseVisualStyleBackColor = true;
            // 
            // pnPaso1
            // 
            this.pnPaso1.Controls.Add(this.btnAgregarCiudad);
            this.pnPaso1.Controls.Add(this.lbTitlePaso1);
            this.pnPaso1.Controls.Add(this.btnContinuarPaso1);
            this.pnPaso1.Controls.Add(this.btnEliminarTodosItems);
            this.pnPaso1.Controls.Add(this.btnEliminarCiudad);
            this.pnPaso1.Controls.Add(this.txtCiudad);
            this.pnPaso1.Controls.Add(this.listbCiudades);
            this.pnPaso1.Location = new System.Drawing.Point(12, 86);
            this.pnPaso1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPaso1.Name = "pnPaso1";
            this.pnPaso1.Size = new System.Drawing.Size(363, 431);
            this.pnPaso1.TabIndex = 32;
            // 
            // pnPaso2
            // 
            this.pnPaso2.Controls.Add(this.nupValorItem);
            this.pnPaso2.Controls.Add(this.lbValorItem);
            this.pnPaso2.Controls.Add(this.cbCiudadDestino);
            this.pnPaso2.Controls.Add(this.cbCiudadOrigen);
            this.pnPaso2.Controls.Add(this.lbA);
            this.pnPaso2.Controls.Add(this.btnAgregarConexion);
            this.pnPaso2.Controls.Add(this.lbTitlePaso2);
            this.pnPaso2.Controls.Add(this.btnContinuarPaso2);
            this.pnPaso2.Controls.Add(this.btnEliminarTodasConexiones);
            this.pnPaso2.Controls.Add(this.btnEliminarConexion);
            this.pnPaso2.Controls.Add(this.listBox1);
            this.pnPaso2.Enabled = false;
            this.pnPaso2.Location = new System.Drawing.Point(381, 86);
            this.pnPaso2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPaso2.Name = "pnPaso2";
            this.pnPaso2.Size = new System.Drawing.Size(421, 431);
            this.pnPaso2.TabIndex = 33;
            // 
            // nupValorItem
            // 
            this.nupValorItem.DecimalPlaces = 2;
            this.nupValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupValorItem.Location = new System.Drawing.Point(105, 96);
            this.nupValorItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nupValorItem.Name = "nupValorItem";
            this.nupValorItem.Size = new System.Drawing.Size(120, 26);
            this.nupValorItem.TabIndex = 36;
            // 
            // lbValorItem
            // 
            this.lbValorItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValorItem.Location = new System.Drawing.Point(15, 98);
            this.lbValorItem.Name = "lbValorItem";
            this.lbValorItem.Size = new System.Drawing.Size(101, 30);
            this.lbValorItem.TabIndex = 35;
            this.lbValorItem.Text = "Distancia";
            // 
            // cbCiudadDestino
            // 
            this.cbCiudadDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiudadDestino.FormattingEnabled = true;
            this.cbCiudadDestino.Items.AddRange(new object[] {
            "Guadalajara",
            "Monterrey",
            "Ciudad de México"});
            this.cbCiudadDestino.Location = new System.Drawing.Point(231, 57);
            this.cbCiudadDestino.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCiudadDestino.Name = "cbCiudadDestino";
            this.cbCiudadDestino.Size = new System.Drawing.Size(172, 26);
            this.cbCiudadDestino.TabIndex = 34;
            // 
            // cbCiudadOrigen
            // 
            this.cbCiudadOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiudadOrigen.FormattingEnabled = true;
            this.cbCiudadOrigen.Items.AddRange(new object[] {
            "Guadalajara",
            "Monterrey",
            "Ciudad de México"});
            this.cbCiudadOrigen.Location = new System.Drawing.Point(8, 57);
            this.cbCiudadOrigen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCiudadOrigen.Name = "cbCiudadOrigen";
            this.cbCiudadOrigen.Size = new System.Drawing.Size(181, 26);
            this.cbCiudadOrigen.TabIndex = 32;
            // 
            // lbA
            // 
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(195, 59);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(31, 30);
            this.lbA.TabIndex = 33;
            this.lbA.Text = "a";
            // 
            // btnAgregarConexion
            // 
            this.btnAgregarConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarConexion.Location = new System.Drawing.Point(268, 92);
            this.btnAgregarConexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarConexion.Name = "btnAgregarConexion";
            this.btnAgregarConexion.Size = new System.Drawing.Size(139, 32);
            this.btnAgregarConexion.TabIndex = 31;
            this.btnAgregarConexion.Text = "Agregar ";
            this.btnAgregarConexion.UseVisualStyleBackColor = true;
            // 
            // lbTitlePaso2
            // 
            this.lbTitlePaso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitlePaso2.Location = new System.Drawing.Point(4, 11);
            this.lbTitlePaso2.Name = "lbTitlePaso2";
            this.lbTitlePaso2.Size = new System.Drawing.Size(335, 30);
            this.lbTitlePaso2.TabIndex = 20;
            this.lbTitlePaso2.Text = "Paso 2: Conexiones";
            // 
            // btnContinuarPaso2
            // 
            this.btnContinuarPaso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuarPaso2.Location = new System.Drawing.Point(284, 379);
            this.btnContinuarPaso2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContinuarPaso2.Name = "btnContinuarPaso2";
            this.btnContinuarPaso2.Size = new System.Drawing.Size(119, 32);
            this.btnContinuarPaso2.TabIndex = 26;
            this.btnContinuarPaso2.Text = "Continuar ";
            this.btnContinuarPaso2.UseVisualStyleBackColor = true;
            this.btnContinuarPaso2.Click += new System.EventHandler(this.btnContinuarPaso2_Click);
            // 
            // btnEliminarTodasConexiones
            // 
            this.btnEliminarTodasConexiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodasConexiones.Location = new System.Drawing.Point(135, 354);
            this.btnEliminarTodasConexiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarTodasConexiones.Name = "btnEliminarTodasConexiones";
            this.btnEliminarTodasConexiones.Size = new System.Drawing.Size(147, 57);
            this.btnEliminarTodasConexiones.TabIndex = 28;
            this.btnEliminarTodasConexiones.Text = "Eliminar Todas Las Conexiones";
            this.btnEliminarTodasConexiones.UseVisualStyleBackColor = true;
            // 
            // btnEliminarConexion
            // 
            this.btnEliminarConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConexion.Location = new System.Drawing.Point(8, 354);
            this.btnEliminarConexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarConexion.Name = "btnEliminarConexion";
            this.btnEliminarConexion.Size = new System.Drawing.Size(121, 57);
            this.btnEliminarConexion.TabIndex = 29;
            this.btnEliminarConexion.Text = "Eliminar\r\n Conexión";
            this.btnEliminarConexion.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Monterrey - Guadalajara : 1500"});
            this.listBox1.Location = new System.Drawing.Point(8, 138);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 164);
            this.listBox1.TabIndex = 27;
            // 
            // pnPaso3
            // 
            this.pnPaso3.Controls.Add(this.nupNumeroIteraciones);
            this.pnPaso3.Controls.Add(this.lbNumeroIteraciones);
            this.pnPaso3.Controls.Add(this.btnRegresarPaso2);
            this.pnPaso3.Controls.Add(this.btnCalcular);
            this.pnPaso3.Controls.Add(this.cbCiudadInicial);
            this.pnPaso3.Controls.Add(this.lbPaso3);
            this.pnPaso3.Controls.Add(this.btnRegresarPaso1);
            this.pnPaso3.Enabled = false;
            this.pnPaso3.Location = new System.Drawing.Point(819, 86);
            this.pnPaso3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPaso3.Name = "pnPaso3";
            this.pnPaso3.Size = new System.Drawing.Size(251, 431);
            this.pnPaso3.TabIndex = 37;
            // 
            // btnRegresarPaso2
            // 
            this.btnRegresarPaso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarPaso2.Location = new System.Drawing.Point(8, 379);
            this.btnRegresarPaso2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresarPaso2.Name = "btnRegresarPaso2";
            this.btnRegresarPaso2.Size = new System.Drawing.Size(232, 32);
            this.btnRegresarPaso2.TabIndex = 33;
            this.btnRegresarPaso2.Text = "Regresar a Paso 2";
            this.btnRegresarPaso2.UseVisualStyleBackColor = true;
            this.btnRegresarPaso2.Click += new System.EventHandler(this.btnRegresarPaso2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(68, 138);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(121, 32);
            this.btnCalcular.TabIndex = 29;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // cbCiudadInicial
            // 
            this.cbCiudadInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCiudadInicial.FormattingEnabled = true;
            this.cbCiudadInicial.Items.AddRange(new object[] {
            "[Aleatoria]",
            "Guadalajara",
            "Monterrey",
            "Ciudad de México"});
            this.cbCiudadInicial.Location = new System.Drawing.Point(8, 59);
            this.cbCiudadInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCiudadInicial.Name = "cbCiudadInicial";
            this.cbCiudadInicial.Size = new System.Drawing.Size(227, 28);
            this.cbCiudadInicial.TabIndex = 32;
            // 
            // lbPaso3
            // 
            this.lbPaso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaso3.Location = new System.Drawing.Point(4, 11);
            this.lbPaso3.Name = "lbPaso3";
            this.lbPaso3.Size = new System.Drawing.Size(247, 30);
            this.lbPaso3.TabIndex = 20;
            this.lbPaso3.Text = "Paso 3: Ciudad Inicial";
            // 
            // btnRegresarPaso1
            // 
            this.btnRegresarPaso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresarPaso1.Location = new System.Drawing.Point(8, 314);
            this.btnRegresarPaso1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegresarPaso1.Name = "btnRegresarPaso1";
            this.btnRegresarPaso1.Size = new System.Drawing.Size(232, 32);
            this.btnRegresarPaso1.TabIndex = 26;
            this.btnRegresarPaso1.Text = "Regresar a Paso 1";
            this.btnRegresarPaso1.UseVisualStyleBackColor = true;
            this.btnRegresarPaso1.Click += new System.EventHandler(this.btnRegresarPaso1_Click);
            // 
            // nupNumeroIteraciones
            // 
            this.nupNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupNumeroIteraciones.Location = new System.Drawing.Point(69, 241);
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
            // lbNumeroIteraciones
            // 
            this.lbNumeroIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroIteraciones.Location = new System.Drawing.Point(3, 196);
            this.lbNumeroIteraciones.Name = "lbNumeroIteraciones";
            this.lbNumeroIteraciones.Size = new System.Drawing.Size(245, 34);
            this.lbNumeroIteraciones.TabIndex = 35;
            this.lbNumeroIteraciones.Text = "Número de Iteraciones";
            // 
            // frmViajeroVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1096, 532);
            this.Controls.Add(this.pnPaso3);
            this.Controls.Add(this.pnPaso2);
            this.Controls.Add(this.pnPaso1);
            this.Controls.Add(this.lbTituloPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmViajeroVendedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Viajero Vendedor";
            this.pnPaso1.ResumeLayout(false);
            this.pnPaso1.PerformLayout();
            this.pnPaso2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupValorItem)).EndInit();
            this.pnPaso3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupNumeroIteraciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarCiudad;
        private System.Windows.Forms.Button btnEliminarTodosItems;
        private System.Windows.Forms.ListBox listbCiudades;
        private System.Windows.Forms.Button btnContinuarPaso1;
        private System.Windows.Forms.Label lbTitlePaso1;
        private System.Windows.Forms.Label lbTituloPrincipal;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnAgregarCiudad;
        private System.Windows.Forms.Panel pnPaso1;
        private System.Windows.Forms.Panel pnPaso2;
        private System.Windows.Forms.Button btnAgregarConexion;
        private System.Windows.Forms.Label lbTitlePaso2;
        private System.Windows.Forms.Button btnContinuarPaso2;
        private System.Windows.Forms.Button btnEliminarTodasConexiones;
        private System.Windows.Forms.Button btnEliminarConexion;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbCiudadOrigen;
        private System.Windows.Forms.ComboBox cbCiudadDestino;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.NumericUpDown nupValorItem;
        private System.Windows.Forms.Label lbValorItem;
        private System.Windows.Forms.Panel pnPaso3;
        private System.Windows.Forms.Button btnRegresarPaso2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbCiudadInicial;
        private System.Windows.Forms.Label lbPaso3;
        private System.Windows.Forms.Button btnRegresarPaso1;
        private System.Windows.Forms.NumericUpDown nupNumeroIteraciones;
        private System.Windows.Forms.Label lbNumeroIteraciones;
    }
}