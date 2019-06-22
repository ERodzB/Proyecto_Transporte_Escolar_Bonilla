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
        public string mensaje = "";

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

        //Ingresar Nuevo Cliente
        public void NuevoCliente(string id, string nom, string dir, string tel, string correo)
        {
            try
            {
                cmd = new SqlCommand("NuevoCliente", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Cliente", id);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", nom);
                cmd.Parameters.AddWithValue("@Direccion_Cliente", dir);
                cmd.Parameters.AddWithValue("@Telefono_Cliente", tel);
                cmd.Parameters.AddWithValue("@Correo_Cliente", correo);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ex.ToString());
            }

            mensaje = "Datos del Cliente guardados con Éxito"; 
        }

        //Ingresar Nuevo Contrato
        public void NuevoContrato(string cod, string cli, int tipo, DateTime fechai, double monto, DateTime fechaf)
        {
            try
            {
                cmd = new SqlCommand("NuevoContrato", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Contrato", cod);
                cmd.Parameters.AddWithValue("@Cliente_Contrato", cli);
                cmd.Parameters.AddWithValue("@Tipo_Contrato", tipo);
                cmd.Parameters.AddWithValue("@Fecha_Inicio_Contrato", fechai);
                cmd.Parameters.AddWithValue("@Monto_Contrato", monto);
                cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fechaf);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            mensaje = "Contrato guardado con Éxito";
        }

        //Ingresar Nueva Ruta
        public void NuevaRuta(string cod, string nom, string desc, string contrato)
        {
            try
            {
                cmd = new SqlCommand("NuevaRuta", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Ruta", cod);
                cmd.Parameters.AddWithValue("@Nombre_Ruta", nom);
                cmd.Parameters.AddWithValue("@Descripcion_Ruta", desc);
                cmd.Parameters.AddWithValue("@Codigo_Contrato", contrato);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        //Asignar Horarios y Vehiculos a las Rutas
        public void AsignarHoraVeh(string cod, string mat, string horas, string horae) 
        {
            try
            {
                cmd = new SqlCommand("AsignarHoraVeh", conexionBD); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Ruta", cod);
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", mat);
                cmd.Parameters.AddWithValue("@Horario_Salida", horas);
                cmd.Parameters.AddWithValue("@Horario_Entrada", horae);  
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
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
