using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class Consultar_empleados : Form
    {
        Estetica est = new Estetica();
        Consultar con = new Consultar();
        public Consultar_empleados()
        {
            InitializeComponent();
        }

        private void Consultar_empleados_Load(object sender, EventArgs e)
        {
            con.cargardvgempleado(dgvConsultaU);
            cmbpuesto.DataSource = con.ComboboxPuestos();
            cmbpuesto.DisplayMember = "Nombre_Puesto";
            cmbpuesto.ValueMember = "Codigo_Puesto";
            cmbpuesto.SelectedIndex = 0;
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            con.filtrarempleado(dgvConsultaU, int.Parse(cmbpuesto.SelectedValue.ToString()));
            cmbpuesto.SelectedIndex = int.Parse(cmbpuesto.SelectedValue.ToString()) - 1;
            cmbpuesto.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cmbpuesto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un filtro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dgvConsultaU.Rows.Count == 0)
            {
                MessageBox.Show("No hay información disponible para impresión", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                est.imprimirTabla(dgvConsultaU, "Información de Empleados en el " + cmbpuesto.Text);
            }
        }
    }
}
