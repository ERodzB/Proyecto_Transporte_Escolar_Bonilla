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

        public void ModificarClientes(string id ,string nombre, string direccion, string telfono, string correo)
        {
            try
            {
                cmd = new SqlCommand("ModificarCliente", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Cliente", id);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", nombre);
                cmd.Parameters.AddWithValue("@Direccion_Cliente", direccion);
                cmd.Parameters.AddWithValue("@Telefono_Cliente", telfono);
                cmd.Parameters.AddWithValue("@Correo_Cliente", correo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha Modificado correctamente el cliente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void ModificarContrato(string id, double monto, DateTime fechafin, int estado)
        {
            
            try
            {
                cmd = new SqlCommand("ModificarContrato", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Contrato", id);
                cmd.Parameters.AddWithValue("@Monto_Contrato", monto);
                cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fechafin);
                cmd.Parameters.AddWithValue("@Estado_Contrato", estado);                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha Modificado correctamente el Contrato");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public void ModificarHorario(string Codigo_Ruta, string Codigo_Vehiculo,string Horario_Salida,string Horario_Entrada, DateTime Horario_Salida_Nuevo, DateTime Horario_Entrada_Nuevo,string Decision)
        {
            try
            {
                cmd = new SqlCommand("Mantenimiento_Horarios", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Ruta", Codigo_Ruta);
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", Codigo_Vehiculo);
                cmd.Parameters.AddWithValue("@Horario_Salida", Horario_Salida);
                cmd.Parameters.AddWithValue("@Horario_Entrada", Horario_Entrada);
                cmd.Parameters.AddWithValue("@Horario_Entrada_Nuevo", Horario_Entrada_Nuevo);
                cmd.Parameters.AddWithValue("Horario_Salida_Nuevo", Horario_Salida_Nuevo);
                cmd.Parameters.AddWithValue("@Decision", Decision);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha "+Decision+" correctamente el Horario");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
