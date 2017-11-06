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
    public partial class frmAltaDepartamento : Form
    {
        private DB db;

        public frmAltaDepartamento(DB db)
        {
            InitializeComponent();
            this.db = db;
            lstSucursal.DataSource = db.traerSucursales();
            lstSucursal.DisplayMember = "Sucursal";
            lstSucursal.ValueMember = "idSucursal";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            altaDepartamento();
        }

        private void altaDepartamento()
        {
            try
            {
                db.altaDepartamento(txtDepartamento.Text, Convert.ToByte(nudPiso.Value), Convert.ToInt32(lstSucursal.SelectedValue));
                MessageBox.Show("Departamento ingresado con esitoh'");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un problema: " + e.Message);
            }
        }
    }
}
