using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Transporte_Escolar_Bonilla.Forms_y_Clases.Contratos
{
    public partial class cotizacion : Form
    {
        public Double subtotal;
        Ingresar ing = new Ingresar();
        public cotizacion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/maps/dir///@14.0592217,-87.2431174,15z/data=!4m2!4m1!3e0");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCorreo.Text = "";
            txtDescuento.Text = "0";
            txtDistancia.Text = "";
            txtISV.Text = "";
            txtNombre.Text = "";
            txtRebaja.Text = "0";
            txtRegreso.Text = "";
            txtSalida.Text = "";
            txtSubtotal.Text = "";
            txtTarifa.Text = "";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtTotal.Text = "";
            RBRoundtrip.Checked = true;
            gbPago.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text!="" && txtCorreo.Text!="" && txtTelefono1.Text!="" && txtTelefono2.Text!="" &&
                txtSalida.Text!="" && txtRegreso.Text!="" && txtTarifa.Text!="" && txtDistancia.Text!="")
            {
                if (txtNombre.Text.Length > 3  && txtSalida.Text.Length > 3 && txtRegreso.Text.Length > 3)
                {
                    if (txtTelefono1.Text.Length == 8 && txtTelefono2.Text.Length == 8)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            if (Double.Parse(txtDistancia.Text) > 0 && Double.Parse(txtTarifa.Text) > 0)
                            {
                                if (rbSingle.Checked == true)
                                {
                                    subtotal = Double.Parse(txtDistancia.Text) * Double.Parse(txtTarifa.Text);

                                }
                                else
                                {
                                    subtotal = (Double.Parse(txtDistancia.Text) * Double.Parse(txtTarifa.Text)) * 2;
                                }

                                gbPago.Visible = true;
                                btnCalcular.Visible = false;
                                btnCotizar.Enabled = true;
                                txtSubtotal.Text = subtotal.ToString();
                                txtISV.Text = (Double.Parse(txtSubtotal.Text) * 0.15).ToString();
                                txtTotal.Text = (Double.Parse(txtSubtotal.Text) + Double.Parse(txtISV.Text)).ToString();
                            }
                            else
                                MessageBox.Show("Ingrese una distancia y una tarifa mayores a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Ingrese el correo en un formato válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Los telefonos deben ser igual a 8 caracteres cada uno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El nombre, punto de origen y destino final deben ser mayores a 3 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Debe llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RBRoundtrip_CheckedChanged(object sender, EventArgs e)
        {
            gbPago.Visible = false;
            btnCalcular.Visible = true;
            btnCotizar.Enabled = false;
            txtRebaja.Text = "0";
            txtDescuento.Text = "0";
        }

        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            gbPago.Visible = false;
            btnCalcular.Visible = true;
            btnCotizar.Enabled = false;
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            gbPago.Visible = false;
            btnCalcular.Visible = true;
            btnCotizar.Enabled = false;
        }

        private void txtTarifa_TextChanged(object sender, EventArgs e)
        {
            gbPago.Visible = false;
            btnCalcular.Visible = true;
            btnCotizar.Enabled = false;
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            btnRecalcular.Visible = true;
            btnCotizar.Enabled = false;
            if (txtDescuento.Text == "")
                txtDescuento.Text = "0";
            else { 
                if (Double.Parse(txtDescuento.Text) > 100)
                    txtDescuento.Text = "100";
                else
                    txtRebaja.Text = (subtotal * (Double.Parse(txtDescuento.Text) / 100)).ToString();
            }
        }



    private void txtRebaja_TextChanged(object sender, EventArgs e)
        {
            btnRecalcular.Visible = true;
            btnCotizar.Enabled = false;
            if (txtRebaja.Text == "")
                txtRebaja.Text = "0";
            else { 
                if (Double.Parse(txtRebaja.Text) > subtotal)
                    txtRebaja.Text = txtSubtotal.Text;
                else    
                    txtDescuento.Text = ((Double.Parse(txtRebaja.Text) / subtotal)*100).ToString();
            }
        }


        private void btnRecalcular_Click(object sender, EventArgs e)
        {
            btnRecalcular.Visible = false;
            btnCotizar.Enabled = true;
            txtSubtotal.Text =(subtotal-double.Parse(txtRebaja.Text)).ToString(); 
            txtISV.Text = (Double.Parse(txtSubtotal.Text) * 0.15).ToString();
            txtTotal.Text = (Double.Parse(txtSubtotal.Text) + Double.Parse(txtISV.Text)).ToString();
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {

        if (txtNombre.Text != "" && txtCorreo.Text != "" && txtTelefono1.Text != "" && txtTelefono2.Text != "" &&
            txtSalida.Text != "" && txtRegreso.Text != "" && txtTarifa.Text != "" && txtDistancia.Text != "")
            {
                if (txtNombre.Text.Length > 3 && txtSalida.Text.Length > 3 && txtRegreso.Text.Length > 3)
                {
                    if (txtTelefono1.Text.Length == 8 && txtTelefono2.Text.Length == 8)
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", System.Text.RegularExpressions.RegexOptions.IgnoreCase))
                        {
                            if (Double.Parse(txtDistancia.Text) > 0 && Double.Parse(txtTarifa.Text) > 0)
                            {

                                string nametipoviaje = "";

                                if (rbSingle.Checked == true)
                                    nametipoviaje = rbSingle.Text;
                                if (RBRoundtrip.Checked == true)
                                    nametipoviaje = RBRoundtrip.Text;
                                ing.NuevaCotizacion(txtNombre.Text, txtCorreo.Text, txtTelefono1.Text, txtTelefono2.Text, txtSalida.Text, txtRegreso.Text, Double.Parse(txtDistancia.Text), Double.Parse(txtTarifa.Text),
                                    nametipoviaje, Double.Parse(txtSubtotal.Text), Double.Parse(txtDescuento.Text), Double.Parse(txtISV.Text), Double.Parse(txtRebaja.Text), Double.Parse(txtTotal.Text));

                                if (MessageBox.Show("Desea Generar la Nueva Cotizacion?", "Generar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    object oMissing = System.Reflection.Missing.Value;
                                    object oEndOfDoc = "\\endofdoc";

                                    Word._Application oWord;
                                    Word._Document oDoc;
                                    oWord = new Word.Application();
                                    oWord.Visible = true;
                                    oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                                    oDoc.Tables.Add(oDoc.Range(), 5, 5, ref oMissing, ref oMissing);
                                    Word.Paragraph oPara1;
                                    oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);

                                    oPara1.Range.Text = "TRANSPORTE TRANSPORTE ESCOLAR BONILLA";
                                    oPara1.Range.Font.Underline = Word.WdUnderline.wdUnderlineSingle;
                                    oPara1.Range.Font.Name = "Times New Roman";
                                    oPara1.Format.SpaceAfter = 24;
                                    oPara1.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                                    oPara1.Range.InsertParagraphAfter();

                                    Word.Paragraph oPara2;
                                    Word.Paragraph oPara3;
                                    Word.Paragraph oPara4;
                                    Word.Paragraph oPara5;
                                    Word.Paragraph oPara6;
                                    Word.Paragraph oPara7;
                                    Word.Paragraph oPara8;
                                    Word.Paragraph oPara9;
                                    Word.Paragraph oPara10;

                                    oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara2.Range.Text = "Nombre del Interesado: " + txtNombre.Text;
                                    oPara2.Range.Font.Name = "Times New Roman";
                                    oPara2.Range.Font.Size = 12;
                                    oPara2.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara2.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara2.Format.SpaceAfter = 15;
                                    oPara2.Range.InsertParagraphAfter();

                                    oPara3 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara3.Range.Text = "Correo Electronico: " + txtCorreo.Text;
                                    oPara3.Range.Font.Name = "Times New Roman";
                                    oPara3.Range.Font.Size = 12;
                                    oPara3.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara3.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara3.Format.SpaceAfter = 15;
                                    oPara3.Range.InsertParagraphAfter();

                                    oPara4 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara4.Range.Text = "Telefonos: " + txtTelefono1.Text + "/" + txtTelefono2.Text;
                                    oPara4.Range.Font.Name = "Times New Roman";
                                    oPara4.Range.Font.Size = 12;
                                    oPara4.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara4.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara4.Format.SpaceAfter = 15;
                                    oPara4.Range.InsertParagraphAfter();

                                    oPara5 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara5.Range.Text = "Se ha solicitado la Cotizacion siguiente: ";
                                    oPara5.Range.Font.Name = "Times New Roman";
                                    oPara5.Range.Font.Size = 12;
                                    oPara5.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara5.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara5.Format.SpaceAfter = 15;
                                    oPara5.Range.InsertParagraphAfter();

                                    oPara6 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara6.Range.Text = "Un viaje Privado con destino a " + txtRegreso.Text + ", desde " + txtSalida.Text +
                                        ", " + "con una distancia de " + txtDistancia.Text + ", " + "A una tarifa por KM de " + txtTarifa.Text + ", " + "El cual el viaje de efectuara como " +
                                        RBRoundtrip.Text;
                                    oPara6.Range.Font.Name = "Times New Roman";
                                    oPara6.Range.Font.Size = 12;
                                    oPara6.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara6.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara6.Format.SpaceAfter = 15;
                                    oPara6.Range.InsertParagraphAfter();

                                    oPara7 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara7.Range.Text = "Subtotal: " + txtSubtotal.Text + "     " + "Descuento: " + txtDescuento.Text;
                                    oPara7.Range.Font.Name = "Times New Roman";
                                    oPara7.Range.Font.Size = 12;
                                    oPara7.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara7.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara7.Format.SpaceAfter = 15;
                                    oPara7.Range.InsertParagraphAfter();

                                    oPara8 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara8.Range.Text = "ISV: " + txtISV.Text + "        " + "Rebaja: " + txtRebaja.Text;
                                    oPara8.Range.Font.Name = "Times New Roman";
                                    oPara8.Range.Font.Size = 12;
                                    oPara8.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara8.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara8.Format.SpaceAfter = 15;
                                    oPara8.Range.InsertParagraphAfter();

                                    oPara9 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara9.Range.Text = "Total: " + txtTotal.Text;
                                    oPara9.Range.Font.Name = "Times New Roman";
                                    oPara9.Range.Font.Size = 12;
                                    oPara9.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara9.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara9.Format.SpaceAfter = 15;
                                    oPara9.Range.InsertParagraphAfter();

                                    oPara10 = oDoc.Content.Paragraphs.Add(ref oMissing);
                                    oPara10.Range.Text = "Se Hace present Dicha informacion para que se proceda con su revision de lo provisto";
                                    oPara10.Range.Font.Name = "Times New Roman";
                                    oPara10.Range.Font.Size = 12;
                                    oPara10.Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
                                    oPara10.Range.Font.Underline = Word.WdUnderline.wdUnderlineNone;
                                    oPara10.Format.SpaceAfter = 15;
                                    oPara10.Range.InsertParagraphAfter();
                                }


                                MessageBox.Show(ing.mensaje, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCorreo.Text = "";
                                txtDescuento.Text = "0";
                                txtDistancia.Text = "";
                                txtISV.Text = "";
                                txtNombre.Text = "";
                                txtRebaja.Text = "0";
                                txtRegreso.Text = "";
                                txtSalida.Text = "";
                                txtSubtotal.Text = "";
                                txtTarifa.Text = "";
                                txtTelefono1.Text = "";
                                txtTelefono2.Text = "";
                                txtTotal.Text = "";
                                RBRoundtrip.Checked = true;
                                gbPago.Visible = false;

                                
                            }
                            else
                                MessageBox.Show("Ingrese una distancia y una tarifa mayores a 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Ingrese el correo en un formato válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Los telefonos deben ser igual a 8 caracteres cada uno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("El nombre, punto de origen y destino final deben ser mayores a 3 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Debe llenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtRebaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRebaja.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtTarifa.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == '@'))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && txtSalida.Text.Trim().Length == 0)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtRegreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && txtRegreso.Text.Trim().Length == 0)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !(e.KeyChar == '.') && !(e.KeyChar == ','))
            {
                e.Handled = true;
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.')
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtRebaja.Text, "^\\d*\\.\\d{2}$")) e.Handled = true;
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
    }
}
