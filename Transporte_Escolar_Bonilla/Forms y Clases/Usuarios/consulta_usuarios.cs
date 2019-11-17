using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class consulta_usuarios : Form
    {
        Consultar con = new Consultar();
        Estetica est = new Estetica();
        public consulta_usuarios()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (cbConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor seleccione una opcion del menu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbConsulta.SelectedItem.ToString() == "Usuarios")
                {
                    con.consultasusuario(dgvConsultaU, "Usuarios");
                }
                if (cbConsulta.SelectedItem.ToString() == "Perfiles")
                {
                    con.consultasusuario(dgvConsultaU, "Perfiles");
                }
                if (cbConsulta.SelectedItem.ToString() == "Niveles de Acceso")
                {
                    con.consultasusuario(dgvConsultaU, "Niveles de Acceso");
                }
            }


        }

        private void CbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvConsultaU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cbConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro");
            }
            else if (dgvConsultaU.Rows.Count == 0)
            {
                MessageBox.Show("No hay informacion disponible para impresion ");

            }
            else
            {
                est.imprimirTabla(dgvConsultaU, "Información de  " + cbConsulta.Text);
            }
        }
    }
}
