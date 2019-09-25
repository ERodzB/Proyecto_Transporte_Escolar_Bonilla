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
    public partial class form_nueva_ruta : Form
    {
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();
        Modificar modifico = new Modificar();
        int cant = 0;

        //Variables Globales
        int cambio1 = 0;

        public form_nueva_ruta()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Dtphoras1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Txtinicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtfin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Carga
        private void Form_nueva_ruta_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Vehiculos
            combveh1.DataSource = consul.Combobox_Vehiculos();
            combveh1.DisplayMember = "Codigo_vehiculo";
            combveh1.SelectedIndex = -1;

            /*Colocar el formato de Hora en el DateTimePicker
            Si quiere que se muestre AM y PM tiene que ir a Panel de Control - Cambiar formatos de Fecha, Hora y Número - Configuracion adicional y poner AM Y PM*/
            dtphoras1.Format = DateTimePickerFormat.Custom;
            dtphoras1.CustomFormat = "h:mm tt";
            dtphoras1.ShowUpDown = true;
            dtphoras1.ShowCheckBox = true; //Aparece un cheque
            dtphoras1.Checked = false; //Deschequearlo

            dtphorae1.Format = DateTimePickerFormat.Custom;
            dtphorae1.CustomFormat = "h:mm tt";
            dtphorae1.ShowUpDown = true;
            dtphorae1.ShowCheckBox = true;
            dtphorae1.Checked = false;


            txtinicio.Focus();
        }

        //Boton Crear
        private void Botcrear_Click(object sender, EventArgs e)
        {
            int cont = 0;
            string error = " ";

            val.igual = 0;

            //Validar datos vacios
            if (txtinicio.Text == "")
            {
                cont++;
                error += "Inicio - ";
            }

            if (txtfin.Text == "")
            {
                cont++;
                error += "Fin - ";
            }

            //Validar Horarios
            if (((dtphoras1.Checked == true && dtphorae1.Checked == false) || (dtphoras1.Checked == false && dtphorae1.Checked == true)) || (dtphoras1.Checked == true && dtphorae1.Checked == true && combveh1.SelectedIndex == -1) || (dtphoras1.Checked == true && dtphorae1.Checked == true && dtphoras1.Text == dtphorae1.Text))
            {
                cont++;
                error += "Horario 1 - ";
            }

            //Al menos un Horario
            if ((dtphoras1.Checked == false && dtphorae1.Checked == false && combveh1.SelectedIndex == -1))
            {
                cont++;
                error += "Debe ingresar al menos 1 Horario\n";
            }

            if ((dtphoras1.Checked == false || dtphorae1.Checked == false || combveh1.SelectedIndex == -1))
            {
                cont++;
                error += "No deje elementos sin ingresar\n";
            }


            //Ruta Existente
            if (val.validarRuta(txtinicio.Text + txtfin.Text) == 1)
            {
                error += "La Ruta ya existe\n";

                txtinicio.Clear();
                txtfin.Clear();
                txtinicio.Focus();

                cont++;
            }


            //Horarios para Vehiculos ya existentes
            if (dtphoras1.Checked == true)
            {
                if (val.validarHorariosVeh(combveh1.Text, dtphoras1.Text) == 1)
                {
                    cont++;
                    error += "El Vehiculo ya realiza una ruta en el Horario 1\n";
                }
            }

            if (cont > 0)
                MessageBox.Show("ERROR EN: " + error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = MessageBox.Show("¿Datos ingresados correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult == DialogResult.Yes)
                {
                    //Guardar Ruta con Contrato
                    ing.NuevaRuta(txtinicio.Text +"-"+ txtfin.Text, txtinicio.Text + " - " + txtfin.Text, "Ruta desde " + txtinicio.Text + " hasta " + txtfin.Text, "Temporal");

                    //Guardar Ruta con Horarios Y Vehiculos 
                    if (dtphoras1.Checked)
                        ing.AsignarHoraVeh(txtinicio.Text + "-" + txtfin.Text, combveh1.Text, dtphoras1.Text, dtphorae1.Text, 0);

                    MessageBox.Show("Ruta creada con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    modifico.BitacoraModulo("Creación", 4, "Creación de una Ruta", txtinicio.Text + "-" + txtfin.Text, combveh1.Text, "N/A", "N/A", "N/A");
                   
                    if(cant == 0)
                    {
                        if (MessageBox.Show("¿Desea crear la ruta de regreso?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            String txtini = txtinicio.Text;

                            txtinicio.Text = txtfin.Text;
                            txtfin.Text = txtini;
                            dtphorae1.Checked = false;
                            dtphoras1.Checked = false;
                            
                            cant = 1;
                        }
                    }                   
                    else
                    {
                        txtinicio.Clear();
                        txtfin.Clear();

                        cambio1 = 2;

                        labv1.Visible = false;

                        combveh1.SelectedIndex = -1;


                        cambio1 = 3;

                        dtphoras1.Checked = false;
                        dtphorae1.Checked = false;

                        txtinicio.Focus();
                    }
                    //Limpieza
                    
                }
            }
        }

        //Seleccionar Vehiculo 1
        private void Combveh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio se refiere a cada vez que cambia el indice del Combobox. Por cada uno su texto cambia
            cambio1++;

            //cambio 1: System.Data.DataRowView, cambio 2: PrimerDato, cambio 3: Vacio (Por el Index = -1)  
            if (cambio1 > 3)
            {
                consul.DescVehiculos(combveh1.Text, labv1);
                labv1.Visible = true;
            }
        }
    }
 }
