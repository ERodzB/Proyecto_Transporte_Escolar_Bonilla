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
    public partial class Modificar_Datos_Contrato : Form
    {
        Estetica estetics = new Estetica();
        Consultar con = new Consultar();
        Modificar modif = new Modificar();
        public Modificar_Datos_Contrato()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Modificar_Datos_Contrato_Load(object sender, EventArgs e)
        {
            txtCliente.Text = contrato_panel.nombrecli;

            con.CargadgvDatosContrato(dgvDatosContrato, contrato_panel.codc);

            /*cmbEstado.DataSource = con.combox_mod_contrato(txtContrato.Text);
            cmbEstado.DisplayMember = "Nombre_Estado";
            cmbEstado.ValueMember = "Codigo_Estado";
            cmbEstado.SelectedIndex = -1;*/

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea Regresar?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                contrato_panel modcon = new contrato_panel();
                estetics.AbrirFormularios(modcon, datos_contrato_panel);
            }
        }

        private void DgvDatosContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtContrato.Text = dgvDatosContrato.CurrentRow.Cells[0].Value.ToString();
            dtpInicio.Value = DateTime.Parse(dgvDatosContrato.CurrentRow.Cells[1].Value.ToString());
            txtMonto.Text = dgvDatosContrato.CurrentRow.Cells[2].Value.ToString();
            dtpFinal.Value = DateTime.Parse(dgvDatosContrato.CurrentRow.Cells[3].Value.ToString());        

            dtpFinal.Enabled = true;
            txtMonto.Enabled = true;

            cmbEstado.DataSource = con.combox_mod_contrato();
            cmbEstado.DisplayMember = "Nombre_Estado";
            cmbEstado.ValueMember = "Codigo_Estado";
            cmbEstado.SelectedIndex = -1;
            cmbEstado.Enabled = true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea guardar los cambios\nSi guarda los cambios, no podrá revertir los cambios?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string estado;
                estado = cmbEstado.SelectedValue.ToString();
                modif.ModificarContrato(txtContrato.Text, double.Parse(txtMonto.Text), DateTime.Parse(dtpFinal.Text), int.Parse(estado));
            }
        }
    }
}
