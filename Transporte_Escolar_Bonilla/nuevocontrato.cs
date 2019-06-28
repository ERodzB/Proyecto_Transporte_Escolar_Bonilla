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
    public partial class nuevocontrato : Form
    {
        Estetica Estetics = new Estetica();
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        public nuevocontrato()
        {
            InitializeComponent();
        }

        private void Botcrear_Click(object sender, EventArgs e)
        {

            //                                         SE DEBE REVISAR VALIDACION     

            int contc = 0, conth = 0, tipoc = 0;
            string errorc = "", errorh = "\n\n";

            //Campos de Texto y TipoContrato Vacio
            if (string.IsNullOrEmpty(txtinicio1.Text) && string.IsNullOrEmpty(txtfin1.Text) && string.IsNullOrEmpty(txtini2.Text) && string.IsNullOrEmpty(txtfin2.Text) && string.IsNullOrEmpty(txtnomc.Text))
                contc++;

            if (string.IsNullOrEmpty(txtmonto.Text))
                contc++;

            if ((txtinicio1.Text == "" && txtfin1.Text != "") || (txtinicio1.Text != "" && txtfin1.Text == ""))
                contc++;

            if ((txtini2.Text == "" && txtfin2.Text != "") || (txtini2.Text != "" && txtfin2.Text == ""))
                contc++;

            if (combTipoContrato.SelectedIndex == -1 && CMBDueno.SelectedIndex== -1)
                contc++;
            //else
            //    if (string.IsNullOrEmpty(txtfin1.Text)) 
            //    contc++;
            //else
            //    if (string.IsNullOrEmpty(txtini2.Text))
            //    contc++;
            //else
            //    if (string.IsNullOrEmpty(txtfin2.Text))
            //    contc++;

            if (contc > 0)
            {
                MessageBox.Show("Debe llenar correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //errorc += "Debe llenar correctamente los datos -"; 
            }
            else
            {
                //Horarios incorrectos
                if ((dtpsh1r1.Checked == true && dtpeh1r1.Checked == false) || (dtpsh1r1.Checked == false && dtpeh1r1.Checked == true) || (dtpsh1r1.Checked == true && dtpeh1r1.Checked == true && combvh1r1.SelectedIndex == -1))
                {
                    conth++;
                    errorh += "Error Horario 1/Ruta #1\n";
                }

                if ((dtpsh2r1.Checked == true && dtpeh2r1.Checked == false) || (dtpsh2r1.Checked == false && dtpeh2r1.Checked == true) || (dtpsh2r1.Checked == true && dtpeh2r1.Checked == true && combvh2r1.SelectedIndex == -1))
                {
                    conth++;
                    errorh += "Error Horario 2/Ruta #1\n";
                }

                if ((dtpsh1r2.Checked == true && dtpeh1r2.Checked == false) || (dtpsh1r2.Checked == false && dtpeh1r2.Checked == true) || (dtpsh1r2.Checked == true && dtpeh1r2.Checked == true && combvh1r2.SelectedIndex == -1))
                {
                    conth++;
                    errorh += "Error Horario 1/Ruta #2\n";
                }

                if ((dtpsh2r2.Checked == true && dtpeh2r2.Checked == false) || (dtpsh2r2.Checked == false && dtpeh2r2.Checked == true) || (dtpsh2r2.Checked == true && dtpeh2r2.Checked == true && combvh2r2.SelectedIndex == -1))
                {
                    conth++;
                    errorh += "Error Horario 2/Ruta #2\n";
                }

                //Al menos una ruta
                if ((dtpsh1r1.Checked == false && dtpeh1r1.Checked == false && combvh1r1.SelectedIndex == -1) && (dtpsh2r1.Checked == false && dtpeh2r1.Checked == false && combvh2r1.SelectedIndex == -1) && (dtpsh1r2.Checked == false && dtpeh1r2.Checked == false && combvh1r2.SelectedIndex == -1) && (dtpsh1r2.Checked == false && dtpeh2r2.Checked == false && combvh2r2.SelectedIndex == -1))
                {
                    conth++;
                    errorh += "Debe ingresar al menos 1 Horario\n";
                }

                //Mostrar mensajes de Error
                if (/*contc > 0 ||*/ conth > 0)
                    MessageBox.Show(/*errorc +*/ errorh, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DialogResult = MessageBox.Show("¿Datos ingresados correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)
                    {
                        tipoc = combTipoContrato.SelectedIndex;
                       
                        //Guardar datos de Contrato
                        string codcliente;

                        codcliente = CMBDueno.SelectedValue.ToString();
                        MessageBox.Show(codcliente, "algo", MessageBoxButtons.OK);
                            ing.NuevoContrato(txtnomc.Text, codcliente, tipoc + 1, Convert.ToDateTime(dtpinicio.Text), double.Parse(txtmonto.Text), Convert.ToDateTime(dtpfin.Text));

                        //Guardar Ruta #1 y Horarios
                        if (txtinicio1.Text != "" && txtfin1.Text != "")
                        {
                            ing.NuevaRuta(txtinicio1.Text + txtfin1.Text, txtinicio1.Text + " - " + txtfin1.Text, "Puntos clave desde " + txtinicio1.Text + " hasta " + txtfin1.Text, txtnomc.Text);

                            if (dtpsh1r1.Checked)
                                ing.AsignarHoraVeh(txtinicio1.Text + txtfin1.Text, combvh1r1.Text, dtpsh1r1.Text, dtpeh1r1.Text);

                            if (dtpsh2r1.Checked)
                                ing.AsignarHoraVeh(txtinicio1.Text + txtfin1.Text, combvh2r1.Text, dtpsh2r1.Text, dtpeh2r1.Text);

                        }

                        //Guardar Ruta #2 y Horarios
                        if (txtini2.Text != "" && txtfin2.Text != "")
                        {
                            ing.NuevaRuta(txtini2.Text + txtfin2.Text, txtini2.Text + " - " + txtfin2.Text, "Puntos clave desde " + txtini2.Text + " hasta " + txtfin2.Text, txtnomc.Text);

                            if (dtpsh1r2.Checked)
                                ing.AsignarHoraVeh(txtini2.Text + txtfin2.Text, combvh1r2.Text, dtpsh1r2.Text, dtpeh1r2.Text);

                            if (dtpsh2r2.Checked)
                                ing.AsignarHoraVeh(txtini2.Text + txtfin2.Text, combvh2r2.Text, dtpsh2r2.Text, dtpeh2r2.Text);

                        }

                        MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpieza  
                        dtpsh1r1.Checked = false;
                        dtpeh1r1.Checked = false;
                        dtpsh2r1.Checked = false;
                        dtpeh2r1.Checked = false;
                        dtpsh1r2.Checked = false;
                        dtpeh1r2.Checked = false;
                        dtpsh2r2.Checked = false;
                        dtpeh2r2.Checked = false;

                        combvh1r1.SelectedIndex = -1;
                        combvh2r1.SelectedIndex = -1;
                        combvh1r2.SelectedIndex = -1;
                        combvh2r2.SelectedIndex = -1;
                        combTipoContrato.SelectedIndex = -1;
                        CMBDueno.SelectedIndex = -1;

                        txtinicio1.Clear();
                        txtfin1.Clear();
                        txtini2.Clear();
                        txtfin2.Clear();
                        txtmonto.Clear();
                        txtnomc.Clear();
                    }

                }
            }
        }

        private void Nuevocontrato_Load(object sender, EventArgs e)
        {
            /*Colocar el formato de Hora en el DateTimePicker
            Si quiere que se muestre AM y PM tiene que ir a Panel de Control - Cambiar formatos de Fecha, Hora y Número - Configuracion adicional y poner AM Y PM*/
            dtpsh1r1.Format = DateTimePickerFormat.Custom;
            dtpsh1r1.CustomFormat = "h:mm tt";
            dtpsh1r1.ShowUpDown = true;
            dtpsh1r1.ShowCheckBox = true; //Aparece un cheque
            dtpsh1r1.Checked = false; //Deschequearlo

            dtpeh1r1.Format = DateTimePickerFormat.Custom;
            dtpeh1r1.CustomFormat = "h:mm tt";
            dtpeh1r1.ShowUpDown = true;
            dtpeh1r1.ShowCheckBox = true;
            dtpeh1r1.Checked = false;

            dtpsh2r1.Format = DateTimePickerFormat.Custom;
            dtpsh2r1.CustomFormat = "h:mm tt";
            dtpsh2r1.ShowUpDown = true;
            dtpsh2r1.ShowCheckBox = true;
            dtpsh2r1.Checked = false;

            dtpeh2r1.Format = DateTimePickerFormat.Custom;
            dtpeh2r1.CustomFormat = "h:mm tt";
            dtpeh2r1.ShowUpDown = true;
            dtpeh2r1.ShowCheckBox = true;
            dtpeh2r1.Checked = false;

            dtpsh1r2.Format = DateTimePickerFormat.Custom;
            dtpsh1r2.CustomFormat = "h:mm tt";
            dtpsh1r2.ShowUpDown = true;
            dtpsh1r2.ShowCheckBox = true;
            dtpsh1r2.Checked = false;

            dtpeh1r2.Format = DateTimePickerFormat.Custom;
            dtpeh1r2.CustomFormat = "h:mm tt";
            dtpeh1r2.ShowUpDown = true;
            dtpeh1r2.ShowCheckBox = true;
            dtpeh1r2.Checked = false;

            dtpsh2r2.Format = DateTimePickerFormat.Custom;
            dtpsh2r2.CustomFormat = "h:mm tt";
            dtpsh2r2.ShowUpDown = true;
            dtpsh2r2.ShowCheckBox = true;
            dtpsh2r2.Checked = false;

            dtpeh2r2.Format = DateTimePickerFormat.Custom;
            dtpeh2r2.CustomFormat = "h:mm tt";
            dtpeh2r2.ShowUpDown = true;
            dtpeh2r2.ShowCheckBox = true;
            dtpeh2r2.Checked = false;

            //Llenar Combobox de Vehiculos
            combvh1r1.DataSource = consul.Combobox_Vehiculos();
            combvh1r1.DisplayMember = "Codigo_vehiculo"; //Mostrara los nombres en el combobox 
            combvh1r1.SelectedIndex = -1; //No muestra nada al inicio 

            combvh2r1.DataSource = consul.Combobox_Vehiculos();
            combvh2r1.DisplayMember = "Codigo_vehiculo";
            combvh2r1.SelectedIndex = -1;

            combvh1r2.DataSource = consul.Combobox_Vehiculos();
            combvh1r2.DisplayMember = "Codigo_vehiculo";
            combvh1r2.SelectedIndex = -1;

            combvh2r2.DataSource = consul.Combobox_Vehiculos();
            combvh2r2.DisplayMember = "Codigo_vehiculo";
            combvh2r2.SelectedIndex = -1;

            //Llenar Combobox de Tipo de Contrato
            combTipoContrato.DataSource = consul.Combobox_TipoContrato();
            combTipoContrato.DisplayMember = "Tipo_Contrato";
            combTipoContrato.SelectedIndex = -1;

            CMBDueno.DataSource = consul.combox_Clientes();
            CMBDueno.DisplayMember = "Nombre_Cliente";
            CMBDueno.ValueMember = "Codigo_Cliente";
            CMBDueno.SelectedIndex = -1;
            txtinicio1.Focus();
        }

        private void Dtpinicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
