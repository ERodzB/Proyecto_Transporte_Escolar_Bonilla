namespace Transporte_Escolar_Bonilla
{
    partial class nuevoviaje
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
            this.txtpa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.botcrear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtant = new System.Windows.Forms.TextBox();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtphorae2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtphoras2 = new System.Windows.Forms.DateTimePicker();
            this.labv2 = new System.Windows.Forms.Label();
            this.combveh2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtphorae1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtphoras1 = new System.Windows.Forms.DateTimePicker();
            this.labv1 = new System.Windows.Forms.Label();
            this.combveh1 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtorigen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combservicio = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.combcliente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtpa
            // 
            this.txtpa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpa.Location = new System.Drawing.Point(348, 101);
            this.txtpa.MaxLength = 3;
            this.txtpa.Name = "txtpa";
            this.txtpa.Size = new System.Drawing.Size(65, 23);
            this.txtpa.TabIndex = 298;
            this.txtpa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpa_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(315, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 24);
            this.label12.TabIndex = 299;
            this.label12.Text = "No. Pasajeros:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 3);
            this.panel2.TabIndex = 297;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.SystemColors.Window;
            this.panel3.Location = new System.Drawing.Point(436, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 380);
            this.panel3.TabIndex = 296;
            // 
            // botcrear
            // 
            this.botcrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.botcrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botcrear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botcrear.ForeColor = System.Drawing.Color.Transparent;
            this.botcrear.Location = new System.Drawing.Point(589, 426);
            this.botcrear.Name = "botcrear";
            this.botcrear.Size = new System.Drawing.Size(109, 42);
            this.botcrear.TabIndex = 295;
            this.botcrear.Text = "Crear";
            this.botcrear.UseVisualStyleBackColor = false;
            this.botcrear.Click += new System.EventHandler(this.Botcrear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(566, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 24);
            this.label11.TabIndex = 294;
            this.label11.Text = "Total a Pagar";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(570, 287);
            this.txttotal.MaxLength = 9;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(145, 22);
            this.txttotal.TabIndex = 293;
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttotal_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(566, 333);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 24);
            this.label17.TabIndex = 292;
            this.label17.Text = "Anticipo";
            // 
            // txtant
            // 
            this.txtant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtant.Location = new System.Drawing.Point(570, 362);
            this.txtant.MaxLength = 9;
            this.txtant.Name = "txtant";
            this.txtant.Size = new System.Drawing.Size(145, 22);
            this.txtant.TabIndex = 291;
            this.txtant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtant_KeyPress);
            // 
            // dtpfin
            // 
            this.dtpfin.Location = new System.Drawing.Point(655, 194);
            this.dtpfin.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(145, 20);
            this.dtpfin.TabIndex = 290;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Location = new System.Drawing.Point(478, 194);
            this.dtpinicio.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(145, 20);
            this.dtpinicio.TabIndex = 289;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(651, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 288;
            this.label5.Text = "Finalización";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(474, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 24);
            this.label10.TabIndex = 287;
            this.label10.Text = "Inicio";
            // 
            // dtphorae2
            // 
            this.dtphorae2.Enabled = false;
            this.dtphorae2.Location = new System.Drawing.Point(138, 431);
            this.dtphorae2.Name = "dtphorae2";
            this.dtphorae2.Size = new System.Drawing.Size(94, 20);
            this.dtphorae2.TabIndex = 284;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(40, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 286;
            this.label3.Text = "Entrada: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(40, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 285;
            this.label4.Text = "Salida: ";
            // 
            // dtphoras2
            // 
            this.dtphoras2.Enabled = false;
            this.dtphoras2.Location = new System.Drawing.Point(138, 387);
            this.dtphoras2.Name = "dtphoras2";
            this.dtphoras2.Size = new System.Drawing.Size(94, 20);
            this.dtphoras2.TabIndex = 283;
            // 
            // labv2
            // 
            this.labv2.AutoSize = true;
            this.labv2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labv2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labv2.Location = new System.Drawing.Point(241, 449);
            this.labv2.Name = "labv2";
            this.labv2.Size = new System.Drawing.Size(31, 19);
            this.labv2.TabIndex = 282;
            this.labv2.Text = "Fin";
            this.labv2.Visible = false;
            // 
            // combveh2
            // 
            this.combveh2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combveh2.Enabled = false;
            this.combveh2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combveh2.FormattingEnabled = true;
            this.combveh2.Location = new System.Drawing.Point(277, 405);
            this.combveh2.Name = "combveh2";
            this.combveh2.Size = new System.Drawing.Size(122, 25);
            this.combveh2.TabIndex = 279;
            this.combveh2.SelectedIndexChanged += new System.EventHandler(this.Combveh2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(273, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 24);
            this.label8.TabIndex = 281;
            this.label8.Text = "Vehículo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(194, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 24);
            this.label9.TabIndex = 280;
            this.label9.Text = "Regreso";
            // 
            // dtphorae1
            // 
            this.dtphorae1.Location = new System.Drawing.Point(138, 260);
            this.dtphorae1.Name = "dtphorae1";
            this.dtphorae1.Size = new System.Drawing.Size(94, 20);
            this.dtphorae1.TabIndex = 276;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(40, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 278;
            this.label7.Text = "Entrada: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(40, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 277;
            this.label6.Text = "Salida: ";
            // 
            // dtphoras1
            // 
            this.dtphoras1.Location = new System.Drawing.Point(138, 216);
            this.dtphoras1.Name = "dtphoras1";
            this.dtphoras1.Size = new System.Drawing.Size(94, 20);
            this.dtphoras1.TabIndex = 275;
            // 
            // labv1
            // 
            this.labv1.AutoSize = true;
            this.labv1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labv1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labv1.Location = new System.Drawing.Point(241, 277);
            this.labv1.Name = "labv1";
            this.labv1.Size = new System.Drawing.Size(31, 19);
            this.labv1.TabIndex = 274;
            this.labv1.Text = "Fin";
            this.labv1.Visible = false;
            // 
            // combveh1
            // 
            this.combveh1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combveh1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combveh1.FormattingEnabled = true;
            this.combveh1.Location = new System.Drawing.Point(277, 234);
            this.combveh1.Name = "combveh1";
            this.combveh1.Size = new System.Drawing.Size(122, 25);
            this.combveh1.TabIndex = 271;
            this.combveh1.SelectedIndexChanged += new System.EventHandler(this.Combveh1_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Window;
            this.label22.Location = new System.Drawing.Point(273, 207);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 24);
            this.label22.TabIndex = 273;
            this.label22.Text = "Vehículo:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(212, 163);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 24);
            this.label19.TabIndex = 272;
            this.label19.Text = "Ida";
            // 
            // txtdestino
            // 
            this.txtdestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestino.Location = new System.Drawing.Point(589, 102);
            this.txtdestino.MaxLength = 50;
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(211, 23);
            this.txtdestino.TabIndex = 268;
            this.txtdestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdestino_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(484, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 270;
            this.label2.Text = "Destino:";
            // 
            // txtorigen
            // 
            this.txtorigen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtorigen.Location = new System.Drawing.Point(589, 59);
            this.txtorigen.MaxLength = 50;
            this.txtorigen.Name = "txtorigen";
            this.txtorigen.Size = new System.Drawing.Size(211, 23);
            this.txtorigen.TabIndex = 267;
            this.txtorigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtorigen_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(491, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 269;
            this.label1.Text = "Origen:";
            // 
            // combservicio
            // 
            this.combservicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combservicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combservicio.FormattingEnabled = true;
            this.combservicio.Items.AddRange(new object[] {
            "Salida o Regreso",
            "Salida y Regreso"});
            this.combservicio.Location = new System.Drawing.Point(120, 63);
            this.combservicio.Name = "combservicio";
            this.combservicio.Size = new System.Drawing.Size(146, 25);
            this.combservicio.TabIndex = 266;
            this.combservicio.SelectedIndexChanged += new System.EventHandler(this.Combservicio_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(10, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 24);
            this.label18.TabIndex = 265;
            this.label18.Text = "Servicio:";
            // 
            // combcliente
            // 
            this.combcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combcliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combcliente.FormattingEnabled = true;
            this.combcliente.Items.AddRange(new object[] {
            "Bus Completo",
            "Medio Bus"});
            this.combcliente.Location = new System.Drawing.Point(120, 102);
            this.combcliente.Name = "combcliente";
            this.combcliente.Size = new System.Drawing.Size(146, 25);
            this.combcliente.TabIndex = 301;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(22, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 24);
            this.label13.TabIndex = 300;
            this.label13.Text = "Cliente:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(175, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(419, 32);
            this.label14.TabIndex = 302;
            this.label14.Text = "Creación de Contrato de Viaje";
            // 
            // nuevoviaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.combcliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtpa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.botcrear);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtant);
            this.Controls.Add(this.dtpfin);
            this.Controls.Add(this.dtpinicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtphorae2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtphoras2);
            this.Controls.Add(this.labv2);
            this.Controls.Add(this.combveh2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtphorae1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtphoras1);
            this.Controls.Add(this.labv1);
            this.Controls.Add(this.combveh1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtdestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtorigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combservicio);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nuevoviaje";
            this.Text = "nuevoviaje";
            this.Load += new System.EventHandler(this.Nuevoviaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button botcrear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtant;
        private System.Windows.Forms.DateTimePicker dtpfin;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtphorae2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtphoras2;
        private System.Windows.Forms.Label labv2;
        private System.Windows.Forms.ComboBox combveh2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtphorae1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtphoras1;
        private System.Windows.Forms.Label labv1;
        private System.Windows.Forms.ComboBox combveh1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtorigen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combservicio;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox combcliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}