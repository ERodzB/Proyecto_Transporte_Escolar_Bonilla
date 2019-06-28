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
                if (MessageBox.Show("¿Esta seguro que desea guardar los cambios\nSi guarda los cambios, no podrá revertir los cambios", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    mod.ModificarClientes(txtIdentidad.Text ,txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);                    
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
}
