using System;
using System.Drawing;
using System.Net;//Libreria para mandar Correo
using System.Net.Mail;//Libreria para mandar Correo
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class Principal_frm : Form
    {


        static public string nomusu = "";

        Estetica Estetics = new Estetica();//Clase que manejara lo estetico de el proyecto
        public Principal_frm()
        {
            InitializeComponent();
            //bar_panel.Visible = false;

            userLogin_tb.ShortcutsEnabled = false;
            contra_tb.ShortcutsEnabled = false;
            Correo_tb.ShortcutsEnabled = false;
        }



        private void Salir_btn_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Desea Cerrar el Programa?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
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
            Estetics.AbrirFormularios(uni, center_panel);
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
            DialogResult = MessageBox.Show("¿Desea Cerrar Sesión?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult == DialogResult.Yes)
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
            ingresarLogin_btn.Visible = false;
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
            ingresarLogin_btn.Visible = true;
        }

        private void IngresarLogin_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            Validar val = new Validar();
          
             ingreso.login(userLogin_tb.Text, contra_tb.Text);

                if (ConexionBD.Acceso == 1 || ConexionBD.Acceso == 2 || ConexionBD.Acceso == 3)
                {
                    if (val.validarEstadoUsuario(userLogin_tb.Text, contra_tb.Text) == 202)
                    {
                        MessageBox.Show("Su usuario ha sido desactivado indefinidamente. \nPara más información comuniquese con el administrador", "CUENTA DESACTIVADA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        userLogin_tb.Clear();
                        contra_tb.Clear();
                        userLogin_tb.Focus(); 
                    }
                    else
                    {
                        nomusu = userLogin_tb.Text;

                        ingreso.ActualizarContratos();
                        center_panel.Controls.Clear();
                        btnMax.Visible = true;
                        rutas_btn.Enabled = true;
                        unidades_btn.Enabled = true;
                        conductores_btn.Enabled = true;
                        clientes_btn.Enabled = true;
                        contratos_btn.Enabled = true;
                        usuarios_btn.Enabled = true;
                        bar_panel.Visible = true;
                        close_btn.Enabled = true;
                        btnNoti.Visible = true;
                        btnBitacora.Visible = true;

                        //Verificar si debe realizar un cambio de contraseña periodico por seguridad (CADA 3 MESES)
                        if (val.verificarActualizarContra(nomusu) >= 3)
                            MessageBox.Show("Debe realizar su cambio periodico de contraseña.\nVaya a Usuarios - Modificar Usuario y actualize su contraseña", "SEGURIDAD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                
                }
            

            
        }

        private void Enviar_linklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Validar valido = new Validar();
            Modificar modifico = new Modificar();
            if (valido.validarInicioSession(userLogin_tb.Text, Correo_tb.Text) == 1)
            {
                MailMessage mensaje = new MailMessage("transporte.escolar.bonilla13@gmail.com", Correo_tb.Text, enviar_linklbl.Text, modifico.CambiarContra(userLogin_tb.Text));//Crea el cuerpo del correo
                //MailMessage(Quien lo envia, A quien se lo enviamos, titulo del correo, cuerpo del correo)
                mensaje.IsBodyHtml = true;//el texto que se envia tiene una codificacion html
                SmtpClient mail = new SmtpClient("smtp.gmail.com", 587); // usar el servicio de gmail y especificar el puerto
                mail.UseDefaultCredentials = false; //No estoy seguro de esto
                NetworkCredential ntc = new NetworkCredential("transporte.escolar.bonilla13@gmail.com", "transporte93"); // El correo que lo envia y su contrasena
                mail.Credentials = ntc; // le pasa las credenciales para poder enviar el correo
                mail.EnableSsl = true;// No estoy seguro de esto
                mail.Send(mensaje);//Envia el mensaje creado
                MessageBox.Show("Su Nueva Contraseña ha sido enviada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();//Reinicia la aplicacion

            }
            else
            {
                MessageBox.Show("El usuario o correo introducido son incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        public async void enviarCorreo()
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
        {

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
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == '@') && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }



        private void BtnNoti_Click(object sender, EventArgs e)
        {
            frmNotificaciones noti = new frmNotificaciones();
            Estetics.AbrirFormularios(noti, center_panel);
        }

        private void Center_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMax_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void userLogin_tb_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Principal_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string cierre = e.CloseReason.ToString();

            if (cierre.Equals("UserClosing"))
            {
                DialogResult = MessageBox.Show("¿Desea Cerrar el Programa?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult == DialogResult.Yes)
                    Application.Exit();
                else
                    e.Cancel = true;
            }
        }



        private void BtnBitacora_Click(object sender, EventArgs e)
        {
            BitacoraModulos bmodulos = new BitacoraModulos();
            Estetics.AbrirFormularios(bmodulos, center_panel);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + @"\\manualAyudaTEB.chm");
        }
    }
}
