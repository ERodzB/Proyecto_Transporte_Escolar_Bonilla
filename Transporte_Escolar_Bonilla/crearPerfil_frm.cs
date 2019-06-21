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
    public partial class crearPerfil_frm : Form
    {
        public crearPerfil_frm()
        {
            InitializeComponent();
        }

        private void Crear_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            Validar valido = new Validar();

            if (valido.validarPerfil(nombrePerfil_tb.Text) == 0)
            {
                ingreso.NuevoPerfil(nivelAcceso_cmb.SelectedIndex+1, nombrePerfil_tb.Text, desPerfil_tb.Text);
                nivelAcceso_cmb.SelectedIndex = -1;
                nombrePerfil_tb.Clear();
                desPerfil_tb.Clear();

            }
            else
            {
                MessageBox.Show("Ya existe ese perfil");
            }
        }
    }
}
