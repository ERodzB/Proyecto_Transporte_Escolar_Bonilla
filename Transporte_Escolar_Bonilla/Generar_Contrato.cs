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
using System.Globalization;

namespace Transporte_Escolar_Bonilla
{
    public partial class Generar_Contrato : Form
    {
        Consultar con = new Consultar();
        string idecliente,cliente, tipocon, mensualidad, cuotas, servicio, fechaini, montocontrato, fechafin, ruta, parada, anticipo;

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea Generar el Contrato?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tipocon == "Temporal" && servicio == "Medio Bus")
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

                    oPara1.Range.Text = "CONTRATO DE SERVICIO DE TRANSPORTE TRANSPORTE ESCOLAR BONILLA";
                    oPara1.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                    oPara1.Range.Font.Name = "Times New Roman";
                    oPara1.Format.SpaceAfter = 24;
                    oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara1.Range.InsertParagraphAfter();

                    Word.Paragraph oPara2;

                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Text = "Yo, GILMA AMARILYS BONILLA MARTINEZ , actuando en su condición de propietaria/o de TRANSPORTES BONILLA," +
                        " con tarjeta de Identidad 0301-1971-001672, con residencia en la ciudad de COMAYAGUA, " +
                        "Departamento de COMAYAGUA y quien en delante se  denominará “EL TRANSPORTISTA”," +
                        " y el Señor (a)  " + cliente.ToUpper() + ", mayor de edad, con Tarjeta de Identidad No. " + idecliente + ", " +
                        "con residencia en la ciudad de COMAYAGUA, Departamento de COMAYAGUA, y quien en adelante " +
                        "se denominará “EL CLIENTE”, convenimos en celebrar el presente CONTRATO DE SERVICIOS DE TRANSPORTE, " +
                        "sujeto a las clausulas/condiciones siguientes:  ";

                    oPara2.Range.Font.Name = "Times New Roman";
                    oPara2.Range.Font.Size = 12;
                    oPara2.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara2.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara2.Format.SpaceAfter = 15;
                    oPara2.Range.InsertParagraphAfter();

                    Word.Paragraph oPara3;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara3.Range.Text = "PRIMERA:  SERVICIO COTRATADO: a) " +
                        "EL CLIENTE acuerda contratar EL TRANSPORTISTA por servicios de transporte, que consisten " +
                        "en transportarlo desde su casa de habitación a su lugar de trabajo/Centro Educactivo o de Su Lugar de trabajo/Centro Educactivo a su casa de habitación b) " +
                        "El horario de servicio es de lunes a viernes y la ruta (lugar de trabajo/centro educativo) " +
                        "" + ruta.ToUpper() + "  " +
                        "El Costo del servicio es de Lps." + mensualidad + " mensuales que se pagarán por el CLIENTE a más tardar el 30 cada mes. d)" +
                        " Todo feriado nacional o día libre de EL CLIENTE en el tiempo de este contrato serán pagados por el cliente como si " +
                        "estuviera el transportista otorgando sus servicios.";
                    oPara3.Range.Font.Name = "Times New Roman";
                    oPara3.Range.Font.Size = 12;
                    oPara3.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara3.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara3.Format.SpaceAfter = 15;
                    oPara3.Range.InsertParagraphAfter();

                    Word.Paragraph oPara4;
                    oPara4 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara4.Range.Text = "SEGUNDA: OBLIGACIONES DEL TRANSPORTISTA: a) EL TRANSPORTISTA deberá " +
                        "cumplir con las horas estipuladas de transportar EL CLIENTE para llegar a las horas convenidas." +
                        " b) De existir en el transporte cualquier tipo de contratiempo, tratar de retomar el servicio con equipo sustituto y" +
                        " así poder cumplir con los horarios convenidos, sin existir costo alguno para EL CLIENTE.  " +
                        "b) EL TRANSPORTISTA se compromete a que las unidades estén en perfecto estado y en óptimas condiciones. " +
                        "c) EL TRANSPORTISTA NO está obligado a otorgar sus servicios fuera del horario y días establecidos en este contrato. " +
                        "e) El TRANSPORTISTA está obligado a llevar EL CLIENTE a su lugar de trabajo/centro educativo o " +
                        "llevarlo de regreso a su casa de habitación, cualquier otro movimiento que EL CLIENTE desea hacer " +
                        "que sea diferente a los lugares convenidos ocasionara un costo extra para EL CLIENTE.  ";
                    oPara4.Range.Font.Name = "Times New Roman";
                    oPara4.Range.Font.Size = 12;
                    oPara4.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara4.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara4.Format.SpaceAfter = 15;
                    oPara4.Range.InsertParagraphAfter();


