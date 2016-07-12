using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using SistemaVentas.Data;

namespace SistemaVentas.Maestros
{
    public partial class ProveedoresListado : Form
    {

        private SisVentasEntities bd = new SisVentasEntities();
        
        public ProveedoresListado()
        {
            InitializeComponent();
            //LimpiarForm();
        }

        private void ProveedoresListado_Load(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProvRut.Text != "" && txtProvRazon.Text == "")
                {
                    String RutProveed = txtProvRut.Text;
                    var query = from p in bd.PROVEEDORES
                                where p.PROVRUT.StartsWith(RutProveed)
                                select new
                                {
                                    Rut = p.PROVRUT,
                                    Nombre = p.PROVRAZON,
                                    Direccion = p.PROVDIRECCION,
                                    Email = p.PROVEMAIL,
                                    Fono = p.PROVTELEFONO,
                                    Vendedor = p.PROVVENDEDOR,
                                    Fono_vendedor = p.PROVFONOVENDEDOR
                                };

                    GrillaDatos.DataSource = query.ToList();
                    AjustarColumnas();
                }
                else if (txtProvRut.Text == "" && txtProvRazon.Text != "")
                {
                    String Razon = txtProvRazon.Text;
                    var query = from p in bd.PROVEEDORES
                                where p.PROVRAZON.StartsWith(Razon)
                                select new
                                {
                                    Rut = p.PROVRUT,
                                    Nombre = p.PROVRAZON,
                                    Direccion = p.PROVDIRECCION,
                                    Email = p.PROVEMAIL,
                                    Fono = p.PROVTELEFONO,
                                    Vendedor = p.PROVVENDEDOR,
                                    Fono_vendedor = p.PROVFONOVENDEDOR
                                };

                    GrillaDatos.DataSource = query.ToList();
                    AjustarColumnas();
                }
                else if (txtProvRut.Text != "" && txtProvRazon.Text != "")
                {
                    String RutProveed = txtProvRut.Text;
                    String Razon = txtProvRazon.Text;
                    var query = from p in bd.PROVEEDORES
                                where (p.PROVRUT.StartsWith(RutProveed) && p.PROVRAZON.StartsWith(Razon))
                                select new
                                {
                                    Rut = p.PROVRUT,
                                    Nombre = p.PROVRAZON,
                                    Direccion = p.PROVDIRECCION,
                                    Email = p.PROVEMAIL,
                                    Fono = p.PROVTELEFONO,
                                    Vendedor = p.PROVVENDEDOR,
                                    Fono_vendedor = p.PROVFONOVENDEDOR
                                };

                    GrillaDatos.DataSource = query.ToList();
                    AjustarColumnas();
                }
                else
                {
                    CargarDatos();
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

        private void GrillaDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LimpiarForm()
        {
            txtProvRut.Text = "";
            txtProvRazon.Text = "";
            CargarDatos();
            txtProvRut.Focus();
        }

        public void CargarDatos()
        {
            var query = from p in bd.PROVEEDORES
                        select new 
                        { 
                            Rut = p.PROVRUT,
                            Nombre = p.PROVRAZON,
                            Direccion = p.PROVDIRECCION,
                            Email=p.PROVEMAIL,
                            Fono=p.PROVTELEFONO,
                            Vendedor=p.PROVVENDEDOR,
                            Fono_vendedor=p.PROVFONOVENDEDOR
                        };

            GrillaDatos.DataSource = query.ToList();
            AjustarColumnas();
        }

        public void AjustarColumnas()
        {
            DataGridViewColumn column = GrillaDatos.Columns[0];
            column.Width = 80;
            column = GrillaDatos.Columns[1];
            column.Width = 150;
            column = GrillaDatos.Columns[2];
            column.Width = 150;
            column = GrillaDatos.Columns[3];
            column.Width = 150;
            column = GrillaDatos.Columns[4];
            column.Width = 80;
            column = GrillaDatos.Columns[5];
            column.Width = 100;
            column = GrillaDatos.Columns[6];
            column.Width = 80;
        }

    }
}
