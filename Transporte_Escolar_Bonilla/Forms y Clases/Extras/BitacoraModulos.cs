using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class BitacoraModulos : Form
    {
        Consultar con = new Consultar();
        Estetica est = new Estetica();
        public BitacoraModulos()
        {
            InitializeComponent();
        }

        private void Cmbfiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BitacoraModulos_Load(object sender, EventArgs e)
        {
            cmbfiltro.DataSource = con.Combobox_TipoEvento();
            cmbfiltro.DisplayMember = "Nombre";
            cmbfiltro.ValueMember = "Codigo";
            cmbfiltro.SelectedIndex = -1;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (cmbfiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Error debe seleccionar al menos un fltro antes");
            }
            else
            {
                con.consultabitacora(dgvConsultaU, cmbfiltro.SelectedIndex + 1);

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cmbfiltro.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro");
            }
            else if(dgvConsultaU.Rows.Count == 0)
            {
                MessageBox.Show("No hay informacion disponible para impresion ");

            }
            else
            {
                est.imprimirTabla(dgvConsultaU, "Información de "+ cmbfiltro.Text);
            }
        }
    }
}
