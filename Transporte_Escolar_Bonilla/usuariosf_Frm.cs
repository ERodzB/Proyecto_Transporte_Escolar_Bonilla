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
            if (ConexionBD.Acceso == 1)
            {
                consultasUsuarios_btn.Visible = true;
                crearUsuarios_btn.Visible = true;
                modificarUsuarios_btn.Visible = true;
                crearPerfil_btn.Visible = true;
                modificarPerfil_btn.Visible = true;
            }
            if (ConexionBD.Acceso == 2)
            {
                consultasUsuarios_btn.Visible = true;
                crearUsuarios_btn.Visible = true;
                modificarUsuarios_btn.Visible = true;
                crearPerfil_btn.Visible = false;
                modificarPerfil_btn.Visible = false;
            }
            if (ConexionBD.Acceso == 3)
            {
                consultasUsuarios_btn.Visible = false;
                crearUsuarios_btn.Visible = true;
                modificarUsuarios_btn.Visible = false;
                crearPerfil_btn.Visible = false;
                modificarPerfil_btn.Visible = false;
            }

        }

        private void CrearUsuarios_btn_Click(object sender, EventArgs e)
        {
            crearUsuario_frm nusuario = new crearUsuario_frm();
            estetics.AbrirFormularios(nusuario, mainUsuarios_panel);
            crearUsuarios_btn.BackColor = Color.White;
            crearUsuarios_btn.ForeColor = Color.MidnightBlue;
            consultasUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUsuarios_btn.ForeColor = Color.White;
            modificarUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUsuarios_btn.ForeColor = Color.White;
            crearPerfil_btn.ForeColor = Color.White;
            crearPerfil_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarPerfil_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarPerfil_btn.ForeColor = Color.White;
        }

        private void ModificarUsuarios_btn_Click(object sender, EventArgs e)
        {
            modificarUsuario_frm modi = new modificarUsuario_frm();
            estetics.AbrirFormularios(modi, mainUsuarios_panel);
            crearUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            crearUsuarios_btn.ForeColor = Color.White;
            consultasUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUsuarios_btn.ForeColor = Color.White;
            modificarUsuarios_btn.BackColor = Color.White;
            modificarUsuarios_btn.ForeColor = Color.MidnightBlue;
            crearPerfil_btn.ForeColor = Color.White;
            crearPerfil_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarPerfil_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarPerfil_btn.ForeColor = Color.White;
        }

        private void CrearPerfil_btn_Click(object sender, EventArgs e)
        {
            crearPerfil_frm cperfil = new crearPerfil_frm();
            estetics.AbrirFormularios(cperfil, mainUsuarios_panel);
            crearUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            crearUsuarios_btn.ForeColor = Color.White;
            consultasUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUsuarios_btn.ForeColor = Color.White;
            modificarUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUsuarios_btn.ForeColor = Color.White;
            crearPerfil_btn.ForeColor = Color.MidnightBlue;
            crearPerfil_btn.BackColor = Color.White; ;
            modificarPerfil_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarPerfil_btn.ForeColor = Color.White;
        }

        private void ModificarPerfil_btn_Click(object sender, EventArgs e)
        {
            modificarPerfiles_frm mperfil = new modificarPerfiles_frm();
            estetics.AbrirFormularios(mperfil, mainUsuarios_panel);
            crearUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            crearUsuarios_btn.ForeColor = Color.White;
            consultasUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUsuarios_btn.ForeColor = Color.White;
            modificarUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUsuarios_btn.ForeColor = Color.White;
            crearPerfil_btn.ForeColor = Color.White;
            crearPerfil_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarPerfil_btn.BackColor = Color.White; 
            modificarPerfil_btn.ForeColor = Color.MidnightBlue;
        }

        private void ConsultasUsuarios_btn_Click(object sender, EventArgs e)
        {
            consulta_usuarios cusuario = new consulta_usuarios();
            estetics.AbrirFormularios(cusuario, mainUsuarios_panel);
            crearUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            crearUsuarios_btn.ForeColor = Color.White;
            consultasUsuarios_btn.BackColor = Color.White;
            consultasUsuarios_btn.ForeColor = Color.MidnightBlue;
            modificarUsuarios_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUsuarios_btn.ForeColor = Color.White;
            crearPerfil_btn.ForeColor = Color.White;
            crearPerfil_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarPerfil_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarPerfil_btn.ForeColor = Color.White;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
