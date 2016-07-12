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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection;


namespace SistemaVentas
{
    public partial class Naturaleza : Form
    {
        //DBDataContext db = new DBDataContext();
        private SisVentasEntities bd = new SisVentasEntities();
        NATURALEZA nat = new NATURALEZA();
        Excel.Application MExcel = new Excel.Application();

        bool estado = false;
        bool modificado = false;
        NaturalezaListado formlistado = new NaturalezaListado();
        
        public Naturaleza()
        {
            InitializeComponent();
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
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
            estado = ValidaDatos();
            if (estado == true)
            {
                MessageBox.Show("Registro Incompleto...");
                txtNatNombre.Focus();
            }
            else  //Se registra un Dato
            {
                if (modificado == false) //Registro Nuevo
                {
                    nat = new NATURALEZA();
                    //nat.NATSID = int.Parse(txtNatCodigo.Text);
                    nat.NATNOMBRE = txtNatNombre.Text;
                    bd.NATURALEZA.Add(nat);
                    bd.SaveChanges();
                    //db.NATURALEZA.InsertOnSubmit(nat);
                    

                }
                else //Registro Existente
                {
                    var query = from p in bd.NATURALEZA
                                where p.NATSID == Convert.ToInt32(txtNatCodigo.Text)
                                select p;

                    foreach (var q in query)
                    {
                        q.NATNOMBRE  = txtNatNombre.Text;
                    }

                }
                //msg.Text = "Registro Insertado...";
                //Limpiar();
                bd.SaveChanges();
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNatCodigo.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show(this, "Confirma que desea Eliminar", "Eliminar Registro", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int idnat = Convert.ToInt32(txtNatCodigo.Text);
                        if (bd.NATURALEZA.Where(em => em.NATSID == idnat).FirstOrDefault() != null)
                        {
                            var query = from p in bd.NATURALEZA
                                        where p.NATSID == idnat
                                        select p;

                            foreach (var q in query)
                            {
                                txtNatCodigo.Enabled = false;

                                //bd.NATURALEZA.DeleteOnSubmit(q);
                                bd.NATURALEZA.Remove(q);
                            }

                            bd.SaveChanges();
                            MessageBox.Show("Registro eliminado.");
                            LimpiarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("registro no encontrado.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("falta codigo para eliminar.");
                    txtNatCodigo.Focus();
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
                formlistado = new NaturalezaListado();
                //formlistado.MdiParent = this;
                formlistado.ShowDialog();
            }
            else
            {
                formlistado = new NaturalezaListado();
                //formlistado.MdiParent = this;
                formlistado.ShowDialog();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = 2;

                var query = from p in bd.NATURALEZA
                            select p;

                if (query.Count() > 0)
                {
                    MExcel.Visible = true;
                    Excel.Workbook Libro = MExcel.Workbooks.Add(true);
                    Excel.Worksheet Hoja = MExcel.ActiveSheet as Excel.Worksheet;
                    Hoja.Name = "Naturaleza";
                    Hoja.Activate();
                    Hoja.Cells.set_Item(1, "A", "Codigo");
                    Hoja.Cells.set_Item(1, "B", "Naturaleza");
                    foreach (var q in query)
                    {
                        Hoja.Cells[fila, 1] = q.NATSID; //CodEigo
                        Hoja.Cells[fila, 2] = q.NATNOMBRE; //Nombre
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                bool generado = false;
                Reporte todos = new Reporte();
                Reportes.Reportes rpt = new Reportes.Reportes();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                SistemaVentasDataSet ds = new SistemaVentasDataSet();


                var r = (from n in bd.NATURALEZA
                         select new { n.NATSID, n.NATNOMBRE }).ToList();

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

        private void txtNatCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtNatCodigo.Text != "")
                {
                    int cod = Convert.ToInt32(txtNatCodigo.Text);
                    if (txtNatCodigo.Text != "" && (bd.NATURALEZA.Where(em => em.NATSID == cod).FirstOrDefault()) != null)
                    {
                        nat = bd.NATURALEZA.Where(em => em.NATSID == cod).First();
                        txtNatCodigo.Enabled = false;
                        txtNatNombre.Text = nat.NATNOMBRE.ToString();
                        modificado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        public void LimpiarFormulario()
        {
            txtNatCodigo.Enabled = true;
            txtNatCodigo.Text = "";
            txtNatNombre.Text = "";
            txtNatCodigo.Focus();
            modificado = false;

        }

        public bool ValidaDatos()
        {

            if (txtNatNombre.Text == null)
                estado = true;

            return estado;
        }
    }
    
}
