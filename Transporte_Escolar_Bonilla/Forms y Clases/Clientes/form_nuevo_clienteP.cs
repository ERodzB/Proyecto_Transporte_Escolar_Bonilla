﻿using System;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class form_nuevo_clienteP : Form
    {
        Estetica Estetics = new Estetica();
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();

        public form_nuevo_clienteP()
        {
            InitializeComponent();

            txtpa.ShortcutsEnabled = false;
            txtorigen.ShortcutsEnabled = false;
            txtdestino.ShortcutsEnabled = false;
            txttotal.ShortcutsEnabled = false;
            txtant.ShortcutsEnabled = false;
        }

        //Carga
        private void Form_nuevo_clienteP_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Vehiculos
            combveh1.DataSource = consul.Combobox_Vehiculos();
            combveh1.DisplayMember = "Codigo_vehiculo";
            combveh1.SelectedIndex = -1;

            combveh2.DataSource = consul.Combobox_Vehiculos();
            combveh2.DisplayMember = "Codigo_vehiculo";
            combveh2.SelectedIndex = -1;

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


        //Boton Crear
        private void Botcrear_Click_1(object sender, EventArgs e)
        {
            double ant = 0;
            int contc = 0, contn = 0, conth = 0;
#pragma warning disable CS0219 // The variable 'anti' is assigned but its value is never used
#pragma warning disable CS0219 // The variable 'errorn' is assigned but its value is never used
            string error = "", errorn = "", anti = "", anio = "";
#pragma warning restore CS0219 // The variable 'errorn' is assigned but its value is never used
#pragma warning restore CS0219 // The variable 'anti' is assigned but its value is never used

            val.igual = 0;

            //Validar Campos
            if (combservicio.SelectedIndex == -1)
                contc++;

            if (txtorigen.Text == "")
                contc++;

            if (txtdestino.Text == "")
                contc++;

            if (txttotal.Text == "")
                contc++;

            if (txtant.Text == "")
                contc++;

            if (txtpa.Text == "")
                contc++;

            if (contc > 0)
                MessageBox.Show("Debe llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (txtorigen.Text.Trim().Length < 3 || txtorigen.Text.All(x => char.IsNumber(x)))
                    contc++;

                if (txtdestino.Text.Trim().Length < 3 || txtdestino.Text.All(x => char.IsNumber(x)))
                    contc++;

                if (contc > 0)
                    MessageBox.Show("Debe ingresar un Origen y Destino válidos de 3 caracteres mínimo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (double.Parse(txttotal.Text) <= 0)
                        contn++;

                    if (double.Parse(txtant.Text) <= 0)
                        contn++;

                    if (int.Parse(txtpa.Text) <= 0)
                        contn++;

                    if (contn > 0)
                        MessageBox.Show("Los campos No. de Pasajeros, Total y Anticipo deben ser mayor que 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    else
                    {
                        //Validar que no sea menor el precio que el anticipo
                        if (txtant.Text != "" && txttotal.Text != "")
                        {
                            if (double.Parse(txtant.Text) > double.Parse(txttotal.Text))
                                contn++;
                        }

                        if (contn > 0)
                            MessageBox.Show("El Anticipo no puede ser mayor al Total a Pagar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            //Validar Fechas 
                            if (dtpinicio.Value > dtpfin.Value)
                                contn++;

                            if (contn > 0)
                                MessageBox.Show("La Fecha de Finalización debe ser mayor a la de Inicio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            else
                            {
                                if (int.Parse(txtpa.Text) > 59)
                                    MessageBox.Show("No puede ingresar más de 59 pasajeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    //Validar Horarios
                                   
                                    //Algunos vacios
                                    if ((dtphoras1.Checked == true && dtphorae1.Checked == false) || (dtphoras1.Checked == false && dtphorae1.Checked == true) || (dtphoras1.Checked == true && dtphorae1.Checked == true && combveh1.SelectedIndex == -1) || (dtphoras1.Checked == true && dtphorae1.Checked == true && dtphoras1.Text == dtphorae1.Text))
                                        conth++;

                                    //Todos Vacios
                                    if (dtphoras1.Checked == false && dtphorae1.Checked == false && combveh1.SelectedIndex == -1)
                                        conth++;
                                    //}

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
                                            error += "El Vehiculo ya realiza una ruta en el Horario de Regreso\n";
                                        }

                                        //Capacidad excedida
                                        if (val.validarCap(combveh2.Text, int.Parse(txtpa.Text)) == 1)
                                        {
                                            conth++;
                                            error += "Capacidad excedida en el Horario de Regreso\n";
                                        }
                                    }

                                    if (conth > 0)
                                        MessageBox.Show("Debe llenar correctamente los Horarios\n\n" + error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    else
                                    {
                                        //Ruta Existente
                                        if (val.validarRuta(txtorigen.Text + "-" + txtdestino.Text) == 1)
                                        {
                                            MessageBox.Show("La Ruta ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            txtorigen.Clear();
                                            txtdestino.Clear();
                                            txtorigen.Focus();
                                        }
                                        else
                                        {
                                            if (val.validarMantenimiento(combveh1.Text) == 701)
                                                MessageBox.Show("El vehiculo no puede realizar viajes, ya que se encuentra en mantenimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            else
                                            {
                                                DialogResult = MessageBox.Show("¿Datos ingresados correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                                                if (DialogResult == DialogResult.Yes)
                                                {
                                                    /****** CONTRATO ******/
                                                    anio = dtpinicio.Value.Year.ToString();

                                                    if (txtant.Text == "")
                                                        ant = 0.00;
                                                    else
                                                        ant = double.Parse(txtant.Text);

                                                    ing.NuevoContrato(anio, form_nuevo_cliente.nomc, form_nuevo_cliente.id, form_nuevo_cliente.tipoc, Convert.ToDateTime(dtpinicio.Text), double.Parse(txttotal.Text),
                                                                      Convert.ToDateTime(dtpfin.Text), 0.00, 0, combservicio.Text, ant, 2);

                                                    /****** RUTA ******/
                                                    ing.NuevaRuta(txtorigen.Text + "-" + txtdestino.Text, txtorigen.Text + " - " + txtdestino.Text, "Viaje desde " + txtorigen.Text + " hasta " + txtdestino.Text, "Viaje");


                                                    /****** RUTA CONTRATO ******/
                                                    ing.RutaContrato(txtorigen.Text + "-" + txtdestino.Text, " ", anio, form_nuevo_cliente.nomc);


                                                    /****** RUTA VEHICULO HORARIO ******/
                                                    if (dtphoras1.Checked)
                                                        ing.AsignarHoraVeh(txtorigen.Text + "-" + txtdestino.Text, combveh1.Text, dtphoras1.Text, dtphorae1.Text, int.Parse(txtpa.Text));

                                                    if (dtphoras2.Checked)
                                                        ing.AsignarHoraVeh(txtorigen.Text + "-" + txtdestino.Text, combveh2.Text, dtphoras2.Text, dtphorae2.Text, int.Parse(txtpa.Text));

                                                    MessageBox.Show("Contrato creado con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    form_nuevo_cliente cli1 = new form_nuevo_cliente();
                                                    Estetics.AbrirFormularios(cli1, cliente3_panel);

                                                    this.Close();
                                                }
                                            }
                                        }
                                    }
                                }


                            }
                        }
                    }
                }
            }
        }

        //Selecciona Servicio
        private void Combservicio_SelectedIndexChanged_1(object sender, EventArgs e)
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

        //Selecciona Vehiculo Ida
        private void Combveh1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            consul.DescVehiculos(combveh1.Text, labv1);
            labv1.Visible = true;
        }

        //Selecciona Vehiculo Vuelta
        private void Combveh2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            consul.DescVehiculos(combveh2.Text, labv2);
            labv2.Visible = true;
        }

        private void Txtpa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
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

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
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

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }

        private void Txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txttotal.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
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

        private void Cliente3_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
