using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.Data;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace SistemaVentas
{
    public partial class Clase : Form
    {
        //DBDataContext db = new DBDataContext();
        private SisVentasEntities bd = new SisVentasEntities();
        NATURALEZA nat = new NATURALEZA();
        CLASE clase = new CLASE();
        Excel.Application MExcel = new Excel.Application();
        bool estado = false;
        bool modificado = false;
        
        public Clase()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clase_Load(object sender, EventArgs e)
        {
            RellenaComboBox();
            CargarDatos(0);
            //CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clase = new CLASE();
                clase.NATSID = Convert.ToInt32(cmbNaturaleza.SelectedValue);
                //clase.CLASEID = 3;
                clase.CLASENOMBRE = txtNomClase.Text;
                bd.CLASE.Add(clase);
                bd.SaveChanges();
                CargarDatos(clase.NATSID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = 2;

                var query = (from n in bd.NATURALEZA
                             join c in bd.CLASE on n.NATSID equals c.NATSID
                             select new { n.NATSID, n.NATNOMBRE, c.CLASEID, c.CLASENOMBRE }).ToList();


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
                    foreach (var q in query)
                    {
                        Hoja.Cells[fila, 1] = q.NATSID; //CodEigo
                        Hoja.Cells[fila, 2] = q.NATNOMBRE; //Nombre
                        Hoja.Cells[fila, 3] = q.CLASEID; //Nombre
                        Hoja.Cells[fila, 4] = q.CLASENOMBRE; //Nombre
                        fila++;
                    }
                    // MessageBox.Show("Archivo Generado con Exito");

                }
                else
                {
                    MessageBox.Show("Error El Archivo no fue Generado");
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                bool generado = false;
                Reporte todos = new Reporte();
                Reportes.RptClases rpt = new Reportes.RptClases();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SistemaVentasDataSet ds = new SistemaVentasDataSet();


                var r = (from n in bd.NATURALEZA
                         join c in bd.CLASE on n.NATSID equals c.NATSID
                         select new { n.NATSID, n.NATNOMBRE, c.CLASEID, c.CLASENOMBRE }).ToList();

                generado = true;

                if (r.Count() > 0)
                {
                    if (generado == true)
                    {
                        System.Data.DataTable dt = LINQToDataTable(r);
                        rpt.SetDataSource(dt);
                        todos.Visor.ReportSource = rpt;
                        todos.WindowState = FormWindowState.Maximized;
                        todos.Show();

                    }
                }
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

        private void cmbNaturaleza_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CargarDatos(Convert.ToInt32(cmbNaturaleza.SelectedValue));
        }

        private void cmbNaturaleza_Leave(object sender, EventArgs e)
        {
            CargarDatos(Convert.ToInt32(cmbNaturaleza.SelectedValue));
        }

        public System.Data.DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            System.Data.DataTable dtReturn = new System.Data.DataTable();

            // column names 
            PropertyInfo[] oProps = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others will follow 
                if (oProps == null)
                {
                    oProps = ((Type)rec.GetType()).GetProperties();
                    foreach (PropertyInfo pi in oProps)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dr = dtReturn.NewRow();

                foreach (PropertyInfo pi in oProps)
                {
                    dr[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue
                    (rec, null);
                }

                dtReturn.Rows.Add(dr);
            }
            return dtReturn;
        }

        public void RellenaComboBox()
        {
            var query = from p in bd.NATURALEZA
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

        public void CargarDatos(int codigo)
        {
            /*  var query = from c in customers
                          join o in orders on c.ID equals o.ID
                          select new { c.Name, o.Product };*/
            var query = from n in bd.NATURALEZA
                        join c in bd.CLASE on n.NATSID equals c.NATSID
                        select new { CodNaturaleza = n.NATSID, Naturaleza = n.NATNOMBRE, CodClase = c.CLASEID, NombreClase = c.CLASENOMBRE };
            if (codigo != -1)
            {
                query = from n in bd.NATURALEZA
                        join c in bd.CLASE on n.NATSID equals c.NATSID
                        where n.NATSID == codigo
                        select new { CodNaturaleza = n.NATSID, Naturaleza = n.NATNOMBRE, CodClase = c.CLASEID, NombreClase = c.CLASENOMBRE };
            }

            GrillaDatos.DataSource = query.ToList();
            DataGridViewColumn column = GrillaDatos.Columns[1];
            column.Width = 180;
            column = GrillaDatos.Columns[3];
            column.Width = 180;

        }

        private void LimpiarFormulario()
        {
            txtNomClase.Text = "";
            CargarDatos(0);
        }

        private void btnListado_Click(object sender, EventArgs e)
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
