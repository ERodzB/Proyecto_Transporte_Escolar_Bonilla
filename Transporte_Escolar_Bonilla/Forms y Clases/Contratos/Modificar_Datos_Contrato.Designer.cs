﻿namespace Transporte_Escolar_Bonilla
{
    partial class Modificar_Datos_Contrato
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
            this.dgvDatosContrato = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContrato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.datos_contrato_panel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFechaFinal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.lblCuota = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.cmbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMontoMensual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTipoContrato = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosContrato)).BeginInit();
            this.datos_contrato_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDatosContrato
            // 
            this.dgvDatosContrato.AllowUserToAddRows = false;
            this.dgvDatosContrato.AllowUserToDeleteRows = false;
            this.dgvDatosContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosContrato.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatosContrato.Location = new System.Drawing.Point(63, 104);
            this.dgvDatosContrato.Name = "dgvDatosContrato";
            this.dgvDatosContrato.ReadOnly = true;
            this.dgvDatosContrato.RowHeadersWidth = 51;
            this.dgvDatosContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosContrato.Size = new System.Drawing.Size(308, 326);
            this.dgvDatosContrato.TabIndex = 0;
            this.dgvDatosContrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosContrato_CellClick);
            this.dgvDatosContrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosContrato_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modificar Contrato";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(409, 127);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(151, 27);
            this.txtCliente.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(635, 461);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(122, 50);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(616, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Contrato:";
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(407, 418);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(148, 27);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMonto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(406, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente:";
            // 
            // txtContrato
            // 
            this.txtContrato.Enabled = false;
            this.txtContrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.Location = new System.Drawing.Point(621, 127);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(147, 27);
            this.txtContrato.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(405, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Inicio del Contrato:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(404, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Monto del Contrato:";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(63, 461);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(122, 50);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(615, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado del Contrato:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(619, 415);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(147, 29);
            this.cmbEstado.TabIndex = 17;
            // 
            // datos_contrato_panel
            // 
            this.datos_contrato_panel.Controls.Add(this.label13);
            this.datos_contrato_panel.Controls.Add(this.txtFechaFinal);
            this.datos_contrato_panel.Controls.Add(this.label12);
            this.datos_contrato_panel.Controls.Add(this.txtAnticipo);
            this.datos_contrato_panel.Controls.Add(this.lblCuota);
            this.datos_contrato_panel.Controls.Add(this.txtCuota);
            this.datos_contrato_panel.Controls.Add(this.label11);
            this.datos_contrato_panel.Controls.Add(this.label10);
            this.datos_contrato_panel.Controls.Add(this.cmbTipoPago);
            this.datos_contrato_panel.Controls.Add(this.cmbTipoServicio);
            this.datos_contrato_panel.Controls.Add(this.label9);
            this.datos_contrato_panel.Controls.Add(this.txtMontoMensual);
            this.datos_contrato_panel.Controls.Add(this.label8);
            this.datos_contrato_panel.Controls.Add(this.txtTipoContrato);
            this.datos_contrato_panel.Controls.Add(this.dtpInicio);
            this.datos_contrato_panel.Controls.Add(this.cmbEstado);
            this.datos_contrato_panel.Controls.Add(this.label7);
            this.datos_contrato_panel.Controls.Add(this.label6);
            this.datos_contrato_panel.Controls.Add(this.btnAtras);
            this.datos_contrato_panel.Controls.Add(this.label5);
            this.datos_contrato_panel.Controls.Add(this.label4);
            this.datos_contrato_panel.Controls.Add(this.txtContrato);
            this.datos_contrato_panel.Controls.Add(this.label3);
            this.datos_contrato_panel.Controls.Add(this.txtMonto);
            this.datos_contrato_panel.Controls.Add(this.label2);
            this.datos_contrato_panel.Controls.Add(this.btnModificar);
            this.datos_contrato_panel.Controls.Add(this.txtCliente);
            this.datos_contrato_panel.Controls.Add(this.label1);
            this.datos_contrato_panel.Controls.Add(this.dgvDatosContrato);
            this.datos_contrato_panel.Location = new System.Drawing.Point(2, 1);
            this.datos_contrato_panel.Name = "datos_contrato_panel";
            this.datos_contrato_panel.Size = new System.Drawing.Size(828, 527);
            this.datos_contrato_panel.TabIndex = 0;
            this.datos_contrato_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(213, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(439, 37);
            this.label13.TabIndex = 33;
            this.label13.Text = "Modificar Datos de Contratos";
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Enabled = false;
            this.txtFechaFinal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinal.Location = new System.Drawing.Point(408, 355);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(147, 27);
            this.txtFechaFinal.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(616, 330);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 22);
            this.label12.TabIndex = 31;
            this.label12.Text = "Anticipo:";
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Enabled = false;
            this.txtAnticipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnticipo.Location = new System.Drawing.Point(620, 357);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(148, 27);
            this.txtAnticipo.TabIndex = 30;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCuota.Location = new System.Drawing.Point(616, 271);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(81, 22);
            this.lblCuota.TabIndex = 29;
            this.lblCuota.Text = "Cuotas:";
            // 
            // txtCuota
            // 
            this.txtCuota.Enabled = false;
            this.txtCuota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuota.Location = new System.Drawing.Point(619, 297);
            this.txtCuota.MaxLength = 2;
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(78, 27);
            this.txtCuota.TabIndex = 28;
            this.txtCuota.TextChanged += new System.EventHandler(this.TxtCuota_TextChanged);
            this.txtCuota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCuota_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(617, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 22);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tipo de Pago:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(406, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Tipo Servicio:";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.Enabled = false;
            this.cmbTipoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(620, 240);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(147, 29);
            this.cmbTipoPago.TabIndex = 25;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.CmbTipoPago_SelectedIndexChanged);
            // 
            // cmbTipoServicio
            // 
            this.cmbTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoServicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoServicio.FormattingEnabled = true;
            this.cmbTipoServicio.Location = new System.Drawing.Point(408, 240);
            this.cmbTipoServicio.Name = "cmbTipoServicio";
            this.cmbTipoServicio.Size = new System.Drawing.Size(147, 29);
            this.cmbTipoServicio.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(617, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Monto Mensual:";
            // 
            // txtMontoMensual
            // 
            this.txtMontoMensual.Enabled = false;
            this.txtMontoMensual.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoMensual.Location = new System.Drawing.Point(620, 183);
            this.txtMontoMensual.Name = "txtMontoMensual";
            this.txtMontoMensual.Size = new System.Drawing.Size(147, 27);
            this.txtMontoMensual.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(406, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 22);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tipo Contrato:";
            // 
            // txtTipoContrato
            // 
            this.txtTipoContrato.Enabled = false;
            this.txtTipoContrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoContrato.Location = new System.Drawing.Point(409, 183);
            this.txtTipoContrato.Name = "txtTipoContrato";
            this.txtTipoContrato.Size = new System.Drawing.Size(151, 27);
            this.txtTipoContrato.TabIndex = 20;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "yyyy - m - dd";
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(408, 296);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(147, 27);
            this.dtpInicio.TabIndex = 19;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.DtpInicio_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(404, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Final del Contrato:";
            // 
            // Modificar_Datos_Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.datos_contrato_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar_Datos_Contrato";
            this.Text = "Modificar_Datos_Contrato";
            this.Load += new System.EventHandler(this.Modificar_Datos_Contrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosContrato)).EndInit();
            this.datos_contrato_panel.ResumeLayout(false);
            this.datos_contrato_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContrato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Panel datos_contrato_panel;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.ComboBox cmbTipoServicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMontoMensual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTipoContrato;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtFechaFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
    }
}