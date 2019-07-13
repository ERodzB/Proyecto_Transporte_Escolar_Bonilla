namespace Transporte_Escolar_Bonilla
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
            this.cliente1_panel.Margin = new System.Windows.Forms.Padding(4);
            this.cliente1_panel.Name = "cliente1_panel";
            this.cliente1_panel.Size = new System.Drawing.Size(1104, 649);
            this.cliente1_panel.TabIndex = 0;
            // 
            // combTipoContrato
            // 
            this.combTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTipoContrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combTipoContrato.FormattingEnabled = true;
            this.combTipoContrato.Location = new System.Drawing.Point(405, 495);
            this.combTipoContrato.Margin = new System.Windows.Forms.Padding(4);
            this.combTipoContrato.Name = "combTipoContrato";
            this.combTipoContrato.Size = new System.Drawing.Size(235, 31);
            this.combTipoContrato.TabIndex = 178;
            this.combTipoContrato.SelectedIndexChanged += new System.EventHandler(this.CombTipoContrato_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(400, 458);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 33);
            this.label3.TabIndex = 97;
            this.label3.Text = "Tipo de Contrato";
            // 
            // labsiguiente
            // 
            this.labsiguiente.AutoSize = true;
            this.labsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labsiguiente.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.labsiguiente.Location = new System.Drawing.Point(848, 544);
            this.labsiguiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labsiguiente.Name = "labsiguiente";
            this.labsiguiente.Size = new System.Drawing.Size(150, 37);
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
            this.label1.Location = new System.Drawing.Point(73, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 91;
            this.label1.Text = "Número de Identidad";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(80, 100);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.MaxLength = 13;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(379, 41);
            this.txtid.TabIndex = 1;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtid_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(515, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 33);
            this.label2.TabIndex = 92;
            this.label2.Text = "Nombre";
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(521, 100);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.MaxLength = 50;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(481, 41);
            this.txtnom.TabIndex = 2;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnom_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(73, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 33);
            this.label12.TabIndex = 93;
            this.label12.Text = "Dirección";
            // 
            // txtdir
            // 
            this.txtdir.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdir.Location = new System.Drawing.Point(80, 234);
            this.txtdir.Margin = new System.Windows.Forms.Padding(4);
            this.txtdir.MaxLength = 50;
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(799, 41);
            this.txtdir.TabIndex = 3;
            this.txtdir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtdir_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(73, 324);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 33);
            this.label13.TabIndex = 94;
            this.label13.Text = "Teléfono";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(80, 362);
            this.txttel.Margin = new System.Windows.Forms.Padding(4);
            this.txttel.MaxLength = 8;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(379, 41);
            this.txttel.TabIndex = 4;
            this.txttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txttel_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(515, 324);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 33);
            this.label14.TabIndex = 95;
            this.label14.Text = "Correo Electrónico";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(521, 362);
            this.txtcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcorreo.MaxLength = 50;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(481, 41);
            this.txtcorreo.TabIndex = 5;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcorreo_KeyPress);
            // 
            // form_nuevo_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1104, 649);
            this.Controls.Add(this.cliente1_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}