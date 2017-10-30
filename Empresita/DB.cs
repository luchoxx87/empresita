using MySql.Data.MySqlClient;
using System.Data;
namespace Empresita
{
    class DB
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
            string query = "SELECT nombre, apellido FROM Empleado order by Apellido ASC, nombre ASC";
            //Instancio una tabla
            DataTable tabla = new DataTable();
            //Instancio adaptador con la query y la conexion
            adaptador = new MySqlDataAdapter(query, conexion);
            //Abro al conexion
            conexion.Open();
            //Cargo la tabla, con la consulta usando el adaptador
            adaptador.Fill(tabla);
            //Libero la conexion, la cierro
            conexion.Close();
            //devolver la tabla
            return tabla;
        }
    }
}
