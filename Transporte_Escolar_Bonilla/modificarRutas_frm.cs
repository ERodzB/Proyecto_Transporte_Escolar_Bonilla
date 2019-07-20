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
    public partial class modificarRutas_frm : Form
    {
        Consultar consulto = new Consultar();
        Ingresar ingreso = new Ingresar();
        Modificar modifico = new Modificar();
        DataTable table;
        int cont = 0;
        public modificarRutas_frm()
        {
            InitializeComponent();
        }

        private void Realizar_btn_Click(object sender, EventArgs e)
        {
            if (agregar_rb.Checked == true)
            {
                ingreso.AsignarHoraVeh(rutasModificar_cmb.Text, vehiculo_cmb.Text, horaSalida_dtp.Text, llegadaHorario_dtp.Text, 0);
                Horario_cmb.DataSource = consulto.Combobox_Horarios(rutasModificar_cmb.Text);
                Horario_cmb.DisplayMember = "Horarios";

            }
            if (eliminarHorario_rb.Checked == true)
            {
                modifico.ModificarHorario(rutasModificar_cmb.Text," ",Horario_cmb.Text.Substring(0, Horario_cmb.Text.IndexOf(" ")),Horario_cmb.Text.Substring(Horario_cmb.Text.IndexOf(" ")+1),Convert.ToDateTime("5:00 AM"), Convert.ToDateTime("5:00 AM"), "Eliminar");
                Horario_cmb.DataSource = consulto.Combobox_Horarios(rutasModificar_cmb.Text);
                Horario_cmb.DisplayMember = "Horarios";
            }
            if (modiHorario_rb.Checked == true)
            {
                
                modifico.ModificarHorario(rutasModificar_cmb.Text, vehiculo_cmb.Text,Horario_cmb.Text.Substring(0, Horario_cmb.Text.IndexOf(" ")),Horario_cmb.Text.Substring(Horario_cmb.Text.IndexOf(" ")+1), horaSalida_dtp.Value, llegadaHorario_dtp.Value,"Modificar");
               
                Horario_cmb.DataSource = consulto.Combobox_Horarios(rutasModificar_cmb.Text);
                Horario_cmb.DisplayMember = "Horarios";
            }
        }

        private void ModificarRutas_frm_Load(object sender, EventArgs e)
        {
            

            rutasModificar_cmb.DataSource = consulto.Combobox_Rutas();
            rutasModificar_cmb.DisplayMember = "Codigo_Ruta";
            rutasModificar_cmb.SelectedIndex = -1;

            horaSalida_dtp.Format = DateTimePickerFormat.Custom;
            horaSalida_dtp.CustomFormat = "h:mm tt";
            horaSalida_dtp.ShowUpDown = true;
            horaSalida_dtp.ShowCheckBox = true; //Aparece un cheque
            horaSalida_dtp.Checked = false; //Deschequearlo

            llegadaHorario_dtp.Format = DateTimePickerFormat.Custom;
            llegadaHorario_dtp.CustomFormat = "h:mm tt";
            llegadaHorario_dtp.ShowUpDown = true;
            llegadaHorario_dtp.ShowCheckBox = true; //Aparece un cheque
            llegadaHorario_dtp.Checked = false; //Deschequearlo
        }

        private void RutasModificar_cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cont >= 3)
            {
                vehiculo_cmb.DataSource = consulto.Combobox_Vehiculos();
                vehiculo_cmb.DisplayMember = "Codigo_vehiculo";
                vehiculo_cmb.SelectedIndex = -1;
                Horario_cmb.Enabled = true;
                Horario_cmb.DataSource = consulto.Combobox_Horarios(rutasModificar_cmb.Text);
                Horario_cmb.DisplayMember = "Horarios";
                Horario_cmb.SelectedIndex = -1;
                
                if(cont >= 3 && eliminarHorario_rb.Checked == true && Horario_cmb.Items.Count == 0)
                {
                    MessageBox.Show("No hay horarios en esa ruta para eliminar, porfavor escoja una que si", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    no_rb.Checked = true;
                }
                if (cont >= 3 && modiHorario_rb.Checked == true && Horario_cmb.Items.Count==0)
                {
                    MessageBox.Show("La ruta escogida para modificar no tiene Horarios, porfavor escoja una que si", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    no_rb.Checked = true;                                       
                }
                else
                {
                    table = consulto.Combobox_VehiculosRH(rutasModificar_cmb.Text, Horario_cmb.Text);
                    if (table.Rows.Count == 0 || eliminarHorario_rb.Checked==true)
                    {
                        vehiculo_cmb.SelectedIndex = -1;
                    }
                    else
                    {
                        
                        vehiculo_cmb.Text = table.Rows[0][0].ToString();
                    }
                }
            }
                
            cont++;
        }

        private void EliminarHorario_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (eliminarHorario_rb.Checked == true)
            {
               
                horario_lbl.Text = "Horario a Eliminar";
                vehiculo_lbl.Visible = false;
                if (Horario_cmb.Items.Count != 0)
                {
                    Horario_cmb.Visible = true;
                    horario_lbl.Visible = true;
                    entradaHorario_lbl.Visible = false;
                    salidaHorario_lbl.Visible = false;
                    horaSalida_dtp.Visible = false;
                    llegadaHorario_dtp.Visible = false;
                    vehi_lbl.Visible = false;
                    vehiculo_cmb.Visible = false;
                    vehiculo_lbl.Visible = false;
                }
                else
                {
                    MessageBox.Show("No hay Horarios para eliminar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    no_rb.Checked = true;
                }
            }
            
        }

        private void ModiHorario_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (modiHorario_rb.Checked == true)
            {
                if (Horario_cmb.Items.Count != 0)
                {
                    vehiculo_cmb.DataSource = consulto.Combobox_Vehiculos();
                    vehiculo_cmb.DisplayMember = "Codigo_vehiculo";
                    vehiculo_cmb.SelectedIndex = -1;
                    
                    Horario_cmb.Visible = true;
                    horario_lbl.Visible = true;
                    horario_lbl.Text = "Horario a Modificar";
                    entradaHorario_lbl.Visible = true;
                    salidaHorario_lbl.Visible = true;
                    horaSalida_dtp.Visible = true;
                    llegadaHorario_dtp.Visible = true;
                    vehiculo_cmb.Visible = true;
                    vehi_lbl.Visible = true;
                    if (cont >= 3)
                    {
                        table = consulto.Combobox_VehiculosRH(rutasModificar_cmb.Text, Horario_cmb.Text);

                        if (table.Rows.Count == 0)
                        {
                            vehiculo_cmb.SelectedIndex = -1;
                        }
                        else
                        {
                            vehiculo_cmb.Text = table.Rows[0][0].ToString();
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La ruta escogida para modificar no tiene Horarios, porfavor escoja una que si","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    no_rb.Checked = true;
                }   
            }
        }

        private void Agregar_rb_CheckedChanged(object sender, EventArgs e)
        {
            
                if (agregar_rb.Checked == true && rutasModificar_cmb.SelectedIndex != -1)
                {
                    consulto.DescVehiculos(vehiculo_cmb.Text, vehiculo_lbl);
                vehiculo_cmb.SelectedIndex = -1;
                    horaSalida_dtp.ResetText();
                   llegadaHorario_dtp.ResetText();
                    Horario_cmb.Visible = false;
                    horario_lbl.Visible = false;
                    entradaHorario_lbl.Visible = true;
                    salidaHorario_lbl.Visible = true;
                    horaSalida_dtp.Visible = true;
                    llegadaHorario_dtp.Visible = true;
                    vehiculo_cmb.Visible = true;
                   // vehiculo_lbl.Visible = true;
                    vehi_lbl.Visible = true;
                }          
            else
            {
                if (no_rb.Checked==false && agregar_rb.Checked==true) {
                    MessageBox.Show("Escoja una ruta para agregar un horario");
                    no_rb.Checked = true;
                }
            }
        }

        private void No_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (no_rb.Checked == true)
            {
                Horario_cmb.Visible = false;
                horario_lbl.Visible = false;
                entradaHorario_lbl.Visible = false;
                salidaHorario_lbl.Visible = false;
                horaSalida_dtp.Visible = false;
                llegadaHorario_dtp.Visible = false;
                vehiculo_cmb.Visible = false;
                vehiculo_lbl.Visible = false;
                vehi_lbl.Visible = false;
            }
        }

        private void RutasModificar_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Horario_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cont >= 3 && modiHorario_rb.Checked==true && eliminarHorario_rb.Checked==false)
            {
               
                table = consulto.Combobox_VehiculosRH(rutasModificar_cmb.Text, Horario_cmb.Text);

       
                if (table.Rows.Count==0)
                {
                    vehiculo_cmb.SelectedIndex = -1;

                }
                else
                {
                    horaSalida_dtp.Value = Convert.ToDateTime(Horario_cmb.Text.Substring(0, Horario_cmb.Text.IndexOf(" ")));
                    llegadaHorario_dtp.Value = Convert.ToDateTime(Horario_cmb.Text.Substring(Horario_cmb.Text.IndexOf(" ") + 1));
                    vehiculo_cmb.Text = table.Rows[0][0].ToString();
                }
            }
        }

        private void Vehiculo_cmb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (no_rb.Checked == false)
            {
                consulto.DescVehiculos(vehiculo_cmb.Text, vehiculo_lbl);

                vehiculo_lbl.Visible = true;
            }
        }
    }
}
