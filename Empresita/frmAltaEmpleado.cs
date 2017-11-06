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
    public partial class frmAltaEmpleado : Form
    {
        DB db;
        public frmAltaEmpleado(DB unaDB)
        {
            InitializeComponent();
            db = unaDB;
            cargarJefes();
            cargarDepartamento();
        }

        private void cargarJefes()
        {
            lstJefe.DataSource = db.traerEmpleados();
            lstJefe.DisplayMember = "empleado";
            lstJefe.ValueMember = "idEmpleado";
        }

        private void cargarDepartamento()
        {
            lstDepartamento.DataSource = db.traerDepartamentos();
            lstDepartamento.DisplayMember = "depto";
            lstDepartamento.ValueMember = "idDepartamento";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            altaEmpleado();
        }

        private void chkJefe_CheckStateChanged(object sender, EventArgs e)
        {
            lstJefe.Enabled = chkJefe.Checked;
        }

        private void altaEmpleado()
        {
            object idJefe;
            if (chkJefe.Checked)
            {
                idJefe = Convert.ToInt32(lstJefe.SelectedValue);
            }
            else
            {
                idJefe = System.DBNull.Value;
            }
            try
            {
                db.altaEmpleado(idJefe, txtNombre.Text, txtApellido.Text, Convert.ToInt32(lstDepartamento.SelectedValue));
                MessageBox.Show("Empleado dado de alta con esitoh'");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error: " + e.Message);
            }
        }
    }
}
