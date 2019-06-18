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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.olvidadoLogin_linklbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userLogin_lbl
            // 
            this.userLogin_lbl.AutoSize = true;
            this.userLogin_lbl.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.userLogin_lbl.ForeColor = System.Drawing.Color.White;
            this.userLogin_lbl.Location = new System.Drawing.Point(247, 222);
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
            this.ingresarLogin_btn.Location = new System.Drawing.Point(654, 412);
            this.ingresarLogin_btn.Name = "ingresarLogin_btn";
            this.ingresarLogin_btn.Size = new System.Drawing.Size(132, 45);
            this.ingresarLogin_btn.TabIndex = 2;
            this.ingresarLogin_btn.Text = "Ingresar";
            this.ingresarLogin_btn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.textBox1.Location = new System.Drawing.Point(476, 302);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 38);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // olvidadoLogin_linklbl
            // 
            this.olvidadoLogin_linklbl.AutoSize = true;
            this.olvidadoLogin_linklbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.olvidadoLogin_linklbl.DisabledLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.olvidadoLogin_linklbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olvidadoLogin_linklbl.ForeColor = System.Drawing.Color.White;
            this.olvidadoLogin_linklbl.LinkColor = System.Drawing.Color.White;
            this.olvidadoLogin_linklbl.Location = new System.Drawing.Point(543, 363);
            this.olvidadoLogin_linklbl.Name = "olvidadoLogin_linklbl";
            this.olvidadoLogin_linklbl.Size = new System.Drawing.Size(243, 23);
            this.olvidadoLogin_linklbl.TabIndex = 5;
            this.olvidadoLogin_linklbl.TabStop = true;
            this.olvidadoLogin_linklbl.Text = "¿Olvido su contraseña?";
            this.olvidadoLogin_linklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OlvidadoLogin_linklbl_LinkClicked);
            // 
            // login_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1088, 698);
            this.Controls.Add(this.olvidadoLogin_linklbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel olvidadoLogin_linklbl;
    }
}