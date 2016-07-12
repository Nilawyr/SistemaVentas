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
    public partial class UsuarioListado : Form
    {
        private SisVentasEntities bd = new SisVentasEntities();
        PRIVILEGIOS privilegios = new PRIVILEGIOS();
        CAJERO cajeros = new CAJERO();
        USUARIOS user = new USUARIOS();

        public UsuarioListado()
        {
            InitializeComponent();
        }

        private void UsuarioListado_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void GrillaDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuRut.Text != "" && txtUsuAPaterno.Text == "" && txtUsuAMaterno.Text == "" && txtUsuNombre.Text == "" && cmbTipoUsuario.SelectedIndex == -1)
                {
                    int RutUsu = Convert.ToInt32(txtUsuRut.Text);
                    var query = (from u in bd.USUARIOS
                                 join c in bd.CAJERO on u.CAJRUT equals c.CAJRUT
                                 join p in bd.PRIVILEGIOS on u.PRICODIGO equals p.PRICODIGO
                                 where (u.USERESTADO == "activo" && u.CAJRUT.Equals(RutUsu)) 
                                 select new
                                 {
                                     Rut = c.CAJRUT,
                                     Nombre = c.CAJNOMBRE,
                                     A_Paterno = c.CAJAPATERNO,
                                     A_Materno = c.CAJAMATERNO,
                                     Tipo_Usuario = p.PRINOMBRE
                                 }).ToList();

                    GrillaDatos.DataSource = query;
                    DataGridViewColumn column = GrillaDatos.Columns[0];
                    column.Width = 70;
                }
                else if (txtUsuRut.Text == "" && txtUsuAPaterno.Text != "" && txtUsuAMaterno.Text == "" && txtUsuNombre.Text == "" && cmbTipoUsuario.SelectedIndex == -1)
                {
                    String ApePat = txtUsuAPaterno.Text;
                    var query = (from u in bd.USUARIOS
                                 join c in bd.CAJERO on u.CAJRUT equals c.CAJRUT
                                 join p in bd.PRIVILEGIOS on u.PRICODIGO equals p.PRICODIGO
                                 where (u.USERESTADO == "activo" && c.CAJAPATERNO.StartsWith(ApePat)) 
                                 select new
                                 {
                                     Rut = c.CAJRUT,
                                     Nombre = c.CAJNOMBRE,
                                     A_Paterno = c.CAJAPATERNO,
                                     A_Materno = c.CAJAMATERNO,
                                     Tipo_Usuario = p.PRINOMBRE
                                 }).ToList();

                    GrillaDatos.DataSource = query;
                    DataGridViewColumn column = GrillaDatos.Columns[0];
                    column.Width = 70;
                }
                else if (txtUsuRut.Text == "" && txtUsuAPaterno.Text == "" && txtUsuAMaterno.Text != "" && txtUsuNombre.Text == "" && cmbTipoUsuario.SelectedIndex == -1)
                {
                    String ApeMat = txtUsuAMaterno.Text;
                    var query = (from u in bd.USUARIOS
                                 join c in bd.CAJERO on u.CAJRUT equals c.CAJRUT
                                 join p in bd.PRIVILEGIOS on u.PRICODIGO equals p.PRICODIGO
                                 where (u.USERESTADO == "activo" && c.CAJAMATERNO.StartsWith(ApeMat))
                                 select new
                                 {
                                     Rut = c.CAJRUT,
                                     Nombre = c.CAJNOMBRE,
                                     A_Paterno = c.CAJAPATERNO,
                                     A_Materno = c.CAJAMATERNO,
                                     Tipo_Usuario = p.PRINOMBRE
                                 }).ToList();

                    GrillaDatos.DataSource = query;
                    DataGridViewColumn column = GrillaDatos.Columns[0];
                    column.Width = 70;
                }
                else if (txtUsuRut.Text == "" && txtUsuAPaterno.Text == "" && txtUsuAMaterno.Text == "" && txtUsuNombre.Text != "" && cmbTipoUsuario.SelectedIndex == -1)
                {
                    String Nombre = txtUsuNombre.Text;
                    var query = (from u in bd.USUARIOS
                                 join c in bd.CAJERO on u.CAJRUT equals c.CAJRUT
                                 join p in bd.PRIVILEGIOS on u.PRICODIGO equals p.PRICODIGO
                                 where (u.USERESTADO == "activo" && c.CAJNOMBRE.StartsWith(Nombre))
                                 select new
                                 {
                                     Rut = c.CAJRUT,
                                     Nombre = c.CAJNOMBRE,
                                     A_Paterno = c.CAJAPATERNO,
                                     A_Materno = c.CAJAMATERNO,
                                     Tipo_Usuario = p.PRINOMBRE
                                 }).ToList();

                    GrillaDatos.DataSource = query;
                    DataGridViewColumn column = GrillaDatos.Columns[0];
                    column.Width = 70;
                }
                else if (txtUsuRut.Text == "" && txtUsuAPaterno.Text == "" && txtUsuAMaterno.Text == "" && txtUsuNombre.Text == "" && cmbTipoUsuario.SelectedIndex != -1)
                {
                    int codPriv = Convert.ToInt32(cmbTipoUsuario.SelectedValue);
                    var query = (from u in bd.USUARIOS
                                 join c in bd.CAJERO on u.CAJRUT equals c.CAJRUT
                                 join p in bd.PRIVILEGIOS on u.PRICODIGO equals p.PRICODIGO
                                 where (u.USERESTADO == "activo" && u.PRICODIGO.Equals(codPriv))
                                 select new
                                 {
                                     Rut = c.CAJRUT,
                                     Nombre = c.CAJNOMBRE,
                                     A_Paterno = c.CAJAPATERNO,
                                     A_Materno = c.CAJAMATERNO,
                                     Tipo_Usuario = p.PRINOMBRE
                                 }).ToList();

                    GrillaDatos.DataSource = query;
                    DataGridViewColumn column = GrillaDatos.Columns[0];
                    column.Width = 70;
                }
                else
                {
                    CargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
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

        public void LimpiarFormulario()
        {
            txtUsuRut.Text = "";
            txtUsuAPaterno.Text = "";
            txtUsuAMaterno.Text = "";
            txtUsuNombre.Text = "";
            CargarCombo();
            cmbTipoUsuario.SelectedIndex = -1;
            CargarGrilla();
            txtUsuRut.Focus();
        }

        public void CargarCombo()
        {
            var query = from p in bd.PRIVILEGIOS
                        select new
                        {
                            PRICODIGO = p.PRICODIGO,
                            PRINOMBRE = p.PRINOMBRE,
                        };

            cmbTipoUsuario.DataSource = query.ToList();
            cmbTipoUsuario.DisplayMember = "PRINOMBRE";
            cmbTipoUsuario.ValueMember = "PRICODIGO";
        }

         public void CargarGrilla()
        {
            var query = (from u in bd.USUARIOS
                        join c in bd.CAJERO on u.CAJRUT equals c.CAJRUT
                        join p in bd.PRIVILEGIOS on u.PRICODIGO equals p.PRICODIGO
                        where(u.USERESTADO == "activo")
                        select new 
                        { 
                            Rut = c.CAJRUT,
                            Nombre = c.CAJNOMBRE,
                            A_Paterno = c.CAJAPATERNO,
                            A_Materno = c.CAJAMATERNO,
                            Tipo_Usuario = p.PRINOMBRE 
                        }).ToList();

            GrillaDatos.DataSource = query;
            DataGridViewColumn column = GrillaDatos.Columns[0];
            column.Width = 70;
        }
    }
}
