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
    public partial class login_frm : Form
    {
        public login_frm()
        {
            InitializeComponent();
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
            correo_lbl.Visible =false;
            regresar_linklbl.Visible = false;
            contra_tb.Visible = true;
            contra_lbl.Visible = true;
            olvidadoLogin_linklbl.Visible = true;

        }
    }
}
