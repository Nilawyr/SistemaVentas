namespace SistemaVentas.Transacciones
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListadoCompras = new System.Windows.Forms.Button();
            this.txtNumDocum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaCom = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazonProv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutProv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIvaCompra = new System.Windows.Forms.TextBox();
            this.txtNetoCompra = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoProd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioProd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCantidadProd = new System.Windows.Forms.TextBox();
            this.btnEliminarLinea = new System.Windows.Forms.Button();
            this.btnModificarLinea = new System.Windows.Forms.Button();
            this.btnAgregarLinea = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreProd = new System.Windows.Forms.TextBox();
            this.GrillaDatos = new System.Windows.Forms.DataGridView();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Location = new System.Drawing.Point(31, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 65);
            this.panel2.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(192, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(147, 8);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(39, 42);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(102, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(39, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(57, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(39, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(39, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnListadoCompras);
            this.panel1.Controls.Add(this.txtNumDocum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFechaCom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRazonProv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRutProv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 92);
            this.panel1.TabIndex = 7;
            // 
            // btnListadoCompras
            // 
            this.btnListadoCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnListadoCompras.Image")));
            this.btnListadoCompras.Location = new System.Drawing.Point(589, 31);
            this.btnListadoCompras.Name = "btnListadoCompras";
            this.btnListadoCompras.Size = new System.Drawing.Size(38, 32);
            this.btnListadoCompras.TabIndex = 8;
            this.btnListadoCompras.Click += new System.EventHandler(this.btnListadoCompras_Click);
            // 
            // txtNumDocum
            // 
            this.txtNumDocum.Location = new System.Drawing.Point(101, 59);
            this.txtNumDocum.Name = "txtNumDocum";
            this.txtNumDocum.Size = new System.Drawing.Size(110, 20);
            this.txtNumDocum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "N° Documento";
            // 
            // txtFechaCom
            // 
            this.txtFechaCom.Location = new System.Drawing.Point(101, 7);
            this.txtFechaCom.Mask = "00/00/0000";
            this.txtFechaCom.Name = "txtFechaCom";
            this.txtFechaCom.Size = new System.Drawing.Size(100, 20);
            this.txtFechaCom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // txtRazonProv
            // 
            this.txtRazonProv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRazonProv.Enabled = false;
            this.txtRazonProv.Location = new System.Drawing.Point(274, 33);
            this.txtRazonProv.Name = "txtRazonProv";
            this.txtRazonProv.Size = new System.Drawing.Size(214, 20);
            this.txtRazonProv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon";
            // 
            // txtRutProv
            // 
            this.txtRutProv.Location = new System.Drawing.Point(101, 33);
            this.txtRutProv.Name = "txtRutProv";
            this.txtRutProv.Size = new System.Drawing.Size(110, 20);
            this.txtRutProv.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut Proveedor";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtTotalCompra);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtIvaCompra);
            this.panel5.Controls.Add(this.txtNetoCompra);
            this.panel5.Location = new System.Drawing.Point(354, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 121);
            this.panel5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Iva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalCompra.Location = new System.Drawing.Point(171, 83);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(147, 31);
            this.txtTotalCompra.TabIndex = 3;
            this.txtTotalCompra.Text = "0";
            this.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Neto";
            // 
            // txtIvaCompra
            // 
            this.txtIvaCompra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIvaCompra.Enabled = false;
            this.txtIvaCompra.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIvaCompra.ForeColor = System.Drawing.Color.Navy;
            this.txtIvaCompra.Location = new System.Drawing.Point(171, 45);
            this.txtIvaCompra.Name = "txtIvaCompra";
            this.txtIvaCompra.Size = new System.Drawing.Size(147, 31);
            this.txtIvaCompra.TabIndex = 1;
            this.txtIvaCompra.Text = "0";
            this.txtIvaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNetoCompra
            // 
            this.txtNetoCompra.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNetoCompra.Enabled = false;
            this.txtNetoCompra.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetoCompra.ForeColor = System.Drawing.Color.Navy;
            this.txtNetoCompra.Location = new System.Drawing.Point(171, 3);
            this.txtNetoCompra.Name = "txtNetoCompra";
            this.txtNetoCompra.Size = new System.Drawing.Size(147, 31);
            this.txtNetoCompra.TabIndex = 0;
            this.txtNetoCompra.Text = "0";
            this.txtNetoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtCodigoProd);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtPrecioProd);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtCantidadProd);
            this.panel6.Controls.Add(this.btnEliminarLinea);
            this.panel6.Controls.Add(this.btnModificarLinea);
            this.panel6.Controls.Add(this.btnAgregarLinea);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.txtNombreProd);
            this.panel6.Location = new System.Drawing.Point(5, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(674, 64);
            this.panel6.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Codigo Producto";
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProd.Location = new System.Drawing.Point(77, 21);
            this.txtCodigoProd.MaxLength = 13;
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Size = new System.Drawing.Size(135, 29);
            this.txtCodigoProd.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(434, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Precio";
            this.label10.Visible = false;
            // 
            // txtPrecioProd
            // 
            this.txtPrecioProd.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrecioProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProd.Location = new System.Drawing.Point(437, 21);
            this.txtPrecioProd.MaxLength = 7;
            this.txtPrecioProd.Name = "txtPrecioProd";
            this.txtPrecioProd.Size = new System.Drawing.Size(94, 29);
            this.txtPrecioProd.TabIndex = 2;
            this.txtPrecioProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioProd.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cantidad";
            // 
            // txtCantidadProd
            // 
            this.txtCantidadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProd.Location = new System.Drawing.Point(9, 21);
            this.txtCantidadProd.MaxLength = 13;
            this.txtCantidadProd.Name = "txtCantidadProd";
            this.txtCantidadProd.Size = new System.Drawing.Size(62, 29);
            this.txtCantidadProd.TabIndex = 0;
            this.txtCantidadProd.Text = "1";
            this.txtCantidadProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEliminarLinea
            // 
            this.btnEliminarLinea.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarLinea.Image")));
            this.btnEliminarLinea.Location = new System.Drawing.Point(623, 20);
            this.btnEliminarLinea.Name = "btnEliminarLinea";
            this.btnEliminarLinea.Size = new System.Drawing.Size(38, 30);
            this.btnEliminarLinea.TabIndex = 5;
            this.btnEliminarLinea.Click += new System.EventHandler(this.btnEliminarLinea_Click);
            // 
            // btnModificarLinea
            // 
            this.btnModificarLinea.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarLinea.Image")));
            this.btnModificarLinea.Location = new System.Drawing.Point(581, 20);
            this.btnModificarLinea.Name = "btnModificarLinea";
            this.btnModificarLinea.Size = new System.Drawing.Size(38, 30);
            this.btnModificarLinea.TabIndex = 4;
            this.btnModificarLinea.Click += new System.EventHandler(this.btnModificarLinea_Click);
            // 
            // btnAgregarLinea
            // 
            this.btnAgregarLinea.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLinea.Image")));
            this.btnAgregarLinea.Location = new System.Drawing.Point(537, 20);
            this.btnAgregarLinea.Name = "btnAgregarLinea";
            this.btnAgregarLinea.Size = new System.Drawing.Size(38, 30);
            this.btnAgregarLinea.TabIndex = 3;
            this.btnAgregarLinea.Click += new System.EventHandler(this.btnAgregarLinea_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Producto";
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreProd.Enabled = false;
            this.txtNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.Location = new System.Drawing.Point(218, 21);
            this.txtNombreProd.MaxLength = 13;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Size = new System.Drawing.Size(213, 29);
            this.txtNombreProd.TabIndex = 1;
            // 
            // GrillaDatos
            // 
            this.GrillaDatos.AllowUserToAddRows = false;
            this.GrillaDatos.AllowUserToDeleteRows = false;
            this.GrillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CANTIDAD,
            this.CODIGO,
            this.PRODUCTO,
            this.PRECIO,
            this.TOTAL});
            this.GrillaDatos.Location = new System.Drawing.Point(5, 170);
            this.GrillaDatos.Name = "GrillaDatos";
            this.GrillaDatos.ReadOnly = true;
            this.GrillaDatos.Size = new System.Drawing.Size(674, 239);
            this.GrillaDatos.TabIndex = 25;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            this.CANTIDAD.Width = 70;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            this.PRODUCTO.Width = 280;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.Width = 70;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            this.TOTAL.Width = 70;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 542);
            this.Controls.Add(this.GrillaDatos);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Compras";
            this.Text = "COMPRAS";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRazonProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutProv;
        private System.Windows.Forms.TextBox txtNumDocum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtFechaCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIvaCompra;
        private System.Windows.Forms.TextBox txtNetoCompra;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecioProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidadProd;
        private System.Windows.Forms.Button btnEliminarLinea;
        private System.Windows.Forms.Button btnModificarLinea;
        private System.Windows.Forms.Button btnAgregarLinea;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreProd;
        private System.Windows.Forms.DataGridView GrillaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Button btnListadoCompras;
    }
}