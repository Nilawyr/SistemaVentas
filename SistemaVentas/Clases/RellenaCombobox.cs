using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.Data;

namespace SistemaVentas
{
    class RellenaCombobox
    {
        //DBDataContext db = new DBDataContext();
        private SisVentasEntities db = new SisVentasEntities();
      
        NATURALEZA nat = new NATURALEZA();
        public ComboBox CargaNaturaleza()
        {
            ComboBox cmbNaturaleza= new ComboBox();
            var query = from p in db.NATURALEZA
                        select new
                        {
                            NATCODIGO = p.NATSID,
                            NATNOMBRE = p.NATNOMBRE,
                        };

            cmbNaturaleza.DataSource = query;
            cmbNaturaleza.DisplayMember = "NATNOMBRE";
            cmbNaturaleza.ValueMember = "NATCODIGO";

            return cmbNaturaleza;
            // GridView1.DataSource = query;
            //  GridView1.DataBind();
        }
    
    }
}
