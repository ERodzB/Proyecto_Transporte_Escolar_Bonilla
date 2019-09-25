namespace Transporte_Escolar_Bonilla
{
    partial class Generar_Contrato
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
            this.generar_panel = new System.Windows.Forms.Panel();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvGenerarContrato = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.generar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerarContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // generar_panel
            // 
            this.generar_panel.Controls.Add(this.btnGenerar);
            this.generar_panel.Controls.Add(this.dgvGenerarContrato);
            this.generar_panel.Controls.Add(this.label1);
            this.generar_panel.Location = new System.Drawing.Point(0, -1);
            this.generar_panel.Margin = new System.Windows.Forms.Padding(4);
            this.generar_panel.Name = "generar_panel";
            this.generar_panel.Size = new System.Drawing.Size(1108, 650);
            this.generar_panel.TabIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.btnGenerar.Enabled = false;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(853, 556);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(173, 69);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // dgvGenerarContrato
            // 
            this.dgvGenerarContrato.AllowUserToAddRows = false;
            this.dgvGenerarContrato.AllowUserToDeleteRows = false;
            this.dgvGenerarContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenerarContrato.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGenerarContrato.Location = new System.Drawing.Point(63, 166);
            this.dgvGenerarContrato.Margin = new System.Windows.Forms.Padding(4);
            this.dgvGenerarContrato.Name = "dgvGenerarContrato";
            this.dgvGenerarContrato.ReadOnly = true;
            this.dgvGenerarContrato.RowHeadersWidth = 51;
            this.dgvGenerarContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGenerarContrato.Size = new System.Drawing.Size(963, 357);
            this.dgvGenerarContrato.TabIndex = 1;
            this.dgvGenerarContrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGenerarContrato_CellClick);
            this.dgvGenerarContrato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatosContrato_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(230, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Contrato A Generar";
            // 
            // Generar_Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.generar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Generar_Contrato";
            this.Text = "Generar_Contrato";
            this.Load += new System.EventHandler(this.Generar_Contrato_Load);
            this.generar_panel.ResumeLayout(false);
            this.generar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenerarContrato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel generar_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvGenerarContrato;
    }
}