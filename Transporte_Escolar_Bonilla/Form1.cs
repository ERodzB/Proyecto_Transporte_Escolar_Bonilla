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
        public Principal_frm()
        {
            InitializeComponent();
            bar_panel.Visible = false;
            
            
            
            // Estetics.NivelAcceso(ConexionBD.Acceso, rutas_btn, unidades_btn, conductores_btn, clientes_btn, contratos_btn, usuarios_btn, bar_panel);
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

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void UserLogin_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void OlvidadoLogin_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Correo_tb.Visible = true;
            correo_lbl.Visible = true;
            contra_tb.Visible = false;
            contra_lbl.Visible = false;
            regresar_linklbl.Visible = true;
            olvidadoLogin_linklbl.Visible = false;
        }

        private void Regresar_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Correo_tb.Visible = false;
            correo_lbl.Visible = false;
            regresar_linklbl.Visible = false;
            contra_tb.Visible = true;
            contra_lbl.Visible = true;
            olvidadoLogin_linklbl.Visible = true;
        }

        private void IngresarLogin_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            ingreso.login(userLogin_tb.Text, contra_tb.Text);
            if (ConexionBD.Acceso == 1)
            {
                center_panel.Controls.Clear();
                rutas_btn.Enabled = true;
                unidades_btn.Enabled = true;
                conductores_btn.Enabled = true;
                clientes_btn.Enabled = true;
                contratos_btn.Enabled = true;
                usuarios_btn.Enabled = true;
                bar_panel.Enabled = true;
                close_btn.Enabled = true;
            }

            if (ConexionBD.Acceso == 2)
            {
                center_panel.Controls.Clear();
                rutas_btn.Visible = true;
                unidades_btn.Visible = true;
                conductores_btn.Visible = true;
                clientes_btn.Visible = true;
                contratos_btn.Visible = true;
                usuarios_btn.Visible = false;
                bar_panel.Visible = true;
                close_btn.Enabled = true;
            }

            if (ConexionBD.Acceso == 3)
            {
                center_panel.Controls.Clear();
                rutas_btn.Visible = false;
                unidades_btn.Visible = false;
                conductores_btn.Visible = false;
                clientes_btn.Visible = true;
                contratos_btn.Visible = true;
                usuarios_btn.Visible = false;
                bar_panel.Visible = true;
                close_btn.Enabled = true;
            }
            
        }
    }
}
