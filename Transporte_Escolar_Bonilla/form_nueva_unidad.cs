﻿using System;
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
    public partial class form_nueva_unidad : Form
    {
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();

        public form_nueva_unidad()
        {
            InitializeComponent();
        }

        //Carga
        private void Form_nueva_unidad_Load(object sender, EventArgs e)
        {
            //Cargar Tipo de Vehiculo
            combtipoveh.DataSource = consul.Combobox_TipoVehiculo();
            combtipoveh.DisplayMember = "Tipo";  
            combtipoveh.ValueMember = "Codigo";
            combtipoveh.SelectedIndex = -1;

            //Cargar Tipo de Transmision
            combtipotra.DataSource = consul.Combobox_TipoTrans();
            combtipotra.DisplayMember = "Transmision";
            combtipotra.ValueMember = "Codigo";
            combtipotra.SelectedIndex = -1;

            //Cargar Tipo de Combustible
            combtipocom.DataSource = consul.Combobox_TipoGas();
            combtipocom.DisplayMember = "Gasolina"; 
            combtipocom.ValueMember = "Codigo";
            combtipocom.SelectedIndex = -1;

            //Cargar Estado
            combestado.DataSource = consul.Combobox_EstadoVeh();
            combestado.DisplayMember = "Estado";
            combestado.ValueMember = "Codigo";
            combestado.SelectedIndex = -1;


            //Colocar solo años en DateTimePicker
            dtpanioveh.Format = DateTimePickerFormat.Custom;
            dtpanioveh.CustomFormat = "yyyy";
            dtpanioveh.MinDate = new DateTime(1900, 01, 01); //Colocar fecha minima (año, mes, dia)
            dtpanioveh.ShowUpDown = true; //para que muestre las flechitas

            dtpanioad.Format = DateTimePickerFormat.Custom;
            dtpanioad.CustomFormat = "yyyy";
            dtpanioad.MinDate = new DateTime(1900, 01, 01);
            dtpanioad.ShowUpDown = true;

            txtmat.Focus();
        }

        //Boton Crear
        private void Botcrear_Click(object sender, EventArgs e)
        {
            int cont = 0;

            //Validar campos y combobox vacios vacios
            if (txtmat.Text == "")
                cont++;

            if (combtipoveh.SelectedIndex == -1)
                cont++;

            if (txtmarca.Text == "")
                cont++;

            if (txtmodelo.Text == "")
                cont++;

            if (txtcolor.Text == "")
                cont++;

            if (txtcap.Text == "")
                cont++;
            else
                if (int.Parse(txtcap.Text) <= 0)
                cont++;

            if (combtipotra.SelectedIndex == -1)
                cont++;

            if (combtipocom.SelectedIndex == -1)
                cont++;

            if (combestado.SelectedIndex == -1)
                cont++;

            //Validar fechas de emision y vencimiento del permiso
            if (dtpvenc.Value < dtpemision.Value)
                cont++;

            if (cont > 0)
                MessageBox.Show("Debe llenar correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Validar si el Vehiculo ya Existe
                if(val.validarVeh(txtmat.Text) == 1) 
                {
                    MessageBox.Show("El Vehiculo ya Existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtmat.Clear();
                    txtmat.Focus();
                }
                else
                {
                    DialogResult = MessageBox.Show("¿Está seguro de los datos ingresados?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)
                    {
                        //Guardar datos en Vehiculos
                        ing.NuevaUnidad(txtmat.Text, int.Parse(combtipoveh.SelectedValue.ToString()), int.Parse(dtpanioveh.Text), txtmarca.Text, txtmodelo.Text,
                                        int.Parse(txtcap.Text), int.Parse(combtipotra.SelectedValue.ToString()), int.Parse(combtipocom.SelectedValue.ToString()),
                                        txtcolor.Text, int.Parse(dtpanioad.Text), int.Parse(combestado.SelectedValue.ToString()), Convert.ToDateTime(dtpemision.Text),
                                        Convert.ToDateTime(dtpvenc.Text));

                        MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpiar
                        txtmat.Clear();
                        txtmarca.Clear();
                        txtmodelo.Clear();
                        txtcolor.Clear();
                        txtcap.Clear();

                        combtipoveh.SelectedIndex = -1; 
                        combtipotra.SelectedIndex = -1;
                        combtipocom.SelectedIndex = -1;
                        combestado.SelectedIndex = -1;

                        txtmat.Focus();
                    }
                } 
            }
        }
    }
}