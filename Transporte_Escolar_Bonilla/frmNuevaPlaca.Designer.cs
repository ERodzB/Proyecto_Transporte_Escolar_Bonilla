namespace Transporte_Escolar_Bonilla
{
    partial class frmNuevaPlaca
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
            this.lab1 = new System.Windows.Forms.Label();
            this.combveh = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNuevaMatricula = new System.Windows.Forms.TextBox();
            this.botasignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lab1.Location = new System.Drawing.Point(575, 200);
            this.lab1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(46, 28);
            this.lab1.TabIndex = 189;
            this.lab1.Text = "Fin";
            this.lab1.Visible = false;
            // 
            // combveh
            // 
            this.combveh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combveh.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.combveh.FormattingEnabled = true;
            this.combveh.Location = new System.Drawing.Point(604, 139);
            this.combveh.Margin = new System.Windows.Forms.Padding(4);
            this.combveh.Name = "combveh";
            this.combveh.Size = new System.Drawing.Size(243, 39);
            this.combveh.TabIndex = 187;
            this.combveh.SelectedIndexChanged += new System.EventHandler(this.Combveh_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(80, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(486, 36);
            this.label13.TabIndex = 188;
            this.label13.Text = "Vehiculo a Cambiar la Matricula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(98, 307);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 36);
            this.label1.TabIndex = 190;
            this.label1.Text = "Nueva Matricula del Vehiculo";
            // 
            // txtNuevaMatricula
            // 
            this.txtNuevaMatricula.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaMatricula.Location = new System.Drawing.Point(604, 307);
            this.txtNuevaMatricula.Name = "txtNuevaMatricula";
            this.txtNuevaMatricula.Size = new System.Drawing.Size(243, 44);
            this.txtNuevaMatricula.TabIndex = 191;
            // 
            // botasignar
            // 
            this.botasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.botasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botasignar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botasignar.ForeColor = System.Drawing.Color.Transparent;
            this.botasignar.Location = new System.Drawing.Point(630, 426);
            this.botasignar.Margin = new System.Windows.Forms.Padding(4);
            this.botasignar.Name = "botasignar";
            this.botasignar.Size = new System.Drawing.Size(217, 70);
            this.botasignar.TabIndex = 193;
            this.botasignar.Text = "Cambiar";
            this.botasignar.UseVisualStyleBackColor = false;
            this.botasignar.Click += new System.EventHandler(this.Botasignar_Click);
            // 
            // frmNuevaPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1090, 603);
            this.Controls.Add(this.botasignar);
            this.Controls.Add(this.txtNuevaMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.combveh);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaPlaca";
            this.Text = "frmNuevaPlaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.ComboBox combveh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevaMatricula;
        private System.Windows.Forms.Button botasignar;
    }
}