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
    public partial class Modficar_Empleado : Form
    {
        Consultar consultar = new Consultar();
        Validar valido = new Validar();
        Modificar modify = new Modificar();

        public Modficar_Empleado()
        {
            InitializeComponent();
        }

        private void Txtcorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modficar_Empleado_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (valido.validarEmpleado(busqueda.Text) == 1)
            {
                cmbPuesto.DataSource = consultar.ComboboxPuestos();
                cmbPuesto.DisplayMember = "Nombre_Puesto";
                cmbPuesto.ValueMember = "Codigo_Puesto";
                cmbGenero.DataSource = consultar.ComboboxGeneros();
                cmbGenero.DisplayMember = "Gen";
                cmbGenero.ValueMember = "Codigo"
;               consultar.BuscarEmpleado(busqueda.Text, txtnombre, cmbGenero, txttelefono, txtcorreo, txtdireccion, txtsalario, cmbPuesto, txtlicencia, dtpvencimiento);
                txtcorreo.Enabled = true;
                txtdireccion.Enabled = true;
                txtnombre.Enabled = true;
                txtsalario.Enabled = true;
                txttelefono.Enabled = true;
                cmbGenero.Enabled = true;
                cmbPuesto.Enabled = true;
                txtlicencia.Enabled = true;
                dtpvencimiento.Enabled = true;
                button1.Enabled = true;
                busqueda.Enabled = false;
            }
            else
            {
                MessageBox.Show("El empleado no existe");
            }
}

        private void CmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuesto.SelectedIndex == 8)
            {
                LBLLicencia.Visible = true;
                dtpvencimiento.Visible = true;
                txtlicencia.Visible = true;
                lblVencimiento.Visible = true;
                txtlicencia.Text = busqueda.Text;
            }
            else
            {
                LBLLicencia.Visible = false;
                dtpvencimiento.Visible = false;
                txtlicencia.Visible = false;
                lblVencimiento.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text!="" && txttelefono.Text!="" && txtcorreo.Text!="" && txtdireccion.TextLength<15 && cmbGenero.Text!="" && cmbPuesto.Text!="" && txtsalario.Text!="")
            {
                if (cmbPuesto.SelectedIndex==8 && txtlicencia.Text!="" && dtpvencimiento.Value<=System.DateTime.Today)
                {
                    modify.ModificarEmpleado(busqueda.Text, txtnombre.Text, Int32.Parse(cmbGenero.SelectedValue.ToString()), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text), txtlicencia.Text, Convert.ToDateTime(dtpvencimiento.Value.ToString()));
                    MessageBox.Show("Modificacion Realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtcorreo.Text = "";
                    txtdireccion.Text = "";
                    txtlicencia.Text = "";
                    txtnombre.Text = "";
                    txtsalario.Text = "";
                    txttelefono.Text = "";
                    busqueda.Text = "";
                    cmbGenero.SelectedIndex = -1;
                    cmbPuesto.SelectedIndex = -1;
                    dtpvencimiento.ResetText();
                    busqueda.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese toda la información necesaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese toda la información necesaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
