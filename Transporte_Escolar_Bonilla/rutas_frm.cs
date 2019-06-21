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
        }

        //Boton Nueva Ruta
        private void NuevaRuta_btn_Click(object sender, EventArgs e)
        {
            form_nueva_ruta nruta = new form_nueva_ruta();
            Estetics.AbrirFormularios(nruta, mainRutas_panel);
        }
    }
}
