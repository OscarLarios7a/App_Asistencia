using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using AppAsistencia.Logica;

namespace AppAsistencia.Datos
{
    public class dCargo
    {
        #region FuncionInsertarCargo
        public bool InsertarCargo(LCargo parametro)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand sql = new SqlCommand("insertarCargo", ConexionBD.sqlConexion);
                sql.CommandType = CommandType.StoredProcedure;

                sql.Parameters.AddWithValue("@Cargo", parametro.NombreCargo);
                sql.Parameters.AddWithValue("@SueldoXhora", parametro.SueldoCargo);
     
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
        #region FuncionEditarCargo
        public bool EditarPersonal(LCargo parametro)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand sql = new SqlCommand("editarCargo", ConexionBD.sqlConexion);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@Id_Cargo", parametro.Id_Cargo);
                sql.Parameters.AddWithValue("@Cargo", parametro.NombreCargo);
                sql.Parameters.AddWithValue("@SueldoXhora", parametro.SueldoCargo);
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
        #region FuncionEliminarCargo
        /*public bool EliminarPersonal(LCargo parametro)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlCommand sql = new SqlCommand("eliminarCargo", ConexionBD.sqlConexion);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.AddWithValue("@IdCargo", parametro.Id_Cargo);

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
        }*/
        #endregion
        #region FuncionMostrarCargo
        /*public void MostrarPersonal(ref DataTable dt, int desde, int hasta)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlDataAdapter sqlDa = new SqlDataAdapter("mostrarCargo", ConexionBD.sqlConexion);
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
        }*/
        #endregion
        #region FuncionBuscarCargo
        public void BuscarPersonal(ref DataTable dt, string buscador)
        {
            try
            {
                ConexionBD.abrirConexion();
                SqlDataAdapter sqlDa = new SqlDataAdapter("buscarCargo", ConexionBD.sqlConexion);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
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