                    Word.Paragraph oPara5;
                    oPara5 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara5.Range.Text = "TERCERA: OBLIGACIONES DEL CLIENTE: a) EL CLIENTE está obligado a estar listo a las horas establecidas y " +
                        "en la parada " + parada.ToUpper() + " para evitar retrasos en el servicio. b) EL CLIENTE está obligado a pagar la cantidad de " +
                        "Lps." + mensualidad + " mensuales por el servicio de transporte convenidos. c) EL CLIENTE está obligado " +
                        "a pagar por el servicio a más tardar el 30 de cada mes, si hay retraso en el pago se cobrara el 5% de multa por cada 3 días" +
                        " de retraso después del 30 de cada mes.";
                    oPara5.Range.Font.Size = 12;
                    oPara5.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara5.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara5.Format.SpaceAfter = 15;
                    oPara5.Range.InsertParagraphAfter();

                    Word.Paragraph oPara6;
                    oPara6 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara6.Range.Text = "CUARTA:  PLAZO DEL CONTRATO: el plazo del presente contrato será " +
                        " del " + DateTime.Parse(fechaini).ToString("dd") + " dias del mes " + DateTime.Parse(fechaini).ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del año " + DateTime.Parse(fechafin).ToString("yyyy", new CultureInfo("es-ES")) + " hasta la fecha de " + DateTime.Parse(fechafin).ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del año " + DateTime.Parse(fechafin).ToString("yyyy", new CultureInfo("es-ES"));
                    oPara6.Range.Font.Size = 12;
                    oPara6.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara6.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara6.Format.SpaceAfter = 15;
                    oPara6.Range.InsertParagraphAfter();

                    Word.Paragraph oPara7;
                    oPara7 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara7.Range.Text = " QUINTA: INCUMPLIMIENTO: el hecho de que cualquiera de las" +
                        " partes incumpla alguno de los compromisos y obligaciones que se derivan del presente contrato, será justificante derecho el" +
                        " presente contrato. AMBAS PARTES se reservan el derecho de acudir a la vía correspondiente con el fin de cubrir daños y" +
                        " perjuicios ocasionados por el incumplimiento en que pueda incurrir LA OTRA PARTE.";
                    oPara7.Range.Font.Size = 12;
                    oPara7.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara7.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara7.Format.SpaceAfter = 24;
                    oPara7.Range.InsertParagraphAfter();

                    Word.Paragraph oPara8;
                    oPara8 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara8.Range.Text = "SEXTA: VENCIMIENTO ANTICIPADO: " +
                        "a) En caso de que alguna de las partes deseare romper unilateralmente el presente contrato deberá notificar a la otra " +
                        "parte con treinta días naturales de anticipación a la fecha de conclusión del servicio. " +
                        "b) Si por cualquier motivo EL CLIENTE rescindiera de los servicios de transporte antes de fin de mes, " +
                        "EL CLIENTE está obligado a pagar el mes completo de servicio. ";
                    oPara8.Range.Font.Size = 12;
                    oPara8.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara8.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara8.Format.SpaceAfter = 15;
                    oPara8.Range.InsertParagraphAfter();

                    Word.Paragraph oPara9;
                    oPara9 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara9.Range.Text = "SEPTIMA: Declaran “EL TRANSPORTISTA” y “EL CLIENTE, que aceptan las cláusulas estipuladas en este " +
                        "CONTRATO DE SERVICIOS y para dar fe de lo convenido, " +
                        "firman el mismo en la ciudad de COMAYAGUA , departamento de COMAYAGUA, a los " + DateTime.Now.Day + " días del mes de " + DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del " + DateTime.Now.Year.ToString() + " . ";
                    oPara9.Range.Font.Size = 12;
                    oPara9.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara9.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara9.Format.SpaceAfter = 300;
                    oPara9.Range.InsertParagraphAfter();

