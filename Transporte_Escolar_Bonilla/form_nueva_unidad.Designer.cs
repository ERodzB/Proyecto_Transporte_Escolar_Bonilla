namespace Transporte_Escolar_Bonilla
{
    partial class form_nueva_unidad
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
            this.txtmat = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combtipoveh = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpanioveh = new System.Windows.Forms.DateTimePicker();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combtipocom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.combtipotra = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpanioad = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.botcrear = new System.Windows.Forms.Button();
            this.combestado = new System.Windows.Forms.ComboBox();
            this.dtpemision = new System.Windows.Forms.DateTimePicker();
            this.dtpvenc = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmat
            // 
            this.txtmat.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmat.Location = new System.Drawing.Point(65, 144);
            this.txtmat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmat.MaxLength = 7;
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(276, 26);
            this.txtmat.TabIndex = 1;
            this.txtmat.TextChanged += new System.EventHandler(this.Txtmat_TextChanged);
            this.txtmat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtmat_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(60, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 33);
            this.label12.TabIndex = 204;
            this.label12.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(399, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 33);
            this.label2.TabIndex = 206;
            this.label2.Text = "Tipo de Vehículo";
            // 
            // combtipoveh
            // 
            this.combtipoveh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combtipoveh.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combtipoveh.FormattingEnabled = true;
            this.combtipoveh.Items.AddRange(new object[] {
            "Bus Completo",
            "Medio Bus"});
            this.combtipoveh.Location = new System.Drawing.Point(404, 144);
            this.combtipoveh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combtipoveh.Name = "combtipoveh";
            this.combtipoveh.Size = new System.Drawing.Size(276, 28);
            this.combtipoveh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(737, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 33);
            this.label3.TabIndex = 208;
            this.label3.Text = "Año del Vehículo";
            // 
            // dtpanioveh
            // 
            this.dtpanioveh.Location = new System.Drawing.Point(743, 144);
            this.dtpanioveh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpanioveh.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dtpanioveh.Name = "dtpanioveh";
            this.dtpanioveh.Size = new System.Drawing.Size(276, 22);
            this.dtpanioveh.TabIndex = 3;
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(65, 245);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmarca.MaxLength = 100;
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(276, 26);
            this.txtmarca.TabIndex = 4;
            this.txtmarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtmarca_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(60, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 33);
            this.label4.TabIndex = 210;
            this.label4.Text = "Marca";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmodelo.Location = new System.Drawing.Point(404, 245);
            this.txtmodelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmodelo.MaxLength = 100;
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(276, 26);
            this.txtmodelo.TabIndex = 5;
            this.txtmodelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtmodelo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(399, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 33);
            this.label5.TabIndex = 212;
            this.label5.Text = "Modelo";
            // 
            // txtcap
            // 
            this.txtcap.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcap.Location = new System.Drawing.Point(65, 346);
            this.txtcap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcap.MaxLength = 3;
            this.txtcap.Name = "txtcap";
            this.txtcap.Size = new System.Drawing.Size(276, 26);
            this.txtcap.TabIndex = 7;
            this.txtcap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcap_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(60, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 33);
            this.label6.TabIndex = 214;
            this.label6.Text = "Capacidad";
            // 
            // combtipocom
            // 
            this.combtipocom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combtipocom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combtipocom.FormattingEnabled = true;
            this.combtipocom.Items.AddRange(new object[] {
            "Bus Completo",
            "Medio Bus"});
            this.combtipocom.Location = new System.Drawing.Point(743, 346);
            this.combtipocom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combtipocom.Name = "combtipocom";
            this.combtipocom.Size = new System.Drawing.Size(276, 28);
            this.combtipocom.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(737, 313);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(287, 33);
            this.label7.TabIndex = 216;
            this.label7.Text = "Tipo de Combustible";
            // 
            // combtipotra
            // 
            this.combtipotra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combtipotra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combtipotra.FormattingEnabled = true;
            this.combtipotra.Items.AddRange(new object[] {
            "Bus Completo",
            "Medio Bus"});
            this.combtipotra.Location = new System.Drawing.Point(404, 346);
            this.combtipotra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combtipotra.Name = "combtipotra";
            this.combtipotra.Size = new System.Drawing.Size(276, 28);
            this.combtipotra.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(399, 313);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 33);
            this.label8.TabIndex = 218;
            this.label8.Text = "Tipo de Transmisión";
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.Location = new System.Drawing.Point(743, 245);
            this.txtcolor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcolor.MaxLength = 100;
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(276, 26);
            this.txtcolor.TabIndex = 6;
            this.txtcolor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcolor_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(737, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 33);
            this.label9.TabIndex = 220;
            this.label9.Text = "Color";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(232, 539);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 33);
            this.label10.TabIndex = 222;
            this.label10.Text = "Estado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(60, 416);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(270, 33);
            this.label11.TabIndex = 224;
            this.label11.Text = "Año de Adquisición";
            // 
            // dtpanioad
            // 
            this.dtpanioad.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpanioad.Location = new System.Drawing.Point(66, 453);
            this.dtpanioad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpanioad.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dtpanioad.Name = "dtpanioad";
            this.dtpanioad.Size = new System.Drawing.Size(276, 41);
            this.dtpanioad.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(399, 416);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(270, 33);
            this.label13.TabIndex = 226;
            this.label13.Text = "Emisión del Permiso";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(736, 416);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(344, 33);
            this.label14.TabIndex = 228;
            this.label14.Text = "Vencimiento del Permiso";
            // 
            // botcrear
            // 
            this.botcrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.botcrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botcrear.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botcrear.ForeColor = System.Drawing.Color.Transparent;
            this.botcrear.Location = new System.Drawing.Point(807, 542);
            this.botcrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botcrear.Name = "botcrear";
            this.botcrear.Size = new System.Drawing.Size(145, 52);
            this.botcrear.TabIndex = 14;
            this.botcrear.Text = "Crear";
            this.botcrear.UseVisualStyleBackColor = false;
            this.botcrear.Click += new System.EventHandler(this.Botcrear_Click);
            // 
            // combestado
            // 
            this.combestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combestado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combestado.FormattingEnabled = true;
            this.combestado.Items.AddRange(new object[] {
            "Bus Completo",
            "Medio Bus"});
            this.combestado.Location = new System.Drawing.Point(344, 542);
            this.combestado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combestado.Name = "combestado";
            this.combestado.Size = new System.Drawing.Size(276, 28);
            this.combestado.TabIndex = 229;
            // 
            // dtpemision
            // 
            this.dtpemision.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpemision.Location = new System.Drawing.Point(404, 452);
            this.dtpemision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpemision.Name = "dtpemision";
            this.dtpemision.Size = new System.Drawing.Size(276, 41);
            this.dtpemision.TabIndex = 230;
            // 
            // dtpvenc
            // 
            this.dtpvenc.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpvenc.Location = new System.Drawing.Point(741, 452);
            this.dtpvenc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpvenc.Name = "dtpvenc";
            this.dtpvenc.Size = new System.Drawing.Size(276, 41);
            this.dtpvenc.TabIndex = 231;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(143, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(747, 44);
            this.label15.TabIndex = 232;
            this.label15.Text = "Ingreso de Nueva Unidad de Transporte";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_nueva_unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpvenc);
            this.Controls.Add(this.dtpemision);
            this.Controls.Add(this.combestado);
            this.Controls.Add(this.botcrear);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpanioad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combtipotra);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combtipocom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpanioveh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combtipoveh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmat);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_nueva_unidad";
            this.Text = "form_nueva_unidad";
            this.Load += new System.EventHandler(this.Form_nueva_unidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combtipoveh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpanioveh;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combtipocom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combtipotra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpanioad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button botcrear;
        private System.Windows.Forms.ComboBox combestado;
        private System.Windows.Forms.DateTimePicker dtpemision;
        private System.Windows.Forms.DateTimePicker dtpvenc;
        private System.Windows.Forms.Label label15;
    }
}