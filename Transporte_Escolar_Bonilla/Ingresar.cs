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

        public void NuevoEmpleado(string id, string nom, DateTime fecha, string genero, string tel, string correo, string dir, int puesto, double salario)
        {
            try
            {
                cmd = new SqlCommand("NuevoEmpleado", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@identidad", id);
                cmd.Parameters.AddWithValue("@Nombr", nom);
                cmd.Parameters.AddWithValue("@FNacimiento", fecha);
                cmd.Parameters.AddWithValue("@Genero", genero);
                cmd.Parameters.AddWithValue("@Telefono", tel);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Direccion",dir);
                cmd.Parameters.AddWithValue("@Puesto", puesto);
                cmd.Parameters.AddWithValue("@Salario", salario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            mensaje = "Datos del Cliente guardados con Éxito";
        }

        //Ingresar Nuevo Contrato
        public void NuevoContrato(string anio, string nomcli, string idcli, int tipo, DateTime fechai, double monto, DateTime fechaf, double montom, int meses, string ser, double ant, string pago)
        {
            try
            {
                cmd = new SqlCommand("NuevoContrato", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Anio_Contrato", anio);
                cmd.Parameters.AddWithValue("@Nombre_Cliente_Contrato", nomcli); 
                cmd.Parameters.AddWithValue("@Id_Cliente_Contrato", idcli); 
                cmd.Parameters.AddWithValue("@Tipo_Contrato", tipo);
                cmd.Parameters.AddWithValue("@Fecha_Inicio_Contrato", fechai);
                cmd.Parameters.AddWithValue("@Monto_Contrato", monto);
                cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fechaf);
                cmd.Parameters.AddWithValue("@Monto_Mensual", montom);
                cmd.Parameters.AddWithValue("@Cuotas_Mensuales", meses);
                cmd.Parameters.AddWithValue("@Servicio", ser);
                cmd.Parameters.AddWithValue("@Anticipo", ant);
                cmd.Parameters.AddWithValue("@Tipo_Pago", pago);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            mensaje = "Contrato guardado con Éxito";
        }

        //Vincular Ruta con Contrato
        public void RutaContrato(string cod, string parada, string anio, string nomcli)
        {
            try
            {
                cmd = new SqlCommand("RutaContrato", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Ruta", cod);
                cmd.Parameters.AddWithValue("@Parada_Contrato", parada);
                cmd.Parameters.AddWithValue("@Anio_Contrato", anio);
                cmd.Parameters.AddWithValue("@Nombre_Cliente_Contrato", nomcli);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        //Actualizar Pasajeros
        public void Pasajeros(string cod, string veh, string horario)
        {
            try
            {
                cmd = new SqlCommand("Pasajeros", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Ruta", cod);
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", veh);
                cmd.Parameters.AddWithValue("@Horario", horario);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }


        //Ingresar Nueva Ruta
        public void NuevaRuta(string cod, string nom, string desc, string tipor)
        {
            try
            {
                cmd = new SqlCommand("NuevaRuta", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Ruta", cod);
                cmd.Parameters.AddWithValue("@Nombre_Ruta", nom);
                cmd.Parameters.AddWithValue("@Descripcion_Ruta", desc);
                cmd.Parameters.AddWithValue("@Tipo_Ruta", tipor);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }

        //Asignar Horarios y Vehiculos a las Rutas
        public void AsignarHoraVeh(string cod, string mat, string horas, string horae, int pa) 
        {
            try
            {
                cmd = new SqlCommand("AsignarHoraVeh", conexionBD); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Ruta", cod);
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", mat);
                cmd.Parameters.AddWithValue("@Horario_Salida", horas);
                cmd.Parameters.AddWithValue("@Horario_Entrada", horae);
                cmd.Parameters.AddWithValue("@Pasajeros", pa);
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
