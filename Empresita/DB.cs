using MySql.Data.MySqlClient;
using System.Data;

namespace Empresita
{
    public class DB
    {
        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataAdapter adaptador;

        public DB(string configuracion)
        {
            //Instancio la conexion con la cadena de configuracion
            conexion = new MySqlConnection(configuracion);
        }

        public DataTable traerEmpleados()
        {
            //Cadena de la consulta
            string query = "SELECT idEmpleado, concat(nombre,' ',apellido) empleado FROM Empleado order by empleado ASC";
            return traerTabla(query);
        }       

        /// <summary>
        /// Metodo para dar de alta Sucursales
        /// </summary>
        /// <param name="nombreSucursal">Nombre de la Sucursal</param>
        /// <param name="domicilio">Domicilio de la sucursal</param>
        public void altaSucursal(string nombreSucursal, string domicilio)
        {
            instanciarComando("altasucursal");
            cargarParametro("unNombre", MySqlDbType.VarChar, 45, nombreSucursal);
            cargarParametro("unDomicilio", MySqlDbType.VarChar, 45, domicilio);
            ejecutarComando();
        }
        /// <summary>
        /// Metodo para dar de alta departamentos
        /// </summary>
        /// <param name="nombreDepartamento">Nombre del departamento</param>
        /// <param name="piso">Piso</param>
        /// <param name="idSucursal">idSucursal</param>
        public void altaDepartamento(string nombreDepartamento, byte piso, int idSucursal)
        {
            instanciarComando("altaDepartamento");
            cargarParametro("unIdSucursal", MySqlDbType.Int16, idSucursal);
            cargarParametro("unDepartamento", MySqlDbType.VarChar, 45, nombreDepartamento);
            cargarParametro("unPiso", MySqlDbType.UByte, piso);
            ejecutarComando();
        }

        /// <summary>
        /// Metodo que abre la conexion, ejecuta el comando y cierra la conexion
        /// </summary>
        private void ejecutarComando()
        {
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        /// <summary>
        /// Metodo que instancia y setea al objeto comando
        /// </summary>
        /// <param name="nombreSP">Nombre del SP que va a ejecutar el comando</param>
        private void instanciarComando(string nombreSP)
        {
            comando = new MySqlCommand(nombreSP, conexion);
            comando.CommandType = CommandType.StoredProcedure;
        }

        /// <summary>
        /// Intancia y setea un MySQLParameter
        /// </summary>
        /// <param name="unNombre">Nombre del Parametro</param>
        /// <param name="tipo">Tipo MySQL del Parametro</param>
        /// <param name="valor">Valor para el Parametro</param>
        /// <returns>Regresa un MySQLParameter instanciado y seteado</returns>
        private void cargarParametro(string unNombre, MySqlDbType tipo, object valor)
        {
            MySqlParameter param = new MySqlParameter(unNombre, tipo);
            param.Value = valor;
            comando.Parameters.Add(param);
        }

        /// <summary>
        /// Intancia y setea un MySQLParameter
        /// </summary>
        /// <param name="unNombre">Nombre del Parametro</param>
        /// <param name="tipo">Tipo MySQL del Parametro</param>
        /// <param name="longitud">Longitud de la cadena</param>
        /// <param name="valor">Valor para el Parametro</param>
        /// <returns>Regresa un MySQLParameter instanciado y seteado</returns>
        private void cargarParametro(string unNombre, MySqlDbType tipo, int longitud, object valor)
        {
            MySqlParameter param = new MySqlParameter(unNombre, tipo, longitud);
            param.Value = valor;
            comando.Parameters.Add(param);
        }

        internal DataTable traerDepartamentos()
        {
            string query = "SELECT idDepartamento, concat(departamento,', ',piso,'°') Depto FROM Departamento ORDER BY Depto ASC";
            return traerTabla(query);
        }

        internal DataTable traerSucursales()
        {
            string query = "SELECT idSucursal, concat(nombre,', ',domicilio) AS Sucursal FROM Sucursal ORDER BY Sucursal ASC";
            return traerTabla(query);
        }
        private DataTable traerTabla(string query)
        {
            adaptador = new MySqlDataAdapter(query, conexion);
            DataTable tabla = new DataTable();
            conexion.Open();
            adaptador.Fill(tabla);
            conexion.Close();
            return tabla;
        }

        internal void altaEmpleado(object idJefe, string nombre, string apellido, int idDepartamento)
        {
            instanciarComando("altaEmpleado");
            cargarParametro("unIdJefe", MySqlDbType.Int32, idJefe);
            cargarParametro("unIdDepartamento", MySqlDbType.Int32, idDepartamento);
            cargarParametro("unNombre", MySqlDbType.VarChar, 45, nombre);
            cargarParametro("unApellido", MySqlDbType.VarChar, 45, apellido);
            ejecutarComando();
        }
    }
}
