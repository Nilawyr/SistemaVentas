namespace SistemaVentas
{
    partial class AperturaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AperturaCaja));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminaLinea = new System.Windows.Forms.Button();
            this.btnModificaLinea = new System.Windows.Forms.Button();
            this.btnAgregaLinea = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtSalida = new System.Windows.Forms.RadioButton();
            this.rbtEntrada = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtNumDocto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrillaDatos = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalSalidas = new System.Windows.Forms.TextBox();
            this.txtTotalEntradas = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDatos)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCerrarCaja);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Location = new System.Drawing.Point(237, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 56);
            this.panel2.TabIndex = 11;
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarCaja.Image")));
            this.btnCerrarCaja.Location = new System.Drawing.Point(177, 8);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(39, 42);
            this.btnCerrarCaja.TabIndex = 6;
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(237, 8);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(39, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(57, 9);
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtFecha);
            this.panel1.Controls.Add(this.btnEliminaLinea);
            this.panel1.Controls.Add(this.btnModificaLinea);
            this.panel1.Controls.Add(this.btnAgregaLinea);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.txtNumDocto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(59, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 155);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(11, 27);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(72, 20);
            this.txtFecha.TabIndex = 16;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // btnEliminaLinea
            // 
            this.btnEliminaLinea.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminaLinea.Image")));
            this.btnEliminaLinea.Location = new System.Drawing.Point(533, 118);
            this.btnEliminaLinea.Name = "btnEliminaLinea";
            this.btnEliminaLinea.Size = new System.Drawing.Size(31, 23);
            this.btnEliminaLinea.TabIndex = 9;
            this.btnEliminaLinea.Click += new System.EventHandler(this.btnEliminaLinea_Click);
            // 
            // btnModificaLinea
            // 
            this.btnModificaLinea.Image = ((System.Drawing.Image)(resources.GetObject("btnModificaLinea.Image")));
            this.btnModificaLinea.Location = new System.Drawing.Point(496, 118);
            this.btnModificaLinea.Name = "btnModificaLinea";
            this.btnModificaLinea.Size = new System.Drawing.Size(31, 23);
            this.btnModificaLinea.TabIndex = 8;
            this.btnModificaLinea.Click += new System.EventHandler(this.btnModificaLinea_Click);
            // 
            // btnAgregaLinea
            // 
            this.btnAgregaLinea.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregaLinea.Image")));
            this.btnAgregaLinea.Location = new System.Drawing.Point(459, 118);
            this.btnAgregaLinea.Name = "btnAgregaLinea";
            this.btnAgregaLinea.Size = new System.Drawing.Size(31, 23);
            this.btnAgregaLinea.TabIndex = 7;
            this.btnAgregaLinea.Click += new System.EventHandler(this.btnAgregaLinea_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbtSalida);
            this.panel3.Controls.Add(this.rbtEntrada);
            this.panel3.Location = new System.Drawing.Point(171, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(147, 27);
            this.panel3.TabIndex = 2;
            // 
            // rbtSalida
            // 
            this.rbtSalida.AutoSize = true;
            this.rbtSalida.Location = new System.Drawing.Point(86, 5);
            this.rbtSalida.Name = "rbtSalida";
            this.rbtSalida.Size = new System.Drawing.Size(58, 17);
            this.rbtSalida.TabIndex = 12;
            this.rbtSalida.TabStop = true;
            this.rbtSalida.Text = "Egreso";
            this.rbtSalida.UseVisualStyleBackColor = true;
            this.rbtSalida.CheckedChanged += new System.EventHandler(this.rbtSalida_CheckedChanged);
            // 
            // rbtEntrada
            // 
            this.rbtEntrada.AutoSize = true;
            this.rbtEntrada.Location = new System.Drawing.Point(5, 5);
            this.rbtEntrada.Name = "rbtEntrada";
            this.rbtEntrada.Size = new System.Drawing.Size(60, 17);
            this.rbtEntrada.TabIndex = 11;
            this.rbtEntrada.TabStop = true;
            this.rbtEntrada.Text = "Ingreso";
            this.rbtEntrada.UseVisualStyleBackColor = true;
            this.rbtEntrada.CheckedChanged += new System.EventHandler(this.rbtEntrada_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(11, 121);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(437, 20);
            this.txtObservaciones.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo Movimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo Doc";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.cmbTipo.Location = new System.Drawing.Point(141, 74);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(120, 21);
            this.cmbTipo.TabIndex = 4;
            this.cmbTipo.SelectedValueChanged += new System.EventHandler(this.cmbTipo_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Num.Doc";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(306, 74);
            this.txtMonto.MaxLength = 15;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // txtNumDocto
            // 
            this.txtNumDocto.Location = new System.Drawing.Point(11, 75);
            this.txtNumDocto.MaxLength = 15;
            this.txtNumDocto.Name = "txtNumDocto";
            this.txtNumDocto.Size = new System.Drawing.Size(100, 20);
            this.txtNumDocto.TabIndex = 3;
            this.txtNumDocto.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            this.txtNumDocto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumDocto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // GrillaDatos
            // 
            this.GrillaDatos.AllowUserToAddRows = false;
            this.GrillaDatos.AllowUserToDeleteRows = false;
            this.GrillaDatos.AllowUserToOrderColumns = true;
            this.GrillaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaDatos.Location = new System.Drawing.Point(59, 173);
            this.GrillaDatos.Name = "GrillaDatos";
            this.GrillaDatos.ReadOnly = true;
            this.GrillaDatos.Size = new System.Drawing.Size(597, 258);
            this.GrillaDatos.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.txtSaldo);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtTotalSalidas);
            this.panel5.Controls.Add(this.txtTotalEntradas);
            this.panel5.Location = new System.Drawing.Point(99, 437);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(525, 34);
            this.panel5.TabIndex = 6;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(359, 2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(124, 26);
            this.txtSaldo.TabIndex = 3;
            this.txtSaldo.Text = "0";
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Totales";
            // 
            // txtTotalSalidas
            // 
            this.txtTotalSalidas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotalSalidas.Enabled = false;
            this.txtTotalSalidas.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSalidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotalSalidas.Location = new System.Drawing.Point(224, 2);
            this.txtTotalSalidas.Name = "txtTotalSalidas";
            this.txtTotalSalidas.Size = new System.Drawing.Size(129, 26);
            this.txtTotalSalidas.TabIndex = 1;
            this.txtTotalSalidas.Text = "0";
            this.txtTotalSalidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalEntradas
            // 
            this.txtTotalEntradas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotalEntradas.Enabled = false;
            this.txtTotalEntradas.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEntradas.ForeColor = System.Drawing.Color.Navy;
            this.txtTotalEntradas.Location = new System.Drawing.Point(93, 2);
            this.txtTotalEntradas.Name = "txtTotalEntradas";
            this.txtTotalEntradas.Size = new System.Drawing.Size(126, 26);
            this.txtTotalEntradas.TabIndex = 0;
            this.txtTotalEntradas.Text = "0";
            this.txtTotalEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 540);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.GrillaDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AperturaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.AperturaCaja_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaDatos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtNumDocto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtSalida;
        private System.Windows.Forms.RadioButton rbtEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView GrillaDatos;
        private System.Windows.Forms.Button btnEliminaLinea;
        private System.Windows.Forms.Button btnModificaLinea;
        private System.Windows.Forms.Button btnAgregaLinea;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTotalEntradas;
        private System.Windows.Forms.TextBox txtTotalSalidas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.Button btnCerrarCaja;
    }
}