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

        //Llevar id y nombre de cliente para asociarlo al contrato
        static public string id;
        static public string nomc;

        public form_nuevo_cliente()
        {
            InitializeComponent();
        }

        //Carga
        private void Form_nuevo_cliente_Load(object sender, EventArgs e)
        {
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
            if (string.IsNullOrEmpty(txtid.Text))
                cont++;
            else
                if (string.IsNullOrEmpty(txtnom.Text)) 
                cont++;
            else
                if (string.IsNullOrEmpty(txtdir.Text))
                cont++; 
            else
                if (string.IsNullOrEmpty(txttel.Text))        
                cont++;

            if (cont > 0) 
                MessageBox.Show("Debe Llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult = MessageBox.Show("Procederá a crear el Contrato y ya no podrá regresar\n\n¿Está seguro de los datos ingresados?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)
                    {
                        //Guardar Datos del Cliente
                        ing.NuevoCliente(txtid.Text, txtnom.Text, txtdir.Text, txttel.Text, txtcorreo.Text);
                         
                        MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Guardar id y nombre
                        id = txtid.Text;
                        nomc = txtnom.Text;     

                        //Limpieza
                        txtnom.Clear();
                        txtid.Clear();
                        txtdir.Clear();
                        txttel.Clear();
                        txtcorreo.Clear();

                        form_nuevo_cliente2 cli2 = new form_nuevo_cliente2();
                        Estetics.AbrirFormularios(cli2, cliente1_panel);
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
    }
}
