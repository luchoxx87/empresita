using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresita
{
    public partial class frmAltaSucursal : Form
    {
        DB db;
        public frmAltaSucursal(DB unaDb)
        {
            InitializeComponent();
            db = unaDb;
        }

        private void altaSucursal()
        {
            try
            {
                db.altaSucursal(txtNombreSucursal.Text, txtDomicilio.Text);
                MessageBox.Show("Sucursal Dada de alta con esitoh'");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            altaSucursal();
        }
    }
}
