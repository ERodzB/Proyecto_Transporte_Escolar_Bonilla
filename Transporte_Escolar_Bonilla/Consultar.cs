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
        public int lic;

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
        public DataTable Combobox_TipoEvento()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboTipoEventos", conexionBD);
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
        public DataTable ComboboxGeneros()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("cargarGenero", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        public DataTable ComboboxMVehiculos()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxMVehiculos", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }
        public DataTable ComboboxTVehiculos()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxTVehiculos", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }
        public DataTable ComboboxEVehiculos()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxEVehiculos", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }
        public DataTable ComboboEncVehiculos()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboEncVehiculos", conexionBD);
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

        //Llenar Combobox de Estados
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
        //Llenar ComboBox de Empleados
        public DataTable Combobox_Empleados()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxEmpleados", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Llenar ComboBox de Horarios
        public DataTable Combobox_Horarios(string ruta)
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxHorarios", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.SelectCommand.Parameters.AddWithValue("@Codigo_Ruta", ruta);
            Adapter.Fill(table);
            return table;
        }

        //LLenar ComboBox Vehiculos segun Ruta y Horario
        public DataTable Combobox_VehiculosRH(string codr, string horario)
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxVehiculosRH", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.SelectCommand.Parameters.AddWithValue("@Codigo_Ruta", codr);
            Adapter.SelectCommand.Parameters.AddWithValue("@Horario", horario);
            Adapter.Fill(table);
            return table;
        }

        //Llenar Combobox Tipo de Vehiculo
        public DataTable Combobox_TipoVehiculo()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxTipoVeh", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table; 
        }

        //Llenar Combobox Tipo de Transmision
        public DataTable Combobox_TipoTrans()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxTipoTrans", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Llenar Combobox Tipo de Combustible
        public DataTable Combobox_TipoGas()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxTipoGas", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Llenar Combobox Estado del vehiculo
        public DataTable Combobox_EstadoVeh()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxEstadoVeh", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Llenar Combobox Tipo de Mantenimiento
        public DataTable Combobox_TipoMant()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxTipoMant", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Llenar Combobox Estado de Mantenimiento
        public DataTable Combobox_EstadoMant()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxEstadoMant", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }


        //Llenar ComboBox de Mantenimientos
        public DataTable Combobox_Mant()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxMant", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        //Consultar Datos Mantenimiento Seleccionado 
        public void DatosMantenimiento(int cod, TextBox nom, TextBox desc)
        {
            try
            {
                table = new DataTable();
                Adapter = new SqlDataAdapter("DatosMantenimiento", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@codigo", cod);
                Adapter.Fill(table);

                nom.Text = table.Rows[0][0].ToString();
                desc.Text = table.Rows[0][1].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Codigo que recibe: " + cod + "\n\nERROR: " + ex);
            }
        }

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
                Perfil_cmb.SelectedItem = table.Rows[0][2].ToString()+1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }
        public void BuscarEmpleado(String Codigo_Empleado, TextBox Nombre, ComboBox Genero, TextBox telefono,TextBox Correo, TextBox direccion
            ,TextBox salario, ComboBox puesto,TextBox licencia, DateTimePicker fecha)
        {
            try
            {

                table = new DataTable();
                Adapter = new SqlDataAdapter("BuscarEmpleado", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@Codigo_Empleado", Codigo_Empleado);
                Adapter.Fill(table);
                Nombre.Text = table.Rows[0][0].ToString();
                Genero.SelectedIndex = int.Parse(table.Rows[0][1].ToString())-1;
                telefono.Text = table.Rows[0][2].ToString();
                Correo.Text = table.Rows[0][3].ToString();
                direccion.Text = table.Rows[0][4].ToString();
                puesto.SelectedIndex = int.Parse(table.Rows[0][5].ToString()) - 1;
                salario.Text = table.Rows[0][6].ToString();
                licencia.Text = table.Rows[0][7].ToString();
                fecha.Text = table.Rows[0][8].ToString();
                lic =int.Parse( table.Rows[0][9].ToString());
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
        public void consultabitacora(DataGridView dgvConsulta, int consulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("dgvEventos", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@filtro", consulta);
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
        public void cargardvgvehiculo(DataGridView dgvConsulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("LLenarDVGvehiculos", conexionBD); //Buscar Informacion de que hace especificamente un adapter
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
        public void dvgdatosasignar(DataGridView dgvConsulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("DatosVehiculosSencillosAsignar", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void dvgdatosdevolver(DataGridView dgvConsulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("DatosVehiculosSencillosdevolver", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
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
        public void filtrarempleado(DataGridView dgvConsulta,int filtro)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("FiltrarDatosDVGEmpleados", conexionBD); //Buscar Informacion de que hace especificamente un adapter
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@puesto", filtro);
                Adapter.Fill(table);
                dgvConsulta.DataSource = table;
                MessageBox.Show("Carga de Datos Finalizada", "Carga exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public void filtrarvehiculos(DataGridView dgvConsulta, string tipo, string filtro)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); //Comando para almacenar la informacion de un select en un DGV
                Adapter = new SqlDataAdapter("filtrarvehiculos", conexionBD); //Buscar Informacion de que hace especificamente un adapter
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
        
        public void CargarInicioFinRuta(string Codigo_Ruta, TextBox Inicio_tb, TextBox Fin_tb)
        {
            try
            {
                table = new DataTable();
                Adapter = new SqlDataAdapter("InicioFinRuta", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.SelectCommand.Parameters.AddWithValue("@Codigo_Ruta", Codigo_Ruta);
                Adapter.Fill(table);
                Inicio_tb.Text = table.Rows[0][0].ToString();
                Fin_tb.Text = table.Rows[0][1].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public DataTable combox_tipo_pago()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxTipoPago", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }

        public int NumeroCuota(string Codigo_Contrato)
        {
            int nc = 0;

            try
            {
                cmd = new SqlCommand("TotalRecibosContratos", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Contrato", Codigo_Contrato);
                nc = (int)cmd.ExecuteScalar()+1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

            return nc;
        }


        public void CargadgvModVehiculos(DataGridView dgvContrato)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable(); Adapter = new SqlDataAdapter("CargaDgvModVehiculo", conexionBD);
                Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                Adapter.Fill(table);
                dgvContrato.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }


        public DataTable combox_mod_vehiculo()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboModVehiculo", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }
        public DataTable Notificaciones()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("Notificaciones", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
        }


        public void cargardvggenerarcotnrato(DataGridView dgvConsulta)
        {
            try
            {
                Consultar consultar = new Consultar();
                table = new DataTable();
                Adapter = new SqlDataAdapter("CargaGenerarContrato", conexionBD);
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

    }
}
