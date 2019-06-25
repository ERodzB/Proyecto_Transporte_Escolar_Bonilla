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
    public partial class modificarUsuario_frm : Form
    {
        Validar valido = new Validar();
        public modificarUsuario_frm()
        {
            InitializeComponent();
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
                Perfil_cmb.Enabled = true;
                modificar_btn.Enabled = true;
                identidad_tb.Enabled = false;
                actual_tb.Enabled = true;
                nueva_tb.Enabled = true;
                contra_tb.Clear();
            }
            else
            {
                MessageBox.Show("El empleado no existe");
            }
        }
        private void Modificar_btn_Click(object sender, EventArgs e)
        {
            if (nombre_tb.Text!="" && contra_tb.Text!="" && Perfil_cmb.Text!="")
            {
                if (nueva_tb.Text.Equals(contra_tb.Text) && valido.validarContrasena(actual_tb.Text, identidad_tb.Text)==1)
                {
                    Modificar modify = new Modificar();
                    modify.ModificarUsuario(identidad_tb.Text, nombre_tb.Text, contra_tb.Text, Perfil_cmb.SelectedIndex + 1);
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
                else
                {
                    MessageBox.Show("ERROR! Ingrese nuevamente su contraseña actual, su nueva contraseña y la confirmacion");
                }
            }
            else
            {
                MessageBox.Show("ERROR! Ingrese todos los datos requeridos");
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
