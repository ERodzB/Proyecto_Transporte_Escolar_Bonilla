﻿namespace Transporte_Escolar_Bonilla
{
    partial class form_nuevo_cliente
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
            this.cliente1_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.combTipoContrato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labsiguiente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.cliente1_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cliente1_panel
            // 
            this.cliente1_panel.Controls.Add(this.label4);
            this.cliente1_panel.Controls.Add(this.combTipoContrato);
            this.cliente1_panel.Controls.Add(this.label3);
            this.cliente1_panel.Controls.Add(this.labsiguiente);
            this.cliente1_panel.Controls.Add(this.label1);
            this.cliente1_panel.Controls.Add(this.txtid);
            this.cliente1_panel.Controls.Add(this.label2);
            this.cliente1_panel.Controls.Add(this.txtnom);
            this.cliente1_panel.Controls.Add(this.label12);
            this.cliente1_panel.Controls.Add(this.txtdir);
            this.cliente1_panel.Controls.Add(this.label13);
            this.cliente1_panel.Controls.Add(this.txttel);
            this.cliente1_panel.Controls.Add(this.label14);
            this.cliente1_panel.Controls.Add(this.txtcorreo);
            this.cliente1_panel.Location = new System.Drawing.Point(1, 0);
            this.cliente1_panel.Name = "cliente1_panel";
            this.cliente1_panel.Size = new System.Drawing.Size(828, 527);
            this.cliente1_panel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(199, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(421, 37);
            this.label4.TabIndex = 179;
            this.label4.Text = "Datos Generales del Cliente";
            // 
            // combTipoContrato
            // 
            this.combTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTipoContrato.Font = new System.Drawing.Font("Century Gothic", 16.2F);
            this.combTipoContrato.FormattingEnabled = true;
            this.combTipoContrato.Location = new System.Drawing.Point(304, 435);
            this.combTipoContrato.Name = "combTipoContrato";
            this.combTipoContrato.Size = new System.Drawing.Size(177, 33);
            this.combTipoContrato.TabIndex = 178;
            this.combTipoContrato.SelectedIndexChanged += new System.EventHandler(this.CombTipoContrato_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(300, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 97;
            this.label3.Text = "Tipo de Contrato:";
            // 
            // labsiguiente
            // 
            this.labsiguiente.AutoSize = true;
            this.labsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labsiguiente.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsiguiente.ForeColor = System.Drawing.Color.Lavender;
            this.labsiguiente.Location = new System.Drawing.Point(639, 452);
            this.labsiguiente.Name = "labsiguiente";
            this.labsiguiente.Size = new System.Drawing.Size(117, 28);
            this.labsiguiente.TabIndex = 96;
            this.labsiguiente.Text = "Siguiente";
            this.labsiguiente.Click += new System.EventHandler(this.Labsiguiente_Click);
            this.labsiguiente.MouseLeave += new System.EventHandler(this.Labsiguiente_MouseLeave);
            this.labsiguiente.MouseHover += new System.EventHandler(this.Labsiguiente_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Número de Identidad:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(60, 114);
            this.txtid.MaxLength = 14;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(285, 34);
            this.txtid.TabIndex = 1;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(386, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nombre:";
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(391, 114);
            this.txtnom.MaxLength = 100;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(362, 34);
            this.txtnom.TabIndex = 2;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnom_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(55, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 24);
            this.label12.TabIndex = 93;
            this.label12.Text = "Dirección:";
            // 
            // txtdir
            // 
            this.txtdir.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdir.Location = new System.Drawing.Point(60, 223);
            this.txtdir.MaxLength = 200;
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(693, 34);
            this.txtdir.TabIndex = 3;
            this.txtdir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdir_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(55, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 24);
            this.label13.TabIndex = 94;
            this.label13.Text = "Teléfono:";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(60, 327);
            this.txttel.MaxLength = 8;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(285, 34);
            this.txttel.TabIndex = 4;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttel_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(386, 296);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 24);
            this.label14.TabIndex = 95;
            this.label14.Text = "Correo Electrónico:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(391, 327);
            this.txtcorreo.MaxLength = 100;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(362, 34);
            this.txtcorreo.TabIndex = 5;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcorreo_KeyPress);
            // 
            // form_nuevo_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.cliente1_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_nuevo_cliente";
            this.Text = "form_nuevo_cliente";
            this.Load += new System.EventHandler(this.Form_nuevo_cliente_Load);
            this.cliente1_panel.ResumeLayout(false);
            this.cliente1_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cliente1_panel;
        private System.Windows.Forms.Label labsiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combTipoContrato;
        private System.Windows.Forms.Label label4;
    }
}