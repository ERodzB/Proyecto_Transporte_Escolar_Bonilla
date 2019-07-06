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
    public partial class nuevoempleado : Form
    {
        Consultar consultar = new Consultar();
        public nuevoempleado()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            Validar validar = new Validar();

            ingresar.NuevoEmpleado(txtidentidad.Text, txtnombre.Text, Convert.ToDateTime(dateTimePicker1.Text), cmbGenero.SelectedItem.ToString(), txttelefono.Text, txtcorreo.Text, txtdireccion.Text,Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text));
            MessageBox.Show("Empleado Guardado con Exito", "Guardado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtcorreo.Text = "";
            txtdireccion.Text = "";
            txtidentidad.Text = "";
            txtnombre.Text = "";
            txtsalario.Text = "";
            txttelefono.Text = "";
            cmbGenero.SelectedIndex = -1;
            cmbPuesto.SelectedIndex = -1;
            dateTimePicker1.ResetText();
        }

        private void Nuevoempleado_Load(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = consultar.ComboboxPuestos();
            cmbPuesto.DisplayMember = "Nombre_Puesto";
            cmbPuesto.ValueMember = "Codigo_Puesto";
            cmbPuesto.SelectedIndex = -1;
        }
    }
}
