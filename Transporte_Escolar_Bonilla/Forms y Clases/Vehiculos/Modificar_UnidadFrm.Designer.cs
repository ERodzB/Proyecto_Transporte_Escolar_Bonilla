namespace Transporte_Escolar_Bonilla
{
    partial class Modificar_UnidadFrm
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
            this.mod_unidad_panel = new System.Windows.Forms.Panel();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstadoVehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mod_unidad_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // mod_unidad_panel
            // 
            this.mod_unidad_panel.Controls.Add(this.dgvVehiculos);
            this.mod_unidad_panel.Controls.Add(this.dtpVencimiento);
            this.mod_unidad_panel.Controls.Add(this.label6);
            this.mod_unidad_panel.Controls.Add(this.label5);
            this.mod_unidad_panel.Controls.Add(this.cmbEstadoVehiculo);
            this.mod_unidad_panel.Controls.Add(this.label4);
            this.mod_unidad_panel.Controls.Add(this.label3);
            this.mod_unidad_panel.Controls.Add(this.txtColor);
            this.mod_unidad_panel.Controls.Add(this.label2);
            this.mod_unidad_panel.Controls.Add(this.dtpEmision);
            this.mod_unidad_panel.Controls.Add(this.btnModificar);
            this.mod_unidad_panel.Controls.Add(this.txtPlaca);
            this.mod_unidad_panel.Controls.Add(this.label1);
            this.mod_unidad_panel.Location = new System.Drawing.Point(0, 0);
            this.mod_unidad_panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mod_unidad_panel.Name = "mod_unidad_panel";
            this.mod_unidad_panel.Size = new System.Drawing.Size(1108, 650);
            this.mod_unidad_panel.TabIndex = 0;
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVehiculos.Location = new System.Drawing.Point(107, 107);
            this.dgvVehiculos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(901, 178);
            this.dgvVehiculos.TabIndex = 13;
            this.dgvVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVehiculos_CellClick_1);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "yyyy - mm - dd ";
            this.dtpVencimiento.Enabled = false;
            this.dtpVencimiento.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(632, 458);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(197, 38);
            this.dtpVencimiento.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(176, 412);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "Emisión del Permiso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(627, 412);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vencimiento del Permiso";
            // 
            // cmbEstadoVehiculo
            // 
            this.cmbEstadoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoVehiculo.Enabled = false;
            this.cmbEstadoVehiculo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.cmbEstadoVehiculo.FormattingEnabled = true;
            this.cmbEstadoVehiculo.Location = new System.Drawing.Point(179, 567);
            this.cmbEstadoVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstadoVehiculo.Name = "cmbEstadoVehiculo";
            this.cmbEstadoVehiculo.Size = new System.Drawing.Size(267, 39);
            this.cmbEstadoVehiculo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(176, 519);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado del Vehículo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(627, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color del Vehículo";
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtColor.Location = new System.Drawing.Point(632, 359);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtColor.MaxLength = 100;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(267, 38);
            this.txtColor.TabIndex = 6;
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(176, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Placa del Vehículo";
            // 
            // dtpEmision
            // 
            this.dtpEmision.CustomFormat = "yyyy - mm - dd ";
            this.dtpEmision.Enabled = false;
            this.dtpEmision.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(182, 458);
            this.dtpEmision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(197, 38);
            this.dtpEmision.TabIndex = 4;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(633, 536);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(171, 70);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txtPlaca.Location = new System.Drawing.Point(182, 359);
            this.txtPlaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(267, 38);
            this.txtPlaca.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(100, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la Unidad a Modificar";
            // 
            // Modificar_UnidadFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.mod_unidad_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Modificar_UnidadFrm";
            this.Text = "Modificar_UnidadFrm";
            this.Load += new System.EventHandler(this.Modificar_UnidadFrm_Load);
            this.mod_unidad_panel.ResumeLayout(false);
            this.mod_unidad_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mod_unidad_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstadoVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DataGridView dgvVehiculos;
    }
}