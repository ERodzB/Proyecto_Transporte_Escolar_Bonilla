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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }


            return nuevaContra;
        }
        public void ModificarUsuario(string Codigo_Empleado, string Nombre_Usuario, string Contrasena_Usuario, int Perfil_Acceso)
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
                MessageBox.Show("Se ha Modificado correctamente el usuario", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Validar valido = new Validar();
                if (valido.validarUsuario(Nombre_Usuario) == 1)
                    MessageBox.Show("Ya existe ese usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error" + ex);

            }
        }
        public void ModificarEmpleado(string id, string nom, int genero, string tel, string correo, string dir, int puesto, double salario, string Lic, DateTime fechaLic, int TLic)
        {
            try
            {
                cmd = new SqlCommand("ModificarEmpleado", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@identidad", id);
                cmd.Parameters.AddWithValue("@Nombr", nom);
                cmd.Parameters.AddWithValue("@Genero", genero);
                cmd.Parameters.AddWithValue("@Telefono", tel);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Direccion", dir);
                cmd.Parameters.AddWithValue("@Puesto", puesto);
                cmd.Parameters.AddWithValue("@Salario", salario);
                cmd.Parameters.AddWithValue("@Licencia", Lic);
                cmd.Parameters.AddWithValue("@FechaVLic", fechaLic);
                cmd.Parameters.AddWithValue("@tipolicencia", TLic);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, algo a salido mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }
        public void ModificarVAsigDevol(int Tipo,string Empleado,string Placa, int estado)
        {
            try
            {
                cmd = new SqlCommand("devolverasignarunidades", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tipo", Tipo);
                cmd.Parameters.AddWithValue("@empleado", Empleado);
                cmd.Parameters.AddWithValue("@placa", Placa);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, algo a salido mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }
        public void BitacoraModulo(string Evento, int tipo, string d1, string d2, string d3, string d4, string d5,string d6)
        {
            try
            {
                cmd = new SqlCommand("actualizarbitacora", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@desc", Evento);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@dato1", d1);
                cmd.Parameters.AddWithValue("@dato2", d2);
                cmd.Parameters.AddWithValue("@dato3", d3);
                cmd.Parameters.AddWithValue("@dato4", d4);
                cmd.Parameters.AddWithValue("@dato5", d5);
                cmd.Parameters.AddWithValue("@dato6", d6);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, algo ha salido mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("ERROR: " + ex.ToString());
            }
        }


        public void ModificarPerfiles(int Codigo_Perfil, int Nivel_Acceso, string Nombre_Perfil, string Descripcion_Perfil)
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
                MessageBox.Show("Se ha Modificado correctamente el perfil", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void ModificarClientes(string id, string nombre, string direccion, string telfono, string correo)
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

        public void ModificarContratoTemporal(string id, double montomensual, string servicio, DateTime fechaini, double monto, string fechafin, int estado, int tipopago, int cuotas)
        {

            try
            {
                cmd = new SqlCommand("ModificarContratoTemporal", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Contrato", id);
                cmd.Parameters.AddWithValue("@Monto_Mensual", montomensual);
                cmd.Parameters.AddWithValue("@Servicio", servicio);
                cmd.Parameters.AddWithValue("@Fecha_Inicio_Contrato", fechaini);
                cmd.Parameters.AddWithValue("@Monto_Contrato", monto);
                cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fechafin);
                cmd.Parameters.AddWithValue("@Estado_Contrato", estado);
                cmd.Parameters.AddWithValue("@Tipo_Pago_Contrato", tipopago);
                cmd.Parameters.AddWithValue("@Cuotas_Mensuales", cuotas); 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha Modificado correctamente el Contrato", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void ModificarContratoViaje(string id, double anticipo, string servicio, DateTime fechaini, double monto, string fechafin, int estado)
        {

            try
            {
                cmd = new SqlCommand("ModificarContratoViaje", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Contrato", id);
                cmd.Parameters.AddWithValue("@Servicio", servicio);
                cmd.Parameters.AddWithValue("@Anticipo", anticipo);
                cmd.Parameters.AddWithValue("@Fecha_Inicio_Contrato", fechaini);
                cmd.Parameters.AddWithValue("@Monto_Contrato", monto);
                cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fechafin);
                cmd.Parameters.AddWithValue("@Estado_Contrato", estado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha Modificado correctamente el Contrato", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public void ModificarHorario(string Codigo_Ruta, string Codigo_Vehiculo, string Horario_Salida, string Horario_Entrada, DateTime Horario_Salida_Nuevo, DateTime Horario_Entrada_Nuevo, string Decision)
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
                MessageBox.Show("Se ha " + Decision + " correctamente el Horario","GUARDADO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void ModificarVehiculo(string placa, string color, int estado, DateTime emision, DateTime vencimiento)
        {

            try
            {
                cmd = new SqlCommand("ModificarVehiculo", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cod_Vehiculo", placa);
                cmd.Parameters.AddWithValue("@Color_Vehiculo", color);
                cmd.Parameters.AddWithValue("@Estado_Vehiculo", estado);
                cmd.Parameters.AddWithValue("@Emision_Permiso", emision);
                cmd.Parameters.AddWithValue("@Vencimiento_Permiso", vencimiento);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha Modificado correctamente el Contrato");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //Modificar Estado de Vehiculo a "En Mantenimiento"
        public void ModificarEstadoVeh(string matricula)
        {
            try
            {
                cmd = new SqlCommand("VehEnMantenimiento", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", matricula);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        //Modificar Tipo de Mantenimiento
        public void ModificarMantenimiento(int cod, string nom, string desc)
        {
            try
            {
                cmd = new SqlCommand("ModificarMantenimiento", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", cod);
                cmd.Parameters.AddWithValue("@nombre", nom);
                cmd.Parameters.AddWithValue("@descripcion", desc);

                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public void ActualizarMatricula(string Codigo_Vehiculo_Anterior, string Codigo_Vehiculo_Nuevo)
        {
            try
            {
                cmd = new SqlCommand("ActualizacionMatricula", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo_Anterior", Codigo_Vehiculo_Anterior);
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo_Nuevo", Codigo_Vehiculo_Nuevo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cambios realizado con exitos", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    
    }
}
