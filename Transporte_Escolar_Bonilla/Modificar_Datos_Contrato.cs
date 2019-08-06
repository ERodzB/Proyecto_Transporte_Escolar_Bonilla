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

            //MessageBox.Show("CARGA", "Atención", MessageBoxButtons.YesNo);

            //cmbTipoServicio.Enabled = true;
            //cmbTipoServicio.Items.Clear();
            //cmbTipoServicio.Items.Add("Bus Completo");
            //cmbTipoServicio.Items.Add("Medio Bus");
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea Regresar?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                contrato_panel modcon = new contrato_panel();
                estetics.AbrirFormularios(modcon, datos_contrato_panel); 
            }
        }

        //DA CLICK AL CONTRATO
        private void DgvDatosContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;

            if(dgvDatosContrato.CurrentRow.Cells[1].Value.ToString() =="Temporal")
            {
                cmbTipoServicio.Items.Clear();
                cmbTipoServicio.Items.Add("Bus Completo");
                cmbTipoServicio.Items.Add("Medio Bus");

                txtContrato.Text = dgvDatosContrato.CurrentRow.Cells[0].Value.ToString();
                txtMontoMensual.Text = dgvDatosContrato.CurrentRow.Cells[2].Value.ToString();
                txtTipoContrato.Text = dgvDatosContrato.CurrentRow.Cells[1].Value.ToString();

                //MessageBox.Show(dgvDatosContrato.CurrentRow.Cells[4].Value.ToString());
                cmbTipoServicio.Text = dgvDatosContrato.CurrentRow.Cells[4].Value.ToString();
                cmbTipoPago.Text = dgvDatosContrato.CurrentRow.Cells[10].Value.ToString();
                //cmbTipoPago.SelectedIndex= Convert.ToInt32(dgvDatosContrato.CurrentRow.Cells[10].Value.ToString())-1;
                txtCuota.Text = dgvDatosContrato.CurrentRow.Cells[3].Value.ToString();
                cmbEstado.Text = dgvDatosContrato.CurrentRow.Cells[9].Value.ToString();
                //cmbEstado.SelectedIndex = Convert.ToInt32(dgvDatosContrato.CurrentRow.Cells[11].Value.ToString()) - 1;
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
                cmbTipoServicio.Items.Clear();
                cmbTipoServicio.Items.Add("Salida o Regreso");
                cmbTipoServicio.Items.Add("Salida y Regreso");

                txtContrato.Text = dgvDatosContrato.CurrentRow.Cells[0].Value.ToString();
                txtMontoMensual.Text = dgvDatosContrato.CurrentRow.Cells[2].Value.ToString();   
                txtTipoContrato.Text = dgvDatosContrato.CurrentRow.Cells[1].Value.ToString();
                
                
                txtAnticipo.Text = dgvDatosContrato.CurrentRow.Cells[5].Value.ToString();
                dtpInicio.Value = DateTime.Parse(dgvDatosContrato.CurrentRow.Cells[6].Value.ToString());
                txtMonto.Text = dgvDatosContrato.CurrentRow.Cells[7].Value.ToString();
                cmbTipoServicio.Text = dgvDatosContrato.CurrentRow.Cells[4].Value.ToString();
                //cmbTipoPago.SelectedIndex = Convert.ToInt32(dgvDatosContrato.CurrentRow.Cells[10].Value.ToString()) - 1;
                cmbTipoPago.Text = dgvDatosContrato.CurrentRow.Cells[10].Value.ToString();
                txtCuota.Text = dgvDatosContrato.CurrentRow.Cells[3].Value.ToString();
                //MessageBox.Show(dgvDatosContrato.CurrentRow.Cells[11].Value.ToString());
                cmbEstado.SelectedIndex = 1;
                dtpInicio.Enabled = true;
                txtMonto.Enabled = true;

                cmbTipoServicio.Enabled = true;   



            }
        }

        private void BtnModificar_Click(object sender, EventArgs e) 
        {
                if(txtTipoContrato.Text == "Temporal")
                {
                    if (txtMonto.Text.Trim().Length == 0 || double.Parse(txtMonto.Text) <= 0 || txtMontoMensual.Text.Trim().Length == 0 || double.Parse(txtMontoMensual.Text) <= 0 || txtCuota.Text.Trim().Length == 0 || double.Parse(txtCuota.Text) <= 0)
                        MessageBox.Show("Debe ingresar los datos correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (int.Parse(txtCuota.Text) > 12)
                            MessageBox.Show("El Máximo de Cuotas permitidas es 12", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            if (MessageBox.Show("¿Está seguro que desea guardar los cambios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                 string estado, tipopago;
                                 estado = cmbEstado.SelectedValue.ToString();
                                 tipopago = cmbTipoPago.SelectedValue.ToString();
                                 modif.ModificarContratoTemporal(txtContrato.Text, double.Parse(txtMontoMensual.Text), cmbTipoServicio.SelectedItem.ToString(), DateTime.Parse(dtpInicio.Text), double.Parse(txtMonto.Text), txtFechaFinal.Text, int.Parse(estado), int.Parse(tipopago), int.Parse(txtCuota.Text));
                                 modif.BitacoraModulo("Modificación - Contrato", 10, "Modificación Información del Contrato", txtCliente.Text, "N/A", "N/A", "N/A", "N/A");
                            }
                        }
                    }
                         
                    
                }


                if(txtTipoContrato.Text == "Viaje")
                {
                    if (txtMonto.Text.Trim().Length == 0 || double.Parse(txtMonto.Text) <= 0)
                        MessageBox.Show("Debe ingresar un monto válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (MessageBox.Show("¿Está seguro que desea guardar los cambios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string estado;
                            estado = cmbEstado.SelectedValue.ToString();
                            modif.ModificarContratoViaje(txtContrato.Text, double.Parse(txtAnticipo.Text), cmbTipoServicio.SelectedItem.ToString(), DateTime.Parse(dtpInicio.Text), double.Parse(txtMonto.Text), txtFechaFinal.Text, int.Parse(estado));
                            modif.BitacoraModulo("Modificación - Contrato", 10, "Modificación Información del Contrato", txtCliente.Text, "N/A", "N/A", "N/A", "N/A");
                        }
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
            if (txtCuota.Text.Trim().Length != 0 && int.Parse(txtCuota.Text) <= 12)
                txtFechaFinal.Text = dtpInicio.Value.AddMonths(int.Parse(txtCuota.Text)).ToString("MM/dd/yyyy"); 
        }

        private void DtpInicio_ValueChanged(object sender, EventArgs e)
        {
            if (txtCuota.Text.Trim().Length != 0 && int.Parse(txtCuota.Text) <= 12)
                txtFechaFinal.Text = dtpInicio.Value.AddMonths(int.Parse(txtCuota.Text)).ToString("MM/dd/yyyy");
        }

        private void CmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCuota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
