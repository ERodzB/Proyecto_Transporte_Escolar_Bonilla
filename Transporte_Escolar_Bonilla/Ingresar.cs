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
    class Ingresar : ConexionBD
    {
        private SqlCommand cmd;
        public Ingresar()
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

        public void login(string Codigo, string password)
        {

            try
            {
                cmd = new SqlCommand("Entrar_Sistema", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_Usuario", Codigo);
                cmd.Parameters.AddWithValue("@Contrasena_Usuario", password);
                //Acceso Tomara el valor de el Nivel de Autoridad que tendra el usuario sobre el sistema, declarada como estatica mas arriba
                Acceso = (int)cmd.ExecuteScalar();   //Resultado de la consulta almacenado a una variable 
            }
            catch (Exception ex)
            {
                if (Acceso == 0)
                {
                    MessageBox.Show("Error no se encontro el usuario");
                }
                else
                    MessageBox.Show("Error" + ex);
            }
         }
        public void NuevoUsuario(string Codigo_Usuario, string Nombre_Usuario, string contra_usuario, int Codigo_Perfil)
        {
            try
            {
                cmd = new SqlCommand("NuevoUsuario", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Empleado", Codigo_Usuario);
                cmd.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario);
                cmd.Parameters.AddWithValue("@Contrasena_Usuario", contra_usuario);
                cmd.Parameters.AddWithValue("@Codigo_Perfil", Codigo_Perfil);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha Ingresado correctamente el usuario");
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void NuevoPerfil(int Nivel_Acceso, string Nombre_Perfil,  string Descripcion_Perfil)
        {
            try
            {
                cmd = new SqlCommand("CrearPerfil", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nivel_Acceso", Nivel_Acceso);
                cmd.Parameters.AddWithValue("@Nombre_Perfil", Nombre_Perfil);
                cmd.Parameters.AddWithValue("@Descripcion_Perfil", Descripcion_Perfil);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha creado correctamente el Perfil");
            }
             catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

    }
}
