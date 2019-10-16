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
        Validar val = new Validar();
        string regMatricula = @"^([a-zA-Z]{3}[0-9]{4}|[a-zA-Z]{3}[0-9]{3})$";
        string regTexto = @"^[a-zA-Z]{4}[a-zA-Z 0-9]*$";
        string regLimMaximo = @"^[\w ]{0,50}$";
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
            errores+= val.regMatricula(txtNuevaMatricula.Text, regMatricula);
            errores += val.valTextoVacioOMaximo(txtNuevaMatricula.Text,"Placa", regTexto, regLimMaximo);
            errores += val.valCmbVacio(combveh.SelectedIndex, "Vehiculo");
            if (errores != "")
            {
                MessageBox.Show("Debe llenar correctamente los datos\n" + errores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TxtNuevaMatricula_TextChanged(object sender, EventArgs e)
        {
            //COLOCAR LETRAS EN MAYUSCULA AL ESCRIBIR
            txtNuevaMatricula.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
