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
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace SistemaVentas
{
    public partial class Producto : Form
    {
        private SisVentasEntities db = new SisVentasEntities();
        NATURALEZA nat = new NATURALEZA();
        CLASE clase = new CLASE();
        SUBCLASE sub = new SUBCLASE();
        PRODUCTOS prod = new PRODUCTOS();
        Excel.Application MExcel = new Excel.Application();
        //RellenaCombobox cmb = new RellenaCombobox();
        ProductosListado formlistado = new ProductosListado();
        
        public Producto()
        {
            InitializeComponent();
            //cmbNaturaleza = cmb.CargaNaturaleza();
            RellenaComboBox();
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                prod.NATSID = Convert.ToInt32(cmbNaturaleza.SelectedValue);
                prod.CLASEID = Convert.ToInt32(cmbClase.SelectedValue);
                prod.SUBCLAID = Convert.ToInt32(cmbSubClase.SelectedValue);
                prod.PRODCODIGOBARRA = txtCodBarra.Text;
                prod.PRODNOMBRE = txtNomProducto.Text;
                prod.PRODPRECIO = Convert.ToInt32(txtPrecio.Text);
                prod.PRODSTOCKINICIAL = Convert.ToInt32(txtStockInicial.Text);
                prod.PRODSTOCKACTUAL = Convert.ToInt32(txtStockActual.Text);
                if (chbInventariable.Checked == true)
                {
                    prod.PRODINVENTARIABLE = true;
                }
                else
                {
                    prod.PRODINVENTARIABLE = false;
                }
                if (chbTienePrecio.Checked == true)
                {
                    prod.PRODCONPRECIO = true;
                }
                else { prod.PRODCONPRECIO = false; }
                db.PRODUCTOS.Add(prod);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

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
                formlistado = new ProductosListado();
                //formlistado.MdiParent = this;
                formlistado.ShowDialog();
            }
            else
            {
                formlistado = new ProductosListado();
                //formlistado.MdiParent = this;
                formlistado.ShowDialog();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = 2;

                var query = (from n in db.NATURALEZA
                             join c in db.CLASE on n.NATSID equals c.NATSID into cu
                             join s in db.SUBCLASE on n.NATSID equals s.NATSID into su
                             join p in db.PRODUCTOS on n.NATSID equals p.NATSID into pu
                             from p in pu.DefaultIfEmpty()
                             from s in su.DefaultIfEmpty()
                             from c in cu.DefaultIfEmpty()
                             select new { n.NATSID, n.NATNOMBRE, c.CLASEID, c.CLASENOMBRE, s.SUBCLAID, s.SUBCLANOMBRE, p.PRODNOMBRE }).ToList();

                //var a = from u in v.users
                //            join p in v.patners on u.userid equals p.partnerid into pu
                //            join l in v.locations on u.userid equals l.userid into lu
                //            from l in lu.DefaultIfEmpty()
                //            from p in pu.DefaultIfEmpty()
                //            where u.userid == i
                //            select new { user = u, partners = p, loca = l };

                if (query.Count() > 0)
                {
                    MExcel.Visible = true;
                    Excel.Workbook Libro = MExcel.Workbooks.Add(true);
                    Excel.Worksheet Hoja = MExcel.ActiveSheet as Excel.Worksheet;
                    Hoja.Name = "Clase";
                    Hoja.Activate();
                    Hoja.Cells.set_Item(1, "A", "Cod.Naturaleza");
                    Hoja.Cells.set_Item(1, "B", "Naturaleza");
                    Hoja.Cells.set_Item(1, "C", "Cod.Clase");
                    Hoja.Cells.set_Item(1, "D", "Clase");
                    Hoja.Cells.set_Item(1, "E", "Cod.SubClase");
                    Hoja.Cells.set_Item(1, "F", "SubClase");
                    Hoja.Cells.set_Item(1, "G", "Producto");

                    foreach (var q in query)
                    {
                        Hoja.Cells[fila, 1] = q.NATSID; //CodEigo
                        Hoja.Cells[fila, 2] = q.NATNOMBRE; //Nombre
                        Hoja.Cells[fila, 3] = q.CLASEID; //Nombre
                        Hoja.Cells[fila, 4] = q.CLASENOMBRE; //Nombre
                        Hoja.Cells[fila, 5] = q.SUBCLAID; //Nombre
                        Hoja.Cells[fila, 6] = q.SUBCLANOMBRE; //Nombre
                        Hoja.Cells[fila, 7] = q.PRODNOMBRE; //Nombre
                        fila++;
                    }
                    // MessageBox.Show("Archivo Generado con Exito");

                }
                else
                    MessageBox.Show("Error El Archivo no fue Generado");

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

        private void cmbNaturaleza_Leave(object sender, EventArgs e)
        {
            SeleccionaClase(Convert.ToInt32(cmbNaturaleza.SelectedValue));
        }

        private void cmbClase_Leave(object sender, EventArgs e)
        {
            SeleccionaSubClase(Convert.ToInt32(cmbClase.SelectedValue));
        }

        private void txtCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNomProducto.Focus();
            }
        }

        private void cmbNaturaleza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNaturaleza_Click(object sender, EventArgs e)
        {

        }

        private void txtNomProducto_TextChanged(object sender, EventArgs e)
        {

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
            var query = from p in db.CLASE where p.NATSID==nat
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

        public void LimpiarForm()
        {
            cmbNaturaleza.SelectedIndex = -1;
            cmbClase.SelectedIndex = -1;
            cmbSubClase.SelectedIndex = -1;
            txtCodBarra.Text = "";
            txtNomProducto.Text = "";
            txtPrecio.Text = "";
            txtStockInicial.Text = "";
            txtStockActual.Text = "";
            chbInventariable.Checked = false;
            chbTienePrecio.Checked = false;
            RellenaComboBox();
        }
    }
}
