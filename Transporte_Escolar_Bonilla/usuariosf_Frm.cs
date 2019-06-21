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
    public partial class usuarios_frm : Form
    {
        Estetica estetics = new Estetica();
        public usuarios_frm()
        {
            InitializeComponent();
        }

        private void CrearUsuarios_btn_Click(object sender, EventArgs e)
        {
            crearUsuario_frm nusuario = new crearUsuario_frm();
            estetics.AbrirFormularios(nusuario, mainUsuarios_panel);
        }

        private void ModificarUsuarios_btn_Click(object sender, EventArgs e)
        {
            modificarUsuario_frm modi = new modificarUsuario_frm();
            estetics.AbrirFormularios(modi, mainUsuarios_panel);
        }

        private void CrearPerfil_btn_Click(object sender, EventArgs e)
        {
            crearPerfil_frm cperfil = new crearPerfil_frm();
            estetics.AbrirFormularios(cperfil, mainUsuarios_panel);
        }

        private void ModificarPerfil_btn_Click(object sender, EventArgs e)
        {
            modificarPerfiles_frm mperfil = new modificarPerfiles_frm();
            estetics.AbrirFormularios(mperfil, mainUsuarios_panel);
        }
    }
}
