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
    public partial class Principal_frm : Form
    {
        Estetica Estetics = new Estetica();//Clase que manejara lo estetico de el proyecto
        login_frm log = new login_frm();//Login no utilizado debido a que no es necesario 
        public Principal_frm()
        {
            
            InitializeComponent();
            /*clientes_btn.Enabled = false;
            conductores_btn.Enabled = false;
            unidades_btn.Enabled = false;
            contratos_btn.Enabled = false;
            usuarios_btn.Enabled = false;
            rutas_btn.Enabled = false;
            close_btn.Enabled = false;
            Estetics.AbrirFormularios(log, center_panel);*/
        }

        private void Salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Salir_btn_MouseHover(object sender, EventArgs e)
        {
            salir_btn.BackColor = Color.Transparent;
        }

        private void Rutas_btn_Click(object sender, EventArgs e)
        {
            rutas_frm rutas = new rutas_frm(); //Creacion de referencia al formulario
            Estetics.AbrirFormularios(rutas, center_panel);//Para abrir un formulario deben llamar a la referencia y en que panel lo quieren abrir
            bar_panel.Location = rutas_btn.Location;
        }

        private void Unidades_btn_Click(object sender, EventArgs e)
        {
            unidades_frm uni = new unidades_frm();
            Estetics.AbrirFormularios(uni , center_panel);
            bar_panel.Location = unidades_btn.Location;
        }

        private void Contratos_btn_Click(object sender, EventArgs e)
        {
            conductores_frm condu = new conductores_frm();
            Estetics.AbrirFormularios(condu, center_panel);
            bar_panel.Location = conductores_btn.Location;
        }

        private void Viajes_btn_Click(object sender, EventArgs e)
        {
            clientes_frm client = new clientes_frm();
            Estetics.AbrirFormularios(client, center_panel);
            bar_panel.Location = clientes_btn.Location;
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            contratos_frm contra = new contratos_frm();
            Estetics.AbrirFormularios(contra, center_panel);
            bar_panel.Location = contratos_btn.Location;
        }

        private void Usuarios_btn_Click(object sender, EventArgs e)
        {
            usuarios_frm user = new usuarios_frm();
            Estetics.AbrirFormularios(user, center_panel);
            bar_panel.Location = usuarios_btn.Location;
        }
    }
}
