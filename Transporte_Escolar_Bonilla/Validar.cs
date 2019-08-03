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
        public int igual = 0; //Para validar horarios duplicados de un vehiculo

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

        public int validarCliente(string id)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("VerificarCliente", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Cliente", id);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ex.ToString());
            }

            return x;
        }

        public int validarRuta(string cod)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("VerificarRuta", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Ruta", cod);
                 x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ex.ToString());
            }

            return x;
        }

        public int validarHorariosVeh(string cod, string hora)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("VerificarHoraVeh", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", cod);
                cmd.Parameters.AddWithValue("@Horario_Salida", hora);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: "+ex.ToString());
            }

            return x;
        }

        //Validar capacidad Vehiculo
        public int validarCap(string cod, int pa)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("VerificarCap", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", cod);
                cmd.Parameters.AddWithValue("@Pasajeros", pa);
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
            }

            return x;
        }

        //Validar Horarios Repetidos para un mismo vehiculo
        public void ValidarHora(DateTimePicker h1, DateTimePicker h2, ComboBox va, ComboBox vb)
        {
            if ((h1.Checked == true && h2.Checked == true) && (h1.Text == h2.Text) && (va.Text == vb.Text))
                igual++;
        }

        //Validar Vehiculos
        public int validarVeh(string mat)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("VerificarVehiculo", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", mat);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }

            return x;
        }

        //Verificar Mantenimiento Existente
        public int VerificarMantenimiento(int cod, string nom, int opcion)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("VerificarMantenimiento", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", cod);
                cmd.Parameters.AddWithValue("@nombre", nom);
                cmd.Parameters.AddWithValue("@opcion", opcion);

                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }

            return x;
        }

        //Verificar Cambios Realizados
        public int CambiosMantenimiento(string nom, string desc)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("CambiosMantenimiento", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;               
                cmd.Parameters.AddWithValue("@nombre", nom);
                cmd.Parameters.AddWithValue("@descripcion", desc);
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }

            return x;
        }

        public int validarContrasena(string cont, string ID)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("VerificarContrasena", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@contra", cont);
                cmd.Parameters.AddWithValue("@identidad", ID);
                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return x;
        }

        public int validarMantenimiento(string CodVeh)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("BuscaMantenimiento", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@matricula", CodVeh);
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return x;
        }

        public int validarLicenciaLiviana(string NombreEmp)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("LicenciaLiviana", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NomEmp", NombreEmp);
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return x;
        }

        public int validarVehiculoPesado (string CodVeh)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("VehiculosPesados", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@matricula", CodVeh);
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return x;
        }
    }
}
