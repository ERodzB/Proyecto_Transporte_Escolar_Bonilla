using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public class Consultar : ConexionBD
    {
        private SqlDataAdapter Adapter;
        private DataTable table;
        private SqlCommand cmd;

        public Consultar()
        {
            try
            {
                conexionBD.Open();
            }

            catch (Exception ex) //Tira error en caso que el try no funcione correctamente
            {
                MessageBox.Show("Desconectado: " + ex.ToString());
            }
        }

        //Llenar Combobox de Contratos
        public DataTable Combobox_Contrato()  
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxContratos", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table); 
            return table;
        }

        //Llenar Combobox de Tipo de Contrato
        public DataTable Combobox_TipoContrato()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxTipoContrato", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table; 
        }
        public DataTable ComboboxPuestos()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxPuesto", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        public DataTable combox_Clientes()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxClientes", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }
        //Llenar Combobox de Clientes
        public DataTable combox_estados()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxEstados", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Llenar Combobox de Vehiculos
        public DataTable Combobox_Vehiculos()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxVehiculos", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Colocar Descripcion de Vehiculos
        public void DescVehiculos(string cod, Label desc)
        {
            try
            {
                cmd = new SqlCommand("DescVehiculos", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", cod);
                desc.Text = (string)cmd.ExecuteScalar(); 
                //table = new DataTable();
                //Adapter = new SqlDataAdapter("DescVehiculos", conexionBD);
                //Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                //Adapter.SelectCommand.Parameters.AddWithValue("@Codigo_Vehiculo", cod);
                //Adapter.Fill(table);
                //desc.Text = table.Rows[0][0].ToString();  
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        //Llenar ComboBox de Rutas
        public DataTable Combobox_Rutas()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxRutas", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Llenar ComboBox de Horarios
        //public DataTable Combobox_Horarios(string ruta)
        //{
        //    table = new DataTable();
        //    Adapter = new SqlDataAdapter("ComboboxHorarios", conexionBD);
        //    Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    Adapter.SelectCommand.Parameters.AddWithValue("@Codigo_Ruta", ruta);  
        //    Adapter.Fill(table);
        //    return table;
        //}

        public DataTable llenarPerfiles()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("cargarPerfiles", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }
        public void BuscarUsuario(String Codigo_Empleado, TextBox Nombre_Usuario, TextBox Contrasena_Usuario, ComboBox Perfil_cmb)
        {
            try
            {
                table = new DataTable();
                Adapter = new SqlDataAdapter("BuscarUsuario", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@Codigo_Empleado", Codigo_Empleado);
                Adapter.Fill(table);
                Nombre_Usuario.Text = table.Rows[0][0].ToString();
                Contrasena_Usuario.Text = table.Rows[0][1].ToString();
                Perfil_cmb.SelectedItem = table.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        public void BuscarPerfiles(int Codigo_Perfil, ComboBox Nivel_Acceso, TextBox Nombre_Perfil, TextBox Descripcion_Perfil)
        {
            try
            {
                table = new DataTable();
                Adapter = new SqlDataAdapter("InfoPerfil", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("Codigo_Perfil", Codigo_Perfil);
                Adapter.Fill(table);
                Nivel_Acceso.SelectedIndex = Convert.ToInt32(table.Rows[0][0].ToString()) - 1;
                Nombre_Perfil.Text = table.Rows[0][1].ToString();
                Descripcion_Perfil.Text = table.Rows[0][2].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void consultasusuario(DataGridView dgvConsulta, string consulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("consultasusuario", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@TipoConsulta", consulta);
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void consultaclientes(DataGridView dgvConsulta, string consulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("consultaclientes", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@consultacliente", consulta);
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void consultarutas(DataGridView dgvConsulta, string consulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("consultarutas", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@consultacliente", consulta);
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void cargardvg(DataGridView dgvConsulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("LLenarDVG", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void cargardvgempleado(DataGridView dgvConsulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("DatosDVGEmpleados", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void filtrarcontrato(DataGridView dgvConsulta, string tipo,string filtro)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("filtrarcontratos", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@tipobusqueda", tipo);
                Adapter.SelectCommand.Parameters.AddWithValue("@filtro", filtro);
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public void CargarCliente(DataGridView dgvCargacliente, string Ident)
        {

            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("CargarCliente", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@Cod_Client", Ident);
                Adapter.Fill(table);
                dgvCargacliente.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public void CargadgvCliente(DataGridView dgvCliente)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); Adapter = new SqlDataAdapter("ConsultaUnicaCliente", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.Fill(table);
                dgvCliente.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public void CargadgvContrato(DataGridView dgvContrato)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); Adapter = new SqlDataAdapter("CargadgvContrato1", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.Fill(table);
                dgvContrato.DataSource = table;
                //MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public void CargadgvDatosContrato(DataGridView dgvContrato, string cod)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); Adapter = new SqlDataAdapter("CargadgvDatoContratoCliente", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@Cod_Cliente", cod);
                Adapter.Fill(table);
                dgvContrato.DataSource = table;
                //MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public DataTable combox_mod_contrato()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxEstados", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;            
            Adapter.Fill(table);
            return table;
        }

    }
}
