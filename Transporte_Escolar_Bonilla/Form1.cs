using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//Libreria para mandar Correo
using System.Net.Mail;//Libreria para mandar Correo

namespace Transporte_Escolar_Bonilla
{
    public partial class Principal_frm : Form
    {

        int usuario_key_press = 0;
        int contrasena_key_press = 0;

        Estetica Estetics = new Estetica();//Clase que manejara lo estetico de el proyecto
        Consultar consulto = new Consultar();
        public Principal_frm()
        {
            InitializeComponent();
            //bar_panel.Visible = false;
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
            enviar_linklbl.Visible = true;
            Correo_tb.Visible = true;
            correo_lbl.Visible = true;
            contra_tb.Visible = false;
            contra_lbl.Visible = false;
            regresar_linklbl.Visible = true;
            olvidadoLogin_linklbl.Visible = false;
        }

        private void Regresar_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            enviar_linklbl.Visible = false;
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
            if (ConexionBD.Acceso == 1 || ConexionBD.Acceso == 2 || ConexionBD.Acceso == 3)
            {
                ingreso.ActualizarContratos();
                center_panel.Controls.Clear();
                button1.Visible = true;
                rutas_btn.Enabled = true;
                unidades_btn.Enabled = true;
                conductores_btn.Enabled = true;
                clientes_btn.Enabled = true;
                contratos_btn.Enabled = true;
                usuarios_btn.Enabled = true;
                bar_panel.Visible = true;
                close_btn.Enabled = true;
                btnNoti.Visible = true;
           
            }
        }

        private void Enviar_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Validar valido = new Validar();
            Modificar modifico = new Modificar();
            if(valido.validarInicioSession(userLogin_tb.Text, Correo_tb.Text) == 1)
            {
                MailMessage mensaje = new MailMessage("transporte.escolar.bonilla13@gmail.com",Correo_tb.Text,enviar_linklbl.Text, modifico.CambiarContra(userLogin_tb.Text));//Crea el cuerpo del correo
                //MailMessage(Quien lo envia, A quien se lo enviamos, titulo del correo, cuerpo del correo)
                mensaje.IsBodyHtml = true;//el texto que se envia tiene una codificacion html
                SmtpClient mail = new SmtpClient("smtp.gmail.com", 587); // usar el servicio de gmail y especificar el puerto
                mail.UseDefaultCredentials = false; //No estoy seguro de esto
                NetworkCredential ntc = new NetworkCredential("transporte.escolar.bonilla13@gmail.com", "transporte93"); // El correo que lo envia y su contrasena
                mail.Credentials = ntc; // le pasa las credenciales para poder enviar el correo
                mail.EnableSsl = true;// No estoy seguro de esto
                mail.Send(mensaje);//Envia el mensaje creado
                MessageBox.Show("Nueva Contraseña enviada");
                Application.Restart();//Reinicia la aplicacion
                
            }else
            {
                MessageBox.Show("El usuario o correo introducido son incorrectos");
            }
        }

        private void Contra_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void UserLogin_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Correo_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar=='@') && !(e.KeyChar=='.'))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BitacoraModulos bmodulos = new BitacoraModulos();
            Estetics.AbrirFormularios(bmodulos,center_panel);
        }

        private void BtnNoti_Click(object sender, EventArgs e)
        {
            frmNotificaciones noti = new frmNotificaciones();
            Estetics.AbrirFormularios(noti, center_panel);
        }

        private void Center_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
