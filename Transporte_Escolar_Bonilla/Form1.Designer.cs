﻿namespace Transporte_Escolar_Bonilla
{
    partial class Principal_frm
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.salir_btn = new System.Windows.Forms.Button();
            this.center_panel = new System.Windows.Forms.Panel();
            this.left_panel = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.bar_panel = new System.Windows.Forms.Panel();
            this.usuarios_btn = new System.Windows.Forms.Button();
            this.contratos_btn = new System.Windows.Forms.Button();
            this.clientes_btn = new System.Windows.Forms.Button();
            this.conductores_btn = new System.Windows.Forms.Button();
            this.unidades_btn = new System.Windows.Forms.Button();
            this.rutas_btn = new System.Windows.Forms.Button();
            this.top_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(36)))), ((int)(((byte)(73)))));
            this.top_panel.Controls.Add(this.salir_btn);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1420, 35);
            this.top_panel.TabIndex = 2;
            // 
            // salir_btn
            // 
            this.salir_btn.BackColor = System.Drawing.Color.Transparent;
            this.salir_btn.BackgroundImage = global::Transporte_Escolar_Bonilla.Properties.Resources.remove_symbol;
            this.salir_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.salir_btn.FlatAppearance.BorderSize = 0;
            this.salir_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.salir_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.salir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir_btn.Location = new System.Drawing.Point(1387, 6);
            this.salir_btn.Name = "salir_btn";
            this.salir_btn.Size = new System.Drawing.Size(24, 21);
            this.salir_btn.TabIndex = 0;
            this.salir_btn.UseVisualStyleBackColor = false;
            this.salir_btn.Click += new System.EventHandler(this.Salir_btn_Click);
            // 
            // center_panel
            // 
            this.center_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.center_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.center_panel.Location = new System.Drawing.Point(314, 35);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(1106, 745);
            this.center_panel.TabIndex = 3;
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(64)))));
            this.left_panel.Controls.Add(this.close_btn);
            this.left_panel.Controls.Add(this.bar_panel);
            this.left_panel.Controls.Add(this.usuarios_btn);
            this.left_panel.Controls.Add(this.contratos_btn);
            this.left_panel.Controls.Add(this.clientes_btn);
            this.left_panel.Controls.Add(this.conductores_btn);
            this.left_panel.Controls.Add(this.unidades_btn);
            this.left_panel.Controls.Add(this.rutas_btn);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 35);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(315, 745);
            this.left_panel.TabIndex = 4;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.close_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(108)))));
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.close_btn.Location = new System.Drawing.Point(0, 678);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(315, 67);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "Cerrar Sessión";
            this.close_btn.UseVisualStyleBackColor = false;
            // 
            // bar_panel
            // 
            this.bar_panel.BackColor = System.Drawing.Color.White;
            this.bar_panel.Location = new System.Drawing.Point(0, 0);
            this.bar_panel.Name = "bar_panel";
            this.bar_panel.Size = new System.Drawing.Size(12, 113);
            this.bar_panel.TabIndex = 6;
            // 
            // usuarios_btn
            // 
            this.usuarios_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.usuarios_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuarios_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(108)))));
            this.usuarios_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usuarios_btn.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarios_btn.ForeColor = System.Drawing.Color.White;
            this.usuarios_btn.Location = new System.Drawing.Point(0, 565);
            this.usuarios_btn.Name = "usuarios_btn";
            this.usuarios_btn.Size = new System.Drawing.Size(315, 113);
            this.usuarios_btn.TabIndex = 5;
            this.usuarios_btn.Text = "Usuarios";
            this.usuarios_btn.UseVisualStyleBackColor = false;
            this.usuarios_btn.Click += new System.EventHandler(this.Usuarios_btn_Click);
            // 
            // contratos_btn
            // 
            this.contratos_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.contratos_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.contratos_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(108)))));
            this.contratos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contratos_btn.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Italic);
            this.contratos_btn.ForeColor = System.Drawing.Color.White;
            this.contratos_btn.Location = new System.Drawing.Point(0, 452);
            this.contratos_btn.Name = "contratos_btn";
            this.contratos_btn.Size = new System.Drawing.Size(315, 113);
            this.contratos_btn.TabIndex = 4;
            this.contratos_btn.Text = "Contratos";
            this.contratos_btn.UseVisualStyleBackColor = false;
            this.contratos_btn.Click += new System.EventHandler(this.Users_btn_Click);
            // 
            // clientes_btn
            // 
            this.clientes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.clientes_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientes_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(108)))));
            this.clientes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientes_btn.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Italic);
            this.clientes_btn.ForeColor = System.Drawing.Color.White;
            this.clientes_btn.Location = new System.Drawing.Point(0, 339);
            this.clientes_btn.Name = "clientes_btn";
            this.clientes_btn.Size = new System.Drawing.Size(315, 113);
            this.clientes_btn.TabIndex = 3;
            this.clientes_btn.Text = "Clientes";
            this.clientes_btn.UseVisualStyleBackColor = false;
            this.clientes_btn.Click += new System.EventHandler(this.Viajes_btn_Click);
            // 
            // conductores_btn
            // 
            this.conductores_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.conductores_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.conductores_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(108)))));
            this.conductores_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conductores_btn.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Italic);
            this.conductores_btn.ForeColor = System.Drawing.Color.White;
            this.conductores_btn.Location = new System.Drawing.Point(0, 226);
            this.conductores_btn.Name = "conductores_btn";
            this.conductores_btn.Size = new System.Drawing.Size(315, 113);
            this.conductores_btn.TabIndex = 2;
            this.conductores_btn.Text = "Conductores";
            this.conductores_btn.UseVisualStyleBackColor = false;
            this.conductores_btn.Click += new System.EventHandler(this.Contratos_btn_Click);
            // 
            // unidades_btn
            // 
            this.unidades_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.unidades_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.unidades_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(108)))));
            this.unidades_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unidades_btn.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidades_btn.ForeColor = System.Drawing.Color.White;
            this.unidades_btn.Location = new System.Drawing.Point(0, 113);
            this.unidades_btn.Name = "unidades_btn";
            this.unidades_btn.Size = new System.Drawing.Size(315, 113);
            this.unidades_btn.TabIndex = 1;
            this.unidades_btn.Text = "Unidades de \r\nTransporte\r\n";
            this.unidades_btn.UseVisualStyleBackColor = false;
            this.unidades_btn.Click += new System.EventHandler(this.Unidades_btn_Click);
            // 
            // rutas_btn
            // 
            this.rutas_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(44)))));
            this.rutas_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rutas_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(108)))));
            this.rutas_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rutas_btn.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutas_btn.ForeColor = System.Drawing.Color.White;
            this.rutas_btn.Location = new System.Drawing.Point(0, 0);
            this.rutas_btn.Name = "rutas_btn";
            this.rutas_btn.Size = new System.Drawing.Size(315, 113);
            this.rutas_btn.TabIndex = 0;
            this.rutas_btn.Text = "Rutas";
            this.rutas_btn.UseVisualStyleBackColor = false;
            this.rutas_btn.Click += new System.EventHandler(this.Rutas_btn_Click);
            // 
            // Principal_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(80)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1420, 780);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.center_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal_frm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.top_panel.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button salir_btn;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel center_panel;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Button usuarios_btn;
        private System.Windows.Forms.Button contratos_btn;
        private System.Windows.Forms.Button clientes_btn;
        private System.Windows.Forms.Button conductores_btn;
        private System.Windows.Forms.Button unidades_btn;
        private System.Windows.Forms.Button rutas_btn;
        private System.Windows.Forms.Panel bar_panel;
        private System.Windows.Forms.Button close_btn;
    }
}

