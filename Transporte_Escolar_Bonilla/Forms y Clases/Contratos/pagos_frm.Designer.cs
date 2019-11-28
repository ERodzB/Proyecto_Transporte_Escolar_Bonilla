namespace Transporte_Escolar_Bonilla
{
    partial class pagos_frm
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
            this.cliente_dgv = new System.Windows.Forms.DataGridView();
            this.contratos_dgv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.monto_tb = new System.Windows.Forms.TextBox();
            this.lblCuota = new System.Windows.Forms.Label();
            this.Cuota_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion_tb = new System.Windows.Forms.TextBox();
            this.pagar_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratos_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cliente_dgv
            // 
            this.cliente_dgv.AllowUserToAddRows = false;
            this.cliente_dgv.AllowUserToDeleteRows = false;
            this.cliente_dgv.AllowUserToResizeColumns = false;
            this.cliente_dgv.AllowUserToResizeRows = false;
            this.cliente_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliente_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cliente_dgv.Location = new System.Drawing.Point(36, 59);
            this.cliente_dgv.Name = "cliente_dgv";
            this.cliente_dgv.ReadOnly = true;
            this.cliente_dgv.RowHeadersWidth = 51;
            this.cliente_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cliente_dgv.Size = new System.Drawing.Size(253, 150);
            this.cliente_dgv.TabIndex = 2;
            this.cliente_dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Cliente_dgv_CellMouseClick);
            // 
            // contratos_dgv
            // 
            this.contratos_dgv.AllowUserToAddRows = false;
            this.contratos_dgv.AllowUserToDeleteRows = false;
            this.contratos_dgv.AllowUserToResizeColumns = false;
            this.contratos_dgv.AllowUserToResizeRows = false;
            this.contratos_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratos_dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.contratos_dgv.Location = new System.Drawing.Point(31, 248);
            this.contratos_dgv.Name = "contratos_dgv";
            this.contratos_dgv.ReadOnly = true;
            this.contratos_dgv.RowHeadersWidth = 51;
            this.contratos_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contratos_dgv.Size = new System.Drawing.Size(725, 109);
            this.contratos_dgv.TabIndex = 3;
            this.contratos_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Contratos_dgv_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(31, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Monto a Pagar:";
            // 
            // monto_tb
            // 
            this.monto_tb.Enabled = false;
            this.monto_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto_tb.Location = new System.Drawing.Point(34, 469);
            this.monto_tb.Name = "monto_tb";
            this.monto_tb.Size = new System.Drawing.Size(140, 27);
            this.monto_tb.TabIndex = 11;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCuota.Location = new System.Drawing.Point(28, 367);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(152, 22);
            this.lblCuota.TabIndex = 31;
            this.lblCuota.Text = "Numero Cuota:";
            // 
            // Cuota_tb
            // 
            this.Cuota_tb.Enabled = false;
            this.Cuota_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuota_tb.Location = new System.Drawing.Point(31, 394);
            this.Cuota_tb.MaxLength = 2;
            this.Cuota_tb.Name = "Cuota_tb";
            this.Cuota_tb.Size = new System.Drawing.Size(107, 27);
            this.Cuota_tb.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(230, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descripcion de Pago:";
            // 
            // descripcion_tb
            // 
            this.descripcion_tb.Enabled = false;
            this.descripcion_tb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion_tb.Location = new System.Drawing.Point(233, 394);
            this.descripcion_tb.Name = "descripcion_tb";
            this.descripcion_tb.Size = new System.Drawing.Size(523, 27);
            this.descripcion_tb.TabIndex = 32;
            // 
            // pagar_btn
            // 
            this.pagar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.pagar_btn.Enabled = false;
            this.pagar_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pagar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pagar_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagar_btn.ForeColor = System.Drawing.Color.White;
            this.pagar_btn.Location = new System.Drawing.Point(634, 455);
            this.pagar_btn.Margin = new System.Windows.Forms.Padding(2);
            this.pagar_btn.Name = "pagar_btn";
            this.pagar_btn.Size = new System.Drawing.Size(122, 50);
            this.pagar_btn.TabIndex = 41;
            this.pagar_btn.Text = "Pagar";
            this.pagar_btn.UseVisualStyleBackColor = false;
            this.pagar_btn.Click += new System.EventHandler(this.Pagar_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(32, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Contratos del Cliente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(227, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(418, 37);
            this.label14.TabIndex = 268;
            this.label14.Text = "Pagos de Contrato Mensual";
            // 
            // pagos_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pagar_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcion_tb);
            this.Controls.Add(this.lblCuota);
            this.Controls.Add(this.Cuota_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monto_tb);
            this.Controls.Add(this.contratos_dgv);
            this.Controls.Add(this.cliente_dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "pagos_frm";
            this.Text = "pagos_frm";
            this.Load += new System.EventHandler(this.Pagos_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cliente_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratos_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cliente_dgv;
        private System.Windows.Forms.DataGridView contratos_dgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox monto_tb;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.TextBox Cuota_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion_tb;
        private System.Windows.Forms.Button pagar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
    }
}