using System;
using System.Collections;
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
    public partial class AperturaCaja : Form
    {
        private SisVentasEntities bd = new SisVentasEntities();
        APERTURACAJA op = new APERTURACAJA();
        MOVIMIENTOS mov;
        private string usuario { get; set; }
        private int saldo = 0;
        private int monto = 0;
        private int rut;
        private int numapertura { get; set; }
        private int tipo { get; set; }
        private int tipodoc { get; set; }
        ArrayList M = new ArrayList();
        Movs movs = new Movs();
        private int tentradas;
        private int tsalidas;
        private int tsaldo;
        private int numcaja {get;set;}
        private int estado {get; set; }
        BindingSource bs;

        public AperturaCaja()
        {
            InitializeComponent();
        }

        public AperturaCaja(String user, int NumCaja,int numero,int Saldo,int Monto,int estado)
        {
            try
            {
                InitializeComponent();
                usuario = user;
                rut = Convert.ToInt32(usuario);
                saldo = Saldo;
                monto = Monto;
                numapertura = numero;
                numcaja = NumCaja;
                tipo = 0;
                tipodoc = 0;
                tentradas = 0;
                tsalidas = 0;
                tsaldo = 0;
                if (estado == 1) //Creado por primera vez
                {
                    var query = (from p in bd.APERTURACAJA
                                 where ((p.CAJRUT == rut) && (p.APERNUM == numapertura))
                                 select p);
                    foreach (var q in query)
                    {
                        op.CAJRUT = q.CAJRUT;
                        op.APERMONTO = q.APERMONTO;
                        op.APERSALDO = q.APERSALDO;
                        op.APERNUM = q.APERNUM;
                        op.APERFECHA = q.APERFECHA;
                        op.CAJANUMERO = q.CAJANUMERO;
                        op.APERCERRADO = q.APERCERRADO;
                        txtSaldo.Text = Convert.ToString(q.APERSALDO);
                    }
                }
                if (estado == 2)//Ya existente
                {
                    var query = (from p in bd.APERTURACAJA
                                 where ((p.CAJRUT == rut) && (p.APERNUM == numapertura))
                                 select p);
                    foreach (var q in query)
                    {
                        op.CAJRUT = q.CAJRUT;
                        op.APERMONTO = q.APERMONTO;
                        op.APERSALDO = q.APERSALDO;
                        op.APERNUM = q.APERNUM;
                        op.APERFECHA = q.APERFECHA;
                        op.CAJANUMERO = q.CAJANUMERO;
                        op.APERCERRADO = q.APERCERRADO;
                        txtSaldo.Text = Convert.ToString(q.APERSALDO);
                    }
                    var qu = (from q in bd.MOVIMIENTOS
                              where q.APERNUM == op.APERNUM
                              select q);
                    if (qu.Count() > 0)
                    {
                        foreach (var r in qu)
                        {
                            movs = new Movs();
                            movs.APERTURA = r.APERNUM;
                            movs.DOCUMENTO = Convert.ToInt32(r.MOVNUMDOCUMENTO);
                            movs.OBSERVACIONES = r.MOVOBSERVACIONES;
                            movs.TIPO = r.MOVTIPO;
                            if (r.MOVTIPODOCTO == 1)
                            {
                                movs.TIPODOC = "Boleta";
                            }
                            if (r.MOVTIPODOCTO == 2)
                            {
                                movs.TIPODOC = "Factura";
                            }
                            if (r.MOVTIPO == 1)
                            {
                                movs.INGRESO = r.MOVMONTO;
                                tentradas = tentradas + r.MOVMONTO;
                                saldo = saldo + r.MOVMONTO;
                            }
                            if (r.MOVTIPO == 2)
                            {
                                movs.EGRESO = r.MOVMONTO;
                                tsalidas = tsalidas + r.MOVMONTO;
                                saldo = saldo - r.MOVMONTO;
                            }
                            movs.SALDO = saldo;
                            txtSaldo.Text = saldo.ToString();
                            txtTotalEntradas.Text = tentradas.ToString();
                            txtTotalSalidas.Text = tsalidas.ToString();
                            op.APERSALDO = saldo;
                            M.Add(movs);
                        }
                        CargarDatos(M);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AperturaCaja_Load(object sender, EventArgs e)
        {
            txtFecha.Text = Convert.ToString(DateTime.Now);
            rbtEntrada.Checked = false;
            rbtSalida.Checked = false;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumDocto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtNumDocto, e);
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

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtMonto, e);
        }

        private void txtNumMov_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregaLinea_Click(object sender, EventArgs e)
        {
            try
            {
                if ((tipo != 0) && (tipo != 0) && (txtMonto.Text != ""))
                {
                    mov = new MOVIMIENTOS();
                    movs = new Movs();
                    mov.APERNUM = numapertura;
                    mov.MOVOBSERVACIONES = txtObservaciones.Text;
                    mov.MOVTIPO = tipo;
                    mov.MOVTIPODOCTO = tipodoc;
                    mov.MOVMONTO = Convert.ToInt32(txtMonto.Text);
                    if (tipo == 1) //Es un Ingreso
                    {
                        mov.MOVNUMDOCUMENTO = 0;
                        movs.TIPODOC = cmbTipo.SelectedItem.ToString();
                        tentradas = tentradas + mov.MOVMONTO;
                        saldo = saldo + mov.MOVMONTO;
                        movs.INGRESO = mov.MOVMONTO;


                    }
                    if (tipo == 2) // Es una Salida de Dinero
                    {
                        mov.MOVNUMDOCUMENTO = Convert.ToInt32(txtNumDocto.Text);
                        tsalidas = tsalidas + mov.MOVMONTO;
                        saldo = saldo - mov.MOVMONTO;
                        movs.TIPODOC = cmbTipo.SelectedItem.ToString();
                        movs.EGRESO = (int)mov.MOVMONTO;
                    }
                    txtSaldo.Text = saldo.ToString();
                    txtTotalEntradas.Text = tentradas.ToString();
                    txtTotalSalidas.Text = tsalidas.ToString();
                    movs.TIPO = tipo;
                    movs.APERTURA = numapertura;
                    movs.DOCUMENTO = (int)mov.MOVNUMDOCUMENTO;
                    movs.OBSERVACIONES = mov.MOVOBSERVACIONES;
                    movs.SALDO = saldo;
                    op.APERSALDO = saldo;
                    bd.MOVIMIENTOS.Add(mov);
                    bd.SaveChanges();
                    M.Add(movs);
                    CargarDatos(M);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void rbtEntrada_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 1;
        }

        private void rbtSalida_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
        }

        private void cmbTipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedItem.Equals("Boleta"))
                tipodoc = 1;
            if (cmbTipo.SelectedItem.Equals("Factura"))
                tipodoc = 2;
        }
        public void CargarDatos(ArrayList D)
        {
            bs = new BindingSource(D, "");
            GrillaDatos.DataSource = bs;
            GrillaDatos.Refresh();
            DataGridViewColumn column = GrillaDatos.Columns[0];
            column.Width = 70;
            column = GrillaDatos.Columns[1];
            column.Width = 70;
            column = GrillaDatos.Columns[2];
            column.Width = 80;
            column = GrillaDatos.Columns[3];
            column.Width = 80;
            column = GrillaDatos.Columns[4];
            column.Width = 80;
            column = GrillaDatos.Columns[5];
            column.Width = 80;
            column = GrillaDatos.Columns[6];
            column.Width = 80;
            column = GrillaDatos.Columns[7];
            column.Width = 80;
            column = GrillaDatos.Columns[8];
            column.Width = 150;
            GrillaDatos.Columns["APERTURA"].Visible = false;
            GrillaDatos.Columns["NUMERO"].Visible = false;
            GrillaDatos.Columns["TIPO"].Visible = false;
            GrillaDatos.Columns["DOCUMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GrillaDatos.Columns["INGRESO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GrillaDatos.Columns["INGRESO"].DefaultCellStyle.ForeColor = Color.Blue;
            GrillaDatos.Columns["EGRESO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GrillaDatos.Columns["EGRESO"].DefaultCellStyle.ForeColor = Color.Red;
            GrillaDatos.Columns["SALDO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            GrillaDatos.Columns["SALDO"].DefaultCellStyle.ForeColor = Color.Blue;
        }
        public void LimpiarFormulario()
        {
            rbtEntrada.Checked = false;
            rbtSalida.Checked = false;
            txtMonto.Text = "";
            txtNumDocto.Text = "";
            txtObservaciones.Text = "";
            rbtEntrada.Focus();
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
                              where ((p.CAJRUT == rut) && (p.APERNUM == numapertura) && p.APERCERRADO == false)
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificaLinea_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminaLinea_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
