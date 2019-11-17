using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Transporte_Escolar_Bonilla
{
    public class Validar : ConexionBD
    {
        private SqlCommand cmd;
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
        public int validarInicioSession(string Nombre_Usuario, string Correo)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            return x;
        }
        public int validarUsuario_Empleado(string Codigo_Empleado)
        {
            x = 0;
            try
            {
                cmd = new SqlCommand("verificar_empleado_usuario", conexionBD);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo_Empleado", Codigo_Empleado);
                x = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString(), "ERROR");
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.ToString());
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }

            return x;
        }

        //Validar Placa de Vehiculo
        public int ValidarPlaca(String placa)
        {
            int num = 0, letra = 0, i = 0;

            for (i = 0; i < placa.Length; i++)
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
            catch (Exception ex)
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
            catch (Exception ex)
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

        public int validarVehiculoPesado(string CodVeh)
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
            int x = 0;
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

        public string valTextoVacioOMaximo(string txtValidar, string nombreTxt)
        {
            string resultado = "";
            string regex1 = @"^[a-zA-Z]{3}[a-zA-Z 0-9]*$";
            string regex2 = @"^[\w ]{0,50}$";
            if (string.IsNullOrEmpty(txtValidar))
            {
                resultado = "*Error valor nulo o vacio en " + nombreTxt + "\n";
            }
            else
            {
                if (!Regex.IsMatch(txtValidar, regex1) && nombreTxt != "Placa")
                {
                    resultado = "*Debe Ingresar minimo 3  caracteres en " + nombreTxt + "\n";
                }
                else
                {
                    if (!Regex.IsMatch(txtValidar, regex2) && nombreTxt != "Placa")
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
        public string valHorarios(DateTimePicker dtp1, DateTimePicker dtp2)
        {
            string resultado = "";
            if (dtp2.Value.Minute <= dtp1.Value.AddMinutes(19).Minute && dtp2.Value.Hour == dtp1.Value.Hour)
            {
                resultado = "*La ruta debe durar al menos 20 minutos\n";
            }

            if (dtp1.Value.Hour < dtp2.Value.Hour)
            {
                for (int x = 0; x > -1; x++)
                {
                    if (dtp1.Value.AddMinutes(x).Hour == dtp2.Value.Hour)
                    {
                        if (dtp1.Value.AddMinutes(x).Minute == dtp2.Value.Minute)
                        {
                            if (x <= 19)
                                resultado = "*La ruta debe durar al menos 20 minutos\n";
                            break;


                        }


                    }

                }
            }


            return resultado;
        }
        public string regMatricula(string txtValidar)
        {
            string resultado = "";
            string regex = @"^([a-zA-Z]{2}[0-9]{4}|[a-zA-Z]{3}[0-9]{4}|[a-zA-Z]{2}[0-9]{5})$";
            if (!Regex.IsMatch(txtValidar, regex))
            {
                resultado = "*Ingrese una Placa valida Ejemplo AB1234 o ABC1234 o AB12345\n";
            }
            return resultado;
        }

        public string valFechasIguales(DateTimePicker dtp1, DateTimePicker dtp2)
        {
            string resultado = "";
            if (dtp1.Value.Date == dtp2.Value.Date)
            {
                resultado = "*Escoja Fechas Distintas\n";
            }
            return resultado;
        }
        public string valIdORtn(string id)
        {
            string regId = @"^(([0-9][1-9]){1,2}(19\d{7})?(20[0-0][0-1]\d{5})?)$";
            string regRTN = @"^(([0-9][1-9]){1,2}(19\d{8})?(20[0-0][0-1]\d{6})?)$";
            string resultado = "";
            if (id.Trim().Length < 13)
                resultado = "*Debe ingresar un Número de Identidad de 13 numeros\n";
            else
            {
                if (!Regex.IsMatch(id, regId) && id.Trim().Length == 13)
                    resultado = "*Debe Ingresar un ID valido o con fecha de nacimiento mayor a 18\n";

                else
                {
                    if (!Regex.IsMatch(id, regRTN) && id.Trim().Length == 14)
                        resultado = "*Debe Ingresar un RTN valido o con fecha de nacimiento mayor a 18\n";
                }
            }



            return resultado;
        }
    }
}
