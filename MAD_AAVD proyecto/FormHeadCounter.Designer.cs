namespace MAD_AAVD_proyecto
{
    partial class FormHeadCounter
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HDCOUNTER_FilterOptions = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HDCOUNTER_ComboBoxDep = new System.Windows.Forms.ComboBox();
            this.HDCOUNTER_Filter = new System.Windows.Forms.Button();
            this.HDCOUNTER_DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.HDCOUNTER_DGV_table = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employCountDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employCountJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.HDCOUNTER_CB_orderOption = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.HDCOUNTER_FilterOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDCOUNTER_DGV_table)).BeginInit();
            this.SuspendLayout();
            // 
            // HDCOUNTER_Title
            // 
            this.HDCOUNTER_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HDCOUNTER_Title.AutoSize = true;
            this.HDCOUNTER_Title.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDCOUNTER_Title.Location = new System.Drawing.Point(374, 14);
            this.HDCOUNTER_Title.Name = "HDCOUNTER_Title";
            this.HDCOUNTER_Title.Size = new System.Drawing.Size(233, 45);
            this.HDCOUNTER_Title.TabIndex = 1;
            this.HDCOUNTER_Title.Text = "Headcounter";
            this.HDCOUNTER_Title.Click += new System.EventHandler(this.HDCOUNTER_Title_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 3);
            this.panel2.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.HDCOUNTER_FilterOptions);
            this.panel5.Location = new System.Drawing.Point(-1, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(982, 62);
            this.panel5.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 3);
            this.panel1.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 3);
            this.panel3.TabIndex = 40;
            // 
            // HDCOUNTER_FilterOptions
            // 
            this.HDCOUNTER_FilterOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.HDCOUNTER_FilterOptions.Controls.Add(this.label1);
            this.HDCOUNTER_FilterOptions.Controls.Add(this.HDCOUNTER_ComboBoxDep);
            this.HDCOUNTER_FilterOptions.Controls.Add(this.HDCOUNTER_Filter);
            this.HDCOUNTER_FilterOptions.Controls.Add(this.HDCOUNTER_DTP_Date);
            this.HDCOUNTER_FilterOptions.Controls.Add(this.label5);
            this.HDCOUNTER_FilterOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.HDCOUNTER_FilterOptions.Location = new System.Drawing.Point(0, 0);
            this.HDCOUNTER_FilterOptions.Name = "HDCOUNTER_FilterOptions";
            this.HDCOUNTER_FilterOptions.Size = new System.Drawing.Size(982, 112);
            this.HDCOUNTER_FilterOptions.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(158, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Por departamento: ";
            // 
            // HDCOUNTER_ComboBoxDep
            // 
            this.HDCOUNTER_ComboBoxDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.HDCOUNTER_ComboBoxDep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HDCOUNTER_ComboBoxDep.FormattingEnabled = true;
            this.HDCOUNTER_ComboBoxDep.Items.AddRange(new object[] {
            "Todos",
            "Por departamento",
            "Por departamento y puesto"});
            this.HDCOUNTER_ComboBoxDep.Location = new System.Drawing.Point(298, 17);
            this.HDCOUNTER_ComboBoxDep.Name = "HDCOUNTER_ComboBoxDep";
            this.HDCOUNTER_ComboBoxDep.Size = new System.Drawing.Size(310, 21);
            this.HDCOUNTER_ComboBoxDep.TabIndex = 4;
            this.HDCOUNTER_ComboBoxDep.SelectedIndexChanged += new System.EventHandler(this.HDCOUNTER_ComboBoxDep_SelectedIndexChanged);
            // 
            // HDCOUNTER_Filter
            // 
            this.HDCOUNTER_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.HDCOUNTER_Filter.FlatAppearance.BorderSize = 0;
            this.HDCOUNTER_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HDCOUNTER_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDCOUNTER_Filter.ForeColor = System.Drawing.Color.AliceBlue;
            this.HDCOUNTER_Filter.Location = new System.Drawing.Point(33, 7);
            this.HDCOUNTER_Filter.Name = "HDCOUNTER_Filter";
            this.HDCOUNTER_Filter.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HDCOUNTER_Filter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HDCOUNTER_Filter.Size = new System.Drawing.Size(92, 41);
            this.HDCOUNTER_Filter.TabIndex = 53;
            this.HDCOUNTER_Filter.Text = "Filtrar";
            this.HDCOUNTER_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HDCOUNTER_Filter.UseVisualStyleBackColor = true;
            // 
            // HDCOUNTER_DTP_Date
            // 
            this.HDCOUNTER_DTP_Date.Location = new System.Drawing.Point(746, 18);
            this.HDCOUNTER_DTP_Date.Name = "HDCOUNTER_DTP_Date";
            this.HDCOUNTER_DTP_Date.Size = new System.Drawing.Size(198, 20);
            this.HDCOUNTER_DTP_Date.TabIndex = 6;
            this.HDCOUNTER_DTP_Date.ValueChanged += new System.EventHandler(this.HDCOUNTER_DTP_Date_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(639, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "|    Por fecha: ";
            // 
            // HDCOUNTER_DGV_table
            // 
            this.HDCOUNTER_DGV_table.BackgroundColor = System.Drawing.Color.Black;
            this.HDCOUNTER_DGV_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HDCOUNTER_DGV_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.employCountDep,
            this.jobPlace,
            this.employCountJob});
            this.HDCOUNTER_DGV_table.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.HDCOUNTER_DGV_table.Location = new System.Drawing.Point(45, 196);
            this.HDCOUNTER_DGV_table.Name = "HDCOUNTER_DGV_table";
            this.HDCOUNTER_DGV_table.Size = new System.Drawing.Size(898, 486);
            this.HDCOUNTER_DGV_table.TabIndex = 47;
            this.HDCOUNTER_DGV_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HDCOUNTER_DGV_table_CellContentClick);
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.HeaderText = "Departamento";
            this.department.Name = "department";
            this.department.ReadOnly = true;
            // 
            // employCountDep
            // 
            this.employCountDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employCountDep.HeaderText = "Cantidad de empleados por departamento";
            this.employCountDep.Name = "employCountDep";
            this.employCountDep.ReadOnly = true;
            // 
            // jobPlace
            // 
            this.jobPlace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jobPlace.HeaderText = "Puesto";
            this.jobPlace.Name = "jobPlace";
            this.jobPlace.ReadOnly = true;
            // 
            // employCountJob
            // 
            this.employCountJob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employCountJob.HeaderText = "Cantidad de empleados por puesto";
            this.employCountJob.Name = "employCountJob";
            this.employCountJob.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(285, 141);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(152, 41);
            this.button1.TabIndex = 54;
            this.button1.Text = "Ordenar por:";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HDCOUNTER_CB_orderOption
            // 
            this.HDCOUNTER_CB_orderOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.HDCOUNTER_CB_orderOption.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HDCOUNTER_CB_orderOption.FormattingEnabled = true;
            this.HDCOUNTER_CB_orderOption.Items.AddRange(new object[] {
            "Departamento",
            "Puesto"});
            this.HDCOUNTER_CB_orderOption.Location = new System.Drawing.Point(403, 151);
            this.HDCOUNTER_CB_orderOption.Name = "HDCOUNTER_CB_orderOption";
            this.HDCOUNTER_CB_orderOption.Size = new System.Drawing.Size(422, 21);
            this.HDCOUNTER_CB_orderOption.TabIndex = 54;
            this.HDCOUNTER_CB_orderOption.SelectedIndexChanged += new System.EventHandler(this.HDCOUNTER_CB_orderOption_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(1, 185);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 3);
            this.panel4.TabIndex = 40;
            // 
            // FormHeadCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(980, 710);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.HDCOUNTER_CB_orderOption);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HDCOUNTER_DGV_table);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HDCOUNTER_Title);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHeadCounter";
            this.Text = "FormHeadCounter";
            this.Load += new System.EventHandler(this.FormHeadCounter_Load);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.HDCOUNTER_FilterOptions.ResumeLayout(false);
            this.HDCOUNTER_FilterOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HDCOUNTER_DGV_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HDCOUNTER_Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox HDCOUNTER_ComboBoxDep;
        private System.Windows.Forms.DataGridView HDCOUNTER_DGV_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn employCountDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPlace;
        private System.Windows.Forms.DataGridViewTextBoxColumn employCountJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel HDCOUNTER_FilterOptions;
        private System.Windows.Forms.DateTimePicker HDCOUNTER_DTP_Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button HDCOUNTER_Filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox HDCOUNTER_CB_orderOption;
        private System.Windows.Forms.Panel panel4;
    }
}