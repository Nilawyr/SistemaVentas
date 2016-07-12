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
    public partial class NaturalezaListado : Form
    {
        private SisVentasEntities db = new SisVentasEntities();
        NATURALEZA nat = new NATURALEZA();
       // DBDataContext db = new DBDataContext();
        //NATURALEZA nat = new NATURALEZA();
        public NaturalezaListado()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDatos()
        {
            
            var query = from p in db.NATURALEZA      
                      select new { Codigo = p.NATSID, Naturaleza=p.NATNOMBRE };            
            GrillaDatos.DataSource = query.ToList();
            DataGridViewColumn column = GrillaDatos.Columns[1];
            column.Width = 180;


        }

        private void txtNatNombre_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtNatNombre.Text != "")
            {
                var query = from p in db.NATURALEZA
                            where p.NATNOMBRE.StartsWith(txtNatNombre.Text)
                            select new { Codigo = p.NATSID, Naturaleza = p.NATNOMBRE };
                GrillaDatos.DataSource = query.ToList();
                DataGridViewColumn column = GrillaDatos.Columns[1];
                column.Width = 180;
            }
            else
                CargarDatos();
        }

        private void NaturalezaListado_Load(object sender, EventArgs e)
        {

        }
    }
}
