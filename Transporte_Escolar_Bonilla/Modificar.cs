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
    class Modificar : ConexionBD
    {
        private SqlCommand cmd;
        public Modificar()
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
        public string CambiarContra(string Nombre_Usuario)
        {
            string nuevaContra = "<h2>Su nueva contraseña es: </h2>";
            try
            {
                
                cmd = new SqlCommand("CambioContrasena", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario);
                nuevaContra += (string)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }


            return nuevaContra;
        }
        public void ModificarUsuario(string Codigo_Empleado, string Nombre_Usuario,string Contrasena_Usuario, int Perfil_Acceso)
        {
            try
            {
                cmd = new SqlCommand("ModificarUsuario", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Empleado", Codigo_Empleado);
                cmd.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario);
                cmd.Parameters.AddWithValue("@Contrasena_Usuario", Contrasena_Usuario);
                cmd.Parameters.AddWithValue("@Perfil_Acceso", Perfil_Acceso);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha Modificado correctamente el usuario");

            }
            catch(Exception ex)
            {
                Validar valido = new Validar();
                if (valido.validarUsuario(Nombre_Usuario) == 1)
                    MessageBox.Show("Ya existe ese usuario");
                else
                    MessageBox.Show("Error" + ex);

            }
        }

        public void ModificarPerfiles(int Codigo_Perfil,int Nivel_Acceso, string Nombre_Perfil, string Descripcion_Perfil)
        {
            try
            {
                cmd = new SqlCommand("ModificarPerfil", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Perfil", Codigo_Perfil);
                cmd.Parameters.AddWithValue("@Nivel_Acceso", Nivel_Acceso);
                cmd.Parameters.AddWithValue("@Nombre_Perfil", Nombre_Perfil);
                cmd.Parameters.AddWithValue("@Descripcion_Perfil", Descripcion_Perfil);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha Modificado correctamente el perfil");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
