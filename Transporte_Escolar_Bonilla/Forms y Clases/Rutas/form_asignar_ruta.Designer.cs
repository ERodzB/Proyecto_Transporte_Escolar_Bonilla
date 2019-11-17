namespace Transporte_Escolar_Bonilla
{
    partial class form_asignar_ruta
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
            this.label2 = new System.Windows.Forms.Label();
            this.combruta = new System.Windows.Forms.ComboBox();
            this.combhorario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botasignar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lab1.Location = new System.Drawing.Point(434, 183);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(35, 22);
            this.lab1.TabIndex = 186;
            this.lab1.Text = "Fin";
            this.lab1.Visible = false;
            // 
            // combveh
            // 
            this.combveh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combveh.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.combveh.FormattingEnabled = true;
            this.combveh.Location = new System.Drawing.Point(456, 133);
            this.combveh.Name = "combveh";
            this.combveh.Size = new System.Drawing.Size(183, 31);
            this.combveh.TabIndex = 184;
            this.combveh.SelectedIndexChanged += new System.EventHandler(this.Combveh_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(124, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(324, 27);
            this.label13.TabIndex = 185;
            this.label13.Text = "Vehículo a Realizar la Ruta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(185, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 27);
            this.label2.TabIndex = 188;
            this.label2.Text = "Ruta a Realizar:";
            // 
            // combruta
            // 
            this.combruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combruta.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.combruta.FormattingEnabled = true;
            this.combruta.Location = new System.Drawing.Point(379, 244);
            this.combruta.Name = "combruta";
            this.combruta.Size = new System.Drawing.Size(260, 31);
            this.combruta.TabIndex = 189;
            this.combruta.SelectedIndexChanged += new System.EventHandler(this.Combruta_SelectedIndexChanged);
            // 
            // combhorario
            // 
            this.combhorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combhorario.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.combhorario.FormattingEnabled = true;
            this.combhorario.Location = new System.Drawing.Point(427, 309);
            this.combhorario.Name = "combhorario";
            this.combhorario.Size = new System.Drawing.Size(183, 31);
            this.combhorario.TabIndex = 191;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(185, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 27);
            this.label3.TabIndex = 190;
            this.label3.Text = "Horario de la Ruta:";
            // 
            // botasignar
            // 
            this.botasignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.botasignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botasignar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botasignar.ForeColor = System.Drawing.Color.Transparent;
            this.botasignar.Location = new System.Drawing.Point(438, 402);
            this.botasignar.Name = "botasignar";
            this.botasignar.Size = new System.Drawing.Size(163, 57);
            this.botasignar.TabIndex = 192;
            this.botasignar.Text = "Asignar";
            this.botasignar.UseVisualStyleBackColor = false;
            this.botasignar.Click += new System.EventHandler(this.Botasignar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(64, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(709, 37);
            this.label4.TabIndex = 193;
            this.label4.Text = "Asignación de Ruta a una Unidad de Transporte";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_asignar_ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(831, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botasignar);
            this.Controls.Add(this.combhorario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combruta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.combveh);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_asignar_ruta";
            this.Text = "form_asignar_ruta";
            this.Load += new System.EventHandler(this.Form_asignar_ruta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.ComboBox combveh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combruta;
        private System.Windows.Forms.ComboBox combhorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botasignar;
        private System.Windows.Forms.Label label4;
    }
}