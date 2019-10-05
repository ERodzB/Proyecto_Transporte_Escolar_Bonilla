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
    public partial class form_nuevo_clienteT : Form
    {
        Estetica Estetics = new Estetica();
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();
        Modificar mod = new Modificar();

        bool borrar = false;
        double total = 0;

        public form_nuevo_clienteT()
        {
            InitializeComponent();

            txtpa1.ShortcutsEnabled = false;
            txtpa2.ShortcutsEnabled = false;
            txtmontom.ShortcutsEnabled = false;
            txtcantm.ShortcutsEnabled = false;
        }

        //Carga  
        private void Form_nuevo_cliente2_Load(object sender, EventArgs e)
        {
            combservicio.SelectedIndex = -1;

            //Llenar ComboBox de Rutas
            combruta1.DataSource = consul.Combobox_Rutas();
            combruta1.DisplayMember = "Codigo_Ruta";
            combruta1.SelectedIndex = -1;

            combruta2.DataSource = consul.Combobox_Rutas();
            combruta2.DisplayMember = "Codigo_Ruta";
            combruta2.SelectedIndex = -1;

            pago_cmb.DataSource = consul.combox_tipo_pago();
            pago_cmb.DisplayMember = "NombrePago";
            pago_cmb.ValueMember = "TipoPago";
            pago_cmb.SelectedIndex = -1;
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
            int contc = 0, contr = 0;
            string errorc = "", error= "\n\n", anio="";

            //Campos de Texto y TipoContrato Vacio
            if (combservicio.SelectedIndex == -1)
                contc++;

            if (txtmontom.Text.Trim().Length == 0 || double.Parse(txtmontom.Text)<=0)
                contc++;

            if (txtcantm.Text.Trim().Length == 0 || int.Parse(txtcantm.Text) <= 0)
                contc++;

            if (contc>0)
            {
                MessageBox.Show("Debe llenar correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            else   
            {
                //Medio Bus
                if(combservicio.SelectedIndex == 1)
                {
                    //Parada
                    if (txtpa1.Text.Trim().Length < 3)
                        contr++;

                    //Todos Vacios
                    if (combruta1.SelectedIndex == -1 && combhora1.SelectedIndex == -1 && combveh1.SelectedIndex == -1 && txtpa1.Text == "")
                        contr++;

                    //Algunos vacios
                    if (combruta1.SelectedIndex == -1 || combhora1.SelectedIndex == -1 || combveh1.SelectedIndex == -1 || txtpa1.Text == "")
                        contr++; 
                }

                //Bus Completo
                if (combservicio.SelectedIndex == 0)
                {
                    //Parada
                    if (txtpa1.Text.Trim().Length < 3 || txtpa2.Text.Trim().Length < 3)
                        contr++;

                    //Todos Vacios
                    if (combruta1.SelectedIndex == -1 && combhora1.SelectedIndex == -1 && combveh1.SelectedIndex == -1 && txtpa1.Text == "" && 
                        combruta2.SelectedIndex == -1 && combhora2.SelectedIndex == -1 && combveh2.SelectedIndex == -1 && txtpa2.Text == "")
                        contr++;

                    //Algunos vacios
                    if (combruta1.SelectedIndex == -1 || combhora1.SelectedIndex == -1 || combveh1.SelectedIndex == -1 || txtpa1.Text == "" || 
                        combruta2.SelectedIndex == -1 || combhora2.SelectedIndex == -1 || combveh2.SelectedIndex == -1 || txtpa2.Text == "")
                        contr++;

                    //Rutas Iguales
                    if (combruta1.Text == combruta2.Text)
                        contr++; 
                }


                //Mostrar mensaje de Error
                if (contr > 0)
                    MessageBox.Show("Debe llenar correctamente los datos de la Ruta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (int.Parse(txtcantm.Text) > 12)
                        MessageBox.Show("La cantidad máxima de Meses a Pagar son 12", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        DialogResult = MessageBox.Show("¿Datos ingresados correctamente?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult == DialogResult.Yes)
                        {
                            anio = dtpinicio.Value.Year.ToString();

                            //Guardar datos de Contrato 

                            if (pago_cmb.SelectedItem.Equals("Pago Mensual"))
                            {
                                ing.NuevoContrato(anio, form_nuevo_cliente.nomc, form_nuevo_cliente.id, form_nuevo_cliente.tipoc, Convert.ToDateTime(dtpinicio.Text), total,
                                              DateTime.ParseExact(txtfechafin.Text, "dd/MM/yyyy", null), double.Parse(txtmontom.Text), Convert.ToInt32(txtcantm.Text), combservicio.Text, 0.00, pago_cmb.SelectedIndex + 1);
                                mod.BitacoraModulo("Nuevo Contrato", 2, "Nuevo Contrato Creado", form_nuevo_cliente.id, "N/A", "N/A", "N/A", "N/A");

                            }
                            else
                            {
                                ing.NuevoContrato(anio, form_nuevo_cliente.nomc, form_nuevo_cliente.id, form_nuevo_cliente.tipoc, Convert.ToDateTime(dtpinicio.Text), total,
                                              DateTime.ParseExact(txtfechafin.Text, "dd/MM/yyyy", null), double.Parse(txtmontom.Text), 1, combservicio.Text, 0.00, pago_cmb.SelectedIndex + 1);
                                mod.BitacoraModulo("Nuevo Contrato", 2, "Nuevo Contrato Creado", form_nuevo_cliente.id, "N/A", "N/A", "N/A", "N/A");

                            }
                            //Asociar Ruta Ida con el Contrato creado (PORQUE OBLIGATORIAMENTE SE CREA UNA) y actualizar pasajeros
                            ing.RutaContrato(combruta1.Text, txtpa1.Text, anio, form_nuevo_cliente.nomc);
                            ing.Pasajeros(combruta1.Text, combveh1.Text, combhora1.Text);

                            //Si es Bus completo - Se asocia ruta de Vuelta al contrato tambien y actualizar pasajeros
                            if (combservicio.SelectedIndex == 0)
                            {
                                ing.RutaContrato(combruta2.Text, txtpa2.Text, anio, form_nuevo_cliente.nomc);
                                ing.Pasajeros(combruta2.Text, combveh2.Text, combhora2.Text);
                            }

                            MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            form_nuevo_cliente cli1 = new form_nuevo_cliente();
                            Estetics.AbrirFormularios(cli1, cliente2_panel);

                            this.Close();
                        }
                    }
                }
            }
        }

        //Seleccionar Vehiculo 1
        private void Combvh1r1_SelectedIndexChanged(object sender, EventArgs e)
        {
            consul.DescVehiculos(combveh1.Text, labv1);
            labv1.Visible = true; 
        }

        private void Combvh1r1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        //Seleccionar Servicio
        private void Combservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bus completo
            if(combservicio.SelectedIndex == 0)
            {
                combruta2.Enabled = true;
                combhora2.Enabled = true;
                combveh2.Enabled = true;
                txtpa2.Enabled = true;
            }
            else
            {
                combruta2.Enabled = false;
                combhora2.Enabled = false;
                combveh2.Enabled = false;
                txtpa2.Enabled = false;
                labv2.Visible = false;

                combruta2.SelectedIndex = -1;
                combhora2.SelectedIndex = -1;
                combveh2.SelectedIndex = -1;
                txtpa2.Text = "";
            }
        }


        //Selecciona Ruta de Ida - Se llenan Horarios de ese Ruta
        private void Combruta1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Llenar ComboBox de Horarios con Horario de la Ruta Seleccionada
            combhora1.DataSource = consul.Combobox_Horarios(combruta1.Text);
            combhora1.DisplayMember = "Horarios";
            combhora1.SelectedIndex = -1;
        }

        //Selecciona Ruta de Vuelta - Se llenan Horarios de ese Ruta
        private void Combruta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Llenar ComboBox de Horarios con Horario de la Ruta Seleccionada
            combhora2.DataSource = consul.Combobox_Horarios(combruta2.Text); 
            combhora2.DisplayMember = "Horarios";
            combhora2.SelectedIndex = -1;
        }


        //Seleccionar Horario Ida -  Se llenan vehiculos de ese Horario
        private void Combhora1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combveh1.DataSource = consul.Combobox_VehiculosRH(combruta1.Text, combhora1.Text);
            combveh1.DisplayMember = "Codigo_vehiculo";
            combveh1.SelectedIndex = -1;
        }

        //Seleccionar Horario Vuelta -  Se llenan vehiculos de ese Horario
        private void Combhora2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combveh2.DataSource = consul.Combobox_VehiculosRH(combruta2.Text, combhora2.Text);
            combveh2.DisplayMember = "Codigo_vehiculo";  
            combveh2.SelectedIndex = -1;
        }


        //Seleccionar vehiculo 2
        private void Combveh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            consul.DescVehiculos(combveh2.Text, labv2); 
            labv2.Visible = true;
        }


        //Se escribe monto mensual
        private void Txtmontom_TextChanged(object sender, EventArgs e)
        {
            //Para calcular Monto Total


        }

        //Se escribe cantidad de meses
        private void Txtcantm_TextChanged(object sender, EventArgs e)
        {
            //Para calcular Monto Total
           
            //Para calcular fecha de finalizacion (Se toma en cuenta si se presiona borrar)
            if (txtcantm.Text == "")
                txtfechafin.Text = "";

            if (borrar == false)
            {
                if (txtcantm.Text != "")
                    txtfechafin.Text = dtpinicio.Value.AddMonths(int.Parse(txtcantm.Text)).ToString("dd/MM/yyyy");
            }
            else
            {
                if (txtcantm.Text != "") 
                    txtfechafin.Text = dtpinicio.Value.AddMonths(int.Parse(txtcantm.Text)).ToString("dd/MM/yyyy");
            } 

        }


        //Selecciona fecha Inicio
        private void Dtpinicio_ValueChanged(object sender, EventArgs e)
        {
            if(txtcantm.Text != "")
                txtfechafin.Text = dtpinicio.Value.AddMonths(int.Parse(txtcantm.Text)).ToString("dd/MM/yyyy"); 
        }


        //Si se presiona tecla borrar en cantmeses
        private void Txtcantm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                if (e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    borrar = true;
                    //MessageBox.Show("TECLA: " + e.KeyChar);
                }

                else
                    borrar = false;

            }

            //MessageBox.Show("TECLA DESPUES: " + e.KeyChar);
            ////Si no se presiona borrar (Para que no mande un dato vacio)
            //if (e.KeyChar != Convert.ToChar(Keys.Back))
            //{
            //    if (txtcantm.Text != " ")
            //    {
            //        //MessageBox.Show("DATO: " + e.KeyChar);
            //        txtfechafin.Text = dtpinicio.Value.AddMonths(int.Parse(e.KeyChar.ToString())).ToString("dd/MM/yyyy");
            //    }
            //}      
        }

        private void Cliente2_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pago_cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (pago_cmb.SelectedIndex==0)
            {
                label7.Text = "Cantidad de Meses";
                label7.Text = "Monto Mensual";
            }
            else
            {
                label7.Text = "Monto Total";
                label17.Text = "Meses a Pagar";
            }
        }

        private void Txtpa1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar=='.') && !(e.KeyChar==','))
            {
                e.Handled = true;
            }
        }

        private void Txtpa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void Txtmontom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtmontom.Text,"^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void Pago_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
