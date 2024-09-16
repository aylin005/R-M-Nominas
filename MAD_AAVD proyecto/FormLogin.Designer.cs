namespace MAD_AAVD_proyecto
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LOGIN_BTN_login = new System.Windows.Forms.Button();
            this.LOGIN_TB_username = new System.Windows.Forms.TextBox();
            this.LOGIN_TB_password = new System.Windows.Forms.TextBox();
            this.inicioSesion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.LOGIN_BTN_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 395);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(36, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 3);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(36, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 3);
            this.panel2.TabIndex = 3;
            // 
            // LOGIN_BTN_login
            // 
            this.LOGIN_BTN_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.LOGIN_BTN_login.FlatAppearance.BorderSize = 0;
            this.LOGIN_BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN_BTN_login.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_BTN_login.Location = new System.Drawing.Point(36, 521);
            this.LOGIN_BTN_login.Name = "LOGIN_BTN_login";
            this.LOGIN_BTN_login.Size = new System.Drawing.Size(382, 43);
            this.LOGIN_BTN_login.TabIndex = 4;
            this.LOGIN_BTN_login.Text = "INGRESAR";
            this.LOGIN_BTN_login.UseVisualStyleBackColor = false;
            this.LOGIN_BTN_login.Click += new System.EventHandler(this.LOGIN_BTN_login_Click);
            // 
            // LOGIN_TB_username
            // 
            this.LOGIN_TB_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.LOGIN_TB_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LOGIN_TB_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_TB_username.ForeColor = System.Drawing.Color.White;
            this.LOGIN_TB_username.Location = new System.Drawing.Point(90, 300);
            this.LOGIN_TB_username.Multiline = true;
            this.LOGIN_TB_username.Name = "LOGIN_TB_username";
            this.LOGIN_TB_username.Size = new System.Drawing.Size(325, 31);
            this.LOGIN_TB_username.TabIndex = 2;
            // 
            // LOGIN_TB_password
            // 
            this.LOGIN_TB_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.LOGIN_TB_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LOGIN_TB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_TB_password.ForeColor = System.Drawing.Color.White;
            this.LOGIN_TB_password.Location = new System.Drawing.Point(93, 416);
            this.LOGIN_TB_password.Multiline = true;
            this.LOGIN_TB_password.Name = "LOGIN_TB_password";
            this.LOGIN_TB_password.PasswordChar = '*';
            this.LOGIN_TB_password.Size = new System.Drawing.Size(325, 31);
            this.LOGIN_TB_password.TabIndex = 3;
            // 
            // inicioSesion
            // 
            this.inicioSesion.AutoSize = true;
            this.inicioSesion.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioSesion.ForeColor = System.Drawing.Color.White;
            this.inicioSesion.Location = new System.Drawing.Point(101, 213);
            this.inicioSesion.Name = "inicioSesion";
            this.inicioSesion.Size = new System.Drawing.Size(254, 36);
            this.inicioSesion.TabIndex = 1;
            this.inicioSesion.Text = "INICIO DE SESIÓN";
            this.inicioSesion.Click += new System.EventHandler(this.inicioSesion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(149, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 138);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(400, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 54);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LOGIN_BTN_exit
            // 
            this.LOGIN_BTN_exit.FlatAppearance.BorderSize = 0;
            this.LOGIN_BTN_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN_BTN_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_BTN_exit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.LOGIN_BTN_exit.Location = new System.Drawing.Point(188, 586);
            this.LOGIN_BTN_exit.Name = "LOGIN_BTN_exit";
            this.LOGIN_BTN_exit.Size = new System.Drawing.Size(75, 33);
            this.LOGIN_BTN_exit.TabIndex = 5;
            this.LOGIN_BTN_exit.Text = "Salir";
            this.LOGIN_BTN_exit.UseVisualStyleBackColor = true;
            this.LOGIN_BTN_exit.Click += new System.EventHandler(this.LOGIN_BTN_exit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(453, 671);
            this.Controls.Add(this.LOGIN_BTN_exit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inicioSesion);
            this.Controls.Add(this.LOGIN_TB_password);
            this.Controls.Add(this.LOGIN_TB_username);
            this.Controls.Add(this.LOGIN_BTN_login);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LOGIN_BTN_login;
        private System.Windows.Forms.TextBox LOGIN_TB_username;
        private System.Windows.Forms.TextBox LOGIN_TB_password;
        private System.Windows.Forms.Label inicioSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button LOGIN_BTN_exit;
    }
}

