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
    public partial class consultar_clientes : Form
    {
        Consultar con = new Consultar();
        public consultar_clientes()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (cbConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor seleccione una opcion del menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbConsulta.SelectedItem.ToString() == "Clientes")
            {
                con.consultaclientes(dgvConsultaU, "Clientes");
            }
            if (cbConsulta.SelectedItem.ToString() == "Contratos por Cliente")
            {
                con.consultaclientes(dgvConsultaU, "Contratos por Cliente");
            }
           
            }
        }
    }
}
