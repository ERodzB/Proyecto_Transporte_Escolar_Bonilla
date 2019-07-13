namespace Transporte_Escolar_Bonilla
{
    partial class asignacionunidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConsultaU = new System.Windows.Forms.DataGridView();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.plinea = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblasignado = new System.Windows.Forms.Label();
            this.cmbempleado = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaU)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaU.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultaU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultaU.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultaU.Location = new System.Drawing.Point(12, 11);
            this.dgvConsultaU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsultaU.Name = "dgvConsultaU";
            this.dgvConsultaU.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaU.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultaU.RowHeadersWidth = 51;
            this.dgvConsultaU.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultaU.RowTemplate.Height = 24;
            this.dgvConsultaU.Size = new System.Drawing.Size(1084, 218);
            this.dgvConsultaU.TabIndex = 6;
            this.dgvConsultaU.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultaU_CellClick);
            this.dgvConsultaU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvConsultaU_CellContentClick);
            // 
            // btnDevolver
            // 
            this.btnDevolver.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnDevolver.Location = new System.Drawing.Point(911, 532);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(185, 89);
            this.btnDevolver.TabIndex = 12;
            this.btnDevolver.Text = "Entregar";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Visible = false;
            this.btnDevolver.Click += new System.EventHandler(this.BtnDevolver_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnAsignar.Location = new System.Drawing.Point(911, 532);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(185, 89);
            this.btnAsignar.TabIndex = 13;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Visible = false;
            this.btnAsignar.Click += new System.EventHandler(this.BtnAsignar_Click);
            // 
            // plinea
            // 
            this.plinea.AutoSize = true;
            this.plinea.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.plinea.ForeColor = System.Drawing.Color.White;
            this.plinea.Location = new System.Drawing.Point(63, 244);
            this.plinea.Name = "plinea";
            this.plinea.Size = new System.Drawing.Size(163, 33);
            this.plinea.TabIndex = 14;
            this.plinea.Text = "El vehiculo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Con Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtDescripcion.Location = new System.Drawing.Point(69, 362);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(585, 77);
            this.txtDescripcion.TabIndex = 16;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtPlaca.Location = new System.Drawing.Point(69, 281);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(585, 40);
            this.txtPlaca.TabIndex = 17;
            // 
            // lblasignado
            // 
            this.lblasignado.AutoSize = true;
            this.lblasignado.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lblasignado.ForeColor = System.Drawing.Color.White;
            this.lblasignado.Location = new System.Drawing.Point(63, 535);
            this.lblasignado.Name = "lblasignado";
            this.lblasignado.Size = new System.Drawing.Size(234, 33);
            this.lblasignado.TabIndex = 18;
            this.lblasignado.Text = "Sera asignado a:";
            // 
            // cmbempleado
            // 
            this.cmbempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbempleado.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cmbempleado.FormattingEnabled = true;
            this.cmbempleado.Location = new System.Drawing.Point(69, 581);
            this.cmbempleado.Name = "cmbempleado";
            this.cmbempleado.Size = new System.Drawing.Size(585, 40);
            this.cmbempleado.TabIndex = 19;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txtEstado.Location = new System.Drawing.Point(69, 483);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(585, 40);
            this.txtEstado.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Estado del Vehiculo:";
            // 
            // asignacionunidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbempleado);
            this.Controls.Add(this.lblasignado);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plinea);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvConsultaU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 1);
            this.Name = "asignacionunidades";
            this.Text = "asignacionunidades";
            this.Load += new System.EventHandler(this.Asignacionunidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConsultaU;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Label plinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblasignado;
        private System.Windows.Forms.ComboBox cmbempleado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label3;
    }
}