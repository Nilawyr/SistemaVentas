namespace SistemaVentas
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenArchNaturaleza = new System.Windows.Forms.ToolStripMenuItem();
            this.MenArchClase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenArchSubClase = new System.Windows.Forms.ToolStripMenuItem();
            this.MenArchProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenArchCajeros = new System.Windows.Forms.ToolStripMenuItem();
            this.MenArchUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenArchPrivilegios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenArchSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenMovAperturaCajas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenMovVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenMovIngresoCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.MenMovInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenConsVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenMovProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenConsMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.archivoToolStripMenuItem,
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
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenArchNaturaleza,
            this.MenArchClase,
            this.MenArchSubClase,
            this.MenArchProductos,
            this.proveedoresToolStripMenuItem,
            this.MenArchCajeros,
            this.MenArchUsuarios,
            this.MenArchPrivilegios,
            this.MenArchSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // MenArchNaturaleza
            // 
            this.MenArchNaturaleza.Name = "MenArchNaturaleza";
            this.MenArchNaturaleza.Size = new System.Drawing.Size(139, 22);
            this.MenArchNaturaleza.Text = "Naturaleza";
            this.MenArchNaturaleza.Click += new System.EventHandler(this.MenArchNaturaleza_Click);
            // 
            // MenArchClase
            // 
            this.MenArchClase.Name = "MenArchClase";
            this.MenArchClase.Size = new System.Drawing.Size(139, 22);
            this.MenArchClase.Text = "Clase";
            this.MenArchClase.Click += new System.EventHandler(this.MenArchClase_Click);
            // 
            // MenArchSubClase
            // 
            this.MenArchSubClase.Name = "MenArchSubClase";
            this.MenArchSubClase.Size = new System.Drawing.Size(139, 22);
            this.MenArchSubClase.Text = "SubClase";
            this.MenArchSubClase.Click += new System.EventHandler(this.MenArchSubClase_Click);
            // 
            // MenArchProductos
            // 
            this.MenArchProductos.Name = "MenArchProductos";
            this.MenArchProductos.Size = new System.Drawing.Size(139, 22);
            this.MenArchProductos.Text = "Productos";
            this.MenArchProductos.Click += new System.EventHandler(this.MenArchProductos_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // MenArchCajeros
            // 
            this.MenArchCajeros.Name = "MenArchCajeros";
            this.MenArchCajeros.Size = new System.Drawing.Size(139, 22);
            this.MenArchCajeros.Text = "Cajeros";
            this.MenArchCajeros.Click += new System.EventHandler(this.MenArchCajeros_Click);
            // 
            // MenArchUsuarios
            // 
            this.MenArchUsuarios.Name = "MenArchUsuarios";
            this.MenArchUsuarios.Size = new System.Drawing.Size(139, 22);
            this.MenArchUsuarios.Text = "Usuarios";
            this.MenArchUsuarios.Click += new System.EventHandler(this.MenArchUsuarios_Click);
            // 
            // MenArchPrivilegios
            // 
            this.MenArchPrivilegios.Name = "MenArchPrivilegios";
            this.MenArchPrivilegios.Size = new System.Drawing.Size(139, 22);
            this.MenArchPrivilegios.Text = "Privilegios";
            this.MenArchPrivilegios.Click += new System.EventHandler(this.MenArchPrivilegios_Click);
            // 
            // MenArchSalir
            // 
            this.MenArchSalir.Name = "MenArchSalir";
            this.MenArchSalir.Size = new System.Drawing.Size(139, 22);
            this.MenArchSalir.Text = "Salir";
            this.MenArchSalir.Click += new System.EventHandler(this.MenArchSalir_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenMovAperturaCajas,
            this.MenMovVentas,
            this.MenMovIngresoCompras,
            this.MenMovInventario});
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // MenMovAperturaCajas
            // 
            this.MenMovAperturaCajas.Name = "MenMovAperturaCajas";
            this.MenMovAperturaCajas.Size = new System.Drawing.Size(180, 22);
            this.MenMovAperturaCajas.Text = "Apertura de Caja";
            this.MenMovAperturaCajas.Click += new System.EventHandler(this.MenMovAperturaCajas_Click);
            // 
            // MenMovVentas
            // 
            this.MenMovVentas.Name = "MenMovVentas";
            this.MenMovVentas.Size = new System.Drawing.Size(180, 22);
            this.MenMovVentas.Text = "Ventas";
            this.MenMovVentas.Click += new System.EventHandler(this.MenMovVentas_Click);
            // 
            // MenMovIngresoCompras
            // 
            this.MenMovIngresoCompras.Name = "MenMovIngresoCompras";
            this.MenMovIngresoCompras.Size = new System.Drawing.Size(180, 22);
            this.MenMovIngresoCompras.Text = "Ingreso de Compras";
            this.MenMovIngresoCompras.Click += new System.EventHandler(this.MenMovIngresoCompras_Click);
            // 
            // MenMovInventario
            // 
            this.MenMovInventario.Name = "MenMovInventario";
            this.MenMovInventario.Size = new System.Drawing.Size(180, 22);
            this.MenMovInventario.Text = "Toma de Inventario";
            this.MenMovInventario.Click += new System.EventHandler(this.MenMovInventario_Click);
            // 
            // MenConsultas
            // 
            this.MenConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenConsVentas,
            this.MenMovProductos,
            this.MenConsMovimientos,
            this.comprasToolStripMenuItem});
            this.MenConsultas.Name = "MenConsultas";
            this.MenConsultas.Size = new System.Drawing.Size(71, 20);
            this.MenConsultas.Text = "Consultas";
            // 
            // MenConsVentas
            // 
            this.MenConsVentas.Name = "MenConsVentas";
            this.MenConsVentas.Size = new System.Drawing.Size(198, 22);
            this.MenConsVentas.Text = "Ventas por Fecha";
            this.MenConsVentas.Click += new System.EventHandler(this.MenConsVentas_Click);
            // 
            // MenMovProductos
            // 
            this.MenMovProductos.Name = "MenMovProductos";
            this.MenMovProductos.Size = new System.Drawing.Size(198, 22);
            this.MenMovProductos.Text = "Productos";
            this.MenMovProductos.Click += new System.EventHandler(this.MenMovProductos_Click);
            // 
            // MenConsMovimientos
            // 
            this.MenConsMovimientos.Name = "MenConsMovimientos";
            this.MenConsMovimientos.Size = new System.Drawing.Size(198, 22);
            this.MenConsMovimientos.Text = "Movimientos de Dinero";
            this.MenConsMovimientos.Click += new System.EventHandler(this.MenConsMovimientos_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
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
            // 
            // ventasPorFechaToolStripMenuItem1
            // 
            this.ventasPorFechaToolStripMenuItem1.Name = "ventasPorFechaToolStripMenuItem1";
            this.ventasPorFechaToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.ventasPorFechaToolStripMenuItem1.Text = "Ventas por Fecha";
            this.ventasPorFechaToolStripMenuItem1.Click += new System.EventHandler(this.ventasPorFechaToolStripMenuItem1_Click);
            // 
            // rankingDeProductosToolStripMenuItem
            // 
            this.rankingDeProductosToolStripMenuItem.Name = "rankingDeProductosToolStripMenuItem";
            this.rankingDeProductosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.rankingDeProductosToolStripMenuItem.Text = "Ranking de Productos";
            this.rankingDeProductosToolStripMenuItem.Click += new System.EventHandler(this.rankingDeProductosToolStripMenuItem_Click);
            // 
            // movimientosDeDineroToolStripMenuItem
            // 
            this.movimientosDeDineroToolStripMenuItem.Name = "movimientosDeDineroToolStripMenuItem";
            this.movimientosDeDineroToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.movimientosDeDineroToolStripMenuItem.Text = "Movimientos de Dinero";
            this.movimientosDeDineroToolStripMenuItem.Click += new System.EventHandler(this.movimientosDeDineroToolStripMenuItem_Click);
            // 
            // inventarioActualizadoToolStripMenuItem
            // 
            this.inventarioActualizadoToolStripMenuItem.Name = "inventarioActualizadoToolStripMenuItem";
            this.inventarioActualizadoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.inventarioActualizadoToolStripMenuItem.Text = "Inventario Actualizado";
            this.inventarioActualizadoToolStripMenuItem.Click += new System.EventHandler(this.inventarioActualizadoToolStripMenuItem_Click);
            // 
            // productosFaltantesToolStripMenuItem
            // 
            this.productosFaltantesToolStripMenuItem.Name = "productosFaltantesToolStripMenuItem";
            this.productosFaltantesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.productosFaltantesToolStripMenuItem.Text = "Productos Faltantes";
            this.productosFaltantesToolStripMenuItem.Click += new System.EventHandler(this.productosFaltantesToolStripMenuItem_Click);
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
            this.toolStripStatusLabel4,
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
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
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
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(926, 643);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 15);
            this.lblHora.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(250, 643);
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
            // MenuPrincipal
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
            this.Name = "MenuPrincipal";
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
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenArchCajeros;
        private System.Windows.Forms.ToolStripMenuItem MenArchUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MenArchPrivilegios;
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
        private System.Windows.Forms.ToolStripStatusLabel lblfechahora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripMenuItem MenMovVentas;
        private System.Windows.Forms.ToolStripMenuItem MenMovIngresoCompras;
        private System.Windows.Forms.ToolStripMenuItem MenMovInventario;
        private System.Windows.Forms.ToolStripMenuItem MenConsVentas;
        private System.Windows.Forms.ToolStripMenuItem MenMovProductos;
        private System.Windows.Forms.ToolStripMenuItem MenConsMovimientos;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFechaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rankingDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosDeDineroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioActualizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosFaltantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenArchNaturaleza;
        private System.Windows.Forms.ToolStripMenuItem MenArchClase;
        private System.Windows.Forms.ToolStripMenuItem MenArchSubClase;
        private System.Windows.Forms.ToolStripMenuItem MenArchProductos;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenArchSalir;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNombreCaja;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
    }
}

