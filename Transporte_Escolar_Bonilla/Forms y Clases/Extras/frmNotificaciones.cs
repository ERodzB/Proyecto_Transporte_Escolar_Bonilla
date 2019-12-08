using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class frmNotificaciones : Form
    {
        public frmNotificaciones()
        {
            Consultar con = new Consultar();
            InitializeComponent();
            dgvNotificaciones.ClearSelection();
            if (con.Notificaciones().Rows.Count != 0)
            {
                dgvNotificaciones.DataSource = con.Notificaciones();
            }

            else
            {
                MessageBox.Show("No hay Notificaciones ", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmNotificaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
