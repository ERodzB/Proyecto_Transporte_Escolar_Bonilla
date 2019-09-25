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
    
    public partial class contratos_frm : Form
    {
        Estetica estetics = new Estetica();
        public contratos_frm()
        {
            InitializeComponent();
            if (ConexionBD.Acceso == 1)
            {
                consultaContratos_btn.Visible = true;
                Contratos_btn.Visible = true;
                ContratosPrivado_btn.Visible = true;
            }

            if (ConexionBD.Acceso == 2)
            {
                consultaContratos_btn.Visible = true;
                Contratos_btn.Visible = true;
                ContratosPrivado_btn.Visible = true;
            }
            if (ConexionBD.Acceso == 3)
            {
                consultaContratos_btn.Visible = true;
                Contratos_btn.Visible = false;
                ContratosPrivado_btn.Visible =false;
            }


        }

        //TEMPORAL
        private void Contratos_btn_Click(object sender, EventArgs e)
        {           
            nuevocontrato ncontrato = new nuevocontrato();
            estetics.AbrirFormularios(ncontrato, contratosMain_panel);
            consultaContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultaContratos_btn.ForeColor = Color.White;
            Contratos_btn.BackColor = Color.White;
            Contratos_btn.ForeColor = Color.MidnightBlue;
            ContratosPrivado_btn.BackColor = Color.FromArgb(12, 24, 94);
            ContratosPrivado_btn.ForeColor = Color.White;
            modificarContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarContratos_btn.ForeColor = Color.White;
            pagos_btn.BackColor = Color.FromArgb(12, 24, 94);
            pagos_btn.ForeColor = Color.White;
            btnGenerarContrato.BackColor = Color.FromArgb(12, 24, 94);
            btnGenerarContrato.ForeColor = Color.White;

        }

        private void ConsultaContratos_btn_Click(object sender, EventArgs e)
        {
            consultarcontrato ccontrato = new consultarcontrato();
            estetics.AbrirFormularios(ccontrato, contratosMain_panel);
            consultaContratos_btn.BackColor = Color.White;
            consultaContratos_btn.ForeColor = Color.MidnightBlue;
            Contratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            Contratos_btn.ForeColor = Color.White;
            ContratosPrivado_btn.BackColor = Color.FromArgb(12, 24, 94);
            ContratosPrivado_btn.ForeColor = Color.White;
            modificarContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarContratos_btn.ForeColor = Color.White;
            pagos_btn.BackColor = Color.FromArgb(12, 24, 94);
            pagos_btn.ForeColor = Color.White;
            btnGenerarContrato.BackColor = Color.FromArgb(12, 24, 94);
            btnGenerarContrato.ForeColor = Color.White;
        }

        //PRIVADO
        private void ModificarContratos_btn_Click(object sender, EventArgs e)
        {      
            nuevoviaje viaje = new nuevoviaje();
            estetics.AbrirFormularios(viaje, contratosMain_panel);
            //label1.Visible = false;//La form no sobreescribia el label
            consultaContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultaContratos_btn.ForeColor = Color.White;
            Contratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            Contratos_btn.ForeColor = Color.White;
            ContratosPrivado_btn.BackColor = Color.White;
            ContratosPrivado_btn.ForeColor = Color.MidnightBlue;
            modificarContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarContratos_btn.ForeColor = Color.White;
            pagos_btn.BackColor = Color.FromArgb(12, 24, 94);
            pagos_btn.ForeColor = Color.White;
            btnGenerarContrato.BackColor = Color.FromArgb(12, 24, 94);
            btnGenerarContrato.ForeColor = Color.White;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        //MODIFICAR
        private void Button1_Click(object sender, EventArgs e)
        {
            contrato_panel modcon = new contrato_panel();
            estetics.AbrirFormularios(modcon, contratosMain_panel);
            consultaContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultaContratos_btn.ForeColor = Color.White;
            Contratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            Contratos_btn.ForeColor = Color.White;
            ContratosPrivado_btn.BackColor = Color.FromArgb(12, 24, 94);
            ContratosPrivado_btn.ForeColor = Color.White;
            modificarContratos_btn.BackColor = Color.White;
            modificarContratos_btn.ForeColor = Color.MidnightBlue;
            pagos_btn.BackColor = Color.FromArgb(12, 24, 94);
            pagos_btn.ForeColor = Color.White;
            btnGenerarContrato.BackColor = Color.FromArgb(12, 24, 94);
            btnGenerarContrato.ForeColor = Color.White;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            pagos_frm pago = new pagos_frm();
            estetics.AbrirFormularios(pago, contratosMain_panel);

            consultaContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultaContratos_btn.ForeColor = Color.White;
            Contratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            Contratos_btn.ForeColor = Color.White;
            ContratosPrivado_btn.BackColor = Color.FromArgb(12, 24, 94);
            ContratosPrivado_btn.ForeColor = Color.White;
            modificarContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarContratos_btn.ForeColor = Color.White;
            pagos_btn.BackColor = Color.White;
            pagos_btn.ForeColor = Color.MidnightBlue;
            btnGenerarContrato.BackColor = Color.FromArgb(12, 24, 94);
            btnGenerarContrato.ForeColor = Color.White;
        }

        private void BtnGenerarContrato_Click(object sender, EventArgs e)
        {
            Generar_Contrato gencon = new Generar_Contrato();
            estetics.AbrirFormularios(gencon, contratosMain_panel);

            consultaContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultaContratos_btn.ForeColor = Color.White;
            Contratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            Contratos_btn.ForeColor = Color.White;
            ContratosPrivado_btn.BackColor = Color.FromArgb(12, 24, 94);
            ContratosPrivado_btn.ForeColor = Color.White;
            modificarContratos_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarContratos_btn.ForeColor = Color.White;
            pagos_btn.BackColor = Color.FromArgb(12, 24, 94);
            pagos_btn.ForeColor = Color.White;
            btnGenerarContrato.BackColor = Color.White;
            btnGenerarContrato.ForeColor = Color.MidnightBlue;

        }
    }
}
