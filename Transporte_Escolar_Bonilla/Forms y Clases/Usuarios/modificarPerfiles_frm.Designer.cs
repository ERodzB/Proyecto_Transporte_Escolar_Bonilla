namespace Transporte_Escolar_Bonilla
{
    partial class modificarPerfiles_frm
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
            this.label3 = new System.Windows.Forms.Label();
            this.desPerfil_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombrePerfil_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nivelAcceso_cmb = new System.Windows.Forms.ComboBox();
            this.Modificar_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Perfiles_cmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 33);
            this.label3.TabIndex = 36;
            this.label3.Text = "Descripción de Perfil";
            // 
            // desPerfil_tb
            // 
            this.desPerfil_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desPerfil_tb.Location = new System.Drawing.Point(94, 360);
            this.desPerfil_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desPerfil_tb.MaxLength = 50;
            this.desPerfil_tb.Name = "desPerfil_tb";
            this.desPerfil_tb.Size = new System.Drawing.Size(649, 34);
            this.desPerfil_tb.TabIndex = 40;
            this.desPerfil_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DesPerfil_tb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre de Perfil";
            // 
            // nombrePerfil_tb
            // 
            this.nombrePerfil_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePerfil_tb.Location = new System.Drawing.Point(404, 259);
            this.nombrePerfil_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombrePerfil_tb.MaxLength = 20;
            this.nombrePerfil_tb.Name = "nombrePerfil_tb";
            this.nombrePerfil_tb.Size = new System.Drawing.Size(339, 34);
            this.nombrePerfil_tb.TabIndex = 39;
            this.nombrePerfil_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombrePerfil_tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 33);
            this.label2.TabIndex = 32;
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
            this.nivelAcceso_cmb.Location = new System.Drawing.Point(463, 201);
            this.nivelAcceso_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nivelAcceso_cmb.Name = "nivelAcceso_cmb";
            this.nivelAcceso_cmb.Size = new System.Drawing.Size(280, 38);
            this.nivelAcceso_cmb.TabIndex = 38;
            // 
            // Modificar_btn
            // 
            this.Modificar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.Modificar_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Modificar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar_btn.ForeColor = System.Drawing.Color.White;
            this.Modificar_btn.Location = new System.Drawing.Point(596, 436);
            this.Modificar_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Modificar_btn.Name = "Modificar_btn";
            this.Modificar_btn.Size = new System.Drawing.Size(146, 51);
            this.Modificar_btn.TabIndex = 41;
            this.Modificar_btn.Text = "Modificar";
            this.Modificar_btn.UseVisualStyleBackColor = false;
            this.Modificar_btn.Click += new System.EventHandler(this.Modificar_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 33);
            this.label4.TabIndex = 38;
            this.label4.Text = "Perfil";
            // 
            // Perfiles_cmb
            // 
            this.Perfiles_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Perfiles_cmb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfiles_cmb.FormattingEnabled = true;
            this.Perfiles_cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Perfiles_cmb.Location = new System.Drawing.Point(463, 136);
            this.Perfiles_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Perfiles_cmb.Name = "Perfiles_cmb";
            this.Perfiles_cmb.Size = new System.Drawing.Size(280, 38);
            this.Perfiles_cmb.TabIndex = 37;
            this.Perfiles_cmb.SelectedIndexChanged += new System.EventHandler(this.Perfiles_cmb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(232, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 36);
            this.label5.TabIndex = 42;
            this.label5.Text = "Modificación de Perfiles";
            // 
            // modificarPerfiles_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Perfiles_cmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desPerfil_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrePerfil_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nivelAcceso_cmb);
            this.Controls.Add(this.Modificar_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "modificarPerfiles_frm";
            this.Text = "modificarPerfiles_frm";
            this.Load += new System.EventHandler(this.ModificarPerfiles_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desPerfil_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombrePerfil_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox nivelAcceso_cmb;
        private System.Windows.Forms.Button Modificar_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Perfiles_cmb;
        private System.Windows.Forms.Label label5;
    }
}