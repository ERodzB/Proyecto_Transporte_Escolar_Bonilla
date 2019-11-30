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
            if(rbSingle.Checked == true)
            {
                subtotal = Double.Parse(txtDistancia.Text) * Double.Parse(txtTarifa.Text);
                
            }
            else
            {
                subtotal = (Double.Parse(txtDistancia.Text) * Double.Parse(txtTarifa.Text))*2;
            }

            gbPago.Visible = true;
            btnCalcular.Visible = false;
            btnCotizar.Enabled = true;
            txtSubtotal.Text = subtotal.ToString();
            txtISV.Text = (Double.Parse(txtSubtotal.Text) * 0.15).ToString();
            txtTotal.Text = (Double.Parse(txtSubtotal.Text) + Double.Parse(txtISV.Text)).ToString();

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
            txtRebaja.Text = (subtotal * (Double.Parse(txtDescuento.Text) / 100)).ToString();
        }

        private void txtRebaja_TextChanged(object sender, EventArgs e)
        {
            btnRecalcular.Visible = true;
            btnCotizar.Enabled = false;
            txtDescuento.Text = ((Double.Parse(txtRebaja.Text) / subtotal)*100).ToString();
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
            string nametipoviaje="";

            if (rbSingle.Checked == true)
                nametipoviaje = rbSingle.Text;
            if (RBRoundtrip.Checked == true)
                nametipoviaje = RBRoundtrip.Text;
            ing.NuevaCotizacion(txtNombre.Text, txtCorreo.Text, txtTelefono1.Text, txtTelefono2.Text, txtSalida.Text, txtRegreso.Text, Double.Parse(txtDistancia.Text), Double.Parse(txtTarifa.Text),
                nametipoviaje, Double.Parse(txtSubtotal.Text), Double.Parse(txtDescuento.Text),Double.Parse(txtISV.Text),Double.Parse(txtRebaja.Text),Double.Parse(txtTotal.Text));

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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
