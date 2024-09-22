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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NREPORT_Filter = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NREPORT_OrderBy = new System.Windows.Forms.Button();
            this.NReport_CB_OrderBy = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 45);
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
            // NREPORT_Filter
            // 
            this.NREPORT_Filter.BackColor = System.Drawing.Color.DodgerBlue;
            this.NREPORT_Filter.FlatAppearance.BorderSize = 0;
            this.NREPORT_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NREPORT_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NREPORT_Filter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NREPORT_Filter.Location = new System.Drawing.Point(156, 100);
            this.NREPORT_Filter.Name = "NREPORT_Filter";
            this.NREPORT_Filter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NREPORT_Filter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NREPORT_Filter.Size = new System.Drawing.Size(155, 39);
            this.NREPORT_Filter.TabIndex = 0;
            this.NREPORT_Filter.Text = "Filtrar por año";
            this.NREPORT_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NREPORT_Filter.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 22);
            this.dateTimePicker1.TabIndex = 70;
            // 
            // NREPORT_OrderBy
            // 
            this.NREPORT_OrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.NREPORT_OrderBy.FlatAppearance.BorderSize = 0;
            this.NREPORT_OrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NREPORT_OrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NREPORT_OrderBy.ForeColor = System.Drawing.Color.AliceBlue;
            this.NREPORT_OrderBy.Location = new System.Drawing.Point(478, 93);
            this.NREPORT_OrderBy.Name = "NREPORT_OrderBy";
            this.NREPORT_OrderBy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.NREPORT_OrderBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NREPORT_OrderBy.Size = new System.Drawing.Size(131, 53);
            this.NREPORT_OrderBy.TabIndex = 0;
            this.NREPORT_OrderBy.Text = "Ordenar por:";
            this.NREPORT_OrderBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NREPORT_OrderBy.UseVisualStyleBackColor = false;
            this.NREPORT_OrderBy.Click += new System.EventHandler(this.button1_Click);
            // 
            // NReport_CB_OrderBy
            // 
            this.NReport_CB_OrderBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.NReport_CB_OrderBy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NReport_CB_OrderBy.FormattingEnabled = true;
            this.NReport_CB_OrderBy.Items.AddRange(new object[] {
            "Departamento",
            "Año",
            "Mes"});
            this.NReport_CB_OrderBy.Location = new System.Drawing.Point(602, 109);
            this.NReport_CB_OrderBy.Name = "NReport_CB_OrderBy";
            this.NReport_CB_OrderBy.Size = new System.Drawing.Size(337, 24);
            this.NReport_CB_OrderBy.TabIndex = 71;
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentJob,
            this.year,
            this.month,
            this.baseSalary,
            this.totalSalary});
            this.dataGridView1.Location = new System.Drawing.Point(37, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 498);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // departmentJob
            // 
            this.departmentJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentJob.HeaderText = "Departamento";
            this.departmentJob.Name = "departmentJob";
            this.departmentJob.ReadOnly = true;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year.HeaderText = "Año";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // month
            // 
            this.month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.month.HeaderText = "Mes";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            // 
            // baseSalary
            // 
            this.baseSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.baseSalary.HeaderText = "ΣSueldo Bruto";
            this.baseSalary.Name = "baseSalary";
            this.baseSalary.ReadOnly = true;
            // 
            // totalSalary
            // 
            this.totalSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalSalary.HeaderText = "ΣSueldo Neto";
            this.totalSalary.Name = "totalSalary";
            this.totalSalary.ReadOnly = true;
            // 
            // FormNominaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(980, 710);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.NReport_CB_OrderBy);
            this.Controls.Add(this.NREPORT_OrderBy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.NREPORT_Filter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormNominaReporte";
            this.Text = "FormNominaReporte";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NREPORT_Filter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button NREPORT_OrderBy;
        private System.Windows.Forms.ComboBox NReport_CB_OrderBy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalary;
    }
}