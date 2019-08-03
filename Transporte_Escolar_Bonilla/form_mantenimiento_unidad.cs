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
    public partial class form_mantenimiento_unidad : Form
    {
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Modificar mod = new Modificar();

        public form_mantenimiento_unidad()
        {
            InitializeComponent();
        }

        //Carga
        private void Form_mantenimiento_unidad_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Vehiculos
            combveh.DataSource = consul.Combobox_Vehiculos();
            combveh.DisplayMember = "Codigo_vehiculo";
            combveh.SelectedIndex = -1;

            //Llenar Combobox de Tipo de Mantenimiento
            combtipo.DataSource = consul.Combobox_TipoMant();
            combtipo.DisplayMember = "Mantenimiento";
            combtipo.ValueMember = "Codigo";
            combtipo.SelectedIndex = -1;

            //Llenar Combobox de Estado de Mantenimiento
            combestado.DataSource = consul.Combobox_EstadoMant();
            combestado.DisplayMember = "Estado";
            combestado.ValueMember = "Codigo";
            combestado.SelectedIndex = -1;
        }

        //Elige un Vehiculo
        private void Combveh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se muestra descripcion en el lab
            consul.DescVehiculos(combveh.Text, lab1);
            lab1.Visible = true;
        }

        //Boton Ingresar
        private void Botingresar_Click(object sender, EventArgs e)
        {
            int cont = 0;

            //Validar campos vacios
            if (combveh.SelectedIndex == -1)
                cont++;

            if (combtipo.SelectedIndex == -1)
                cont++;

            if (txtcosto.Text == " " || double.Parse(txtcosto.Text) <= 0)
                cont++; 

            if (combestado.SelectedIndex == -1)
                cont++;

            if (dtpfecha.Value < System.DateTime.Today)
                cont++;

            if (cont > 0)
                MessageBox.Show("Debe llenar correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = MessageBox.Show("¿Está seguro de los datos ingresados?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(DialogResult == DialogResult.Yes)
                {
                    //Guardar mantenimiento
                    ing.NuevoMantenimiento(int.Parse(combtipo.SelectedValue.ToString()), dtpfecha.Value, combveh.Text, double.Parse(txtcosto.Text), 
                                           int.Parse(combestado.SelectedValue.ToString()));
                    mod.BitacoraModulo("Mantenimiento", 1, "Mantenimiento a un Vehiculo", combveh.Text, "N/A", "N/A", "N/A", "N/A");

                    //Cambiar estado del vehiculo a "En Mantenimiento"
                    mod.ModificarEstadoVeh(combveh.Text);

                    MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                    //Limpiar
                    lab1.Visible = false;

                    txtcosto.Clear();

                    combveh.SelectedIndex = -1;
                    combtipo.SelectedIndex = -1;
                    combestado.SelectedIndex = -1;
                }
            }
        }

        private void Txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtcosto.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
    }
}
