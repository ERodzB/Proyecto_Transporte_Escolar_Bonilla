namespace Transporte_Escolar_Bonilla
{
    partial class contrato_panel
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
            this.contratos_panel = new System.Windows.Forms.Panel();
            this.dgvContrato = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.contratos_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // contratos_panel
            // 
            this.contratos_panel.Controls.Add(this.dgvContrato);
            this.contratos_panel.Controls.Add(this.label1);
            this.contratos_panel.Controls.Add(this.btnSeleccionar);
            this.contratos_panel.Location = new System.Drawing.Point(3, -2);
            this.contratos_panel.Margin = new System.Windows.Forms.Padding(4);
            this.contratos_panel.Name = "contratos_panel";
            this.contratos_panel.Size = new System.Drawing.Size(1106, 652);
            this.contratos_panel.TabIndex = 4;
            this.contratos_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Contratos_panel_Paint);
            // 
            // dgvContrato
            // 
            this.dgvContrato.AllowUserToAddRows = false;
            this.dgvContrato.AllowUserToDeleteRows = false;
            this.dgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContrato.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContrato.Location = new System.Drawing.Point(167, 193);
            this.dgvContrato.Margin = new System.Windows.Forms.Padding(4);
            this.dgvContrato.Name = "dgvContrato";
            this.dgvContrato.ReadOnly = true;
            this.dgvContrato.RowHeadersWidth = 51;
            this.dgvContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContrato.Size = new System.Drawing.Size(329, 348);
            this.dgvContrato.TabIndex = 4;
            this.dgvContrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContrato_CellClick_1);
            this.dgvContrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContrato_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(122, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione el Cliente al Cual se le Modificara el Contrato";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(721, 467);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(215, 74);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click_1);
            // 
            // contrato_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.contratos_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "contrato_panel";
            this.Text = "Form_Modificar_Contrato";
            this.Load += new System.EventHandler(this.Form_Modificar_Contrato_Load);
            this.contratos_panel.ResumeLayout(false);
            this.contratos_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contratos_panel;
        private System.Windows.Forms.DataGridView dgvContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}