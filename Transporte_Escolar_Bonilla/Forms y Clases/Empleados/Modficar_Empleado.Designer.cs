﻿namespace Transporte_Escolar_Bonilla
{
    partial class Modficar_Empleado
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
            this.dtpvencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBLLicencia = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlicencia = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltipolic = new System.Windows.Forms.Label();
            this.GBlicencia = new System.Windows.Forms.GroupBox();
            this.CBInter = new System.Windows.Forms.CheckBox();
            this.RBPesada = new System.Windows.Forms.RadioButton();
            this.RBLiviana = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.GBlicencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpvencimiento
            // 
            this.dtpvencimiento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpvencimiento.Enabled = false;
            this.dtpvencimiento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvencimiento.Location = new System.Drawing.Point(275, 410);
            this.dtpvencimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpvencimiento.Name = "dtpvencimiento";
            this.dtpvencimiento.Size = new System.Drawing.Size(391, 30);
            this.dtpvencimiento.TabIndex = 43;
            this.dtpvencimiento.Visible = false;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVencimiento.ForeColor = System.Drawing.Color.White;
            this.lblVencimiento.Location = new System.Drawing.Point(40, 405);
            this.lblVencimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(220, 44);
            this.lblVencimiento.TabIndex = 44;
            this.lblVencimiento.Text = "Fecha de Vencimiento\r\n de Licencia:";
            this.lblVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVencimiento.Visible = false;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.Enabled = false;
            this.cmbPuesto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "Conductor"});
            this.cmbPuesto.Location = new System.Drawing.Point(275, 309);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(391, 29);
            this.cmbPuesto.TabIndex = 34;
            this.cmbPuesto.SelectedIndexChanged += new System.EventHandler(this.CmbPuesto_SelectedIndexChanged);
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Enabled = false;
            this.cmbGenero.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.cmbGenero.Location = new System.Drawing.Point(275, 173);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(391, 29);
            this.cmbGenero.TabIndex = 29;
            // 
            // txtsalario
            // 
            this.txtsalario.Enabled = false;
            this.txtsalario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(275, 342);
            this.txtsalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtsalario.MaxLength = 13;
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(391, 30);
            this.txtsalario.TabIndex = 35;
            this.txtsalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtsalario_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(186, 345);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 22);
            this.label9.TabIndex = 42;
            this.label9.Text = "Salario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(184, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 41;
            this.label8.Text = "Puesto:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(275, 275);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdireccion.MaxLength = 50;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(391, 30);
            this.txtdireccion.TabIndex = 32;
            this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdireccion_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(159, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 40;
            this.label7.Text = "Dirección:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Enabled = false;
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(275, 241);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcorreo.MaxLength = 30;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(391, 30);
            this.txtcorreo.TabIndex = 31;
            this.txtcorreo.TextChanged += new System.EventHandler(this.Txtcorreo_TextChanged);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcorreo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(182, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Correo:";
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(275, 207);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefono.MaxLength = 8;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(391, 30);
            this.txttelefono.TabIndex = 30;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttelefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(168, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(174, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 37;
            this.label4.Text = "Género:";
            // 
            // LBLLicencia
            // 
            this.LBLLicencia.AutoSize = true;
            this.LBLLicencia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLicencia.ForeColor = System.Drawing.Color.White;
            this.LBLLicencia.Location = new System.Drawing.Point(30, 379);
            this.LBLLicencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBLLicencia.Name = "LBLLicencia";
            this.LBLLicencia.Size = new System.Drawing.Size(230, 22);
            this.LBLLicencia.TabIndex = 36;
            this.LBLLicencia.Text = "# Licencia de Conducir:";
            this.LBLLicencia.Visible = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(275, 139);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(391, 30);
            this.txtnombre.TabIndex = 27;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombre Empleado:";
            // 
            // txtlicencia
            // 
            this.txtlicencia.Enabled = false;
            this.txtlicencia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlicencia.Location = new System.Drawing.Point(275, 376);
            this.txtlicencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtlicencia.MaxLength = 20;
            this.txtlicencia.Name = "txtlicencia";
            this.txtlicencia.Size = new System.Drawing.Size(391, 30);
            this.txtlicencia.TabIndex = 45;
            this.txtlicencia.Visible = false;
            this.txtlicencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtlicencia_KeyPress);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(685, 448);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 50);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // busqueda
            // 
            this.busqueda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqueda.Location = new System.Drawing.Point(275, 86);
            this.busqueda.Margin = new System.Windows.Forms.Padding(2);
            this.busqueda.MaxLength = 13;
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(391, 30);
            this.busqueda.TabIndex = 47;
            this.busqueda.TextChanged += new System.EventHandler(this.Busqueda_TextChanged);
            this.busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Busqueda_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Identidad del Empleado a buscar:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(685, 81);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 49;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lbltipolic
            // 
            this.lbltipolic.AutoSize = true;
            this.lbltipolic.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipolic.ForeColor = System.Drawing.Color.White;
            this.lbltipolic.Location = new System.Drawing.Point(98, 463);
            this.lbltipolic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltipolic.Name = "lbltipolic";
            this.lbltipolic.Size = new System.Drawing.Size(162, 22);
            this.lbltipolic.TabIndex = 50;
            this.lbltipolic.Text = "Tipo de Licencia:";
            this.lbltipolic.Visible = false;
            // 
            // GBlicencia
            // 
            this.GBlicencia.Controls.Add(this.CBInter);
            this.GBlicencia.Controls.Add(this.RBPesada);
            this.GBlicencia.Controls.Add(this.RBLiviana);
            this.GBlicencia.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.GBlicencia.Location = new System.Drawing.Point(275, 445);
            this.GBlicencia.Margin = new System.Windows.Forms.Padding(2);
            this.GBlicencia.Name = "GBlicencia";
            this.GBlicencia.Padding = new System.Windows.Forms.Padding(2);
            this.GBlicencia.Size = new System.Drawing.Size(390, 49);
            this.GBlicencia.TabIndex = 51;
            this.GBlicencia.TabStop = false;
            this.GBlicencia.Visible = false;
            // 
            // CBInter
            // 
            this.CBInter.AutoSize = true;
            this.CBInter.Enabled = false;
            this.CBInter.ForeColor = System.Drawing.Color.White;
            this.CBInter.Location = new System.Drawing.Point(235, 16);
            this.CBInter.Margin = new System.Windows.Forms.Padding(2);
            this.CBInter.Name = "CBInter";
            this.CBInter.Size = new System.Drawing.Size(151, 26);
            this.CBInter.TabIndex = 2;
            this.CBInter.Text = "Internacional";
            this.CBInter.UseVisualStyleBackColor = true;
            // 
            // RBPesada
            // 
            this.RBPesada.AutoSize = true;
            this.RBPesada.Enabled = false;
            this.RBPesada.ForeColor = System.Drawing.Color.White;
            this.RBPesada.Location = new System.Drawing.Point(105, 16);
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
            this.RBLiviana.Enabled = false;
            this.RBLiviana.ForeColor = System.Drawing.Color.White;
            this.RBLiviana.Location = new System.Drawing.Point(11, 16);
            this.RBLiviana.Margin = new System.Windows.Forms.Padding(2);
            this.RBLiviana.Name = "RBLiviana";
            this.RBLiviana.Size = new System.Drawing.Size(94, 26);
            this.RBLiviana.TabIndex = 0;
            this.RBLiviana.TabStop = true;
            this.RBLiviana.Text = "Liviana";
            this.RBLiviana.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(177, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 37);
            this.label3.TabIndex = 52;
            this.label3.Text = "Modificar Datos de Empleados";
            // 
            // Modficar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GBlicencia);
            this.Controls.Add(this.lbltipolic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtlicencia);
            this.Controls.Add(this.dtpvencimiento);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.cmbGenero);
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
            this.Controls.Add(this.LBLLicencia);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1, 0);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Modficar_Empleado";
            this.Text = "Modficar_Empleado";
            this.Load += new System.EventHandler(this.Modficar_Empleado_Load);
            this.GBlicencia.ResumeLayout(false);
            this.GBlicencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpvencimiento;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBLLicencia;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlicencia;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltipolic;
        private System.Windows.Forms.GroupBox GBlicencia;
        private System.Windows.Forms.CheckBox CBInter;
        private System.Windows.Forms.RadioButton RBPesada;
        private System.Windows.Forms.RadioButton RBLiviana;
        private System.Windows.Forms.Label label3;
    }
}