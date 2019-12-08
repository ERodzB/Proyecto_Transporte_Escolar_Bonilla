namespace Transporte_Escolar_Bonilla
{
    partial class modificarRutas_frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.opc_gp = new System.Windows.Forms.GroupBox();
            this.agregar_rb = new System.Windows.Forms.RadioButton();
            this.eliminarHorario_rb = new System.Windows.Forms.RadioButton();
            this.modiHorario_rb = new System.Windows.Forms.RadioButton();
            this.no_rb = new System.Windows.Forms.RadioButton();
            this.llegadaHorario_dtp = new System.Windows.Forms.DateTimePicker();
            this.entradaHorario_lbl = new System.Windows.Forms.Label();
            this.salidaHorario_lbl = new System.Windows.Forms.Label();
            this.horario_lbl = new System.Windows.Forms.Label();
            this.horaSalida_dtp = new System.Windows.Forms.DateTimePicker();
            this.Horario_cmb = new System.Windows.Forms.ComboBox();
            this.realizar_btn = new System.Windows.Forms.Button();
            this.rutasModificar_cmb = new System.Windows.Forms.ComboBox();
            this.vehiculo_lbl = new System.Windows.Forms.Label();
            this.vehiculo_cmb = new System.Windows.Forms.ComboBox();
            this.vehi_lbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.opc_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta a Modificar:";
            // 
            // opc_gp
            // 
            this.opc_gp.Controls.Add(this.agregar_rb);
            this.opc_gp.Controls.Add(this.eliminarHorario_rb);
            this.opc_gp.Controls.Add(this.modiHorario_rb);
            this.opc_gp.Controls.Add(this.no_rb);
            this.opc_gp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opc_gp.ForeColor = System.Drawing.Color.White;
            this.opc_gp.Location = new System.Drawing.Point(66, 124);
            this.opc_gp.Margin = new System.Windows.Forms.Padding(2);
            this.opc_gp.Name = "opc_gp";
            this.opc_gp.Padding = new System.Windows.Forms.Padding(2);
            this.opc_gp.Size = new System.Drawing.Size(698, 90);
            this.opc_gp.TabIndex = 6;
            this.opc_gp.TabStop = false;
            this.opc_gp.Text = "Horario";
            // 
            // agregar_rb
            // 
            this.agregar_rb.AutoSize = true;
            this.agregar_rb.Location = new System.Drawing.Point(159, 41);
            this.agregar_rb.Margin = new System.Windows.Forms.Padding(2);
            this.agregar_rb.Name = "agregar_rb";
            this.agregar_rb.Size = new System.Drawing.Size(176, 26);
            this.agregar_rb.TabIndex = 10;
            this.agregar_rb.Text = "Agregar Horario";
            this.agregar_rb.UseVisualStyleBackColor = true;
            this.agregar_rb.CheckedChanged += new System.EventHandler(this.Agregar_rb_CheckedChanged);
            // 
            // eliminarHorario_rb
            // 
            this.eliminarHorario_rb.AutoSize = true;
            this.eliminarHorario_rb.Location = new System.Drawing.Point(527, 41);
            this.eliminarHorario_rb.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarHorario_rb.Name = "eliminarHorario_rb";
            this.eliminarHorario_rb.Size = new System.Drawing.Size(165, 26);
            this.eliminarHorario_rb.TabIndex = 9;
            this.eliminarHorario_rb.Text = "Eliminar Horario";
            this.eliminarHorario_rb.UseVisualStyleBackColor = true;
            this.eliminarHorario_rb.CheckedChanged += new System.EventHandler(this.EliminarHorario_rb_CheckedChanged);
            // 
            // modiHorario_rb
            // 
            this.modiHorario_rb.AutoSize = true;
            this.modiHorario_rb.Location = new System.Drawing.Point(339, 41);
            this.modiHorario_rb.Margin = new System.Windows.Forms.Padding(2);
            this.modiHorario_rb.Name = "modiHorario_rb";
            this.modiHorario_rb.Size = new System.Drawing.Size(183, 26);
            this.modiHorario_rb.TabIndex = 8;
            this.modiHorario_rb.Text = "Modificar Horario";
            this.modiHorario_rb.UseVisualStyleBackColor = true;
            this.modiHorario_rb.CheckedChanged += new System.EventHandler(this.ModiHorario_rb_CheckedChanged);
            // 
            // no_rb
            // 
            this.no_rb.AutoSize = true;
            this.no_rb.Checked = true;
            this.no_rb.Location = new System.Drawing.Point(10, 41);
            this.no_rb.Margin = new System.Windows.Forms.Padding(2);
            this.no_rb.Name = "no_rb";
            this.no_rb.Size = new System.Drawing.Size(144, 26);
            this.no_rb.TabIndex = 7;
            this.no_rb.TabStop = true;
            this.no_rb.Text = "No Modificar";
            this.no_rb.UseVisualStyleBackColor = true;
            this.no_rb.CheckedChanged += new System.EventHandler(this.No_rb_CheckedChanged);
            // 
            // llegadaHorario_dtp
            // 
            this.llegadaHorario_dtp.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.llegadaHorario_dtp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llegadaHorario_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.llegadaHorario_dtp.Location = new System.Drawing.Point(390, 365);
            this.llegadaHorario_dtp.Name = "llegadaHorario_dtp";
            this.llegadaHorario_dtp.Size = new System.Drawing.Size(183, 34);
            this.llegadaHorario_dtp.TabIndex = 35;
            this.llegadaHorario_dtp.Visible = false;
            // 
            // entradaHorario_lbl
            // 
            this.entradaHorario_lbl.AutoSize = true;
            this.entradaHorario_lbl.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.entradaHorario_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.entradaHorario_lbl.Location = new System.Drawing.Point(166, 367);
            this.entradaHorario_lbl.Name = "entradaHorario_lbl";
            this.entradaHorario_lbl.Size = new System.Drawing.Size(210, 27);
            this.entradaHorario_lbl.TabIndex = 38;
            this.entradaHorario_lbl.Text = "Hora de Llegada:";
            this.entradaHorario_lbl.Visible = false;
            // 
            // salidaHorario_lbl
            // 
            this.salidaHorario_lbl.AutoSize = true;
            this.salidaHorario_lbl.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.salidaHorario_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.salidaHorario_lbl.Location = new System.Drawing.Point(190, 312);
            this.salidaHorario_lbl.Name = "salidaHorario_lbl";
            this.salidaHorario_lbl.Size = new System.Drawing.Size(186, 27);
            this.salidaHorario_lbl.TabIndex = 37;
            this.salidaHorario_lbl.Text = "Hora de Salida:";
            this.salidaHorario_lbl.Visible = false;
            // 
            // horario_lbl
            // 
            this.horario_lbl.AutoSize = true;
            this.horario_lbl.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.horario_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.horario_lbl.Location = new System.Drawing.Point(137, 260);
            this.horario_lbl.Name = "horario_lbl";
            this.horario_lbl.Size = new System.Drawing.Size(239, 27);
            this.horario_lbl.TabIndex = 36;
            this.horario_lbl.Text = "Horario a Modificar:";
            this.horario_lbl.Visible = false;
            // 
            // horaSalida_dtp
            // 
            this.horaSalida_dtp.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.horaSalida_dtp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaSalida_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.horaSalida_dtp.Location = new System.Drawing.Point(390, 310);
            this.horaSalida_dtp.Name = "horaSalida_dtp";
            this.horaSalida_dtp.Size = new System.Drawing.Size(183, 34);
            this.horaSalida_dtp.TabIndex = 34;
            this.horaSalida_dtp.Visible = false;
            // 
            // Horario_cmb
            // 
            this.Horario_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Horario_cmb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Horario_cmb.FormattingEnabled = true;
            this.Horario_cmb.Location = new System.Drawing.Point(390, 258);
            this.Horario_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.Horario_cmb.Name = "Horario_cmb";
            this.Horario_cmb.Size = new System.Drawing.Size(235, 33);
            this.Horario_cmb.TabIndex = 39;
            this.Horario_cmb.Visible = false;
            this.Horario_cmb.SelectedIndexChanged += new System.EventHandler(this.Horario_cmb_SelectedIndexChanged);
            // 
            // realizar_btn
            // 
            this.realizar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.realizar_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.realizar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.realizar_btn.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.realizar_btn.ForeColor = System.Drawing.Color.White;
            this.realizar_btn.Location = new System.Drawing.Point(649, 441);
            this.realizar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.realizar_btn.Name = "realizar_btn";
            this.realizar_btn.Size = new System.Drawing.Size(129, 50);
            this.realizar_btn.TabIndex = 40;
            this.realizar_btn.Text = "Modificar";
            this.realizar_btn.UseVisualStyleBackColor = false;
            this.realizar_btn.Visible = false;
            this.realizar_btn.Click += new System.EventHandler(this.Realizar_btn_Click);
            // 
            // rutasModificar_cmb
            // 
            this.rutasModificar_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rutasModificar_cmb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutasModificar_cmb.FormattingEnabled = true;
            this.rutasModificar_cmb.Location = new System.Drawing.Point(394, 79);
            this.rutasModificar_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.rutasModificar_cmb.Name = "rutasModificar_cmb";
            this.rutasModificar_cmb.Size = new System.Drawing.Size(254, 29);
            this.rutasModificar_cmb.TabIndex = 41;
            this.rutasModificar_cmb.SelectedIndexChanged += new System.EventHandler(this.RutasModificar_cmb_SelectedIndexChanged);
            this.rutasModificar_cmb.SelectedValueChanged += new System.EventHandler(this.RutasModificar_cmb_SelectedValueChanged);
            // 
            // vehiculo_lbl
            // 
            this.vehiculo_lbl.AutoSize = true;
            this.vehiculo_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiculo_lbl.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.vehiculo_lbl.Location = new System.Drawing.Point(387, 472);
            this.vehiculo_lbl.Name = "vehiculo_lbl";
            this.vehiculo_lbl.Size = new System.Drawing.Size(31, 19);
            this.vehiculo_lbl.TabIndex = 186;
            this.vehiculo_lbl.Text = "Fin";
            this.vehiculo_lbl.Visible = false;
            // 
            // vehiculo_cmb
            // 
            this.vehiculo_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehiculo_cmb.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.vehiculo_cmb.FormattingEnabled = true;
            this.vehiculo_cmb.Location = new System.Drawing.Point(390, 422);
            this.vehiculo_cmb.Name = "vehiculo_cmb";
            this.vehiculo_cmb.Size = new System.Drawing.Size(183, 31);
            this.vehiculo_cmb.TabIndex = 184;
            this.vehiculo_cmb.Visible = false;
            this.vehiculo_cmb.SelectedValueChanged += new System.EventHandler(this.Vehiculo_cmb_SelectedValueChanged);
            // 
            // vehi_lbl
            // 
            this.vehi_lbl.AutoSize = true;
            this.vehi_lbl.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.vehi_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.vehi_lbl.Location = new System.Drawing.Point(52, 421);
            this.vehi_lbl.Name = "vehi_lbl";
            this.vehi_lbl.Size = new System.Drawing.Size(324, 27);
            this.vehi_lbl.TabIndex = 185;
            this.vehi_lbl.Text = "Vehículo a Realizar la Ruta:";
            this.vehi_lbl.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(291, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 37);
            this.label13.TabIndex = 187;
            this.label13.Text = "Modificar Rutas";
            // 
            // modificarRutas_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.vehiculo_lbl);
            this.Controls.Add(this.vehiculo_cmb);
            this.Controls.Add(this.vehi_lbl);
            this.Controls.Add(this.rutasModificar_cmb);
            this.Controls.Add(this.realizar_btn);
            this.Controls.Add(this.Horario_cmb);
            this.Controls.Add(this.llegadaHorario_dtp);
            this.Controls.Add(this.entradaHorario_lbl);
            this.Controls.Add(this.salidaHorario_lbl);
            this.Controls.Add(this.horario_lbl);
            this.Controls.Add(this.horaSalida_dtp);
            this.Controls.Add(this.opc_gp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modificarRutas_frm";
            this.Text = "modificarRutas_frm";
            this.Load += new System.EventHandler(this.ModificarRutas_frm_Load);
            this.opc_gp.ResumeLayout(false);
            this.opc_gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox opc_gp;
        private System.Windows.Forms.RadioButton eliminarHorario_rb;
        private System.Windows.Forms.RadioButton modiHorario_rb;
        private System.Windows.Forms.RadioButton no_rb;
        private System.Windows.Forms.DateTimePicker llegadaHorario_dtp;
        private System.Windows.Forms.Label entradaHorario_lbl;
        private System.Windows.Forms.Label salidaHorario_lbl;
        private System.Windows.Forms.Label horario_lbl;
        private System.Windows.Forms.DateTimePicker horaSalida_dtp;
        private System.Windows.Forms.ComboBox Horario_cmb;
        private System.Windows.Forms.Button realizar_btn;
        private System.Windows.Forms.RadioButton agregar_rb;
        private System.Windows.Forms.ComboBox rutasModificar_cmb;
        private System.Windows.Forms.Label vehiculo_lbl;
        private System.Windows.Forms.ComboBox vehiculo_cmb;
        private System.Windows.Forms.Label vehi_lbl;
        private System.Windows.Forms.Label label13;
    }
}