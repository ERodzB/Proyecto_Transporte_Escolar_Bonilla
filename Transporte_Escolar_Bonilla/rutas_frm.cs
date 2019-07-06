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
        }

        private void ConsultasRutas_btn_Click(object sender, EventArgs e)
        {
            consultar_rutas cruta = new consultar_rutas();
            Estetics.AbrirFormularios(cruta, mainRutas_panel);
        }
    }
}
