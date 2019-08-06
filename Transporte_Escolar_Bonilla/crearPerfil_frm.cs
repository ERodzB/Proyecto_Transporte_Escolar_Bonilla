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
    public partial class crearPerfil_frm : Form
    {
        public crearPerfil_frm()
        {
            InitializeComponent();
        }

        private void Crear_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            Validar valido = new Validar();

            if (nombrePerfil_tb.Text.Trim().Length > 2 && desPerfil_tb.Text.Trim().Length > 2 && nivelAcceso_cmb.Text!="")
            {
                if (valido.validarPerfil(nombrePerfil_tb.Text) == 0) 
                {
                    ingreso.NuevoPerfil(nivelAcceso_cmb.SelectedIndex + 1, nombrePerfil_tb.Text, desPerfil_tb.Text);
                    nivelAcceso_cmb.SelectedIndex = -1;
                    nombrePerfil_tb.Clear();
                    desPerfil_tb.Clear();

                }
                else
                {
                    MessageBox.Show("Ya existe ese perfil", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un mínimo de 3 caracteres por campo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombrePerfil_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DesPerfil_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
