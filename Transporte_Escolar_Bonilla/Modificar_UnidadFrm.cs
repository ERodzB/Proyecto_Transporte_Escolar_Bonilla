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
    public partial class Modificar_UnidadFrm : Form
    {
        Consultar con = new Consultar();
        Modificar mod = new Modificar();
        public Modificar_UnidadFrm()
        {
            InitializeComponent();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (txtColor.Text.Trim().Length > 2 && dtpEmision.Value <= System.DateTime.Today && dtpVencimiento.Value > System.DateTime.Today && cmbEstadoVehiculo.Text!="")
            {
                if (MessageBox.Show("¿Está seguro que desea guardar los cambios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    mod.ModificarVehiculo(txtPlaca.Text, txtColor.Text, int.Parse(cmbEstadoVehiculo.SelectedValue.ToString()), DateTime.Parse(dtpEmision.Text), DateTime.Parse(dtpVencimiento.Text));
                    mod.BitacoraModulo("Modificación - Unidad", 10, "Modificación de Informacion de Un Vehiculo", "Vehiculo Modificado: " + txtPlaca.Text, "N/A", "N/A", "N/A", "N/A");
                    txtPlaca.Text = "";
                    txtColor.Text = "";
                    cmbEstadoVehiculo.SelectedIndex = -1;
                    dtpEmision.ResetText();
                    dtpEmision.Enabled = false;
                    dtpVencimiento.ResetText();
                    dtpVencimiento.Enabled = false; 
                }
            }
            else
                MessageBox.Show("Debe ingresar los datos correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Modificar_UnidadFrm_Load(object sender, EventArgs e)
        {
            con.CargadgvModVehiculos(dgvVehiculos);
            cmbEstadoVehiculo.DataSource = con.combox_mod_vehiculo ();
            cmbEstadoVehiculo.DisplayMember = "Nombre_Estado";
            cmbEstadoVehiculo.ValueMember = "Codigo_Estado";
            cmbEstadoVehiculo.SelectedIndex = -1;

        }

 

        private void DgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvVehiculos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaca.Text = dgvVehiculos.CurrentRow.Cells[0].Value.ToString();
            txtColor.Text = dgvVehiculos.CurrentRow.Cells[8].Value.ToString();
            dtpEmision.Value = DateTime.Parse(dgvVehiculos.CurrentRow.Cells[11].Value.ToString());
            dtpVencimiento.Value = DateTime.Parse(dgvVehiculos.CurrentRow.Cells[12].Value.ToString());
            cmbEstadoVehiculo.SelectedIndex = 1;

            txtColor.Enabled = true;
            dtpEmision.Enabled = true;
            dtpVencimiento.Enabled = true;
            cmbEstadoVehiculo.Enabled = true;
            btnModificar.Enabled = true;
        }
    }
}
