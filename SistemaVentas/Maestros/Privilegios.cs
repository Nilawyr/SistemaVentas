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
    public partial class Privilegios : Form
    {
       
        
        private SisVentasEntities bd = new SisVentasEntities();
        PRIVILEGIOS privilegios = new PRIVILEGIOS();
        private Boolean modificado = false;
       
        public Privilegios()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modificado == false) //Registro Nuevo
                {
                    privilegios.PRICODIGO = Convert.ToInt32(txtPrivCodigo.Text);
                    privilegios.PRINOMBRE = txtPrivNombre.Text;

                    bd.SaveChanges();

                }
                else //Registro Existente
                {
                    var query = from p in bd.PRIVILEGIOS
                                where p.PRICODIGO == Convert.ToInt32(txtPrivCodigo.Text)
                                select p;

                    foreach (var q in query)
                    {
                        q.PRINOMBRE = txtPrivNombre.Text;
                    }

                }
                //msg.Text = "Registro Insertado...";
                //Limpiar();
                bd.SaveChanges();
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
                if (txtPrivCodigo.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show(this, "Confirma que desea Eliminar", "Eliminar Registro", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int pricod = Convert.ToInt32(txtPrivCodigo.Text);
                        if (bd.PRIVILEGIOS.Where(em => em.PRICODIGO == pricod).FirstOrDefault() != null)
                        {
                            var query = from p in bd.PRIVILEGIOS
                                        where p.PRICODIGO == pricod
                                        select p;

                            foreach (var q in query)
                            {
                                txtPrivCodigo.Enabled = false;
                                bd.PRIVILEGIOS.Remove(q);
                                //bd.DeleteObject(q);
                                //bd.SaveChanges();
                            }

                            bd.SaveChanges();
                            MessageBox.Show("Registro eliminado.");
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("registro no encontrado.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("falta codigo Privilegio.");
                    txtPrivCodigo.Focus();
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

        private void txtPrivCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtPrivCodigo.Text != "")
                {
                    int codPriv = Convert.ToInt32(txtPrivCodigo.Text);
                    var query = from p in bd.PRIVILEGIOS
                                where p.PRICODIGO == codPriv
                                select p;
                    foreach (var q in query)
                    {
                        txtPrivCodigo.Enabled = false;
                        txtPrivNombre.Text = q.PRINOMBRE;
                        modificado = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void Limpiar()
        {
            txtPrivCodigo.Text = "";
            txtPrivNombre.Text = "";
            txtPrivCodigo.Enabled = true;
            modificado = false;
            txtPrivCodigo.Focus();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {

        }

    }
}
