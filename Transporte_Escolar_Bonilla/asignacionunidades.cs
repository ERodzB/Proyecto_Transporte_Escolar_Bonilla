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
    public partial class asignacionunidades : Form
    {
        Consultar con = new Consultar();
        Modificar modify = new Modificar();
        public int Tipo;
        public asignacionunidades(int tipo)
        {
            InitializeComponent();
            Tipo = tipo;
    
        }

        private void Asignacionunidades_Load(object sender, EventArgs e)
        {
            cmbempleado.DataSource = con.Combobox_Empleados();
            cmbempleado.DisplayMember = "Nombre";
            cmbempleado.ValueMember = "Codigo";
            cmbempleado.SelectedIndex = -1;
            cmbestado.DataSource = con.ComboboxEVehiculos();
            cmbestado.DisplayMember = "Estado";
            cmbestado.ValueMember = "Codigo";
            cmbestado.SelectedIndex = -1;
            
            if(Tipo==1)
            {
                btnAsignar.Visible = true;
                btnDevolver.Visible = false;
                con.dvgdatosasignar(dgvConsultaU);
                lblestado.Visible = false;
                cmbestado.Visible = false;
            }
            if(Tipo==2)
            {
                btnAsignar.Visible = false;
                btnDevolver.Visible = true;
                con.dvgdatosdevolver(dgvConsultaU);
                cmbempleado.Enabled = false;
                lblasignado.Text = "Actualmente asignado a: ";
                lblestado.Text = "Estado en que se devuelve: ";
      
            }
        }

        private void BtnAsignar_Click(object sender, EventArgs e)
        {
            modify.ModificarVAsigDevol(Tipo, cmbempleado.SelectedValue.ToString(), txtPlaca.Text,702);
            modify.BitacoraModulo("Asignacion", 8, "Asignacion de Vehiculo a Empleado", txtPlaca.Text, cmbempleado.SelectedValue.ToString(),txtObservaciones.Text, "N/A", "N/A");
            MessageBox.Show("La unidad a sido asignada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.dvgdatosasignar(dgvConsultaU);
            txtPlaca.Text = "";
            txtDescripcion.Text = "";
            txtObservaciones.Text = "Ninguna";
            cmbempleado.SelectedIndex = -1;
        }

        private void BtnDevolver_Click(object sender, EventArgs e)
        {
            modify.ModificarVAsigDevol(Tipo, cmbempleado.Text, txtPlaca.Text,int.Parse(cmbestado.SelectedValue.ToString()));
            modify.BitacoraModulo("Devolucion", 9, "Devolucion de Vehiculo por Empelado", txtPlaca.Text, cmbempleado.SelectedValue.ToString(), txtObservaciones.Text, "N/A", "N/A");
            MessageBox.Show("La unidad a sido entregada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.dvgdatosdevolver(dgvConsultaU);
            txtPlaca.Text = "";
            txtDescripcion.Text = "";
            txtObservaciones.Text = "Ninguna";
            cmbestado.SelectedIndex = -1;
            cmbempleado.SelectedIndex = -1;
        }

        private void DgvConsultaU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void DgvConsultaU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlaca.Text = dgvConsultaU.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgvConsultaU.CurrentRow.Cells[1].Value.ToString();
            cmbempleado.Text = dgvConsultaU.CurrentRow.Cells[3].Value.ToString();
        }

        private void TxtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
