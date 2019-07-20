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
        public nuevoempleado()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            Validar validar = new Validar();

            if(cmbPuesto.SelectedIndex==8)
            {
                if (txtcorreo.Text != "" && txtdireccion.Text != "" && txtidentidad.Text != "" && txtlicencia.Text != "" && txtnombre.Text != ""
                    && txtsalario.Text != "" && txttelefono.Text != "" && cmbGenero.SelectedIndex != -1 && dateTimePicker1.Value >= System.DateTime.Today)
                {
                    ingresar.NuevoEmpleado(txtidentidad.Text, txtnombre.Text, Convert.ToDateTime(dateTimePicker1.Text), (cmbGenero.SelectedIndex + 1), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text),
                        txtlicencia.Text, Convert.ToDateTime(dtpvencimiento.Text));
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
                    MessageBox.Show("Error, porfavor llene todos los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtcorreo.Text != "" && txtdireccion.Text != "" && txtidentidad.Text != "" && txtnombre.Text != "" && dateTimePicker1.Value >= System.DateTime.Today
                   && txtsalario.Text != "" && txttelefono.Text != "" && cmbGenero.SelectedIndex != -1 && cmbPuesto.SelectedIndex != -1)
                {
                    ingresar.NuevoEmpleado(txtidentidad.Text, txtnombre.Text, Convert.ToDateTime(dateTimePicker1.Text), (cmbGenero.SelectedIndex + 1), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text), txtlicencia.Text, Convert.ToDateTime(dtpvencimiento.Value.ToString()));
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
                    MessageBox.Show("Error, porfavor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(cmbPuesto.SelectedIndex==8)
            {
                DAdicionales.Visible = true;
                LBLLicencia.Visible = true;
                dtpvencimiento.Visible = true;
                txtlicencia.Visible = true;
                lblVencimiento.Visible = true;
                txtlicencia.Text = txtidentidad.Text;
            }
            else
            {
                DAdicionales.Visible = false;
                LBLLicencia.Visible = false;
                dtpvencimiento.Visible = false;
                txtlicencia.Visible = false;
                lblVencimiento.Visible = false;
            }
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
