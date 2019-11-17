using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class crearUsuario_frm : Form
    {
        public crearUsuario_frm()
        {
            InitializeComponent();

            identidad_tb.ShortcutsEnabled = false;
            nombre_tb.ShortcutsEnabled = false;
            contra_tb.ShortcutsEnabled = false;
            confirm_tb.ShortcutsEnabled = false;
        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            Validar valido = new Validar();
            Modificar mod = new Modificar();

            //String error = " ";
            //int cont = 0;

            //if(nombre_tb.Text.Trim().Length < 3)
            //{
            //    error += "Debe ingresar 3 caracteres mínimo para el Nombre de Usuario\n";
            //    cont++;               
            //}


            //if (contra_tb.Text.Trim().Length < 8)
            //{
            //    error += "Ingrese una contraseña de 8 caracteres mínimo";
            //    cont++;
            //}

            //if(cont>0)
            //    MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{
            if (contra_tb.Text.Equals(confirm_tb.Text))
            {
                if (valido.validarEmpleado(identidad_tb.Text) == 1)
                {
                    if (valido.validarUsuario_Empleado(identidad_tb.Text) == 0)
                    {
                        if (valido.validarUsuario(nombre_tb.Text) == 0)
                        {
                            if (nombre_tb.Text.Trim().Length > 2)
                            {
                                if (contra_tb.Text.Trim().Length >= 8)
                                {
                                    if (Perfil_cmb.SelectedIndex != -1)
                                    {
                                        ingreso.NuevoUsuario(identidad_tb.Text, nombre_tb.Text, contra_tb.Text, Convert.ToInt32(Perfil_cmb.SelectedIndex.ToString()) + 1);
                                        mod.BitacoraModulo("Creación Usuario", 5, "Creación de un Nuevo Usuario", nombre_tb.Text, "N/A", "N/A", "N/A", "N/A");
                                        contra_tb.Clear();
                                        nombre_tb.Clear();
                                        confirm_tb.Clear();
                                        Perfil_cmb.SelectedIndex = -1;
                                        identidad_tb.Clear();
                                    }
                                    else
                                        MessageBox.Show("Debe seleccionar un Perfil", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                    MessageBox.Show("Debe ingresar una contraseña de 8 caracteres mínimo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Debe ingresar 3 caracteres mínimo para el Nombre de Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un usuario con ese nombre", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            nombre_tb.Clear();
                            nombre_tb.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El empleado ya tiene un usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        identidad_tb.Clear();
                        identidad_tb.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El empleado no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    identidad_tb.Clear();
                    identidad_tb.Focus();
                }
            }
            else
                MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CrearUsuario_frm_Load(object sender, EventArgs e)
        {
            Consultar consu = new Consultar();
            Perfil_cmb.DataSource = consu.llenarPerfiles();
            Perfil_cmb.DisplayMember = "Nombre_Perfil";
            Perfil_cmb.ValueMember = "Codigo_Perfil";
            Perfil_cmb.SelectedIndex = -1;
        }

        private void Perfil_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void Conform_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void OJO1_Click(object sender, EventArgs e)
        {
            if (contra_tb.PasswordChar == '\0')
                contra_tb.PasswordChar = '*';
            else
                contra_tb.PasswordChar = '\0';
        }

        private void OJO2_Click(object sender, EventArgs e)
        {
            if (confirm_tb.PasswordChar == '\0')
                confirm_tb.PasswordChar = '*';
            else
                confirm_tb.PasswordChar = '\0';
        }
    }
}
