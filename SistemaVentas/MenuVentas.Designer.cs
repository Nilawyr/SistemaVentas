namespace SistemaVentas
{
    partial class MenuVentas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVentas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenMovAperturaCajas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenMovVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenConsVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenMovProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosDeDineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioActualizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosFaltantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTareas = new System.Windows.Forms.StatusStrip();
            this.tareas = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblfechahora = new System.Windows.Forms.ToolStripStatusLabel();
            this.fechahora = new System.Windows.Forms.ToolStripStatusLabel();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNombreCaja = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.barraTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosToolStripMenuItem,
            this.MenConsultas,
            this.informesToolStripMenuItem,
            this.MenuAcercaDe,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenMovAperturaCajas,
            this.MenMovVentas});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // MenMovAperturaCajas
            // 
            this.MenMovAperturaCajas.Name = "MenMovAperturaCajas";
            this.MenMovAperturaCajas.Size = new System.Drawing.Size(162, 22);
            this.MenMovAperturaCajas.Text = "Apertura de Caja";
            this.MenMovAperturaCajas.Click += new System.EventHandler(this.MenMovAperturaCajas_Click);
            // 
            // MenMovVentas
            // 
            this.MenMovVentas.Name = "MenMovVentas";
            this.MenMovVentas.Size = new System.Drawing.Size(162, 22);
            this.MenMovVentas.Text = "Ventas";
            this.MenMovVentas.Click += new System.EventHandler(this.MenMovVentas_Click);
            // 
            // MenConsultas
            // 
            this.MenConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenConsVentas,
            this.MenMovProductos});
            this.MenConsultas.Name = "MenConsultas";
            this.MenConsultas.Size = new System.Drawing.Size(71, 20);
            this.MenConsultas.Text = "Consultas";
            // 
            // MenConsVentas
            // 
            this.MenConsVentas.Name = "MenConsVentas";
            this.MenConsVentas.Size = new System.Drawing.Size(164, 22);
            this.MenConsVentas.Text = "Ventas por Fecha";
            // 
            // MenMovProductos
            // 
            this.MenMovProductos.Name = "MenMovProductos";
            this.MenMovProductos.Size = new System.Drawing.Size(164, 22);
            this.MenMovProductos.Text = "Productos";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorFechaToolStripMenuItem1,
            this.rankingDeProductosToolStripMenuItem,
            this.movimientosDeDineroToolStripMenuItem,
            this.inventarioActualizadoToolStripMenuItem,
            this.productosFaltantesToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Visible = false;
            // 
            // ventasPorFechaToolStripMenuItem1
            // 
            this.ventasPorFechaToolStripMenuItem1.Name = "ventasPorFechaToolStripMenuItem1";
            this.ventasPorFechaToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.ventasPorFechaToolStripMenuItem1.Text = "Ventas por Fecha";
            // 
            // rankingDeProductosToolStripMenuItem
            // 
            this.rankingDeProductosToolStripMenuItem.Name = "rankingDeProductosToolStripMenuItem";
            this.rankingDeProductosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rankingDeProductosToolStripMenuItem.Text = "Ranking de Productos";
            // 
            // movimientosDeDineroToolStripMenuItem
            // 
            this.movimientosDeDineroToolStripMenuItem.Name = "movimientosDeDineroToolStripMenuItem";
            this.movimientosDeDineroToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.movimientosDeDineroToolStripMenuItem.Text = "Movimientos de Dinero";
            // 
            // inventarioActualizadoToolStripMenuItem
            // 
            this.inventarioActualizadoToolStripMenuItem.Name = "inventarioActualizadoToolStripMenuItem";
            this.inventarioActualizadoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.inventarioActualizadoToolStripMenuItem.Text = "Inventario Actualizado";
            // 
            // productosFaltantesToolStripMenuItem
            // 
            this.productosFaltantesToolStripMenuItem.Name = "productosFaltantesToolStripMenuItem";
            this.productosFaltantesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.productosFaltantesToolStripMenuItem.Text = "Productos Faltantes";
            // 
            // MenuAcercaDe
            // 
            this.MenuAcercaDe.Name = "MenuAcercaDe";
            this.MenuAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.MenuAcercaDe.Text = "Acerca de";
            this.MenuAcercaDe.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // barraTareas
            // 
            this.barraTareas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.barraTareas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareas,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.lblfechahora,
            this.fechahora});
            this.barraTareas.Location = new System.Drawing.Point(0, 639);
            this.barraTareas.Name = "barraTareas";
            this.barraTareas.Size = new System.Drawing.Size(1264, 22);
            this.barraTareas.TabIndex = 2;
            this.barraTareas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barraTareas_ItemClicked);
            // 
            // tareas
            // 
            this.tareas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tareas.Name = "tareas";
            this.tareas.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel5.Text = "toolStripStatusLabel5";
            // 
            // lblfechahora
            // 
            this.lblfechahora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechahora.Name = "lblfechahora";
            this.lblfechahora.Size = new System.Drawing.Size(42, 17);
            this.lblfechahora.Text = "Fecha:";
            // 
            // fechahora
            // 
            this.fechahora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechahora.Name = "fechahora";
            this.fechahora.Size = new System.Drawing.Size(0, 17);
            // 
            // Reloj
            // 
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(926, 641);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(250, 641);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 15);
            this.lblUser.TabIndex = 7;
            // 
            // lblNombreCaja
            // 
            this.lblNombreCaja.AutoSize = true;
            this.lblNombreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCaja.Location = new System.Drawing.Point(270, 641);
            this.lblNombreCaja.Name = "lblNombreCaja";
            this.lblNombreCaja.Size = new System.Drawing.Size(0, 15);
            this.lblNombreCaja.TabIndex = 9;
            // 
            // MenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 661);
            this.Controls.Add(this.lblNombreCaja);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.barraTareas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Ventas de Minimarket";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.barraTareas.ResumeLayout(false);
            this.barraTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip barraTareas;
        private System.Windows.Forms.ToolStripStatusLabel tareas;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenMovAperturaCajas;
        private System.Windows.Forms.ToolStripMenuItem MenConsultas;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAcercaDe;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolStripStatusLabel fechahora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblfechahora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem MenMovVentas;
        private System.Windows.Forms.ToolStripMenuItem MenConsVentas;
        private System.Windows.Forms.ToolStripMenuItem MenMovProductos;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFechaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rankingDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeDineroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioActualizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosFaltantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNombreCaja;
    }
}

