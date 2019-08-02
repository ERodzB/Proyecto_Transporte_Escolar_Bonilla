using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;

namespace Transporte_Escolar_Bonilla
{
    public partial class Generar_Contrato : Form
    {
        Consultar con = new Consultar();
        string codcontrato, cliente, tipocon, mensualidad, cuotas, servicio, fechaini, montocontrato, fechafin;

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea Generar el Contrato?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tipocon == "Temporal")
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
                    oPara1.Range.Text = "Transporte Bonilla";
                    oPara1.Range.Font.Bold = 1;
                    oPara1.Format.SpaceAfter = 24;
                    oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara1.Range.InsertParagraphAfter();

                    Word.Paragraph oPara2;
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Text = "Contrato de Servicios";
                    oPara2.Range.Font.Bold = 1;
                    oPara2.Format.SpaceAfter = 24;
                    oPara2.Range.InsertParagraphAfter();

                    Word.Paragraph oPara3;
                    object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara3.Range.Text = "Contrato hecho para" + ": " + cliente;
                    oPara3.Range.Font.Bold = 1;
                    oPara3.Format.SpaceAfter = 6;
                    oPara3.Range.InsertParagraphAfter();
                    oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphThaiJustify;

                    Word.Paragraph oPara4;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara3.Range.Font.Bold = 0;
                    oPara3.Range.Text = "Con este Contrato damos a Conocer los terminos en que la persona " + cliente + " esta dispuesta a aceptar los terminos y condiciones " +
                        "que le brinda la Empresa Transporte Bonilla Representado legalmente en el presente documento";
                    oPara3.Range.Font.Bold = 0;
                    oPara3.Format.SpaceAfter = 15;
                    oPara3.Range.InsertParagraphAfter();

                    Word.Paragraph oPara5;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara5 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara5.Range.Text = "Se presenta el servicio de: " + tipocon + " de Dicho Contrato";
                    oPara5.Range.Font.Bold = 0;
                    oPara5.Format.SpaceAfter = 15;
                    oPara5.Range.InsertParagraphAfter();

                    Word.Paragraph oPara6;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara6 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara6.Range.Text = "Con una Mensualidad de: " + mensualidad;
                    oPara6.Range.Font.Bold = 0;
                    oPara6.Format.SpaceAfter = 15;
                    oPara6.Range.InsertParagraphAfter();

                    Word.Paragraph oPara7;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara7 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara7.Range.Text = "Se presenta el servicio de: " + tipocon + " de Dicho Contrato";
                    oPara7.Range.Font.Bold = 0;
                    oPara7.Format.SpaceAfter = 15;
                    oPara7.Range.InsertParagraphAfter();

                    Word.Paragraph oPara8;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara8 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara8.Range.Text = "Numero de cuotas a pagar: " + cuotas;
                    oPara8.Range.Font.Bold = 0;
                    oPara8.Format.SpaceAfter = 15;
                    oPara8.Range.InsertParagraphAfter();

                    Word.Paragraph oPara9;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara9 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara9.Range.Text = "Servicio que dispondra: " + servicio;
                    oPara9.Range.Font.Bold = 0;
                    oPara9.Format.SpaceAfter = 15;
                    oPara9.Range.InsertParagraphAfter();

                    Word.Paragraph oPara10;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara10 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara10.Range.Text = "Fecha de Inicio del Contrato" + fechaini;
                    oPara10.Range.Font.Bold = 0;
                    oPara10.Format.SpaceAfter = 15;
                    oPara10.Range.InsertParagraphAfter();

                    Word.Paragraph oPara11;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara11 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara11.Range.Text = "Monto Total del Contrato" + montocontrato;
                    oPara11.Range.Font.Bold = 0;
                    oPara11.Format.SpaceAfter = 15;
                    oPara11.Range.InsertParagraphAfter();

