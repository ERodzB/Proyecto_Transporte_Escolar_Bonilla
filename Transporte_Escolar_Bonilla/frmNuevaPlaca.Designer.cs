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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lab1.Location = new System.Drawing.Point(439, 213);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(35, 22);
            this.lab1.TabIndex = 189;
            this.lab1.Text = "Fin";
            this.lab1.Visible = false;
            // 
            // combveh
            // 
            this.combveh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combveh.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.combveh.FormattingEnabled = true;
            this.combveh.Location = new System.Drawing.Point(460, 163);
            this.combveh.Name = "combveh";
            this.combveh.Size = new System.Drawing.Size(183, 31);
            this.combveh.TabIndex = 187;
            this.combveh.SelectedIndexChanged += new System.EventHandler(this.Combveh_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(68, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(345, 27);
            this.label13.TabIndex = 188;
            this.label13.Text = "Vehículo a Cambiar la Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(81, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 27);
            this.label1.TabIndex = 190;
            this.label1.Text = "Nueva Placa del Vehículo";
            // 
            // txtNuevaMatricula
            // 
            this.txtNuevaMatricula.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaMatricula.Location = new System.Drawing.Point(460, 300);
            this.txtNuevaMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNuevaMatricula.MaxLength = 7;
            this.txtNuevaMatricula.Name = "txtNuevaMatricula";
            this.txtNuevaMatricula.Size = new System.Drawing.Size(183, 37);
            this.txtNuevaMatricula.TabIndex = 191;
            this.txtNuevaMatricula.TextChanged += new System.EventHandler(this.TxtNuevaMatricula_TextChanged);
            // 
            // botasignar
            // 
            this.botasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.botasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botasignar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botasignar.ForeColor = System.Drawing.Color.Transparent;
            this.botasignar.Location = new System.Drawing.Point(472, 396);
            this.botasignar.Name = "botasignar";
            this.botasignar.Size = new System.Drawing.Size(163, 57);
            this.botasignar.TabIndex = 193;
            this.botasignar.Text = "Cambiar";
            this.botasignar.UseVisualStyleBackColor = false;
            this.botasignar.Click += new System.EventHandler(this.Botasignar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(263, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 37);
            this.label2.TabIndex = 267;
            this.label2.Text = "Cambio de Placa";
            // 
            // frmNuevaPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botasignar);
            this.Controls.Add(this.txtNuevaMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.combveh);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
    }
}