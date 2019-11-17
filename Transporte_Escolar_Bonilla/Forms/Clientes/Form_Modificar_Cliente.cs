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
    public partial class Form_Modificar_Cliente : Form
    {
        Consultar con = new Consultar();
        Validar val = new Validar();

        public Form_Modificar_Cliente()
        {
            InitializeComponent();

            txtIdentidad.ShortcutsEnabled = false;
            txtNombre.ShortcutsEnabled = false;
            txtDireccion.ShortcutsEnabled = false;
            txtTelefono.ShortcutsEnabled = false;
            txtCorreo.ShortcutsEnabled = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar mod = new Modificar();

            if(txtIdentidad.Text.Trim().Length == 13)
            {
                if (txtNombre.Text.Trim().Length > 2) /*&& txtDireccion.Text!="" && txtTelefono.Text.Trim().Length == 8 && txtCorreo.Text!="")*/
                {
                    if (txtDireccion.Text.Trim().Length >= 15 && txtDireccion.Text.Any(x => char.IsLetter(x)))
                    {
                        if(txtTelefono.Text.Trim().Length == 8 && txtTelefono.Text.Trim() != "00000000")
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                            {
                                //Validar si no se realizo ningun cambio en el cliente seleccionado
                                if(val.CambiosCliente(txtIdentidad.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text) == 0)
                                {
                                    if (MessageBox.Show("¿Está seguro que desea guardar los cambios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                    {
                                        mod.ModificarClientes(txtIdentidad.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                                        mod.BitacoraModulo("Modificación - Cliente", 10, "Modificación Información del Cliente", "Cliente Modificado: " + txtIdentidad.Text, "N/A", "N/A", "N/A", "N/A");
                                        
                                        txtIdentidad.Text = "";
                                        txtDireccion.Text = "";
                                        txtNombre.Text = "";
                                        txtTelefono.Text = "";
                                        txtCorreo.Text = "";

                                        txtNombre.Enabled = false;
                                        txtDireccion.Enabled = false;
                                        txtTelefono.Enabled = false;
                                        txtCorreo.Enabled = false;

                                        btnModificar.Enabled = false;

                                        //Refrescar DGV
                                        con.CargadgvCliente(dgvCargaCliente, true); 
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se ha realizado ninguna modificación", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                    
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar una dirección de correo válida. Ej: tucorreo@gmail.com", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtCorreo.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe ingresar un Teléfono válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtTelefono.Focus();
                        }
                            
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar una Dirección válida mayor o igual a 15 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDireccion.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un Nombre mayor o igual a 3 caracteres","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form_Modificar_Cliente_Load(object sender, EventArgs e)
        {
            con.CargadgvCliente(dgvCargaCliente, false);
        }

        private void DgvCargaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCargaCliente.Rows.Count > 0)
            {
                btnModificar.Enabled = true;

                txtIdentidad.Text = dgvCargaCliente.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvCargaCliente.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dgvCargaCliente.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvCargaCliente.CurrentRow.Cells[3].Value.ToString();
                txtCorreo.Text = dgvCargaCliente.CurrentRow.Cells[4].Value.ToString();

                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;
                txtCorreo.Enabled = true;
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Que no deje espacios en blanco al inicio
            if (char.IsWhiteSpace(e.KeyChar) && txtNombre.Text.Trim().Length == 0)
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

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Que no deje espacios en blanco al inicio
            if (char.IsWhiteSpace(e.KeyChar) && txtDireccion.Text.Trim().Length == 0)
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar=='.') && !(e.KeyChar=='@'))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }

        private void DgvCargaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                SystemSounds.Hand.Play();
            }
        }
    }
}
