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
            cmbTipoPago.DataSource = con.combox_tipo_pago();
            cmbTipoPago.DisplayMember = "NombrePago";
            cmbTipoPago.ValueMember = "TipoPago";
            cmbTipoPago.SelectedIndex = -1;
            cmbEstado.DataSource = con.combox_mod_contrato();
            cmbEstado.DisplayMember = "Nombre_Estado";
            cmbEstado.ValueMember = "Codigo_Estado";
            cmbEstado.SelectedIndex = -1;
            cmbTipoServicio.Items.Add("Bus Completo");
            cmbTipoServicio.Items.Add("Salida y Regreso");

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
            btnModificar.Enabled = true;
            if(dgvDatosContrato.CurrentRow.Cells[1].Value.ToString() =="Temporal")
            {                
                txtContrato.Text = dgvDatosContrato.CurrentRow.Cells[0].Value.ToString();
                txtMontoMensual.Text = dgvDatosContrato.CurrentRow.Cells[2].Value.ToString();
                txtTipoContrato.Text = dgvDatosContrato.CurrentRow.Cells[1].Value.ToString();

                //MessageBox.Show(dgvDatosContrato.CurrentRow.Cells[4].Value.ToString());
                cmbTipoServicio.Text = dgvDatosContrato.CurrentRow.Cells[4].Value.ToString();
                cmbTipoPago.SelectedIndex= Convert.ToInt32(dgvDatosContrato.CurrentRow.Cells[10].Value.ToString())-1;
                txtCuota.Text = dgvDatosContrato.CurrentRow.Cells[3].Value.ToString();
                cmbEstado.SelectedIndex = Convert.ToInt32(dgvDatosContrato.CurrentRow.Cells[11].Value.ToString()) - 1;
                cmbTipoServicio.Enabled = true;                
                dtpInicio.Value = DateTime.Parse(dgvDatosContrato.CurrentRow.Cells[6].Value.ToString());
                txtMonto.Text = dgvDatosContrato.CurrentRow.Cells[7].Value.ToString();
                //dtpFinal.Value = DateTime.Parse(dgvDatosContrato.CurrentRow.Cells[8].Value.ToString());


                txtCuota.Enabled = true;
                txtMontoMensual.Enabled = true;
                txtMonto.Enabled = true;
                dtpInicio.Enabled = true;
                //dtpFinal.Enabled = true;

                
                cmbEstado.Enabled = true;

                
                cmbTipoPago.Enabled = true;
                

            }
            else if(dgvDatosContrato.CurrentRow.Cells[1].Value.ToString() == "Viaje")
            {
                txtContrato.Text = dgvDatosContrato.CurrentRow.Cells[0].Value.ToString();
                txtMontoMensual.Text = dgvDatosContrato.CurrentRow.Cells[2].Value.ToString();   
                txtTipoContrato.Text = dgvDatosContrato.CurrentRow.Cells[1].Value.ToString();
                
                
                txtAnticipo.Text = dgvDatosContrato.CurrentRow.Cells[5].Value.ToString();
                dtpInicio.Value = DateTime.Parse(dgvDatosContrato.CurrentRow.Cells[6].Value.ToString());
                txtMonto.Text = dgvDatosContrato.CurrentRow.Cells[7].Value.ToString();
                cmbTipoServicio.Text = dgvDatosContrato.CurrentRow.Cells[4].Value.ToString();
                cmbTipoPago.SelectedIndex = Convert.ToInt32(dgvDatosContrato.CurrentRow.Cells[10].Value.ToString()) - 1;
                txtCuota.Text = dgvDatosContrato.CurrentRow.Cells[3].Value.ToString();
                MessageBox.Show(dgvDatosContrato.CurrentRow.Cells[11].Value.ToString());
                cmbEstado.SelectedIndex = 1;
                dtpInicio.Enabled = true;
                txtMonto.Enabled = true;

                cmbTipoServicio.Enabled = true;



            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea guardar los cambios\nSi guarda los cambios, no podrá revertir los cambios?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(txtTipoContrato.Text == "Temporal")
                {
                    string estado, tipopago;
                    estado = cmbEstado.SelectedValue.ToString();
                    tipopago = cmbTipoPago.SelectedValue.ToString();
                    modif.ModificarContratoTemporal(txtContrato.Text, double.Parse(txtMontoMensual.Text), cmbTipoServicio.SelectedItem.ToString(), DateTime.Parse(dtpInicio.Text), double.Parse(txtMonto.Text), txtFechaFinal.Text, int.Parse(estado), int.Parse(tipopago));

                }
                if(txtTipoContrato.Text == "Viaje")
                {
                    string estado;
                    estado = cmbEstado.SelectedValue.ToString();
                    modif.ModificarContratoViaje(txtContrato.Text, double.Parse(txtAnticipo.Text), cmbTipoServicio.SelectedItem.ToString(), DateTime.Parse(dtpInicio.Text), double.Parse(txtMonto.Text), txtFechaFinal.Text, int.Parse(estado));

                }
            }
        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back))
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtMonto.Text,"^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void DgvDatosContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtpFinal_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCuota_TextChanged(object sender, EventArgs e)
        {
            if (txtCuota.Text != " ")
                txtFechaFinal.Text = dtpInicio.Value.AddMonths(int.Parse(txtCuota.Text)).ToString("MM/dd/yyyy");
        }

        private void DtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (txtCuota.Text != "")
                txtFechaFinal.Text = dtpInicio.Value.AddMonths(int.Parse(txtCuota.Text)).ToString("MM/dd/yyyy");
        }

        private void CmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
