namespace MAD_AAVD_proyecto
{
    partial class FormNominaReporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NREPORT_BTN_Filter = new System.Windows.Forms.Button();
            this.NREPORTE_DTP_date = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NREPORTE_DGV_table = new System.Windows.Forms.DataGridView();
            this.departmentJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NREPORTE_DGV_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reporte de Nómina";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(-1, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 3);
            this.panel2.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(0, 278);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 3);
            this.panel1.TabIndex = 40;
            // 
            // NREPORT_BTN_Filter
            // 
            this.NREPORT_BTN_Filter.BackColor = System.Drawing.Color.DodgerBlue;
            this.NREPORT_BTN_Filter.FlatAppearance.BorderSize = 0;
            this.NREPORT_BTN_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NREPORT_BTN_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NREPORT_BTN_Filter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NREPORT_BTN_Filter.Location = new System.Drawing.Point(525, 97);
            this.NREPORT_BTN_Filter.Name = "NREPORT_BTN_Filter";
            this.NREPORT_BTN_Filter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NREPORT_BTN_Filter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NREPORT_BTN_Filter.Size = new System.Drawing.Size(93, 42);
            this.NREPORT_BTN_Filter.TabIndex = 0;
            this.NREPORT_BTN_Filter.Text = "Filtrar";
            this.NREPORT_BTN_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NREPORT_BTN_Filter.UseVisualStyleBackColor = false;
            this.NREPORT_BTN_Filter.Click += new System.EventHandler(this.NREPORT_BTN_Filter_Click);
            // 
            // NREPORTE_DTP_date
            // 
            this.NREPORTE_DTP_date.CalendarMonthBackground = System.Drawing.Color.Black;
            this.NREPORTE_DTP_date.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NREPORTE_DTP_date.CustomFormat = "yyyy";
            this.NREPORTE_DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NREPORTE_DTP_date.Location = new System.Drawing.Point(386, 106);
            this.NREPORTE_DTP_date.Name = "NREPORTE_DTP_date";
            this.NREPORTE_DTP_date.Size = new System.Drawing.Size(106, 26);
            this.NREPORTE_DTP_date.TabIndex = 70;
            this.NREPORTE_DTP_date.ValueChanged += new System.EventHandler(this.NREPORTE_DTP_date_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(-1, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 3);
            this.panel3.TabIndex = 69;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(0, 278);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(983, 3);
            this.panel4.TabIndex = 40;
            // 
            // NREPORTE_DGV_table
            // 
            this.NREPORTE_DGV_table.AllowUserToAddRows = false;
            this.NREPORTE_DGV_table.AllowUserToDeleteRows = false;
            this.NREPORTE_DGV_table.BackgroundColor = System.Drawing.Color.Black;
            this.NREPORTE_DGV_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NREPORTE_DGV_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentJob,
            this.year,
            this.month,
            this.baseSalary,
            this.totalSalary});
            this.NREPORTE_DGV_table.Location = new System.Drawing.Point(37, 176);
            this.NREPORTE_DGV_table.Name = "NREPORTE_DGV_table";
            this.NREPORTE_DGV_table.ReadOnly = true;
            this.NREPORTE_DGV_table.RowHeadersWidth = 51;
            this.NREPORTE_DGV_table.Size = new System.Drawing.Size(902, 498);
            this.NREPORTE_DGV_table.TabIndex = 72;
            this.NREPORTE_DGV_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NREPORTE_DGV_table_CellContentClick);
            // 
            // departmentJob
            // 
            this.departmentJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentJob.HeaderText = "Departamento";
            this.departmentJob.MinimumWidth = 6;
            this.departmentJob.Name = "departmentJob";
            this.departmentJob.ReadOnly = true;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year.HeaderText = "Año";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // month
            // 
            this.month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.month.HeaderText = "Mes";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.ReadOnly = true;
            // 
            // baseSalary
            // 
            this.baseSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.baseSalary.DefaultCellStyle = dataGridViewCellStyle1;
            this.baseSalary.HeaderText = "ΣSueldo Bruto";
            this.baseSalary.MinimumWidth = 6;
            this.baseSalary.Name = "baseSalary";
            this.baseSalary.ReadOnly = true;
            // 
            // totalSalary
            // 
            this.totalSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.totalSalary.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalSalary.HeaderText = "ΣSueldo Neto";
            this.totalSalary.MinimumWidth = 6;
            this.totalSalary.Name = "totalSalary";
            this.totalSalary.ReadOnly = true;
            // 
            // FormNominaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(980, 710);
            this.Controls.Add(this.NREPORTE_DGV_table);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NREPORTE_DTP_date);
            this.Controls.Add(this.NREPORT_BTN_Filter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNominaReporte";
            this.Text = "FormNominaReporte";
            this.Load += new System.EventHandler(this.FormNominaReporte_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NREPORTE_DGV_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NREPORT_BTN_Filter;
        private System.Windows.Forms.DateTimePicker NREPORTE_DTP_date;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView NREPORTE_DGV_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalary;
    }
}