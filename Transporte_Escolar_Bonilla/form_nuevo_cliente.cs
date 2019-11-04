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
using System.Text.RegularExpressions;

namespace Transporte_Escolar_Bonilla
{
    public partial class form_nuevo_cliente : Form
    {
        Estetica Estetics = new Estetica();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();
        Consultar consul = new Consultar();
        Modificar mod = new Modificar();

        //Llevar id, nombre de cliente y tipo contrato para asociarlo al contrato
        static public string id;
        static public string nomc;
        static public int tipoc;
        string regId = @"^(([0-9][1-9]){1,2}(19\d{7})?(20[0-0][0-1]\d{5})?)$";
        string regRTN = @"^(([0-9][1-9]){1,2}(19\d{8})?(20[0-0][0-1]\d{6})?)$";


        public form_nuevo_cliente()
        {
            InitializeComponent();

            txtid.ShortcutsEnabled = false;
            txtnom.ShortcutsEnabled = false;
            txtdir.ShortcutsEnabled = false;
            txttel.ShortcutsEnabled = false;
            txtcorreo.ShortcutsEnabled = false;
        }

        //Carga
        private void Form_nuevo_cliente_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Tipo de Contrato
            combTipoContrato.DataSource = consul.Combobox_TipoContrato();
            combTipoContrato.DisplayMember = "Tipo_Contrato";
            combTipoContrato.SelectedIndex = -1;

            txtid.Focus();
        } 
        //Click Siguiente
        private void Labsiguiente_Click(object sender, EventArgs e)
        { 
            int cont = 0;
            string error = "";

            //No dejar Campos Vacios
            if (txtid.Text.Trim().Length == 0)
                cont++;
            if (txtcorreo.Text.Trim().Length == 0)
                cont++;
            if (txtnom.Text.Trim().Length == 0)
                cont++;
            if (txtdir.Text.Trim().Length == 0)
                cont++;
            if (txttel.Text.Trim().Length == 0)
                cont++;
            if (combTipoContrato.SelectedIndex == -1)
                cont++;


            if (cont > 0)
                MessageBox.Show("Debe llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (val.validarCliente(txtid.Text) == 1)
                {
                    MessageBox.Show("El ID ingresado ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtid.Clear();
                    txtid.Focus(); 
                }
                else
                {


                    error += val.valIdORtn(txtid.Text);

                      
                 
                    if(txtnom.Text.Trim().Length < 3)
                        error += "*Debe ingresar un Nombre mayor o igual a 3 caracteres\n";

                    //All verifica si todos los caracteres cumplen cierta condicion. Se toma cada letra en x y se verifica si cada una es un numero 
                    if (txtdir.Text.Trim().Length < 15 || txtdir.Text.All(x => char.IsNumber(x))) 
                        error += "*Debe ingresar una Dirección válida mayor o igual a 15 caracteres\n";

                    if(txttel.Text.Trim().Length < 8 || txttel.Text.Equals("00000000"))
                        error += "*Debe ingresar un Teléfono Válido\n";

                    if(combTipoContrato.SelectedIndex == -1)
                        error += "*Debe seleccionar un Tipo de Contrato\n";

                    if(error == "")
                    {
                        if(System.Text.RegularExpressions.Regex.IsMatch(txtcorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            DialogResult = MessageBox.Show("Procederá a crear el Contrato y ya no podrá regresar\n\n¿Está seguro de los datos ingresados?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (DialogResult == DialogResult.Yes)
                            {
                                //Guardar Datos del Cliente
                                ing.NuevoCliente(txtid.Text, txtnom.Text, txtdir.Text, txttel.Text, txtcorreo.Text);
                                mod.BitacoraModulo("Nuevo Cliente", 7, "Ingreso de Nuevo Cliente", txtid.Text, "N/A", "N/A", "N/A", "N/A");

                                MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Guardar id, nombre y tipoc 
                                id = txtid.Text;
                                nomc = txtnom.Text;
                                tipoc = combTipoContrato.SelectedIndex + 1;


                                if (combTipoContrato.Text.Equals("Temporal"))
                                {
                                    form_nuevo_clienteT cliT = new form_nuevo_clienteT();
                                    Estetics.AbrirFormularios(cliT, cliente1_panel);
                                }
                                else
                                {
                                    form_nuevo_clienteP clip = new form_nuevo_clienteP();
                                    Estetics.AbrirFormularios(clip, cliente1_panel);
                                }
                                //Limpieza
                                txtnom.Clear();
                                txtid.Clear();
                                txtdir.Clear();
                                txttel.Clear();
                                txtcorreo.Clear();
                                combTipoContrato.SelectedIndex = -1;
                            }                         
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar una dirección de correo válida. Ej: tucorreo@gmail.com", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtcorreo.Focus();
                        }
                    }
                    else
                        MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Pasar el mouse por Siguiente
        private void Labsiguiente_MouseHover(object sender, EventArgs e)
        {
            labsiguiente.ForeColor = Color.White;
        }

        //Se quita el mouse de Siguiente
        private void Labsiguiente_MouseLeave(object sender, EventArgs e)
        {
            labsiguiente.ForeColor = Color.FromArgb(12, 24, 94); 
        }

        private void CombTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
            
        }

        private void Txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Que no deje espacios en blanco al inicio
            if(char.IsWhiteSpace(e.KeyChar) && txtnom.Text.Trim().Length == 0)
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }

        private void Txtdir_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Que no deje espacios en blanco al inicio
            if (char.IsWhiteSpace(e.KeyChar) && txtdir.Text.Trim().Length == 0)
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar=='.') && !(e.KeyChar==','))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }

        private void Txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }

        private void Txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar=='@') && !(e.KeyChar=='.'))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }
        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text.Length <= 13)
                label1.Text = "Número de Identidad";
            if (txtid.Text.Length == 14)
                label1.Text = "Número de RTN";

        }
    }
}
