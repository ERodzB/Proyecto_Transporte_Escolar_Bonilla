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
        int Licencia = 0;
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
            cmbGenero.ValueMember = "Codigo";
            consultar.BuscarEmpleado(busqueda.Text, txtnombre, cmbGenero, txttelefono, txtcorreo, txtdireccion, txtsalario, cmbPuesto, txtlicencia, dtpvencimiento);
                Licencia = consultar.lic;
            btnModificar.Enabled = true;

                if (Licencia == 1)
                {
                    RBLiviana.Checked = true;

                }
                if (Licencia == 2)
                {
                    RBPesada.Checked = true;

                }
                if (Licencia == 3)
                {
                    RBLiviana.Checked = true;
                    CBInter.Checked = true;

                }
                if (Licencia == 4)
                {
                    RBPesada.Checked = true;
                    CBInter.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("El empleado no existe");
            }
}

        private void CmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuesto.SelectedIndex == 0)
            {
               
                LBLLicencia.Visible = true;
                dtpvencimiento.Visible = true;
                txtlicencia.Visible = true;
                lblVencimiento.Visible = true;
                txtlicencia.Text = busqueda.Text;
                lbltipolic.Visible = true;
                GBlicencia.Visible = true;
            }
            else
            {
                LBLLicencia.Visible = false;
                dtpvencimiento.Visible = false;
                txtlicencia.Visible = false;
                lblVencimiento.Visible = false;
                lbltipolic.Visible = false;
                GBlicencia.Visible = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (RBLiviana.Checked == false && RBPesada.Checked == false)
            {
                MessageBox.Show("Error, debe seleccionar el tipo de licencia");
            }
            else
            {
                if (CBInter.Checked == true && RBLiviana.Checked == true)
                {
                    Licencia = 3;
                }
                else
                if (CBInter.Checked == true && RBPesada.Checked == true)
                {
                    Licencia = 4;
                }
                else
                if (CBInter.Checked == false && RBPesada.Checked == true)
                {
                    Licencia = 2;
                }
                else
                if (CBInter.Checked == false && RBLiviana.Checked == true)
                {
                    Licencia = 1;
                }
                modify.ModificarEmpleado(busqueda.Text, txtnombre.Text, Int32.Parse(cmbGenero.SelectedValue.ToString()), txttelefono.Text, txtcorreo.Text, txtdireccion.Text, Int32.Parse(cmbPuesto.SelectedValue.ToString()), Double.Parse(txtsalario.Text),
                       txtlicencia.Text, Convert.ToDateTime(dtpvencimiento.Value.ToString()), Licencia);
                modify.BitacoraModulo("Modificacion", 10, "Modificacion de Empleado", busqueda.Text, "N/A", "N/A", "N/A", "N/A");
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
                btnModificar.Enabled = false;
            }

           
        }
    }
}
