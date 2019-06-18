namespace Transporte_Escolar_Bonilla
{
    partial class login_frm
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
            this.userLogin_lbl = new System.Windows.Forms.Label();
            this.userLogin_tb = new System.Windows.Forms.TextBox();
            this.ingresarLogin_btn = new System.Windows.Forms.Button();
            this.contra_tb = new System.Windows.Forms.TextBox();
            this.contra_lbl = new System.Windows.Forms.Label();
            this.olvidadoLogin_linklbl = new System.Windows.Forms.LinkLabel();
            this.correo_lbl = new System.Windows.Forms.Label();
            this.Correo_tb = new System.Windows.Forms.TextBox();
            this.regresar_linklbl = new System.Windows.Forms.LinkLabel();
            this.enviar_linklbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userLogin_lbl
            // 
            this.userLogin_lbl.AutoSize = true;
            this.userLogin_lbl.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.userLogin_lbl.ForeColor = System.Drawing.Color.White;
            this.userLogin_lbl.Location = new System.Drawing.Point(276, 222);
            this.userLogin_lbl.Name = "userLogin_lbl";
            this.userLogin_lbl.Size = new System.Drawing.Size(134, 40);
            this.userLogin_lbl.TabIndex = 0;
            this.userLogin_lbl.Text = "Usuario";
            // 
            // userLogin_tb
            // 
            this.userLogin_tb.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.userLogin_tb.Location = new System.Drawing.Point(476, 222);
            this.userLogin_tb.Name = "userLogin_tb";
            this.userLogin_tb.Size = new System.Drawing.Size(310, 38);
            this.userLogin_tb.TabIndex = 1;
            // 
            // ingresarLogin_btn
            // 
            this.ingresarLogin_btn.BackColor = System.Drawing.Color.White;
            this.ingresarLogin_btn.FlatAppearance.BorderSize = 0;
            this.ingresarLogin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ingresarLogin_btn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresarLogin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ingresarLogin_btn.Location = new System.Drawing.Point(654, 500);
            this.ingresarLogin_btn.Name = "ingresarLogin_btn";
            this.ingresarLogin_btn.Size = new System.Drawing.Size(132, 45);
            this.ingresarLogin_btn.TabIndex = 2;
            this.ingresarLogin_btn.Text = "Ingresar";
            this.ingresarLogin_btn.UseVisualStyleBackColor = false;
            // 
            // contra_tb
            // 
            this.contra_tb.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.contra_tb.Location = new System.Drawing.Point(476, 294);
            this.contra_tb.Name = "contra_tb";
            this.contra_tb.Size = new System.Drawing.Size(310, 38);
            this.contra_tb.TabIndex = 4;
            // 
            // contra_lbl
            // 
            this.contra_lbl.AutoSize = true;
            this.contra_lbl.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.contra_lbl.ForeColor = System.Drawing.Color.White;
            this.contra_lbl.Location = new System.Drawing.Point(209, 294);
            this.contra_lbl.Name = "contra_lbl";
            this.contra_lbl.Size = new System.Drawing.Size(212, 40);
            this.contra_lbl.TabIndex = 3;
            this.contra_lbl.Text = "Contraseña";
            // 
            // olvidadoLogin_linklbl
            // 
            this.olvidadoLogin_linklbl.AutoSize = true;
            this.olvidadoLogin_linklbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.olvidadoLogin_linklbl.DisabledLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.olvidadoLogin_linklbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvidadoLogin_linklbl.ForeColor = System.Drawing.Color.White;
            this.olvidadoLogin_linklbl.LinkColor = System.Drawing.Color.White;
            this.olvidadoLogin_linklbl.Location = new System.Drawing.Point(543, 421);
            this.olvidadoLogin_linklbl.Name = "olvidadoLogin_linklbl";
            this.olvidadoLogin_linklbl.Size = new System.Drawing.Size(243, 23);
            this.olvidadoLogin_linklbl.TabIndex = 5;
            this.olvidadoLogin_linklbl.TabStop = true;
            this.olvidadoLogin_linklbl.Text = "¿Olvido su contraseña?";
            this.olvidadoLogin_linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OlvidadoLogin_linklbl_LinkClicked);
            // 
            // correo_lbl
            // 
            this.correo_lbl.AutoSize = true;
            this.correo_lbl.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.correo_lbl.ForeColor = System.Drawing.Color.White;
            this.correo_lbl.Location = new System.Drawing.Point(118, 361);
            this.correo_lbl.Name = "correo_lbl";
            this.correo_lbl.Size = new System.Drawing.Size(324, 40);
            this.correo_lbl.TabIndex = 6;
            this.correo_lbl.Text = "Correo Electronico";
            this.correo_lbl.Visible = false;
            // 
            // Correo_tb
            // 
            this.Correo_tb.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.Correo_tb.Location = new System.Drawing.Point(476, 363);
            this.Correo_tb.Name = "Correo_tb";
            this.Correo_tb.Size = new System.Drawing.Size(310, 38);
            this.Correo_tb.TabIndex = 7;
            this.Correo_tb.Visible = false;
            // 
            // regresar_linklbl
            // 
            this.regresar_linklbl.AutoSize = true;
            this.regresar_linklbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.regresar_linklbl.DisabledLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.regresar_linklbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar_linklbl.ForeColor = System.Drawing.Color.White;
            this.regresar_linklbl.LinkColor = System.Drawing.Color.White;
            this.regresar_linklbl.Location = new System.Drawing.Point(442, 421);
            this.regresar_linklbl.Name = "regresar_linklbl";
            this.regresar_linklbl.Size = new System.Drawing.Size(95, 23);
            this.regresar_linklbl.TabIndex = 8;
            this.regresar_linklbl.TabStop = true;
            this.regresar_linklbl.Text = "Regresar";
            this.regresar_linklbl.Visible = false;
            this.regresar_linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Regresar_linklbl_LinkClicked);
            // 
            // enviar_linklbl
            // 
            this.enviar_linklbl.AutoSize = true;
            this.enviar_linklbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.enviar_linklbl.DisabledLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.enviar_linklbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviar_linklbl.ForeColor = System.Drawing.Color.White;
            this.enviar_linklbl.LinkColor = System.Drawing.Color.White;
            this.enviar_linklbl.Location = new System.Drawing.Point(717, 457);
            this.enviar_linklbl.Name = "enviar_linklbl";
            this.enviar_linklbl.Size = new System.Drawing.Size(69, 23);
            this.enviar_linklbl.TabIndex = 9;
            this.enviar_linklbl.TabStop = true;
            this.enviar_linklbl.Text = "Enviar";
            this.enviar_linklbl.Visible = false;
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1088, 698);
            this.Controls.Add(this.enviar_linklbl);
            this.Controls.Add(this.regresar_linklbl);
            this.Controls.Add(this.Correo_tb);
            this.Controls.Add(this.correo_lbl);
            this.Controls.Add(this.olvidadoLogin_linklbl);
            this.Controls.Add(this.contra_tb);
            this.Controls.Add(this.contra_lbl);
            this.Controls.Add(this.ingresarLogin_btn);
            this.Controls.Add(this.userLogin_tb);
            this.Controls.Add(this.userLogin_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_frm";
            this.Text = "login_frm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLogin_lbl;
        private System.Windows.Forms.TextBox userLogin_tb;
        private System.Windows.Forms.Button ingresarLogin_btn;
        private System.Windows.Forms.TextBox contra_tb;
        private System.Windows.Forms.Label contra_lbl;
        private System.Windows.Forms.LinkLabel olvidadoLogin_linklbl;
        private System.Windows.Forms.Label correo_lbl;
        private System.Windows.Forms.TextBox Correo_tb;
        private System.Windows.Forms.LinkLabel regresar_linklbl;
        private System.Windows.Forms.LinkLabel enviar_linklbl;
    }
}