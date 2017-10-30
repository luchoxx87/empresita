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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cargarEmpleados();
        }

        private void cargarEmpleados()
        {
            try
            {
                //Asigno cadena de conexion
                string cadena = string.Format("Server=win2012-01;Database=bd47_autoEmpresa;Uid={0};Pwd={1};", txtUsuario.Text, txtPass.Text);
                //Instancio mi DB
                DB db = new DB(cadena);
                //Asigno la tabla de empleados como fuente del dataGridView
                dgvVisor.DataSource = db.traerEmpleados();
            }
            catch (Exception e)
            {
                //En caso de error, muestro un mensaje con la naturaleza del mismo
                MessageBox.Show(e.Message);
            }
        }
    }
}
