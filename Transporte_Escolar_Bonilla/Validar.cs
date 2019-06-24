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
    public class Validar : ConexionBD
    {
        private SqlCommand cmd;
        private SqlDataReader Reader;
        int x = 0;
        public Validar()
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
        public int validarInicioSession (string Nombre_Usuario, string Correo)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("VerificarCorreo", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            return x;
        }
        public int validarUsuario_Empleado(string Codigo_Empleado)
        {
            x= 0;
            try
            {
                cmd = new SqlCommand("verificar_empleado_usuario", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Empleado", Codigo_Empleado);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            return x; 
        }
        public int validarUsuario(string Nombre_Usuario)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("VerificarUsuario", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return x;
        }

        public int validarEmpleado(string Codigo_Empleado)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("VerificarEmpleado", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Codigo_Empleado", Codigo_Empleado);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            return x;
        }
        public int validarPerfil(string Nombre_Perfil)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("VerificarPerfil", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Nombre_Perfil", Nombre_Perfil);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return x;
        }

        public int VerificarCliente(string identidad)
        {
            int x = 0;
            try
            {
                cmd = new SqlCommand("VerificarCliente", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Codigo_Cliente", identidad);
                x = (int)cmd.ExecuteScalar();
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            return x;
            
        }
    }
}
