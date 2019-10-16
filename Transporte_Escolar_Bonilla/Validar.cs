using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        //Validar Cambios Modificar Cliente
        public int CambiosCliente(string id, string nom, string dir, string tel, string correo)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("CambiosCliente", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Cliente", id);
                cmd.Parameters.AddWithValue("@Nombre_Cliente", nom);
                cmd.Parameters.AddWithValue("@Direccion_Cliente", dir);
                cmd.Parameters.AddWithValue("@Telefono_Cliente", tel);
                cmd.Parameters.AddWithValue("@Correo_Cliente", correo);

                x = (int)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " +ex.ToString(), "ERROR");
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

        //Validar Placa de Vehiculo
        public int ValidarPlaca(String placa)
        {
            int num = 0, letra = 0, i = 0;

            for(i=0; i<placa.Length; i++)
            {
                if (char.IsLetter(placa[i]))
                    letra++;
                else
                    num++;
            }

            //Devuelve 1 si esta bien escrito
            if (letra == 3 && num == 4)
                return 1;
            else
                return 0;
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


        public int VehiculoConductor(string CodVeh)
        {
            int x=0;
            try
            {
                cmd = new SqlCommand("VehiculoConductor", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Vehiculo", CodVeh);
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            return x;
        }


        //Validar si se Modifica Ruta 
        public int VerificarModiRuta(string codr)
        {
            x = 0;

            try
            {
                cmd = new SqlCommand("VerificarModiRuta", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo_ruta", codr);
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            return x;
        }

        public string valTextoVacioOMaximo(string txtValidar, string nombreTxt, string regex1, string regex2)
        {
            string resultado = "";
            if (string.IsNullOrEmpty(txtValidar))
            {
                resultado = "*Error valor nulo o vacio en " + nombreTxt+"\n";
            }
            else
            {
                if (!Regex.IsMatch(txtValidar, regex1) && nombreTxt!= "Placa")
                {
                    resultado = "*Debe Ingresar minimo 3  caracteres en " + nombreTxt + "\n";
                }
                else
                {
                    if(!Regex.IsMatch(txtValidar, regex2) && nombreTxt != "Placa")
                    {
                        resultado = "*El maximo de caracteres es de 50 en " + nombreTxt + "\n";
                    }
                }
            }
            return resultado;
        }
        public string valCmbVacio(int a, string nombreCmb)
        {
            string resultado = "";
            if (a == -1)
            {
                resultado = "*Error Escoja una opcion de " + nombreCmb + "\n";
            }

            return resultado;
        }
        public string valFechas(DateTimePicker dtp1, DateTimePicker dtp2)
        {
            string resultado = "";
            if (dtp1.Value.Date == dtp2.Value.Date)
            {
                resultado = "*Escoja Fechas Diferentes\n";
            }
            return resultado;
        }
        public string regMatricula(string txtValidar, string regex)
        {
            string resultado = "";
            if(!Regex.IsMatch(txtValidar, regex))
            {
                resultado = "*Ingrese una Placa valida Ejemplo ABC123 o ABC1234\n";
            }
            return resultado;
        }

        
       
    }
}
