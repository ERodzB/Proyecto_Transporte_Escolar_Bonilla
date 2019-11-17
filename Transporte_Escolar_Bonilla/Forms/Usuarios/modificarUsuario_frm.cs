using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class modificarUsuario_frm : Form
    {
        Validar valido = new Validar();
        public modificarUsuario_frm()
        {
            InitializeComponent();

            identidad_tb.ShortcutsEnabled = false;
            nombre_tb.ShortcutsEnabled = false;
            actual_tb.ShortcutsEnabled = false;
            nueva_tb.ShortcutsEnabled = false;
            contra_tb.ShortcutsEnabled = false;
        }
        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            Consultar consulto = new Consultar();

            if (valido.validarEmpleado(identidad_tb.Text) == 1)
            {
                Perfil_cmb.DataSource = consulto.llenarPerfiles();
                Perfil_cmb.DisplayMember = "Nombre_Perfil";
                Perfil_cmb.ValueMember = "Codigo_Perfil";
                consulto.BuscarUsuario(identidad_tb.Text, nombre_tb, contra_tb, Perfil_cmb);
                nombre_tb.Enabled = true;
                contra_tb.Enabled = true;

                if (Principal_frm.nomusu.Equals(nombre_tb.Text))
                    Perfil_cmb.Enabled = false;
                else
                    Perfil_cmb.Enabled = true;

                modificar_btn.Enabled = true;
                identidad_tb.Enabled = false;
                actual_tb.Enabled = true;
                nueva_tb.Enabled = true;
                contra_tb.Clear();
            }
            else
            {
                MessageBox.Show("El empleado no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                identidad_tb.Clear();
                identidad_tb.Focus();
            }
        }
        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            if (nombre_tb.Text.Trim().Length > 2 && contra_tb.Text.Trim().Length != 0 && Perfil_cmb.Text != "")
            {
                if (nueva_tb.Text.Length >= 8)
                {
                    if (nueva_tb.Text.Equals(contra_tb.Text) && valido.validarContrasena(actual_tb.Text, identidad_tb.Text) == 1)
                    {
                        if (MessageBox.Show("¿Está seguro que desea guardar los cambios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Modificar modify = new Modificar();
                            modify.ModificarUsuario(identidad_tb.Text, nombre_tb.Text, contra_tb.Text, Perfil_cmb.SelectedIndex + 1);
                            modify.BitacoraModulo("Modificación - Usuario", 10, "Modificación de Información del Usuario ", "Usuario Modificado: " + nombre_tb.Text, "N/A", "N/A", "N/A", "N/A");

                            identidad_tb.Clear();
                            nombre_tb.Clear();
                            contra_tb.Clear();
                            identidad_tb.Enabled = true;
                            nombre_tb.Enabled = true;
                            contra_tb.Enabled = false;
                            Perfil_cmb.Enabled = false;
                            Perfil_cmb.SelectedIndex = -1;
                            modificar_btn.Enabled = false;
                            actual_tb.Clear();
                            actual_tb.Enabled = false;
                            nueva_tb.Clear();
                            nueva_tb.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese nuevamente su contraseña actual, su nueva contraseña y la confirmación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una contraseña de 8 caracteres mínimo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos requeridos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Identidad_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nombre_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Contra_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ModificarUsuario_frm_Load(object sender, EventArgs e)
        {

        }

        private void Actual_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nueva_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OJO2_Click(object sender, EventArgs e)
        {
            if (nueva_tb.PasswordChar == '\0')
                nueva_tb.PasswordChar = '*';
            else
                nueva_tb.PasswordChar = '\0';
        }

        private void OJO1_Click(object sender, EventArgs e)
        {
            if (actual_tb.PasswordChar == '\0')
                actual_tb.PasswordChar = '*';
            else
                actual_tb.PasswordChar = '\0';
        }

        private void OJO3_Click(object sender, EventArgs e)
        {
            if (contra_tb.PasswordChar == '\0')
                contra_tb.PasswordChar = '*';
            else
                contra_tb.PasswordChar = '\0';
        }
    }
}
