﻿using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class consultar_clientes : Form
    {
        Consultar con = new Consultar();
        public consultar_clientes()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (cbConsulta.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una opcion del menú", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbConsulta.SelectedItem.ToString() == "Clientes")
                {
                    con.consultaclientes(dgvConsultaU, "Clientes");
                }
                if (cbConsulta.SelectedItem.ToString() == "Contratos por Cliente")
                {
                    con.consultaclientes(dgvConsultaU, "Contratos por Cliente");
                }

            }
        }

        private void Consultar_clientes_Load(object sender, EventArgs e)
        {

        }
    }
}
