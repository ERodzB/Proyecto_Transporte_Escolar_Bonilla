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

        public form_nueva_ruta()
        {
            InitializeComponent();
        }

        //Carga
        private void Form_nueva_ruta_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Contrato
            combcontrato.DataSource = consul.Combobox_Contrato();
            combcontrato.DisplayMember = "Codigo_Contrato"; //Mostrara los nombres en el combobox 
            combcontrato.SelectedIndex = -1; //No muestra nada al inicio 

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

            if(combcontrato.SelectedIndex == -1)
            {
                cont++;
                error += "Contrato - ";
            }

            if( ((dtphoras1.Checked == true && dtphorae1.Checked == false) || (dtphoras1.Checked == false && dtphorae1.Checked == true)) || (dtphoras1.Checked == true && dtphorae1.Checked == true && combveh1.SelectedIndex == -1))
            {
                cont++;
                error += "Horario 1 - ";
            }

            if (((dtphoras2.Checked == true && dtphorae2.Checked == false) || (dtphoras2.Checked == false && dtphorae2.Checked == true)) || (dtphoras2.Checked == true && dtphorae2.Checked == true && combveh2.SelectedIndex == -1))
            {
                cont++;
                error += "Horario 2 - ";
            }

            if (((dtphoras3.Checked == true && dtphorae3.Checked == false) || (dtphoras3.Checked == false && dtphorae3.Checked == true)) || (dtphoras3.Checked == true && dtphorae3.Checked == true && combveh3.SelectedIndex == -1))
            {
                cont++;
                error += "Horario 3 - "; 
            }

            if (cont > 0)
                MessageBox.Show("Error en: "+error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult = MessageBox.Show("¿Datos ingresados correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(DialogResult == DialogResult.Yes)
                {
                    //Guardar Ruta con Contrato
                    ing.NuevaRuta(txtinicio.Text + txtfin.Text, txtinicio.Text + " - " + txtfin.Text, "Puntos clave desde " + txtinicio.Text + " hasta " + txtfin.Text, combcontrato.Text);

                    //Guardar Ruta con Horarios Y Vehiculos
                    if (dtphoras1.Checked)
                        ing.AsignarHoraVeh(txtinicio.Text + txtfin.Text, combveh1.Text, dtphoras1.Text, dtphorae1.Text);

                    if (dtphoras2.Checked)
                        ing.AsignarHoraVeh(txtinicio.Text + txtfin.Text, combveh2.Text, dtphoras2.Text, dtphorae2.Text);

                    if (dtphoras3.Checked)
                        ing.AsignarHoraVeh(txtinicio.Text + txtfin.Text, combveh3.Text, dtphoras3.Text, dtphorae3.Text);
                      
                    MessageBox.Show("Ruta creada con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);                  

                    //Limpieza
                    txtinicio.Clear();  
                    txtfin.Clear();

                    combcontrato.SelectedIndex = -1;
                    combveh1.SelectedIndex = -1;
                    combveh2.SelectedIndex = -1;
                    combveh3.SelectedIndex = -1;

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
    }
}
