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
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace SistemaVentas.Maestros
{
    public partial class Proveedores : Form
    {
        private SisVentasEntities bd = new SisVentasEntities();
        ProveedoresListado formprovlistado;
        PROVEEDORES proveed = new PROVEEDORES();
        private Boolean modificado = false;

        public Proveedores()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtProvRut_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProvRut.Text != "")
                {
                    String RutProv = txtProvRut.Text;
                    Boolean RutValido = validarRut(RutProv);
                    if (RutValido == true)
                    {
                        if (bd.PROVEEDORES.Where(em => em.PROVRUT == RutProv).FirstOrDefault() != null)
                        {
                            var query = from p in bd.PROVEEDORES
                                        where p.PROVRUT == RutProv
                                        select p;
                            foreach (var q in query)
                            {
                                txtProvRazon.Text = q.PROVRAZON;
                                txtProvDireccion.Text = q.PROVDIRECCION;
                                txtProvEmail.Text = q.PROVEMAIL;
                                txtProvFono.Text = q.PROVTELEFONO;
                                txtProvVendedor.Text = q.PROVVENDEDOR;
                                txtProvFonoVend.Text = q.PROVFONOVENDEDOR;
                                modificado = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rut incorrecto.");
                        txtProvRut.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            if (formprovlistado != null)
            {
                formprovlistado.Close();
                formprovlistado = new ProveedoresListado();
                //formlistado.MdiParent = this;
                formprovlistado.ShowDialog();
            }
            else
            {
                formprovlistado = new ProveedoresListado();
                //formlistado.MdiParent = this;
                formprovlistado.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean CamposValidos = validarCampos();
                if (CamposValidos == true)
                {
                    if (modificado == false) //registro nuevo
                    {
                        proveed.PROVRUT = txtProvRut.Text;
                        proveed.PROVRAZON = txtProvRazon.Text;
                        proveed.PROVDIRECCION = txtProvDireccion.Text;
                        proveed.PROVEMAIL = txtProvEmail.Text;
                        proveed.PROVTELEFONO = txtProvFono.Text;
                        proveed.PROVVENDEDOR = txtProvVendedor.Text;
                        proveed.PROVFONOVENDEDOR = txtProvFonoVend.Text;
                        bd.PROVEEDORES.Add(proveed);
                    }
                    else //registro existente
                    {
                        String RutProv = txtProvRut.Text;
                        var query = from p in bd.PROVEEDORES
                                    where p.PROVRUT == RutProv
                                    select p;
                        foreach (var q in query)
                        {
                            q.PROVRAZON = txtProvRazon.Text;
                            q.PROVDIRECCION = txtProvDireccion.Text;
                            q.PROVEMAIL = txtProvEmail.Text;
                            q.PROVTELEFONO = txtProvFono.Text;
                            q.PROVVENDEDOR = txtProvVendedor.Text;
                            q.PROVFONOVENDEDOR = txtProvFonoVend.Text;
                        }
                    }
                    bd.SaveChanges();
                    MessageBox.Show("Registro guardado.");
                    LimpiarFormulario();
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
                if (txtProvRut.Text != "")
                {
                    String RutProv = txtProvRut.Text;
                    if (bd.PROVEEDORES.Where(em => em.PROVRUT == RutProv).FirstOrDefault() != null)
                    {
                        var query = from p in bd.PROVEEDORES
                                    where p.PROVRUT == RutProv
                                    select p;
                        foreach (var q in query)
                        {
                            bd.PROVEEDORES.Remove(q);
                        }
                        bd.SaveChanges();
                        MessageBox.Show("Registro eliminado.");
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("Registro no existe, revise rut.");
                        txtProvRut.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar rut para eliminar.");
                    txtProvRut.Focus();
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

        private void txtProvFono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtProvFono, e);
        }

        private void txtProvFonoVend_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtProvFonoVend, e);
        }

        public void LimpiarFormulario()
        {
            txtProvRut.Text = "";
            txtProvRazon.Text = "";
            txtProvDireccion.Text = "";
            txtProvEmail.Text = "";
            txtProvFono.Text = "";
            txtProvVendedor.Text = "";
            txtProvFonoVend.Text = "";
            modificado = false;
            txtProvRut.Focus();
        }

        public Boolean validarCampos()
        {
            Boolean valido = false;
            if (txtProvRut.Text != "" && txtProvRazon.Text != "" && txtProvDireccion.Text != "" && txtProvEmail.Text != "" && txtProvFono.Text != "" && txtProvVendedor.Text != "" && txtProvFonoVend.Text != "")
            {
                valido = true;
            }
            else
            {
                if(txtProvRut.Text=="")
                {
                    MessageBox.Show("Falta Rut.");
                    txtProvRut.Focus();
                }
                else if(txtProvRazon.Text=="")
                {
                    MessageBox.Show("Falta Razon.");
                    txtProvRazon.Focus();
                }
                else if (txtProvDireccion.Text == "")
                {
                    MessageBox.Show("Falta Dirección.");
                    txtProvDireccion.Focus();
                }
                else if (txtProvEmail.Text == "")
                {
                    MessageBox.Show("Falta Email.");
                    txtProvEmail.Focus();
                }
                else if (txtProvFono.Text == "")
                {
                    MessageBox.Show("Falta Telefono.");
                    txtProvFono.Focus();
                }
                else if (txtProvVendedor.Text == "")
                {
                    MessageBox.Show("Falta Nombre Vendedor.");
                    txtProvVendedor.Focus();
                }
                else if (txtProvFonoVend.Text == "")
                {
                    MessageBox.Show("Falta Telefono Vendedor.");
                    txtProvFonoVend.Focus();
                }
            }
            return valido;
        }

        public bool validarRut(string rut)
        {
            string[] split;
            bool validacion = false;
            try
            {

                rut = rut.ToUpper();
                split = rut.Split(new Char[] { '-' });

                int rutAux = int.Parse(split[0] );

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
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

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtProvEmail_Leave(object sender, EventArgs e)
        {
            if(txtProvEmail.Text!="")
            {
                String Email = txtProvEmail.Text;
                Boolean emailvalido = IsValidEmail(Email);

                if (emailvalido == false)
                {
                    MessageBox.Show("email incorrecto.");
                    txtProvEmail.Focus();
                }
            }
        }
    }
}
