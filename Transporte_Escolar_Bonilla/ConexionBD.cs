using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//Libreria para usar SQL


namespace Transporte_Escolar_Bonilla
{
   public class ConexionBD
    {
        protected SqlConnection conexionBD = new SqlConnection("Data Source=.; Initial Catalog=Transporte_Bonilla; Integrated Security=True");

        //protected SqlConnection conexionBD = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|Data\\Transporte_Bonilla.mdf;Integrated Security=True;User Instance=True");
        public static int Acceso=0;//Nivel de Acceso
        public static string codigo;
        public static string password;
        public ConexionBD()
        { }
    }
}
