namespace Transporte_Escolar_Bonilla
{
    partial class clientes_frm
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
            this.clienteTop_panel = new System.Windows.Forms.Panel();
            this.consultasClientes_btn = new System.Windows.Forms.Button();
            this.nuevoCliente_btn = new System.Windows.Forms.Button();
            this.modificarCliente_btn = new System.Windows.Forms.Button();
            this.clienteMain_panel = new System.Windows.Forms.Panel();
            this.clienteTop_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteTop_panel
            // 
            this.clienteTop_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(80)))));
            this.clienteTop_panel.Controls.Add(this.modificarCliente_btn);
            this.clienteTop_panel.Controls.Add(this.nuevoCliente_btn);
            this.clienteTop_panel.Controls.Add(this.consultasClientes_btn);
            this.clienteTop_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.clienteTop_panel.Location = new System.Drawing.Point(0, 0);
            this.clienteTop_panel.Name = "clienteTop_panel";
            this.clienteTop_panel.Size = new System.Drawing.Size(1108, 95);
            this.clienteTop_panel.TabIndex = 0;
            // 
            // consultasClientes_btn
            // 
            this.consultasClientes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.consultasClientes_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.consultasClientes_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(129)))));
            this.consultasClientes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultasClientes_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasClientes_btn.ForeColor = System.Drawing.Color.White;
            this.consultasClientes_btn.Location = new System.Drawing.Point(0, 0);
            this.consultasClientes_btn.Name = "consultasClientes_btn";
            this.consultasClientes_btn.Size = new System.Drawing.Size(176, 95);
            this.consultasClientes_btn.TabIndex = 4;
            this.consultasClientes_btn.Text = "Consultas";
            this.consultasClientes_btn.UseVisualStyleBackColor = false;
            // 
            // nuevoCliente_btn
            // 
            this.nuevoCliente_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.nuevoCliente_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.nuevoCliente_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(129)))));
            this.nuevoCliente_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoCliente_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoCliente_btn.ForeColor = System.Drawing.Color.White;
            this.nuevoCliente_btn.Location = new System.Drawing.Point(176, 0);
            this.nuevoCliente_btn.Name = "nuevoCliente_btn";
            this.nuevoCliente_btn.Size = new System.Drawing.Size(176, 95);
            this.nuevoCliente_btn.TabIndex = 5;
            this.nuevoCliente_btn.Text = "Nuevo Cliente";
            this.nuevoCliente_btn.UseVisualStyleBackColor = false;
            // 
            // modificarCliente_btn
            // 
            this.modificarCliente_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(94)))));
            this.modificarCliente_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.modificarCliente_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(129)))));
            this.modificarCliente_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarCliente_btn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarCliente_btn.ForeColor = System.Drawing.Color.White;
            this.modificarCliente_btn.Location = new System.Drawing.Point(352, 0);
            this.modificarCliente_btn.Name = "modificarCliente_btn";
            this.modificarCliente_btn.Size = new System.Drawing.Size(176, 95);
            this.modificarCliente_btn.TabIndex = 6;
            this.modificarCliente_btn.Text = "Modificar Clientes";
            this.modificarCliente_btn.UseVisualStyleBackColor = false;
            // 
            // clienteMain_panel
            // 
            this.clienteMain_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clienteMain_panel.Location = new System.Drawing.Point(0, 95);
            this.clienteMain_panel.Name = "clienteMain_panel";
            this.clienteMain_panel.Size = new System.Drawing.Size(1108, 650);
            this.clienteMain_panel.TabIndex = 7;
            // 
            // clientes_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(72)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1108, 745);
            this.Controls.Add(this.clienteMain_panel);
            this.Controls.Add(this.clienteTop_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientes_frm";
            this.Text = "clientes_frm";
            this.clienteTop_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clienteTop_panel;
        private System.Windows.Forms.Button modificarCliente_btn;
        private System.Windows.Forms.Button nuevoCliente_btn;
        private System.Windows.Forms.Button consultasClientes_btn;
        private System.Windows.Forms.Panel clienteMain_panel;
    }
}