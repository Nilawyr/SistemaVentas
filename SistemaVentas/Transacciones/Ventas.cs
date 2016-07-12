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
    public partial class Ventas : Form
    {
        private SisVentasEntities db = new SisVentasEntities();
        VENTAS maestro = new VENTAS();
        VENTA_DETALLE detalle = new VENTA_DETALLE();
        APERTURACAJA op = new APERTURACAJA();
        MOVIMIENTOS mov;
        ArrayList V = new ArrayList();
        ArrayList D = new ArrayList();
        Sales S;
        BindingSource bs;
        int total;
        bool inicial = true;
        int filaselec = -1;
        DialogResult resp;
        private string usuario {get;set;}
        byte formapago;
        long boucher;
        int numcaja;

        public Ventas(String user,int NumCaja)
        {
            InitializeComponent();
            total = 0;
            numcaja = NumCaja;
            cmbTipoPago.SelectedItem = "Seleccione";
            txtBoucher.Enabled = false;
            usuario = user;
            formapago = 0;
            boucher = 0;
        }
        public Ventas()
        {
            InitializeComponent();
            total = 0;
            cmbTipoPago.SelectedItem = "Seleccione";
            txtBoucher.Enabled = false;
            formapago = 0;
            boucher = 0;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            txtFecha.Text = Convert.ToString(DateTime.Now);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtCantidad, e);
        }

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                SoloNumeros(txtCodBarra, e);
                if (e.KeyChar == 13)
                {
                    if (txtCodBarra.Text != "")
                    {
                        if (inicial == true)
                        {
                            GrillaDatos.Columns.Clear();
                            inicial = false;
                        }
                        var query = from p in db.PRODUCTOS
                                    where p.PRODCODIGOBARRA.Equals(txtCodBarra.Text)
                                    select p;

                        foreach (var q in query)
                        {
                            S = new Sales();
                            S.CANTIDAD = Convert.ToInt32(txtCantidad.Text);
                            S.PRODUCTO = q.PRODNOMBRE;
                            S.CODBARRA = txtCodBarra.Text;
                            S.CODIGO = q.PRODCODIGO;
                            if (q.PRODCONPRECIO == true)
                            {
                                S.PRECIO = Convert.ToInt32(q.PRODPRECIO);
                                txtValor.Text = q.PRODPRECIO.ToString();
                                S.TOTAL = S.CANTIDAD * S.PRECIO;
                                total = total + S.TOTAL;
                                txtTotalVenta.Text = total.ToString("N0");
                                D.Add(S);
                                CargarDatos(D);

                            }
                            else
                            {
                                txtValor.Visible = true;
                                lblValor.Visible = true;
                                txtValor.Focus();
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtValor, e);
        }

        private void txtNumBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtNumBoleta, e);
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

        private void txtBoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtBoucher, e);
        }

        private void txtCancelado_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtCancelado, e);
        }
        
        public void CargarDatos(ArrayList D)
        {
            
            if (inicial == false)
            {
                bs = new BindingSource(D, "");
                GrillaDatos.DataSource = bs;
                GrillaDatos.Refresh();
                DataGridViewColumn column = GrillaDatos.Columns[0];
                column.Width = 70;
                column = GrillaDatos.Columns[1];
                column.Width = 90;
                column = GrillaDatos.Columns[2];
                column.Width = 280;
                column = GrillaDatos.Columns[3];
                column.Width = 70;
                column = GrillaDatos.Columns[4];
                column.Width = 70;
                GrillaDatos.Columns["CODBARRA"].Visible = false;
                GrillaDatos.Columns["CODIGO"].Visible = false;
                GrillaDatos.Columns["CANTIDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                GrillaDatos.Columns["PRECIO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                GrillaDatos.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void txtCancelado_Leave(object sender, EventArgs e)
        {
            
            String [] num;
            String numero;
            
            if (txtCancelado.Text != "")
            {
               // txtCancelado.Text = txtCancelado.Text.ToString("N0");
                num = txtTotalVenta.Text.Split('.');
                numero = String.Join("",num);
                int tot = int.Parse(Convert.ToDouble(numero).ToString());
                int cancelado = Convert.ToInt32(txtCancelado.Text);
                int vuelto = cancelado-tot;
                if (vuelto < 0)
                {
                    MessageBox.Show("Monto Ingresado no cubre Total de la Venta","Sistema de Ventas");
                    txtCancelado.Focus();
                }
                if (vuelto >= 0)
                {
                    txtVuelto.Text = vuelto.ToString("N0");
                   // lblVuelto.Text = vuelto.ToString("N0");
                }
            }
        }

        private void btnAgregaLinea_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtCantidad.Text != "") && (txtCodBarra.Text != "") && (txtValor.Text != ""))
                {
                    S.CANTIDAD = Convert.ToInt32(txtCantidad.Text);
                    S.PRECIO = Convert.ToInt32(txtValor.Text);
                    S.TOTAL = S.CANTIDAD * S.PRECIO;
                    total = total + S.TOTAL;
                    txtTotalVenta.Text = total.ToString("N0");
                    D.Add(S);
                    CargarDatos(D);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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
            resp = 0;
            String[] num;
            String numero;
            try
            {
                if ((txtCodBarra.Text != "")&&(txtCantidad.Text!=""))
                {
                   resp = MessageBox.Show("Confirma que Desea Eliminar esta Linea", "Confirmacion de Eliminacion", MessageBoxButtons.YesNo);
                        if (resp == DialogResult.Yes)
                        {
                            num = txtTotalVenta.Text.Split('.');
                            numero = String.Join("", num);
                            int tot = int.Parse(Convert.ToDouble(numero).ToString());
                            int totallinea = Convert.ToInt32(GrillaDatos.CurrentRow.Cells[4].Value);
                            tot = tot - totallinea;
                            txtTotalVenta.Text = tot.ToString("N0");
                            D.RemoveAt(filaselec); 
                            CargarDatos(D);
                            filaselec=-1;
                            txtCodBarra.Text="";
                          // txtPrecio.text="";
                            MessageBox.Show("**** Linea Eliminada ****");
                        }
                        else
                            MessageBox.Show("Se ha cancelado la eliminación de la Línea");

                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GrillaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int rut = Convert.ToInt32(usuario);
                DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                int numapertura = 0;
                var qu = (from p in db.APERTURACAJA
                          where ((p.CAJRUT == rut) && (p.CAJANUMERO == numcaja) && p.APERCERRADO == false)
                          select p);
                if (qu.Count() > 0)
                {
                    foreach (var q in qu)
                    {
                        numapertura = q.APERNUM;
                    }
                    bool validado = false;
                    string tipo = cmbTipoPago.SelectedItem.ToString();
                    if (tipo.Equals("Seleccione"))
                    {
                        cmbTipoPago.Focus();
                        validado = false;
                    }
                    else if (tipo.Equals("Tarjeta") && (txtBoucher.Text.Equals("")))
                    {
                        validado = false;
                        MessageBox.Show("Debe Ingresar Numero de Boucher", "Sistema de Ventas");
                        txtBoucher.Focus();
                    }
                    if (txtNumBoleta.Text.Equals(""))
                    {
                        validado = false;
                        MessageBox.Show("Debe Ingresar Numero de Boleta", "Sistema de Ventas");
                        txtNumBoleta.Focus();
                    }
                    if ((txtNumBoleta.Text != "") && (!tipo.Equals("Seleccione")) && (txtCancelado.Text != "") && (txtVuelto.Text != ""))
                        validado = true;

                    if (validado == true)
                    {
                        string[] num = txtTotalVenta.Text.Split('.');
                        string numero = String.Join("", num);

                        int tot = int.Parse(Convert.ToDouble(numero).ToString());
                        num = txtCancelado.Text.Split('.');
                        numero = String.Join("", num);
                        int canc = int.Parse(Convert.ToDouble(numero).ToString());

                        num = txtVuelto.Text.Split('.');
                        numero = String.Join("", num);
                        int vuelto = int.Parse(Convert.ToDouble(numero).ToString());
                        resp = MessageBox.Show("¿Confirma Venta?", "Confirmacion de Transaccion", MessageBoxButtons.YesNo);
                        if (resp == DialogResult.Yes)
                        {
                            maestro.TIPPAGOID = formapago;
                            maestro.CAJRUT = Convert.ToInt32(usuario);
                            maestro.VENBOLETANUM = Convert.ToInt32(txtNumBoleta.Text);
                            maestro.VENTFECHA = DateTime.Now;
                            maestro.VENTOTAL = tot;
                            maestro.VENTACANCELADO = canc;
                            maestro.VENTAVUELTO = vuelto;
                            maestro.VENBOUCHER = boucher;
                            db.VENTAS.Add(maestro);
                            db.SaveChanges();
                            AsignarDetalles(maestro.VENBOLETANUM);
                            btnGuardar.Enabled = false;
                            //Agregarlo a Movimientos de Apertura de Caja
                            mov = new MOVIMIENTOS();
                            mov.APERNUM = numapertura;
                            mov.MOVMONTO = maestro.VENTOTAL;
                            mov.MOVNUMDOCUMENTO = maestro.VENBOLETANUM;
                            mov.MOVTIPO = 1;
                            mov.MOVTIPODOCTO = 1;
                            mov.MOVOBSERVACIONES = "VENTA EN EL LOCAL";
                            db.MOVIMIENTOS.Add(mov);
                            db.SaveChanges();
                            //Modificar el Stock.

                        }

                    }
                }
                else
                {
                    MessageBox.Show("No hay Apertura de Caja para Asignar la Venta", "Sistema de Ventas");
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmbTipoPago_SelectedValueChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoPago.SelectedItem.ToString();
            if (tipo.Equals("Tarjeta"))
            {
                formapago = 2;
                txtBoucher.Enabled = true;
                txtBoucher.Focus();
            }
            if(tipo.Equals("Efectivo"))
                formapago=1;


        }

        private void GrillaDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrillaDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                filaselec = e.RowIndex;
                txtCantidad.Text = Convert.ToString(GrillaDatos.CurrentRow.Cells[0].Value);
                txtCodBarra.Text = Convert.ToString(GrillaDatos.CurrentRow.Cells[1].Value);

            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoucher_Leave(object sender, EventArgs e)
        {
           if(txtBoucher.Text!="")
            boucher = Convert.ToInt64(txtBoucher.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        public void LimpiarFormulario()
        {
            txtCantidad.Text = "1";
            txtCodBarra.Text = "";
            txtValor.Text = "";
            txtNumBoleta.Text = "";
            txtBoucher.Text = "";
            cmbTipoPago.SelectedItem = "Seleccione";
            total = 0;
            inicial = true;
            txtBoucher.Enabled = false;
            usuario = this.usuario;
            formapago = 0;
            boucher = 0;
            D.Clear();
            GrillaDatos.Columns.Clear();
            IniciarGrilla();
            GrillaDatos.Refresh();
            btnGuardar.Enabled = true;
            txtTotalVenta.Text = "0";
            txtCancelado.Text = "";
            txtVuelto.Text = "0";
            txtValor.Visible = true;
            lblValor.Visible = true;
        }
        
        public void IniciarGrilla()
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna.HeaderText = "CANTIDAD";
            columna.Name = "CANTIDAD";
            columna.Width = 70;
            GrillaDatos.Columns.Insert(0, columna);
            columna1.HeaderText = "PRODUCTO";
            columna1.Name = "PRODUCTO";
            columna1.Width = 280;
            GrillaDatos.Columns.Insert(1, columna1);
            columna2.HeaderText = "PRECIO";
            columna2.Name = "PRECIO";
            columna2.Width = 70;
            GrillaDatos.Columns.Insert(2, columna2);
            columna3.HeaderText = "TOTAL";
            columna3.Name = "TOTAL";
            columna3.Width = 70;
            GrillaDatos.Columns.Insert(3, columna3);

        }
        
        public void AsignarDetalles(int boleta)
        {
            long venid=0;
            var query = from p in db.VENTAS
                        where p.VENBOLETANUM== boleta
                        select p;
            
            foreach (var q in query)
            {
                venid = q.VENTAID;
            }
            
            for(int fila=0; fila<D.Count;fila++)
            {
                S = (Sales)D[fila];
                detalle.VENTLINEA=(fila+1);
                detalle.VENTAID = venid;
                detalle.VENTCANTIDAD = S.CANTIDAD;
                detalle.VENTCODBARRA = S.CODBARRA;
                detalle.VENTTOTLINEA = S.TOTAL;
                detalle.PRODCODIGO= S.CODIGO;
                db.VENTA_DETALLE.Add(detalle);
                db.SaveChanges();
            }

        }

    }
}
