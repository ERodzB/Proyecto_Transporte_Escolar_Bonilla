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
    public partial class pagos_frm : Form
    {
        Consultar consulto = new Consultar();
        Modificar mod = new Modificar();
        public pagos_frm()
        {
            InitializeComponent();
        }

        private void Pagos_frm_Load(object sender, EventArgs e)
        {
            consulto.CargadgvContrato(cliente_dgv);
        }

        private void Cliente_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void Contratos_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (contratos_dgv.CurrentRow.Cells[6].Value.ToString().Equals("1"))
            {
                if (DateTime.Now >= Convert.ToDateTime(contratos_dgv.CurrentRow.Cells[6].Value.ToString()).AddMonths(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()) - 1) && DateTime.Now < Convert.ToDateTime(contratos_dgv.CurrentRow.Cells[6].Value.ToString()).AddMonths(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()) + 1) || DateTime.Now.Day + consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()) + 1 >= 25 + consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()) + 1)
                {
                    Cuota_tb.Text = Convert.ToString(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()));
                    descripcion_tb.Text = "Pago #" + Convert.ToString(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString())) + " a los " + DateTime.Now.Day + " dias" + " del Mes " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year;
                    pagar_btn.Enabled = true;
                    monto_tb.Enabled = true;
                    monto_tb.Text = contratos_dgv.CurrentRow.Cells[2].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Ya pago ese contrato este mes", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ese contrato ya Expiró", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void Pagar_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            if (Convert.ToDouble(monto_tb.Text) == Convert.ToDouble(contratos_dgv.CurrentRow.Cells[2].Value.ToString()))
            {
                if (descripcion_tb.Text != " " || monto_tb.Text != " ")
                {
                    ingreso.NuevoPago(contratos_dgv.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(Cuota_tb.Text), DateTime.Now, Convert.ToDouble(monto_tb.Text), descripcion_tb.Text);
                    mod.BitacoraModulo("Pago Cliente", 7, "Pago Recibido del Cliente", cliente_dgv.CurrentRow.Cells[0].Value.ToString(), "N/A", "N/A", "N/A", "N/A");
                    descripcion_tb.Clear();
                    monto_tb.Clear();
                    pagar_btn.Enabled = false;
                    descripcion_tb.Enabled = false;
                    monto_tb.Enabled = false;
                    Cuota_tb.Clear();

                }
                else
                {
                    MessageBox.Show("Rellene los datos necesarios","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
            
            else
            {
                MessageBox.Show("Ingrese el monto mensual en cual acordo a pagar el contrato : L." + contratos_dgv.CurrentRow.Cells[2].Value.ToString(),"INFORMACION",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void Cliente_dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            consulto.CargadgvDatosContrato(contratos_dgv, cliente_dgv.CurrentRow.Cells[0].Value.ToString());

            descripcion_tb.Clear();
            monto_tb.Clear();
            pagar_btn.Enabled = false;
            descripcion_tb.Enabled = false;
            monto_tb.Enabled = false;
            Cuota_tb.Clear();

        }
    }
}
