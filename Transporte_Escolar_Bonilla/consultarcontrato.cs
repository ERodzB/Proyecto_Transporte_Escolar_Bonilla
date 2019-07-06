using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class consultarcontrato : Form
    {
        Consultar con = new Consultar();
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
                MessageBox.Show("Porfavor seleccione una opcion del menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(CBFiltrox.SelectedItem.ToString()=="Clientes")
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
    }
}
