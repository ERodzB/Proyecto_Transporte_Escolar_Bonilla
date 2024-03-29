﻿using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class form_mantenimiento_unidad : Form
    {
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Modificar mod = new Modificar();
        Validar val = new Validar();
        public form_mantenimiento_unidad()
        {
            InitializeComponent();

            txtcosto.ShortcutsEnabled = false;

            dtpfecha.MaxDate = System.DateTime.Today;
        }

        //Carga
        private void Form_mantenimiento_unidad_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Vehiculos
            combveh.DataSource = consul.Combobox_Vehiculos();
            combveh.DisplayMember = "Codigo_vehiculo";
            combveh.SelectedIndex = -1;

            //Llenar Combobox de Tipo de Mantenimiento
            combtipo.DataSource = consul.Combobox_TipoMant();
            combtipo.DisplayMember = "Mantenimiento";
            combtipo.ValueMember = "Codigo";
            combtipo.SelectedIndex = -1;

        }

        //Elige un Vehiculo
        private void Combveh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se muestra descripcion en el lab
            consul.DescVehiculos(combveh.Text, lab1);
            lab1.Visible = true;
        }

        //Boton Ingresar
        private void Botingresar_Click(object sender, EventArgs e)
        {
            int cont = 0;
#pragma warning disable CS0219 // The variable 'error' is assigned but its value is never used
            string error = "";
#pragma warning restore CS0219 // The variable 'error' is assigned but its value is never used

            //Validar campos vacios
            if (combveh.SelectedIndex == -1)
                cont++;

            if (combtipo.SelectedIndex == -1)
                cont++;

            if (txtcosto.Text.Trim().Length == 0)
                cont++;

            if (cont > 0)
                MessageBox.Show("Debe llenar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (double.Parse(txtcosto.Text) <= 0)
                    MessageBox.Show("El Costo del Mantenimiento debe ser mayor que 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {                  
                    if (val.VehiculoConductor(combveh.Text) == 0)
                        MessageBox.Show("Asigne un conductor encargado antes de enviarlo a Mantenimiento", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        DialogResult = MessageBox.Show("¿Está seguro de los datos ingresados?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (DialogResult == DialogResult.Yes)
                        {
                            //Guardar mantenimiento
                            ing.NuevoMantenimiento(int.Parse(combtipo.SelectedValue.ToString()), dtpfecha.Value, combveh.Text, double.Parse(txtcosto.Text));
                            mod.BitacoraModulo("Mantenimiento", 1, "Mantenimiento a un Vehiculo", combveh.Text, "N/A", "N/A", "N/A", "N/A");

                            //Cambiar estado del vehiculo a "En Mantenimiento"
                            mod.ModificarEstadoVeh(combveh.Text);

                            MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Limpiar
                            lab1.Visible = false;

                            txtcosto.Clear();

                            combveh.SelectedIndex = -1;
                            combtipo.SelectedIndex = -1;
                        }
                    }                  
                }


            }



        }

        private void Txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtcosto.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
    }
}
