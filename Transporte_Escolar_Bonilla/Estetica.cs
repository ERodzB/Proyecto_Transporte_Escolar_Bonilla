using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Librearia para poder utilizar formularios y los controles de windows

namespace Transporte_Escolar_Bonilla
{
    public class Estetica
    {


        public Estetica()
        {

        }

        public void AbrirFormularios(Form Formulario, Panel Panel)
        {
            bool x;// variable que recibira si ya existe ese formulario en la coleccion del panel
            x = Panel.Controls.Contains(Formulario);//verifica si ese formulario ya existe
            if (x == false)// En caso de ser falso lo añade
            {
                Formulario.TopLevel = false;
                Panel.Controls.Add(Formulario);
                ///MessageBox.Show(Convert.ToString(x));
            }

            Formulario.BringToFront();//Trae el formulario de frente
            Formulario.Show();//lo muestra
        }
    }
}
