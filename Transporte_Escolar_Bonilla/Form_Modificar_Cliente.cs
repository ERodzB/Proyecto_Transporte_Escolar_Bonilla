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
    public partial class Form_Modificar_Cliente : Form
    {
        public Form_Modificar_Cliente()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar mod = new Modificar();
            if(txtIdentidad.Text !="")
            {
                if (txtNombre.Text!="" && txtDireccion.Text!="" && txtTelefono.Text!="" && txtCorreo.Text!="")
                {
                    if (txtDireccion.TextLength >= 15)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            if (MessageBox.Show("¿Esta seguro que desea guardar los cambios\nSi guarda los cambios, no podrá revertir los cambios", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                mod.ModificarClientes(txtIdentidad.Text, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                                mod.BitacoraModulo("Modificación - Cliente", 10, "Modificación Información del Cliente", "Cliente Modificado: " + txtIdentidad.Text, "N/A", "N/A", "N/A", "N/A");
                                txtIdentidad.Text = "";
                                txtDireccion.Text = "";
                                txtNombre.Text = "";
                                txtTelefono.Text = "";
                                txtCorreo.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("La direccion de correo es invalida. Favor corregir", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCorreo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una direccion mayor a 15 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDireccion.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error. Favor no dejar ningun valor vacio","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form_Modificar_Cliente_Load(object sender, EventArgs e)
        {
            Consultar con = new Consultar();

            con.CargadgvCliente(dgvCargaCliente);
        }

        private void DgvCargaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar=='.') && !(e.KeyChar==','))
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar=='.') && !(e.KeyChar=='@'))
            {
                e.Handled = true;
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
            }
        }
    }
}
