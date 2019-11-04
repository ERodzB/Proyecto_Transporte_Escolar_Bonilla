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

            txtidentidad.ShortcutsEnabled = false;
            txtnombre.ShortcutsEnabled = false;
            txttelefono.ShortcutsEnabled = false;
            txtdireccion.ShortcutsEnabled = false;
            txtcorreo.ShortcutsEnabled = false;
            txtsalario.ShortcutsEnabled = false;
            txtlicencia.ShortcutsEnabled = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e) 
        {
            Ingresar ingresar = new Ingresar();
            Validar validar = new Validar();
            int varlicencia=0;
            string error = validar.valIdORtn(txtidentidad.Text);

            if (cmbPuesto.Text=="Conductor")
            {
               
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
                

                if (error=="" && txtcorreo.Text!="" && txtdireccion.Text.Trim().Length > 15 && txtidentidad.Text.Trim().Length == 13 && txtlicencia.Text.Trim().Length != 0 && txtnombre.Text.Trim().Length > 2
                    && txtsalario.Text.Trim().Length != 0 && double.Parse(txtsalario.Text) > 0 && txttelefono.Text.Trim().Length == 8 && cmbGenero.SelectedIndex != -1 && cmbPuesto.SelectedIndex != -1 && RBPesada.Checked==true || RBLiviana.Checked==true
                    && dateTimePicker1.Value<System.DateTime.Today && dtpvencimiento.Value > System.DateTime.Today && 
                    System.Text.RegularExpressions.Regex.IsMatch(txtcorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    if (MessageBox.Show("¿Está seguro de los datos ingresados?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ingresar.NuevoEmpleado(txtidentidad.Text, txtnombre.Text, Convert.ToDateTime(dateTimePicker1.Text), (cmbGenero.SelectedIndex + 1), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text),
                        txtlicencia.Text, Convert.ToDateTime(dtpvencimiento.Text), varlicencia);
                        modify.BitacoraModulo("Contratación", 3, "Contratación Nuevo Empleado", txtidentidad.Text, txtsalario.Text, "N/A", "N/A", "N/A");
                        MessageBox.Show("Empleado Guardado con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }else
                if (RBLiviana.Checked == false && RBPesada.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar el Tipo de Licencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (txtidentidad.Text == "")
                {
                    MessageBox.Show("La Identidad debe no puede quedar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (error != "")
                {
                    MessageBox.Show(validar.valIdORtn(txtidentidad.Text), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                if (txtidentidad.Text.Trim().Length != 13)
                {
                    MessageBox.Show("La Identidad debe no puede quedar vacio o ser menor a 13 numeros.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    if (txtnombre.Text.Trim().Length <= 2)
                {
                    MessageBox.Show("El Nombre debe ser mayor a 2 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (cmbGenero.Text == "")
                {
                    MessageBox.Show("El Combobox de Genero no puede quedar sin seleccionar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (txttelefono.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El Telefono debe ser solamente los 8 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                       if (txtdireccion.Text.Trim().Length <= 15)
                {
                    MessageBox.Show("La direccion debe ser mas de 15 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (cmbPuesto.Text == "")
                {
                    MessageBox.Show("El puesto no puede quedar sin seleccionar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (txtsalario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("El salario no puede quedar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (double.Parse(txtsalario.Text) < 1)
                {
                    MessageBox.Show("El salario no puede ser menor a 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                        if (txtlicencia.Text == "")
                {
                    MessageBox.Show("La licencia no puede quedar vacia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                        if (dtpvencimiento.Value <= System.DateTime.Today)
                {
                    MessageBox.Show("La fecha de vencimiento de la licencia no puede ser menor al dia de hoy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (dateTimePicker1.Value >= System.DateTime.Today)
                {
                    MessageBox.Show("La fecha de nacimiento no puede ser hoy o en el futuro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (txtcorreo.Text == "")
                {
                    MessageBox.Show("El correo no puede quedar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Use un formato de correo valido \n abc@gmail.com", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                if (error == "" && txtcorreo.Text != "" && txtdireccion.Text.Trim().Length > 15 && txtidentidad.Text.Trim().Length == 13 && txtnombre.Text.Trim().Length > 2
                   && txtsalario.Text.Trim().Length != 0 && double.Parse(txtsalario.Text) > 0 && txttelefono.Text.Trim().Length == 8 && cmbGenero.SelectedIndex != -1 && cmbPuesto.SelectedIndex != -1
                   && dateTimePicker1.Value<System.DateTime.Today &&
                   System.Text.RegularExpressions.Regex.IsMatch(txtcorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    if (MessageBox.Show("¿Está seguro de los datos ingresados?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ingresar.NuevoEmpleado(txtidentidad.Text, txtnombre.Text, Convert.ToDateTime(dateTimePicker1.Text), (cmbGenero.SelectedIndex + 1), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text), txtlicencia.Text,
                        Convert.ToDateTime(dtpvencimiento.Value.ToString()), 0);
                        modify.BitacoraModulo("Contratación", 3, "Contratacion Nuevo Empleado", txtidentidad.Text, txtsalario.Text, "N/A", "N/A", "N/A");
                        MessageBox.Show("Empleado Guardado con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }else
                if (txtidentidad.Text=="")
                {
                    MessageBox.Show("La Identidad debe no puede quedar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                if (error != "")
                {
                    MessageBox.Show(validar.valIdORtn(txtidentidad.Text), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    if (txtnombre.Text.Trim().Length <= 2)
                {
                    MessageBox.Show("El Nombre debe ser mayor a 2 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (cmbGenero.Text == "")
                {
                    MessageBox.Show("El Combobox de Genero no puede quedar sin seleccionar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (txttelefono.Text.Trim().Length != 8)
                {
                    MessageBox.Show("El Telefono debe ser solamente los 8 numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else
                       if (txtdireccion.Text.Trim().Length <= 15)
                {
                    MessageBox.Show("La direccion debe ser mas de 15 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (cmbPuesto.Text == "")
                {
                    MessageBox.Show("El puesto no puede quedar sin seleccionar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (txtsalario.Text.Trim().Length == 0)
                {
                    MessageBox.Show("El salario no puede quedar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (double.Parse(txtsalario.Text) < 1)
                {
                    MessageBox.Show("El salario no puede ser menor a 1", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                       if (dateTimePicker1.Value >= System.DateTime.Today)
                {
                    MessageBox.Show("La fecha de nacimiento no puede ser hoy o en el futuro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                       if (txtcorreo.Text == "")
                {
                    MessageBox.Show("El correo no puede quedar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Use un formato de correo valido \n abc@gmail.com", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
