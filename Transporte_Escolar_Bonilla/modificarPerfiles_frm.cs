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
        }

        private void Perfiles_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Perfiles_cmb.SelectedIndex >=0)
            {
                consulto.BuscarPerfiles(Perfiles_cmb.SelectedIndex + 1, nivelAcceso_cmb, nombrePerfil_tb, desPerfil_tb);
            }
        }
    }
}
