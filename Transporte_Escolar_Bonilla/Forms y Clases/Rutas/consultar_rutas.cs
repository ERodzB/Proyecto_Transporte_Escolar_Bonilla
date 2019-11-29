using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class consultar_rutas : Form
    {
        Estetica est = new Estetica();
        Consultar con = new Consultar();
        public consultar_rutas()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (cbConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una opción del menu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cbConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgvConsultaU.Rows.Count == 0)
            {
                MessageBox.Show("No hay información disponible para impresión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                est.imprimirTabla(dgvConsultaU, "Información de " + cbConsulta.Text);
            }
        }
    }
}
