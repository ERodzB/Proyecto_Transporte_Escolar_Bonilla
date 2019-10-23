﻿using System;
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
    public partial class Modificar_UnidadFrm : Form
    {
        Consultar con = new Consultar();
        Modificar mod = new Modificar();
        Validar val = new Validar();
        string color = "1";
        int cmbValue=999;
        string dtp1 = "1";
        string dtp2 = "1";
        public Modificar_UnidadFrm()
        {
            InitializeComponent();

            txtPlaca.ShortcutsEnabled = false;
            txtColor.ShortcutsEnabled = false;  
            dtpEmision.MinDate = new DateTime(2015, 01, 01);
            dtpEmision.MaxDate = new DateTime(Convert.ToInt32(DateTime.Now.Year), Convert.ToInt32(DateTime.Now.Month), Convert.ToInt32(DateTime.Now.Day));
            dtpVencimiento.MinDate = new DateTime(2019, 01, 01);
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            string errores = "";
            errores += val.valTextoVacioOMaximo(txtColor.Text, "Color");
            errores += val.valCmbVacio(cmbEstadoVehiculo.SelectedIndex, "Estado de Vehiculo");
            if (dtpEmision.Value.Date == dtpVencimiento.Value.Date)
                errores += "*Escoja Fechas Distintas\n";
            if(txtColor.Text == color && cmbEstadoVehiculo.SelectedIndex == cmbValue && dtpEmision.Value.ToString() == dtp1 && dtpVencimiento.Value.ToString() == dtp2)
            {
                errores += "*No se ha realizado ningun cambio\n";
            }
            
            if (errores != "")
            {
                MessageBox.Show("Debe llenar correctamente los datos\n" + errores, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea guardar los cambios?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    mod.ModificarVehiculo(txtPlaca.Text, txtColor.Text, int.Parse(cmbEstadoVehiculo.SelectedValue.ToString()), DateTime.Parse(dtpEmision.Text), DateTime.Parse(dtpVencimiento.Text));
                    mod.BitacoraModulo("Modificación - Unidad", 10, "Modificación de Informacion de Un Vehiculo", "Vehiculo Modificado: " + txtPlaca.Text, "N/A", "N/A", "N/A", "N/A");

                    txtPlaca.Text = "";
                    txtColor.Text = "";
                    cmbEstadoVehiculo.SelectedIndex = -1;
                    dtpEmision.ResetText();
                    dtpEmision.Enabled = false;
                    dtpVencimiento.ResetText();
                    dtpVencimiento.Enabled = false;
                }
            }
                
         }
         

        private void Modificar_UnidadFrm_Load(object sender, EventArgs e)
        {
            con.CargadgvModVehiculos(dgvVehiculos);
            cmbEstadoVehiculo.DataSource = con.combox_mod_vehiculo ();
            cmbEstadoVehiculo.DisplayMember = "Nombre_Estado";
            cmbEstadoVehiculo.ValueMember = "Codigo_Estado";
            cmbEstadoVehiculo.SelectedIndex = -1;

        }

 

        private void DgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvVehiculos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvVehiculos.Rows.Count > 0)
            {
                txtPlaca.Text = dgvVehiculos.CurrentRow.Cells[0].Value.ToString();
                txtColor.Text = dgvVehiculos.CurrentRow.Cells[8].Value.ToString();
                dtpEmision.Value = DateTime.Parse(dgvVehiculos.CurrentRow.Cells[11].Value.ToString());
                dtpVencimiento.Value = DateTime.Parse(dgvVehiculos.CurrentRow.Cells[12].Value.ToString());
                cmbEstadoVehiculo.SelectedIndex = 1;

                txtColor.Enabled = true;
                dtpEmision.Enabled = true;
                dtpVencimiento.Enabled = true;
                cmbEstadoVehiculo.Enabled = true;
                btnModificar.Enabled = true;

                color = txtColor.Text;
                cmbValue = cmbEstadoVehiculo.SelectedIndex;
                dtp1 = dtpEmision.Value.ToString();
                dtp2 = dtpVencimiento.Value.ToString();
            }   
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Que no deje espacios en blanco al inicio
            if (char.IsWhiteSpace(e.KeyChar) && txtColor.Text.Trim().Length == 0)
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
    }
}
