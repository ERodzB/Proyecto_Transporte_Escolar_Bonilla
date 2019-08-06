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

        public form_nuevo_cliente()
        {
            InitializeComponent();
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Botcrear_Click(object sender, EventArgs e)
        {
            
        }

        private void Combruta1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combruta2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combruta3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        //Click Siguiente
        private void Labsiguiente_Click(object sender, EventArgs e)
        { 
            int cont = 0;

            //No dejar Campos Vacios
            if (txtid.Text.Trim().Length < 13)
                cont++;
            if (string.IsNullOrEmpty(txtcorreo.Text))
                cont++;
            if (txtnom.Text.Trim().Length < 3)
                cont++;
            if (txtdir.Text.Trim().Length < 15)
                cont++;
            if (txttel.Text.Trim().Length < 8)
                cont++;
            if (combTipoContrato.SelectedIndex == -1)
                cont++;


            if (cont > 0) 
                MessageBox.Show("Debe llenar todos los campos correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if(val.validarCliente(txtid.Text) == 1)
                {
                    MessageBox.Show("El ID ingresado ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtid.Clear();
                    txtid.Focus(); 
                }
                else
                {
                    if (txtdir.TextLength < 15)
                    {
                        MessageBox.Show("Debe ingresar una dirección mayor a 15 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtdir.Focus();
                    }
                    else
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
                            MessageBox.Show("Dirección de correo inválida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtcorreo.Focus();
                        }
                    }
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
            }
        }

        private void Txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtdir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar=='.') && !(e.KeyChar==','))
            {
                e.Handled = true;
            }
        }

        private void Txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar=='@') && !(e.KeyChar=='.'))
            {
                e.Handled = true;
            }
        }
    }
}
