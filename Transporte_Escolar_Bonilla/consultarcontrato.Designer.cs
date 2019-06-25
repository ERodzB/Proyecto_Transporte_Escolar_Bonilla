namespace Transporte_Escolar_Bonilla
{
    partial class consultarcontrato
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBFiltrox = new System.Windows.Forms.ComboBox();
            this.dgvConsultaU = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Enabled = false;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnFiltrar.Location = new System.Drawing.Point(869, 176);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(158, 45);
            this.btnFiltrar.TabIndex = 11;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(367, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contratos de la Empresa";
            // 
            // CBFiltrox
            // 
            this.CBFiltrox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFiltrox.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.CBFiltrox.FormattingEnabled = true;
            this.CBFiltrox.Items.AddRange(new object[] {
            "Clientes",
            "Estados"});
            this.CBFiltrox.Location = new System.Drawing.Point(623, 82);
            this.CBFiltrox.Name = "CBFiltrox";
            this.CBFiltrox.Size = new System.Drawing.Size(404, 40);
            this.CBFiltrox.TabIndex = 9;
            this.CBFiltrox.SelectedIndexChanged += new System.EventHandler(this.CBFiltrox_SelectedIndexChanged);
            // 
            // dgvConsultaU
            // 
            this.dgvConsultaU.AllowUserToAddRows = false;
            this.dgvConsultaU.AllowUserToDeleteRows = false;
            this.dgvConsultaU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaU.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsultaU.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvConsultaU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaU.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultaU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaU.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultaU.Location = new System.Drawing.Point(46, 227);
            this.dgvConsultaU.Name = "dgvConsultaU";
            this.dgvConsultaU.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaU.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConsultaU.RowHeadersWidth = 51;
            this.dgvConsultaU.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultaU.RowTemplate.Height = 24;
            this.dgvConsultaU.Size = new System.Drawing.Size(981, 338);
            this.dgvConsultaU.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtrar Contratos por: ";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Seleccione el Dato Filtro:";
            // 
            // CMBFiltro
            // 
            this.CMBFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBFiltro.Enabled = false;
            this.CMBFiltro.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.CMBFiltro.FormattingEnabled = true;
            this.CMBFiltro.Items.AddRange(new object[] {
            "Clientes",
            "Contratos por Cliente"});
            this.CMBFiltro.Location = new System.Drawing.Point(623, 130);
            this.CMBFiltro.Name = "CMBFiltro";
            this.CMBFiltro.Size = new System.Drawing.Size(404, 40);
            this.CMBFiltro.TabIndex = 14;
            this.CMBFiltro.SelectedIndexChanged += new System.EventHandler(this.CMBFiltro_SelectedIndexChanged);
            // 
            // consultarcontrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1090, 603);
            this.Controls.Add(this.CMBFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBFiltrox);
            this.Controls.Add(this.dgvConsultaU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultarcontrato";
            this.Text = "consultarcontrato";
            this.Load += new System.EventHandler(this.Consultarcontrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBFiltrox;
        private System.Windows.Forms.DataGridView dgvConsultaU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMBFiltro;
    }
}