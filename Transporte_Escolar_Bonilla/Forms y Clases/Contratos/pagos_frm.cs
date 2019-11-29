using System;
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

            Cuota_tb.ShortcutsEnabled = false;
            descripcion_tb.ShortcutsEnabled = false;
            monto_tb.ShortcutsEnabled = false;
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
            if (contratos_dgv.Rows.Count != 0)
            {
                if (contratos_dgv.CurrentRow.Cells[9].Value.ToString().Equals("Vigente"))
                {
                    if (contratos_dgv.CurrentRow.Cells[1].Value.ToString().Equals("Temporal"))
                    {
                        if (DateTime.Now >= Convert.ToDateTime(contratos_dgv.CurrentRow.Cells[6].Value.ToString()).AddMonths(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()) - 1) && DateTime.Now < Convert.ToDateTime(contratos_dgv.CurrentRow.Cells[6].Value.ToString()).AddMonths(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()) + 1))
                        {

                            Cuota_tb.Text = Convert.ToString(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()));
                            descripcion_tb.Text = "Pago #" + Convert.ToString(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString())) + " a los " + DateTime.Now.Day + " días" + " del Mes " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year;
                            pagar_btn.Enabled = true;
                            monto_tb.Enabled = true;
                            monto_tb.Text = contratos_dgv.CurrentRow.Cells[2].Value.ToString();


                        }
                        else
                        {
                            MessageBox.Show("El pago de este mes ya fue cancelado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        if (consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()) == 1)
                        {
                            Cuota_tb.Text = Convert.ToString(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString()));
                            descripcion_tb.Text = "Pago de Viaje" + Convert.ToString(consulto.NumeroCuota(contratos_dgv.CurrentRow.Cells[0].Value.ToString())) + " a los " + DateTime.Now.Day + " días" + " del Mes " + DateTime.Now.ToString("MMMM") + " " + DateTime.Now.Year;
                            pagar_btn.Enabled = true;
                            monto_tb.Enabled = true;
                            monto_tb.Text = contratos_dgv.CurrentRow.Cells[7].Value.ToString();
                        }
                        else
                        {
                            MessageBox.Show("El pago de ese viaje ya fue CANCELADO", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Ese contrato ya Expiró", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void Pagar_btn_Click(object sender, EventArgs e)
        {
            Ingresar ingreso = new Ingresar();
            if (monto_tb.Text.Trim() != String.Empty)
            {
                if (Convert.ToDouble(monto_tb.Text) == Convert.ToDouble(contratos_dgv.CurrentRow.Cells[2].Value.ToString()) || Convert.ToDouble(monto_tb.Text) == Convert.ToDouble(monto_tb.Text = contratos_dgv.CurrentRow.Cells[7].Value.ToString()))
                {
                    if (descripcion_tb.Text.Trim().Length != 0 || monto_tb.Text.Trim().Length != 0)
                    {
                        if (contratos_dgv.CurrentRow.Cells[1].Value.ToString().Equals("Temporal"))
                        {
                            ingreso.NuevoPago(contratos_dgv.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(Cuota_tb.Text), Convert.ToDouble(monto_tb.Text), descripcion_tb.Text);
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

                            ingreso.NuevoPago(contratos_dgv.CurrentRow.Cells[0].Value.ToString(), 1, Convert.ToDouble(monto_tb.Text), descripcion_tb.Text);
                            mod.BitacoraModulo("Pago Cliente", 7, "Pago Recibido del Cliente", cliente_dgv.CurrentRow.Cells[0].Value.ToString(), "N/A", "N/A", "N/A", "N/A");
                            descripcion_tb.Clear();
                            monto_tb.Clear();
                            pagar_btn.Enabled = false;
                            descripcion_tb.Enabled = false;
                            monto_tb.Enabled = false;
                            Cuota_tb.Clear();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Ingrese los datos necesarios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                else
                {
                    if (contratos_dgv.CurrentRow.Cells[1].Value.ToString().Equals("Temporal"))
                    {
                        MessageBox.Show("Ingrese el monto mensual acordado a pagar en el contrato : L." + contratos_dgv.CurrentRow.Cells[2].Value.ToString(), "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        monto_tb.Clear();
                        monto_tb.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el monto mensual acordado a pagar en el contrato : L." + contratos_dgv.CurrentRow.Cells[7].Value.ToString(), "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        monto_tb.Clear();
                        monto_tb.Focus();
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el valor del Monto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                monto_tb.Clear();
                monto_tb.Focus();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }


        private void Cliente_dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (cliente_dgv.Rows.Count > 0)
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
}
