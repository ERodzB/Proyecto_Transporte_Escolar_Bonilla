namespace Transporte_Escolar_Bonilla
{
    partial class rutas_frm
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
            this.rutasTop_panel = new System.Windows.Forms.Panel();
            this.modificarRuta_btn = new System.Windows.Forms.Button();
            this.nuevaRuta_btn = new System.Windows.Forms.Button();
            this.consultasRutas_btn = new System.Windows.Forms.Button();
            this.mainRutas_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rutasTop_panel.SuspendLayout();
            this.mainRutas_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rutasTop_panel
            // 
            this.rutasTop_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.rutasTop_panel.Controls.Add(this.modificarRuta_btn);
            this.rutasTop_panel.Controls.Add(this.nuevaRuta_btn);
            this.rutasTop_panel.Controls.Add(this.consultasRutas_btn);
            this.rutasTop_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rutasTop_panel.ForeColor = System.Drawing.Color.Coral;
            this.rutasTop_panel.Location = new System.Drawing.Point(0, 0);
            this.rutasTop_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rutasTop_panel.Name = "rutasTop_panel";
            this.rutasTop_panel.Size = new System.Drawing.Size(1108, 95);
            this.rutasTop_panel.TabIndex = 0;
            // 
            // modificarRuta_btn
            // 
            this.modificarRuta_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.modificarRuta_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.modificarRuta_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(129)))));
            this.modificarRuta_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarRuta_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarRuta_btn.ForeColor = System.Drawing.Color.Transparent;
            this.modificarRuta_btn.Location = new System.Drawing.Point(358, 0);
            this.modificarRuta_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificarRuta_btn.Name = "modificarRuta_btn";
            this.modificarRuta_btn.Size = new System.Drawing.Size(217, 95);
            this.modificarRuta_btn.TabIndex = 3;
            this.modificarRuta_btn.Text = "Modificar Rutas";
            this.modificarRuta_btn.UseVisualStyleBackColor = false;
            // 
            // nuevaRuta_btn
            // 
            this.nuevaRuta_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.nuevaRuta_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.nuevaRuta_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(129)))));
            this.nuevaRuta_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevaRuta_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevaRuta_btn.ForeColor = System.Drawing.Color.Transparent;
            this.nuevaRuta_btn.Location = new System.Drawing.Point(179, 0);
            this.nuevaRuta_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nuevaRuta_btn.Name = "nuevaRuta_btn";
            this.nuevaRuta_btn.Size = new System.Drawing.Size(179, 95);
            this.nuevaRuta_btn.TabIndex = 2;
            this.nuevaRuta_btn.Text = "Nueva Ruta";
            this.nuevaRuta_btn.UseVisualStyleBackColor = false;
            this.nuevaRuta_btn.Click += new System.EventHandler(this.NuevaRuta_btn_Click);
            // 
            // consultasRutas_btn
            // 
            this.consultasRutas_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.consultasRutas_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.consultasRutas_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(129)))));
            this.consultasRutas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultasRutas_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasRutas_btn.ForeColor = System.Drawing.Color.Transparent;
            this.consultasRutas_btn.Location = new System.Drawing.Point(0, 0);
            this.consultasRutas_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consultasRutas_btn.Name = "consultasRutas_btn";
            this.consultasRutas_btn.Size = new System.Drawing.Size(179, 95);
            this.consultasRutas_btn.TabIndex = 1;
            this.consultasRutas_btn.Text = "Consultas";
            this.consultasRutas_btn.UseVisualStyleBackColor = false;
            this.consultasRutas_btn.Click += new System.EventHandler(this.ConsultasRutas_btn_Click);
            // 
            // mainRutas_panel
            // 
            this.mainRutas_panel.Controls.Add(this.label1);
            this.mainRutas_panel.Controls.Add(this.pictureBox1);
            this.mainRutas_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainRutas_panel.Location = new System.Drawing.Point(0, 95);
            this.mainRutas_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainRutas_panel.Name = "mainRutas_panel";
            this.mainRutas_panel.Size = new System.Drawing.Size(1108, 650);
            this.mainRutas_panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(31, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 80);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bienvenido al Módulo de Rutas\r\nSeleccione la acción que desea realizar del menú s" +
    "uperior\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Transporte_Escolar_Bonilla.Properties.Resources.bus;
            this.pictureBox1.Location = new System.Drawing.Point(341, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // rutas_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 745);
            this.Controls.Add(this.mainRutas_panel);
            this.Controls.Add(this.rutasTop_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "rutas_frm";
            this.Text = "rutas_frm";
            this.rutasTop_panel.ResumeLayout(false);
            this.mainRutas_panel.ResumeLayout(false);
            this.mainRutas_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rutasTop_panel;
        private System.Windows.Forms.Button consultasRutas_btn;
        private System.Windows.Forms.Button modificarRuta_btn;
        private System.Windows.Forms.Button nuevaRuta_btn;
        private System.Windows.Forms.Panel mainRutas_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}