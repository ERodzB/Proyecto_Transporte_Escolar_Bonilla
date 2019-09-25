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
            consultasUnidades_btn.BackColor = Color.White;
            consultasUnidades_btn.ForeColor = Color.MidnightBlue;
            nuevaUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevaUnidad_btn.ForeColor = Color.White;
            asignarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            asignarUnidad_btn.ForeColor = Color.White;
            mantenimientoUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            mantenimientoUnidades_btn.ForeColor = Color.White;
            modificarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUnidad_btn.ForeColor = Color.White;
            btnNuevaPlaca.BackColor = Color.FromArgb(12, 24, 94);
            btnNuevaPlaca.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(12, 24, 94);
            button1.ForeColor = Color.White;
        }

        //Nueva Unidad
        private void NuevaUnidad_btn_Click(object sender, EventArgs e)
        {
            form_nueva_unidad uni = new form_nueva_unidad();
            estetica.AbrirFormularios(uni, mainUnidades_panel);
            consultasUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUnidades_btn.ForeColor = Color.White;
            nuevaUnidad_btn.BackColor = Color.White;
            nuevaUnidad_btn.ForeColor = Color.MidnightBlue;
            asignarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            asignarUnidad_btn.ForeColor = Color.White;
            mantenimientoUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            mantenimientoUnidades_btn.ForeColor = Color.White;
            modificarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUnidad_btn.ForeColor = Color.White;
            btnNuevaPlaca.BackColor = Color.FromArgb(12, 24, 94);
            btnNuevaPlaca.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(12, 24, 94);
            button1.ForeColor = Color.White;
        }

        //Asignar una ruta a la Unidad
        private void AsignarUnidad_btn_Click(object sender, EventArgs e)
        {
            form_asignar_ruta ruta = new form_asignar_ruta();
            estetica.AbrirFormularios(ruta, mainUnidades_panel);
            consultasUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUnidades_btn.ForeColor = Color.White;
            nuevaUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevaUnidad_btn.ForeColor = Color.White;
            asignarUnidad_btn.BackColor = Color.White;
            asignarUnidad_btn.ForeColor = Color.MidnightBlue;
            mantenimientoUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            mantenimientoUnidades_btn.ForeColor = Color.White;
            modificarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUnidad_btn.ForeColor = Color.White;
            btnNuevaPlaca.BackColor = Color.FromArgb(12, 24, 94);
            btnNuevaPlaca.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(12, 24, 94);
            button1.ForeColor = Color.White;
        }

        private void MantenimientoUnidades_btn_Click(object sender, EventArgs e)
        {
            form_mantenimiento_unidad mant = new form_mantenimiento_unidad();
            estetica.AbrirFormularios(mant, mainUnidades_panel);
            consultasUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUnidades_btn.ForeColor = Color.White;
            nuevaUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevaUnidad_btn.ForeColor = Color.White;
            asignarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            asignarUnidad_btn.ForeColor = Color.White;
            mantenimientoUnidades_btn.BackColor = Color.White;
            mantenimientoUnidades_btn.ForeColor = Color.MidnightBlue;
            modificarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUnidad_btn.ForeColor = Color.White;
            btnNuevaPlaca.BackColor = Color.FromArgb(12, 24, 94);
            btnNuevaPlaca.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(12, 24, 94);
            button1.ForeColor = Color.White;
        }

        private void ModificarUnidad_btn_Click(object sender, EventArgs e)
        {
            Modificar_UnidadFrm modunidad = new Modificar_UnidadFrm();
            estetica.AbrirFormularios(modunidad, mainUnidades_panel);
            consultasUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUnidades_btn.ForeColor = Color.White;
            nuevaUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevaUnidad_btn.ForeColor = Color.White;
            asignarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            asignarUnidad_btn.ForeColor = Color.White;
            mantenimientoUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            mantenimientoUnidades_btn.ForeColor = Color.White;
            modificarUnidad_btn.BackColor = Color.White;
            modificarUnidad_btn.ForeColor = Color.MidnightBlue;
            btnNuevaPlaca.BackColor = Color.FromArgb(12, 24, 94);
            btnNuevaPlaca.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(12, 24, 94);
            button1.ForeColor = Color.White;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            form_mantenimientos mant = new form_mantenimientos();
            estetica.AbrirFormularios(mant, mainUnidades_panel);
            consultasUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUnidades_btn.ForeColor = Color.White;
            nuevaUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevaUnidad_btn.ForeColor = Color.White;
            asignarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            asignarUnidad_btn.ForeColor = Color.White;
            mantenimientoUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            mantenimientoUnidades_btn.ForeColor = Color.White;
            modificarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUnidad_btn.ForeColor = Color.White;
            btnNuevaPlaca.BackColor = Color.FromArgb(12, 24, 94);
            btnNuevaPlaca.ForeColor = Color.White;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.MidnightBlue;
        }

        private void BtnNuevaPlaca_Click(object sender, EventArgs e)
        {
            frmNuevaPlaca nplaca = new frmNuevaPlaca();
            estetica.AbrirFormularios(nplaca, mainUnidades_panel);
            consultasUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasUnidades_btn.ForeColor = Color.White;
            nuevaUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevaUnidad_btn.ForeColor = Color.White;
            asignarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            asignarUnidad_btn.ForeColor = Color.White;
            mantenimientoUnidades_btn.BackColor = Color.FromArgb(12, 24, 94);
            mantenimientoUnidades_btn.ForeColor = Color.White;
            modificarUnidad_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarUnidad_btn.ForeColor = Color.White;
            btnNuevaPlaca.BackColor = Color.White;
            btnNuevaPlaca.ForeColor = Color.MidnightBlue;
            button1.BackColor = Color.FromArgb(12, 24, 94);
            button1.ForeColor = Color.White;
        }
    }
}
