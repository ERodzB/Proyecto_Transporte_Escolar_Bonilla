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
    public partial class frmNuevaPlaca : Form
    {
        Consultar consul = new Consultar();
        Modificar modifico = new Modificar();
        public frmNuevaPlaca()
        {
            InitializeComponent();
            combveh.DataSource = consul.Combobox_Vehiculos();
            combveh.DisplayMember = "Codigo_vehiculo";
            combveh.SelectedIndex = -1;

        }

        private void Combveh_SelectedIndexChanged(object sender, EventArgs e)
        {
            consul.DescVehiculos(combveh.Text, lab1);
            lab1.Visible = true;
        }

        private void Botasignar_Click(object sender, EventArgs e)
        {
            int cant = 0;
            if (txtNuevaMatricula.Equals(""))
            {
                MessageBox.Show("Error no ingrese datos vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cant++;
            }
            if (txtNuevaMatricula.Text.Length <= 5)
            {
                MessageBox.Show("Error Ingrese una matricula correcta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cant++;
            }
            if (combveh.SelectedIndex == -1)
            {
                MessageBox.Show("Error seleccione una matricula para actualizar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cant++;
            }
            if (cant == 0)
            {
                modifico.ActualizarMatricula(combveh.Text, txtNuevaMatricula.Text);
                combveh.SelectedIndex = -1;
                lab1.Visible = false;
                txtNuevaMatricula.Clear();
            }
        }
    }
}
