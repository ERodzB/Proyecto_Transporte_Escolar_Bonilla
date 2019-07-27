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
            consulto.CargadgvDatosContrato(contratos_dgv, cliente_dgv.CurrentRow.Cells[0].Value.ToString());
        }

        private void Contratos_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DateTime.Now>= Convert.ToDateTime(contratos_dgv.CurrentRow.Cells[6].Value.ToString()).AddMonths(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString())-1) && DateTime.Now< Convert.ToDateTime(contratos_dgv.CurrentRow.Cells[6].Value.ToString()).AddMonths(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString())+1))
            {
                Cuota_tb.Text = Convert.ToString(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()));
                monto_tb.Enabled = true;
                descripcion_tb.Enabled = true;
                pagar_btn.Enabled = true;

            }
            else
            {
                MessageBox.Show("Ya pago ese contrato este mes");
            }
            
        }

        private void Pagar_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            if(descripcion_tb.Text!=" " || monto_tb.Text!=" ")
            {
                ingreso.NuevoPago(contratos_dgv.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(Cuota_tb.Text), DateTime.Now, Convert.ToDouble(monto_tb.Text), descripcion_tb.Text);
                mod.BitacoraModulo("Pago Cliente", 7, "Pago Recibido del Cliente", cliente_dgv.CurrentRow.Cells[0].Value.ToString(), "N/A", "N/A", "N/A", "N/A");
                descripcion_tb.Clear();
                monto_tb.Clear();
                pagar_btn.Enabled = false;
                descripcion_tb.Enabled = false;
                monto_tb.Enabled = false;
               
            }
            else
            {
                MessageBox.Show("Rellene los datos necesarios");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
