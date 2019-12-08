using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class rutas_frm : Form
    {
        Estetica Estetics = new Estetica();

        public rutas_frm()
        {
            InitializeComponent();
            if (ConexionBD.Acceso == 1)
            {
                consultasRutas_btn.Visible = true;
                nuevaRuta_btn.Visible = true;
                modificarRuta_btn.Visible = true;
            }
            if (ConexionBD.Acceso == 2)
            {
                consultasRutas_btn.Visible = true;
                nuevaRuta_btn.Visible = true;
                modificarRuta_btn.Visible = false;
            }
            if (ConexionBD.Acceso == 3)
            {
                consultasRutas_btn.Visible = true;
                nuevaRuta_btn.Visible = false;
                modificarRuta_btn.Visible = false;
            }


        }

        //Boton Nueva Ruta
        private void NuevaRuta_btn_Click(object sender, EventArgs e)
        {
            form_nueva_ruta nruta = new form_nueva_ruta();
            Estetics.AbrirFormularios(nruta, mainRutas_panel);
            nuevaRuta_btn.BackColor = Color.White;
            nuevaRuta_btn.ForeColor = Color.MidnightBlue;
            consultasRutas_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasRutas_btn.ForeColor = Color.White;
            modificarRuta_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarRuta_btn.ForeColor = Color.White;
        }

        private void ConsultasRutas_btn_Click(object sender, EventArgs e)
        {
            consultar_rutas cruta = new consultar_rutas();
            Estetics.AbrirFormularios(cruta, mainRutas_panel);
            nuevaRuta_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevaRuta_btn.ForeColor = Color.White;
            consultasRutas_btn.BackColor = Color.White;
            consultasRutas_btn.ForeColor = Color.MidnightBlue;
            modificarRuta_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarRuta_btn.ForeColor = Color.White;
        }

        private void ModificarRuta_btn_Click(object sender, EventArgs e)
        {
            modificarRutas_frm mrutas = new modificarRutas_frm();
            Estetics.AbrirFormularios(mrutas, mainRutas_panel);
            nuevaRuta_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevaRuta_btn.ForeColor = Color.White;
            consultasRutas_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasRutas_btn.ForeColor = Color.White;
            modificarRuta_btn.BackColor = Color.White;
            modificarRuta_btn.ForeColor = Color.MidnightBlue;
        }
    }
}
