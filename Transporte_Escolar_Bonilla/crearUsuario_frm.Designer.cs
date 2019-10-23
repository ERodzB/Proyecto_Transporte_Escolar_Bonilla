namespace Transporte_Escolar_Bonilla
{
    partial class crearUsuario_frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.identidad_tb = new System.Windows.Forms.TextBox();
            this.contra_tb = new System.Windows.Forms.TextBox();
            this.ingresar_btn = new System.Windows.Forms.Button();
            this.nombre_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Perfil_cmb = new System.Windows.Forms.ComboBox();
            this.confirm_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OJO1 = new System.Windows.Forms.Button();
            this.OJO2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(215, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de  Identidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Perfil";
            // 
            // identidad_tb
            // 
            this.identidad_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identidad_tb.Location = new System.Drawing.Point(467, 121);
            this.identidad_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.identidad_tb.MaxLength = 14;
            this.identidad_tb.Name = "identidad_tb";
            this.identidad_tb.Size = new System.Drawing.Size(451, 41);
            this.identidad_tb.TabIndex = 5;
            this.identidad_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Identidad_tb_KeyPress);
            // 
            // contra_tb
            // 
            this.contra_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra_tb.Location = new System.Drawing.Point(467, 249);
            this.contra_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contra_tb.MaxLength = 20;
            this.contra_tb.Name = "contra_tb";
            this.contra_tb.PasswordChar = '*';
            this.contra_tb.Size = new System.Drawing.Size(451, 41);
            this.contra_tb.TabIndex = 7;
            this.contra_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contra_tb_KeyPress);
            // 
            // ingresar_btn
            // 
            this.ingresar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.ingresar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresar_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresar_btn.ForeColor = System.Drawing.Color.White;
            this.ingresar_btn.Location = new System.Drawing.Point(768, 490);
            this.ingresar_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingresar_btn.Name = "ingresar_btn";
            this.ingresar_btn.Size = new System.Drawing.Size(149, 70);
            this.ingresar_btn.TabIndex = 10;
            this.ingresar_btn.Text = "Ingresar";
            this.ingresar_btn.UseVisualStyleBackColor = false;
            this.ingresar_btn.Click += new System.EventHandler(this.Ingresar_btn_Click);
            // 
            // nombre_tb
            // 
            this.nombre_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_tb.Location = new System.Drawing.Point(467, 185);
            this.nombre_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre_tb.MaxLength = 16;
            this.nombre_tb.Name = "nombre_tb";
            this.nombre_tb.Size = new System.Drawing.Size(451, 41);
            this.nombre_tb.TabIndex = 6;
            this.nombre_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(99, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre de Usuario";
            // 
            // Perfil_cmb
            // 
            this.Perfil_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Perfil_cmb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfil_cmb.FormattingEnabled = true;
            this.Perfil_cmb.Location = new System.Drawing.Point(545, 379);
            this.Perfil_cmb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Perfil_cmb.Name = "Perfil_cmb";
            this.Perfil_cmb.Size = new System.Drawing.Size(372, 45);
            this.Perfil_cmb.TabIndex = 9;
            this.Perfil_cmb.SelectedIndexChanged += new System.EventHandler(this.Perfil_cmb_SelectedIndexChanged);
            // 
            // confirm_tb
            // 
            this.confirm_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_tb.Location = new System.Drawing.Point(467, 313);
            this.confirm_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm_tb.MaxLength = 20;
            this.confirm_tb.Name = "confirm_tb";
            this.confirm_tb.PasswordChar = '*';
            this.confirm_tb.Size = new System.Drawing.Size(451, 41);
            this.confirm_tb.TabIndex = 8;
            this.confirm_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Conform_tb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirmar contraseña";
            // 
            // OJO1
            // 
            this.OJO1.BackgroundImage = global::Transporte_Escolar_Bonilla.Properties.Resources.ojo;
            this.OJO1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OJO1.FlatAppearance.BorderSize = 0;
            this.OJO1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OJO1.Location = new System.Drawing.Point(932, 249);
            this.OJO1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OJO1.Name = "OJO1";
            this.OJO1.Size = new System.Drawing.Size(52, 41);
            this.OJO1.TabIndex = 13;
            this.OJO1.TabStop = false;
            this.OJO1.UseVisualStyleBackColor = true;
            this.OJO1.Click += new System.EventHandler(this.OJO1_Click);
            // 
            // OJO2
            // 
            this.OJO2.BackgroundImage = global::Transporte_Escolar_Bonilla.Properties.Resources.ojo;
            this.OJO2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OJO2.FlatAppearance.BorderSize = 0;
            this.OJO2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OJO2.Location = new System.Drawing.Point(932, 313);
            this.OJO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OJO2.Name = "OJO2";
            this.OJO2.Size = new System.Drawing.Size(52, 41);
            this.OJO2.TabIndex = 14;
            this.OJO2.TabStop = false;
            this.OJO2.UseVisualStyleBackColor = true;
            this.OJO2.Click += new System.EventHandler(this.OJO2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(333, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 44);
            this.label5.TabIndex = 95;
            this.label5.Text = "Creación de Usuario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crearUsuario_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OJO2);
            this.Controls.Add(this.OJO1);
            this.Controls.Add(this.confirm_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Perfil_cmb);
            this.Controls.Add(this.nombre_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ingresar_btn);
            this.Controls.Add(this.contra_tb);
            this.Controls.Add(this.identidad_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "crearUsuario_frm";
            this.Text = "crearUsuario_frm";
            this.Load += new System.EventHandler(this.CrearUsuario_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox identidad_tb;
        private System.Windows.Forms.TextBox contra_tb;
        private System.Windows.Forms.Button ingresar_btn;
        private System.Windows.Forms.TextBox nombre_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Perfil_cmb;
        private System.Windows.Forms.TextBox confirm_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OJO1;
        private System.Windows.Forms.Button OJO2;
        private System.Windows.Forms.Label label5;
    }
}