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

        //Llenar Combobox de Vehiculos
        public DataTable Combobox_Vehiculos()
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxVehiculos", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.Fill(table);
            return table;
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
        public DataTable Combobox_Horarios(string ruta)
        {
            table = new DataTable();
            Adapter = new SqlDataAdapter("ComboboxHorarios", conexionBD);
            Adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            Adapter.SelectCommand.Parameters.AddWithValue("@Codigo_Ruta", ruta);  
            Adapter.Fill(table);
            return table;
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
    }
}
