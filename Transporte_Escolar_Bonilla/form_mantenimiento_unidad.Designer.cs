namespace Transporte_Escolar_Bonilla
{
    partial class form_mantenimiento_unidad
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
            this.combtipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.combestado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.botingresar = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lab1.Location = new System.Drawing.Point(537, 180);
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
            this.combveh.Location = new System.Drawing.Point(560, 130);
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
            this.label13.Location = new System.Drawing.Point(385, 129);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 36);
            this.label13.TabIndex = 188;
            this.label13.Text = "Vehículo:";
            // 
            // combtipo
            // 
            this.combtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combtipo.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.combtipo.FormattingEnabled = true;
            this.combtipo.Location = new System.Drawing.Point(560, 242);
            this.combtipo.Margin = new System.Windows.Forms.Padding(4);
            this.combtipo.Name = "combtipo";
            this.combtipo.Size = new System.Drawing.Size(288, 39);
            this.combtipo.TabIndex = 190;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(173, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 36);
            this.label3.TabIndex = 191;
            this.label3.Text = "Tipo de Mantenimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(141, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 36);
            this.label2.TabIndex = 192;
            this.label2.Text = "Costo del Mantenimiento:";
            // 
            // txtcosto
            // 
            this.txtcosto.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.txtcosto.Location = new System.Drawing.Point(560, 321);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcosto.MaxLength = 10;
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(288, 34);
            this.txtcosto.TabIndex = 193;
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcosto_KeyPress);
            // 
            // combestado
            // 
            this.combestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combestado.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combestado.FormattingEnabled = true;
            this.combestado.Items.AddRange(new object[] {
            "Bus Completo",
            "Medio Bus"});
            this.combestado.Location = new System.Drawing.Point(560, 468);
            this.combestado.Margin = new System.Windows.Forms.Padding(4);
            this.combestado.Name = "combestado";
            this.combestado.Size = new System.Drawing.Size(288, 39);
            this.combestado.TabIndex = 233;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(135, 398);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(395, 36);
            this.label4.TabIndex = 232;
            this.label4.Text = "Fecha del Mantenimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(124, 468);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(401, 36);
            this.label10.TabIndex = 231;
            this.label10.Text = "Estado del Mantenimiento:";
            // 
            // botingresar
            // 
            this.botingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.botingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botingresar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botingresar.ForeColor = System.Drawing.Color.Transparent;
            this.botingresar.Location = new System.Drawing.Point(839, 548);
            this.botingresar.Margin = new System.Windows.Forms.Padding(4);
            this.botingresar.Name = "botingresar";
            this.botingresar.Size = new System.Drawing.Size(161, 62);
            this.botingresar.TabIndex = 235;
            this.botingresar.Text = "Ingresar";
            this.botingresar.UseVisualStyleBackColor = false;
            this.botingresar.Click += new System.EventHandler(this.Botingresar_Click);
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(561, 400);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpfecha.MinDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(287, 30);
            this.dtpfecha.TabIndex = 290;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(185, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 44);
            this.label1.TabIndex = 291;
            this.label1.Text = "Mantenimiento de Unidades de Transporte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_mantenimiento_unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.botingresar);
            this.Controls.Add(this.combestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combtipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.combveh);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_mantenimiento_unidad";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "form_mantenimiento_unidad";
            this.Load += new System.EventHandler(this.Form_mantenimiento_unidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.ComboBox combveh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combtipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcosto;
        private System.Windows.Forms.ComboBox combestado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botingresar;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label1;
    }
}