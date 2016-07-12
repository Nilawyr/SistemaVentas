using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.Data;

namespace SistemaVentas
{
    public partial class MenuPrincipal : Form
    {
        Cajeros formcajeros;
        Privilegios formprivilegios;
        Acercade formacercade;
        Usuarios formusuarios;
        AperturaMaestro formapertura;
        Naturaleza formnaturaleza;
        Clase formclase;
        SubClase formsubclase;
        Producto formproducto;
        Ventas formventas;
        ProductosListado formprodlistado;
        SistemaVentas.Transacciones.VentasListado formventaslistado;
        SistemaVentas.Transacciones.ComprasListado formcomplistado;
        SistemaVentas.Transacciones.Compras formcompras;
        SistemaVentas.Transacciones.Inventario forminven;
        SistemaVentas.Maestros.Proveedores formprov;
        SistemaVentas.Transacciones.MovimientosListado formlistadomov;
        SistemaVentas.Transacciones.InventarioListado formlistainven;
        public string usuario;
        public string rut;
        public int numcaja;
        public String nomcaja;

        public String User = "";
        public MenuPrincipal(String us,String user,int caja,string Nomcaja)
        {
            InitializeComponent();
            tareas.Text = "Usuario: "+user+"; "+us;
            lblUser.Visible = false;
            lblUser.Text = user;
            lblNombreCaja.Text = Nomcaja;
            numcaja = caja;
            nomcaja = Nomcaja;
            usuario = user;
            fechahora.Text = Convert.ToString(DateTime.Now);
            Reloj.Start();
        }

        private void MenArchCajeros_Click(object sender, EventArgs e)
        {
            if (formcajeros != null)
            {
                formcajeros.Close();
                formcajeros = new Cajeros();
                formcajeros.MdiParent = this;
                formcajeros.Show();
            }
            else
            {
                formcajeros = new Cajeros();
                formcajeros.MdiParent = this;
                formcajeros.Show();
            }
            
        }

        private void MenArchPrivilegios_Click(object sender, EventArgs e)
        {
            if (formprivilegios != null)
            {
                formprivilegios.Close();
                formprivilegios = new Privilegios();
                formprivilegios.MdiParent = this;
                formprivilegios.Show();
            }
            else
            {
                formprivilegios = new Privilegios();
                formprivilegios.MdiParent = this;
                formprivilegios.Show();
            }
            
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formacercade != null)
            {
                formacercade.Close();
                formacercade = new Acercade();
                formacercade.MdiParent = this;
                formacercade.Show();
            }
            else
            {
                formacercade = new Acercade();
                formacercade.MdiParent = this;
                formacercade.Show();
            }
        }

        private void MenArchUsuarios_Click(object sender, EventArgs e)
        {
            if (formusuarios != null)
            {
                formusuarios.Close();
                formusuarios = new Usuarios();
                formusuarios.MdiParent = this;
                formusuarios.Show();
            }
            else
            {
                formusuarios = new Usuarios();
                formusuarios.MdiParent = this;
                formusuarios.Show();
            }
        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            Reloj.Stop();
            fechahora.Text = Convert.ToString(DateTime.Now);
            //lblHora.Text = Convert.ToString(DateTime.Now);
            Reloj.Start();

        }

        private void MenMovAperturaCajas_Click(object sender, EventArgs e)
        {
            if (formapertura != null)
            {
                formapertura.Close();
                formapertura = new AperturaMaestro(usuario,numcaja);
                formapertura.MdiParent = this;
                formapertura.Show();
            }
            else
            {
                formapertura = new AperturaMaestro(usuario,numcaja);
                formapertura.MdiParent = this;
                formapertura.Show();
            }
        }

        private void barraTareas_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenArchSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenArchNaturaleza_Click(object sender, EventArgs e)
        {
            if (formnaturaleza != null)
            {
                formnaturaleza.Close();
                formnaturaleza = new Naturaleza();
                formnaturaleza.MdiParent = this;
                formnaturaleza.Show();
            }
            else
            {
                formnaturaleza = new Naturaleza();
                formnaturaleza.MdiParent = this;
                formnaturaleza.Show();
            }
        }

        private void MenArchClase_Click(object sender, EventArgs e)
        {
            if (formclase != null)
            {
                formclase.Close();
                formclase = new Clase();
                formclase.MdiParent = this;
                formclase.Show();
            }
            else
            {
                formclase = new Clase();
                formclase.MdiParent = this;
                formclase.Show();
            }
        }

