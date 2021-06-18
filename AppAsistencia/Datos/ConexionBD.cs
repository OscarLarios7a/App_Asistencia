using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace AppAsistencia.Datos
{
    public class ConexionBD
    {
        //declaracion de una variable  para la cadena de conexion;
        public static string conexion = @"Data Source=DESKTOP-UATUHL3; Initial Catog=AppAsistencia;Integrated Security=true;";
        public static SqlConnection sqlConexion = new SqlConnection(conexion);

        public static void abrirConexion()
        {
            if (sqlConexion.State == ConnectionState.Closed)
            {
                sqlConexion.Open();
            }
        }
        public static void cerrarConexion()
        {
            if (sqlConexion.State == ConnectionState.Open)
            {
                sqlConexion.Close();
            }
        }

    }
}
