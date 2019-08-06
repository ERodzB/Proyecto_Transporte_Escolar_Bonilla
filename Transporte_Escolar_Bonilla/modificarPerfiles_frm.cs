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
    public partial class modificarPerfiles_frm : Form
    {
        Consultar consulto = new Consultar();
        public modificarPerfiles_frm()
        {
            InitializeComponent();
        }

        private void ModificarPerfiles_frm_Load(object sender, EventArgs e)
        {
            
            Perfiles_cmb.DataSource = consulto.llenarPerfiles();
            Perfiles_cmb.DisplayMember = "Nombre_Perfil";
            Perfiles_cmb.ValueMember = "Codigo_Perfil";
            Perfiles_cmb.SelectedIndex = -1;
            nivelAcceso_cmb.SelectedIndex = -1;
            nombrePerfil_tb.Clear();
            desPerfil_tb.Clear();
        }

        private void Perfiles_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Perfiles_cmb.SelectedIndex >=0)
            {
                consulto.BuscarPerfiles(Perfiles_cmb.SelectedIndex + 1, nivelAcceso_cmb, nombrePerfil_tb, desPerfil_tb);
            }
        }

        private void Modificar_btn_Click(object sender, EventArgs e) 
        {
            if (nombrePerfil_tb.Text.Trim().Length > 2 && desPerfil_tb.Text.Trim().Length > 2 && nivelAcceso_cmb.Text!="" && Perfiles_cmb.Text!="")
            {
                Modificar mperfiles = new Modificar();

                mperfiles.ModificarPerfiles(Perfiles_cmb.SelectedIndex + 1, nivelAcceso_cmb.SelectedIndex + 1, nombrePerfil_tb.Text, desPerfil_tb.Text);
                mperfiles.BitacoraModulo("Modificación - Perfiles", 10, "Modificación de Información del Perfil ", "Perfil Modificado: " + nombrePerfil_tb.Text, "N/A", "N/A", "N/A", "N/A");

                Perfiles_cmb.DataSource = consulto.llenarPerfiles();
                Perfiles_cmb.DisplayMember = "Nombre_Perfil";
                Perfiles_cmb.ValueMember = "Codigo_Perfil";
                Perfiles_cmb.SelectedIndex = -1;
                nivelAcceso_cmb.SelectedIndex = -1;
                nombrePerfil_tb.Clear();
                desPerfil_tb.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
