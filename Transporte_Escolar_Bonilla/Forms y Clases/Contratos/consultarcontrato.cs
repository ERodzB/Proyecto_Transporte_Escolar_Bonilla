using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class consultarcontrato : Form
    {
        Consultar con = new Consultar();
        Estetica est = new Estetica();
        public consultarcontrato()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Consultarcontrato_Load(object sender, EventArgs e)
        {
            con.cargardvg(dgvConsultaU);
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (CMBFiltro.SelectedIndex == -1 || CBFiltrox.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un Dato Filtro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string ctipo, cfiltro;
                ctipo = CBFiltrox.SelectedItem.ToString();
                cfiltro = CMBFiltro.SelectedValue.ToString();
                con.filtrarcontrato(dgvConsultaU, ctipo, cfiltro);
            }


        }

        private void CBFiltrox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFiltrox.SelectedItem.ToString() == "Clientes")
            {
                CMBFiltro.DataSource = con.combox_Clientes();
                CMBFiltro.DisplayMember = "Nombre_Cliente";
                CMBFiltro.ValueMember = "Codigo_Cliente";
                CMBFiltro.SelectedIndex = -1;
                CMBFiltro.Enabled = true;
            }
            if (CBFiltrox.SelectedItem.ToString() == "Estados")
            {
                CMBFiltro.DataSource = con.combox_estados();
                CMBFiltro.DisplayMember = "Nombre_Estado";
                CMBFiltro.ValueMember = "Codigo_Estado";
                CMBFiltro.SelectedIndex = -1;
                CMBFiltro.Enabled = true;
            }
        }

        private void CMBFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBFiltro.SelectedIndex != -1)
                btnFiltrar.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (CMBFiltro.SelectedIndex == -1 || CBFiltrox.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgvConsultaU.Rows.Count == 0)
            {
                MessageBox.Show("No hay información disponible para impresión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                est.imprimirTabla(dgvConsultaU, "Información de contratos " + CMBFiltro.Text+" "+ CBFiltrox);
            }
        }
    }
}
