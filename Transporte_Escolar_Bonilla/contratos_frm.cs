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
                modificarContratos_btn.Visible = true;
            }

            if (ConexionBD.Acceso == 2)
            {
                consultaContratos_btn.Visible = true;
                Contratos_btn.Visible = true;
                modificarContratos_btn.Visible = true;
            }
            if (ConexionBD.Acceso == 3)
            {
                consultaContratos_btn.Visible = true;
                Contratos_btn.Visible = false;
                modificarContratos_btn.Visible =false;
            }


        }

        private void Contratos_btn_Click(object sender, EventArgs e)
        {
            nuevocontrato ncontrato = new nuevocontrato();
            estetics.AbrirFormularios(ncontrato, contratosMain_panel);
        }

        private void ConsultaContratos_btn_Click(object sender, EventArgs e)
        {
            consultarcontrato ccontrato = new consultarcontrato();
            estetics.AbrirFormularios(ccontrato, contratosMain_panel);
        }

        private void ModificarContratos_btn_Click(object sender, EventArgs e)
        {
            contrato_panel modcon = new contrato_panel();
            estetics.AbrirFormularios(modcon, contratosMain_panel);
            //label1.Visible = false;//La form no sobreescribia el label
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
