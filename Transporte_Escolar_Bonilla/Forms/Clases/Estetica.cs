using System.Windows.Forms; // Librearia para poder utilizar formularios y los controles de windows
using Word = Microsoft.Office.Interop.Word;

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
        public void abrirLoading(Form loading)
        {
            loading.Show();
        }
        public void cerrarLoading(Form loading)
        {
            loading.Close();
        }

        public void imprimirTabla(DataGridView dgvImprimir)
        {
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            Word.Table table;
            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            table = oDoc.Tables.Add(oDoc.Range(), dgvImprimir.Rows.Count, dgvImprimir.Columns.Count, ref oMissing, ref oMissing);


            for (int x = 0; x < dgvImprimir.Rows.Count; x++)
            {
                for (int y = 0; y < dgvImprimir.Columns.Count; y++)
                {

                    table.Cell(x, y).Range.Text = dgvImprimir[y, x].Value.ToString();
                }
            }
        }
    }
}
