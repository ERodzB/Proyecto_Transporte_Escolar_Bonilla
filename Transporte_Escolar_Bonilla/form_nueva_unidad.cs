using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Transporte_Escolar_Bonilla
{
    public partial class form_nueva_unidad : Form
    {
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();
        Modificar mod = new Modificar();
        string regAsientos = @"^([1-9]{1}|[1-5]{1}[0-9]{1})$";
        string regMatricula = @"^([a-zA-Z]{2}[0-9]{4}|[a-zA-Z]{3}[0-9]{3}|[a-zA-Z]{2}[0-9]{5})$";

        public form_nueva_unidad()
        {
            InitializeComponent();

            txtmat.ShortcutsEnabled = false;
            txtmarca.ShortcutsEnabled = false;
            txtmodelo.ShortcutsEnabled = false;
            txtcolor.ShortcutsEnabled = false;
            txtcap.ShortcutsEnabled = false;
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
            dtpanioveh.MinDate = new DateTime(2000, 01, 01); //Colocar fecha minima (año, mes, dia)
            dtpanioveh.ShowUpDown = true; //para que muestre las flechitas

            dtpanioad.Format = DateTimePickerFormat.Custom;
            dtpanioad.CustomFormat = "yyyy";
            dtpanioad.MinDate = new DateTime(2000, 01, 01);
            dtpanioad.ShowUpDown = true;

            txtmat.Focus();
            dtpemision.MinDate= new DateTime(2015, 01, 01);
            dtpemision.MaxDate = new DateTime(Convert.ToInt32(DateTime.Now.Year),Convert.ToInt32(DateTime.Now.Month), Convert.ToInt32(DateTime.Now.Day));

            dtpvenc.MinDate = new DateTime(2018, 01, 01);
        }

        //Boton Crear
        private void Botcrear_Click(object sender, EventArgs e)
        {
            string errores = "";

            //Validar campos y combobox vacios vacios
            errores += val.regMatricula(txtmat.Text);
            errores += val.valTextoVacioOMaximo(txtmat.Text, "Placa");
            errores += val.valTextoVacioOMaximo(txtmarca.Text, "Marca");
            errores += val.valTextoVacioOMaximo(txtmodelo.Text, "Modelo");
            errores += val.valTextoVacioOMaximo(txtcolor.Text, "Color");
            errores += val.valCmbVacio(combtipoveh.SelectedIndex, "Tipo Vehiculo");
            errores += val.valCmbVacio(combtipotra.SelectedIndex, "Tipo de Transmision");
            errores += val.valCmbVacio(combtipocom.SelectedIndex, "Tipo de Combustible");
            errores += val.valCmbVacio(combestado.SelectedIndex, "Estado de Vehiculo");
            errores += val.valFechasIguales(dtpemision, dtpvenc);

            if (!Regex.IsMatch(txtcap.Text, regAsientos))
            {
                errores += "*Error la cantidad maxima de asientos es entre 1-59\n";
            }
            
            
            //Validar fechas de emision y vencimiento del permiso
            
            //Validar si el Vehiculo ya Existe
            if (val.validarVeh(txtmat.Text) == 1)
            {
                errores += "El Vehiculo ya fue registrado";
            }
            if (errores!="")
                MessageBox.Show("Debe llenar correctamente los datos\n"+errores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
