namespace Transporte_Escolar_Bonilla
{
    partial class nuevoempleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtidentidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.dtpvencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.txtlicencia = new System.Windows.Forms.TextBox();
            this.LBLLicencia = new System.Windows.Forms.Label();
            this.DAdicionales = new System.Windows.Forms.Label();
            this.GBlicencia = new System.Windows.Forms.GroupBox();
            this.CBInter = new System.Windows.Forms.CheckBox();
            this.RBPesada = new System.Windows.Forms.RadioButton();
            this.RBLiviana = new System.Windows.Forms.RadioButton();
            this.lbltipolic = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GBlicencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtidentidad
            // 
            this.txtidentidad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidentidad.Location = new System.Drawing.Point(284, 58);
            this.txtidentidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtidentidad.MaxLength = 13;
            this.txtidentidad.Name = "txtidentidad";
            this.txtidentidad.Size = new System.Drawing.Size(391, 30);
            this.txtidentidad.TabIndex = 1;
            this.txtidentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtidentidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de  Identidad:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(284, 92);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MaxLength = 100;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(391, 30);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre Empleado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(185, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Género:";
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(284, 193);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefono.MaxLength = 8;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(391, 30);
            this.txttelefono.TabIndex = 5;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(179, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Teléfono:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(284, 227);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcorreo.MaxLength = 100;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(391, 30);
            this.txtcorreo.TabIndex = 6;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcorreo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(193, 230);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Correo:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(284, 262);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdireccion.MaxLength = 100;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(391, 30);
            this.txtdireccion.TabIndex = 7;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdireccion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(170, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(195, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Puesto:";
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(284, 329);
            this.txtsalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtsalario.MaxLength = 13;
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(391, 30);
            this.txtsalario.TabIndex = 9;
            this.txtsalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtsalario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(197, 332);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Salario:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(694, 461);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 50);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 126);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(391, 30);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2001, 12, 31, 0, 0, 0, 0);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.cmbGenero.Location = new System.Drawing.Point(284, 160);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(391, 29);
            this.cmbGenero.TabIndex = 4;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Conductor"});
            this.cmbPuesto.Location = new System.Drawing.Point(284, 296);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(391, 29);
            this.cmbPuesto.TabIndex = 8;
            this.cmbPuesto.SelectedIndexChanged += new System.EventHandler(this.CmbPuesto_SelectedIndexChanged);
            // 
            // dtpvencimiento
            // 
            this.dtpvencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpvencimiento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvencimiento.Location = new System.Drawing.Point(284, 433);
            this.dtpvencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpvencimiento.Name = "dtpvencimiento";
            this.dtpvencimiento.Size = new System.Drawing.Size(391, 30);
            this.dtpvencimiento.TabIndex = 11;
            this.dtpvencimiento.Visible = false;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.Color.White;
            this.lblVencimiento.Location = new System.Drawing.Point(51, 428);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(220, 44);
            this.lblVencimiento.TabIndex = 26;
            this.lblVencimiento.Text = "Fecha de Vencimiento\r\n de Licencia:";
            this.lblVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVencimiento.Visible = false;
            // 
            // txtlicencia
            // 
            this.txtlicencia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlicencia.Location = new System.Drawing.Point(284, 399);
            this.txtlicencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtlicencia.MaxLength = 100;
            this.txtlicencia.Name = "txtlicencia";
            this.txtlicencia.Size = new System.Drawing.Size(391, 30);
            this.txtlicencia.TabIndex = 10;
            this.txtlicencia.Visible = false;
            this.txtlicencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtlicencia_KeyPress);
            // 
            // LBLLicencia
            // 
            this.LBLLicencia.AutoSize = true;
            this.LBLLicencia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLicencia.ForeColor = System.Drawing.Color.White;
            this.LBLLicencia.Location = new System.Drawing.Point(41, 402);
            this.LBLLicencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLLicencia.Name = "LBLLicencia";
            this.LBLLicencia.Size = new System.Drawing.Size(230, 22);
            this.LBLLicencia.TabIndex = 25;
            this.LBLLicencia.Text = "# Licencia de Conducir:";
            this.LBLLicencia.Visible = false;
            // 
            // DAdicionales
            // 
            this.DAdicionales.AutoSize = true;
            this.DAdicionales.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DAdicionales.ForeColor = System.Drawing.Color.White;
            this.DAdicionales.Location = new System.Drawing.Point(282, 375);
            this.DAdicionales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DAdicionales.Name = "DAdicionales";
            this.DAdicionales.Size = new System.Drawing.Size(173, 22);
            this.DAdicionales.TabIndex = 27;
            this.DAdicionales.Text = "Datos Adicionales";
            this.DAdicionales.Visible = false;
            // 
            // GBlicencia
            // 
            this.GBlicencia.Controls.Add(this.CBInter);
            this.GBlicencia.Controls.Add(this.RBPesada);
            this.GBlicencia.Controls.Add(this.RBLiviana);
            this.GBlicencia.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.GBlicencia.Location = new System.Drawing.Point(284, 461);
            this.GBlicencia.Margin = new System.Windows.Forms.Padding(2);
            this.GBlicencia.Name = "GBlicencia";
            this.GBlicencia.Padding = new System.Windows.Forms.Padding(2);
            this.GBlicencia.Size = new System.Drawing.Size(390, 49);
            this.GBlicencia.TabIndex = 53;
            this.GBlicencia.TabStop = false;
            this.GBlicencia.Visible = false;
            this.GBlicencia.Enter += new System.EventHandler(this.GBlicencia_Enter);
            // 
            // CBInter
            // 
            this.CBInter.AutoSize = true;
            this.CBInter.ForeColor = System.Drawing.Color.White;
            this.CBInter.Location = new System.Drawing.Point(238, 16);
            this.CBInter.Margin = new System.Windows.Forms.Padding(2);
            this.CBInter.Name = "CBInter";
            this.CBInter.Size = new System.Drawing.Size(151, 26);
            this.CBInter.TabIndex = 2;
            this.CBInter.Text = "Internacional";
            this.CBInter.UseVisualStyleBackColor = true;
            this.CBInter.CheckedChanged += new System.EventHandler(this.CBInter_CheckedChanged);
            // 
            // RBPesada
            // 
            this.RBPesada.AutoSize = true;
            this.RBPesada.ForeColor = System.Drawing.Color.White;
            this.RBPesada.Location = new System.Drawing.Point(104, 16);
            this.RBPesada.Margin = new System.Windows.Forms.Padding(2);
            this.RBPesada.Name = "RBPesada";
            this.RBPesada.Size = new System.Drawing.Size(97, 26);
            this.RBPesada.TabIndex = 1;
            this.RBPesada.TabStop = true;
            this.RBPesada.Text = "Pesada";
            this.RBPesada.UseVisualStyleBackColor = true;
            // 
            // RBLiviana
            // 
            this.RBLiviana.AutoSize = true;
            this.RBLiviana.ForeColor = System.Drawing.Color.White;
            this.RBLiviana.Location = new System.Drawing.Point(10, 16);
            this.RBLiviana.Margin = new System.Windows.Forms.Padding(2);
            this.RBLiviana.Name = "RBLiviana";
            this.RBLiviana.Size = new System.Drawing.Size(94, 26);
            this.RBLiviana.TabIndex = 0;
            this.RBLiviana.TabStop = true;
            this.RBLiviana.Text = "Liviana";
            this.RBLiviana.UseVisualStyleBackColor = true;
            this.RBLiviana.CheckedChanged += new System.EventHandler(this.RBLiviana_CheckedChanged);
            // 
            // lbltipolic
            // 
            this.lbltipolic.AutoSize = true;
            this.lbltipolic.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipolic.ForeColor = System.Drawing.Color.White;
            this.lbltipolic.Location = new System.Drawing.Point(109, 480);
            this.lbltipolic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltipolic.Name = "lbltipolic";
            this.lbltipolic.Size = new System.Drawing.Size(162, 22);
            this.lbltipolic.TabIndex = 52;
            this.lbltipolic.Text = "Tipo de Licencia:";
            this.lbltipolic.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(262, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(431, 37);
            this.label10.TabIndex = 54;
            this.label10.Text = "Ingreso de Nuevo Empleado";
            // 
            // nuevoempleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GBlicencia);
            this.Controls.Add(this.lbltipolic);
            this.Controls.Add(this.DAdicionales);
            this.Controls.Add(this.dtpvencimiento);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.txtlicencia);
            this.Controls.Add(this.LBLLicencia);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidentidad);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "nuevoempleado";
            this.Text = "nuevoempleado";
            this.Load += new System.EventHandler(this.Nuevoempleado_Load);
            this.GBlicencia.ResumeLayout(false);
            this.GBlicencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidentidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.DateTimePicker dtpvencimiento;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.TextBox txtlicencia;
        private System.Windows.Forms.Label LBLLicencia;
        private System.Windows.Forms.Label DAdicionales;
        private System.Windows.Forms.GroupBox GBlicencia;
        private System.Windows.Forms.CheckBox CBInter;
        private System.Windows.Forms.RadioButton RBPesada;
        private System.Windows.Forms.RadioButton RBLiviana;
        private System.Windows.Forms.Label lbltipolic;
        private System.Windows.Forms.Label label10;
    }
}