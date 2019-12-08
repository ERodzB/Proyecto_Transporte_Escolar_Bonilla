﻿using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class Modficar_Empleado : Form
    {
        Consultar consultar = new Consultar();
        Validar valido = new Validar();
        Modificar modify = new Modificar();
        int Licencia = 0;
        public Modficar_Empleado()
        {
            InitializeComponent();

            busqueda.ShortcutsEnabled = false;

            txtnombre.ShortcutsEnabled = false;
            txttelefono.ShortcutsEnabled = false;
            txtdireccion.ShortcutsEnabled = false;
            txtcorreo.ShortcutsEnabled = false;
            txtsalario.ShortcutsEnabled = false;
            txtlicencia.ShortcutsEnabled = false;
        }

        private void Txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modficar_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (valido.validarEmpleado(busqueda.Text) == 1)
            {

                cmbPuesto.DataSource = consultar.ComboboxPuestos();
                cmbPuesto.DisplayMember = "Nombre_Puesto";
                cmbPuesto.ValueMember = "Codigo_Puesto";
                cmbGenero.DataSource = consultar.ComboboxGeneros();
                cmbGenero.DisplayMember = "Gen";
                cmbGenero.ValueMember = "Codigo";
                consultar.BuscarEmpleado(busqueda.Text, txtnombre, cmbGenero, txttelefono, txtcorreo, txtdireccion, txtsalario, cmbPuesto, txtlicencia, dtpvencimiento);
                Licencia = consultar.lic;
                btnModificar.Enabled = true;
                txtnombre.Enabled = true;
                txtcorreo.Enabled = true;
                txtdireccion.Enabled = true;
                txtlicencia.Enabled = true;
                txtsalario.Enabled = true;
                txttelefono.Enabled = true;
                cmbGenero.Enabled = true;
                cmbPuesto.Enabled = true;
                dtpvencimiento.Enabled = true;
                RBPesada.Enabled = true;
                RBLiviana.Enabled = true;
                CBInter.Enabled = true;

                if (Licencia == 1)
                {
                    RBLiviana.Checked = true;

                }
                if (Licencia == 2)
                {
                    RBPesada.Checked = true;

                }
                if (Licencia == 3)
                {
                    RBLiviana.Checked = true;
                    CBInter.Checked = true;

                }
                if (Licencia == 4)
                {
                    RBPesada.Checked = true;
                    CBInter.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("El empleado no existe");
            }
        }

        private void CmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuesto.Text == "Conductor")
            {

                LBLLicencia.Visible = true;
                dtpvencimiento.Visible = true;
                txtlicencia.Visible = true;
                lblVencimiento.Visible = true;
                txtlicencia.Text = busqueda.Text;
                lbltipolic.Visible = true;
                GBlicencia.Visible = true;
            }
            else
            {
                LBLLicencia.Visible = false;
                dtpvencimiento.Visible = false;
                txtlicencia.Visible = false;
                lblVencimiento.Visible = false;
                lbltipolic.Visible = false;
                GBlicencia.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (cmbPuesto.Text == "Conductor")
            {
                if (RBLiviana.Checked == false && RBPesada.Checked == false)
                {
                    MessageBox.Show("Debe seleccionar el tipo de licencia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (CBInter.Checked == true && RBLiviana.Checked == true)
                    {
                        Licencia = 3;
                    }
                    else
                    if (CBInter.Checked == true && RBPesada.Checked == true)
                    {
                        Licencia = 4;
                    }
                    else
                    if (CBInter.Checked == false && RBPesada.Checked == true)
                    {
                        Licencia = 2;
                    }
                    else
                    if (CBInter.Checked == false && RBLiviana.Checked == true)
                    {
                        Licencia = 1;
                    }
                    if (txtnombre.Text.Trim().Length > 2 && cmbGenero.Text != "" && txttelefono.Text.Trim().Length == 8 && txtcorreo.Text != "" && txtdireccion.Text.Trim().Length >= 15 && cmbPuesto.Text != "" && txtsalario.Text.Trim().Length != 0 && double.Parse(txtsalario.Text) > 0 && txtlicencia.Text != "" && dtpvencimiento.Value > System.DateTime.Today && System.Text.RegularExpressions.Regex.IsMatch(txtcorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                    {
                        if (MessageBox.Show("¿Está seguro que desea guardar los cambios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            modify.ModificarEmpleado(busqueda.Text, txtnombre.Text, Int32.Parse(cmbGenero.SelectedValue.ToString()), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text), txtlicencia.Text, Convert.ToDateTime(dtpvencimiento.Value.ToString()), Licencia);
                            modify.BitacoraModulo("Modificación - Empleado", 10, "Modificación de Empleado", "Empleado Modificado: " + busqueda.Text, "N/A", "N/A", "N/A", "N/A");
                            MessageBox.Show("Modificacion Realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcorreo.Text = "";
                            txtdireccion.Text = "";
                            txtlicencia.Text = "";
                            txtnombre.Text = "";
                            txtsalario.Text = "";
                            txttelefono.Text = "";
                            busqueda.Text = "";
                            cmbGenero.SelectedIndex = -1;
                            cmbPuesto.SelectedIndex = -1;
                            dtpvencimiento.ResetText();
                            busqueda.Focus();
                            btnModificar.Enabled = false;
                            txtnombre.Enabled = false;
                            txtcorreo.Enabled = false;
                            txtdireccion.Enabled = false;
                            txtlicencia.Enabled = false;
                            txtsalario.Enabled = false;
                            txttelefono.Enabled = false;
                            cmbGenero.Enabled = false;
                            cmbPuesto.Enabled = false;
                            dtpvencimiento.Enabled = false;
                            RBPesada.Enabled = false;
                            RBLiviana.Enabled = false;
                            CBInter.Enabled = false;
                        }

                    }
                    else
                    {
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
            }
            else
            {
                if (txtnombre.Text.Trim().Length > 2 && cmbGenero.Text != "" && txttelefono.Text.Trim().Length == 8 && txtcorreo.Text != "" && txtdireccion.Text.Trim().Length >= 15 && cmbPuesto.Text != "" && txtsalario.Text.Trim().Length != 0 && double.Parse(txtsalario.Text) > 0 && System.Text.RegularExpressions.Regex.IsMatch(txtcorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                {
                    if (MessageBox.Show("¿Está seguro que desea guardar los cambios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        modify.ModificarEmpleado(busqueda.Text, txtnombre.Text, Int32.Parse(cmbGenero.SelectedValue.ToString()), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text), "N/A", dtpvencimiento.MinDate, 0);
                        modify.BitacoraModulo("Modificación - Empleado", 10, "Modificación de Empleado", "Empleado Modificado: " + busqueda.Text, "N/A", "N/A", "N/A", "N/A");
                        MessageBox.Show("Modificacion Realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcorreo.Text = "";
                        txtdireccion.Text = "";
                        txtlicencia.Text = "";
                        txtnombre.Text = "";
                        txtsalario.Text = "";
                        txttelefono.Text = "";
                        busqueda.Text = "";
                        cmbGenero.SelectedIndex = -1;
                        cmbPuesto.SelectedIndex = -1;
                        busqueda.Focus();
                        btnModificar.Enabled = false;
                        txtnombre.Enabled = false;
                        txtcorreo.Enabled = false;
                        txtdireccion.Enabled = false;
                        txtlicencia.Enabled = false;
                        txtsalario.Enabled = false;
                        txttelefono.Enabled = false;
                        cmbGenero.Enabled = false;
                        cmbPuesto.Enabled = false;
                        dtpvencimiento.Enabled = false;
                        RBPesada.Enabled = false;
                        RBLiviana.Enabled = false;
                        CBInter.Enabled = false;
                    }
                }
                else
                {
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
        }

        private void Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Busqueda_TextChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '@'))
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