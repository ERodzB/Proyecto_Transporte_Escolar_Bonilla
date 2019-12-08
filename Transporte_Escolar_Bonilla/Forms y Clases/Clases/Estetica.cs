using System;
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

        public void imprimirTabla(DataGridView dgvImprimir, string titulo)
        {
           

            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc";
            Word._Application oWord;
            Word._Document oDoc;

            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);

            oPara1.Range.Text = titulo;
            oPara1.Range.Font.Name = "Times New Roman";
            oPara1.Format.SpaceAfter = 30;
            oPara1.Range.Font.Size = 30;
            oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            oPara1.Range.InsertParagraphAfter();


            Word.Table table;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            table = oDoc.Tables.Add(wrdRng,1, dgvImprimir.Columns.Count-1, ref oMissing, ref oMissing);
            table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle;
            table.Range.Font.Name = "Times New Roman";
            table.Range.Font.Size = 12;

            foreach (DataGridViewCell cell in dgvImprimir.Rows[0].Cells)
            {
                table.Cell(table.Rows.Count, cell.ColumnIndex).Range.Text = dgvImprimir.Columns[cell.ColumnIndex].Name;
            }
       
            table.Rows.Add();
            
            foreach (DataGridViewRow row in dgvImprimir.Rows){
                
                foreach(DataGridViewCell cell in row.Cells){
                    table.Cell(table.Rows.Count, cell.ColumnIndex).Range.Text = cell.Value.ToString();
                    
                }
                table.Rows.Add();
            }
            table.Rows[1].Range.Font.Bold = 1;
            table.Rows[dgvImprimir.Rows.Count+2].Delete();
            
        }
    }
}
