namespace MAD_AAVD_proyecto
{
    partial class FormEmployReport
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
            this.HDCOUNTER_Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RGN_BTN_Filtrar = new System.Windows.Forms.Button();
            this.RGN_DTP_FiltroFecha = new System.Windows.Forms.DateTimePicker();
            this.RGN_DGV_Reporte = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.RGN_CB_Departamento = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGN_DGV_Reporte)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HDCOUNTER_Title
            // 
            this.HDCOUNTER_Title.Location = new System.Drawing.Point(0, 0);
            this.HDCOUNTER_Title.Name = "HDCOUNTER_Title";
            this.HDCOUNTER_Title.Size = new System.Drawing.Size(100, 23);
            this.HDCOUNTER_Title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte General de Nómina";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-2, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 3);
            this.panel2.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 3);
            this.panel1.TabIndex = 40;
            // 
            // RGN_BTN_Filtrar
            // 
            this.RGN_BTN_Filtrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.RGN_BTN_Filtrar.FlatAppearance.BorderSize = 0;
            this.RGN_BTN_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RGN_BTN_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGN_BTN_Filtrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RGN_BTN_Filtrar.Location = new System.Drawing.Point(962, 124);
            this.RGN_BTN_Filtrar.Name = "RGN_BTN_Filtrar";
            this.RGN_BTN_Filtrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RGN_BTN_Filtrar.Size = new System.Drawing.Size(113, 31);
            this.RGN_BTN_Filtrar.TabIndex = 68;
            this.RGN_BTN_Filtrar.Text = "Filtrar";
            this.RGN_BTN_Filtrar.UseVisualStyleBackColor = false;
            // 
            // RGN_DTP_FiltroFecha
            // 
            this.RGN_DTP_FiltroFecha.CustomFormat = "dd/MMM/yyyy";
            this.RGN_DTP_FiltroFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RGN_DTP_FiltroFecha.Location = new System.Drawing.Point(374, 125);
            this.RGN_DTP_FiltroFecha.MaxDate = new System.DateTime(2024, 9, 22, 0, 0, 0, 0);
            this.RGN_DTP_FiltroFecha.MinDate = new System.DateTime(1924, 9, 22, 0, 0, 0, 0);
            this.RGN_DTP_FiltroFecha.Name = "RGN_DTP_FiltroFecha";
            this.RGN_DTP_FiltroFecha.Size = new System.Drawing.Size(128, 26);
            this.RGN_DTP_FiltroFecha.TabIndex = 70;
            this.RGN_DTP_FiltroFecha.Value = new System.DateTime(2024, 9, 22, 0, 0, 0, 0);
            // 
            // RGN_DGV_Reporte
            // 
            this.RGN_DGV_Reporte.BackgroundColor = System.Drawing.Color.Black;
            this.RGN_DGV_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RGN_DGV_Reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.employJob,
            this.employName,
            this.startDate,
            this.employAge,
            this.employSalary});
            this.RGN_DGV_Reporte.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.RGN_DGV_Reporte.Location = new System.Drawing.Point(36, 198);
            this.RGN_DGV_Reporte.Name = "RGN_DGV_Reporte";
            this.RGN_DGV_Reporte.RowHeadersWidth = 51;
            this.RGN_DGV_Reporte.Size = new System.Drawing.Size(1229, 624);
            this.RGN_DGV_Reporte.TabIndex = 71;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.HeaderText = "Departamento";
            this.department.MinimumWidth = 6;
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // employJob
            // 
            this.employJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employJob.HeaderText = "Puesto";
            this.employJob.MinimumWidth = 6;
            this.employJob.Name = "employJob";
            this.employJob.ReadOnly = true;
            // 
            // employName
            // 
            this.employName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employName.HeaderText = "Nombre del empleado";
            this.employName.MinimumWidth = 6;
            this.employName.Name = "employName";
            this.employName.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.startDate.HeaderText = "Fecha de ingreso";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 135;
            // 
            // employAge
            // 
            this.employAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.employAge.HeaderText = "Edad";
            this.employAge.MinimumWidth = 6;
            this.employAge.Name = "employAge";
            this.employAge.ReadOnly = true;
            this.employAge.Width = 60;
            // 
            // employSalary
            // 
            this.employSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.employSalary.HeaderText = "Salario Diario";
            this.employSalary.MinimumWidth = 6;
            this.employSalary.Name = "employSalary";
            this.employSalary.ReadOnly = true;
            this.employSalary.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(10, 170);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1310, 3);
            this.panel3.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(0, 278);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1310, 3);
            this.panel4.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(540, 121);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(169, 31);
            this.button1.TabIndex = 72;
            this.button1.Text = "Departamento:";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RGN_CB_Departamento
            // 
            this.RGN_CB_Departamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.RGN_CB_Departamento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RGN_CB_Departamento.FormattingEnabled = true;
            this.RGN_CB_Departamento.Items.AddRange(new object[] {
            "Todos",
            "Desarrollo",
            "Contabilidad"});
            this.RGN_CB_Departamento.Location = new System.Drawing.Point(707, 124);
            this.RGN_CB_Departamento.Name = "RGN_CB_Departamento";
            this.RGN_CB_Departamento.Size = new System.Drawing.Size(215, 28);
            this.RGN_CB_Departamento.TabIndex = 73;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.AliceBlue;
            this.button2.Location = new System.Drawing.Point(284, 120);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(84, 31);
            this.button2.TabIndex = 74;
            this.button2.Text = "Fecha:";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormEmployReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1307, 874);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RGN_CB_Departamento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.RGN_DGV_Reporte);
            this.Controls.Add(this.RGN_DTP_FiltroFecha);
            this.Controls.Add(this.RGN_BTN_Filtrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HDCOUNTER_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmployReport";
            this.Text = "FormEmployReport";
            this.Load += new System.EventHandler(this.FormEmployReport_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RGN_DGV_Reporte)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HDCOUNTER_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RGN_BTN_Filtrar;
        private System.Windows.Forms.DateTimePicker RGN_DTP_FiltroFecha;
        private System.Windows.Forms.DataGridView RGN_DGV_Reporte;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox RGN_CB_Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn employJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn employName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn employAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn employSalary;
        private System.Windows.Forms.Button button2;
    }
}