using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class consultar_rutas : Form
    {
        Consultar con = new Consultar();
        public consultar_rutas()
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
                if (cbConsulta.SelectedItem.ToString() == "Rutas Generales")
                {
                    con.consultarutas(dgvConsultaU, "Rutas Generales");
                }
                if (cbConsulta.SelectedItem.ToString() == "Rutas de Clientes")
                {
                    con.consultarutas(dgvConsultaU, "Rutas de Clientes");
                }
                if (cbConsulta.SelectedItem.ToString() == "Rutas Viajes Privados")
                {
                    con.consultarutas(dgvConsultaU, "Rutas Viajes Privados");
                }

            }
        }
    }
}
