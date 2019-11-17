using System;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public partial class form_asignar_ruta : Form
    {
        Consultar consul = new Consultar();
        Ingresar ing = new Ingresar();
        Validar val = new Validar();
        Modificar MOD = new Modificar();

        public form_asignar_ruta()
        {
            InitializeComponent();
        }

        //Carga
        private void Form_asignar_ruta_Load(object sender, EventArgs e)
        {
            //Llenar Combobox de Vehiculos
            combveh.DataSource = consul.Combobox_Vehiculos();
            combveh.DisplayMember = "Codigo_vehiculo";
            combveh.SelectedIndex = -1;

            //Llenar ComboBox de Rutas
            combruta.DataSource = consul.Combobox_Rutas();
            combruta.DisplayMember = "Codigo_Ruta";
            combruta.SelectedIndex = -1;
        }

        //Se elige la Ruta
        private void Combruta_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Llenar ComboBox de Horario con Horario de la Ruta Seleccionada
            combhorario.DataSource = consul.Combobox_Horarios(combruta.Text);
            combhorario.DisplayMember = "Horarios";
            combhorario.SelectedIndex = -1;
        }

        //Se elige Vehiculo
        private void Combveh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se muestra descripcion en el lab
            consul.DescVehiculos(combveh.Text, lab1);
            lab1.Visible = true;
        }

        //Boton Asignar
        private void Botasignar_Click(object sender, EventArgs e)
        {
            int cont = 0;

            //Validar campos vacios
            if (combveh.SelectedIndex == -1)
                cont++;

            if (combruta.SelectedIndex == -1)
                cont++;

            if (combhorario.SelectedIndex == -1)
                cont++;

            if (cont > 0)
                MessageBox.Show("Debe seleccionar todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Verificar que el vehiculo elegido no tenga el horario de la ruta ya asignado

                //Para sacar una subcadena de un texto: Substring(Posicion donde inicia, Cantidad de caracteres que toma)

                if (val.validarHorariosVeh(combveh.Text, combhorario.Text.Substring(0, combhorario.Text.IndexOf(" "))) == 1)
                    MessageBox.Show("El Vehiculo ya realiza una ruta en el Horario seleccionado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DialogResult = MessageBox.Show("¿Está seguro de los datos ingresados?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (DialogResult == DialogResult.Yes)
                    {
                        ing.AsignarHoraVeh(combruta.Text, combveh.Text, combhorario.Text.Substring(0, combhorario.Text.IndexOf(" ")),
                                           combhorario.Text.Substring(combhorario.Text.IndexOf(" ") + 1, 6), 0);

                        MOD.BitacoraModulo("Asignacion Vehiculo - Ruta", 1, "Asignacion de Vehiculo a una ruta", combveh.Text, "N/A", "N/A", "N/A", "N/A");
                        MessageBox.Show("Ruta Asignada Con Éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Limpiar
                        lab1.Visible = false;

                        combveh.SelectedIndex = -1;
                        combruta.SelectedIndex = -1;
                        combhorario.SelectedIndex = -1;
                    }
                }

            }
        }
    }
}
