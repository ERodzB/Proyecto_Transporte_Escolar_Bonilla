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
    public partial class form_mantenimientos : Form
    {
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();
        Modificar modi = new Modificar();
        int cambio = 0;

        public form_mantenimientos()
        {
            InitializeComponent();

            txtnom.ShortcutsEnabled = false;
            txtdesc.ShortcutsEnabled = false;
        }

        //Load
        private void Form_mantenimientos_Load(object sender, EventArgs e)
        {
            //Llenar comb mantenimiento
            combmant.DataSource = consul.Combobox_Mant();
            combmant.DisplayMember = "Mantenimiento";
            combmant.SelectedIndex = -1;
        }

        private void Radagregar_CheckedChanged(object sender, EventArgs e)
        {
            if(radagregar.Checked)
            {
                labnom.Visible = true;
                txtnom.Visible = true;
                labdesc.Visible = true;
                txtdesc.Visible = true;

                botingresar.Visible = true;
            }
            else
            {
                labnom.Visible = false;
                txtnom.Visible = false;
                labdesc.Visible = false;
                txtdesc.Visible = false;

                botingresar.Visible = false;
            }
        }

        private void Radmodi_CheckedChanged(object sender, EventArgs e)
        {
            if (radmodi.Checked)
            {
                cambio = 3;

                labmant.Visible = true;
                combmant.Visible = true;
                labnom.Visible = true;
                txtnom.Visible = true;
                labdesc.Visible = true;
                txtdesc.Visible = true;

                txtnom.Clear();
                txtdesc.Clear();
                txtnom.Enabled = false;
                txtdesc.Enabled = false;

                botingresar.Visible = true;
                botingresar.Text = "Modificar";

            }
            else
            {
                labmant.Visible = false;
                combmant.Visible = false;
                labnom.Visible = false;
                txtnom.Visible = false;
                labdesc.Visible = false;
                txtdesc.Visible = false;

                txtnom.Clear();
                txtdesc.Clear();
                txtnom.Enabled = true;
                txtdesc.Enabled = true;

                botingresar.Visible = false;
                botingresar.Text = "Ingresar";

                cambio = 0;
                combmant.SelectedIndex = -1;
                //cambio = 0;
            }
        }

        private void Botingresar_Click(object sender, EventArgs e)
        {
            string errores = "";
            errores += val.valTextoVacioOMaximo(txtnom.Text, "Nombre de Mantenimiento");
            errores += val.valTextoVacioOMaximo(txtdesc.Text, "Descripcion de Mantenimiento");
            //INGRESAR NUEVO
            if (botingresar.Text.Equals("Ingresar"))
            {
                if (val.VerificarMantenimiento(1, txtnom.Text, 1) == 1)
                {
                    errores += "*El Mantenimiento ya existe\n";
                    txtnom.Clear();
                    txtnom.Focus();
                }
                if (errores != "")
                {
                    MessageBox.Show("Debe llenar correctamente los datos\n" + errores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = MessageBox.Show("¿Está seguro de los datos ingresados?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)
                    {
                        //Guardar Mantenimiento
                        ing.NuevoTipoMant(txtnom.Text, txtdesc.Text);

                        MessageBox.Show("Mantenimiento guardado con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpiar

                        cambio = 0;

                        //Actializar comb mantenimiento
                        combmant.DataSource = consul.Combobox_Mant();
                        combmant.DisplayMember = "Mantenimiento";
                        combmant.SelectedIndex = -1;

                        txtnom.Clear();
                        txtdesc.Clear();

                        txtnom.Focus();

                        radno.Checked = true;
                    }
                }




            }

            //MODIFICAR 
            else
            {
                errores += val.valCmbVacio(combmant.SelectedIndex, "Mantenimientos");


                //Validar ningun cambio realizado en el seleccionado
                if (val.CambiosMantenimiento(txtnom.Text, txtdesc.Text) == 1)
                    errores += "*No se ha realizado ningún cambio en el Mantenimiento\n";
                //Validar Existente
                if (val.VerificarMantenimiento(combmant.SelectedIndex + 1, txtnom.Text, 2) == 1)
                {
                    errores += "*El Mantenimiento ya existe\n";
                    txtnom.Clear();
                    txtnom.Focus();
                }

                if (errores != "")
                {
                    MessageBox.Show("Debe llenar correctamente los datos\n" + errores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = MessageBox.Show("¿Está seguro de los datos ingresados?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)
                    {
                        //Modificar Mantenimiento
                        modi.ModificarMantenimiento(combmant.SelectedIndex + 1, txtnom.Text, txtdesc.Text);

                        MessageBox.Show("Mantenimiento modificado con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpiar

                        cambio = 0;

                        //Actializar comb mantenimiento
                        combmant.DataSource = consul.Combobox_Mant();
                        combmant.DisplayMember = "Mantenimiento";
                        combmant.SelectedIndex = -1;

                        //cambio = 3;

                        txtnom.Clear();
                        txtdesc.Clear();

                        txtnom.Focus();

                        radno.Checked = true;
                    }
                }

            }
        }

        //Elige un Mantenimiento
        private void Combmant_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambio++;

            if(cambio>3)
            {
                consul.DatosMantenimiento(combmant.SelectedIndex + 1, txtnom, txtdesc);
                txtnom.Enabled = true;
                txtdesc.Enabled = true;
            }
                
        }

        private void Radno_CheckedChanged(object sender, EventArgs e)
        {
            if(radno.Checked)
            {
                txtnom.Clear();
                txtdesc.Clear();
            } 
        }
    }
}
