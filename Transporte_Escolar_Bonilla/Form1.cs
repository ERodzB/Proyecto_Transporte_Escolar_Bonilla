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
            login_frm log = new login_frm();
            log.TopLevel = false;
            center_panel.Controls.Add(log);
            log.Show();*/
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
            center_panel.Controls.Clear();
            bar_panel.Location = rutas_btn.Location;
            rutas_frm rutas = new rutas_frm();
            rutas.TopLevel = false;
            center_panel.Controls.Add(rutas);
            rutas.Show();
        }

        private void Unidades_btn_Click(object sender, EventArgs e)
        {
            center_panel.Controls.Clear();
            bar_panel.Location = unidades_btn.Location;
            unidades_frm uni = new unidades_frm();
            uni.TopLevel = false;
            center_panel.Controls.Add(uni);
            uni.Show();
        }

        private void Contratos_btn_Click(object sender, EventArgs e)
        {
            bar_panel.Location = conductores_btn.Location;
            center_panel.Controls.Clear();
            conductores_frm condu = new conductores_frm();
            condu.TopLevel = false;
            center_panel.Controls.Add(condu);
            condu.Show();
        }

        private void Viajes_btn_Click(object sender, EventArgs e)
        {
            bar_panel.Location = clientes_btn.Location;
            center_panel.Controls.Clear();
            clientes_frm client = new clientes_frm();
            client.TopLevel = false;
            center_panel.Controls.Add(client);
            client.Show();
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            bar_panel.Location = contratos_btn.Location;
            center_panel.Controls.Clear();
            contratos_frm contra = new contratos_frm();
            contra.TopLevel = false;
            center_panel.Controls.Add(contra);
            contra.Show();
        }

        private void Usuarios_btn_Click(object sender, EventArgs e)
        {
            bar_panel.Location = usuarios_btn.Location;
            center_panel.Controls.Clear();
            usuarios_frm user = new usuarios_frm();
            user.TopLevel = false;
            center_panel.Controls.Add(user);
            user.Show();
        }
    }
}
