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
    /// <summary>
    /// Clase con el objetivo de conectar a la BD y mostrar
    /// como traer una tabla
    /// </summary>
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
                string cadena = string.Format("Server=win2012-01;Database=bd47_autoempresa;Uid={0};Pwd={1};", txtUsuario.Text, txtPass.Text);
                //Instancio mi DB
                DB db = new DB(cadena);
                //Asigno la tabla de empleados como fuente del dataGridView
                dgvVisor.DataSource = db.traerEmpleados();
                //Instancio el formulario frmAltaSucursal, pasandole
                //como parametro, la DB
                frmAltaSucursal altaSucursal = new frmAltaSucursal(db);
                //Muestro el formulario que instancie
                altaSucursal.Show();
                frmAltaDepartamento altaDepartamento = new frmAltaDepartamento(db);
                frmAltaEmpleado altaEmpleado = new frmAltaEmpleado(db);
                altaEmpleado.Show();
                altaDepartamento.Show();
            }
            catch (Exception e)
            {
                //En caso de error, muestro un mensaje con la naturaleza del mismo
                MessageBox.Show(e.Message);
            }
        }
    }
}
