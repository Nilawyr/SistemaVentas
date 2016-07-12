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
    public partial class Usuarios : Form
    {
        private SisVentasEntities bd = new SisVentasEntities();
        PRIVILEGIOS privilegios = new PRIVILEGIOS();
        CAJERO cajeros = new CAJERO();
        USUARIOS user = new USUARIOS();
        Cajeros FormCajeros;
        SistemaVentas.Maestros.UsuarioListado formuserlistado;
        private Boolean modificado = false;
        private Boolean validado = false;

        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                validado = validarCampos();

                if (validado == true)
                {
                    if (modificado == false)
                    {
                        int Rutusu = Convert.ToInt32(txtUsuCodigo.Text);
                        if (bd.CAJERO.Where(em => em.CAJRUT == Rutusu).FirstOrDefault() != null)
                        {
                            user.CAJRUT = Convert.ToInt32(txtUsuCodigo.Text);
                            user.PRICODIGO = Convert.ToInt32(cmbPrivilegios.SelectedValue);
                            user.PASSWORD = txtPassword.Text;
                            user.USERESTADO = "activo";
                            bd.USUARIOS.Add(user);
                            bd.SaveChanges();
                            MessageBox.Show("Usuario Guardado.");
                        }
                        else
                        {
                            DialogResult result;
                            result = MessageBox.Show(this, "Registrar ahora.", "Falta registro datos usuario", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                if (FormCajeros != null)
                                {
                                    FormCajeros.Close();
                                    FormCajeros = new Cajeros();
                                    FormCajeros.MdiParent = MenuPrincipal.ActiveForm;
                                    FormCajeros.Show();
                                    this.Close();
                                }
                                else
                                {
                                    FormCajeros = new Cajeros();
                                    FormCajeros.MdiParent = MenuPrincipal.ActiveForm;
                                    FormCajeros.Show();
                                    this.Close();
                                }
                            }
                        }
                    }
                    else
                    {
                        int RutUsu = Convert.ToInt32(txtUsuCodigo.Text);
                        var query = from p in bd.USUARIOS
                                    where p.CAJRUT == RutUsu
                                    select p;

                        foreach (var q in query)
                        {
                            q.PRICODIGO = Convert.ToInt32(cmbPrivilegios.SelectedValue);
                            q.PASSWORD = txtPassword.Text;
                            q.USERESTADO = "activo";
                        }
                        var query1 = from c in bd.CAJERO
                                     where c.CAJRUT == RutUsu
                                     select c;
                        foreach (var t in query1)
                        {
                            t.CAJESTADO = "activo";
                        }
                        bd.SaveChanges();
                        MessageBox.Show("Usuario Guardado.");
                    }
                    LimpiarFormulario();
                }
                else
                {
                    if (txtUsuCodigo.Text == null)
                    {
                        MessageBox.Show("faltan usuario.");
                        txtUsuCodigo.Focus();
                    }
                    else if (cmbPrivilegios.SelectedValue == null)
                    {
                        MessageBox.Show("falta Privilegio.");
                        cmbPrivilegios.Focus();
                    }
                    else
                    {
                        MessageBox.Show("falta contraseña.");
                        txtPassword.Focus();
                    }
                }
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
                if (txtUsuCodigo.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show(this, "Confirma que desea Eliminar", "Eliminar Registro", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int RutUsu = Convert.ToInt32(txtUsuCodigo.Text);
                        var query = from u in bd.USUARIOS
                                    where u.CAJRUT == RutUsu
                                    select u;
                        var query1 = from c in bd.CAJERO
                                     where c.CAJRUT == RutUsu
                                     select c;
                        foreach (var q in query)
                        {
                            q.USERESTADO = "bloqueado";
                        }
                        foreach (var w in query1)
                        {
                            w.CAJESTADO = "bloqueado";
                        }
                        bd.SaveChanges();
                        MessageBox.Show("Registro eliminado.");
                        LimpiarFormulario();
                    }

                }
                else
                {
                    MessageBox.Show("Debe ingresar usuario para eliminar.");
                    txtUsuCodigo.Focus();
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

        private void btnExcel_Click(object sender, EventArgs e)
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

        private void btnListado_Click(object sender, EventArgs e)
        {
            if (formuserlistado != null)
            {
                formuserlistado.Close();
                formuserlistado = new SistemaVentas.Maestros.UsuarioListado();
                //formlistado.MdiParent = this;
                formuserlistado.ShowDialog();
            }
            else
            {
                formuserlistado = new SistemaVentas.Maestros.UsuarioListado();
                //formlistado.MdiParent = this;
                formuserlistado.ShowDialog();
            }
        }

        private void cmbPrivilegios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPrivilegios_Leave(object sender, EventArgs e)
        {

        }

        public void LimpiarFormulario()
        {
            txtUsuCodigo.Text = "";
            cmbPrivilegios.SelectedIndex = -1;
            txtPassword.Text = "";
            CargarCombo();
            txtUsuCodigo.Focus();
            modificado = false;
        }

        public Boolean validarCampos()
        {
            Boolean Estado = false;
            if (txtUsuCodigo.Text != null && cmbPrivilegios.SelectedValue != null && txtPassword.Text != null)
            {
                Estado = true;
            }
            else
            {
                Estado = false;
            }
            return Estado;
        }

        public void CargarCombo()
        {
            var query = from p in bd.PRIVILEGIOS
                        select new
                        {
                            PRICODIGO = p.PRICODIGO,
                            PRINOMBRE = p.PRINOMBRE,
                        };

            cmbPrivilegios.DataSource = query.ToList();
            cmbPrivilegios.DisplayMember = "PRINOMBRE";
            cmbPrivilegios.ValueMember = "PRICODIGO";
        }

        private void txtUsuCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuCodigo.Text != "")
                {
                    int Rut = Convert.ToInt32(txtUsuCodigo.Text);
                    if (bd.USUARIOS.Where(em => em.CAJRUT == Rut).FirstOrDefault() != null)
                    {
                        var query = from p in bd.USUARIOS
                                    where p.CAJRUT == Rut
                                    select p;
                        foreach (var q in query)
                        {
                            cmbPrivilegios.SelectedValue = q.PRICODIGO;
                            txtPassword.Text = q.PASSWORD;
                            modificado = true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
