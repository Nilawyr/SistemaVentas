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
    public partial class Login : Form
    {
        private SisVentasEntities db = new SisVentasEntities();
        PRIVILEGIOS priv = new PRIVILEGIOS();
        USUARIOS us = new USUARIOS();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = "";
                int pr = 0;
                String estado = "";
                if (txtUser.Text != "" && txtPass.Text != "" && cmbCaja.SelectedItem != null)
                {
                    String nomcaja = cmbCaja.SelectedItem.ToString();
                    int caja = evaluaCaja();
                    int rut = Convert.ToInt32((txtUser.Text));
                    var query = from u in db.USUARIOS
                                join p in db.PRIVILEGIOS on u.PRICODIGO equals p.PRICODIGO
                                join c in db.CAJERO on u.CAJRUT equals c.CAJRUT
                                where u.CAJRUT == rut && u.PASSWORD.Equals(txtPass.Text)
                                select new { user = u.CAJRUT, pass = u.PASSWORD, pri = p.PRICODIGO, cajnombre = c.CAJNOMBRE, cajap = c.CAJAPATERNO, userestado = u.USERESTADO };
                    foreach (var q in query)
                    {
                        usuario = q.cajnombre + " " + q.cajap;
                        estado = q.userestado;
                        pr = q.pri;

                    }

                    if (usuario != "")
                    {
                        if (estado == "activo")
                        {
                            if (pr == 1)
                            {
                                MenuPrincipal menu = new MenuPrincipal(usuario, rut.ToString(), caja, nomcaja);
                                menu.Show();
                            }
                            else
                            {
                                MenuVentas menu = new MenuVentas(usuario, rut.ToString(), caja, nomcaja);
                                menu.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no valido.", "Sistema de Ventas");
                            txtUser.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre de Usuario o Contraseña Incorrecta", "Sistema de Ventas");
                        // MenuPrincipal menu = new MenuPrincipal(usuario);
                        txtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("faltan campos.");
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
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

        public int evaluaCaja()
        {
            int numcaja = 0;
            switch (cmbCaja.SelectedItem.ToString())
            {
                case "Caja 1": numcaja = 1;
                               break;
                case "Caja 2": numcaja = 2;
                               break;
                case "Caja 3": numcaja = 3;
                               break;
                case "Caja 4": numcaja = 4;
                               break;
            }
            return numcaja;
        }
    }
}
