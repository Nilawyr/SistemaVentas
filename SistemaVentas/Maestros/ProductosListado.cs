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
using System.Data.Entity;
namespace SistemaVentas
{
    public partial class ProductosListado : Form
    {

        private SisVentasEntities db = new SisVentasEntities();
        NATURALEZA nat = new NATURALEZA();
        CLASE clase = new CLASE();
        SUBCLASE sub = new SUBCLASE();
        PRODUCTOS prod = new PRODUCTOS();


        public ProductosListado()
        {
            InitializeComponent();
            RellenaComboBox();
        }
        public void RellenaComboBox()
        {
            var query = from p in db.NATURALEZA
                        select new
                        {
                            NATCODIGO = p.NATSID,
                            NATNOMBRE = p.NATNOMBRE,
                        };

            cmbNaturaleza.DataSource = query.ToList();
            cmbNaturaleza.DisplayMember = "NATNOMBRE";
            cmbNaturaleza.ValueMember = "NATCODIGO";


            // GridView1.DataSource = query;
            //  GridView1.DataBind();
        }


        public void SeleccionaClase(int nat)
        {
            cmbClase.DataSource = null;
            cmbClase.Items.Clear();
            var query = from p in db.CLASE
                        where p.NATSID == nat
                        select new
                        {
                            CLASECODIGO = p.CLASEID,
                            CLASENOMBRE = p.CLASENOMBRE,
                        };

            cmbClase.DataSource = query.ToList();
            cmbClase.DisplayMember = "CLASENOMBRE";
            cmbClase.ValueMember = "CLASECODIGO";

        }
        public void SeleccionaSubClase(int sub)
        {
            cmbSubClase.DataSource = null;
            cmbSubClase.Items.Clear();
            var query = from p in db.SUBCLASE
                        where p.CLASEID == sub
                        select new
                        {
                            SUBCLASECODIGO = p.SUBCLAID,
                            SUBCLASENOMBRE = p.SUBCLANOMBRE,
                        };

            cmbSubClase.DataSource = query.ToList();
            cmbSubClase.DisplayMember = "SUBCLASENOMBRE";
            cmbSubClase.ValueMember = "SUBCLASECODIGO";

        }



        private void cmbNaturaleza_Leave(object sender, EventArgs e)
        {
            SeleccionaClase(Convert.ToInt32(cmbNaturaleza.SelectedValue));
        }

        private void cmbClase_Leave(object sender, EventArgs e)
        {
            SeleccionaSubClase(Convert.ToInt32(cmbClase.SelectedValue));
        }

        private void cmbSubClase_Leave(object sender, EventArgs e)
        {
            SeleccionaProductos(Convert.ToInt32(cmbSubClase.SelectedValue));
        }

        public void SeleccionaProductos(int sub)
        {
            using (var sis = new SisVentasEntities())
            {
                var query = db.Database.SqlQuery<Products>("SELECT PRODUCTO,CODBARRA,PRECIO, NATURALEZA,CLASE,SUBCLASE,CODNAT,CODCLASE,CODSUBCLASE, CODPRODUCTO FROM PRODUCTOSLISTADOS").ToList();
                
                //this will throw an exception
                //var q = sis.SqlQuery("Select studentid as id, studentname as name 
                //        from Student where studentname='New Student1'").ToList();

                GrillaDatos.DataSource = query;
                GrillaDatos.Columns["CodNat"].Visible = false;
                //DataGridViewColumn column = GrillaDatos.Columns[1];
                //column.Width = 180;
                //column = GrillaDatos.Columns[3];
                //column.Width = 180;
            }
        }
    }
}