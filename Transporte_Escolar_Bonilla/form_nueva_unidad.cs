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
    public partial class form_nueva_unidad : Form
    {
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();
        Modificar mod = new Modificar();
        public form_nueva_unidad()
        {
            InitializeComponent();
        }

        //Carga
        private void Form_nueva_unidad_Load(object sender, EventArgs e)
        {
            //Cargar Tipo de Vehiculo
            combtipoveh.DataSource = consul.Combobox_TipoVehiculo();
            combtipoveh.DisplayMember = "Tipo";  
            combtipoveh.ValueMember = "Codigo";
            combtipoveh.SelectedIndex = -1;

            //Cargar Tipo de Transmision
            combtipotra.DataSource = consul.Combobox_TipoTrans();
            combtipotra.DisplayMember = "Transmision";
            combtipotra.ValueMember = "Codigo";
            combtipotra.SelectedIndex = -1;

            //Cargar Tipo de Combustible
            combtipocom.DataSource = consul.Combobox_TipoGas();
            combtipocom.DisplayMember = "Gasolina"; 
            combtipocom.ValueMember = "Codigo";
            combtipocom.SelectedIndex = -1;

            //Cargar Estado
            combestado.DataSource = consul.Combobox_EstadoVeh();
            combestado.DisplayMember = "Estado";
            combestado.ValueMember = "Codigo";
            combestado.SelectedIndex = -1;


            //Colocar solo años en DateTimePicker
            dtpanioveh.Format = DateTimePickerFormat.Custom;
            dtpanioveh.CustomFormat = "yyyy";
            dtpanioveh.MinDate = new DateTime(1900, 01, 01); //Colocar fecha minima (año, mes, dia)
            dtpanioveh.ShowUpDown = true; //para que muestre las flechitas

            dtpanioad.Format = DateTimePickerFormat.Custom;
            dtpanioad.CustomFormat = "yyyy";
            dtpanioad.MinDate = new DateTime(1900, 01, 01);
            dtpanioad.ShowUpDown = true;

            txtmat.Focus();
        }

        //Boton Crear
        private void Botcrear_Click(object sender, EventArgs e)
        {
            int cont = 0;

            //Validar campos y combobox vacios vacios
            if (txtmat.Text == "" || val.ValidarPlaca(txtmat.Text) == 0) //Si la placa esta vacia o mal escrita
                cont++;

            if (combtipoveh.SelectedIndex == -1)
                cont++;

            if (txtmarca.Text.Trim().Length < 3)
                cont++;

            if (txtmodelo.Text.Trim().Length < 3)
                cont++;

            if (txtcolor.Text.Trim().Length < 3)
                cont++;

            if (txtcap.Text.Trim().Length == 0 || int.Parse(txtcap.Text) <= 0) 
                cont++;

            if (combtipotra.SelectedIndex == -1)
                cont++;

            if (combtipocom.SelectedIndex == -1)
                cont++;

            if (combestado.SelectedIndex == -1)
                cont++;

            if (dtpanioveh.Value.Year > System.DateTime.Today.Year)
                cont++;

            if (dtpanioad.Value.Year > System.DateTime.Today.Year)
                cont++;

            if (dtpemision.Value > System.DateTime.Today)
                cont++;

            if (dtpvenc.Value < System.DateTime.Today)
                cont++;

            //Validar fechas de emision y vencimiento del permiso
            if (dtpvenc.Value <= dtpemision.Value)
                cont++;

            if (cont > 0)
                MessageBox.Show("Debe llenar correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Validar si el Vehiculo ya Existe
                if(val.validarVeh(txtmat.Text) == 1) 
                {
                    MessageBox.Show("El Vehiculo ya Existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmat.Clear();
                    txtmat.Focus();
                }
                else
                {
                    DialogResult = MessageBox.Show("¿Está seguro de los datos ingresados?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)
                    {
                        //Guardar datos en Vehiculos
                        ing.NuevaUnidad(txtmat.Text, int.Parse(combtipoveh.SelectedValue.ToString()), int.Parse(dtpanioveh.Text), txtmarca.Text, txtmodelo.Text,
                                        int.Parse(txtcap.Text), int.Parse(combtipotra.SelectedValue.ToString()), int.Parse(combtipocom.SelectedValue.ToString()),
                                        txtcolor.Text, int.Parse(dtpanioad.Text), int.Parse(combestado.SelectedValue.ToString()), Convert.ToDateTime(dtpemision.Text),
                                        Convert.ToDateTime(dtpvenc.Text));
                        mod.BitacoraModulo("Ingreso Vehiculo", 1, "Ingreso de Nuevo Vehiculo Adquirido", txtmat.Text, "N/A", "N/A", "N/A", "N/A");

                        MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpiar
                        txtmat.Clear();
                        txtmarca.Clear();
                        txtmodelo.Clear();
                        txtcolor.Clear();
                        txtcap.Clear();

                        combtipoveh.SelectedIndex = -1; 
                        combtipotra.SelectedIndex = -1;
                        combtipocom.SelectedIndex = -1;
                        combestado.SelectedIndex = -1;

                        txtmat.Focus();
                    }
                } 
            }
        }

        private void Txtmat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtmodelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !(e.KeyChar=='-'))
            {
                e.Handled = true;
            }
        }

        private void Txtcap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtmat_TextChanged(object sender, EventArgs e)
        {
            //COLOCAR LETRAS EN MAYUSCULA AL ESCRIBIR
            txtmat.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
