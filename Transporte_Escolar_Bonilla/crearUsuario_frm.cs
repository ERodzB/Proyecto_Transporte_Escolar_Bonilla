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
    public partial class crearUsuario_frm : Form
    {
        public crearUsuario_frm()
        {
            InitializeComponent();
        }

        private void Ingresar_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            Validar valido = new Validar();
            if (valido.validarEmpleado(identidad_tb.Text) == 1)
            {
                if (valido.validarUsuario_Empleado(identidad_tb.Text) == 0)
                {
                    if (valido.validarUsuario(nombre_tb.Text) == 0)
                    {
                        ingreso.NuevoUsuario(identidad_tb.Text, nombre_tb.Text, contra_tb.Text, Convert.ToInt32(Perfil_cmb.SelectedIndex.ToString()) + 1);
                        contra_tb.Clear();
                        nombre_tb.Clear();
                        Perfil_cmb.SelectedIndex = -1;
                        identidad_tb.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un usuario con ese nombre");
                        nombre_tb.Clear();
                        nombre_tb.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error ese empleado ya tiene un usuario");
                    identidad_tb.Clear();
                    identidad_tb.Focus();
                }
            }
            else
            {
                MessageBox.Show("El empleado no existe");
            }
            
        }

        private void CrearUsuario_frm_Load(object sender, EventArgs e)
        {
            Consultar consu = new Consultar();
            Perfil_cmb.DataSource = consu.llenarPerfiles();
            Perfil_cmb.DisplayMember = "Nombre_Perfil";
            Perfil_cmb.ValueMember = "Codigo_Perfil";
            Perfil_cmb.SelectedIndex = -1;
        }

        private void Perfil_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Identidad_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Nombre_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Contra_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
