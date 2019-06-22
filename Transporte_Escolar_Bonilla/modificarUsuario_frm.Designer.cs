namespace Transporte_Escolar_Bonilla
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
            this.SuspendLayout();
            // 
            // Perfil_cmb
            // 
            this.Perfil_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Perfil_cmb.Enabled = false;
            this.Perfil_cmb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Perfil_cmb.FormattingEnabled = true;
            this.Perfil_cmb.Location = new System.Drawing.Point(566, 372);
            this.Perfil_cmb.Name = "Perfil_cmb";
            this.Perfil_cmb.Size = new System.Drawing.Size(372, 45);
            this.Perfil_cmb.TabIndex = 26;
            // 
            // nombre_tb
            // 
            this.nombre_tb.Enabled = false;
            this.nombre_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_tb.Location = new System.Drawing.Point(487, 234);
            this.nombre_tb.MaxLength = 10;
            this.nombre_tb.Name = "nombre_tb";
            this.nombre_tb.Size = new System.Drawing.Size(451, 41);
            this.nombre_tb.TabIndex = 24;
            this.nombre_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_tb_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(119, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 40);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre de Usuario";
            // 
            // Buscar_btn
            // 
            this.Buscar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.Buscar_btn.FlatAppearance.BorderSize = 0;
            this.Buscar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscar_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_btn.ForeColor = System.Drawing.Color.White;
            this.Buscar_btn.Location = new System.Drawing.Point(789, 124);
            this.Buscar_btn.Name = "Buscar_btn";
            this.Buscar_btn.Size = new System.Drawing.Size(149, 63);
            this.Buscar_btn.TabIndex = 23;
            this.Buscar_btn.Text = "Buscar";
            this.Buscar_btn.UseVisualStyleBackColor = false;
            this.Buscar_btn.Click += new System.EventHandler(this.Ingresar_btn_Click);
            // 
            // contra_tb
            // 
            this.contra_tb.Enabled = false;
            this.contra_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contra_tb.Location = new System.Drawing.Point(487, 305);
            this.contra_tb.MaxLength = 20;
            this.contra_tb.Name = "contra_tb";
            this.contra_tb.Size = new System.Drawing.Size(451, 41);
            this.contra_tb.TabIndex = 25;
            this.contra_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contra_tb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de Perfil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(236, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Contraseña";
            // 
            // identidad_tb
            // 
            this.identidad_tb.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.identidad_tb.Location = new System.Drawing.Point(487, 61);
            this.identidad_tb.MaxLength = 13;
            this.identidad_tb.Name = "identidad_tb";
            this.identidad_tb.Size = new System.Drawing.Size(451, 41);
            this.identidad_tb.TabIndex = 22;
            this.identidad_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Identidad_tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 40);
            this.label2.TabIndex = 21;
            this.label2.Text = "Numero de  Identidad";
            // 
            // modificar_btn
            // 
            this.modificar_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.modificar_btn.Enabled = false;
            this.modificar_btn.FlatAppearance.BorderSize = 0;
            this.modificar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificar_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_btn.ForeColor = System.Drawing.Color.White;
            this.modificar_btn.Location = new System.Drawing.Point(743, 456);
            this.modificar_btn.Name = "modificar_btn";
            this.modificar_btn.Size = new System.Drawing.Size(195, 63);
            this.modificar_btn.TabIndex = 27;
            this.modificar_btn.Text = "Modificar";
            this.modificar_btn.UseVisualStyleBackColor = false;
            this.modificar_btn.Click += new System.EventHandler(this.Modificar_btn_Click);
            // 
            // modificarUsuario_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1070, 556);
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
            this.Name = "modificarUsuario_frm";
            this.Text = "modificarUsuario_frm";
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
    }
}