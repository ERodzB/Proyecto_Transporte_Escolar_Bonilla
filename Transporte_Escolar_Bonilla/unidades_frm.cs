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
    public partial class unidades_frm : Form
    {
        public unidades_frm()
        {
            InitializeComponent();
            if (ConexionBD.Acceso == 1)
            {
                consultasUnidades_btn.Visible = true;
                mantenimientoUnidades_btn.Visible = true;
                nuevaUnidad_btn.Visible = true;
                modificarUnidad_btn.Visible = true;
                asignarUnidad_btn.Visible = true;
            }

            if (ConexionBD.Acceso == 2)
            {
                consultasUnidades_btn.Visible = true;
                mantenimientoUnidades_btn.Visible = true;
                nuevaUnidad_btn.Visible = true;
                modificarUnidad_btn.Visible = true;
                asignarUnidad_btn.Visible = true;
            }
            if (ConexionBD.Acceso == 3)
            {
                consultasUnidades_btn.Visible = true;
                mantenimientoUnidades_btn.Visible = true;
                nuevaUnidad_btn.Visible = false;
                modificarUnidad_btn.Visible = false;
                asignarUnidad_btn.Visible = false;
            }


        }

        private void MainUnidades_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
