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
            this.HDCOUNTER_Filter = new System.Windows.Forms.Button();
            this.HDCOUNTER_DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(249, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(481, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte General de Nómina";
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
            this.panel2.TabIndex = 67;
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
            // HDCOUNTER_Filter
            // 
            this.HDCOUNTER_Filter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HDCOUNTER_Filter.FlatAppearance.BorderSize = 0;
            this.HDCOUNTER_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HDCOUNTER_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDCOUNTER_Filter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HDCOUNTER_Filter.Location = new System.Drawing.Point(50, 96);
            this.HDCOUNTER_Filter.Name = "HDCOUNTER_Filter";
            this.HDCOUNTER_Filter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HDCOUNTER_Filter.Size = new System.Drawing.Size(155, 39);
            this.HDCOUNTER_Filter.TabIndex = 68;
            this.HDCOUNTER_Filter.Text = "Filtrar por fecha";
            this.HDCOUNTER_Filter.UseVisualStyleBackColor = false;
            this.HDCOUNTER_Filter.Click += new System.EventHandler(this.HDCOUNTER_Filter_Click);
            // 
            // HDCOUNTER_DTP_Date
            // 
            this.HDCOUNTER_DTP_Date.CustomFormat = "dd/mmm/yyyy";
            this.HDCOUNTER_DTP_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HDCOUNTER_DTP_Date.Location = new System.Drawing.Point(211, 105);
            this.HDCOUNTER_DTP_Date.MaxDate = new System.DateTime(2024, 9, 22, 0, 0, 0, 0);
            this.HDCOUNTER_DTP_Date.MinDate = new System.DateTime(1924, 9, 22, 0, 0, 0, 0);
            this.HDCOUNTER_DTP_Date.Name = "HDCOUNTER_DTP_Date";
            this.HDCOUNTER_DTP_Date.Size = new System.Drawing.Size(224, 22);
            this.HDCOUNTER_DTP_Date.TabIndex = 70;
            this.HDCOUNTER_DTP_Date.Value = new System.DateTime(2024, 9, 22, 0, 0, 0, 0);
            this.HDCOUNTER_DTP_Date.ValueChanged += new System.EventHandler(this.HDCOUNTER_DTP_Date_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.employJob,
            this.employName,
            this.startDate,
            this.employAge,
            this.employSalary});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(50, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 485);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.HeaderText = "Departamento";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // employJob
            // 
            this.employJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employJob.HeaderText = "Puesto";
            this.employJob.Name = "employJob";
            this.employJob.ReadOnly = true;
            // 
            // employName
            // 
            this.employName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employName.HeaderText = "Nombre del empleado";
            this.employName.Name = "employName";
            this.employName.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.startDate.HeaderText = "Fecha de ingreso";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 135;
            // 
            // employAge
            // 
            this.employAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.employAge.HeaderText = "Edad";
            this.employAge.Name = "employAge";
            this.employAge.ReadOnly = true;
            this.employAge.Width = 60;
            // 
            // employSalary
            // 
            this.employSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.employSalary.HeaderText = "Salario Diario";
            this.employSalary.Name = "employSalary";
            this.employSalary.ReadOnly = true;
            this.employSalary.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(11, 148);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 3);
            this.panel3.TabIndex = 68;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(523, 90);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(130, 53);
            this.button1.TabIndex = 72;
            this.button1.Text = "Ordenar por:";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Departamento",
            "Puesto",
            "Nombre(s)",
            "Apellido paterno",
            "Apellido materno"});
            this.comboBox1.Location = new System.Drawing.Point(644, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 73;
            // 
            // FormEmployReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(980, 710);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HDCOUNTER_DTP_Date);
            this.Controls.Add(this.HDCOUNTER_Filter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HDCOUNTER_Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmployReport";
            this.Text = "FormEmployReport";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HDCOUNTER_Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HDCOUNTER_Filter;
        private System.Windows.Forms.DateTimePicker HDCOUNTER_DTP_Date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn employJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn employName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn employAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn employSalary;
    }
}