                    Word.Paragraph oPara10;
                    oPara10 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara10.Range.Text = "EL CLIENTE			                                         EL TRANSPORTISTA";
                    oPara10.Range.Font.Size = 12;
                    oPara10.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara10.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara10.Format.SpaceAfter = 40;
                    oPara10.Range.InsertParagraphAfter();

                }
                if (tipocon == "Temporal" && servicio == "Bus Completo")
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

                    oPara1.Range.Text = "CONTRATO DE SERVICIO DE TRANSPORTE TRANSPORTE ESCOLAR BONILLA";
                    oPara1.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                    oPara1.Range.Font.Name = "Times New Roman";
                    oPara1.Format.SpaceAfter = 24;
                    oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara1.Range.InsertParagraphAfter();

                    Word.Paragraph oPara2;
                  
                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Text = "Yo, GILMA AMARILYS BONILLA MARTINEZ , actuando en su condición de propietaria/o de TRANSPORTES BONILLA," +
                        " con tarjeta de Identidad 0301-1971-001672, con residencia en la ciudad de COMAYAGUA, " +
                        "Departamento de COMAYAGUA y quien en delante se  denominará “EL TRANSPORTISTA”," +
                        " y el Señor (a)  " + cliente.ToUpper() + ", mayor de edad, con Tarjeta de Identidad No. " + idecliente + ", " +
                        "con residencia en la ciudad de COMAYAGUA, Departamento de COMAYAGUA, y quien en adelante " +
                        "se denominará “EL CLIENTE”, convenimos en celebrar el presente CONTRATO DE SERVICIOS DE TRANSPORTE, " +
                        "sujeto a las clausulas/condiciones siguientes:  ";
                        
                    oPara2.Range.Font.Name = "Times New Roman";
                    oPara2.Range.Font.Size = 12;
                    oPara2.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara2.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara2.Format.SpaceAfter = 15;
                    oPara2.Range.InsertParagraphAfter();

                    Word.Paragraph oPara3;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara3.Range.Text = "PRIMERA:  SERVICIO COTRATADO: a) " +
                        "EL CLIENTE acuerda contratar EL TRANSPORTISTA por servicios de transporte, que consisten " +
                        "en transportarlo desde su casa de habitación a su lugar de trabajo/centro educativo y viceversa. b) " +
                        "El horario de servicio es de lunes a viernes y la ruta (lugar de trabajo/centro educativo) " +
                        "" + ruta.ToUpper() + "  " +
                        "El Costo del servicio es de Lps." + mensualidad + " mensuales que se pagarán por el CLIENTE a más tardar el 30 cada mes. d)" +
                        " Todo feriado nacional o día libre de EL CLIENTE en el tiempo de este contrato serán pagados por el cliente como si " +
                        "estuviera el transportista otorgando sus servicios.";
                    oPara3.Range.Font.Name = "Times New Roman";
                    oPara3.Range.Font.Size = 12;
                    oPara3.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara3.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara3.Format.SpaceAfter = 15;
                    oPara3.Range.InsertParagraphAfter();

                    Word.Paragraph oPara4;
                    oPara4 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara4.Range.Text = "SEGUNDA: OBLIGACIONES DEL TRANSPORTISTA: a) EL TRANSPORTISTA deberá " +
                        "cumplir con las horas estipuladas de transportar EL CLIENTE para llegar a las horas convenidas." +
                        " b) De existir en el transporte cualquier tipo de contratiempo, tratar de retomar el servicio con equipo sustituto y" +
                        " así poder cumplir con los horarios convenidos, sin existir costo alguno para EL CLIENTE.  " +
                        "b) EL TRANSPORTISTA se compromete a que las unidades estén en perfecto estado y en óptimas condiciones. " +
                        "c) EL TRANSPORTISTA NO está obligado a otorgar sus servicios fuera del horario y días establecidos en este contrato. " +
                        "e) El TRANSPORTISTA está obligado a llevar EL CLIENTE a su lugar de trabajo/centro educativo y " +
                        "llevarlo de regreso a su casa de habitación, cualquier otro movimiento que EL CLIENTE desea hacer " +
                        "que sea diferente a los lugares convenidos ocasionara un costo extra para EL CLIENTE.  ";
                    oPara4.Range.Font.Name = "Times New Roman";
                    oPara4.Range.Font.Size = 12;
                    oPara4.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara4.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara4.Format.SpaceAfter = 15;
                    oPara4.Range.InsertParagraphAfter();

                    
                    Word.Paragraph oPara5;
                    oPara5 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara5.Range.Text = "TERCERA: OBLIGACIONES DEL CLIENTE: a) EL CLIENTE está obligado a estar listo a las horas establecidas y " +
                        "en la parada " + parada.ToUpper() + " para evitar retrasos en el servicio. b) EL CLIENTE está obligado a pagar la cantidad de " +
                        "Lps." + mensualidad + " mensuales por el servicio de transporte convenidos. c) EL CLIENTE está obligado " +
                        "a pagar por el servicio a más tardar el 30 de cada mes, si hay retraso en el pago se cobrara el 5% de multa por cada 3 días" +
                        " de retraso después del 30 de cada mes.";                  
                    oPara5.Range.Font.Size = 12;
                    oPara5.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara5.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara5.Format.SpaceAfter = 15;
                    oPara5.Range.InsertParagraphAfter();

                    Word.Paragraph oPara6;
                    oPara6 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara6.Range.Text = "CUARTA:  PLAZO DEL CONTRATO: el plazo del presente contrato será " +
                        " del " + DateTime.Parse(fechaini).ToString("dd") + " dias del mes " + DateTime.Parse(fechaini).ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del año " + DateTime.Parse(fechafin).ToString("yyyy", new CultureInfo("es-ES")) + " hasta la fecha de " + DateTime.Parse(fechafin).ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del año " + DateTime.Parse(fechafin).ToString("yyyy", new CultureInfo("es-ES"));
                    oPara6.Range.Font.Size = 12;
                    oPara6.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara6.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara6.Format.SpaceAfter = 15;
                    oPara6.Range.InsertParagraphAfter();

                    Word.Paragraph oPara7;
                    oPara7 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara7.Range.Text =" QUINTA: INCUMPLIMIENTO: el hecho de que cualquiera de las" +
                        " partes incumpla alguno de los compromisos y obligaciones que se derivan del presente contrato, será justificante derecho el" +
                        " presente contrato. AMBAS PARTES se reservan el derecho de acudir a la vía correspondiente con el fin de cubrir daños y" +
                        " perjuicios ocasionados por el incumplimiento en que pueda incurrir LA OTRA PARTE.";
                    oPara7.Range.Font.Size = 12;
                    oPara7.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara7.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara7.Format.SpaceAfter = 24;
                    oPara7.Range.InsertParagraphAfter();

                    Word.Paragraph oPara8;
                    oPara8 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara8.Range.Text ="SEXTA: VENCIMIENTO ANTICIPADO: " +
                        "a) En caso de que alguna de las partes deseare romper unilateralmente el presente contrato deberá notificar a la otra " +
                        "parte con treinta días naturales de anticipación a la fecha de conclusión del servicio. " +
                        "b) Si por cualquier motivo EL CLIENTE rescindiera de los servicios de transporte antes de fin de mes, " +
                        "EL CLIENTE está obligado a pagar el mes completo de servicio. ";
                    oPara8.Range.Font.Size = 12;
                    oPara8.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara8.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara8.Format.SpaceAfter = 15;
                    oPara8.Range.InsertParagraphAfter();

                    Word.Paragraph oPara9;
                    oPara9 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara9.Range.Text = "SEPTIMA: Declaran “EL TRANSPORTISTA” y “EL CLIENTE, que aceptan las cláusulas estipuladas en este " +
                        "CONTRATO DE SERVICIOS y para dar fe de lo convenido, " +
                        "firman el mismo en la ciudad de COMAYAGUA , departamento de COMAYAGUA, a los " + DateTime.Now.Day + " días del mes de " + DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del " + DateTime.Now.Year.ToString() + " . ";
                    oPara9.Range.Font.Size = 12;
                    oPara9.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara9.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara9.Format.SpaceAfter = 300;
                    oPara9.Range.InsertParagraphAfter();

                    Word.Paragraph oPara10;
                    oPara10 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara10.Range.Text = "EL CLIENTE			                                         EL TRANSPORTISTA";
                    oPara10.Range.Font.Size = 12;
                    oPara10.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara10.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara10.Format.SpaceAfter = 40;
                    oPara10.Range.InsertParagraphAfter();
                }

              if (tipocon == "Viaje" && servicio == "Salida y Regreso")
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

                    oPara1.Range.Text = "CONTRATO DE SERVICIO DE TRANSPORTE TRANSPORTE ESCOLAR BONILLA";
                    oPara1.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                    oPara1.Range.Font.Name = "Times New Roman";
                    oPara1.Format.SpaceAfter = 24;
                    oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara1.Range.InsertParagraphAfter();

                    Word.Paragraph oPara2;

                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Text = "Yo, GILMA AMARILYS BONILLA MARTINEZ , actuando en su condición de propietaria/o de TRANSPORTES BONILLA," +
                        " con tarjeta de Identidad 0301-1971-001672, con residencia en la ciudad de COMAYAGUA, " +
                        "Departamento de COMAYAGUA y quien en delante se  denominará “EL TRANSPORTISTA”," +
                        " y el Señor (a)  " + cliente.ToUpper() + ", mayor de edad, con Tarjeta de Identidad No. " + idecliente + ", " +
                        "con residencia en la ciudad de COMAYAGUA, Departamento de COMAYAGUA, y quien en adelante " +
                        "se denominará “EL CLIENTE”, convenimos en celebrar el presente CONTRATO DE SERVICIOS DE TRANSPORTE, " +
                        "sujeto a las clausulas/condiciones siguientes:  ";

                    oPara2.Range.Font.Name = "Times New Roman";
                    oPara2.Range.Font.Size = 12;
                    oPara2.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara2.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara2.Format.SpaceAfter = 15;
                    oPara2.Range.InsertParagraphAfter();

                    Word.Paragraph oPara3;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara3.Range.Text = "PRIMERA:  SERVICIO COTRATADO: a) " +
                        "EL CLIENTE acuerda contratar EL TRANSPORTISTA por servicios de transporte, que consisten " +
                        "en viajar  de " + ruta.ToUpper() + "  y de Regreso " +
                        "El Costo del servicio es de Lps." + Convert.ToString(Convert.ToDouble(montocontrato)- Convert.ToDouble(anticipo)) + " que se pagara al FINALIZAR dicho viaje con un ANTICIPO de" + anticipo + ".";
                    oPara3.Range.Font.Name = "Times New Roman";
                    oPara3.Range.Font.Size = 12;
                    oPara3.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara3.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara3.Format.SpaceAfter = 15;
                    oPara3.Range.InsertParagraphAfter();

                    Word.Paragraph oPara4;
                    oPara4 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara4.Range.Text = "SEGUNDA: OBLIGACIONES DEL TRANSPORTISTA: a) EL TRANSPORTISTA deberá " +
                        "cumplir con las horas estipuladas de transportar EL CLIENTE para llegar a las horas convenidas." +
                        " b) De existir en el transporte cualquier tipo de contratiempo, tratar de retomar el servicio con equipo sustituto y" +
                        " así poder cumplir con los horarios convenidos, sin existir costo alguno para EL CLIENTE.  " +
                        "b) EL TRANSPORTISTA se compromete a que las unidades estén en perfecto estado y en óptimas condiciones. " +
                        "c) EL TRANSPORTISTA NO está obligado a otorgar sus servicios fuera del horario y días establecidos en este contrato. " +
                        "e) El TRANSPORTISTA está obligado a llevar EL CLIENTE al lugar acordado del viaje y de regreso, cualquier otro movimiento que EL CLIENTE desea hacer " +
                        "que sea diferente a los lugares convenidos ocasionara un costo extra para EL CLIENTE.  ";
                    oPara4.Range.Font.Name = "Times New Roman";
                    oPara4.Range.Font.Size = 12;
                    oPara4.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara4.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara4.Format.SpaceAfter = 15;
                    oPara4.Range.InsertParagraphAfter();


                    Word.Paragraph oPara5;
                    oPara5 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara5.Range.Text = "TERCERA: OBLIGACIONES DEL CLIENTE: a) EL CLIENTE está obligado a estar listo a las horas establecidas y " +
                        " para evitar retrasos en el servicio. b) EL CLIENTE está obligado a pagar la cantidad de " +
                        "Lps." + montocontrato + "  por el servicio de transporte convenidos. c) EL CLIENTE está obligado " +
                        "a pagar por el servicio a más tardar el 2 dias al FINALIZAR el viaje, si hay retraso en el pago se cobrara el 5% de multa por cada 2 días" +
                        " de retraso." ;
                    oPara5.Range.Font.Size = 12;
                    oPara5.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara5.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara5.Format.SpaceAfter = 15;
                    oPara5.Range.InsertParagraphAfter();

                    Word.Paragraph oPara6;
                    oPara6 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara6.Range.Text = "CUARTA:  PLAZO DEL CONTRATO: el plazo del presente contrato será " +
                        " del " + DateTime.Parse(fechaini).ToString("dd") + " dias del mes " + DateTime.Parse(fechaini).ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del año " + DateTime.Parse(fechafin).ToString("yyyy", new CultureInfo("es-ES")) + " hasta la fecha de " + DateTime.Parse(fechafin).ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del año " + DateTime.Parse(fechafin).ToString("yyyy", new CultureInfo("es-ES"));
                    oPara6.Range.Font.Size = 12;
                    oPara6.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara6.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara6.Format.SpaceAfter = 15;
                    oPara6.Range.InsertParagraphAfter();

                    Word.Paragraph oPara7;
                    oPara7 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara7.Range.Text = " QUINTA: INCUMPLIMIENTO: el hecho de que cualquiera de las" +
                        " partes incumpla alguno de los compromisos y obligaciones que se derivan del presente contrato, será justificante derecho el" +
                        " presente contrato. AMBAS PARTES se reservan el derecho de acudir a la vía correspondiente con el fin de cubrir daños y" +
                        " perjuicios ocasionados por el incumplimiento en que pueda incurrir LA OTRA PARTE.";
                    oPara7.Range.Font.Size = 12;
                    oPara7.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara7.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara7.Format.SpaceAfter = 24;
                    oPara7.Range.InsertParagraphAfter();

                    Word.Paragraph oPara8;
                    oPara8 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara8.Range.Text = "SEXTA: VENCIMIENTO ANTICIPADO: " +
                        "a) En caso de que alguna de las partes deseare romper unilateralmente el presente contrato deberá notificar a la otra " +
                        "parte con diez días naturales de anticipación a la fecha de conclusión del servicio. " +
                        "b) Si por cualquier motivo EL CLIENTE rescindiera de los servicios de transporte y pago con anticipo este será deuvelto";
                    oPara8.Range.Font.Size = 12;
                    oPara8.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara8.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara8.Format.SpaceAfter = 15;
                    oPara8.Range.InsertParagraphAfter();

                    Word.Paragraph oPara9;
                    oPara9 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara9.Range.Text = "SEPTIMA: Declaran “EL TRANSPORTISTA” y “EL CLIENTE, que aceptan las cláusulas estipuladas en este " +
                        "CONTRATO DE SERVICIOS y para dar fe de lo convenido, " +
                        "firman el mismo en la ciudad de COMAYAGUA , departamento de COMAYAGUA, a los " + DateTime.Now.Day + " días del mes de " + DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del " + DateTime.Now.Year.ToString() + " . ";
                    oPara9.Range.Font.Size = 12;
                    oPara9.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara9.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara9.Format.SpaceAfter = 300;
                    oPara9.Range.InsertParagraphAfter();

                    Word.Paragraph oPara10;
                    oPara10 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara10.Range.Text = "EL CLIENTE			                                         EL TRANSPORTISTA";
                    oPara10.Range.Font.Size = 12;
                    oPara10.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara10.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara10.Format.SpaceAfter = 40;
                    oPara10.Range.InsertParagraphAfter();

                }


                if (tipocon == "Viaje" && servicio == "Salida o Regreso")
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

                    oPara1.Range.Text = "CONTRATO DE SERVICIO DE TRANSPORTE TRANSPORTE ESCOLAR BONILLA";
                    oPara1.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                    oPara1.Range.Font.Name = "Times New Roman";
                    oPara1.Format.SpaceAfter = 24;
                    oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara1.Range.InsertParagraphAfter();

                    Word.Paragraph oPara2;

                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara2.Range.Text = "Yo, GILMA AMARILYS BONILLA MARTINEZ , actuando en su condición de propietaria/o de TRANSPORTES BONILLA," +
                        " con tarjeta de Identidad 0301-1971-001672, con residencia en la ciudad de COMAYAGUA, " +
                        "Departamento de COMAYAGUA y quien en delante se  denominará “EL TRANSPORTISTA”," +
                        " y el Señor (a)  " + cliente.ToUpper() + ", mayor de edad, con Tarjeta de Identidad No. " + idecliente + ", " +
                        "con residencia en la ciudad de COMAYAGUA, Departamento de COMAYAGUA, y quien en adelante " +
                        "se denominará “EL CLIENTE”, convenimos en celebrar el presente CONTRATO DE SERVICIOS DE TRANSPORTE, " +
                        "sujeto a las clausulas/condiciones siguientes:  ";

                    oPara2.Range.Font.Name = "Times New Roman";
                    oPara2.Range.Font.Size = 12;
                    oPara2.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara2.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara2.Format.SpaceAfter = 15;
                    oPara2.Range.InsertParagraphAfter();

                    Word.Paragraph oPara3;
                    oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara3.Range.Text = "PRIMERA:  SERVICIO COTRATADO: a) " +
                        "EL CLIENTE acuerda contratar EL TRANSPORTISTA por servicios de transporte, que consisten " +
                        "en viajar  de " + ruta.ToUpper() +" de IDA "+
                        "El Costo del servicio es de Lps." + Convert.ToString(Convert.ToDouble(montocontrato)- Convert.ToDouble(anticipo)) + " que se pagara al FINALIZAR dicho viaje con un ANTICIPO de" + anticipo + ".";
                      oPara3.Range.Font.Name = "Times New Roman";
                    oPara3.Range.Font.Size = 12;
                    oPara3.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara3.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara3.Format.SpaceAfter = 15;
                    oPara3.Range.InsertParagraphAfter();

                    Word.Paragraph oPara4;
                    oPara4 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara4.Range.Text = "SEGUNDA: OBLIGACIONES DEL TRANSPORTISTA: a) EL TRANSPORTISTA deberá " +
                        "cumplir con las horas estipuladas de transportar EL CLIENTE para llegar a las horas convenidas." +
                        " b) De existir en el transporte cualquier tipo de contratiempo, tratar de retomar el servicio con equipo sustituto y" +
                        " así poder cumplir con los horarios convenidos, sin existir costo alguno para EL CLIENTE.  " +
                        "b) EL TRANSPORTISTA se compromete a que las unidades estén en perfecto estado y en óptimas condiciones. " +
                        "c) EL TRANSPORTISTA NO está obligado a otorgar sus servicios fuera del horario y días establecidos en este contrato. " +
                        "e) El TRANSPORTISTA está obligado a llevar EL CLIENTE al lugar acordado del viaje de IDA, cualquier otro movimiento que EL CLIENTE desea hacer " +
                        "que sea diferente a los lugares convenidos ocasionara un costo extra para EL CLIENTE.  ";
                    oPara4.Range.Font.Name = "Times New Roman";
                    oPara4.Range.Font.Size = 12;
                    oPara4.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara4.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara4.Format.SpaceAfter = 15;
                    oPara4.Range.InsertParagraphAfter();


                    Word.Paragraph oPara5;
                    oPara5 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara5.Range.Text = "TERCERA: OBLIGACIONES DEL CLIENTE: a) EL CLIENTE está obligado a estar listo a las horas establecidas y " +
                        " para evitar retrasos en el servicio. b) EL CLIENTE está obligado a pagar la cantidad de" +
                        "Lps." + montocontrato + " por el servicio de transporte convenidos. c) EL CLIENTE está obligado " +
                        "a pagar por el servicio a más tardar el 2 dias al FINALIZAR el viaje, si hay retraso en el pago se cobrara el 5% de multa por cada 2 días" +
                        " de retraso.";
                    oPara5.Range.Font.Size = 12;
                    oPara5.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara5.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara5.Format.SpaceAfter = 15;
                    oPara5.Range.InsertParagraphAfter();

                    Word.Paragraph oPara6;
                    oPara6 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara6.Range.Text = "CUARTA:  PLAZO DEL CONTRATO: el plazo del presente contrato será " +
                        " del " + DateTime.Parse(fechaini).ToString("dd") + " dias del mes " + DateTime.Parse(fechaini).ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del año " + DateTime.Parse(fechafin).ToString("yyyy", new CultureInfo("es-ES")) + " hasta la fecha de " + DateTime.Parse(fechafin).ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del año " + DateTime.Parse(fechafin).ToString("yyyy", new CultureInfo("es-ES"));
                    oPara6.Range.Font.Size = 12;
                    oPara6.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara6.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara6.Format.SpaceAfter = 15;
                    oPara6.Range.InsertParagraphAfter();

                    Word.Paragraph oPara7;
                    oPara7 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara7.Range.Text = " QUINTA: INCUMPLIMIENTO: el hecho de que cualquiera de las" +
                        " partes incumpla alguno de los compromisos y obligaciones que se derivan del presente contrato, será justificante derecho el" +
                        " presente contrato. AMBAS PARTES se reservan el derecho de acudir a la vía correspondiente con el fin de cubrir daños y" +
                        " perjuicios ocasionados por el incumplimiento en que pueda incurrir LA OTRA PARTE.";
                    oPara7.Range.Font.Size = 12;
                    oPara7.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara7.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara7.Format.SpaceAfter = 24;
                    oPara7.Range.InsertParagraphAfter();

                    Word.Paragraph oPara8;
                    oPara8 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara8.Range.Text = "SEXTA: VENCIMIENTO ANTICIPADO: " +
                        "a) En caso de que alguna de las partes deseare romper unilateralmente el presente contrato deberá notificar a la otra " +
                        "parte con diez días naturales de anticipación a la fecha de conclusión del servicio. " +
                        "b) Si por cualquier motivo EL CLIENTE rescindiera de los servicios de transporte y pago con anticipo este será deuvelto";
                    oPara8.Range.Font.Size = 12;
                    oPara8.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara8.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara8.Format.SpaceAfter = 15;
                    oPara8.Range.InsertParagraphAfter();

                    Word.Paragraph oPara9;
                    oPara9 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara9.Range.Text = "SEPTIMA: Declaran “EL TRANSPORTISTA” y “EL CLIENTE, que aceptan las cláusulas estipuladas en este " +
                        "CONTRATO DE SERVICIOS y para dar fe de lo convenido, " +
                        "firman el mismo en la ciudad de COMAYAGUA , departamento de COMAYAGUA, a los " + DateTime.Now.Day + " días del mes de " + DateTime.Now.ToString("MMMM", new CultureInfo("es-ES")).ToUpper() + " del " + DateTime.Now.Year.ToString() + " . ";
                    oPara9.Range.Font.Size = 12;
                    oPara9.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                    oPara9.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara9.Format.SpaceAfter = 300;
                    oPara9.Range.InsertParagraphAfter();

                    Word.Paragraph oPara10;
                    oPara10 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oPara10.Range.Text = "EL CLIENTE			                                         EL TRANSPORTISTA";
                    oPara10.Range.Font.Size = 12;
                    oPara10.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    oPara10.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                    oPara10.Format.SpaceAfter = 40;
                    oPara10.Range.InsertParagraphAfter();

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
            idecliente= dgvGenerarContrato.CurrentRow.Cells[1].Value.ToString();
            cliente = dgvGenerarContrato.CurrentRow.Cells[2].Value.ToString();
            tipocon = dgvGenerarContrato.CurrentRow.Cells[3].Value.ToString();
            mensualidad = dgvGenerarContrato.CurrentRow.Cells[4].Value.ToString();
            cuotas = dgvGenerarContrato.CurrentRow.Cells[5].Value.ToString();
            servicio = dgvGenerarContrato.CurrentRow.Cells[6].Value.ToString();
            montocontrato = dgvGenerarContrato.CurrentRow.Cells[7].Value.ToString();
            fechaini = dgvGenerarContrato.CurrentRow.Cells[8].Value.ToString();
            fechafin = dgvGenerarContrato.CurrentRow.Cells[9].Value.ToString();
            ruta = dgvGenerarContrato.CurrentRow.Cells[10].Value.ToString();
            parada = dgvGenerarContrato.CurrentRow.Cells[11].Value.ToString();
            anticipo = dgvGenerarContrato.CurrentRow.Cells[12].Value.ToString();
            btnGenerar.Enabled = true;
        }
    }
}