        private void MenArchSubClase_Click(object sender, EventArgs e)
        {
            if (formsubclase != null)
            {
                formsubclase.Close();
                formsubclase = new SubClase();
                formsubclase.MdiParent = this;
                formsubclase.Show();
            }
            else
            {
                formsubclase = new SubClase();
                formsubclase.MdiParent = this;
                formsubclase.Show();
            }
        }

        private void MenArchProductos_Click(object sender, EventArgs e)
        {
            if (formproducto != null)
            {
                formproducto.Close();
                formproducto = new Producto();
                formproducto.MdiParent = this;
                formproducto.Show();
            }
            else
            {
                formproducto = new Producto();
                formproducto.MdiParent = this;
                formproducto.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenMovVentas_Click(object sender, EventArgs e)
        {
            if (formventas != null)
            {
                formventas.Close();
                formventas = new Ventas(usuario,numcaja);
                formventas.MdiParent = this;
                formventas.Show();
            }
            else
            {
                formventas = new Ventas(usuario,numcaja);
                formventas.MdiParent = this;
                formventas.Show();
            }
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void MenMovIngresoCompras_Click(object sender, EventArgs e)
        {
            if (formcompras != null)
            {
                formcompras.Close();
                formcompras = new SistemaVentas.Transacciones.Compras();
                formcompras.MdiParent = this;
                formcompras.Show();
            }
            else
            {
                formcompras = new SistemaVentas.Transacciones.Compras();
                formcompras.MdiParent = this;
                formcompras.Show();
            }
        }

        private void MenMovInventario_Click(object sender, EventArgs e)
        {
            if (forminven != null)
            {
                forminven.Close();
                forminven = new SistemaVentas.Transacciones.Inventario();
                forminven.MdiParent = this;
                forminven.Show();
            }
            else
            {
                forminven = new SistemaVentas.Transacciones.Inventario();
                forminven.MdiParent = this;
                forminven.Show();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formprov != null)
            {
                formprov.Close();
                formprov = new SistemaVentas.Maestros.Proveedores();
                formprov.MdiParent = this;
                formprov.Show();
            }
            else
            {
                formprov = new SistemaVentas.Maestros.Proveedores();
                formprov.MdiParent = this;
                formprov.Show();
            }
        }

        private void MenMovProductos_Click(object sender, EventArgs e)
        {
            if (formprodlistado != null)
            {
                formprodlistado.Close();
                formprodlistado = new ProductosListado();
                //formlistado.MdiParent = this;
                formprodlistado.ShowDialog();
            }
            else
            {
                formprodlistado = new ProductosListado();
                //formlistado.MdiParent = this;
                formprodlistado.ShowDialog();
            }
        }

        private void MenConsVentas_Click(object sender, EventArgs e)
        {
            if (formventaslistado != null)
            {
                formventaslistado.Close();
                formventaslistado = new SistemaVentas.Transacciones.VentasListado();
                formventaslistado.MdiParent = this;
                formventaslistado.Show();
            }
            else
            {
                formventaslistado = new SistemaVentas.Transacciones.VentasListado();
                formventaslistado.MdiParent = this;
                formventaslistado.Show();
            }
        }

        private void MenConsMovimientos_Click(object sender, EventArgs e)
        {
            if (formlistadomov != null)
            {
                formlistadomov.Close();
                formlistadomov = new SistemaVentas.Transacciones.MovimientosListado();
                formlistadomov.MdiParent = this;
                formlistadomov.Show();
            }
            else
            {
                formlistadomov = new SistemaVentas.Transacciones.MovimientosListado();
                formlistadomov.MdiParent = this;
                formlistadomov.Show();
            }
        }

        private void ventasPorFechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void rankingDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void movimientosDeDineroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventarioActualizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formlistainven != null)
            {
                formlistainven.Close();
                formlistainven = new SistemaVentas.Transacciones.InventarioListado();
                //formlistado.MdiParent = this;
                formlistainven.ShowDialog();
            }
            else
            {
                formlistainven = new SistemaVentas.Transacciones.InventarioListado();
                //formlistado.MdiParent = this;
                formlistainven.ShowDialog();
            }
        }

        private void productosFaltantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formcomplistado != null)
            {
                formcomplistado.Close();
                formcomplistado = new SistemaVentas.Transacciones.ComprasListado();
                //formlistado.MdiParent = this;
                formcomplistado.ShowDialog();
            }
            else
            {
                formcomplistado = new SistemaVentas.Transacciones.ComprasListado();
                //formlistado.MdiParent = this;
                formcomplistado.ShowDialog();
            }
        }

        
    }
}
