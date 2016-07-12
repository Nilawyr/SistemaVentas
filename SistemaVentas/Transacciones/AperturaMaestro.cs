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
    public partial class AperturaMaestro : Form
    {
        AperturaCaja formapertura;
        AperturaCajaListado formlistado;
        private SisVentasEntities bd = new SisVentasEntities();
        APERTURACAJA op = new APERTURACAJA();
        private string usuario { get; set; }
        private int saldo=0;
        private int numapertura { get; set; }
        private int numcaja { get; set; }
        public AperturaMaestro()
        {
            InitializeComponent();
        }
        public AperturaMaestro(String user,int NumCaja)
        {
            try
            {
                int rut = Convert.ToInt32(user);
                InitializeComponent();
                usuario = user;
                numcaja = NumCaja;
                txtCajaNumero.Text = numcaja.ToString();
                var qu = (from p in bd.USUARIOS
                          where ((p.CAJRUT == rut))
                          select p);
                if (qu.Count() > 0)
                {
                    foreach (var q in qu)
                    {
                        if (q.PRICODIGO == 2)
                        {
                            btnAbrirMovimientos.Enabled = false;
                            btnListado.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbrirMovimientos_Click(object sender, EventArgs e)
        {
            if (formapertura != null)
            {
                formapertura.Close();
                formapertura = new AperturaCaja(usuario,numcaja,numapertura, saldo,saldo,1); //Se define estado 1 por crear la Apertura.
                formapertura.MdiParent = MenuPrincipal.ActiveForm;
                formapertura.Show();
                this.Close();
            }
            else
            {
                formapertura = new AperturaCaja(usuario, numcaja,numapertura, saldo,saldo,1);
                formapertura.MdiParent = MenuPrincipal.ActiveForm;
                formapertura.Show();
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AperturaMaestro_Load(object sender, EventArgs e)
        {
            txtFecha.Text = Convert.ToString(DateTime.Now);
        }
        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCajaNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtCajaNumero, e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtMonto, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        public void LimpiarFormulario()
        {
           // txtCajaNumero.Text = "";
            txtFecha.Text = Convert.ToString(DateTime.Now);
            txtMonto.Text = "";
            btnCerrarCaja.Enabled = true;
           // txtCajaNumero.Focus();
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int rut = Convert.ToInt32(usuario);
                DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                var qu = (from p in bd.APERTURACAJA
                          where ((p.CAJRUT == rut) && (p.CAJANUMERO == numcaja) && (p.APERFECHA == fecha) && p.APERCERRADO == false)
                          select p);
                if (qu.Count() > 0)
                {
                    MessageBox.Show("No se puede Insertar una Apertura de Caja, Tiene una Pendiente de Cierre");
                }
                else
                {
                    if (txtCajaNumero.Text != "" && txtFecha.Text != "" && txtMonto.Text != "")
                    {
                        op.CAJANUMERO = Convert.ToInt32(txtCajaNumero.Text);
                        op.APERFECHA = Convert.ToDateTime(txtFecha.Text);
                        op.APERMONTO = Convert.ToInt32(txtMonto.Text);
                        op.CAJRUT = Convert.ToInt32(usuario);
                        op.APERSALDO = op.APERMONTO;
                        saldo = (int)op.APERSALDO;
                        op.APERCERRADO = false;
                        bd.APERTURACAJA.Add(op);
                        bd.SaveChanges();

                        var query = (from p in bd.APERTURACAJA
                                     where ((p.CAJRUT == op.CAJRUT) && (p.CAJANUMERO == op.CAJANUMERO) && (p.APERFECHA == op.APERFECHA) && (p.APERMONTO == op.APERMONTO))
                                     select p);
                        foreach (var q in query)
                        {
                            numapertura = q.APERNUM;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            if (formlistado != null)
            {
                formlistado.Close();
                formlistado = new AperturaCajaListado(usuario);
                formlistado.MdiParent = MenuPrincipal.ActiveForm;
                formlistado.Show();
                this.Close();
            }
            else
            {
                formlistado = new AperturaCajaListado(usuario);
                formlistado.MdiParent = MenuPrincipal.ActiveForm;
                formlistado.Show();
                this.Close();
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resp;
                resp = MessageBox.Show("¿Confirma Cierre de Caja?", "Confirmacion de Transaccion", MessageBoxButtons.YesNo);
                if (resp == DialogResult.Yes)
                {
                    int rut = Convert.ToInt32(usuario);
                    DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                    var qu = (from p in bd.APERTURACAJA
                              where ((p.CAJRUT == rut) && (p.CAJANUMERO == numcaja) && (p.APERFECHA == fecha) && p.APERCERRADO == false)
                              select p);
                    if (qu.Count() > 0)
                    {
                        foreach (var q in qu)
                        {
                            q.APERCERRADO = true;

                        }
                        bd.SaveChanges();
                        MessageBox.Show("Caja Cerrada");
                        btnCerrarCaja.Enabled = false;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
