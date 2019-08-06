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
    public partial class contrato_panel : Form
    {
        Estetica estetics = new Estetica();
        public static string codc, nombrecli, fechaini, monto, fechafin, estado;
        public int x = 0;

        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea Modificar los contratos de este Cliente?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Modificar_Datos_Contrato moddato = new Modificar_Datos_Contrato();
                estetics.AbrirFormularios(moddato, contratos_panel); 
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSeleccionar.Enabled = true;
        }

        private void Contratos_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvContrato_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            codc = dgvContrato.CurrentRow.Cells[0].Value.ToString();
            nombrecli = dgvContrato.CurrentRow.Cells[1].Value.ToString();
            btnSeleccionar.Enabled = true;
        }

        public contrato_panel()
        {
            InitializeComponent();
        }
        

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Modificar_Contrato_Load(object sender, EventArgs e)
        {
            x = 0;

            Consultar con = new Consultar();

            con.CargadgvContrato(dgvContrato);
            codc = null;
            nombrecli = null;
            fechaini = null;
            monto = null;
            fechafin = null;
            estado = null;
        }

        private void DgvContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {                            

        }

    }
}
