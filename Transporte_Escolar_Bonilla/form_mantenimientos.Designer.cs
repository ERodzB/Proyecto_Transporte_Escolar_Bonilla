namespace Transporte_Escolar_Bonilla
{
    partial class form_mantenimientos
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
            this.opc_gp = new System.Windows.Forms.GroupBox();
            this.radagregar = new System.Windows.Forms.RadioButton();
            this.radmodi = new System.Windows.Forms.RadioButton();
            this.radno = new System.Windows.Forms.RadioButton();
            this.combmant = new System.Windows.Forms.ComboBox();
            this.labmant = new System.Windows.Forms.Label();
            this.labnom = new System.Windows.Forms.Label();
            this.labdesc = new System.Windows.Forms.Label();
            this.botingresar = new System.Windows.Forms.Button();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.opc_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(317, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mantenimientos";
            // 
            // opc_gp
            // 
            this.opc_gp.Controls.Add(this.radagregar);
            this.opc_gp.Controls.Add(this.radmodi);
            this.opc_gp.Controls.Add(this.radno);
            this.opc_gp.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opc_gp.ForeColor = System.Drawing.Color.White;
            this.opc_gp.Location = new System.Drawing.Point(65, 84);
            this.opc_gp.Margin = new System.Windows.Forms.Padding(2);
            this.opc_gp.Name = "opc_gp";
            this.opc_gp.Padding = new System.Windows.Forms.Padding(2);
            this.opc_gp.Size = new System.Drawing.Size(698, 90);
            this.opc_gp.TabIndex = 15;
            this.opc_gp.TabStop = false;
            this.opc_gp.Text = "Mantenimiento";
            // 
            // radagregar
            // 
            this.radagregar.AutoSize = true;
            this.radagregar.Location = new System.Drawing.Point(173, 41);
            this.radagregar.Margin = new System.Windows.Forms.Padding(2);
            this.radagregar.Name = "radagregar";
            this.radagregar.Size = new System.Drawing.Size(250, 26);
            this.radagregar.TabIndex = 10;
            this.radagregar.Text = "Agregar Mantenimiento";
            this.radagregar.UseVisualStyleBackColor = true;
            this.radagregar.CheckedChanged += new System.EventHandler(this.Radagregar_CheckedChanged);
            // 
            // radmodi
            // 
            this.radmodi.AutoSize = true;
            this.radmodi.Location = new System.Drawing.Point(434, 41);
            this.radmodi.Margin = new System.Windows.Forms.Padding(2);
            this.radmodi.Name = "radmodi";
            this.radmodi.Size = new System.Drawing.Size(257, 26);
            this.radmodi.TabIndex = 8;
            this.radmodi.Text = "Modificar Mantenimiento";
            this.radmodi.UseVisualStyleBackColor = true;
            this.radmodi.CheckedChanged += new System.EventHandler(this.Radmodi_CheckedChanged);
            // 
            // radno
            // 
            this.radno.AutoSize = true;
            this.radno.Checked = true;
            this.radno.Location = new System.Drawing.Point(15, 41);
            this.radno.Margin = new System.Windows.Forms.Padding(2);
            this.radno.Name = "radno";
            this.radno.Size = new System.Drawing.Size(144, 26);
            this.radno.TabIndex = 7;
            this.radno.TabStop = true;
            this.radno.Text = "No Modificar";
            this.radno.UseVisualStyleBackColor = true;
            this.radno.CheckedChanged += new System.EventHandler(this.Radno_CheckedChanged);
            // 
            // combmant
            // 
            this.combmant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combmant.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.combmant.FormattingEnabled = true;
            this.combmant.Location = new System.Drawing.Point(348, 211);
            this.combmant.Name = "combmant";
            this.combmant.Size = new System.Drawing.Size(285, 31);
            this.combmant.TabIndex = 189;
            this.combmant.Visible = false;
            this.combmant.SelectedIndexChanged += new System.EventHandler(this.Combmant_SelectedIndexChanged);
            // 
            // labmant
            // 
            this.labmant.AutoSize = true;
            this.labmant.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.labmant.ForeColor = System.Drawing.SystemColors.Window;
            this.labmant.Location = new System.Drawing.Point(148, 211);
            this.labmant.Name = "labmant";
            this.labmant.Size = new System.Drawing.Size(194, 27);
            this.labmant.TabIndex = 190;
            this.labmant.Text = "Mantenimiento:";
            this.labmant.Visible = false;
            // 
            // labnom
            // 
            this.labnom.AutoSize = true;
            this.labnom.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.labnom.ForeColor = System.Drawing.SystemColors.Window;
            this.labnom.Location = new System.Drawing.Point(232, 271);
            this.labnom.Name = "labnom";
            this.labnom.Size = new System.Drawing.Size(110, 27);
            this.labnom.TabIndex = 194;
            this.labnom.Text = "Nombre:";
            this.labnom.Visible = false;
            // 
            // labdesc
            // 
            this.labdesc.AutoSize = true;
            this.labdesc.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.labdesc.ForeColor = System.Drawing.SystemColors.Window;
            this.labdesc.Location = new System.Drawing.Point(189, 326);
            this.labdesc.Name = "labdesc";
            this.labdesc.Size = new System.Drawing.Size(153, 27);
            this.labdesc.TabIndex = 196;
            this.labdesc.Text = "Descripción:";
            this.labdesc.Visible = false;
            // 
            // botingresar
            // 
            this.botingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.botingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botingresar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botingresar.ForeColor = System.Drawing.Color.Transparent;
            this.botingresar.Location = new System.Drawing.Point(400, 393);
            this.botingresar.Name = "botingresar";
            this.botingresar.Size = new System.Drawing.Size(177, 64);
            this.botingresar.TabIndex = 236;
            this.botingresar.Text = "Ingresar";
            this.botingresar.UseVisualStyleBackColor = false;
            this.botingresar.Visible = false;
            this.botingresar.Click += new System.EventHandler(this.Botingresar_Click);
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(348, 271);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(285, 28);
            this.txtnom.TabIndex = 237;
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(348, 325);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(285, 28);
            this.txtdesc.TabIndex = 238;
            // 
            // form_mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(828, 527);
            this.Controls.Add(this.txtdesc);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.botingresar);
            this.Controls.Add(this.labdesc);
            this.Controls.Add(this.labnom);
            this.Controls.Add(this.combmant);
            this.Controls.Add(this.labmant);
            this.Controls.Add(this.opc_gp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_mantenimientos";
            this.Text = "form_mantenimientos";
            this.Load += new System.EventHandler(this.Form_mantenimientos_Load);
            this.opc_gp.ResumeLayout(false);
            this.opc_gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox opc_gp;
        private System.Windows.Forms.RadioButton radagregar;
        private System.Windows.Forms.RadioButton radmodi;
        private System.Windows.Forms.RadioButton radno;
        private System.Windows.Forms.ComboBox combmant;
        private System.Windows.Forms.Label labmant;
        private System.Windows.Forms.Label labnom;
        private System.Windows.Forms.Label labdesc;
        private System.Windows.Forms.Button botingresar;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtdesc;
    }
}