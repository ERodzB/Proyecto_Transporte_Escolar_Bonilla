namespace Transporte_Escolar_Bonilla
{
    partial class crearPerfil_frm
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
            this.nombrePerfil_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nivelAcceso_cmb = new System.Windows.Forms.ComboBox();
            this.Crear_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desPerfil_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombrePerfil_tb
            // 
            this.nombrePerfil_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePerfil_tb.Location = new System.Drawing.Point(533, 228);
            this.nombrePerfil_tb.Name = "nombrePerfil_tb";
            this.nombrePerfil_tb.Size = new System.Drawing.Size(451, 41);
            this.nombrePerfil_tb.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 40);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nivel de Acceso";
            // 
            // nivelAcceso_cmb
            // 
            this.nivelAcceso_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nivelAcceso_cmb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivelAcceso_cmb.FormattingEnabled = true;
            this.nivelAcceso_cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.nivelAcceso_cmb.Location = new System.Drawing.Point(612, 134);
            this.nivelAcceso_cmb.Name = "nivelAcceso_cmb";
            this.nivelAcceso_cmb.Size = new System.Drawing.Size(372, 45);
            this.nivelAcceso_cmb.TabIndex = 24;
            // 
            // Crear_btn
            // 
            this.Crear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.Crear_btn.FlatAppearance.BorderSize = 0;
            this.Crear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crear_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crear_btn.ForeColor = System.Drawing.Color.White;
            this.Crear_btn.Location = new System.Drawing.Point(835, 393);
            this.Crear_btn.Name = "Crear_btn";
            this.Crear_btn.Size = new System.Drawing.Size(149, 63);
            this.Crear_btn.TabIndex = 23;
            this.Crear_btn.Text = "Crear";
            this.Crear_btn.UseVisualStyleBackColor = false;
            this.Crear_btn.Click += new System.EventHandler(this.Crear_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 40);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre de Perfil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(113, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 40);
            this.label3.TabIndex = 29;
            this.label3.Text = "Descripcion de Perfil";
            // 
            // desPerfil_tb
            // 
            this.desPerfil_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desPerfil_tb.Location = new System.Drawing.Point(533, 307);
            this.desPerfil_tb.Name = "desPerfil_tb";
            this.desPerfil_tb.Size = new System.Drawing.Size(451, 41);
            this.desPerfil_tb.TabIndex = 28;
            // 
            // crearPerfil_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1106, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desPerfil_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrePerfil_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nivelAcceso_cmb);
            this.Controls.Add(this.Crear_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "crearPerfil_frm";
            this.Text = "crearPerfil_frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombrePerfil_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nivelAcceso_cmb;
        private System.Windows.Forms.Button Crear_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desPerfil_tb;
    }
}