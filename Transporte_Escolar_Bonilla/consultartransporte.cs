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
    public partial class consultartransporte : Form
    {
        Consultar con = new Consultar();
        public consultartransporte()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Consultarcontrato_Load(object sender, EventArgs e)
        {
            con.cargardvgvehiculo(dgvConsultaU);
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
                con.filtrarvehiculos(dgvConsultaU, ctipo, cfiltro);
            }
                

        }

        private void CBFiltrox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(CBFiltrox.SelectedItem.ToString()== "Marca Vehiculo")
            {
                CMBFiltro.DataSource = con.ComboboxMVehiculos();
                CMBFiltro.DisplayMember = "Marca";
                CMBFiltro.ValueMember ="Marca";
                CMBFiltro.SelectedIndex = -1;
                CMBFiltro.Enabled = true;
                CMBFiltro.Visible = true;
                label3.Visible = true;
            }
            if (CBFiltrox.SelectedItem.ToString() == "Tipo Vehiculo")
            {
                CMBFiltro.DataSource = con.ComboboxTVehiculos();
                CMBFiltro.DisplayMember = "Tipo";
                CMBFiltro.ValueMember = "Codigo";
                CMBFiltro.SelectedIndex = -1;
                CMBFiltro.Enabled = true;
                CMBFiltro.Visible = true;
                label3.Visible = true;
            }
            if (CBFiltrox.SelectedItem.ToString() == "Estado Vehiculo")
            {
                CMBFiltro.DataSource = con.ComboboxEVehiculos();
                CMBFiltro.DisplayMember = "Estado";
                CMBFiltro.ValueMember = "Codigo";
                CMBFiltro.SelectedIndex = -1;
                CMBFiltro.Enabled = true;
                CMBFiltro.Visible = true;
                label3.Visible = true;
            }
            if (CBFiltrox.SelectedItem.ToString() == "Responsable Vehiculo")
            {
                CMBFiltro.DataSource = con.ComboboEncVehiculos();
                CMBFiltro.DisplayMember = "Nombre";
                CMBFiltro.ValueMember ="Identidad";
                CMBFiltro.SelectedIndex = -1;
                CMBFiltro.Enabled = true;
                CMBFiltro.Visible = true;
                label3.Visible = true;
            }
            if (CBFiltrox.SelectedItem.ToString() == "Sin Asignar")
            {
                CMBFiltro.Visible = false;
                label3.Visible = false;
                CMBFiltro.DataSource = con.ComboboEncVehiculos();
                CMBFiltro.DisplayMember = "Nombre";
                CMBFiltro.ValueMember = "Identidad";
                CMBFiltro.SelectedIndex = 0;
            }

        }

        private void CMBFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMBFiltro.SelectedIndex != -1)
                btnFiltrar.Enabled = true;
        }
    }
}
