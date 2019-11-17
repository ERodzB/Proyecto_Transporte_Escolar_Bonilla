using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Transporte_Escolar_Bonilla
{
    public partial class nuevoviaje : Form
    {
        Estetica Estetics = new Estetica();
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();

        //Variables Globales
        int cambio1 = 0, cambio2 = 0;

        public nuevoviaje()
        {
            InitializeComponent();

            txtpa.ShortcutsEnabled = false;
            txtorigen.ShortcutsEnabled = false;
            txtdestino.ShortcutsEnabled = false;
            txttotal.ShortcutsEnabled = false;
            txtant.ShortcutsEnabled = false;
        }

        //Carga
        private void Nuevoviaje_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Vehiculos
            combveh1.DataSource = consul.Combobox_Vehiculos();
            combveh1.DisplayMember = "Codigo_vehiculo";
            combveh1.SelectedIndex = -1;

            combveh2.DataSource = consul.Combobox_Vehiculos();
            combveh2.DisplayMember = "Codigo_vehiculo";
            combveh2.SelectedIndex = -1;

            //Llenar ComboBox Clientes
            combcliente.DataSource = consul.combox_Clientes();
            combcliente.DisplayMember = "Nombre_Cliente";
            combcliente.ValueMember = "Codigo_Cliente";
            combcliente.SelectedIndex = -1;

            /*Colocar el formato de Hora en el DateTimePicker
            Si quiere que se muestre AM y PM tiene que ir a Panel de Control - Cambiar formatos de Fecha, Hora y Número - Configuracion adicional y poner AM Y PM*/
            dtphoras1.Format = DateTimePickerFormat.Custom;
            dtphoras1.CustomFormat = "HH:mm";
            dtphoras1.ShowUpDown = true;
            dtphoras1.ShowCheckBox = true; //Aparece un cheque
            dtphoras1.Checked = false; //Deschequearlo

            dtphorae1.Format = DateTimePickerFormat.Custom;
            dtphorae1.CustomFormat = "HH:mm";
            dtphorae1.ShowUpDown = true;
            dtphorae1.ShowCheckBox = true;
            dtphorae1.Checked = false;

            dtphoras2.Format = DateTimePickerFormat.Custom;
            dtphoras2.CustomFormat = "HH:mm";
            dtphoras2.ShowUpDown = true;
            dtphoras2.ShowCheckBox = true;
            dtphoras2.Checked = false;

            dtphorae2.Format = DateTimePickerFormat.Custom;
            dtphorae2.CustomFormat = "HH:mm";
            dtphorae2.ShowUpDown = true;
            dtphorae2.ShowCheckBox = true;
            dtphorae2.Checked = false;
        }

        //Servicio
        private void Combservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ida y Vuelta
            if (combservicio.SelectedIndex == 1)
            {
                dtphoras2.Enabled = true;
                dtphorae2.Enabled = true;
                combveh2.Enabled = true;
            }
            else
            {
                dtphoras2.Enabled = false;
                dtphorae2.Enabled = false;
                combveh2.Enabled = false;
                labv2.Visible = false;

                dtphoras2.Checked = false;
                dtphorae2.Checked = false;

                combveh2.SelectedIndex = -1;
            }
        }

        //Vehiculo 1
        private void Combveh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cambio se refiere a cada vez que cambia el indice del Combobox. Por cada uno su texto cambia
            cambio1++;

            //cambio 1: System.Data.DataRowView, cambio 2: PrimerDato, cambio 3: Vacio (Por el Index = -1)  
            if (cambio1 > 3)
            {
                consul.DescVehiculos(combveh1.Text, labv1);
                labv1.Visible = true;
                if(combservicio.SelectedIndex==1)
                    combveh2.SelectedIndex = combveh1.SelectedIndex;
            }
        }

        //Vehiculo 2
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

        private void Txtpa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtorigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Que no deje espacios en blanco al inicio
            if (char.IsWhiteSpace(e.KeyChar) && txtorigen.Text.Trim().Length == 0)
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtdestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Que no deje espacios en blanco al inicio
            if (char.IsWhiteSpace(e.KeyChar) && txtdestino.Text.Trim().Length == 0)
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txttotal.Text,"^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
    

        private void Txtant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtant.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
    

        //Crear
        private void Botcrear_Click(object sender, EventArgs e)
        {
            double ant = 0;
            int contc = 0, conth = 0;
            string errorc="", error = "", anio = "", codcli="";

            val.igual = 0;

            //Validar Campos
            if (combservicio.SelectedIndex == -1)
            {
                errorc += "Seleccione un Servicio\n";
                contc++;
            }        

            if (combcliente.SelectedIndex == -1)
            {
                errorc += "Seleccione un Cliente\n";
                contc++;
            }

            if (txtorigen.Text.Trim().Length < 3 || txtorigen.Text.All(x => char.IsNumber(x)))
            {
                errorc += "Ingrese un Origen válido de 3 caracteres mínimo\n";
                contc++;
            }

            if (txtdestino.Text.Trim().Length < 3 || txtdestino.Text.All(x => char.IsNumber(x)))
            {
                errorc += "Ingrese un Destino válido de 3 caracteres mínimo\n";
                contc++;
            }

            if (txtpa.Text.Trim().Length == 0 || (int.Parse(txtpa.Text) <= 0 || int.Parse(txtpa.Text) > 59))
            {
                errorc += "Ingrese un número de pasajeros entre 1 y 59\n";
                contc++;
            }

            //Validar Fechas 
            if (dtpfin.Value < dtpinicio.Value)
            {
                errorc += "El viaje no puede iniciar despues de que haya finalizado\n";
                contc++;
            }
            
            //Validar anticipo no mayor que monto total
            if((txtant.Text.Trim().Length == 0 || double.Parse(txtant.Text) <= 0) || (txttotal.Text.Trim().Length == 0 || double.Parse(txttotal.Text) <= 0) || double.Parse(txtant.Text) > double.Parse(txttotal.Text))
            {
                errorc += "El Anticipo y El Total deben ser mayor que 0. El Anticipo no puede ser mayor al Total a Pagar\n";
                contc++;
            }

            if (contc > 0)
                MessageBox.Show("Debe llenar correctamente los datos: \n\n"+ errorc, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {

                if ((dtphoras1.Checked == true && dtphorae1.Checked == false) || (dtphoras1.Checked == false && dtphorae1.Checked == true) || (dtphoras1.Checked == true && dtphorae1.Checked == true && combveh1.SelectedIndex == -1) || (dtphoras1.Checked == true && dtphorae1.Checked == true && dtphoras1.Text == dtphorae1.Text))
                    conth++;

                //Todos Vacios
                if (dtphoras1.Checked == false && dtphorae1.Checked == false && combveh1.SelectedIndex == -1)
                    conth++;


                //Ida y Venida
                if (combservicio.SelectedIndex == 1)
                {
                    //Algunos Vacios
                    if ((dtphoras2.Checked == true && dtphorae2.Checked == false) || (dtphoras2.Checked == false && dtphorae2.Checked == true) || (dtphoras2.Checked == true && dtphorae2.Checked == true && combveh2.SelectedIndex == -1) || (dtphoras2.Checked == true && dtphorae2.Checked == true && dtphoras2.Text == dtphorae2.Text))
                        conth++;

                    //Todos Vacios
                    if (dtphoras2.Checked == false && dtphorae2.Checked == false && combveh2.SelectedIndex == -1)
                        conth++;

                    //Al menos un Horario
                    if ((dtphoras1.Checked == false && dtphorae1.Checked == false && combveh1.SelectedIndex == -1) && (dtphoras2.Checked == false && dtphorae2.Checked == false && combveh2.SelectedIndex == -1))
                        conth++;
                }


                //Horarios Iguales para el vehiculo 
                val.ValidarHora(dtphoras1, dtphoras2, combveh1, combveh2);

                if (val.igual > 0)
                {
                    conth++;
                    error += "Horario duplicado para el Vehículo\n";
                }


                //Horarios para Vehiculos ya existentes
                if (dtphoras1.Checked == true)
                {
                    if (val.validarHorariosVeh(combveh1.Text, dtphoras1.Text) == 1)
                    {
                        conth++;
                        error += "El Vehiculo ya realiza una ruta en el Horario de Ida\n";
                    }

                    //Capacidad excedida
                    if (val.validarCap(combveh1.Text, int.Parse(txtpa.Text)) == 1)
                    {
                        conth++;
                        error += "Capacidad excedida en el Horario de Ida\n";
                    }
                }

                if (dtphoras2.Checked == true)
                {
                    if (val.validarHorariosVeh(combveh2.Text, dtphoras2.Text) == 1)
                    {
                        conth++;
                        error += "El Vehiculo ya realiza una ruta en el Horario de Venida\n";
                    }

                    //Capacidad excedida
                    if (val.validarCap(combveh2.Text, int.Parse(txtpa.Text)) == 1)
                    {
                        conth++;
                        error += "Capacidad excedida en el Horario de Venida\n";
                    }
                }


                //Ruta Existente
                if (val.validarRuta(txtorigen.Text + "-" + txtdestino.Text) == 1)
                {
                    error += "La Ruta ya existe\n";

                    txtorigen.Clear();
                    txtdestino.Clear();
                    txtorigen.Focus();

                    conth++;
                }
                if (conth > 0)
                    MessageBox.Show("Debe llenar correctamente los Horarios\n\n" + error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (val.validarMantenimiento(combveh1.Text) > 0)
                        MessageBox.Show("El vehiculo no esta disponible para viajar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        DialogResult = MessageBox.Show("¿Datos ingresados correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult == DialogResult.Yes)
                        {
                            /****** CONTRATO ******/
                            anio = dtpinicio.Value.Year.ToString();
                            codcli = combcliente.SelectedValue.ToString();

                            if (txtant.Text == "")
                                ant = 0.00;
                            else
                                ant = double.Parse(txtant.Text);

                            ing.NuevoContrato(anio, combcliente.Text, codcli, 2, Convert.ToDateTime(dtpinicio.Text), double.Parse(txttotal.Text),
                                              Convert.ToDateTime(dtpfin.Text), 0.00, 0, combservicio.Text, ant, 2);

                            /****** RUTA ******/
                            ing.NuevaRuta(txtorigen.Text + "-" + txtdestino.Text, txtorigen.Text + " - " + txtdestino.Text, "Viaje desde " + txtorigen.Text + " hasta " + txtdestino.Text, "Viaje");


                            /****** RUTA CONTRATO ******/
                            ing.RutaContrato(txtorigen.Text + "-" + txtdestino.Text, " ", anio, combcliente.Text);


                            /****** RUTA VEHICULO HORARIO ******/
                            if (dtphoras1.Checked)
                                ing.AsignarHoraVeh(txtorigen.Text + "-" + txtdestino.Text, combveh1.Text, dtphoras1.Text, dtphorae1.Text, int.Parse(txtpa.Text));

                            if (dtphoras2.Checked)
                                ing.AsignarHoraVeh(txtorigen.Text + "-" + txtdestino.Text, combveh2.Text, dtphoras2.Text, dtphorae2.Text, int.Parse(txtpa.Text));

                            MessageBox.Show("Contrato creado con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Limpieza
                            txtorigen.Clear();
                            txtdestino.Clear();
                            txttotal.Clear();
                            txtant.Clear();
                            txtpa.Clear();

                            cambio1 = 2;
                            cambio2 = 2;


                            labv1.Visible = false;
                            labv2.Visible = false;

                            combservicio.SelectedIndex = -1;
                            combcliente.SelectedIndex = -1;
                            combveh1.SelectedIndex = -1;
                            combveh2.SelectedIndex = -1;

                            cambio1 = 3;
                            cambio2 = 3;

                            dtphoras1.Checked = false;
                            dtphorae1.Checked = false;
                            dtphoras2.Checked = false;
                            dtphorae2.Checked = false;

                            txtorigen.Focus();
                        }
                    }
                }
            }
        }
    }
}
