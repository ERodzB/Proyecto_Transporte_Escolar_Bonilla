﻿namespace Transporte_Escolar_Bonilla
{
    partial class form_nueva_ruta
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
            this.dtphorae1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botcrear = new System.Windows.Forms.Button();
            this.dtphoras1 = new System.Windows.Forms.DateTimePicker();
            this.txtinicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.combveh1 = new System.Windows.Forms.ComboBox();
            this.labv1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtphorae1
            // 
            this.dtphorae1.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.dtphorae1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphorae1.Location = new System.Drawing.Point(551, 396);
            this.dtphorae1.Margin = new System.Windows.Forms.Padding(4);
            this.dtphorae1.Name = "dtphorae1";
            this.dtphorae1.Size = new System.Drawing.Size(243, 41);
            this.dtphorae1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(272, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 36);
            this.label7.TabIndex = 33;
            this.label7.Text = "Hora de Llegada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(303, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 36);
            this.label6.TabIndex = 32;
            this.label6.Text = "Hora de Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(405, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "Horario de la Ruta";
            // 
            // txtfin
            // 
            this.txtfin.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtfin.Location = new System.Drawing.Point(516, 217);
            this.txtfin.Margin = new System.Windows.Forms.Padding(4);
            this.txtfin.MaxLength = 50;
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(336, 34);
            this.txtfin.TabIndex = 2;
            this.txtfin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtfin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(208, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 36);
            this.label2.TabIndex = 29;
            this.label2.Text = "Destino de la Ruta:";
            // 
            // botcrear
            // 
            this.botcrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.botcrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botcrear.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.botcrear.ForeColor = System.Drawing.Color.Transparent;
            this.botcrear.Location = new System.Drawing.Point(837, 543);
            this.botcrear.Margin = new System.Windows.Forms.Padding(4);
            this.botcrear.Name = "botcrear";
            this.botcrear.Size = new System.Drawing.Size(203, 76);
            this.botcrear.TabIndex = 13;
            this.botcrear.Text = "Crear Ruta";
            this.botcrear.UseVisualStyleBackColor = false;
            this.botcrear.Click += new System.EventHandler(this.Botcrear_Click);
            // 
            // dtphoras1
            // 
            this.dtphoras1.CalendarFont = new System.Drawing.Font("Century Gothic", 13F);
            this.dtphoras1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtphoras1.Location = new System.Drawing.Point(551, 337);
            this.dtphoras1.Margin = new System.Windows.Forms.Padding(4);
            this.dtphoras1.Name = "dtphoras1";
            this.dtphoras1.Size = new System.Drawing.Size(243, 41);
            this.dtphoras1.TabIndex = 4;
            // 
            // txtinicio
            // 
            this.txtinicio.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtinicio.Location = new System.Drawing.Point(516, 164);
            this.txtinicio.Margin = new System.Windows.Forms.Padding(4);
            this.txtinicio.MaxLength = 50;
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(336, 34);
            this.txtinicio.TabIndex = 1;
            this.txtinicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtinicio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(208, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "Origen de la Ruta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(169, 460);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(362, 33);
            this.label13.TabIndex = 47;
            this.label13.Text = "Vehículo a Realizar la Ruta";
            // 
            // combveh1
            // 
            this.combveh1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combveh1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.combveh1.FormattingEnabled = true;
            this.combveh1.Location = new System.Drawing.Point(551, 459);
            this.combveh1.Margin = new System.Windows.Forms.Padding(4);
            this.combveh1.Name = "combveh1";
            this.combveh1.Size = new System.Drawing.Size(243, 39);
            this.combveh1.TabIndex = 6;
            this.combveh1.SelectedIndexChanged += new System.EventHandler(this.Combveh1_SelectedIndexChanged);
            // 
            // labv1
            // 
            this.labv1.AutoSize = true;
            this.labv1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labv1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.labv1.Location = new System.Drawing.Point(547, 519);
            this.labv1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labv1.Name = "labv1";
            this.labv1.Size = new System.Drawing.Size(36, 23);
            this.labv1.TabIndex = 183;
            this.labv1.Text = "Fin";
            this.labv1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(405, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 36);
            this.label4.TabIndex = 184;
            this.label4.Text = "Trayecto a Recorrer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(329, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(472, 44);
            this.label5.TabIndex = 185;
            this.label5.Text = "Creación de Nueva Ruta";
            // 
            // form_nueva_ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labv1);
            this.Controls.Add(this.combveh1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtphorae1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botcrear);
            this.Controls.Add(this.dtphoras1);
            this.Controls.Add(this.txtinicio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_nueva_ruta";
            this.Text = "form_nueva_ruta";
            this.Load += new System.EventHandler(this.Form_nueva_ruta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtphorae1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botcrear;
        private System.Windows.Forms.DateTimePicker dtphoras1;
        private System.Windows.Forms.TextBox txtinicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combveh1;
        private System.Windows.Forms.Label labv1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}