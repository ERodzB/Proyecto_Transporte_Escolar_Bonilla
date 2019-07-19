﻿using System;
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
        Estetica estetica = new Estetica();
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

        private void ConsultasUnidades_btn_Click(object sender, EventArgs e)
        {
            consultartransporte transporte = new consultartransporte();
            estetica.AbrirFormularios(transporte, mainUnidades_panel);
        }

        private void ModificarUnidad_btn_Click(object sender, EventArgs e)
        {
            Modificar_UnidadFrm modunidad = new Modificar_UnidadFrm();
            estetica.AbrirFormularios(modunidad, mainUnidades_panel);
        }
    }
}
