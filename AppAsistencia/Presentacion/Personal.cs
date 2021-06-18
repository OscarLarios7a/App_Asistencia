using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppAsistencia.Datos;
using AppAsistencia.Logica;


namespace AppAsistencia.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelVisibles();
            limpiarCajas();
        }

        #region FuncionesPrivadas
        private void limpiarCajas()
        {
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtSueldo.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();

        }
        private void panelVisibles()
        {
            pnlCargos.Visible = false;
            pnlPaginado.Visible = false;
            pnlRegistros.Visible = true;
            pnlRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarEditarPersonal.Visible = false;
        }
        #endregion
    }
}
