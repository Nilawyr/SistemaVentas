using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaVentas.Data;

namespace SistemaVentas
{
    public partial class AperturaCajaListado : Form
    {
        private String usuario { get; set; }
        private SisVentasEntities bd = new SisVentasEntities();
        APERTURACAJA op = new APERTURACAJA();
        AperturaCaja formapertura;
        public AperturaCajaListado()
        {
            InitializeComponent();
        }
         public AperturaCajaListado(String user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void AperturaCajaListado_Load(object sender, EventArgs e)
        {
            int rut=Convert.ToInt32(usuario);
            DateTime fecha= DateTime.Now;
            var query = (from p in bd.APERTURACAJA
                         where (p.CAJRUT == rut &&  p.APERCERRADO == false)
                         select new { CAJA = p.CAJANUMERO,FECHA = p.APERFECHA, MONTO = p.APERMONTO, RUT = p.CAJRUT, APERTURA=p.APERNUM }).ToList();
            GrillaDatos.DataSource = query;
            DataGridViewColumn column = GrillaDatos.Columns[0];
            column.Width = 50;
            column = GrillaDatos.Columns[1];
            column.Width = 70;
            column = GrillaDatos.Columns[2];
            column.Width = 70;
            column = GrillaDatos.Columns[3];
            column.Width = 80;
            column = GrillaDatos.Columns[4];
            column.Width = 80;
            GrillaDatos.Columns["MONTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //GrillaDatos.Columns["CodNat"].Visible = false;
        }

        private void GrillaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrillaDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numcaja = 0;
            DateTime fecha;
            int rut = 0;
            int monto = 0;
            int numapertura=0;
            int saldo=0;
            if (e.RowIndex != -1)
            {
                //filaselec = e.RowIndex;
                numcaja = Convert.ToInt32(GrillaDatos.CurrentRow.Cells[0].Value);
                fecha = Convert.ToDateTime(GrillaDatos.CurrentRow.Cells[1].Value);
                monto = Convert.ToInt32(GrillaDatos.CurrentRow.Cells[2].Value);
                rut=Convert.ToInt32(GrillaDatos.CurrentRow.Cells[3].Value);
                numapertura=Convert.ToInt32(GrillaDatos.CurrentRow.Cells[4].Value);
                 var query = (from p in bd.APERTURACAJA
                         where ((p.CAJRUT == rut) && (p.APERNUM == numapertura))
                         select p);
                 foreach (var q in query)
                 {
                     saldo = Convert.ToInt32(q.APERSALDO);
                 }
                if (formapertura != null)
                {
                    formapertura.Close();
                    formapertura = new AperturaCaja(usuario,numcaja, numapertura, saldo,monto,2);
                    formapertura.MdiParent = MenuPrincipal.ActiveForm;
                    formapertura.Show();
                    this.Close();
                }
                else
                {
                    formapertura = new AperturaCaja(usuario, numcaja,numapertura, saldo,monto,2);
                    formapertura.MdiParent = MenuPrincipal.ActiveForm;
                    formapertura.Show();
                    this.Close();
                }

            }
        }
    }
}
