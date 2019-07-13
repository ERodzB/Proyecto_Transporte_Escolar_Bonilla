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
    public partial class conductores_frm : Form
    {
        Estetica Estetics = new Estetica();
        public conductores_frm()
        {
            InitializeComponent();
            if (ConexionBD.Acceso == 1)
            {
                consultaConductores_btn.Visible = true;
                nuevoConductor_btn.Visible = true;
                modificarConductores_btn.Visible = true;
                entregaUnidad_btn.Visible = true;
                asignarConductor_btn.Visible = true;
            }

            if (ConexionBD.Acceso == 2)
            {
                consultaConductores_btn.Visible = true;
                nuevoConductor_btn.Visible = true;
                modificarConductores_btn.Visible = true;
                entregaUnidad_btn.Visible = true;
                asignarConductor_btn.Visible = true;
            }
            if (ConexionBD.Acceso == 3)
            {
                consultaConductores_btn.Visible = true;
                nuevoConductor_btn.Visible = false;
                modificarConductores_btn.Visible = false;
                entregaUnidad_btn.Visible = true;
                asignarConductor_btn.Visible = false;
            }

        }

        private void ConductorTop_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NuevoConductor_btn_Click(object sender, EventArgs e)
        {
            nuevoempleado Nuevoempleado = new nuevoempleado();
            Estetics.AbrirFormularios(Nuevoempleado, conductorMain_Panel);
        }

        private void ConsultaConductores_btn_Click(object sender, EventArgs e)
        {
            Consultar_empleados empleados = new Consultar_empleados();
            Estetics.AbrirFormularios(empleados, conductorMain_Panel);
        }

        private void ModificarConductores_btn_Click(object sender, EventArgs e)
        {
            Modficar_Empleado mempleados = new Modficar_Empleado();
            Estetics.AbrirFormularios(mempleados, conductorMain_Panel);
        }

        private void AsignarConductor_btn_Click(object sender, EventArgs e)
        {
            asignacionunidades aunidades = new asignacionunidades(1);
            Estetics.AbrirFormularios(aunidades, conductorMain_Panel);
        }

        private void EntregaUnidad_btn_Click(object sender, EventArgs e)
        {
            asignacionunidades aunidades = new asignacionunidades(2);
            Estetics.AbrirFormularios(aunidades, conductorMain_Panel);
        }
    }
}
