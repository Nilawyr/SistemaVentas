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
    public partial class Cajeros : Form
    {
        //DBDataContext bd = new DBDataContext();
        private SisVentasEntities bd = new SisVentasEntities();
        PRIVILEGIOS privilegios = new PRIVILEGIOS();
        CAJERO cajeros = new CAJERO();
        USUARIOS user = new USUARIOS();
        SistemaVentas.Maestros.UsuarioListado formuserlistado;
        private Boolean modificado = false;
        private Boolean validado = false;
        private Boolean rutvalido = false;
        
        public Cajeros()
        {
            InitializeComponent();
        }

        private void Cajeros_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtDv_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtRut.Text != "" && txtDv.Text != "")
                {
                    int rutcajero = Convert.ToInt32(txtRut.Text);
                    char dv = Convert.ToChar(txtDv.Text);
                    rutvalido = validarRut(rutcajero, dv);
                    if (rutvalido == false)
                    {
                        MessageBox.Show("Rut Mal Ingresado..");
                        //txtRut.Focus();
                    }
                    else
                    {
                        if (bd.CAJERO.Where(em => em.CAJRUT == rutcajero).FirstOrDefault() != null)
                        {
                            var query = from p in bd.CAJERO
                                        where p.CAJRUT == rutcajero
                                        select p;
                            foreach (var q in query)
                            {
                                txtNombres.Text = q.CAJNOMBRE;
                                txtAPaterno.Text = q.CAJAPATERNO;
                                txtAMaterno.Text = q.CAJAMATERNO;
                                modificado = true;
                            }
                        }
                    }
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

        private void cAJEROBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                validado = ValidarDatos();
                if (validado == true)
                {
                    if (modificado == false) //Registro Nuevo
                    {
                        cajeros.CAJRUT = Convert.ToInt32(txtRut.Text);
                        cajeros.CAJNOMBRE = txtNombres.Text;
                        cajeros.CAJAPATERNO = txtAPaterno.Text;
                        cajeros.CAJAMATERNO = txtAMaterno.Text;
                        cajeros.CAJESTADO = "activo";
                        bd.CAJERO.Add(cajeros);
                        bd.SaveChanges();
                        //bd.PRIVILEGIOS.InsertOnSubmit(privilegios);
                        user.CAJRUT = cajeros.CAJRUT;
                        //user.PRICODIGO= 

                    }
                    else //Registro Existente
                    {
                        var query = from p in bd.CAJERO
                                    where p.CAJRUT == Convert.ToInt32(txtRut.Text)
                                    select p;

                        foreach (var q in query)
                        {
                            q.CAJNOMBRE = txtNombres.Text;
                            q.CAJAPATERNO = txtAPaterno.Text;
                            q.CAJAMATERNO = txtAMaterno.Text;
                            q.CAJESTADO = "activo";
                        }

                    }
                    //msg.Text = "Registro Insertado...";
                    //Limpiar();
                    bd.SaveChanges();
                    MessageBox.Show("Registro Guardado.");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("faltan campos.");
                    txtRut.Focus();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRut.Text != "")
                {
                    int rutcajero = Convert.ToInt32(txtRut.Text);
                    if (bd.CAJERO.Where(em => em.CAJRUT == rutcajero).FirstOrDefault() != null)
                    {
                        var query = from p in bd.CAJERO
                                    where p.CAJRUT == rutcajero
                                    select p;
                        var query1 = from u in bd.USUARIOS
                                     where u.CAJRUT == rutcajero
                                     select u;
                        foreach (var q in query)
                        {
                            q.CAJESTADO = "bloqueado";

                        }
                        foreach (var w in query1)
                        {
                            w.USERESTADO = "bloqueado";
                        }

                        bd.SaveChanges();
                        MessageBox.Show("Registro eliminado.");
                        LimpiarFormulario();

                    }
                    else
                    {
                        MessageBox.Show("registro no encontrado.");
                        txtRut.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("falta rut cajero.");
                    txtRut.Focus();
                }
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

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(txtRut, e);
        }

        public void LimpiarFormulario()
        {
            txtRut.Text = "";
            txtDv.Text = "";
            txtNombres.Text = "";
            txtAPaterno.Text = "";
            txtAMaterno.Text = "";
            //CargarCombo();
            txtRut.Focus();
            modificado = false;
        }
        
        /*public void CargarCombo()
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
        }*/

        public Boolean ValidarDatos()
        {
            Boolean val = false;
            if(txtRut.Text!="" && txtNombres.Text!="" && txtAPaterno.Text!="" && txtAMaterno.Text!="")
            {
                val = true;
            }
            else
            {
                val = false;
            }
            return val;
        }

        public bool validarRut(int rut, char dig)
        {
            bool validacion = false;
            try
            {
                int rutAux = rut;
                
                char dv = dig;
                dv = char.ToUpper(dv);
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

    }
}
