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
    }
}
