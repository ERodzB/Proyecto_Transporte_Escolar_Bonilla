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
    public partial class nuevoempleado : Form
    {
        Consultar consultar = new Consultar();
        Modificar modify = new Modificar();
        public nuevoempleado()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            Validar validar = new Validar();
            int varlicencia=0;


            if (cmbPuesto.Text=="Conductor")
            {
                if(RBLiviana.Checked==false && RBPesada.Checked==false)
                {
                    MessageBox.Show("Error, debe seleccionar el tipo de licencia");
                }
                else
                if (CBInter.Checked == true && RBLiviana.Checked == true)
                {
                    varlicencia = 3;
                }
                else
                if (CBInter.Checked == true && RBPesada.Checked == true)
                {
                    varlicencia = 4;
                }
                else
                if (CBInter.Checked == false && RBPesada.Checked == true)
                {
                    varlicencia = 2;
                }
                else
                if (CBInter.Checked == false && RBLiviana.Checked == true)
                {
                    varlicencia = 1;
                }

                
                if (txtcorreo.Text!="" && txtdireccion.TextLength > 15 && txtidentidad.TextLength == 13 && txtlicencia.Text != "" && txtnombre.TextLength > 2
                    && txtsalario.Text != "" && txttelefono.TextLength == 8 && cmbGenero.SelectedIndex != -1 && cmbPuesto.SelectedIndex != -1 && RBPesada.Checked==true || RBLiviana.Checked==true
                    && dateTimePicker1.Value<System.DateTime.Today && dtpvencimiento.Value>System.DateTime.Today && 
                    System.Text.RegularExpressions.Regex.IsMatch(txtcorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    ingresar.NuevoEmpleado(txtidentidad.Text, txtnombre.Text, Convert.ToDateTime(dateTimePicker1.Text), (cmbGenero.SelectedIndex + 1), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text),
                    txtlicencia.Text, Convert.ToDateTime(dtpvencimiento.Text),varlicencia);
                    modify.BitacoraModulo("Contratación", 3, "Contratación Nuevo Empleado", txtidentidad.Text,txtsalario.Text, "N/A", "N/A", "N/A");                
                    MessageBox.Show("Empleado Guardado con Exito", "Guardado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcorreo.Text = "";
                    txtdireccion.Text = "";
                    txtidentidad.Text = "";
                    txtnombre.Text = "";
                    txtsalario.Text = "";
                    txttelefono.Text = "";
                    txtlicencia.Text = "";
                    dtpvencimiento.ResetText();
                    cmbGenero.SelectedIndex = -1;
                    cmbPuesto.SelectedIndex = -1;
                    dateTimePicker1.ResetText();
                    DAdicionales.Visible = false;
                    LBLLicencia.Visible = false;
                    dtpvencimiento.Visible = false;
                    txtlicencia.Visible = false;
                    lblVencimiento.Visible = false;
                }
                else
                    MessageBox.Show("Error, porfavor llene todos los campos apropiadamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtcorreo.Text != "" && txtdireccion.TextLength > 15 && txtidentidad.TextLength == 13 && txtnombre.TextLength > 2
                   && txtsalario.Text != "" && txttelefono.TextLength == 8 && cmbGenero.SelectedIndex != -1 && cmbPuesto.SelectedIndex != -1
                   && dateTimePicker1.Value<System.DateTime.Today &&
                   System.Text.RegularExpressions.Regex.IsMatch(txtcorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    ingresar.NuevoEmpleado(txtidentidad.Text, txtnombre.Text, Convert.ToDateTime(dateTimePicker1.Text), (cmbGenero.SelectedIndex + 1), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text), txtlicencia.Text, 
                        Convert.ToDateTime(dtpvencimiento.Value.ToString()),0);
                    modify.BitacoraModulo("Contratación", 3, "Contratacion Nuevo Empleado", txtidentidad.Text, txtsalario.Text, "N/A", "N/A", "N/A");
                    MessageBox.Show("Empleado Guardado con Exito", "Guardado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcorreo.Text = "";
                    txtdireccion.Text = "";
                    txtidentidad.Text = "";
                    txtnombre.Text = "";
                    txtsalario.Text = "";
                    txttelefono.Text = "";
                    cmbGenero.SelectedIndex = -1;
                    cmbPuesto.SelectedIndex = -1;
                    dateTimePicker1.ResetText();
                }
                else
                    MessageBox.Show("Error, porfavor llene todos los campos apropiadamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Nuevoempleado_Load(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = consultar.ComboboxPuestos();
            cmbPuesto.DisplayMember = "Nombre_Puesto";
            cmbPuesto.ValueMember = "Codigo_Puesto";
            cmbPuesto.SelectedIndex = -1;
        }

        private void CmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPuesto.Text=="Conductor")
            {
                DAdicionales.Visible = true;
                LBLLicencia.Visible = true;
                dtpvencimiento.Visible = true;
                txtlicencia.Visible = true;
                lblVencimiento.Visible = true;
                txtlicencia.Text = txtidentidad.Text;
                lbltipolic.Visible = true;
                GBlicencia.Visible = true;
            }
            else
            {
                DAdicionales.Visible = false;
                LBLLicencia.Visible = false;
                dtpvencimiento.Visible = false;
                txtlicencia.Visible = false;
                lblVencimiento.Visible = false;
                lbltipolic.Visible = false;
                GBlicencia.Visible = false;
            }
        }

        private void GBlicencia_Enter(object sender, EventArgs e)
        {

        }

        private void RBLiviana_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBInter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar=='.') && !(e.KeyChar=='@'))
            {
                e.Handled = true;
            }
        }

        private void Txtdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtsalario.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void Txtlicencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar=='-'))
            {
                e.Handled = true;
            }
        }
    }
}
