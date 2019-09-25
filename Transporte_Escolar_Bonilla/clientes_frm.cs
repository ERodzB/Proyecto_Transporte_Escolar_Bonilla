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
    public partial class clientes_frm : Form
    {
        Estetica Estetics = new Estetica();

        public clientes_frm()
        {
            InitializeComponent();
            if (ConexionBD.Acceso == 1)
            {
                consultasClientes_btn.Visible = true;
                nuevoCliente_btn.Visible = true;
                modificarCliente_btn.Visible = true;
            }

            if (ConexionBD.Acceso == 2)
            {
                consultasClientes_btn.Visible = true;
                nuevoCliente_btn.Visible = true;
                modificarCliente_btn.Visible = true;
            }

            if (ConexionBD.Acceso == 3)
            {
                consultasClientes_btn.Visible = true;
                nuevoCliente_btn.Visible = false;
                modificarCliente_btn.Visible = false;
            }
        }

        //Nuevo Cliente
        private void NuevoCliente_btn_Click(object sender, EventArgs e)
        {
            form_nuevo_cliente cli1 = new form_nuevo_cliente();
            Estetics.AbrirFormularios(cli1, clienteMain_panel);
            nuevoCliente_btn.ForeColor = Color.FromArgb(12, 24, 94);
            nuevoCliente_btn.BackColor = Color.White;
            consultasClientes_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasClientes_btn.ForeColor = Color.White;
            modificarCliente_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarCliente_btn.ForeColor = Color.White;
        }

        private void ConsultasClientes_btn_Click(object sender, EventArgs e)
        {
            consultar_clientes ccliente = new consultar_clientes();
            Estetics.AbrirFormularios(ccliente, clienteMain_panel);
            nuevoCliente_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevoCliente_btn.ForeColor = Color.White;
            consultasClientes_btn.ForeColor = Color.FromArgb(12, 24, 94);
            consultasClientes_btn.BackColor = Color.White;
            modificarCliente_btn.BackColor = Color.FromArgb(12, 24, 94);
            modificarCliente_btn.ForeColor = Color.White;
        }

        private void ModificarCliente_btn_Click(object sender, EventArgs e)
        {
            Form_Modificar_Cliente modcli = new Form_Modificar_Cliente();
            Estetics.AbrirFormularios(modcli, clienteMain_panel);
            nuevoCliente_btn.BackColor = Color.FromArgb(12, 24, 94);
            nuevoCliente_btn.ForeColor = Color.White;
            consultasClientes_btn.BackColor = Color.FromArgb(12, 24, 94);
            consultasClientes_btn.ForeColor = Color.White;
            modificarCliente_btn.ForeColor = Color.FromArgb(12, 24, 94);
            modificarCliente_btn.BackColor = Color.White;
        }
    }
}