                    Word.Paragraph oPara12;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara12 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara12.Range.Text = "Fecha de Finalizacion del Contrato" + fechafin;
                    oPara12.Range.Font.Bold = 0;
                    oPara12.Format.SpaceAfter = 15;
                    oPara12.Range.InsertParagraphAfter();

                }
                if(tipocon == "Viaje")
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
                    oPara1.Range.Text = "Transporte Bonilla";
                    oPara1.Range.Font.Bold = 1;
                    oPara1.Format.SpaceAfter = 24;
                    oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara1.Range.InsertParagraphAfter();

                    Word.Paragraph oPara2;
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Text = "Contrato de Servicios";
                    oPara2.Range.Font.Bold = 0;
                    oPara2.Format.SpaceAfter = 24;
                    oPara2.Range.InsertParagraphAfter();

                    Word.Paragraph oPara3;
                    object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara3.Range.Text = "Contrato hecho para" + ": " + cliente;
                    //oPara3.Range.Font.Bold = 0;
                    oPara3.Format.SpaceAfter = 6;
                    oPara3.Range.InsertParagraphAfter();
                    oPara3.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphThaiJustify;

                    Word.Paragraph oPara4;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara4 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara4.Range.Font.Bold = 0;
                    oPara4.Range.Text = "Con este Contrato damos a Conocer los terminos en que la persona " + cliente + " esta dispuesta a aceptar los terminos y condiciones " +
                        "que le brinda la Empresa Transporte Bonilla Representado legalmente en el presente documento";
                    oPara4.Range.Font.Bold = 0;
                    oPara4.Format.SpaceAfter = 15;
                    oPara4.Range.InsertParagraphAfter();

                    Word.Paragraph oPara5;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara5 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara5.Range.Text = "Se presenta el servicio de: " + tipocon + " de Dicho Contrato";
                    oPara5.Range.Font.Bold = 0;
                    oPara5.Format.SpaceAfter = 15;
                    oPara5.Range.InsertParagraphAfter();
                    
                    Word.Paragraph oPara6;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara6 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara6.Range.Text = "Se presenta el servicio de: " + tipocon + " de Dicho Contrato";
                    oPara6.Range.Font.Bold = 0;
                    oPara6.Format.SpaceAfter = 15;
                    oPara6.Range.InsertParagraphAfter();

                    
                    Word.Paragraph oPara7;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara7 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara7.Range.Text = "Servicio que dispondra: " + servicio;
                    oPara7.Range.Font.Bold = 0;
                    oPara7.Format.SpaceAfter = 15;
                    oPara7.Range.InsertParagraphAfter();

                    Word.Paragraph oPara9;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara9 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara9.Range.Text = "Fecha de Inicio del Contrato: " + fechaini;
                    oPara9.Range.Font.Bold = 0;
                    oPara9.Format.SpaceAfter = 15;
                    oPara9.Range.InsertParagraphAfter();

                    Word.Paragraph oPara10;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara10 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara10.Range.Text = "Monto Total del Contrato: " + montocontrato;
                    oPara10.Range.Font.Bold = 0;
                    oPara10.Format.SpaceAfter = 15;
                    oPara10.Range.InsertParagraphAfter();

                    Word.Paragraph oPara11;
                    oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                    oPara11 = oDoc.Content.Paragraphs.Add(ref oRng);
                    oPara11.Range.Text = "Fecha de Finalizacion del Contrato: " + fechafin;
                    oPara11.Range.Font.Bold = 0;
                    oPara11.Format.SpaceAfter = 15;
                    oPara11.Range.InsertParagraphAfter();

                }

            }
        }

        public Generar_Contrato()
        {
            InitializeComponent();
        }

        private void DgvDatosContrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Generar_Contrato_Load(object sender, EventArgs e)
        {
            con.cargardvggenerarcotnrato(dgvGenerarContrato);

        }

        private void DgvGenerarContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codcontrato = dgvGenerarContrato.CurrentRow.Cells[0].Value.ToString();
            cliente = dgvGenerarContrato.CurrentRow.Cells[1].Value.ToString();
            tipocon = dgvGenerarContrato.CurrentRow.Cells[2].Value.ToString();
            mensualidad = dgvGenerarContrato.CurrentRow.Cells[3].Value.ToString();
            cuotas = dgvGenerarContrato.CurrentRow.Cells[4].Value.ToString();
            servicio = dgvGenerarContrato.CurrentRow.Cells[5].Value.ToString();
            fechaini = dgvGenerarContrato.CurrentRow.Cells[7].Value.ToString();
            montocontrato = dgvGenerarContrato.CurrentRow.Cells[8].Value.ToString();
            fechafin = dgvGenerarContrato.CurrentRow.Cells[9].Value.ToString();

            btnGenerar.Enabled = true;
        }
    }
}
