﻿namespace Transporte_Escolar_Bonilla
{
    partial class modificarUsuario_frm
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
            this.Perfil_cmb = new System.Windows.Forms.ComboBox();
            this.nombre_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Buscar_btn = new System.Windows.Forms.Button();
            this.contra_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.identidad_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.modificar_btn = new System.Windows.Forms.Button();
            this.nueva_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.actual_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OJO2 = new System.Windows.Forms.Button();
            this.OJO3 = new System.Windows.Forms.Button();
            this.OJO1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Perfil_cmb
            // 
            this.Perfil_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Perfil_cmb.Enabled = false;
            this.Perfil_cmb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfil_cmb.FormattingEnabled = true;
            this.Perfil_cmb.Location = new System.Drawing.Point(488, 405);
            this.Perfil_cmb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Perfil_cmb.Name = "Perfil_cmb";
            this.Perfil_cmb.Size = new System.Drawing.Size(280, 38);
            this.Perfil_cmb.TabIndex = 28;
            // 
            // nombre_tb
            // 
            this.nombre_tb.Enabled = false;
            this.nombre_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_tb.Location = new System.Drawing.Point(429, 206);
            this.nombre_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombre_tb.MaxLength = 10;
            this.nombre_tb.Name = "nombre_tb";
            this.nombre_tb.Size = new System.Drawing.Size(339, 34);
            this.nombre_tb.TabIndex = 24;
            this.nombre_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(121, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 33);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre de Usuario";
            // 
            // Buscar_btn
            // 
            this.Buscar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.Buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_btn.ForeColor = System.Drawing.Color.White;
            this.Buscar_btn.Location = new System.Drawing.Point(656, 141);
            this.Buscar_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Buscar_btn.Name = "Buscar_btn";
            this.Buscar_btn.Size = new System.Drawing.Size(112, 51);
            this.Buscar_btn.TabIndex = 23;
            this.Buscar_btn.Text = "Buscar";
            this.Buscar_btn.UseVisualStyleBackColor = false;
            this.Buscar_btn.Click += new System.EventHandler(this.Ingresar_btn_Click);
            // 
            // contra_tb
            // 
            this.contra_tb.Enabled = false;
            this.contra_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra_tb.Location = new System.Drawing.Point(429, 358);
            this.contra_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contra_tb.MaxLength = 20;
            this.contra_tb.Name = "contra_tb";
            this.contra_tb.PasswordChar = '*';
            this.contra_tb.Size = new System.Drawing.Size(339, 34);
            this.contra_tb.TabIndex = 27;
            this.contra_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contra_tb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 405);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirmar nueva contraseña";
            // 
            // identidad_tb
            // 
            this.identidad_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identidad_tb.Location = new System.Drawing.Point(429, 89);
            this.identidad_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.identidad_tb.MaxLength = 13;
            this.identidad_tb.Name = "identidad_tb";
            this.identidad_tb.Size = new System.Drawing.Size(339, 34);
            this.identidad_tb.TabIndex = 22;
            this.identidad_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Identidad_tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(85, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 33);
            this.label2.TabIndex = 21;
            this.label2.Text = "Número de  Identidad";
            // 
            // modificar_btn
            // 
            this.modificar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.modificar_btn.Enabled = false;
            this.modificar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_btn.ForeColor = System.Drawing.Color.White;
            this.modificar_btn.Location = new System.Drawing.Point(621, 467);
            this.modificar_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(146, 51);
            this.modificar_btn.TabIndex = 29;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = false;
            this.modificar_btn.Click += new System.EventHandler(this.Modificar_btn_Click);
            // 
            // nueva_tb
            // 
            this.nueva_tb.Enabled = false;
            this.nueva_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nueva_tb.Location = new System.Drawing.Point(429, 309);
            this.nueva_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nueva_tb.MaxLength = 20;
            this.nueva_tb.Name = "nueva_tb";
            this.nueva_tb.PasswordChar = '*';
            this.nueva_tb.Size = new System.Drawing.Size(339, 34);
            this.nueva_tb.TabIndex = 26;
            this.nueva_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nueva_tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(128, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nueva contraseña";
            // 
            // actual_tb
            // 
            this.actual_tb.Enabled = false;
            this.actual_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actual_tb.Location = new System.Drawing.Point(429, 258);
            this.actual_tb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.actual_tb.MaxLength = 20;
            this.actual_tb.Name = "actual_tb";
            this.actual_tb.PasswordChar = '*';
            this.actual_tb.Size = new System.Drawing.Size(339, 34);
            this.actual_tb.TabIndex = 25;
            this.actual_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Actual_tb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(126, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 33);
            this.label5.TabIndex = 30;
            this.label5.Text = "Contraseña actual";
            // 
            // OJO2
            // 
            this.OJO2.BackgroundImage = global::Transporte_Escolar_Bonilla.Properties.Resources.ojo;
            this.OJO2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OJO2.FlatAppearance.BorderSize = 0;
            this.OJO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OJO2.Location = new System.Drawing.Point(782, 309);
            this.OJO2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OJO2.Name = "OJO2";
            this.OJO2.Size = new System.Drawing.Size(40, 33);
            this.OJO2.TabIndex = 32;
            this.OJO2.TabStop = false;
            this.OJO2.UseVisualStyleBackColor = true;
            this.OJO2.Click += new System.EventHandler(this.OJO2_Click);
            // 
            // OJO3
            // 
            this.OJO3.BackgroundImage = global::Transporte_Escolar_Bonilla.Properties.Resources.ojo;
            this.OJO3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OJO3.FlatAppearance.BorderSize = 0;
            this.OJO3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OJO3.Location = new System.Drawing.Point(782, 358);
            this.OJO3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OJO3.Name = "OJO3";
            this.OJO3.Size = new System.Drawing.Size(40, 33);
            this.OJO3.TabIndex = 33;
            this.OJO3.TabStop = false;
            this.OJO3.UseVisualStyleBackColor = true;
            this.OJO3.Click += new System.EventHandler(this.OJO3_Click);
            // 
            // OJO1
            // 
            this.OJO1.BackColor = System.Drawing.Color.Transparent;
            this.OJO1.BackgroundImage = global::Transporte_Escolar_Bonilla.Properties.Resources.ojo;
            this.OJO1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OJO1.FlatAppearance.BorderSize = 0;
            this.OJO1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OJO1.Location = new System.Drawing.Point(782, 258);
            this.OJO1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OJO1.Name = "OJO1";
            this.OJO1.Size = new System.Drawing.Size(40, 33);
            this.OJO1.TabIndex = 31;
            this.OJO1.TabStop = false;
            this.OJO1.UseVisualStyleBackColor = false;
            this.OJO1.Click += new System.EventHandler(this.OJO1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(291, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(281, 37);
            this.label13.TabIndex = 34;
            this.label13.Text = "Modificar Usuarios";
            // 
            // modificarUsuario_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.OJO3);
            this.Controls.Add(this.OJO2);
            this.Controls.Add(this.OJO1);
            this.Controls.Add(this.actual_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nueva_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modificar_btn);
            this.Controls.Add(this.identidad_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Perfil_cmb);
            this.Controls.Add(this.nombre_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Buscar_btn);
            this.Controls.Add(this.contra_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "modificarUsuario_frm";
            this.Text = "modificarUsuario_frm";
            this.Load += new System.EventHandler(this.ModificarUsuario_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Perfil_cmb;
        private System.Windows.Forms.TextBox nombre_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Buscar_btn;
        private System.Windows.Forms.TextBox contra_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox identidad_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modificar_btn;
        private System.Windows.Forms.TextBox nueva_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox actual_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OJO1;
        private System.Windows.Forms.Button OJO2;
        private System.Windows.Forms.Button OJO3;
        private System.Windows.Forms.Label label13;
    }
}