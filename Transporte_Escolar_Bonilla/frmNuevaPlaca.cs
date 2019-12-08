using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class frmNuevaPlaca : Form
    {
        Consultar consul = new Consultar();
        Modificar modifico = new Modificar();
        Validar val = new Validar();
        public frmNuevaPlaca()
        {
            InitializeComponent();

            combveh.DataSource = consul.Combobox_Vehiculos();
            combveh.DisplayMember = "Codigo_vehiculo";
            combveh.SelectedIndex = -1;

            txtNuevaMatricula.Focus();

            txtNuevaMatricula.ShortcutsEnabled = false;

        }

        private void Combveh_SelectedIndexChanged(object sender, EventArgs e)
        {
            consul.DescVehiculos(combveh.Text, lab1);
            lab1.Visible = true;
        }

        private void Botasignar_Click(object sender, EventArgs e)
        {
            string errores = "";
            errores += val.regMatricula(txtNuevaMatricula.Text);
            errores += val.valTextoVacioOMaximo(txtNuevaMatricula.Text, "Placa");
            errores += val.valCmbVacio(combveh.SelectedIndex, "Vehiculo");
            if (errores != "")
            {
                MessageBox.Show("Debe llenar correctamente los datos\n" + errores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(combveh.Text.Equals(txtNuevaMatricula.Text))
                {
                    MessageBox.Show("Debe ingresar una Nueva Placa para el Vehículo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNuevaMatricula.Clear();
                    txtNuevaMatricula.Focus();
                }
                else
                {
                    modifico.ActualizarMatricula(combveh.Text, txtNuevaMatricula.Text);

                    combveh.DataSource = consul.Combobox_Vehiculos();
                    combveh.DisplayMember = "Codigo_vehiculo";
                    combveh.SelectedIndex = -1;

                    lab1.Visible = false;
                    txtNuevaMatricula.Clear();
                }

            }
        }

        private void TxtNuevaMatricula_TextChanged(object sender, EventArgs e)
        {
            //COLOCAR LETRAS EN MAYUSCULA AL ESCRIBIR
            txtNuevaMatricula.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
