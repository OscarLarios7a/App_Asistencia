using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

using AppAsistencia.Logica;
//using AppAsistencia.Datos;
namespace AppAsistencia.Datos
{
    public class dPersonal
    {
        #region FuncionInsertarPersonal 
        public bool InsertarPersonal(lPersonal parametro)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand sql = new SqlCommand("InsertarPersonal",ConexionBD.sqlConexion);
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@Nombres",parametro.NombrePersonal);
                sql.Parameters.AddWithValue("@Identificacion", parametro.IdentificacionPersonal);
                sql.Parameters.AddWithValue("@Pais", parametro.PaisPersonal);
                sql.Parameters.AddWithValue("@Id_cargo", parametro.Id_CargoPersonal);
                sql.Parameters.AddWithValue("@SueldoPorHora", parametro.SueldoPorHoraPersonal);
                sql.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }     
        }
        #endregion
        #region FuncionEditarPersonal
        public bool EditarPersonal(lPersonal parametro)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand sql = new SqlCommand("editarPersonal", ConexionBD.sqlConexion);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Id_personal",parametro.Id_Personal);
                sql.Parameters.AddWithValue("@Nombres", parametro.NombrePersonal);
                sql.Parameters.AddWithValue("@Identificacion", parametro.IdentificacionPersonal);
                sql.Parameters.AddWithValue("@Pais", parametro.PaisPersonal);
                sql.Parameters.AddWithValue("@Id_cargo", parametro.Id_CargoPersonal);
                sql.Parameters.AddWithValue("@SueldoPorHora", parametro.SueldoPorHoraPersonal);
                sql.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }
        #endregion
        #region FuncionEliminarPersonal
        public bool EliminarPersonal(lPersonal parametro)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand sql = new SqlCommand("eliminarPersonal", ConexionBD.sqlConexion);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@IdPersonal", parametro.Id_Personal);
    
                sql.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }
        #endregion
        #region FuncionMostrarPersonal
        public void MostrarPersonal(ref DataTable dt, int desde, int hasta)
        {
            try 
	        {
                ConexionBD.abrirConexion();
                SqlDataAdapter sqlDa = new SqlDataAdapter("mostrarPersonal", ConexionBD.sqlConexion);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                sqlDa.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                sqlDa.Fill(dt);
            }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.StackTrace); 

	        }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }
        #endregion
        #region FuncionBuscarPersonal
        public void BuscarPersonal(ref DataTable dt, int desde, int hasta,string buscador)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlDataAdapter sqlDa = new SqlDataAdapter("BuscarPersonal", ConexionBD.sqlConexion);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                sqlDa.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                sqlDa.SelectCommand.Parameters.AddWithValue("@Buscador", buscador);
                sqlDa.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
            finally
            {
                ConexionBD.cerrarConexion();
            }
        }
        #endregion

    }
}
