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

        //Variables Globales
        int cambio1 = 0, cambio2 = 0, cambio3 = 0, cambio4 = 0;

        public form_nueva_ruta()
        {
            InitializeComponent();
        }

        //Carga
        private void Form_nueva_ruta_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Vehiculos
            combveh1.DataSource = consul.Combobox_Vehiculos();
            combveh1.DisplayMember = "Codigo_vehiculo";
            combveh1.SelectedIndex = -1;

            combveh2.DataSource = consul.Combobox_Vehiculos();
            combveh2.DisplayMember = "Codigo_vehiculo";
            combveh2.SelectedIndex = -1;

            combveh3.DataSource = consul.Combobox_Vehiculos();  
            combveh3.DisplayMember = "Codigo_vehiculo";
            combveh3.SelectedIndex = -1;

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

            dtphoras2.Format = DateTimePickerFormat.Custom;
            dtphoras2.CustomFormat = "h:mm tt";
            dtphoras2.ShowUpDown = true;
            dtphoras2.ShowCheckBox = true;
            dtphoras2.Checked = false;

            dtphorae2.Format = DateTimePickerFormat.Custom;
            dtphorae2.CustomFormat = "h:mm tt";
            dtphorae2.ShowUpDown = true;
            dtphorae2.ShowCheckBox = true;
            dtphorae2.Checked = false;

            dtphoras3.Format = DateTimePickerFormat.Custom;
            dtphoras3.CustomFormat = "h:mm tt";
            dtphoras3.ShowUpDown = true;
            dtphoras3.ShowCheckBox = true;
            dtphoras3.Checked = false;

            dtphorae3.Format = DateTimePickerFormat.Custom;
            dtphorae3.CustomFormat = "h:mm tt";
            dtphorae3.ShowUpDown = true;
            dtphorae3.ShowCheckBox = true;
            dtphorae3.Checked = false;

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

            if(txtfin.Text == "")
            {
                cont++;
                error += "Fin - "; 
            }

            //Validar Horarios
            if( ((dtphoras1.Checked == true && dtphorae1.Checked == false) || (dtphoras1.Checked == false && dtphorae1.Checked == true)) || (dtphoras1.Checked == true && dtphorae1.Checked == true && combveh1.SelectedIndex == -1) || (dtphoras1.Checked == true && dtphorae1.Checked == true && dtphoras1.Text == dtphorae1.Text))
            {
                cont++;
                error += "Horario 1 - ";
            }

            if (((dtphoras2.Checked == true && dtphorae2.Checked == false) || (dtphoras2.Checked == false && dtphorae2.Checked == true)) || (dtphoras2.Checked == true && dtphorae2.Checked == true && combveh2.SelectedIndex == -1) || (dtphoras2.Checked == true && dtphorae2.Checked == true && dtphoras2.Text == dtphorae2.Text))
            {
                cont++;
                error += "Horario 2 - ";
            }

            if (((dtphoras3.Checked == true && dtphorae3.Checked == false) || (dtphoras3.Checked == false && dtphorae3.Checked == true)) || (dtphoras3.Checked == true && dtphorae3.Checked == true && combveh3.SelectedIndex == -1) || (dtphoras3.Checked == true && dtphorae3.Checked == true && dtphoras3.Text == dtphorae3.Text))
            {
                cont++;
                error += "Horario 3 - ";   
            }


            //Al menos un Horario
            if ((dtphoras1.Checked == false && dtphorae1.Checked == false && combveh1.SelectedIndex == -1) && (dtphoras2.Checked == false && dtphorae2.Checked == false && combveh2.SelectedIndex == -1) && (dtphoras3.Checked == false && dtphorae3.Checked == false && combveh3.SelectedIndex == -1))
            {
                cont++; 
                error += "Debe ingresar al menos 1 Horario\n";
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


            //Horarios Iguales para el vehiculo 
            val.ValidarHora(dtphoras1, dtphoras2, combveh1, combveh2);
            val.ValidarHora(dtphoras1, dtphoras3, combveh1, combveh3);
            val.ValidarHora(dtphoras2, dtphoras3, combveh2, combveh3);     

            if(val.igual > 0)
            {
                cont++;
                error += "Horario duplicado para el Vehículo\n";
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

            if (dtphoras2.Checked == true)
            {
                if (val.validarHorariosVeh(combveh2.Text, dtphoras2.Text) == 1)
                {
                    cont++;
                    error += "El Vehiculo ya realiza una ruta en el Horario 2\n";
                }
            }

            if (dtphoras3.Checked == true)
            {
                if (val.validarHorariosVeh(combveh3.Text, dtphoras3.Text) == 1)
                {
                    cont++;
                    error += "El Vehiculo ya realiza una ruta en el Horario 3\n";
                }
            }


            if (cont > 0)
                MessageBox.Show("ERROR EN: "+error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = MessageBox.Show("¿Datos ingresados correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(DialogResult == DialogResult.Yes)
                {
                    //Guardar Ruta con Contrato
                    ing.NuevaRuta(txtinicio.Text + txtfin.Text, txtinicio.Text + " - " + txtfin.Text, "Ruta desde " + txtinicio.Text + " hasta " + txtfin.Text, "Temporal");

                    //Guardar Ruta con Horarios Y Vehiculos 
                    if (dtphoras1.Checked)
                        ing.AsignarHoraVeh(txtinicio.Text + txtfin.Text, combveh1.Text, dtphoras1.Text, dtphorae1.Text, 0);

                    if (dtphoras2.Checked)
                        ing.AsignarHoraVeh(txtinicio.Text + txtfin.Text, combveh2.Text, dtphoras2.Text, dtphorae2.Text, 0);

                    if (dtphoras3.Checked)
                        ing.AsignarHoraVeh(txtinicio.Text + txtfin.Text, combveh3.Text, dtphoras3.Text, dtphorae3.Text, 0); 

                    MessageBox.Show("Ruta creada con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);                    

                    //Limpieza
                    txtinicio.Clear();  
                    txtfin.Clear();

                    cambio1 = 2;
                    cambio2 = 2;
                    cambio3 = 2;
                    cambio4 = 2;

                    labv1.Visible = false;
                    labv2.Visible = false;
                    labv3.Visible = false;

                    combveh1.SelectedIndex = -1;
                    combveh2.SelectedIndex = -1;
                    combveh3.SelectedIndex = -1;

                    cambio1 = 3;
                    cambio2 = 3;
                    cambio3 = 3;
                    cambio4 = 3;

                    dtphoras1.Checked = false;
                    dtphorae1.Checked = false;
                    dtphoras2.Checked = false;
                    dtphorae2.Checked = false;
                    dtphoras3.Checked = false;
                    dtphorae3.Checked = false;

                    txtinicio.Focus(); 
                }
            }
        }

        private void Combcontrato_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        //Seleccionar vehiculo 2
        private void Combveh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio se refiere a cada vez que cambia el indice del Combobox. Por cada uno su texto cambia
            cambio2++;

            //cambio 1: System.Data.DataRowView, cambio 2: PrimerDato, cambio 3: Vacio (Por el Index = -1)  
            if (cambio2 > 3)
            {
                consul.DescVehiculos(combveh2.Text, labv2);
                labv2.Visible = true;
            }
        }

        //Seleccionar Vehiculo 3
        private void Combveh3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio se refiere a cada vez que cambia el indice del Combobox. Por cada uno su texto cambia
            cambio3++;

            //cambio 1: System.Data.DataRowView, cambio 2: PrimerDato, cambio 3: Vacio (Por el Index = -1)  
            if (cambio3 > 3)
            {
                consul.DescVehiculos(combveh3.Text, labv3);
                labv3.Visible = true;
            }
        }
    }
}
