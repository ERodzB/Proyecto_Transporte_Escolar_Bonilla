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
                MessageBox.Show("Desconectado: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);   
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
                MessageBox.Show("ERROR: "+ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mensaje = "Datos del Cliente guardados con Éxito"; 
        }

        public void NuevoEmpleado(string id, string nom, DateTime fecha, int genero, string tel, string correo, string dir, int puesto, double salario,string Lic, DateTime fechaLic, int tipolic)
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
                cmd.Parameters.AddWithValue("@Licencia", Lic);
                cmd.Parameters.AddWithValue("@FechaVLic", fechaLic);
                cmd.Parameters.AddWithValue("@tipolic", tipolic);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mensaje = "Datos del Cliente guardados con Éxito";
        }

        //Ingresar Nuevo Contrato
        public void NuevoContrato(string anio, string nomcli, string idcli, int tipo, DateTime fechai, double monto, DateTime fechaf, double montom, int meses, string ser, double ant, int pago)
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
                MessageBox.Show("ERROR: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERROR: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERROR: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("ERROR: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Nueva Unidad de Transporte
        public void NuevaUnidad(string mat, int tipo, int anioveh, string marca, string modelo, int cap, int trans, int gas, string color, int anioad,
                                int estado, DateTime emipermiso, DateTime vencpermiso)
        {
            try
            {
                cmd = new SqlCommand("NuevaUnidad", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", mat);
                cmd.Parameters.AddWithValue("@Tipo_Vehiculo", tipo);
                cmd.Parameters.AddWithValue("@Anio_Vehiculo", anioveh);
                cmd.Parameters.AddWithValue("@Marca_Vehiculo", marca);
                cmd.Parameters.AddWithValue("@Modelo_Vehiculo", modelo);
                cmd.Parameters.AddWithValue("@Capacidad_Vehiculo", cap);
                cmd.Parameters.AddWithValue("@Transmision_Vehiculo", trans);
                cmd.Parameters.AddWithValue("@Combustible_Vehiculo", gas);
                cmd.Parameters.AddWithValue("@Color_Vehiculo", color);
                cmd.Parameters.AddWithValue("@Anio_Adquisicion", anioad);
                cmd.Parameters.AddWithValue("@Estado_Vehiculo", estado);
                cmd.Parameters.AddWithValue("@Emision_Permiso", emipermiso);
                cmd.Parameters.AddWithValue("@Vencimiento_Permiso", vencpermiso); 
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mensaje = "Vehículo guardado con Éxito";
        }

        //Nuevo Mantenimiento
        public void NuevoMantenimiento(int tipo, DateTime fecha, string veh, double costo)
        {
            try
            {
                cmd = new SqlCommand("NuevoMantenimiento", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tipo_Mantenimiento", tipo);
                cmd.Parameters.AddWithValue("@Fecha_Mantenimiento", fecha);
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", veh);
                cmd.Parameters.AddWithValue("@Costo_Mantenimiento", costo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mensaje = "Mantenimiento ingresado con Éxito";
        }


        //Ingreso de Nuevo Tipo de Mantenimiento
        public void NuevoTipoMant(string nom, string desc)
        {
            try
            {
                cmd = new SqlCommand("NuevoTipoMantenimiento", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nom);
                cmd.Parameters.AddWithValue("@descripcion", desc);

                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Usuario o Contraseña Inválidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Se ha Ingresado correctamente el usuario", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Se ha creado correctamente el Perfil", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NuevoPago(string Codigo_Contrato, int Numero_Cuota, DateTime Fecha_Recibo, Double Monto, string Descripcion_Recibo)
        {
            try
            {
                cmd = new SqlCommand("NuevoPago", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Contrato", Codigo_Contrato);
                cmd.Parameters.AddWithValue("@Numero_Cuota", Numero_Cuota);
                cmd.Parameters.AddWithValue("@Fecha_Recibo", Fecha_Recibo);
                cmd.Parameters.AddWithValue("@Monto", Monto);
                cmd.Parameters.AddWithValue("@Descripcion_Recibo", Descripcion_Recibo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha realizado el pago","INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarContratos()
        {
            try
            {
                cmd = new SqlCommand("VencimientoContratos", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
