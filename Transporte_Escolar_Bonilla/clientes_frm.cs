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
        }

        //Nuevo Cliente
        private void NuevoCliente_btn_Click(object sender, EventArgs e)
        {
            form_nuevo_cliente cli1 = new form_nuevo_cliente();
            Estetics.AbrirFormularios(cli1, clienteMain_panel);
        }
    }
}
