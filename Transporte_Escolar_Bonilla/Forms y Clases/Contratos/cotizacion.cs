using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla.Forms_y_Clases.Contratos
{
    public partial class cotizacion : Form
    {
        public Double subtotal;
        Ingresar ing = new Ingresar();
        public cotizacion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir///@14.0592217,-87.2431174,15z/data=!4m2!4m1!3e0");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
            txtDescuento.Text = "0";
            txtDistancia.Text = "";
            txtISV.Text = "";
            txtNombre.Text = "";
            txtRebaja.Text = "0";
            txtRegreso.Text = "";
            txtSalida.Text = "";
            txtSubtotal.Text = "";
            txtTarifa.Text = "";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtTotal.Text = "";
            RBRoundtrip.Checked = true;
            gbPago.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text!="" && txtCorreo.Text!="" && txtTelefono1.Text!="" && txtTelefono2.Text!="" &&
                txtSalida.Text!="" && txtRegreso.Text!="" && txtTarifa.Text!="" && txtDistancia.Text!="")
            {
                if (txtNombre.Text.Length > 3  && txtSalida.Text.Length > 3 && txtRegreso.Text.Length > 3)
                {
                    if (txtTelefono1.Text.Length == 8 && txtTelefono2.Text.Length == 8)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            if (Double.Parse(txtDistancia.Text) > 0 && Double.Parse(txtTarifa.Text) > 0)
                            {
                                if (rbSingle.Checked == true)
                                {
                                    subtotal = Double.Parse(txtDistancia.Text) * Double.Parse(txtTarifa.Text);

                                }
                                else
                                {
                                    subtotal = (Double.Parse(txtDistancia.Text) * Double.Parse(txtTarifa.Text)) * 2;
                                }

                                gbPago.Visible = true;
                                btnCalcular.Visible = false;
                                btnCotizar.Enabled = true;
                                txtSubtotal.Text = subtotal.ToString();
                                txtISV.Text = (Double.Parse(txtSubtotal.Text) * 0.15).ToString();
                                txtTotal.Text = (Double.Parse(txtSubtotal.Text) + Double.Parse(txtISV.Text)).ToString();
                            }
                            else
                                MessageBox.Show("Ingrese una distancia y una tarifa mayores a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Ingrese el correo en un formato válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Los telefonos deben ser igual a 8 caracteres cada uno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El nombre, punto de origen y destino final deben ser mayores a 3 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Debe llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RBRoundtrip_CheckedChanged(object sender, EventArgs e)
        {
            gbPago.Visible = false;
            btnCalcular.Visible = true;
            btnCotizar.Enabled = false;
            txtRebaja.Text = "0";
            txtDescuento.Text = "0";
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            gbPago.Visible = false;
            btnCalcular.Visible = true;
            btnCotizar.Enabled = false;
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            gbPago.Visible = false;
            btnCalcular.Visible = true;
            btnCotizar.Enabled = false;
        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {
            gbPago.Visible = false;
            btnCalcular.Visible = true;
            btnCotizar.Enabled = false;
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            btnRecalcular.Visible = true;
            btnCotizar.Enabled = false;
            if (txtDescuento.Text == "")
                txtDescuento.Text = "0";
            else { 
                if (Double.Parse(txtDescuento.Text) > 100)
                    txtDescuento.Text = "100";
                else
                    txtRebaja.Text = (subtotal * (Double.Parse(txtDescuento.Text) / 100)).ToString();
            }
        }



    private void txtRebaja_TextChanged(object sender, EventArgs e)
        {
            btnRecalcular.Visible = true;
            btnCotizar.Enabled = false;
            if (txtRebaja.Text == "")
                txtRebaja.Text = "0";
            else { 
                if (Double.Parse(txtRebaja.Text) > subtotal)
                    txtRebaja.Text = txtSubtotal.Text;
                else    
                    txtDescuento.Text = ((Double.Parse(txtRebaja.Text) / subtotal)*100).ToString();
            }
        }


        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            btnRecalcular.Visible = false;
            btnCotizar.Enabled = true;
            txtSubtotal.Text =(subtotal-double.Parse(txtRebaja.Text)).ToString(); 
            txtISV.Text = (Double.Parse(txtSubtotal.Text) * 0.15).ToString();
            txtTotal.Text = (Double.Parse(txtSubtotal.Text) + Double.Parse(txtISV.Text)).ToString();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {

        if (txtNombre.Text != "" && txtCorreo.Text != "" && txtTelefono1.Text != "" && txtTelefono2.Text != "" &&
            txtSalida.Text != "" && txtRegreso.Text != "" && txtTarifa.Text != "" && txtDistancia.Text != "")
            {
                if (txtNombre.Text.Length > 3 && txtSalida.Text.Length > 3 && txtRegreso.Text.Length > 3)
                {
                    if (txtTelefono1.Text.Length == 8 && txtTelefono2.Text.Length == 8)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            if (Double.Parse(txtDistancia.Text) > 0 && Double.Parse(txtTarifa.Text) > 0)
                            {

                                string nametipoviaje = "";

                                if (rbSingle.Checked == true)
                                    nametipoviaje = rbSingle.Text;
                                if (RBRoundtrip.Checked == true)
                                    nametipoviaje = RBRoundtrip.Text;
                                ing.NuevaCotizacion(txtNombre.Text, txtCorreo.Text, txtTelefono1.Text, txtTelefono2.Text, txtSalida.Text, txtRegreso.Text, Double.Parse(txtDistancia.Text), Double.Parse(txtTarifa.Text),
                                    nametipoviaje, Double.Parse(txtSubtotal.Text), Double.Parse(txtDescuento.Text), Double.Parse(txtISV.Text), Double.Parse(txtRebaja.Text), Double.Parse(txtTotal.Text));

                                MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCorreo.Text = "";
                                txtDescuento.Text = "0";
                                txtDistancia.Text = "";
                                txtISV.Text = "";
                                txtNombre.Text = "";
                                txtRebaja.Text = "0";
                                txtRegreso.Text = "";
                                txtSalida.Text = "";
                                txtSubtotal.Text = "";
                                txtTarifa.Text = "";
                                txtTelefono1.Text = "";
                                txtTelefono2.Text = "";
                                txtTotal.Text = "";
                                RBRoundtrip.Checked = true;
                                gbPago.Visible = false;

                            }
                            else
                                MessageBox.Show("Ingrese una distancia y una tarifa mayores a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Ingrese el correo en un formato válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Los telefonos deben ser igual a 8 caracteres cada uno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El nombre, punto de origen y destino final deben ser mayores a 3 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Debe llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtRebaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRebaja.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtTarifa.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '@'))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && txtSalida.Text.Trim().Length == 0)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtRegreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && txtRegreso.Text.Trim().Length == 0)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRebaja.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
    }
}
