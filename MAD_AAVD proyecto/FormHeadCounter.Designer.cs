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
            this.HDCOUNTER_Filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HDCOUNTER_CB_Departamento = new System.Windows.Forms.ComboBox();
            this.HDCOUNTER_DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ADMIN_DGV_DepartamentoCant = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CantPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADMIN_DGV_PuestoCant = new System.Windows.Forms.DataGridView();
            this.Depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantEmpDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.HDCOUNTER_FilterOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADMIN_DGV_DepartamentoCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADMIN_DGV_PuestoCant)).BeginInit();
            this.SuspendLayout();
            // 
            // HDCOUNTER_Title
            // 
            this.HDCOUNTER_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HDCOUNTER_Title.AutoSize = true;
            this.HDCOUNTER_Title.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDCOUNTER_Title.Location = new System.Drawing.Point(499, 17);
            this.HDCOUNTER_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HDCOUNTER_Title.Name = "HDCOUNTER_Title";
            this.HDCOUNTER_Title.Size = new System.Drawing.Size(292, 57);
            this.HDCOUNTER_Title.TabIndex = 1;
            this.HDCOUNTER_Title.Text = "Headcounter";
            this.HDCOUNTER_Title.Click += new System.EventHandler(this.HDCOUNTER_Title_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Location = new System.Drawing.Point(-1, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 4);
            this.panel2.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.HDCOUNTER_FilterOptions);
            this.panel5.Location = new System.Drawing.Point(1, 114);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1309, 76);
            this.panel5.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 4);
            this.panel1.TabIndex = 51;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 342);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1309, 4);
            this.panel3.TabIndex = 40;
            // 
            // HDCOUNTER_FilterOptions
            // 
            this.HDCOUNTER_FilterOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.HDCOUNTER_FilterOptions.Controls.Add(this.HDCOUNTER_Filter);
            this.HDCOUNTER_FilterOptions.Controls.Add(this.label1);
            this.HDCOUNTER_FilterOptions.Controls.Add(this.HDCOUNTER_CB_Departamento);
            this.HDCOUNTER_FilterOptions.Controls.Add(this.HDCOUNTER_DTP_Date);
            this.HDCOUNTER_FilterOptions.Controls.Add(this.label5);
            this.HDCOUNTER_FilterOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.HDCOUNTER_FilterOptions.Location = new System.Drawing.Point(0, 0);
            this.HDCOUNTER_FilterOptions.Margin = new System.Windows.Forms.Padding(4);
            this.HDCOUNTER_FilterOptions.Name = "HDCOUNTER_FilterOptions";
            this.HDCOUNTER_FilterOptions.Size = new System.Drawing.Size(1309, 87);
            this.HDCOUNTER_FilterOptions.TabIndex = 47;
            // 
            // HDCOUNTER_Filter
            // 
            this.HDCOUNTER_Filter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HDCOUNTER_Filter.FlatAppearance.BorderSize = 0;
            this.HDCOUNTER_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HDCOUNTER_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HDCOUNTER_Filter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HDCOUNTER_Filter.Location = new System.Drawing.Point(887, 18);
            this.HDCOUNTER_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.HDCOUNTER_Filter.Name = "HDCOUNTER_Filter";
            this.HDCOUNTER_Filter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HDCOUNTER_Filter.Size = new System.Drawing.Size(151, 38);
            this.HDCOUNTER_Filter.TabIndex = 69;
            this.HDCOUNTER_Filter.Text = "Filtrar";
            this.HDCOUNTER_Filter.UseVisualStyleBackColor = false;
            this.HDCOUNTER_Filter.Click += new System.EventHandler(this.HDCOUNTER_Filter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(468, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Departamento: ";
            // 
            // HDCOUNTER_CB_Departamento
            // 
            this.HDCOUNTER_CB_Departamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.HDCOUNTER_CB_Departamento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HDCOUNTER_CB_Departamento.FormattingEnabled = true;
            this.HDCOUNTER_CB_Departamento.Location = new System.Drawing.Point(627, 22);
            this.HDCOUNTER_CB_Departamento.Margin = new System.Windows.Forms.Padding(4);
            this.HDCOUNTER_CB_Departamento.Name = "HDCOUNTER_CB_Departamento";
            this.HDCOUNTER_CB_Departamento.Size = new System.Drawing.Size(231, 24);
            this.HDCOUNTER_CB_Departamento.TabIndex = 54;
            this.HDCOUNTER_CB_Departamento.SelectedIndexChanged += new System.EventHandler(this.HDCOUNTER_CB_orderOption_SelectedIndexChanged);
            // 
            // HDCOUNTER_DTP_Date
            // 
            this.HDCOUNTER_DTP_Date.CustomFormat = "MMM/yyyy";
            this.HDCOUNTER_DTP_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HDCOUNTER_DTP_Date.Location = new System.Drawing.Point(317, 23);
            this.HDCOUNTER_DTP_Date.Margin = new System.Windows.Forms.Padding(4);
            this.HDCOUNTER_DTP_Date.Name = "HDCOUNTER_DTP_Date";
            this.HDCOUNTER_DTP_Date.Size = new System.Drawing.Size(121, 22);
            this.HDCOUNTER_DTP_Date.TabIndex = 6;
            this.HDCOUNTER_DTP_Date.ValueChanged += new System.EventHandler(this.HDCOUNTER_DTP_Date_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightBlue;
            this.label5.Location = new System.Drawing.Point(215, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mes/año:";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(1, 187);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1309, 4);
            this.panel4.TabIndex = 40;
            // 
            // ADMIN_DGV_DepartamentoCant
            // 
            this.ADMIN_DGV_DepartamentoCant.AllowUserToAddRows = false;
            this.ADMIN_DGV_DepartamentoCant.AllowUserToDeleteRows = false;
            this.ADMIN_DGV_DepartamentoCant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ADMIN_DGV_DepartamentoCant.BackgroundColor = System.Drawing.Color.Black;
            this.ADMIN_DGV_DepartamentoCant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADMIN_DGV_DepartamentoCant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Depto,
            this.CantEmpDepto});
            this.ADMIN_DGV_DepartamentoCant.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.ADMIN_DGV_DepartamentoCant.Location = new System.Drawing.Point(39, 623);
            this.ADMIN_DGV_DepartamentoCant.Margin = new System.Windows.Forms.Padding(4);
            this.ADMIN_DGV_DepartamentoCant.Name = "ADMIN_DGV_DepartamentoCant";
            this.ADMIN_DGV_DepartamentoCant.ReadOnly = true;
            this.ADMIN_DGV_DepartamentoCant.RowHeadersWidth = 51;
            this.ADMIN_DGV_DepartamentoCant.Size = new System.Drawing.Size(1197, 236);
            this.ADMIN_DGV_DepartamentoCant.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel6.Location = new System.Drawing.Point(0, 609);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1309, 4);
            this.panel6.TabIndex = 40;
            // 
            // CantPuesto
            // 
            this.CantPuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CantPuesto.HeaderText = "Cantidad de empleados";
            this.CantPuesto.MinimumWidth = 6;
            this.CantPuesto.Name = "CantPuesto";
            this.CantPuesto.ReadOnly = true;
            // 
            // Puesto
            // 
            this.Puesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Puesto.HeaderText = "Puesto";
            this.Puesto.MinimumWidth = 6;
            this.Puesto.Name = "Puesto";
            this.Puesto.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.MinimumWidth = 6;
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // ADMIN_DGV_PuestoCant
            // 
            this.ADMIN_DGV_PuestoCant.AllowUserToAddRows = false;
            this.ADMIN_DGV_PuestoCant.AllowUserToDeleteRows = false;
            this.ADMIN_DGV_PuestoCant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ADMIN_DGV_PuestoCant.BackgroundColor = System.Drawing.Color.Black;
            this.ADMIN_DGV_PuestoCant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADMIN_DGV_PuestoCant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departamento,
            this.Puesto,
            this.CantPuesto});
            this.ADMIN_DGV_PuestoCant.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.ADMIN_DGV_PuestoCant.Location = new System.Drawing.Point(39, 206);
            this.ADMIN_DGV_PuestoCant.Margin = new System.Windows.Forms.Padding(4);
            this.ADMIN_DGV_PuestoCant.Name = "ADMIN_DGV_PuestoCant";
            this.ADMIN_DGV_PuestoCant.ReadOnly = true;
            this.ADMIN_DGV_PuestoCant.RowHeadersWidth = 51;
            this.ADMIN_DGV_PuestoCant.Size = new System.Drawing.Size(1197, 388);
            this.ADMIN_DGV_PuestoCant.TabIndex = 47;
            this.ADMIN_DGV_PuestoCant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HDCOUNTER_DGV_table_CellContentClick);
            // 
            // Depto
            // 
            this.Depto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Depto.HeaderText = "Departamento";
            this.Depto.MinimumWidth = 6;
            this.Depto.Name = "Depto";
            this.Depto.ReadOnly = true;
            // 
            // CantEmpDepto
            // 
            this.CantEmpDepto.HeaderText = "Cantidad de empleados";
            this.CantEmpDepto.MinimumWidth = 6;
            this.CantEmpDepto.Name = "CantEmpDepto";
            this.CantEmpDepto.ReadOnly = true;
            // 
            // FormHeadCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1307, 874);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ADMIN_DGV_DepartamentoCant);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ADMIN_DGV_PuestoCant);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HDCOUNTER_Title);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHeadCounter";
            this.Text = "FormHeadCounter";
            this.Load += new System.EventHandler(this.FormHeadCounter_Load);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.HDCOUNTER_FilterOptions.ResumeLayout(false);
            this.HDCOUNTER_FilterOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADMIN_DGV_DepartamentoCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADMIN_DGV_PuestoCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HDCOUNTER_Title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView ADMIN_DGV_DepartamentoCant;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel HDCOUNTER_FilterOptions;
        private System.Windows.Forms.Button HDCOUNTER_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HDCOUNTER_CB_Departamento;
        private System.Windows.Forms.DateTimePicker HDCOUNTER_DTP_Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridView ADMIN_DGV_PuestoCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantEmpDepto;
    }
}