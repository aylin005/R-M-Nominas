namespace MAD_AAVD_proyecto
{
    partial class FormUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.SMUSER_Panel = new System.Windows.Forms.Panel();
            this.SMUSER_Recibo = new System.Windows.Forms.Button();
            this.SMUSER_EditarEmpleado = new System.Windows.Forms.Button();
            this.SMUSER_Panel_Logo = new System.Windows.Forms.Panel();
            this.SMUSER_Logout = new System.Windows.Forms.Button();
            this.USER_TopBar = new System.Windows.Forms.Panel();
            this.USER_Close = new System.Windows.Forms.Button();
            this.USER_PanelChildForm = new System.Windows.Forms.Panel();
            this.SMUSER_Panel.SuspendLayout();
            this.USER_TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SMUSER_Panel
            // 
            this.SMUSER_Panel.AutoScroll = true;
            this.SMUSER_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.SMUSER_Panel.Controls.Add(this.SMUSER_Recibo);
            this.SMUSER_Panel.Controls.Add(this.SMUSER_EditarEmpleado);
            this.SMUSER_Panel.Controls.Add(this.SMUSER_Panel_Logo);
            this.SMUSER_Panel.Controls.Add(this.SMUSER_Logout);
            this.SMUSER_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SMUSER_Panel.Location = new System.Drawing.Point(0, 0);
            this.SMUSER_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.SMUSER_Panel.Name = "SMUSER_Panel";
            this.SMUSER_Panel.Size = new System.Drawing.Size(199, 704);
            this.SMUSER_Panel.TabIndex = 1;
            // 
            // SMUSER_Recibo
            // 
            this.SMUSER_Recibo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SMUSER_Recibo.FlatAppearance.BorderSize = 0;
            this.SMUSER_Recibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMUSER_Recibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMUSER_Recibo.ForeColor = System.Drawing.Color.AliceBlue;
            this.SMUSER_Recibo.Image = ((System.Drawing.Image)(resources.GetObject("SMUSER_Recibo.Image")));
            this.SMUSER_Recibo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SMUSER_Recibo.Location = new System.Drawing.Point(0, 147);
            this.SMUSER_Recibo.Margin = new System.Windows.Forms.Padding(2);
            this.SMUSER_Recibo.Name = "SMUSER_Recibo";
            this.SMUSER_Recibo.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.SMUSER_Recibo.Size = new System.Drawing.Size(199, 47);
            this.SMUSER_Recibo.TabIndex = 11;
            this.SMUSER_Recibo.Text = " Recibo de nómina";
            this.SMUSER_Recibo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SMUSER_Recibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SMUSER_Recibo.UseVisualStyleBackColor = true;
            this.SMUSER_Recibo.Click += new System.EventHandler(this.SMUSER_Recibo_Click);
            // 
            // SMUSER_EditarEmpleado
            // 
            this.SMUSER_EditarEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.SMUSER_EditarEmpleado.FlatAppearance.BorderSize = 0;
            this.SMUSER_EditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMUSER_EditarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMUSER_EditarEmpleado.ForeColor = System.Drawing.Color.AliceBlue;
            this.SMUSER_EditarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("SMUSER_EditarEmpleado.Image")));
            this.SMUSER_EditarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SMUSER_EditarEmpleado.Location = new System.Drawing.Point(0, 100);
            this.SMUSER_EditarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.SMUSER_EditarEmpleado.Name = "SMUSER_EditarEmpleado";
            this.SMUSER_EditarEmpleado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SMUSER_EditarEmpleado.Size = new System.Drawing.Size(199, 47);
            this.SMUSER_EditarEmpleado.TabIndex = 8;
            this.SMUSER_EditarEmpleado.Text = " Datos personales";
            this.SMUSER_EditarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SMUSER_EditarEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SMUSER_EditarEmpleado.UseVisualStyleBackColor = true;
            this.SMUSER_EditarEmpleado.Click += new System.EventHandler(this.SM_Puestos_Click);
            // 
            // SMUSER_Panel_Logo
            // 
            this.SMUSER_Panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SMUSER_Panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.SMUSER_Panel_Logo.Margin = new System.Windows.Forms.Padding(2);
            this.SMUSER_Panel_Logo.Name = "SMUSER_Panel_Logo";
            this.SMUSER_Panel_Logo.Size = new System.Drawing.Size(199, 100);
            this.SMUSER_Panel_Logo.TabIndex = 5;
            // 
            // SMUSER_Logout
            // 
            this.SMUSER_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.SMUSER_Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SMUSER_Logout.FlatAppearance.BorderSize = 0;
            this.SMUSER_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMUSER_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMUSER_Logout.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.SMUSER_Logout.Location = new System.Drawing.Point(0, 664);
            this.SMUSER_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.SMUSER_Logout.Name = "SMUSER_Logout";
            this.SMUSER_Logout.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.SMUSER_Logout.Size = new System.Drawing.Size(199, 40);
            this.SMUSER_Logout.TabIndex = 4;
            this.SMUSER_Logout.Text = "Cerrar sesión";
            this.SMUSER_Logout.UseVisualStyleBackColor = false;
            this.SMUSER_Logout.Click += new System.EventHandler(this.SMUSER_Logout_Click);
            // 
            // USER_TopBar
            // 
            this.USER_TopBar.BackColor = System.Drawing.Color.Black;
            this.USER_TopBar.Controls.Add(this.USER_Close);
            this.USER_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.USER_TopBar.Location = new System.Drawing.Point(199, 0);
            this.USER_TopBar.Name = "USER_TopBar";
            this.USER_TopBar.Size = new System.Drawing.Size(965, 34);
            this.USER_TopBar.TabIndex = 2;
            // 
            // USER_Close
            // 
            this.USER_Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("USER_Close.BackgroundImage")));
            this.USER_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.USER_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.USER_Close.FlatAppearance.BorderSize = 0;
            this.USER_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.USER_Close.Location = new System.Drawing.Point(929, 0);
            this.USER_Close.Name = "USER_Close";
            this.USER_Close.Size = new System.Drawing.Size(36, 34);
            this.USER_Close.TabIndex = 0;
            this.USER_Close.UseVisualStyleBackColor = true;
            this.USER_Close.Click += new System.EventHandler(this.USER_Close_Click);
            // 
            // USER_PanelChildForm
            // 
            this.USER_PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.USER_PanelChildForm.Location = new System.Drawing.Point(199, 34);
            this.USER_PanelChildForm.Name = "USER_PanelChildForm";
            this.USER_PanelChildForm.Size = new System.Drawing.Size(965, 670);
            this.USER_PanelChildForm.TabIndex = 3;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1164, 704);
            this.Controls.Add(this.USER_PanelChildForm);
            this.Controls.Add(this.USER_TopBar);
            this.Controls.Add(this.SMUSER_Panel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuario";
            this.SMUSER_Panel.ResumeLayout(false);
            this.USER_TopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SMUSER_Panel;
        private System.Windows.Forms.Button SMUSER_Recibo;
        private System.Windows.Forms.Button SMUSER_EditarEmpleado;
        private System.Windows.Forms.Panel SMUSER_Panel_Logo;
        private System.Windows.Forms.Button SMUSER_Logout;
        private System.Windows.Forms.Panel USER_TopBar;
        private System.Windows.Forms.Button USER_Close;
        private System.Windows.Forms.Panel USER_PanelChildForm;
    }
}