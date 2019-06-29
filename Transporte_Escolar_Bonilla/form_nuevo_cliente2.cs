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
    public partial class form_nuevo_cliente2 : Form
    {
        Estetica Estetics = new Estetica();
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();

        //Variables Globales
        int cambio1 = 0, cambio2 = 0, cambio3 = 0, cambio4 = 0; 

        public form_nuevo_cliente2()
        {
            InitializeComponent();
        }

        //Carga  
        private void Form_nuevo_cliente2_Load(object sender, EventArgs e)
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

            txtinicio1.Focus();
        }

        private void Labatras_Click(object sender, EventArgs e)
        {

        }

        private void Labatras_Click_1(object sender, EventArgs e)
        {

        }

        private void Labatras_MouseHover(object sender, EventArgs e)
        {

        }

        private void Labatras_MouseLeave(object sender, EventArgs e)
        {

        }

        //Boton Crear
        private void Botcrear_Click(object sender, EventArgs e)
        {    
            int contc = 0, conth= 0, tipoc = 0, igual=0; 
            string errorc = "", errorh= "\n\n", anio="";

            val.igual = 0; //Para validar horarios duplicados de un vehiculo 

            //Campos de Texto y TipoContrato Vacio
            if (string.IsNullOrEmpty(txtinicio1.Text) && string.IsNullOrEmpty(txtfin1.Text) && string.IsNullOrEmpty(txtini2.Text) && string.IsNullOrEmpty(txtfin2.Text))
                contc++;

            if (string.IsNullOrEmpty(txtmonto.Text) || double.Parse(txtmonto.Text) <= 0) 
                contc++;

            if ((txtinicio1.Text == "" && txtfin1.Text != "" ) || (txtinicio1.Text != "" && txtfin1.Text == ""))
                contc++;

            if ((txtini2.Text == "" && txtfin2.Text != "") || (txtini2.Text != "" && txtfin2.Text == "")) 
                contc++;

            if (combTipoContrato.SelectedIndex == -1)   
                contc++;       
              
            //DateTime f1 = dtpinicio.Value;
            //DateTime f2 = dtpfin.Value;

            //Validar Fechas
            if (dtpfin.Value < dtpinicio.Value) //|| DateTime.Compare(f1, f2) == 0) //|| this.dtpinicio.Value.CompareTo(this.dtpfin.Value) == 0)  
                contc++;      


            if (contc>0)
            {
                MessageBox.Show("Debe llenar correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //errorc += "Debe llenar correctamente los datos -"; 
            }           
            else   
            {
                //Horarios incorrectos
                if ((dtpsh1r1.Checked == true && dtpeh1r1.Checked == false) || (dtpsh1r1.Checked == false && dtpeh1r1.Checked == true) || (dtpsh1r1.Checked == true && dtpeh1r1.Checked == true && combvh1r1.SelectedIndex == -1) || (dtpsh1r1.Checked == true && dtpeh1r1.Checked == true && dtpsh1r1.Text == dtpeh1r1.Text))
                {
                    conth++;
                    errorh += "Error Horario 1/Ruta #1\n";
                }

                if ((dtpsh2r1.Checked == true && dtpeh2r1.Checked == false) || (dtpsh2r1.Checked == false && dtpeh2r1.Checked == true) || (dtpsh2r1.Checked == true && dtpeh2r1.Checked == true && combvh2r1.SelectedIndex == -1) || (dtpsh2r1.Checked == true && dtpeh2r1.Checked == true && dtpsh2r1.Text == dtpeh2r1.Text))
                {
                    conth++;
                    errorh += "Error Horario 2/Ruta #1\n"; 
                }

                if ((dtpsh1r2.Checked == true && dtpeh1r2.Checked == false) || (dtpsh1r2.Checked == false && dtpeh1r2.Checked == true) || (dtpsh1r2.Checked == true && dtpeh1r2.Checked == true && combvh1r2.SelectedIndex == -1) || (dtpsh1r2.Checked == true && dtpeh1r2.Checked == true && dtpsh1r2.Text == dtpeh1r2.Text))
                {
                    conth++;
                    errorh += "Error Horario 1/Ruta #2\n";
                }

                if ((dtpsh2r2.Checked == true && dtpeh2r2.Checked == false) || (dtpsh2r2.Checked == false && dtpeh2r2.Checked == true) || (dtpsh2r2.Checked == true && dtpeh2r2.Checked == true && combvh2r2.SelectedIndex == -1) || (dtpsh2r2.Checked == true && dtpeh2r2.Checked == true && dtpsh2r2.Text == dtpeh2r2.Text))
                {
                    conth++;
                    errorh += "Error Horario 2/Ruta #2\n";
                }

                if((txtinicio1.Text != "" && txtfin1.Text != "") && ((dtpsh1r1.Checked == false && dtpeh1r1.Checked == false) && (dtpsh2r1.Checked == false && dtpeh2r1.Checked == false)))
                {
                    conth++;
                    errorh += "Debe ingresar al menos 1 Horario de la Ruta #1\n"; 
                }

                if ((txtini2.Text != "" && txtfin2.Text != "") && ((dtpsh1r2.Checked == false && dtpeh1r2.Checked == false) && (dtpsh2r2.Checked == false && dtpeh2r2.Checked == false)))
                {
                    conth++;
                    errorh += "Debe ingresar al menos 1 Horario de la Ruta #2\n";    
                }

                //Al menos una ruta
                if ((dtpsh1r1.Checked == false && dtpeh1r1.Checked == false && combvh1r1.SelectedIndex == -1) && (dtpsh2r1.Checked == false && dtpeh2r1.Checked == false && combvh2r1.SelectedIndex == -1) && (dtpsh1r2.Checked == false && dtpeh1r2.Checked == false && combvh1r2.SelectedIndex == -1) && (dtpsh1r2.Checked == false && dtpeh2r2.Checked == false && combvh2r2.SelectedIndex == -1))
                {
                    conth++;
                    errorh += "Debe ingresar al menos 1 Ruta\n";      
                }
                

                //Horarios 1 y 2 Iguales en Rutas 
                if( (dtpsh1r1.Checked == true && dtpsh2r1.Checked == true) && (dtpsh1r1.Value.ToString() == dtpsh2r1.Value.ToString()) && (combvh1r1.Text == combvh2r1.Text))
                {
                    conth++;
                    errorh += "Horario duplicado para el Vehículo en la Ruta #1\n";
                }

                if ((dtpsh1r2.Checked == true && dtpsh2r2.Checked == true) && (dtpsh1r2.Value.ToString() == dtpsh2r2.Value.ToString()) && (combvh1r2.Text == combvh2r2.Text))
                {
                    conth++;
                    errorh += "Horario duplicado para el Vehículo en la Ruta #2\n";   
                }

                //Horarios Iguales entre Rutas 
                val.ValidarHora(dtpsh1r1, dtpsh1r2, combvh1r1, combvh1r2);  
                val.ValidarHora(dtpsh1r1, dtpsh2r2, combvh1r1, combvh2r2);
                val.ValidarHora(dtpsh2r1, dtpsh1r2, combvh2r1, combvh1r2);
                val.ValidarHora(dtpsh2r1, dtpsh2r2, combvh2r1, combvh2r2);

                if(val.igual>0)
                {
                    conth++;
                    errorh += "Horario duplicado entre rutas para el vehículo\n"; 
                }


                //Rutas Existentes
                if (val.validarRuta(txtinicio1.Text + txtfin1.Text) == 1)
                {
                    errorh += "La Ruta #1 ya existe\n";

                    txtinicio1.Clear();
                    txtfin1.Clear();
                    txtinicio1.Focus();

                    conth++;   
                }

                if (val.validarRuta(txtini2.Text + txtfin2.Text) == 1)
                {
                    errorh += "La Ruta #2 ya existe\n";

                    txtini2.Clear();
                    txtfin2.Clear();
                    txtini2.Focus(); 

                    conth++; 
                }


                //Horarios para Vehiculos ya existentes
                if(dtpsh1r1.Checked == true)
                {
                    if (val.validarHorariosVeh(combvh1r1.Text, dtpsh1r1.Text) == 1)
                    {
                        conth++; 
                        errorh += "Ruta #1 - El Vehiculo ya realiza una ruta en el Horario 1\n";
                    }
                }

                if (dtpsh2r1.Checked == true)
                {
                    if (val.validarHorariosVeh(combvh2r1.Text, dtpsh2r1.Text) == 1)
                    {
                        conth++;
                        errorh += "Ruta #1 - El Vehiculo ya realiza una ruta en el Horario 2\n";
                    }
                }

                if (dtpsh1r2.Checked == true)
                {
                    if (val.validarHorariosVeh(combvh1r2.Text, dtpsh1r2.Text) == 1)   
                    {
                        conth++;
                        errorh += "Ruta #2 - El Vehiculo ya realiza una ruta en el Horario 1\n";
                    }
                }

                if (dtpsh2r2.Checked == true)
                {
                    if (val.validarHorariosVeh(combvh2r2.Text, dtpsh2r2.Text) == 1)
                    {
                        conth++;
                        errorh += "Ruta #2 - El Vehiculo ya realiza una ruta en el Horario 2\n";
                    }
                }


                //Mostrar mensajes de Error
                if (/*contc > 0 ||*/ conth > 0)
                MessageBox.Show("Error. Ingrese correctamente toda la informacion requerida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                {

                DialogResult = MessageBox.Show("¿Datos ingresados correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult == DialogResult.Yes)
                {
                    tipoc = combTipoContrato.SelectedIndex;
                    anio = dtpinicio.Value.Year.ToString();

                    //Guardar datos de Contrato 
                    ing.NuevoContrato(anio, form_nuevo_cliente.nomc, form_nuevo_cliente.id, tipoc + 1, Convert.ToDateTime(dtpinicio.Text), double.Parse(txtmonto.Text), Convert.ToDateTime(dtpfin.Text));

                    //Guardar Ruta #1 y Horarios
                    if (txtinicio1.Text != "" && txtfin1.Text != "")
                    {
                        ing.NuevaRuta(txtinicio1.Text + txtfin1.Text, txtinicio1.Text + " - " + txtfin1.Text, "Puntos clave desde " + txtinicio1.Text + " hasta " + txtfin1.Text, " ", anio, form_nuevo_cliente.nomc, 1);

                        if (dtpsh1r1.Checked)
                            ing.AsignarHoraVeh(txtinicio1.Text + txtfin1.Text, combvh1r1.Text, dtpsh1r1.Text, dtpeh1r1.Text);

                        if (dtpsh2r1.Checked)
                            ing.AsignarHoraVeh(txtinicio1.Text + txtfin1.Text, combvh2r1.Text, dtpsh2r1.Text, dtpeh2r1.Text);
                    }

                    //Guardar Ruta #2 y Horarios
                    if (txtini2.Text != "" && txtfin2.Text != "")
                    {
                        ing.NuevaRuta(txtini2.Text + txtfin2.Text, txtini2.Text + " - " + txtfin2.Text, "Puntos clave desde " + txtini2.Text + " hasta " + txtfin2.Text, " ", anio, form_nuevo_cliente.nomc, 1);

                        if (dtpsh1r2.Checked)
                            ing.AsignarHoraVeh(txtini2.Text + txtfin2.Text, combvh1r2.Text, dtpsh1r2.Text, dtpeh1r2.Text);

                        if (dtpsh2r2.Checked)
                            ing.AsignarHoraVeh(txtini2.Text + txtfin2.Text, combvh2r2.Text, dtpsh2r2.Text, dtpeh2r2.Text);
                    }

                    MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    form_nuevo_cliente cli1 = new form_nuevo_cliente();
                    Estetics.AbrirFormularios(cli1, cliente2_panel);

                    this.Close();

                    //Limpieza  
                    //dtpsh1r1.Checked = false;
                    //dtpeh1r1.Checked = false;
                    //dtpsh2r1.Checked = false;
                    //dtpeh2r1.Checked = false; 
                    //dtpsh1r2.Checked = false;
                    //dtpeh1r2.Checked = false;
                    //dtpsh2r2.Checked = false;
                    //dtpeh2r2.Checked = false;

                    //cambio1 = 2;
                    //cambio2 = 2;
                    //cambio3 = 2;
                    //cambio4 = 2;

                    //labv1.Visible = false;
                    //labv2.Visible = false;
                    //labv3.Visible = false;
                    //labv4.Visible = false;

                    //combvh1r1.SelectedIndex = -1;
                    //combvh2r1.SelectedIndex = -1;
                    //combvh1r2.SelectedIndex = -1;
                    //combvh2r2.SelectedIndex = -1;
                    //combTipoContrato.SelectedIndex = -1;

                    ////MessageBox.Show(cambio1.ToString() + "\n" + cambio2.ToString() + "\n" + cambio3.ToString() + "\n" + cambio4.ToString(), "CAMBIOS");

                    //cambio1 = 3;
                    //cambio2 = 3;
                    //cambio3 = 3;
                    //cambio4 = 3;

                    ////MessageBox.Show(cambio1.ToString() + "\n" + cambio2.ToString() + "\n" + cambio3.ToString() + "\n" + cambio4.ToString(), "CAMBIOS");

                    //txtinicio1.Clear();
                    //txtfin1.Clear();
                    //txtini2.Clear();
                    //txtfin2.Clear(); 
                    //txtmonto.Clear();  
                }
                else
                {
                    MessageBox.Show(/*errorc +*/ errorh, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            }
        }

        //Seleccionar Vehiculo 1
        private void Combvh1r1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio se refiere a cada vez que cambia el indice del Combobox. Por cada uno su texto cambia
            cambio1++;

            //cambio 1: System.Data.DataRowView, cambio 2: PrimerDato, cambio 3: Vacio (Por el Index = -1)  
            if (cambio1>3)
            {
  //              consul.DescVehiculos(combvh1r1.Text, labv1);
                labv1.Visible = true; 
            }
        }

        private void Combvh1r1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void Txtinicio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void Txtfin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void Txtini2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void Txtfin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void Txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || (char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back))
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtmonto.Text,"^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        //Seleccionar Vehiculo 2
        private void Combvh2r1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio se refiere a cada vez que cambia el indice del Combobox. Por cada uno su texto cambia
            cambio2++;

            //cambio 1: System.Data.DataRowView, cambio 2: PrimerDato, cambio 3: Vacio (Por el Index = -1)  
            if (cambio2 > 3)
            {
    //            consul.DescVehiculos(combvh2r1.Text, labv2);
                labv2.Visible = true;  
            }
        }

        //Seleccionar Vehiculo 3
        private void Combvh1r2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio se refiere a cada vez que cambia el indice del Combobox. Por cada uno su texto cambia
            cambio3++;

            //cambio 1: System.Data.DataRowView, cambio 2: PrimerDato, cambio 3: Vacio (Por el Index = -1)  
            if (cambio3 > 3)
            {
       //         consul.DescVehiculos(combvh1r2.Text, labv3); 
                labv3.Visible = true;
            }
        }

        //Seleccionar Vehiculo 4
        private void Combvh2r2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio se refiere a cada vez que cambia el indice del Combobox. Por cada uno su texto cambia
            cambio4++;

            //cambio 1: System.Data.DataRowView, cambio 2: PrimerDato, cambio 3: Vacio (Por el Index = -1)  
            if (cambio4 > 3)
            {
     //           consul.DescVehiculos(combvh2r2.Text, labv4);
                labv4.Visible = true; 
            }
        }
    }
}
